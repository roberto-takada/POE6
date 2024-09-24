namespace ProjetoCadastro
{
    partial class FormCadastroAluno
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAluno));
            TabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            btnConfirma = new ReaLTaiizor.Controls.MaterialButton();
            btnCancela = new ReaLTaiizor.Controls.MaterialButton();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNomeCompleto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            imageList1 = new ImageList(components);
            TabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Controls.Add(tabPageCadastro);
            TabControlCadastro.Controls.Add(tabPageConsulta);
            TabControlCadastro.Depth = 0;
            TabControlCadastro.Dock = DockStyle.Fill;
            TabControlCadastro.ImageList = imageList1;
            TabControlCadastro.Location = new Point(3, 64);
            TabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCadastro.Multiline = true;
            TabControlCadastro.Name = "TabControlCadastro";
            TabControlCadastro.SelectedIndex = 0;
            TabControlCadastro.Size = new Size(1039, 635);
            TabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnConfirma);
            tabPageCadastro.Controls.Add(btnCancela);
            tabPageCadastro.Controls.Add(txtSenha);
            tabPageCadastro.Controls.Add(cboEstado);
            tabPageCadastro.Controls.Add(txtCidade);
            tabPageCadastro.Controls.Add(txtBairro);
            tabPageCadastro.Controls.Add(txtEndereco);
            tabPageCadastro.Controls.Add(txtNomeCompleto);
            tabPageCadastro.Controls.Add(txtNascimento);
            tabPageCadastro.Controls.Add(txtMatricula);
            tabPageCadastro.ImageKey = "form.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(1031, 600);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // btnConfirma
            // 
            btnConfirma.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirma.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirma.Depth = 0;
            btnConfirma.HighEmphasis = true;
            btnConfirma.Icon = null;
            btnConfirma.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnConfirma.Location = new Point(667, 526);
            btnConfirma.Margin = new Padding(4, 6, 4, 6);
            btnConfirma.MinimumSize = new Size(150, 60);
            btnConfirma.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnConfirma.Name = "btnConfirma";
            btnConfirma.NoAccentTextColor = Color.Empty;
            btnConfirma.Size = new Size(150, 60);
            btnConfirma.TabIndex = 9;
            btnConfirma.Text = "Confirma";
            btnConfirma.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfirma.UseAccentColor = false;
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // btnCancela
            // 
            btnCancela.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancela.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancela.Depth = 0;
            btnCancela.HighEmphasis = true;
            btnCancela.Icon = null;
            btnCancela.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancela.Location = new Point(220, 526);
            btnCancela.Margin = new Padding(4, 6, 4, 6);
            btnCancela.MinimumSize = new Size(150, 60);
            btnCancela.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancela.Name = "btnCancela";
            btnCancela.NoAccentTextColor = Color.Empty;
            btnCancela.Size = new Size(150, 60);
            btnCancela.TabIndex = 8;
            btnCancela.Text = "Cancelar";
            btnCancela.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancela.UseAccentColor = false;
            btnCancela.UseVisualStyleBackColor = true;
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
            txtSenha.LeadingIcon = (Image)resources.GetObject("txtSenha.LeadingIcon");
            txtSenha.Location = new Point(91, 448);
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
            txtSenha.Size = new Size(831, 48);
            txtSenha.TabIndex = 7;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = true;
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
            cboEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboEstado.Location = new Point(771, 361);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(151, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 6;
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
            txtCidade.Location = new Point(91, 362);
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
            txtCidade.Size = new Size(600, 48);
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
            txtBairro.Location = new Point(91, 273);
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
            txtBairro.Size = new Size(831, 48);
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
            txtEndereco.Location = new Point(91, 192);
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
            txtEndereco.Size = new Size(831, 48);
            txtEndereco.TabIndex = 3;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.AnimateReadOnly = false;
            txtNomeCompleto.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeCompleto.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeCompleto.BackgroundImageLayout = ImageLayout.None;
            txtNomeCompleto.CharacterCasing = CharacterCasing.Normal;
            txtNomeCompleto.Depth = 0;
            txtNomeCompleto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeCompleto.HideSelection = true;
            txtNomeCompleto.Hint = "Nome Completo";
            txtNomeCompleto.LeadingIcon = null;
            txtNomeCompleto.Location = new Point(91, 113);
            txtNomeCompleto.MaxLength = 32767;
            txtNomeCompleto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.PasswordChar = '\0';
            txtNomeCompleto.PrefixSuffixText = null;
            txtNomeCompleto.ReadOnly = false;
            txtNomeCompleto.RightToLeft = RightToLeft.No;
            txtNomeCompleto.SelectedText = "";
            txtNomeCompleto.SelectionLength = 0;
            txtNomeCompleto.SelectionStart = 0;
            txtNomeCompleto.ShortcutsEnabled = true;
            txtNomeCompleto.Size = new Size(831, 48);
            txtNomeCompleto.TabIndex = 2;
            txtNomeCompleto.TabStop = false;
            txtNomeCompleto.TextAlign = HorizontalAlignment.Left;
            txtNomeCompleto.TrailingIcon = null;
            txtNomeCompleto.UseSystemPasswordChar = false;
            // 
            // txtNascimento
            // 
            txtNascimento.AllowPromptAsInput = true;
            txtNascimento.AnimateReadOnly = false;
            txtNascimento.AsciiOnly = false;
            txtNascimento.BackgroundImageLayout = ImageLayout.None;
            txtNascimento.BeepOnError = false;
            txtNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtNascimento.Depth = 0;
            txtNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNascimento.HidePromptOnLeave = false;
            txtNascimento.HideSelection = true;
            txtNascimento.Hint = "Data de Nascimento";
            txtNascimento.InsertKeyMode = InsertKeyMode.Default;
            txtNascimento.LeadingIcon = null;
            txtNascimento.Location = new Point(771, 38);
            txtNascimento.Mask = "99/99/9999";
            txtNascimento.MaxLength = 32767;
            txtNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNascimento.Name = "txtNascimento";
            txtNascimento.PasswordChar = '\0';
            txtNascimento.PrefixSuffixText = null;
            txtNascimento.PromptChar = '_';
            txtNascimento.ReadOnly = false;
            txtNascimento.RejectInputOnFirstFailure = false;
            txtNascimento.ResetOnPrompt = true;
            txtNascimento.ResetOnSpace = true;
            txtNascimento.RightToLeft = RightToLeft.No;
            txtNascimento.SelectedText = "";
            txtNascimento.SelectionLength = 0;
            txtNascimento.SelectionStart = 0;
            txtNascimento.ShortcutsEnabled = true;
            txtNascimento.Size = new Size(151, 48);
            txtNascimento.SkipLiterals = true;
            txtNascimento.TabIndex = 1;
            txtNascimento.TabStop = false;
            txtNascimento.Text = "  /  /";
            txtNascimento.TextAlign = HorizontalAlignment.Left;
            txtNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtNascimento.TrailingIcon = null;
            txtNascimento.UseSystemPasswordChar = false;
            txtNascimento.ValidatingType = null;
            txtNascimento.Click += materialMaskedTextBox1_Click;
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
            txtMatricula.Location = new Point(91, 38);
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
            txtMatricula.Size = new Size(337, 48);
            txtMatricula.TabIndex = 0;
            txtMatricula.TabStop = false;
            txtMatricula.TextAlign = HorizontalAlignment.Left;
            txtMatricula.TrailingIcon = null;
            txtMatricula.UseSystemPasswordChar = false;
            txtMatricula.Click += materialTextBoxEdit1_Click;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.ImageKey = "search.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(1031, 600);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // FormCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 702);
            Controls.Add(TabControlCadastro);
            DrawerTabControl = TabControlCadastro;
            Name = "FormCadastroAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alunos";
            Load += FormCadastroAluno_Load;
            TabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControlCadastro;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        public ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtNascimento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeCompleto;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialButton btnConfirma;
        private ReaLTaiizor.Controls.MaterialButton btnCancela;
    }
}