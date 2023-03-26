using HotelAppClassLibrary.Databases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Xaml;

namespace WpfUI
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			var services = new ServiceCollection();
			services.AddTransient<ISqlDataAccess, SqlDataAccess>();
			services.AddTransient<IDatabaseData, SqlData>();
			services.AddTransient<MainWindow>();
			var builder = new ConfigurationBuilder();
			builder
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true)
				.AddUserSecrets<App>();

			
			
			IConfiguration config = builder.Build();
			services.AddSingleton(config);
			var serviceProvider = services.BuildServiceProvider();
			var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();

            

           


			

		}

	}
}
