using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IPCount
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        TextBox iptb;
        TextBox mtb;
        Label point;
        Label binIP;
        TextBox cIDR;
        IpControll ik;
        List<TextBox> IpOctets = new List<TextBox>();
        List<Label> BinIPs = new List<Label>();
        public MainWindow()
        {
            InitializeComponent();
            ik = new IpControll();
            for (int i = 0; i < 4; i++)
            {
                iptb = new TextBox
                {
                    
                    
                    Width = 30,
                    Height = 20
                };
                point = new Label
                {
                    Content = "."
                };
                binIP = new Label
                {
                    Content = "00000000",
                    Height = 30,
                    Width = 70,
                    Background = new SolidColorBrush(Colors.LightGray)
                };

                BinIPs.Add(ik.Lbl);
                IpOctets.Add(iptb);
                iptb.TextChanged += Iptb_TextChanged;
                SpIPInput.Children.Add(iptb);
                if (i == 3) point.Content = "/";
                SpIPInput.Children.Add(point);
                LblSpBinIp.Children.Add(binIP);
                
            }
            cIDR = new TextBox()
            {
                Width = 30,
                Height = 20
            };
            SpIPInput.Children.Add(cIDR);

            for (int i = 0; i < 4; i++)
            {
              
                mtb = new TextBox
                {
                    Width = 30,
                    Height = 20
                };
                point = new Label
                {
                    Content = "."
                };
                SpMaskInput.Children.Add(mtb);
                if (i!=3)
                {
                    SpMaskInput.Children.Add(point);
                }
                
            }



        }

        private void Iptb_TextChanged(object sender, TextChangedEventArgs e)
        {

            for (int i = 0; i < 4; i++)
            {

                binIP = new Label
                {
                    Background = new SolidColorBrush(Colors.Coral)
                };
                
                string s = IpOctets[i].Text;
                
                if (s!="")
                {
                    ik.IpOctet = s;
                    
                    binIP.Content = BinIPs[i].Content;
                }
                
            }
        }
    }
}
