using Entidades;
using System.Drawing.Printing;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado = null;
        private Operacion calculadora;
        private Esistema sistema;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.CmbOperacion.Items.AddRange(new object[] { '+', '-', '/', '*' });
            this.RdbDecimal.Checked = true;
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            char simbOperador = CmbOperacion.Text.FirstOrDefault();
            double primerValor;
            double segundoValor;

            if (double.TryParse(TxtPrimerOperador.Text, out primerValor) && double.TryParse(TxtSegundoOperador.Text, out segundoValor))
            {
                this.calculadora = new Operacion(this.primerOperando, this.segundoOperando);
                this.resultado = this.calculadora.Operar(simbOperador);
                SetResultado();
            }
            else
            {
                MessageBox.Show("¡Datos ingresados Invalidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetResultado()
        {
            if (this.resultado is not null)
            {
                LblResultado.Text = $"Resultado:     {this.resultado.ConvertirA(this.sistema)}";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.TxtPrimerOperador.Clear();
            this.TxtSegundoOperador.Clear();
            this.primerOperando = null;
            this.segundoOperando = null;
            this.resultado = null;
            this.RdbDecimal.Checked = true;
            this.RdbBinario.Checked = false;
            this.CmbOperacion.SelectedValue = null;
            this.CmbOperacion.Text = null;
            LblResultado.Text = "Resultado:";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) { e.Cancel = true; }
        }

        private void TxtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            this.primerOperando = new Numeracion(Esistema.DECIMAL, TxtPrimerOperador.Text);
        }

        private void TxtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            this.segundoOperando = new Numeracion(Esistema.DECIMAL, TxtSegundoOperador.Text);
        }

        private void RdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbDecimal.Checked)
            {
                this.sistema = Esistema.DECIMAL;
                SetResultado();
            }
        }

        private void RdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbBinario.Checked)
            {
                this.sistema = Esistema.BINARIO;
                SetResultado();
            }
        }
    }
}