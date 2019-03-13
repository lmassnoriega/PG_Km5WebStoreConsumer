using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Km5Store.Models
{
	public class Album
	{
		[Required]
		public int ID { get; set; }
		public string Name { get; set; }
		public int Artist { get; set; }
		public string Url { get; set; }
		public string Image { get; set; }
		public string Listeners { get; set; }
		public string Playcount { get; set; }
		//public List<Track> Tracks { get; set; }
	}

	//public class Track
	//{
	//	public int TrackNumber { get; set; }
	//	public string TrackName { get; set; }
	//}
}