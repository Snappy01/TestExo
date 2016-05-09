using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;

namespace TestExo
{
    public class Socket
    {


        public TcpClient client;
        public UDPDiscovery Discovery;

        public Socket()
        { 
        

       
        
        
        }

        public string Connect(string server, string device)
        {
          
          
           string test = null;
           string temp = null; 
           string temp1 = null;
           string message = null;
            /////////////////////////////////////////////////////////////////////
           
             
            

            
////////////////////////////////////////////////////////////////////

            try
            {



                client = new TcpClient(server, 41795);

                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
               //Thread.Sleep(1000);


                NetworkStream stream = client.GetStream();


                stream.Write(data, 0, data.Length);



                
                //Console.WriteLine("Sent: {0}", message);


                data = new Byte[1000];


                String responseData = String.Empty;
                Thread.Sleep(1000);

                Int32 bytes = stream.Read(data, 0, data.Length);

                responseData = Encoding.ASCII.GetString(data, 0, bytes);
                test = responseData;

                temp = test.Substring(test.IndexOf(">")+1);
                temp1 = temp.Remove(temp.LastIndexOf(Environment.NewLine));

                //Console.WriteLine(temp1+Environment.NewLine);

                message = "";
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            return temp1;

        }



    }
}
