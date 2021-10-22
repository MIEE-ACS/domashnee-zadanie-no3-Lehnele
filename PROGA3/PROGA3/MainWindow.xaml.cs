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

namespace PROGA3
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

        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            string WordLetter = "аиеёоуыэюя";
            int k = 0;
            foreach (char i in tbI.Text)
            {
                foreach (char j in WordLetter)
                {
                    if(i == j)
                    {
                        k++;
                    }
                }
            }
            tbR.Text = String.Format($"Количество гласных: {k}");
        }

        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            string WordLetter = "аиеёоуыэюя";
            int k = 0;
            foreach (char i in tbI.Text)
                {
                if (Char.IsWhiteSpace(i))
                {
                    k++;
                }
                foreach (char j in WordLetter)
                {
                    if (i == j)
                    {
                        k++;
                    }
                }
            }
            tbR.Text = String.Format($"Количество согласных: {tbI.Text.Length - k}");
        }
    }
}
