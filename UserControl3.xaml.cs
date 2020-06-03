using Clint_kursach3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Clint_kursach3.UserControls
{
    /// <summary>
    /// Логика взаимодействия для UserControl3.xaml
    /// </summary>
    public partial class UserControl3 : UserControl
    {
        public BindingList<Options> options;

        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
           
           
            if (options==null)
            {
                options = new BindingList<Options>();
            }
           
            DgUserControl3.ItemsSource = options;
            options.ListChanged += Options_ListChanged;


        }

        private void Options_ListChanged(object sender, ListChangedEventArgs e)
        {
           
            if (options.Count != 0)
            {
                for (int i = 0; i < options.Count; i++)
                    options[i].Id = i + 1;
                options[options.Count - 1].Id = options.Count;
            }
            if (options.Count > 1)
            {
                WindowWork.is_enable_button = true;
            }
            else
            {
                WindowWork.is_enable_button = false;
            }
        }
    }
}
