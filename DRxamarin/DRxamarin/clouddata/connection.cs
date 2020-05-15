using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DRxamarin.clouddata
{
	public class connection
	{
		public async Task<T> Get<T>()
		{
			try
			{
				HttpClient client = new HttpClient();
				var response = await client.GetAsync("http://192.168.1.108:5000/api/kategoriler/");
				if (response.StatusCode == System.Net.HttpStatusCode.OK)
				{ 
					var jsonstring = await response.Content.ReadAsStringAsync();
					return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonstring);
				}
			}
			catch
			{	}
			return default(T);
		}
		/*HttpClient client;
	    
		public connection()
		{
			client = new HttpClient();
			List<kategoriler> kategoris = new List<kategoriler>();
		}
	     public List<kategoriler> GetKategorilers()
		{
			List<kategoriler> kategorilistesi = null;
			var task = client.GetAsync("http://192.168.1.108:5000/api/kategoriler/").ContinueWith((taskResponse) =>
			  {
				  var response = taskResponse.Result;
				  var jsonString = response.Content.ReadAsStringAsync();
				  jsonString.Wait();
				  kategorilistesi = JsonConvert.DeserializeObject<List<kategoriler>>(jsonString.Result);
			  });
			task.Wait();
			return kategorilistesi;	/*var jsondata = task.Content.ReadAsStringAsync().Result;
			var root = JsonConvert.DeserializeObject<List<kategoriler>>(jsondata);
			return root;
		}*/
	}
}
