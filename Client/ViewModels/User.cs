﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Client.ViewModels
{
    public partial class User
    {
        public User()
        {
          
        }

        public long UserId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Source { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePictureUrl { get; set; }
        public byte[] DateOfBirth { get; set; }
        public string AboutMe { get; set; }
        public long? Notifications { get; set; }
        public long? DarkTheme { get; set; }
        public byte[] CreatedDate { get; set; }
        public string ProfilePicDataUrl { get; set; }      
    }
}