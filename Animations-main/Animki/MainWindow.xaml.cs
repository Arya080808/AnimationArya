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

namespace Animki
{
 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 Window2 = new Window2();
            Window2.Show();
            this.Close();

        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            closed.Source = opened.Source;
            string jelanie = "";
            int res = rnd.Next(1, 4);
            switch (res)
            {
                case 1:
                    jelanie = "Мнооооооого денег!";
                    break;
                case 2:
                    jelanie = "Здоровьица!)";
                    break;
                case 3:
                    jelanie = "Стоит улыбаться чаще)";
                    break;
            }
            MessageBox.Show(jelanie, "Ваше пожелание");
        }
    }
}
