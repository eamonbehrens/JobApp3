﻿using System;

namespace JobApp.API.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Descripton { get; set; }

        public DateTime DateAddded { get; set; }
        public bool IsMain { get; set; }

        public string PublicID { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

    }
}