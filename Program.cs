

// dotnet publish -c Release
// dotnet new console -o "ConsoleApplciation2"


using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace udpsender
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("UDP Udpsender");
            Console.WriteLine("");           
            fUdpsender();


        }


        private static void fUdpsender() {

            var src = DateTime.Now;

            string sMyTimeStamp = "Time:" + src.Hour.ToString() + "_" + src.Minute.ToString() + "_" + src.Second.ToString();

            string sIWGMessage = "IWG1," + sMyTimeStamp + ",21.1653,-168.5142,,,,,,,,";

            byte[] StringAsBytes = Encoding.ASCII.GetBytes(sIWGMessage);

            try
            {
                using (var client = new UdpClient())
                {

                    client.Send(StringAsBytes, StringAsBytes.Length, "127.0.0.1", 10645);

                    Console.WriteLine("IWG MSG Sent! (Run again to send another msg)");
                    Console.WriteLine(""); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }

        

 
    }

}





