using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using System.Collections.Specialized;
using NHibernate.Dialect;

namespace Equipe15WebFlix
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Equipe15WebFlix.Properties.Settings.ConnectionString"].ToString();

           
            NHibernate.Cfg.Configuration nHibernateConfiguration =
                                                  new NHibernate.Cfg.Configuration();
//            nHibernateConfiguration.SetProperty(
//              NHibernate.Cfg.Environment.ProxyFactoryFactoryClass,
//              typeof(NHibernate.Castle.ProxyFactoryFactory).AssemblyQualifiedName);
//            nHibernateConfiguration.SetProperty(
//              NHibernate.Cfg.Environment.Dialect,
//              typeof(NHibernate.Dialect.MsSql2005Dialect).AssemblyQualifiedName);
//            nHibernateConfiguration.SetProperty(
//              NHibernate.Cfg.Environment.ConnectionString, connectionString);
//            nHibernateConfiguration.SetProperty(
//              NHibernate.Cfg.Environment.FormatSql, "true");
//            nHibernateConfiguration.AddAssembly(Assembly.GetCallingAssembly());

            ISessionFactory oneISessionFactory = nHibernateConfiguration
                                                    .BuildSessionFactory();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
