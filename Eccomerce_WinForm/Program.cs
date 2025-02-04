using BLL;
using Presentation;

namespace Eccomerce_WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            UsersServices userService = new UsersServices(); // Create an instance of UsersServices
            Application.Run(new Intro()); // Pass the instance to RegisterForm
        }
    }
}