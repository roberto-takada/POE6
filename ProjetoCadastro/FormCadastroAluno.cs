using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace ProjetoCadastro
{
    public partial class FormCadastroAluno : MaterialForm
    {

        string alunosFileName = "alunos.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;
        public FormCadastroAluno()
        {
            InitializeComponent();
        }

        private void materialTextBoxEdit1_Click(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                TabControlCadastro.SelectedIndex = 1;
            }
        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matricula inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }
            if(!DateTime.TryParse(txtNascimento.Text, out DateTime result))
            {
                MessageBox.Show("Data de Nascimento inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNascimento.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNomeCompleto.Text))
            {
                MessageBox.Show("Nome inválido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeCompleto.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endereço inválido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Cidade inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboEstado.Text))
            {
                MessageBox.Show("Estado inválidp", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEstado.Focus();
                return false;
            
            }

            return true;
        }

        private void Salvar()
        {
            var line = $"{txtMatricula.Text};"
                     + $"{txtNascimento.Text};"
                     + $"{txtNomeCompleto.Text};"
                     + $"{txtEndereco.Text};"
                     + $"{txtBairro.Text};"
                     + $"{txtCidade.Text};"
                     + $"{cboEstado.Text};"
                     + $"{txtSenha.Text};";
            if (!isAlteracao)
            {
                var file = new StreamWriter(alunosFileName, true);
                file.WriteLine(line);
                file.Close();
            }
            else
            {

            }
            LimpaCampos();     
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach(var control in tabPageCadastro.Controls)
            {
                if(control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if(control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }
    }
}
