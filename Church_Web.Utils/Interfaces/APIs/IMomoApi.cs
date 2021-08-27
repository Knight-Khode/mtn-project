using System.Net;

namespace Church_Web.Utils.Interfaces.APIs
{
    public interface IMomoApi
    { 
        public string getMoMoBal(string APP_USR, string APP_PWD);
        public void AttachClientCertificate(HttpWebRequest request, string userName, string certPath);
        public string GetResponse(string requestUri, string postData, string userName, string certPath);
        public string get_Token(string APP_USR, string APP_PWD);
    }
}
