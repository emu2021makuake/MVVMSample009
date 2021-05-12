using Microsoft.Extensions.DependencyInjection;
using MVVMSample009.Models;
using System.Windows;
using IOC = Microsoft.Toolkit.Mvvm.DependencyInjection.Ioc;

namespace MVVMSample009
{
    public partial class App : Application
    {
        public App()
        {
            IOC.Default.ConfigureServices(
                new ServiceCollection()
                .AddSingleton<IFoo, Foo>()
                .BuildServiceProvider());
        }
    }
}
