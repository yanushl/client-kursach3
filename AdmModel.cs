using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clint_kursach3.Models
{
    class AdmModel : INotifyPropertyChanged
    {
        private string _user_login;
        private string _user_password;


        public AdmModel(string log, string pass)
        {
            _user_login = log;
            _user_password = pass;
        }

        public string user_login
        {
            get { return _user_login; }
            set
            {
                if (_user_login == value)
                {
                    return;
                }
                _user_login = value;
                OnPropertyChanged("user_login");
            }
        }

        public string user_password
        {
            get { return _user_password; }
            set
            {
                if (_user_password == value) return;
                _user_password = value;
                OnPropertyChanged("user_password");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public string NetWork_Send
        {
            get { return _user_login + '\n' + _user_password + '\n'; }
        }


    }
}
