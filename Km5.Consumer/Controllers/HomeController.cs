using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Km5Store.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Diagnostics;

namespace Km5.Consumer.Controllers
{
	public class HomeController : Controller
    {
		private Stopwatch watch = new Stopwatch();
		private TimeSpan ellapsed1 = new TimeSpan();
		private TimeSpan ellapsed2 = new TimeSpan();
		private string baseURL1 = "http://km5store.azurewebsites.net/api/";
		private string baseURL2 = "http://km5store2.azurewebsites.net/api/";

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Artists()
        {
			List<Artist> artistList = new List<Artist>();
			watch.Reset();
			watch.Start();
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(baseURL1);
				client.DefaultRequestHeaders.Accept.Clear();
				var response = await client.GetAsync(baseURL1+"Artists");
				if (response.IsSuccessStatusCode)
				{
					var responseJson = await response.Content.ReadAsStringAsync();
					//do something with the response here. Typically use JSON.net to deserialise it and work with it

					artistList = JsonConvert.DeserializeObject<List<Artist>>(responseJson);
				}
			}
			watch.Stop();
			ellapsed1 = watch.Elapsed;
			watch.Reset();
			
			watch.Start();
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(baseURL2);
				client.DefaultRequestHeaders.Accept.Clear();
				var response = await client.GetAsync(baseURL2+"Artists");
				if (response.IsSuccessStatusCode)
				{
					var responseJson = await response.Content.ReadAsStringAsync();
					//do something with the response here. Typically use JSON.net to deserialise it and work with it

					artistList = JsonConvert.DeserializeObject<List<Artist>>(responseJson);
				}
			}
			watch.Stop();
			ellapsed2 = watch.Elapsed;
			watch.Reset();

			if (ellapsed1.CompareTo(ellapsed2)>0)
			{
				ViewData["Winner"] = baseURL2;
				ViewData["Ellapsed"] = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ellapsed2.Hours, ellapsed2.Minutes, ellapsed2.Seconds, ellapsed2.Milliseconds / 10);
			}
			else
			{
				ViewData["Winner"] = baseURL1;
				ViewData["Ellapsed"] = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ellapsed1.Hours, ellapsed1.Minutes, ellapsed1.Seconds, ellapsed1.Milliseconds / 10);
			}

			ViewData["Message"] = "This is our artists collection";

            return View(artistList);
        }

		public async Task<IActionResult> Albums(string id, string artistName)
        {
			List<Album> albums = new List<Album>();
			if (artistName != null && id!=null)
			{
				ViewData["Message"] = "Showing all albums by "+artistName;
				watch.Reset();
				watch.Start();
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri(baseURL1);
					client.DefaultRequestHeaders.Accept.Clear();
					var response = await client.GetAsync(baseURL1 + "Albums?artistId="+id);
					if (response.IsSuccessStatusCode)
					{
						var responseJson = await response.Content.ReadAsStringAsync();
						albums = JsonConvert.DeserializeObject<List<Album>>(responseJson);
					}
				}
				watch.Stop();
				ellapsed1 = watch.Elapsed;
				watch.Reset();

				watch.Start();
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri(baseURL2);
					client.DefaultRequestHeaders.Accept.Clear();
					var response = await client.GetAsync(baseURL2 + "Albums&artistId=" + id);
					if (response.IsSuccessStatusCode)
					{
						var responseJson = await response.Content.ReadAsStringAsync();
						albums = JsonConvert.DeserializeObject<List<Album>>(responseJson);
					}
				}
				watch.Stop();
				ellapsed2 = watch.Elapsed;
				watch.Reset();
			}
			else
			{
				ViewData["Message"] = "This is our albums collection.";
				
				watch.Reset();
				watch.Start();
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri(baseURL1);
					client.DefaultRequestHeaders.Accept.Clear();
					var response = await client.GetAsync(baseURL1 + "Albums");
					if (response.IsSuccessStatusCode)
					{
						var responseJson = await response.Content.ReadAsStringAsync();
						albums = JsonConvert.DeserializeObject<List<Album>>(responseJson);
					}
				}
				watch.Stop();
				ellapsed1 = watch.Elapsed;
				watch.Reset();

				watch.Start();
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri(baseURL2);
					client.DefaultRequestHeaders.Accept.Clear();
					var response = await client.GetAsync(baseURL2 + "Albums");
					if (response.IsSuccessStatusCode)
					{
						var responseJson = await response.Content.ReadAsStringAsync();
						albums = JsonConvert.DeserializeObject<List<Album>>(responseJson);
					}
				}
				watch.Stop();
				ellapsed2 = watch.Elapsed;
				watch.Reset();
			}


			if (ellapsed1.CompareTo(ellapsed2) > 0)
			{
				ViewData["Winner"] = baseURL2;
				ViewData["Ellapsed"] = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ellapsed2.Hours, ellapsed2.Minutes, ellapsed2.Seconds, ellapsed2.Milliseconds / 10);
			}
			else
			{
				ViewData["Winner"] = baseURL1;
				ViewData["Ellapsed"] = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ellapsed1.Hours, ellapsed1.Minutes, ellapsed1.Seconds, ellapsed1.Milliseconds / 10);
			}
			return View(albums);
        }

        public IActionResult Error()
        {
            return View();
        }

		public async Task<IActionResult> Movies()
		{
			List<Movie> movies = new List<Movie>();
			watch.Reset();
			watch.Start();
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(baseURL1);
				client.DefaultRequestHeaders.Accept.Clear();
				var response = await client.GetAsync(baseURL1 + "Movies");
				if (response.IsSuccessStatusCode)
				{
					var responseJson = await response.Content.ReadAsStringAsync();
					//do something with the response here. Typically use JSON.net to deserialise it and work with it

					movies = JsonConvert.DeserializeObject<List<Movie>>(responseJson);
				}
			}
			watch.Stop();
			ellapsed1 = watch.Elapsed;
			watch.Reset();

			watch.Start();
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(baseURL2);
				client.DefaultRequestHeaders.Accept.Clear();
				var response = await client.GetAsync(baseURL2 + "Movies");
				if (response.IsSuccessStatusCode)
				{
					var responseJson = await response.Content.ReadAsStringAsync();
					//do something with the response here. Typically use JSON.net to deserialise it and work with it

					movies = JsonConvert.DeserializeObject<List<Movie>>(responseJson);
				}
			}
			watch.Stop();
			ellapsed2 = watch.Elapsed;
			watch.Reset();

			if (ellapsed1.CompareTo(ellapsed2) > 0)
			{
				ViewData["Winner"] = baseURL2;
				ViewData["Ellapsed"] = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ellapsed2.Hours, ellapsed2.Minutes, ellapsed2.Seconds, ellapsed2.Milliseconds / 10);
			}
			else
			{
				ViewData["Winner"] = baseURL1;
				ViewData["Ellapsed"] = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ellapsed1.Hours, ellapsed1.Minutes, ellapsed1.Seconds, ellapsed1.Milliseconds / 10);
			}

			ViewData["Message"] = "This is our movie store.";
			return View(movies);
		}
    }
}
