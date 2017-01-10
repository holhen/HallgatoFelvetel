using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;

namespace HallgatoFelvetel
{
    static class Program
    {
        public static IContainer Container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<IdopontFelvetele>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ViewModel>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SampleContext>().As<ISampleContext>().WithParameter("connectionString", "Vizsga").SingleInstance();
            builder.RegisterType<HallgatokListajaForm>().AsSelf().InstancePerLifetimeScope();
            Container = builder.Build();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
