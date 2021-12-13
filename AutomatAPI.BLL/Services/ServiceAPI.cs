using Automat.BLL.Interfaces;
using Automat.Models.Entities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Automat.BLL.Services
{
    public class ServiceAPI : IServiceAPI
	{
		private readonly HttpClient _httpClient;
		private readonly string _url;
		private readonly string _Id;

		public ServiceAPI(HttpClient httpClient, IConfiguration config)
		{
			_httpClient = httpClient;
			_url = config.GetSection("FruitApiOptions")["Url"];
			_Id = config.GetSection("FruitApiOptions")["Id"];
		}

		public async Task<List<Composition>> GetAll()
		{
			string url = $"{_url}/fdc/v1/foods/search?query=apple&pageSize=2&api_key={_Id}";
			var response = await _httpClient.GetAsync(url);			
			string strbody = await response.Content.ReadAsStringAsync();			
			List<Composition> newN = JsonConvert.DeserializeObject<List<Composition>>(strbody);
						
			return newN;
		}


		public async Task<List<Composition>> GetProductComposition(string product)
		{
			string url = $"{_url}{product}";
			HttpRequestMessage _request = new HttpRequestMessage();
			_request.RequestUri = new Uri(url);
			_request.Method = HttpMethod.Get;
			_request.Headers.Add("x-api-key", "HCq2WxFCSYmNileHmryLbQ==m9zMCDoKvUw0BcGx");
			HttpResponseMessage response = await _httpClient.SendAsync(_request);			
			var responseString = await response.Content.ReadAsStringAsync();

			Comp datalist = JsonConvert.DeserializeObject<Comp>(responseString);

			int s = datalist.items.Count;

			return datalist.items;
		}

	}
}
