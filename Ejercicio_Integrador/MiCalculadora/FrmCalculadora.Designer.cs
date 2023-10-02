namespace MiCalculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            LblResultado = new Label();
            CmbOperacion = new ComboBox();
            GrpRepresetarResul = new GroupBox();
            RdbBinario = new RadioButton();
            RdbDecimal = new RadioButton();
            LblPrimerOperador = new Label();
            LblSegundoOperdor = new Label();
            TxtPrimerOperador = new TextBox();
            TxtSegundoOperador = new TextBox();
            BtnLimpiar = new Button();
            BtnOperar = new Button();
            BtnCerrar = new Button();
            LblOperacion = new Label();
            GrpRepresetarResul.SuspendLayout();
            SuspendLayout();
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LblResultado.Location = new Point(12, 27);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(167, 45);
            LblResultado.TabIndex = 0;
            LblResultado.Text = "Resultado:";
            // 
            // CmbOperacion
            // 
            CmbOperacion.FormattingEnabled = true;
            CmbOperacion.Location = new Point(183, 222);
            CmbOperacion.Name = "CmbOperacion";
            CmbOperacion.Size = new Size(158, 23);
            CmbOperacion.TabIndex = 1;
            // 
            // GrpRepresetarResul
            // 
            GrpRepresetarResul.Controls.Add(RdbBinario);
            GrpRepresetarResul.Controls.Add(RdbDecimal);
            GrpRepresetarResul.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GrpRepresetarResul.Location = new Point(183, 95);
            GrpRepresetarResul.Name = "GrpRepresetarResul";
            GrpRepresetarResul.Size = new Size(157, 85);
            GrpRepresetarResul.TabIndex = 2;
            GrpRepresetarResul.TabStop = false;
            GrpRepresetarResul.Text = "Representar resultado en:";
            // 
            // RdbBinario
            // 
            RdbBinario.AutoSize = true;
            RdbBinario.Location = new Point(6, 47);
            RdbBinario.Name = "RdbBinario";
            RdbBinario.Size = new Size(62, 19);
            RdbBinario.TabIndex = 1;
            RdbBinario.TabStop = true;
            RdbBinario.Text = "Binario";
            RdbBinario.UseVisualStyleBackColor = true;
            RdbBinario.CheckedChanged += RdbBinario_CheckedChanged;
            // 
            // RdbDecimal
            // 
            RdbDecimal.AutoSize = true;
            RdbDecimal.Location = new Point(6, 22);
            RdbDecimal.Name = "RdbDecimal";
            RdbDecimal.Size = new Size(69, 19);
            RdbDecimal.TabIndex = 0;
            RdbDecimal.TabStop = true;
            RdbDecimal.Text = "Decimal";
            RdbDecimal.UseVisualStyleBackColor = true;
            RdbDecimal.CheckedChanged += RdbDecimal_CheckedChanged;
            // 
            // LblPrimerOperador
            // 
            LblPrimerOperador.AutoSize = true;
            LblPrimerOperador.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblPrimerOperador.Location = new Point(12, 198);
            LblPrimerOperador.Name = "LblPrimerOperador";
            LblPrimerOperador.Size = new Size(156, 21);
            LblPrimerOperador.TabIndex = 4;
            LblPrimerOperador.Text = "Primer operador:     ";
            // 
            // LblSegundoOperdor
            // 
            LblSegundoOperdor.AutoSize = true;
            LblSegundoOperdor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblSegundoOperdor.Location = new Point(356, 198);
            LblSegundoOperdor.Name = "LblSegundoOperdor";
            LblSegundoOperdor.Size = new Size(154, 21);
            LblSegundoOperdor.TabIndex = 5;
            LblSegundoOperdor.Text = "Segundo operador:";
            // 
            // TxtPrimerOperador
            // 
            TxtPrimerOperador.Location = new Point(12, 222);
            TxtPrimerOperador.Name = "TxtPrimerOperador";
            TxtPrimerOperador.Size = new Size(157, 23);
            TxtPrimerOperador.TabIndex = 6;
            TxtPrimerOperador.TextChanged += TxtPrimerOperador_TextChanged;
            // 
            // TxtSegundoOperador
            // 
            TxtSegundoOperador.Location = new Point(356, 222);
            TxtSegundoOperador.Name = "TxtSegundoOperador";
            TxtSegundoOperador.Size = new Size(154, 23);
            TxtSegundoOperador.TabIndex = 7;
            TxtSegundoOperador.TextChanged += TxtSegundoOperador_TextChanged;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(183, 268);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(157, 33);
            BtnLimpiar.TabIndex = 8;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnOperar
            // 
            BtnOperar.Location = new Point(12, 268);
            BtnOperar.Name = "BtnOperar";
            BtnOperar.Size = new Size(157, 33);
            BtnOperar.TabIndex = 9;
            BtnOperar.Text = "Operar";
            BtnOperar.UseVisualStyleBackColor = true;
            BtnOperar.Click += BtnOperar_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Location = new Point(356, 268);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(154, 33);
            BtnCerrar.TabIndex = 10;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // LblOperacion
            // 
            LblOperacion.AutoSize = true;
            LblOperacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblOperacion.Location = new Point(183, 198);
            LblOperacion.Name = "LblOperacion";
            LblOperacion.Size = new Size(158, 21);
            LblOperacion.TabIndex = 11;
            LblOperacion.Text = "         Operación         ";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(537, 345);
            Controls.Add(LblOperacion);
            Controls.Add(BtnCerrar);
            Controls.Add(BtnOperar);
            Controls.Add(BtnLimpiar);
            Controls.Add(TxtSegundoOperador);
            Controls.Add(TxtPrimerOperador);
            Controls.Add(LblSegundoOperdor);
            Controls.Add(LblPrimerOperador);
            Controls.Add(GrpRepresetarResul);
            Controls.Add(CmbOperacion);
            Controls.Add(LblResultado);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            Text = "Calculadora Alumna: Rubén López";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            GrpRepresetarResul.ResumeLayout(false);
            GrpRepresetarResul.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblResultado;
        private ComboBox CmbOperacion;
        private GroupBox GrpRepresetarResul;
        private RadioButton RdbBinario;
        private RadioButton RdbDecimal;
        private Label LblPrimerOperador;
        private Label LblSegundoOperdor;
        private TextBox TxtPrimerOperador;
        private TextBox TxtSegundoOperador;
        private Button BtnLimpiar;
        private Button BtnOperar;
        private Button BtnCerrar;
        private Label LblOperacion;
    }
}