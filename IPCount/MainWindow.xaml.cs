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
            Ik = new IpControll();
            for (int i = 0; i < 4; i++)
            {
                Iptb = new TextBox
                {
                    
                    
                    Width = 30,
                    Height = 20
                };
                point = new Label
                {
                    Content = "."
                };
                BinIP = new Label
                {
                    Content = "00000000",
                    Height = 30,
                    Width = 70,
                    Background = new SolidColorBrush(Colors.LightGray)
                };

                BinIPs1.Add(Ik.Lbl);
                IpOctets1.Add(Iptb);
                Iptb.TextChanged += Iptb_TextChanged;
                SpIPInput.Children.Add(Iptb);
                if (i == 3) point.Content = "/";
                SpIPInput.Children.Add(point);
                LblSpBinIp.Children.Add(BinIP);
                
            }
            CIDR = new TextBox()
            {
                Width = 30,
                Height = 20
            };
            SpIPInput.Children.Add(CIDR);

            for (int i = 0; i < 4; i++)
            {
              
                Mtb = new TextBox
                {
                    Width = 30,
                    Height = 20
                };
                point = new Label
                {
                    Content = "."
                };
                SpMaskInput.Children.Add(Mtb);
                if (i!=3)
                {
                    SpMaskInput.Children.Add(point);
                }
                
            }



        }

        public TextBox Iptb { get => iptb; set => iptb = value; }
        public TextBox Mtb { get => mtb; set => mtb = value; }
        public Label BinIP { get => binIP; set => binIP = value; }
        public TextBox CIDR { get => cIDR; set => cIDR = value; }
        public List<TextBox> IpOctets1 { get => IpOctets; set => IpOctets = value; }
        public List<Label> BinIPs1 { get => BinIPs; set => BinIPs = value; }
        internal IpControll Ik { get => ik; set => ik = value; }

        private void Iptb_TextChanged(object sender, TextChangedEventArgs e)
        {

            for (int i = 0; i < 4; i++)
            {

                BinIP = new Label
                {
                    Background = new SolidColorBrush(Colors.Coral)
                };
                
                string s = IpOctets1[i].Text;
                
                if (s!="")
                {
                    Ik.IpOctet = s;
                    
                    BinIP.Content = BinIPs1[i].Content;
                }
                
            }
        }
    }
}
