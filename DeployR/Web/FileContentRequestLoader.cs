﻿using System.Net;

namespace DeployR.Web
{
    internal class FileContentRequestLoader
    {
        public static string DownloadString(string requestUri)
        {
            WebClient webClient = new WebClient();
            return webClient.DownloadString(requestUri);
        }
    }
}