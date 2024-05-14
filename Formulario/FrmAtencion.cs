using Entidades;

namespace Formulario
{
    public partial class FrmAtencion : Form
    {
        public FrmAtencion()
        {
            InitializeComponent();
        }
        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (lstPacientes.SelectedItem is null || lstMedicos.SelectedItem is null)
            {
                MessageBox.Show("Error de datos", "¡Error!", MessageBoxButtons.OK);
            }
            else
            {
                //
                MessageBox.Show("","Atención finalizada",MessageBoxButtons.OK);
            }
        }

        private void LstMedicos_SelectedIndexChanged(object? sender, EventArgs e)
        {
            PersonalMedico doctor = (PersonalMedico)lstMedicos.SelectedItem;
            if (doctor is not null)
            {
                rtbInfoMedico.Text = doctor.FichaPersonal(doctor);
            }
        }

        private void FrmAtencion_Load_1(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void FrmAtencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }


    }
}