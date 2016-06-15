using System;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace TestExo
{
    public class Socket
    {


        private TcpClient client;
        public Form1 Ui;
        public string mydev { get; set; }
        public string ipdev { get; set; }
        string cr = Environment.NewLine;
        List<string> MaListControlSystem3series = new List<string> { "CP3","CP3N","DIN-AP3","DIN-AP3MEX", "MC3", "AV3", "PRO3", "RMC3","DMPS" };
        List<string> MaListControlSystem2series = new List<string> {"DIN-AP2", "MC2E", "CP2E", "AV2", "PRO2"};
        List<string> MaListTouchPanel = new List<string> { "TSW", "TSS", "TST" };
        List<string> MaListDGE = new List<string> { "DGE" };
        List<string> MaListSWAMP = new List<string> { "SWAMP" };



        public Socket(Form1 f)
        {
            
            Ui = f;

           
        }

        public string Connect(string server, string message)
        {

            TimeSpan timeout = TimeSpan.FromSeconds(2);

            string test = null;
            string temp = null;
            string temp1 = null;



            try
            {



                client = new TcpClient(server, 41795);

                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
           
                NetworkStream stream = client.GetStream();


                stream.Write(data, 0, data.Length);




                //Console.WriteLine("Sent: {0}", message);


                data = new Byte[5000];


                String responseData = String.Empty;
                var start = DateTime.Now;
                while (DateTime.Now.Subtract(start) < timeout) { }
               // Thread.Sleep(1000);

                Int32 bytes = stream.Read(data, 0, data.Length);

                responseData = Encoding.ASCII.GetString(data, 0, bytes);
                test = responseData;

                temp = test.Substring(test.IndexOf(">") + 1);
                if (temp.Contains(Environment.NewLine))
                    temp1 = temp.Remove(temp.LastIndexOf(Environment.NewLine));

                Console.WriteLine(temp1+Environment.NewLine);

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

           // Ui.Result.Text = temp;

            return temp;

        }


        public bool SendCommandDev()
        {

          
            // if (mydev.Contains("CP3")||mydev.Contains("DMPS3"))
            if(MaListControlSystem3series.Any(mydev.Contains))
            {

                Ui.Result.Text = "Hostname"+ cr + Connect(ipdev, "Hostname\r");
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[MyCrestron]"+cr+ Connect(ipdev, "mycrestron\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[SHOWHW]"+ cr + Connect(ipdev, "showhw\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[SHOWLICENSE]"+ cr + Connect(ipdev, "showlicense\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[VER -V]"+ cr + Connect(ipdev, "ver -v\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[VER -ALL]"+ cr + Connect(ipdev, "ver -all\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[UP Time]" + cr + Connect(ipdev, "uptime\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[TIMEZ]"+ cr + Connect(ipdev, "timez\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[SNTP]"+ cr + Connect(ipdev, "sntp\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[APPSTAT]"+ cr + Connect(ipdev, "appstat\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[PROGREGISTER]"+ cr + Connect(ipdev, "progregister\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[IPCONFIG All]"+ cr + Connect(ipdev, "ipconfig /all\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[ETHWDOG]"+ cr + Connect(ipdev, "ethwdog\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[TASKSTAT]"+ cr + Connect(ipdev, "taskstat\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[REPORTCRESNET]"+ cr + Connect(ipdev, "reportcresnet\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[IPTABLE -P:ALL -T]"+ cr + Connect(ipdev, "iptable -p:all -t\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[PROGCOMMENTS 1]"+ cr + Connect(ipdev, "progcomments:1\r") + cr);
                Ui.Result.AppendText("[PROGCOMMENTS 2]"+ cr + Connect(ipdev, "progcomments:2\r") + cr);
                Ui.Result.AppendText("[PROGCOMMENTS 3]"+ cr + Connect(ipdev, "progcomments:3\r") + cr);
                Ui.Result.AppendText("[PROGCOMMENTS 4]"+ cr + Connect(ipdev, "progcomments:4\r") + cr);
                Ui.Result.AppendText("[PROGCOMMENTS 5]"+ cr + Connect(ipdev, "progcomments:5\r") + cr);
                Ui.Result.AppendText("[PROGCOMMENTS 6]"+ cr + Connect(ipdev, "progcomments:6\r") + cr);
                Ui.Result.AppendText("[PROGCOMMENTS 7]"+ cr + Connect(ipdev, "progcomments:7\r") + cr);
                Ui.Result.AppendText("[PROGCOMMENTS 8]"+ cr + Connect(ipdev, "progcomments:8\r") + cr);
                Ui.Result.AppendText("[PROGCOMMENTS 9]"+ cr + Connect(ipdev, "progcomments:9\r") + cr);
                Ui.Result.AppendText("[PROGCOMMENTS 10]"+ cr + Connect(ipdev, "progcomments:10\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[SPLUSTASKS 1]"+ cr + Connect(ipdev, "splustasks:1\r"));
                Ui.Result.AppendText("[SPLUSTASKS 2]"+ cr + Connect(ipdev, "splustasks:2\r"));
                Ui.Result.AppendText("[SPLUSTASKS 3]"+ cr + Connect(ipdev, "splustasks:3\r"));
                Ui.Result.AppendText("[SPLUSTASKS 4]"+ cr + Connect(ipdev, "splustasks:4\r"));
                Ui.Result.AppendText("[SPLUSTASKS 5]"+ cr + Connect(ipdev, "splustasks:5\r"));
                Ui.Result.AppendText("[SPLUSTASKS 6]"+ cr + Connect(ipdev, "splustasks:6\r"));
                Ui.Result.AppendText("[SPLUSTASKS 7]"+ cr + Connect(ipdev, "splustasks:7\r"));
                Ui.Result.AppendText("[SPLUSTASKS 8]"+ cr + Connect(ipdev, "splustasks:8\r"));
                Ui.Result.AppendText("[SPLUSTASKS 9]"+ cr + Connect(ipdev, "splustasks:9\r"));
                Ui.Result.AppendText("[SPLUSTASKS 10]"+ cr + Connect(ipdev, "splustasks:10\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[AUTODISCOVERY QUERY TABLEFORMAT]"+ cr + Connect(ipdev, "autodiscovery query tableformat\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[LIST ACTIVE MODULE]"+ cr + Connect(ipdev, "listactivemodules\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[THREADPOOL INFO]"+ cr + Connect(ipdev, "threadpoolinfo\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[LISTEN STAT]"+ cr + Connect(ipdev, "listenstat\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[ROUTER STATUS]"+ cr + Connect(ipdev, "routerstatus\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[ROUTERSENDCMD GET VERSION]"+ cr + Connect(ipdev, "routersendcmd get version\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[CPU LOAD]" + cr + Connect(ipdev, "cpuload\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[RAM FREE]" + cr + Connect(ipdev, "ramfree\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[ROUTESYM STAT]" + cr + Connect(ipdev, "routesymstat\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[DHCP LEASES]" + cr + Connect(ipdev, "dhcpleases\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[USERPAT LIST]" + cr + Connect(ipdev, "userpatlist\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[SHOW PORT MAP -ALL]" + cr + Connect(ipdev, "showportmap -all\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[SHOWDISKINFO]" + cr + Connect(ipdev, "showdiskinfo\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[ERR PLOGCURRENT]" + cr + Connect(ipdev, "err plogcurrent\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[ERR PLOGALL]" + cr + Connect(ipdev, "err plogall\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);



            }
            else if (MaListTouchPanel.Any(mydev.Contains))
            {

                Ui.Result.Text = "Hostname" + cr + Connect(ipdev, "Hostname\r");
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[INFO]" + cr + Connect(ipdev, "info\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[SHOWHW]" + cr + Connect(ipdev, "showhw\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[SHOWLICENSE]" + cr + Connect(ipdev, "showlicense\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[VER -V]" + cr + Connect(ipdev, "ver -v\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[OSD]" + cr + Connect(ipdev, "osd\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[UP Time]" + cr + Connect(ipdev, "uptime\r"));
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[CORE3Uilevel]" + cr + Connect(ipdev, "CORE3Uilevel\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[CORE3Version]" + cr + Connect(ipdev, "CORE3Version\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[ETHWDOG]" + cr + Connect(ipdev, "ETHWDOG\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[SYSMSG]" + cr + Connect(ipdev, "sysmsg\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[IPCONFIG All]" + cr + Connect(ipdev, "ipconfig /all\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[WHO]" + cr + Connect(ipdev, "who\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[ERR]" + cr + Connect(ipdev, "err\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[IPTABLE]" + cr + Connect(ipdev, "iptable\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[AUTODISCOVERY]" + cr + Connect(ipdev, "autodiscovery\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[CPULOAD]" + cr + Connect(ipdev, "cpuload\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[RAMFREE]" + cr + Connect(ipdev, "ramfree\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[TEMPerature]" + cr + Connect(ipdev, "TEMPerature\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[8021XAU]" + cr + Connect(ipdev, "8021XAU\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[MEDIASTREAMINFO]" + cr + Connect(ipdev, "MEDIASTREAMINFO\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[SIPINFO]" + cr + Connect(ipdev, "sipinfo\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[NVRAMREBOOT]" + cr + Connect(ipdev, "NVRAMREBOOT\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
                Ui.Result.AppendText("[TASKSTAT]" + cr + Connect(ipdev, "taskstat\r") + cr);
                Ui.Result.AppendText(cr + "******************************" + cr);
            }
            else if (MaListDGE.Any(mydev.Contains))
            {

            }
            else if (MaListSWAMP.Any(mydev.Contains))
            {

            }





            return true;
        }
        // public bool


    }
}
