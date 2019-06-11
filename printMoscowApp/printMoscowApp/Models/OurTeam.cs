using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PrintMoscowApp.Models
{

    public class OurTeam
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
		public string Description { get; set; }
		public byte[] Image { get; set; }
        public string ImageMimeType { get; set; }
    }
}
