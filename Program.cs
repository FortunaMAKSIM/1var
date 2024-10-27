using _1var.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace _1var
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var servicesProvider = new ServiceCollection().AddDbContext<MyDbContext>(options => options.UseSqlServer("Server=DESKTOP-NJ4MPGV; Database=Variant1; Integrated Security=true; TrustServerCertificate=true")).BuildServiceProvider();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var dbContext = servicesProvider.GetService<MyDbContext>();

            Application.Run(new Form1(dbContext));
        }
    }
}