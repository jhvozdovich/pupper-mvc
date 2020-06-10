using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PupperMvc.Models
{
  public class Doggo
  {
    public int DoggoId { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }

    public string PicUrl { get; set; }
    public string Gender { get; set; }


    public static List<Doggo> GetAll()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Doggo> doggoList = JsonConvert.DeserializeObject<List<Doggo>>(jsonResponse.ToString());

      return doggoList;
    }

    public static Doggo GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Doggo doggo = JsonConvert.DeserializeObject<Doggo>(jsonResponse.ToString());

      return doggo;
    }

    public static void Post(Doggo doggo)
    {
      string jsonDoggo = JsonConvert.SerializeObject(doggo);
      var apiCallTask = ApiHelper.Post(jsonDoggo);
    }

    public static void Delete(int id)
    {

    }

    public static void Put(Doggo doggo)
    {

    }
  }
}