using System.Threading.Tasks;
using RestSharp;
using System;

namespace PupperMvc.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"Doggo", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Post(string newDoggo)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"Doggo", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newDoggo);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"Doggo/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"Doggo/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string newDoggo)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"Doggo/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newDoggo);
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}