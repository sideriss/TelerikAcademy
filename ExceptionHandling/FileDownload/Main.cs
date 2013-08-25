using System;
using System.Net;


class Program
{
    static void Main()
    {
        try
        {
            string remoteUrl = "http://www.devbg.org/img/Logo-BASD.jpg";
            string fileName = "Logo-BASD.jpg", myStringWebResource = null;

            // Create a new WebClient instance.
            using (WebClient myWebClient = new WebClient())
            {
                myStringWebResource = remoteUrl + fileName;
                // Download the Web resource and save it into the current filesystem folder.
                myWebClient.DownloadFile(remoteUrl, fileName);
            }
            Console.WriteLine("File suxefully downloaded !");
        }
        catch
        {
            Console.WriteLine("File is not downloaded sexefull !");
        }
        
    }
}