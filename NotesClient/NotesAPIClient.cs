using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace NotesClient
{

    public class NotesAPIClient
    {
        public static void Main(string[] args)
        {

        }

        const string BaseUrl = "http://timesheet-1172.appspot.com/f73c7de1/notes";

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();
            //check the BaseUrl
            client.BaseUrl = new Uri(BaseUrl);
            var response = client.Execute<T>(request);

            return response.Data;

        }

        public class Note
        {
            public Note(string json)
            {
                JObject jNote = JObject.Parse(json);

                description = (string)jNote["description"];
                id = (string)jNote["id"];
                title = (string)jNote["title"];

            }

            public Note()
            {
            }

            public string description { get; set; }
            public string id { get; set; }
            public string title { get; set; }
        }

        public Note GetNote(string id)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = id;
           // request.RootElement = "notes";
            request.AddParameter(id, ParameterType.UrlSegment);

            return Execute<Note>(request);
        }

        public Note CreateNote( string title, string description)
        {
            var objectToSerialize = new Note
            {
                title = title,
                description = description
            };
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(objectToSerialize);

            return Execute<Note>(request);

        }

        public List<Note> GetAllNotes()
        {
            var request = new RestRequest();

            return Execute<List<Note>>(request);
        }

        public Note UpdateNote(string id, string title, string description)
        {
            var objectToSerialize = new Note
            {
                title = title,
                description = description
            };

            var request = new RestRequest(Method.PUT);
            request.Resource = id;
            request.AddJsonBody(objectToSerialize);
            //request.Resource = id;
            // request.RootElement = "notes";
            //request.AddParameter(id, ParameterType.UrlSegment);

            return Execute<Note>(request);
        }

        public Note DeleteNote(string id)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = id;

            request.AddParameter(id, ParameterType.UrlSegment);

            return Execute<Note>(request);
        }

        public bool XDeleteNote(string id)
        {
            var client = new RestClient();

            client.BaseUrl = new Uri(BaseUrl);
            var request = new RestRequest(Method.DELETE);
            request.Resource = id;
            var response = client.Execute(request);

            bool deleteSuccess = false;

            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                deleteSuccess = true;
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
            {
                deleteSuccess = false;
            }

            return deleteSuccess;
        }
    }

    
}
