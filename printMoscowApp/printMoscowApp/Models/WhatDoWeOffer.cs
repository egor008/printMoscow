using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PrintMoscowApp.Models
{

    public class WhatDoWeOffer
	{
        public int Id { get; set; }
        public string Title { get; set; }
		public string Description { get; set; }
		public byte[] Image { get; set; }
        public string ImageMimeType { get; set; }
    }
}
