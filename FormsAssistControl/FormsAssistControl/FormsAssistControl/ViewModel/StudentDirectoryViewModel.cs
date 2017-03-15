﻿using FormsAssistControl.Model.Entities;
using FormsAssistControl.Model.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsAssistControl.ViewModel
{
    public class StudentDirectoryViewModel : ObservableBaseObject
    {

        public ObservableCollection<Student> Students { get; set; }

        bool isBusy = false;
        public bool IsBusy
        {

            get
            {
                return isBusy;
            }

            private set
            {
                isBusy = value; OnPropertyChanged();
            }

        }
        public Command LoadDirectoryCommand { get; private set; }

        public StudentDirectoryViewModel()
        {
            Students = new ObservableCollection<Student>();
            IsBusy = false;
            LoadDirectoryCommand = new Command((obj) => LoadDirectory());

        }

        async void LoadDirectory()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                await Task.Delay(3000);
                var loadedDirectory = StudentDirectoryService.LoadStudentDirectory();

                foreach (var student in loadedDirectory.Students)
                {
                    Students.Add(student);
                }

                IsBusy = false;
            }
        }
    }
}
