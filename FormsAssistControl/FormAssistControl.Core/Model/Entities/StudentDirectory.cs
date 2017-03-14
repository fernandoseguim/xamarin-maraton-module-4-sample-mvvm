using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsAssistControl.Model.Entities
{
    public class StudentDirectory : ObservableBaseObject
    {

        public ObservableCollection<Student> Students
        {
            get
            {
                return Students;
            }

            set
            {
                Students = value; OnPropertyChanged();
            }
        }

    }
}
