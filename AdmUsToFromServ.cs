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
    class AdmUsToFromServ
    {
        private NetworkStream stream;

        public AdmUsToFromServ(NetworkStream stream)
        {
            this.stream = stream;
        }

        public BindingList<AdmModel> LoadData()
        {

            StringBuilder builder = new StringBuilder();
            byte[] buffer = new byte[256];
            BindingList<AdmModel> adm_data_List = new BindingList<AdmModel>();
            string log = "", pass = "", str = "";
            do
            {
                int bytes = stream.Read(buffer, 0, buffer.Length);
                builder.Append(Encoding.UTF8.GetString(buffer, 0, bytes));
                str += builder.ToString();
                builder.Clear();
               // Task.Delay(1800).Wait();
            } while (stream.DataAvailable);
            if (str == "NULL")
            {
                MessageBox.Show("Пока пользователей нет", " ", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }

            string[] str_arr = str.Split('\n');
            for (int i = 0; i < str_arr.Length - 1; i++)
            {
                log = str_arr[i];
                i++;
                pass = str_arr[i];
                Task.Delay(10).Wait();
                adm_data_List.Add(new AdmModel(log, pass));
            }
            return adm_data_List;
        }

        public void SaveData(BindingList<AdmModel> adm_data_List)
        {
            byte[] buffer = new byte[256];
            if (adm_data_List.Count == 0)
            {
                buffer = Encoding.UTF8.GetBytes("NULL");
                stream.Write(buffer, 0, buffer.Length);///шлем данные о пользователях
            }
            foreach (var item in adm_data_List)//цикл использует итератор насколько я знаю
            {
                buffer = Encoding.UTF8.GetBytes(item.NetWork_Send);
                stream.Write(buffer, 0, buffer.Length);///шлем данные о пользователях
            }
        }
    }
}
