namespace FormsComBancoDeDados
{
    partial class FormAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControlAluno = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageAluno = new TabPage();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancela = new ReaLTaiizor.Controls.MaterialButton();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNomeDoAluno = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataDeNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            listView1 = new ListView();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            TabControlAluno.SuspendLayout();
            tabPageAluno.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlAluno
            // 
            TabControlAluno.Controls.Add(tabPageAluno);
            TabControlAluno.Controls.Add(tabPageConsulta);
            TabControlAluno.Depth = 0;
            TabControlAluno.Dock = DockStyle.Fill;
            TabControlAluno.Location = new Point(3, 64);
            TabControlAluno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlAluno.Multiline = true;
            TabControlAluno.Name = "TabControlAluno";
            TabControlAluno.SelectedIndex = 0;
            TabControlAluno.Size = new Size(941, 581);
            TabControlAluno.TabIndex = 0;
            // 
            // tabPageAluno
            // 
            tabPageAluno.Controls.Add(btnSalvar);
            tabPageAluno.Controls.Add(btnCancela);
            tabPageAluno.Controls.Add(cboEstado);
            tabPageAluno.Controls.Add(txtSenha);
            tabPageAluno.Controls.Add(txtCidade);
            tabPageAluno.Controls.Add(txtBairro);
            tabPageAluno.Controls.Add(txtEndereco);
            tabPageAluno.Controls.Add(txtNomeDoAluno);
            tabPageAluno.Controls.Add(txtDataDeNascimento);
            tabPageAluno.Controls.Add(txtMatricula);
            tabPageAluno.Location = new Point(4, 29);
            tabPageAluno.Name = "tabPageAluno";
            tabPageAluno.Padding = new Padding(3);
            tabPageAluno.Size = new Size(933, 548);
            tabPageAluno.TabIndex = 0;
            tabPageAluno.Text = "Cadastro de Aluno";
            tabPageAluno.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(744, 465);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MinimumSize = new Size(150, 50);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(150, 50);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancela
            // 
            btnCancela.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancela.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancela.Depth = 0;
            btnCancela.HighEmphasis = true;
            btnCancela.Icon = null;
            btnCancela.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancela.Location = new Point(540, 465);
            btnCancela.Margin = new Padding(4, 6, 4, 6);
            btnCancela.MinimumSize = new Size(150, 50);
            btnCancela.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancela.Name = "btnCancela";
            btnCancela.NoAccentTextColor = Color.Empty;
            btnCancela.Size = new Size(150, 50);
            btnCancela.TabIndex = 8;
            btnCancela.Text = "Cancelar";
            btnCancela.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancela.UseAccentColor = false;
            btnCancela.UseVisualStyleBackColor = true;
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(255, 255, 255);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Hint = "UF";
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboEstado.Location = new Point(743, 298);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(151, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 7;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(36, 382);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(858, 48);
            txtSenha.TabIndex = 6;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(36, 299);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(686, 48);
            txtCidade.TabIndex = 5;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            txtBairro.AnimateReadOnly = false;
            txtBairro.AutoCompleteMode = AutoCompleteMode.None;
            txtBairro.AutoCompleteSource = AutoCompleteSource.None;
            txtBairro.BackgroundImageLayout = ImageLayout.None;
            txtBairro.CharacterCasing = CharacterCasing.Normal;
            txtBairro.Depth = 0;
            txtBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBairro.HideSelection = true;
            txtBairro.Hint = "Bairro";
            txtBairro.LeadingIcon = null;
            txtBairro.Location = new Point(36, 230);
            txtBairro.MaxLength = 32767;
            txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBairro.Name = "txtBairro";
            txtBairro.PasswordChar = '\0';
            txtBairro.PrefixSuffixText = null;
            txtBairro.ReadOnly = false;
            txtBairro.RightToLeft = RightToLeft.No;
            txtBairro.SelectedText = "";
            txtBairro.SelectionLength = 0;
            txtBairro.SelectionStart = 0;
            txtBairro.ShortcutsEnabled = true;
            txtBairro.Size = new Size(858, 48);
            txtBairro.TabIndex = 4;
            txtBairro.TabStop = false;
            txtBairro.TextAlign = HorizontalAlignment.Left;
            txtBairro.TrailingIcon = null;
            txtBairro.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            txtEndereco.AnimateReadOnly = false;
            txtEndereco.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereco.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereco.BackgroundImageLayout = ImageLayout.None;
            txtEndereco.CharacterCasing = CharacterCasing.Normal;
            txtEndereco.Depth = 0;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereco.HideSelection = true;
            txtEndereco.Hint = "Endereço";
            txtEndereco.LeadingIcon = null;
            txtEndereco.Location = new Point(36, 160);
            txtEndereco.MaxLength = 32767;
            txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.PrefixSuffixText = null;
            txtEndereco.ReadOnly = false;
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.ShortcutsEnabled = true;
            txtEndereco.Size = new Size(858, 48);
            txtEndereco.TabIndex = 3;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtNomeDoAluno
            // 
            txtNomeDoAluno.AnimateReadOnly = false;
            txtNomeDoAluno.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeDoAluno.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeDoAluno.BackgroundImageLayout = ImageLayout.None;
            txtNomeDoAluno.CharacterCasing = CharacterCasing.Normal;
            txtNomeDoAluno.Depth = 0;
            txtNomeDoAluno.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeDoAluno.HideSelection = true;
            txtNomeDoAluno.Hint = "Nome Completo";
            txtNomeDoAluno.LeadingIcon = null;
            txtNomeDoAluno.Location = new Point(36, 94);
            txtNomeDoAluno.MaxLength = 32767;
            txtNomeDoAluno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeDoAluno.Name = "txtNomeDoAluno";
            txtNomeDoAluno.PasswordChar = '\0';
            txtNomeDoAluno.PrefixSuffixText = null;
            txtNomeDoAluno.ReadOnly = false;
            txtNomeDoAluno.RightToLeft = RightToLeft.No;
            txtNomeDoAluno.SelectedText = "";
            txtNomeDoAluno.SelectionLength = 0;
            txtNomeDoAluno.SelectionStart = 0;
            txtNomeDoAluno.ShortcutsEnabled = true;
            txtNomeDoAluno.Size = new Size(858, 48);
            txtNomeDoAluno.TabIndex = 2;
            txtNomeDoAluno.TabStop = false;
            txtNomeDoAluno.TextAlign = HorizontalAlignment.Left;
            txtNomeDoAluno.TrailingIcon = null;
            txtNomeDoAluno.UseSystemPasswordChar = false;
            // 
            // txtDataDeNascimento
            // 
            txtDataDeNascimento.AllowPromptAsInput = true;
            txtDataDeNascimento.AnimateReadOnly = false;
            txtDataDeNascimento.AsciiOnly = false;
            txtDataDeNascimento.BackgroundImageLayout = ImageLayout.None;
            txtDataDeNascimento.BeepOnError = false;
            txtDataDeNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataDeNascimento.Depth = 0;
            txtDataDeNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataDeNascimento.HidePromptOnLeave = false;
            txtDataDeNascimento.HideSelection = true;
            txtDataDeNascimento.Hint = "Data de Nascimento";
            txtDataDeNascimento.InsertKeyMode = InsertKeyMode.Default;
            txtDataDeNascimento.LeadingIcon = null;
            txtDataDeNascimento.Location = new Point(582, 28);
            txtDataDeNascimento.Mask = "99/99/9999";
            txtDataDeNascimento.MaxLength = 32767;
            txtDataDeNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataDeNascimento.Name = "txtDataDeNascimento";
            txtDataDeNascimento.PasswordChar = '\0';
            txtDataDeNascimento.PrefixSuffixText = null;
            txtDataDeNascimento.PromptChar = '_';
            txtDataDeNascimento.ReadOnly = false;
            txtDataDeNascimento.RejectInputOnFirstFailure = false;
            txtDataDeNascimento.ResetOnPrompt = true;
            txtDataDeNascimento.ResetOnSpace = true;
            txtDataDeNascimento.RightToLeft = RightToLeft.No;
            txtDataDeNascimento.SelectedText = "";
            txtDataDeNascimento.SelectionLength = 0;
            txtDataDeNascimento.SelectionStart = 0;
            txtDataDeNascimento.ShortcutsEnabled = true;
            txtDataDeNascimento.Size = new Size(312, 48);
            txtDataDeNascimento.SkipLiterals = true;
            txtDataDeNascimento.TabIndex = 1;
            txtDataDeNascimento.TabStop = false;
            txtDataDeNascimento.Text = "  /  /";
            txtDataDeNascimento.TextAlign = HorizontalAlignment.Left;
            txtDataDeNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataDeNascimento.TrailingIcon = null;
            txtDataDeNascimento.UseSystemPasswordChar = false;
            txtDataDeNascimento.ValidatingType = null;
            // 
            // txtMatricula
            // 
            txtMatricula.AnimateReadOnly = false;
            txtMatricula.AutoCompleteMode = AutoCompleteMode.None;
            txtMatricula.AutoCompleteSource = AutoCompleteSource.None;
            txtMatricula.BackgroundImageLayout = ImageLayout.None;
            txtMatricula.CharacterCasing = CharacterCasing.Normal;
            txtMatricula.Depth = 0;
            txtMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatricula.HideSelection = true;
            txtMatricula.Hint = "Matricula";
            txtMatricula.LeadingIcon = null;
            txtMatricula.Location = new Point(36, 28);
            txtMatricula.MaxLength = 32767;
            txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PasswordChar = '\0';
            txtMatricula.PrefixSuffixText = null;
            txtMatricula.ReadOnly = false;
            txtMatricula.RightToLeft = RightToLeft.No;
            txtMatricula.SelectedText = "";
            txtMatricula.SelectionLength = 0;
            txtMatricula.SelectionStart = 0;
            txtMatricula.ShortcutsEnabled = true;
            txtMatricula.Size = new Size(400, 48);
            txtMatricula.TabIndex = 0;
            txtMatricula.TabStop = false;
            txtMatricula.TextAlign = HorizontalAlignment.Left;
            txtMatricula.TrailingIcon = null;
            txtMatricula.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(listView1);
            tabPageConsulta.Location = new Point(4, 29);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(933, 548);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta de Aluno";
            tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 6);
            listView1.Name = "listView1";
            listView1.Size = new Size(921, 479);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(586, 489);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MinimumSize = new Size(150, 50);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(150, 50);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(776, 489);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MinimumSize = new Size(150, 50);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(150, 50);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += materialButton2_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(389, 489);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MinimumSize = new Size(150, 50);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(150, 50);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FormAluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 648);
            Controls.Add(TabControlAluno);
            DrawerTabControl = TabControlAluno;
            Name = "FormAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestão Acadêmica - Alunos";
            TabControlAluno.ResumeLayout(false);
            tabPageAluno.ResumeLayout(false);
            tabPageAluno.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControlAluno;
        private TabPage tabPageAluno;
        private TabPage tabPageConsulta;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataDeNascimento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeDoAluno;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancela;
        private ListView listView1;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
    }
}