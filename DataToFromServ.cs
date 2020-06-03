using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Clint_kursach3.Models
{
    public class DataToFromServ
    {
        private NetworkStream stream;

        public DataToFromServ(NetworkStream stream)
        {
            this.stream = stream;
        }

        public void ToServ_ExpertTable(BindingList<Expert_Table> table)
        {
            byte[] buffer = new byte[256];
            foreach (var item in table)
            {
                buffer = Encoding.Unicode.GetBytes(item.ToServ(table.Count));
                stream.Write(buffer, 0, buffer.Length);///шлем данные 
            }
        }

        public void ToServ_OptionTable(BindingList<Options_Table> table)
        {
            byte[] buffer = new byte[256];
            foreach (var item in table)
            {
                buffer = Encoding.Unicode.GetBytes(item.ToServ());
                stream.Write(buffer, 0, buffer.Length);///шлем данные 
            }
        }

        public string FromServ(BindingList<Expert> table_ex, BindingList<Options> op)
        {
            string rep = " ";
            try
            {

                byte[] buffer = new byte[256];
                string str = "";

                StringBuilder builder = new StringBuilder();
                int bytes = 0;
                do
                {
                    bytes = 0;
                    bytes = stream.Read(buffer, 0, buffer.Length);
                    builder.Append(Encoding.Unicode.GetString(buffer, 0, bytes));
                    str += builder.ToString();
                    builder.Clear();
                    Task.Delay(100).Wait();
                } while (stream.DataAvailable);

                string[] str_arr_all = str.Split('@');

                string[] str_rj = null;
                string[] str_DRj = null;
                string[] str_Ck = null;
                string[] str_DCj = null;
                rep = " ";

                str_rj = str_arr_all[0].Split('\n');
                str_DRj = str_arr_all[1].Split('\n');
                str_Ck = str_arr_all[2].Split('\n');
                str_DCj = str_arr_all[3].Split('\n');
                rep = str_arr_all[4];

                for (int i = 0; i < table_ex.Count; i++)
                {
                    table_ex[i].rj = str_rj[i];
                    table_ex[i].DRj = str_DRj[i];
                }

                for (int i = 0; i < op.Count; i++)
                {
                    op[i].Ck = str_Ck[i];
                    op[i].DCj = str_DCj[i];
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rep;
        }


    }
}
