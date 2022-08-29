using InvokeAPIUsingHttpClinet.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace InvokeAPIUsingHttpClinet.Services
{
    public class ProductService : IProductService
    {
        string url_path = "https://localhost:44365/";
        public void Add(Product item)
        {
           using(HttpClient client=new HttpClient())
            {
                client.BaseAddress = new Uri(url_path);
                //convert object data to json
                var contentData = new StringContent(JsonConvert.SerializeObject(item),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("api/Product/Add", contentData).Result;
            }
        }

      

        public Product Get(int Id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url_path);
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("api/Product/GetById/"+Id).Result;
                Product item = JsonConvert.DeserializeObject<Product>(response.Content.ReadAsStringAsync().Result);
                return item;
            }
        }

        public List<Product> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44365/"); //rest api path
                MediaTypeWithQualityHeaderValue contentType =new MediaTypeWithQualityHeaderValue("application/json"); //response type
                client.DefaultRequestHeaders.Accept.Add(contentType); //add media-type to request header
                HttpResponseMessage response = client.GetAsync("api/Product/GetAll").Result; //return json data
                //converting json data into list
                List<Product> list = JsonConvert.DeserializeObject<List<Product>>(response.Content.ReadAsStringAsync().Result);
                return list;
            }
        }

        public void Update(Product item)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44365/");
                //convert Product into Json data
                var contentData = new StringContent(JsonConvert.SerializeObject(item),
                    System.Text.Encoding.UTF8, "application/json"); 
                HttpResponseMessage response = client.PutAsync("api/Product/Update", contentData).Result;
            }
        }
        public void Delete(int Id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url_path);
                HttpResponseMessage response = client.DeleteAsync("api/Product/Delete/"+Id).Result;
            }
        }
    }
}
