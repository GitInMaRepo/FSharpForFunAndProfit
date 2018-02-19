using System;
using System.IO;
using System.Net;

namespace AFewSimpleThingsFirst
{
    public class HtmlDownloaderCSharp
    {
        public string DownloadHtml(string url)
        {
            return DownloadHtmlCall(url, callback);
        }

        public string DownloadHtmlCall(string url, Func<StreamReader, string> callback)
        {
            var webRequest = WebRequest.Create(url);
            using (var response = webRequest.GetResponse())
            {
                using (var responseStream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(responseStream))
                    {
                        return callback(reader);
                    }
                }
            }
        }

        Func<StreamReader, string> callback = (StreamReader) =>
        {
            return StreamReader.ReadToEnd();
        };
    }
}