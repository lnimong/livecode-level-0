using AlloWorld.SharedCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace WP
{
    public class MainPageViewModel 
    {
        DialerModel model = new DialerModel();
        
        public MainPageViewModel()
        {
            DialCommand = new Command(() => { model.RandomDial(); }); 
        }

        public string Name { get; set; }

        public Thickness RandomMargin { get; set; }

        public ICommand DialCommand
        {
            private set;
            get;
        }

    }
}                                                                                                                                                                                                                                                                                           