using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Km5Store.Models
{
	public class Artist
	{
		[Required]
		public int ID { get; set; }
		public string name { get; set; }
		public string url { get; set; }
		public string image { get; set; }
		public string bio { get; set; }
	}
}