using Clint_kursach3.Models;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
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
    /// Логика взаимодействия для UserControl5.xaml
    /// </summary>
    public partial class UserControl5 : UserControl
    {
        public NetworkStream stream;/// для отправки данных серваку
        

        public BindingList<Expert> experts;
        public BindingList<Expert_Table> expert_table;
        public BindingList<Models.Options> options;
        public BindingList<Options_Table> option_table;
        public string report;
   

        public UserControl5()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            UserControl6 user_control_6 = new UserControl6();
            DgFinalTable.Children.Clear();
            DgFinalTable.Children.Add(user_control_6);

            user_control_6.stream = stream;
            user_control_6.experts = experts;
            user_control_6.expert_table = expert_table;
            user_control_6.options = options;
            user_control_6.option_table = option_table;

            textblock_rep.Text = report;

            List<Label> labels = new List<Label>();
            labels.Add(l1);
            labels.Add(l2);
            labels.Add(l3);
            labels.Add(l4);
            labels.Add(l5); labels.Add(l10);
            labels.Add(l6);
            labels.Add(l7);
            labels.Add(l8);
            labels.Add(l9);
            labels.Add(l10);

            List<ProgressBar> progressBars = new List<ProgressBar>();
            progressBars.Add(pb_1);
            progressBars.Add(pb_2);
            progressBars.Add(pb_3);
            progressBars.Add(pb_4);
            progressBars.Add(pb_5);
            progressBars.Add(pb_6);
            progressBars.Add(pb_7);
            progressBars.Add(pb_8);
            progressBars.Add(pb_9);
            progressBars.Add(pb_10);
            int i = 0;
           
            foreach (var item in options)
            {
                progressBars[i].Value = Convert.ToDouble(item.Ck);
                progressBars[i].Visibility = Visibility.Visible;
             
                labels[i].Visibility = Visibility.Visible;
                i++;
            }
        }

       
    }
}
