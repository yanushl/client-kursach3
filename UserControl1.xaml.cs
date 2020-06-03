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
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {

        public BindingList<Expert> experts;
        public bool is_enable_button;

        public UserControl1()
        {
            InitializeComponent();
        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (experts == null)
            {
                experts = new BindingList<Expert>();
            }
            DgUserControl1.ItemsSource = experts;
            experts.ListChanged += Experts_ListChanged;

        }

        private void Experts_ListChanged(object sender, ListChangedEventArgs e)
        {

            if (experts.Count != 0)
            {
                for(int i=0;i<experts.Count;i++)
                experts[i].Id = i+1;
            }

            if (experts.Count > 1)
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
