using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HallgatoFelvetel
{
    public partial class HallgatokListajaForm : Form
    {
        private BindingList<StudentEntity> _hallgatok;
        private ViewModel _viewModel;
        public HallgatokListajaForm(ViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
        }

        private void HallgatokListajaForm_Load(object sender, EventArgs e)
        {
            _hallgatok = new BindingList<StudentEntity>(_viewModel.GetStudents());
            studentEntityBindingSource.DataSource = _hallgatok;
        }
    }
}
