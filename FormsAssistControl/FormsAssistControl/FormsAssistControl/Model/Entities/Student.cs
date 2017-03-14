using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsAssistControl.Model.Entities
{
    public class Student : ObservableBaseObject
    {

        public string Name
        {
            get
            {
                return Name;
            }
            
            set
            {
                Name = value; OnPropertyChanged();
            }
        }
        public string Lastname
        {
            get
            {
                return Lastname;
            }
            set
            {
                Lastname = value; OnPropertyChanged();
            }
        }
        public string Group {

            get
            {
                return Group;
            }

            set
            {
                Group = value; OnPropertyChanged();
            }
        }
        public string StudentNumber
        {
            get
            {
                return StudentNumber;
            }

            set
            {
                StudentNumber = value; OnPropertyChanged();
            }
        }
        public double Average
        {
            get
            {
                return Average;
            }

            set
            {
                Average = value; OnPropertyChanged();
            }
        }

    }
}
