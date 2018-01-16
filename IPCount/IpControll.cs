using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace IPCount
{
    class IpControll
    {
        byte ip;
        public byte Ip { get => ip; set => ip = value; }
        string binIPAddr;
        public string BinIPAddr { get => binIPAddr; set => binIPAddr = value; }
        Label lbl;
        public Label Lbl { get => lbl; set => lbl = value; }
        public string IpOctet {
            get
            {
                return IpOctet;
            }
            set
            {
                bool ok = true;

                if (value.Length != 0)
                {
                    lbl = new Label();
                    ipOctet = value;
                    ok = byte.TryParse(ipOctet, out byte ip);
                    if (!ok) MessageBox.Show("Rossz IP cím"); 
                    Ip = ip;
                    binIPAddr = DecToBin(ip);
                    lbl.Content = binIPAddr;
                    
                }
            }
        }

        

        string ipOctet;

        
        //public IpControll()
        //{ }
        

        //public IpControll(string ipOctet)
        //{
            
        //    bool ok = true;

        //    if (ipOctet.Length != 0)
        //    {
        //        ok = byte.TryParse(ipOctet, out byte ip);
        //        if (!ok) throw new Exception("Rossz ip cím");
        //        Ip = ip;
        //        binIPAddr = DecToBin(ip);
        //        lbl.Content = binIPAddr;
        //    }
        //}

        protected string DecToBin(byte i)
        {
            string result = "";
            while (i>0)
            {
                int remainder = i % 2;
                result = remainder.ToString() + result;
                i /= 2;
            }
            int l = result.Length;
            for (int z = 0; z < 8-l; z++)
            {
                result = "0" + result;
            }
            return result;
        }



        
    }
}
