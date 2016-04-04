using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace nsModuleB.ViewModels
{
    public class Screen1VM:BindableBase
    {
        public string Title { get; set; }

        public Screen1VM()
        {
            Title = "Screen 1";
        }

    }
}
