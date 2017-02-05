using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate.Dialect;

namespace Equipe15WebFlix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


         Dialect dialect = Dialect.GetDialect();
//            //<-- compare against the expected dailect classes
//            if (dialect instanceof OracleDialect){
//                //your database is oracle
//            }else if (dialect instanceof HSQLDialect){
//                //<-- compare against the expected dailect classes
//                //your database is HSQL
//            }
        }
    }
}
