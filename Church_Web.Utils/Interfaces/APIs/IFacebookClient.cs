using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Church_Web.Utils.Interfaces.APIs
{
   public  interface IFacebookClient
    {
        string GetAsync(string accessToken, string endpoint, string args = null);
        Task PostAsync(string accessToken, string endpoint, object data, string args = null);
    }
}
