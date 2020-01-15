using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomaticMigrations;
using CodeFirstMigrations;
using LoadingRelatedEntities;

namespace EFsamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCodeFirstMigrationos_Click(object sender, EventArgs e)
        {
            new RunCodeFirstMigrations().Run();

        }

        private void btnAutoMigrations_Click(object sender, EventArgs e)
        {
            new RunAutomaticMigrations().Run();
        }

        private void btnEagerlyLoading_Click(object sender, EventArgs e)
        {
            new EagerlyLoading().Run();
        }

        private void btnLazy_Click(object sender, EventArgs e)
        {
            new LazyLoading().Run();
        }

        private void btnExplicitlyLoading_Click(object sender, EventArgs e)
        {
            new ExplicitlyLoading().Run();
        }
    }
}
