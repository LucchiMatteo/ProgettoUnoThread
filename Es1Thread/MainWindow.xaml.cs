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

namespace Es1Thread
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static BitmapImage bmpLive;
        static BitmapImage bmpLast;
        public MainWindow()
        {
            InitializeComponent();


        }

        static Color starColor = Colors.White;

        private void sli1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbl1.Content = Decimal.Round((decimal) sli1.Value*10,2) + " %";
            byte alpha = (byte)(sli1.Value * 255 / 100);
            starColor = Color.FromArgb(alpha, Colors.White.R, Colors.White.G, Colors.White.B); //inserisco le 3 componenti che danno il bianco
        }

      
    }
}
