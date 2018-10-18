﻿using Microsoft.AspNetCore.Http;
using System;

namespace JobApp.API.DTO
{
    public class PhotoForCreationDto
    {
        public string Url { get; set; }
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicID { get; set; }

        public PhotoForCreationDto()
        {
            DateAdded = DateTime.Now;
        }
   

    }
}