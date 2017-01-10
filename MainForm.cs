using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;

namespace HallgatoFelvetel
{
    public partial class MainForm : Form
    {
        //private List<StudentEntity> _hallgatok = new List<StudentEntity>();
        private SampleContext _context = new SampleContext();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() != DialogResult.OK)
                Close();
        }

        private void hallgatókBeolvasásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.CheckFileExists = true;
                open.Multiselect = false;
                open.Filter = "Csv fájlok (*.csv)|*.csv|Minden fájl (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    _context.Database.ExecuteSqlCommand("DELETE FROM StudentEntities");
                    _context.SaveChanges();
                    backgroundWorker1.RunWorkerAsync(open.FileName);
                }
                MessageBox.Show("A hallgatók beolvasása sikeres.");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var reader = new StreamReader((string)e.Argument, Encoding.UTF8))
            {
                string line;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string[] elements = line.Split(';');
                    StudentEntity hallgato = new StudentEntity();
                    hallgato.Name = elements[0];
                    hallgato.Course = elements[1];
                    Invoke(new Action(() =>
                    {
                        //_hallgatok.Add(hallgato);
                        _context.StudentEntities.Add(hallgato);
                    }));
                }
                _context.SaveChanges();
            }
        }

        private void hallgatókListájaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lifetimeScope = Program.Container.BeginLifetimeScope();
            HallgatokListajaForm hallgatokListaja = lifetimeScope.Resolve<HallgatokListajaForm>();
            hallgatokListaja.MdiParent = this;
            hallgatokListaja.WindowState = FormWindowState.Maximized;
            hallgatokListaja.Show();
        }

        private void időpontFoglalásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lifetimeScope = Program.Container.BeginLifetimeScope();
            IdopontFelvetele idopontFelvitele = lifetimeScope.Resolve<IdopontFelvetele>();
            idopontFelvitele.MdiParent = this;
            idopontFelvitele.WindowState = FormWindowState.Maximized;
            idopontFelvitele.Show();
        }
    }
}
