using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clint_kursach3.Models
{
    public static class ServiceTable
    {
        private static DataTable res;

        public static DataTable ToDataTable<T>(this BindingList<T> arr)
        {
            res = new DataTable();

            for (int i = 0; i < arr.Count; i++)
            {
                res.Columns.Add("Э" + i, typeof(T));
            }
            var row = res.NewRow();


            for (int i = 1; i < arr.Count; i++)
            {
                row[i] = arr[i];
            }
            res.Rows.Add(row);

            return res;
        }



        public static DataTable ToDataTable<T>(this T[,] matrix)
        {
            var res = new DataTable();

            for (int i = 0; i <= matrix.GetLength(1); i++)
            {
                if (i == 0)
                {
                    res.Columns.Add("Эj/Эj", typeof(T));
                }
                else
                {
                    res.Columns.Add("Э" + i, typeof(T));
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = res.NewRow();
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {                
                    row[j] = matrix[i, j];                    
                }

                res.Rows.Add(row);
               
            }          
            return res;
        }
    }


    public class ServiceTable_Rows : INotifyPropertyChanged
    {
        private string _row_name;

        public string Row_Name
        {
            get { return _row_name; }

            set
            {
                if (_row_name == value)
                {
                    return;
                }
                _row_name = value;
                OnPropertyChanged("Row_Name");
            }
        }

        public ServiceTable_Rows(int index)
        {
            _row_name = "Э" + index;
        }

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
