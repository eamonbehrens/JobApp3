using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp.API.DTO
{
    public class PhotosForDetailedDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Descripton { get; set; }

        public DateTime DateAddded { get; set; }
        public bool IsMain { get; set; }
    }
}
