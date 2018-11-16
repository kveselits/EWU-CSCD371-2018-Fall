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

namespace Assignment8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*ClickMeButton. Click += ClickMeButton_OnClick;
            ClickMeButton.Click -= ClickMeButton_OnClick;*/
            var button = new Button();
            button.Content = new TextBlock {Text = "Kris"};
            StackPanel.Children.Add(button);

        }

        private void ClickMeButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ClickMeButton_OnClickXaml(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
