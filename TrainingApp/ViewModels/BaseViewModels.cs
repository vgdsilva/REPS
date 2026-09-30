using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingApp.ViewModels
{
    public partial class BaseViewModels : ObservableObject
    {
        public virtual void OnAppearing()
        {
        }

        public virtual void OnDisappearing()
        {
        }
    }
}
