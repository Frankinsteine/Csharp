using System;
using System.Collections.Generic;
using System.Text;

namespace Hostel
{
    class Human
    {
        public string FIO { 
            get 
            {
                string fio = name + ' ' + secondName + ' ' + lastName;
                return fio; 
            } 
            set 
            {
                string[] fio = value.Split(' ');
                name = fio[0];
                secondName = fio[1];
                lastName = fio[2];
            }
        }
        string name;
        string secondName;
        string lastName;
        public Gender Gender;

    }

    
}
