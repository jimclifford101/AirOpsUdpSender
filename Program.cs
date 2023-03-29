

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

            string[] sIWGMsgArray = new string[12];

            sIWGMsgArray[0] = "IWG1,2023-03-14T23:17:55Z,39.990847,-105.224955,1618.056030,,,0.000000,,,,,,270.000008,,,,,,,,,,,,,,,,,,,";
            sIWGMsgArray[1] = "IWG1,2023-03-14T23:17:56Z,39.990847,-106.224955,1618.050781,,,0.000000,,,,,,270.000008,,,,,,,,,,,,,,,,,,,";
            sIWGMsgArray[2] = "IWG1,2023-03-14T23:17:58Z,39.990847,-107.224955,1618.050781,,,0.000000,,,,,,270.000008,,,,,,,,,,,,,,,,,,,";
            sIWGMsgArray[3] = "IWG1,2023-03-14T23:17:58Z,39.990847,-108.224955,1618.050781,,,0.000000,,,,,,270.000008,,,,,,,,,,,,,,,,,,,";
            sIWGMsgArray[4] = "IWG1,2023-03-14T23:17:59Z,39.990847,-109.224955,1618.048096,,,0.000000,,,,,,270.000008,,,,,,,,,,,,,,,,,,,";
            sIWGMsgArray[5] = "IWG1,2023-03-14T23:18:01Z,39.990847,-110.224955,1618.050781,,,0.000000,,,,,,270.000008,,,,,,,,,,,,,,,,,,,";
            sIWGMsgArray[6] = "IWG1,2023-03-14T23:18:01Z,39.990847,-111.224955,1618.050781,,,0.000000,,,,,,270.000008,,,,,,,,,,,,,,,,,,,";
            sIWGMsgArray[7] = "IWG1,2023-03-14T23:18:02Z,39.990847,-112.224955,1618.050781,,,0.000000,,,,,,270.000008,,,,,,,,,,,,,,,,,,,";
            sIWGMsgArray[8] = "IWG1,2023-03-14T23:18:04Z,39.990847,-113.224955,1618.050781,,,0.000000,,,,,,270.000008,,,,,,,,,,,,,,,,,,,";
            sIWGMsgArray[9] = "IWG1,2023-03-14T23:18:05Z,39.990847,-114.224955,1618.050781,,,0.000000,,,,,,270.000008,,,,,,,,,,,,,,,,,,,";
            sIWGMsgArray[10] = "IWG1,2023-03-14T23:18:0Z,39.990847,-115.224955,1618.048096,,,0.000000,,,,,,270.000008,,,,,,,,,,,,,,,,,,,";
            sIWGMsgArray[11] = "IWG1,2023-03-14T23:18:0Z,39.990847,-116.224955,1618.050781,,,0.000000,,,,,,270.000008,,,,,,,,,,,,,,,,,,,";

            try
            {
                using (var client = new UdpClient())
                {

                   
                    for (int i = 0; i < 12; i++)
                    {
                        byte[] StringAsBytes = Encoding.ASCII.GetBytes(sIWGMsgArray[i]);
                   
                        client.Send(StringAsBytes, StringAsBytes.Length, "127.0.0.1", 10645);
                        //client.Send(StringAsBytes, StringAsBytes.Length, "10.10.16.31", 10645);

                        Console.WriteLine("IWG MSG Sent! i: " + i.ToString());
                        Console.WriteLine("");

                        Thread.Sleep(5000); //wait 8 seconds

                    }
                   

                    Console.WriteLine("IWG udpSender Done!!!");
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












