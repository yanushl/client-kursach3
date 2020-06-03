using Clint_kursach3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
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
    /// Логика взаимодействия для UserControl6.xaml
    /// </summary>
    public partial class UserControl6 : UserControl
    {
        public NetworkStream stream;/// для отправки данных серваку

        public BindingList<Expert> experts;
        public BindingList<Expert_Table> expert_table;
        public BindingList<Options> options;
        public BindingList<Options_Table> option_table;

        public UserControl6()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
         

            for (int i = Dg_6.Columns.Count-1; i > options.Count+2; i--)
            {
                Dg_6.Columns[i].Visibility = Visibility.Collapsed;
            }
            Dg_6.ItemsSource = option_table;
            Dg_6_t2.ItemsSource = options;
           
        }
    }
}
