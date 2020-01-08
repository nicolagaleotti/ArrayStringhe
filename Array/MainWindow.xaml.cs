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
using System.IO;

namespace Array
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
            string[] array = new string[5];
            int i = 0;
            string file = @"array.txt";
            string testo;
        private void btnInserisci_Click(object sender, RoutedEventArgs e)
        {
            string text = txtStringa.Text;
            array[i] = text;
            i++;
            txtStringa.Clear();
            txtStringa.Focus();
            if (i == 5)
                btnInserisci.IsEnabled = false;
        }
        
        private void btnStampa_Click(object sender, RoutedEventArgs e)
        {
            for (int c = 0; c < array.Length; c++)
            {
                testo += $"Posizione {c+1} : {array[c]} \n";
            }
            lblResult.Content = testo;
        }

        private void btnPubblica_Click(object sender, RoutedEventArgs e)
        {
            
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(lblResult.Content);
            }
        }
    }
}
