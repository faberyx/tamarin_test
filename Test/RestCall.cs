using System;
using RestSharp;

namespace Test
{
	public class RestCall
	{

		public string Endpoint { get; } = Constants.REST_SERVER_ADDR;

		public RestClient Client { get; set; }

		public RestCall()
		{
			this.Client = new RestClient(this.Endpoint)
			{
				//Authenticator = new HttpBasicAuthenticator(this.Username, this.Password)
			};
		}

		public string Request(string methodName)
		{
			var request = new RestRequest(methodName, Method.GET);

			return this.Client.Execute(request).Content;
		}
	}
}
