using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Timers;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace TestExo
{
   public class UDPDiscovery
    {

        static UdpClient Client;
        static IPEndPoint ServerEp;
        static string hh;
        static int index=0;
        public List<string> MaListe = new List<string>();
        ListBox test;
        public UDPDiscovery(ListBox ListF1) 
        {

            ServerEp = new IPEndPoint(IPAddress.Any, 41794);
            Client = new UdpClient(41794);
            Client.BeginReceive(new AsyncCallback(Udp_IncomingData), ServerEp);
            test = ListF1;
        }


        public void DiscoveryGo()
        {
            

            string header = "14:00:00:00:01:04:00:03:00:00:46:52:4c:54:2d:4d:42:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00";


            byte[] msg = header.Split(':').Select(s => Convert.ToByte(s, 16)).ToArray();
           
            var RequestData = msg;

           

            Client.EnableBroadcast = true;
            Client.Send(RequestData, RequestData.Length, new IPEndPoint(IPAddress.Broadcast, 41794));

            Thread.Sleep(500);
            
       

            for (int i = 0; i < MaListe.Count; ++i)
            {

                Console.WriteLine(MaListe[i]);

               
               // File.AppendAllText(@"C:\\Users\\MBOULHALFA\\Desktop\\discovery\\CHAO", MaListe[i], new UTF8Encoding());
            
            }
            
            index = 0;
            
        }

    
         void Udp_IncomingData(IAsyncResult ar)
        {
            ++index;
            
             var ServerResponseData = Client.EndReceive(ar, ref ServerEp);
            //Console.WriteLine(Encoding.UTF8.GetString(ServerResponseData));


            var ServerResponse = Encoding.UTF8.GetString(ServerResponseData);
            //hh = Regex.Replace(ServerResponse, @"\s\r\n?|\n", String.Empty);
           // hh = ServerResponse.Replace("\u0000", "").Replace("\u0001", "").Replace("\u0002", "").Replace("\u0003", "").Replace("\u0004", "").Replace("\u0014", "").Replace("\u0015", "").Replace(@"[^\u0000-\u007F]", "").ToString();
           // hh = Regex.Replace(ServerResponse.ToString(), @"[^\u0000-\u007F]","");
            hh = TrimNonAscii(ServerResponse.ToString());
             //hh = Regex.Replace(ServerResponse.ToString()," ",".");
            MaListe.Add(index+" > "+hh+"  [IP: "+ ServerEp.Address.ToString()+"]");

          
            
           
            
            Client.BeginReceive(new AsyncCallback(Udp_IncomingData), ServerEp);
        }

         public string TrimNonAscii(string value)
         {
             string pattern = "[^ -~]*";
             Regex reg_exp = new Regex(pattern);
             return reg_exp.Replace(value, "");
         }





    }
}
