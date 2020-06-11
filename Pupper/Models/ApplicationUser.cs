using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PupperMvc.Models
{
  public class ApplicationUser : IdentityUser
  {
    public static ApplicationUser SignInByAPI(string UserName, string Password)
    {
      var apiCallTask = ApiHelper.AttemptLogin(UserName, Password);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      ApplicationUser user = JsonConvert.DeserializeObject<ApplicationUser>(jsonResponse.ToString());

      return user;
    }
  }
}