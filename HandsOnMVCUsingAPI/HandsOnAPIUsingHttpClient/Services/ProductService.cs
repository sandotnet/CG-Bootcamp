using HandsOnAPIUsingHttpClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace HandsOnAPIUsingHttpClient.Services
{
    public class ProductService : IProductService
    {
        public string Add(Product item)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://mywebsite.com/");
                var contentData = new StringContent(JsonConvert.SerializeObject(item),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("api/Product/Add", contentData).Result;
               return response.Content.ReadAsStringAsync().Result;
            }
        }

        public string Delete(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://mywebsite.com/");
                HttpResponseMessage response = client.DeleteAsync("api/Product/Delete/" + id).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }

        public Product Get(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://mywebsite.com/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("api/Product/GetById/"+id).Result;
                Product item = JsonConvert.DeserializeObject<Product>(response.Content.ReadAsStringAsync().Result);
                return item;
            }
        }

        public List<Product> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://mywebsite.com/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("api/Product/GetAll").Result;
                List<Product> list = JsonConvert.DeserializeObject<List<Product>>(response.Content.ReadAsStringAsync().Result);
                return list;
            }
        }

        public string Update(Product item)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://mywebsite.com/");
                var contentData = new StringContent(JsonConvert.SerializeObject(item),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync("api/Product/Update", contentData).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
