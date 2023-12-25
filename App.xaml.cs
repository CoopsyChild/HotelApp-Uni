﻿using System.Configuration;
using System.Data;
using System.Windows;
using HotelApp.Models;

namespace HotelApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        Hotel hotel = new Hotel("Kupszi Hotel");
    }
}