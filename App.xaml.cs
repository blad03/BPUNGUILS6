﻿using BPUNGUILS6.Views;

namespace BPUNGUILS6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VEstudiante();
        }
    }
}