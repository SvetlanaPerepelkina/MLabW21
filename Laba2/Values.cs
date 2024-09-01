using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Laba2
{
    public class Values :  IDataErrorInfo
    {
        public int Start { get; set; }
        public int Stop { get; set; }
        public int Step { get; set; }
        public int Num {  get; set; }

        public Values() { }

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                if (string.IsNullOrEmpty(columnName)) { }
                switch (columnName)
                {
                    case "Num":
                        if (Num > 0 && Num < 5)
                        {
                            error = "Это число должно быть больше 5 ";
                            MessageBox.Show(error);
                        }
                        break;

                }
                return error;
            }
        }
        public string Error
        {
            get { throw new NotImplementedException(); }
        }


    }
}
