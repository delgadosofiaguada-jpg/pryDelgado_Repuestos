namespace pryDelgado_GestionRepuestos
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        string[,] Repuestos = new string[100, 5];
        int C = 0;

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {

        }
        private void cmdRegistrar_Click_1(object sender, EventArgs e)
        {
            if (C >= 100)
            {
                MessageBox.Show("Ya se ingresaron los 100 repuestos permitidos.");
                return;
            }

            if (lstMarca.Text == "")
            {
                MessageBox.Show("Debe seleccionar una marca.");
                return;
            }

            if (mtbNumero.Text == "")
            {
                MessageBox.Show("Debe ingresar un número de repuesto.");
                return;
            }


            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción.");
                return;
            }
            if (mtbPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio.");
                return;
            }

            if (lstOrigen.Text == "")
            {
                MessageBox.Show("Debe seleccionar un origen.");
                return;
            }

            string Numero = mtbNumero.Text;
            int Num;

            try
            {
                Num = int.Parse(Numero);
                if (Numero.Length > 6)
                {
                    MessageBox.Show("El número de repuesto no puede tener más de 6 dígitos.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un número de repuesto válido (solo números).");
                return;
            }

            // Validar repetido
            for (int i = 0; i < C; i++)
            {
                if (Repuestos[i, 2] == Numero)
                {
                    MessageBox.Show("Ya existe un repuesto con ese número.");
                    return;
                }
            }

            string Precio = mtbPrecio.Text;
            float Prec;

            try
            {
                Prec = float.Parse(Precio);
                if (Prec <= 0)
                {
                    MessageBox.Show("Ingrese un precio mayor a 0.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            // Carga en matriz
            Repuestos[C, 0] = lstMarca.Text;
            Repuestos[C, 1] = lstOrigen.Text;
            Repuestos[C, 2] = Numero;
            Repuestos[C, 3] = txtDescripcion.Text;
            Repuestos[C, 4] = Precio;
            C++;

            MessageBox.Show("Repuesto cargado correctamente.");

            // Limpiar
            lstMarca.SelectedIndex = -1;
            mtbNumero.Text = "";
            txtDescripcion.Text = "";
            mtbPrecio.Text = "";

        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            if (C == 0)
            {
                MessageBox.Show("No hay repuestos cargados.");
                return;
            }

            if (lstMarca2.Text == "")
            {
                MessageBox.Show("Debe seleccionar una marca para consultar.");
                return;
            }

            char Marca = lstMarca2.Text[0];
            char Origen = rbNacional.Checked ? 'N' : 'I';
            bool Encontrado = false;

            ltbResultados.Items.Clear();

            for (int i = 0; i < C; i++)
            {
                if (Repuestos[i, 0][0] == Marca && Repuestos[i, 1][0] == Origen)
                {
                    Encontrado = true;
                    ltbResultados.Items.Add(
                        "Número: " + Repuestos[i, 2] +
                        " | Descripción: " + Repuestos[i, 3] +
                        " | Precio: $" + Repuestos[i, 4]
                    );
                }
            }

            if (!Encontrado)
            {
                ltbResultados.Items.Add("No se encontraron repuestos con esos criterios.");
            }
        }
    }
}

    