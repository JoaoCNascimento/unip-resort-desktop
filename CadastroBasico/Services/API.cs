using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoUnipResort.Services
{
    class API
    {
        public string URL = "http://localhost:3000";

        public string getMethod(string route)
        {
            try
            {
                string jsonString = "";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.URL + "/" + route);
                request.Method = "GET";
                request.Credentials = CredentialCache.DefaultCredentials;
                ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
                request.Accept = "/";
                request.UseDefaultCredentials = true;
                request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                request.ContentType = "application/x-www-form-urlencoded";

                WebResponse response = request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                jsonString = sr.ReadToEnd();
                sr.Close();
                return jsonString;
            }
            catch (Exception er)
            {
                MessageBox.Show("Houve um erro ao tentar se conectar ao servidor, verifique a sua conexão ou se o servidor está funcionando e tente novamente.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return "";
        }

        public string postMethod(string route, string json)
        {
            try
            {
                string responseFromServer = "";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.URL + "/" + route);
                request.Method = "POST";
                request.Credentials = CredentialCache.DefaultCredentials;
                ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
                request.Accept = "/";
                request.UseDefaultCredentials = true;
                request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                byte[] byteArray = Encoding.UTF8.GetBytes(json);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
                return responseFromServer;
            }
            catch(Exception er)
            {
                MessageBox.Show("Houve um erro ao tentar se conectar ao servidor, verifique a sua conexão ou se o servidor está funcionando e tente novamente.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return "";
        }

        public string put(string route, string json)
        {
            return "";
        }

        public string delete(string route, string json)
        {
            return "";
        }
    }
}
