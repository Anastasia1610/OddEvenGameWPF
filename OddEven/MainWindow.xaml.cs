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

namespace OddEven
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

        int point;

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            Input.Text = (random.Next(1, 100)).ToString();
            point = 0;
            Points.Text = point.ToString(); 
            PBpoints.Value = point; 
        }

        private void Even_Click(object sender, RoutedEventArgs e)
        {
            if (point < 0 || point > 29)  // После проигрыша или выигрыша игра возможна только если нажать START
                return;

            if (int.Parse(Input.Text) == 0)   // Стартовый ноль в игре не участвует
                return;

            // Верный ответ +1
            if (int.Parse(Input.Text) % 2 == 0)
            {
                point++;
                Points.Text = point.ToString();
                PBpoints.Value = point;
            }
            else   // Не верный -2
            {
                point = point-2;
                Points.Text = point.ToString();
                PBpoints.Value = point;
            }
            
            if(point < 0)  // Проигрыш
            {
                Input.Text = "L";
                return;
            }

            if(point > 29) // Выигрыш
            {
                Input.Text = "W";
                return;
            }

            Random random = new Random();
            Input.Text = (random.Next(1, 100)).ToString();
         }

        private void Odd_Click(object sender, RoutedEventArgs e)
        {
            if (point < 0 || point > 29)  // После проигрыша или выигрыша игра возможна только если нажать START
                return;

            if (int.Parse(Input.Text) == 0)   // Стартовый ноль в игре не участвует
                return;

            if (int.Parse(Input.Text) % 2 != 0) // Верный +1
            {
                point++;
                Points.Text = point.ToString();
                PBpoints.Value = point;
            }
            else   // Не верный -2
            {
                point = point - 2;
                Points.Text = point.ToString();
                PBpoints.Value = point;
            }

            if (point < 0)  // Проигрыш
            {
                Input.Text = "L";
                return;
            }

            if (point > 29) // Выигрыш
            {
                Input.Text = "W";
                return;
            }

            Random random = new Random();
            Input.Text = (random.Next(1, 100)).ToString();
        }
    }
}
