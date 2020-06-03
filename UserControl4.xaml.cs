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
    /// Логика взаимодействия для UserControl4.xaml
    /// </summary>
    public partial class UserControl4 : UserControl
    {
        public BindingList<Expert> experts;
        public BindingList<Options> options;
        public BindingList<Options_Table> option_table;

        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (option_table == null || option_table.Count > experts.Count)
            {
                option_table = new BindingList<Options_Table>();

                for (int i = 0; i < experts.Count; i++)
                {
                    option_table.Add(new Options_Table(experts[i], options));
                }
            }

            if (option_table.Count < experts.Count)
            {
                for (int i = option_table.Count + 1; i < experts.Count; i++)
                {
                    option_table.Add(new Options_Table(experts[i],options));
                }
            }
            for (int i = DgUserControl4.Columns.Count - 1; i > options.Count; i--)
            {
                DgUserControl4.Columns[i].Visibility = Visibility.Collapsed;
            }
            DgUserControl4.ItemsSource = option_table;
            option_table.ListChanged += Option_table_ListChanged;     

        }

        private void Option_table_ListChanged(object sender, ListChangedEventArgs e)
        {
            
        }
    }
}
