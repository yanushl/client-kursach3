using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clint_kursach3.Models
{

    public class Options : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public int _Id;
        private string _option;
        private string _symmary;

        private string _Ck;
        private string _DCj;


        public int Id
        {
            get { return _Id; }
            set
            {
                if (_Id == value)
                {
                    return;
                }
                _Id = value;
                OnPropertyChanged("_Id");
            }
        }

        public string Option
        {
            get { return _option; }
            set
            {
                if (_option == value)
                {
                    return;
                }
                _option = value;
                OnPropertyChanged("_option");
            }
        }

        public string Summary
        {
            get { return _symmary; }
            set
            {
                if (_symmary == value)
                {
                    return;
                }
                _symmary = value;
                OnPropertyChanged("_symmary");
            }
        }

        public string Ck { get { return _Ck; } set { _Ck = value; } }
        public string DCj { get { return _DCj; } set { _DCj = value; } }

        public void Set(int count, string option, string summary)
        {
            _Id = count;
            _option = option;
            _symmary = summary;
        }

        virtual public void OnPropertyChanged(string v = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public string ToNetWork
        {
            get { return _Id + "\n" + _option + "\n" + _symmary + "\n"; }
        }
    }
}
