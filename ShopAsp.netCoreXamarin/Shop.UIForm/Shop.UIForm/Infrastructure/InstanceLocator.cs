using Shop.UIForm.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.UIForm.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
