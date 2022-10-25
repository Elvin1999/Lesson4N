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

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Car> Cars { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Cars = new List<Car>
            {
                new Car
                {
                     Model="E-200",
                     Vendor="Mercedes",
                     Year=2020
                },
                new Car
                {
                     Model="Malibu",
                     Vendor="Chevrolet",
                     Year=2020
                },
                new Car
                {
                     Model="F30",
                     Vendor="BMW",
                     Year=2022
                },
                new Car
                {
                     Model="E-200",
                     Vendor="Mercedes",
                     Year=2020
                },
                new Car
                {
                     Model="Malibu",
                     Vendor="Chevrolet",
                     Year=2020
                },
                new Car
                {
                     Model="F30",
                     Vendor="BMW",
                     Year=2022
                },
                new Car
                {
                     Model="E-200",
                     Vendor="Mercedes",
                     Year=2020
                },
                new Car
                {
                     Model="Malibu",
                     Vendor="Chevrolet",
                     Year=2020
                },
                new Car
                {
                     Model="F30",
                     Vendor="BMW",
                     Year=2022
                },
                new Car
                {
                     Model="E-200",
                     Vendor="Mercedes",
                     Year=2020
                },
                new Car
                {
                     Model="Malibu",
                     Vendor="Chevrolet",
                     Year=2020
                },
                new Car
                {
                     Model="F30",
                     Vendor="BMW",
                     Year=2022
                },
                new Car
                {
                     Model="E-200",
                     Vendor="Mercedes",
                     Year=2020
                },
                new Car
                {
                     Model="Malibu",
                     Vendor="Chevrolet",
                     Year=2020
                },
                new Car
                {
                     Model="F30",
                     Vendor="BMW",
                     Year=2022
                },
                new Car
                {
                     Model="E-200",
                     Vendor="Mercedes",
                     Year=2020
                },
                new Car
                {
                     Model="Malibu",
                     Vendor="Chevrolet",
                     Year=2020
                },
                new Car
                {
                     Model="F30",
                     Vendor="BMW",
                     Year=2022
                },
            };


            mydatagrid.ItemsSource = Cars;

            //mycombobox.ItemsSource = Cars;
            //mycombobox.DisplayMemberPath=nameof(Car.Model);
            //mycombobox.SelectedIndex = 0;
            //listbox.ItemsSource = Cars;

            //var textBlock = new TextBlock
            //{
            //    Text = "Salam"
            //};

            //textBlock.Text += "   " + DateTime.Now.ToShortTimeString();

            //mylistbox.Items.Add(textBlock);

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.Title=(sender as Slider).Value.ToString();
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var  car=listbox.SelectedItem as Car;

            //var sb=new StringBuilder();
            //foreach (var item in listbox.SelectedItems)
            //{
            //    if(item is Car c)
            //    {
            //        sb.AppendLine(c.ToString());
            //    }
            //}
            //MessageBox.Show(sb.ToString());
            //MessageBox.Show(car.ToString());
        }

       

        private void mycombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var comboItem = mycombobox.SelectedItem as ComboBoxItem;
            //var stackPanel = comboItem.Content as StackPanel;
            //foreach (var item in stackPanel.Children)
            //{
            //    if (item is TextBlock tb)
            //    {
            //        MessageBox.Show(tb.Text);
            //    }
            //}
        }
    }
}
