using System;
using System.Collections.Generic;
using System.Linq;

namespace Km5Store.Models
{
	public class Album
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int Artist { get; set; }
		public string Url { get; set; }
		public string Image { get; set; }
		public string Listeners { get; set; }
		public string Playcount { get; set; }
	}
}