using Clint_kursach3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    /// Логика взаимодействия для UserControl2.xaml
    /// </summary>
    /// 
    public partial class UserControl2 : UserControl
    {
        public BindingList<Expert> experts;
        public BindingList<Expert_Table> expert_table;



        public UserControl2()
        {
            InitializeComponent();
        }




        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {


            //expert_table = new BindingList<Expert_Table>();


            //for (int i = 0; i < experts.Count; i++)
            //{
            //    expert_table = new BindingList<Expert_Table>();
            //    expert_table.Add(new Expert_Table(experts[i]));
            //    DataGridTextColumn col = new DataGridTextColumn();
            //    col.Header = "Э" + i + 1;
            //    col.Width = 60;

            //    col.Binding = new Binding(expert_table[i].mark);
            //    DgUserControl2.Columns.Add(col);
            //}



            //expert_num = new BindingList<ServiceTable_Rows>();
            //for (int i = 1; i <= experts.Count; i++)
            //{
            //    expert_num.Add(new ServiceTable_Rows(i));
            //}
            //if (expert_table == null)
            //{


            //string[,] marks_arr = new string[experts.Count, experts.Count];
            //DgUserControl2_row.ItemsSource = marks_arr.ToDataTable().DefaultView;
            // o = ((ContentPresenter)DgUserControl2_row.Columns[0].GetCellContent(DgUserControl2_row.Items[0])).Content;           

            if (expert_table == null || expert_table.Count > experts.Count)
            {
                expert_table = new BindingList<Expert_Table>();

                for (int i = 0; i < experts.Count; i++)
                {
                    expert_table.Add(new Expert_Table(experts[i]));
                    // expert_table.Add(new Expert_Table(i, experts.Count));
                }

            }

            //if (expert_table.Count > experts.Count)
            //{
            //    for (int i = experts.Count - 1; i < expert_table.Count - 1; i++)//чтобы удалялись автоматом из экспертов
            //    {
            //        expert_table.RemoveAt(i);
            //    }

            //}

            if (expert_table.Count < experts.Count)
            {
                for (int i = expert_table.Count; i < experts.Count; i++)//чтобы добавлялись автоматом из экспертов
                {
                    expert_table.Add(new Expert_Table(experts[i]));
                    //expert_table.Add(new Expert_Table(i, experts.Count));
                }

            }
            for (int i = DgUserControl2.Columns.Count - 1; i > experts.Count; i--)
            {
                DgUserControl2.Columns[i].Visibility = Visibility.Collapsed;

            }

            DgUserControl2.ItemsSource = expert_table;
            expert_table.ListChanged += Expert_table_ListChanged;


        }

        private void Expert_table_ListChanged(object sender, ListChangedEventArgs e)
        {

        }


    }
}
