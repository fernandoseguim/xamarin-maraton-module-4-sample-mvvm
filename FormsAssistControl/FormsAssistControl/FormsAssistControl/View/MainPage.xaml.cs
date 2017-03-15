using FormsAssistControl.Model.Entities;
using FormsAssistControl.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsAssistControl.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new StudentDirectoryViewModel();
            listViewStudents.ItemSelected += GetStudentDetails;
        }

        private void GetStudentDetails(object sender, SelectedItemChangedEventArgs e)
        {
            Student selectedStudent = (Student)e.SelectedItem;
            if (selectedStudent == null)
                return;
            Navigation.PushAsync(new StudentDetailsPage(selectedStudent));
            listViewStudents.SelectedItem = null;
        }
    }
}
