using FullXamarinPlayGround.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace FullXamarinPlayGround.ViewModels
{
    public class HomeViewMdoel : INotifyPropertyChanged
    {
        private TaskModel _taskModel;
        private string _message;
        public TaskModel TaskModel
        {
            get { return _taskModel; }
            set
            {
                _taskModel = value;
                OnPropertyChanged();
            }
        }

        public string  Messaage
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }
        public Command SaveCommand
        { get
            {
                return new Command(() =>
                {
                    Messaage = $"you task {TaskModel.Title} {TaskModel.Duration} was successfully saved";
                });
            }
        }
        
        public HomeViewMdoel()
        {
            TaskModel = new TaskModel
            {
                Title = "Writing Xamarin",
                Duration = 5
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
