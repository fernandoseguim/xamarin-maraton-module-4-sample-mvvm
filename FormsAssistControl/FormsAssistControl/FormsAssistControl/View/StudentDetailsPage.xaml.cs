using FormsAssistControl.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsAssistControl.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentDetailsPage : ContentPage
    {
        public StudentDetailsPage(Student selectedStudent)
        {
            InitializeComponent();
            this.BindingContext = selectedStudent;
        }
    }
}
