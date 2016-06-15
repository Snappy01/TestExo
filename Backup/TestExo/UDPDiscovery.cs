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
       
        static int index=0;
        List<string> testip = new List<string>();
        public List<string> MaListeDevice = new List<string>();
        public List<Device> MesDevices = new List<Device>();
        string ad = Dns.GetHostName();
        public List<string> MaListeIpAddress = new List<string>();
        ListBox test;
        IPHostEntry myself;

        public UDPDiscovery(ListBox ListF1) 
        {
            
            ServerEp = new IPEndPoint(IPAddress.Any, 41794);
            Client = new UdpClient(41794);


            Client.BeginReceive(new AsyncCallback(Udp_IncomingData), ServerEp);
            test = ListF1;

            
            myself = Dns.GetHostEntry(ad);
            foreach (IPAddress address in myself.AddressList)
            {
                testip.Add(address.ToString());
                
            }
           
           


        }


        public void DiscoveryGo()
        {

            index = 0;
            string header = "14:00:00:00:01:04:00:03:00:00:46:52:4c:54:2d:4d:42:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00";
            
            byte[] msg = header.Split(':').Select(s => Convert.ToByte(s, 16)).ToArray();
           
            var RequestData = msg;

           

            Client.EnableBroadcast = true;
            Client.Send(RequestData, RequestData.Length, new IPEndPoint(IPAddress.Broadcast, 41794));

            Thread.Sleep(500);
            
       
            /*
            for (int i = 0; i < MaListeDevice.Count; ++i)
            {

                Console.WriteLine(MaListeDevice[i]);

               
               // File.AppendAllText(@"C:\\Users\\MBOULHALFA\\Desktop\\discovery\\CHAO", MaListe[i], new UTF8Encoding());
            
            }
             */
            
            index = 0;
            
        }

    
         void Udp_IncomingData(IAsyncResult ar)
        {
            
            string j,hstname,realname,hostname,namedev;
            byte b = 0;
            

            var ServerResponseData = Client.EndReceive(ar, ref ServerEp);

            var ServerResponse = Encoding.UTF8.GetString(ServerResponseData);
           
            //hh = TrimNonAscii(ServerResponse.ToString());



            j = ServerEp.Address.ToString();
            try
            {
                if (ServerResponseData.Length > 186 && !testip.Contains(j))
                {
                    hostname = Encoding.UTF8.GetString(ServerResponseData, 10, Array.IndexOf(ServerResponseData, b, 11));
                    namedev = Encoding.UTF8.GetString(ServerResponseData, 186, Array.IndexOf(ServerResponseData, b, 187));//Name Device
                    hstname = TrimNonAscii(hostname);
                    realname = TrimNonAscii(namedev);
                    
                    Device nDevice = new Device(index + " > " + hstname, j, realname);

                    if (!MesDevices.Contains(nDevice))
                    {
                        ++index;
                        MesDevices.Add(nDevice);

                    }
                
                }
                }
            catch ( Exception e)
            {
                //Console.WriteLine(e.Message);
            }

           
                     
           
                
            
            

            //foreach (string s in testip)
            //{

            //    if (!ServerEp.Address.ToString().Contains(s))
            //    {
            //        Console.WriteLine(ServerEp.Address.ToString());
            //        ;


            //    }

                
            
            
            //}



           // MaListeDevice.Add(index + " > " + hh);
            //MaListeIpAddress.Add(ServerEp.Address.ToString());

            
            
            
            
            Client.BeginReceive(new AsyncCallback(Udp_IncomingData), ServerEp);
        }

         public string TrimNonAscii(string value)
         {
             string pattern = "[^ -~]*";
             Regex reg_exp = new Regex(pattern);
             return reg_exp.Replace(value, "");
         }

       
    }

   public class Device 
   
   
  {

       public string dev{get;set;}
       public string ip { get; set; }
       public string name { get; set; }



       public Device(string dev, string ip,string name)
       {

           this.dev = dev;    // this.dev because we talk about "dev" de la class Device
           this.ip = ip;
           this.name = name;
       }
       
       public override string ToString()
       {
           string j;

           //j = String.Format("{0} at {1} [Device : {2}", dev, ip,name);
           j = String.Format("{0} at {1} ", dev, ip);

           return j;


       }

       public override bool Equals(Object obj)
       {
           try
           {
               Device tmp = (Device)obj;
               return this.ip.Equals(tmp.ip);
           }
           catch
           {

               return false;
           }
       }

       public override int GetHashCode()
       {
           return base.GetHashCode();
       }
        
   
   }
}
