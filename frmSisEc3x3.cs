namespace ECUACIONES_SIMULTANEAS_3X3
{
    public partial class frmCramer3x3 : Form
    {
        public frmCramer3x3()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static float Determinante(float[,] A)
        {
            int i, j, k;
            float aux, pivote, pivote1, deter = 1;

            for (i = 0; i < 3; i++)
            {
                pivote = A[i, i];
                for (j = i + 1; j < 3; j++)
                {
                    pivote1 = A[j, i];
                    aux = pivote1 / pivote;
                    for (k = 0; k < 3; k++)
                    {
                        A[j, k] = A[j, k] - aux * A[i, k];
                    }
                }
            }

            for (i = 0; i < 3; i++)
                deter *= A[i, i];

            return deter;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtA11.Text = "";
            txtA12.Text = "";
            txtA13.Text = "";
            txtB1.Text = "";
            txtA21.Text = "";
            txtA22.Text = "";
            txtA23.Text = "";
            txtB2.Text = "";
            txtA31.Text = "";
            txtA32.Text = "";
            txtA33.Text = "";
            txtB3.Text = "";
            txtX.Text = "";
            txtY.Text = "";
            txtZ.Text = "";
            txtA11.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtA11.Text.Trim() == "")
            {
                MessageBox.Show("El coeficiente en X de la primera ecuación no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtA11.Text = "";
                txtA11.Focus();
            }
            else if (txtA12.Text.Trim() == "")
            {
                MessageBox.Show("El coeficiente en Y de la primera ecuación no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtA12.Text = "";
                txtA12.Focus();
            }
            else if (txtA13.Text.Trim() == "")
            {
                MessageBox.Show("El coeficiente en Z de la primera ecuación no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtA13.Text = "";
                txtA13.Focus();
            }
            else if (txtB1.Text.Trim() == "")
            {
                MessageBox.Show("El coeficiente libre de la primera ecuación no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtB1.Text = "";
                txtB1.Focus();
            }
            else if (txtA21.Text.Trim() == "")
            {
                MessageBox.Show("El coeficiente en X de la segunda ecuación no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtA21.Text = "";
                txtA21.Focus();
            }
            else if (txtA22.Text.Trim() == "")
            {
                MessageBox.Show("El coeficiente en Y de la segunda ecuación no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtA22.Text = "";
                txtA22.Focus();
            }
            else if (txtA23.Text.Trim() == "")
            {
                MessageBox.Show("El coeficiente en Z de la segunda ecuación no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtA23.Text = "";
                txtA23.Focus();
            }
            else if (txtB2.Text.Trim() == "")
            {
                MessageBox.Show("El coeficiente libre de la segunda ecuación no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtB2.Text = "";
                txtB2.Focus();
            }
            else if (txtA31.Text.Trim() == "")
            {
                MessageBox.Show("El coeficiente en X de la tercera ecuación no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtA31.Text = "";
                txtA31.Focus();
            }
            else if (txtA32.Text.Trim() == "")
            {
                MessageBox.Show("El coeficiente en Y de la tercera ecuación no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtA32.Text = "";
                txtA32.Focus();
            }
            else if (txtA33.Text.Trim() == "")
            {
                MessageBox.Show("El coeficiente en Z de la tercera ecuación no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtA33.Text = "";
                txtA33.Focus();
            }
            else if (txtB3.Text.Trim() == "")
            {
                MessageBox.Show("El coeficiente libre de la tercera ecuación no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtB3.Text = "";
                txtB3.Focus();
            }
            else
            {
                int i, j;
                float detA, detx, X;
                float[] b = new float[3];
                float[,] A = new float[3, 3], A1 = new float[3, 3];

                A[0, 0] = float.Parse(txtA11.Text.ToString());
                A[0, 1] = float.Parse(txtA12.Text.ToString());
                A[0, 2] = float.Parse(txtA13.Text.ToString());
                A[1, 0] = float.Parse(txtA21.Text.ToString());
                A[1, 1] = float.Parse(txtA22.Text.ToString());
                A[1, 2] = float.Parse(txtA23.Text.ToString());
                A[2, 0] = float.Parse(txtA31.Text.ToString());
                A[2, 1] = float.Parse(txtA32.Text.ToString());
                A[2, 2] = float.Parse(txtA33.Text.ToString());

                A1[0, 0] = float.Parse(txtA11.Text.ToString());
                A1[0, 1] = float.Parse(txtA12.Text.ToString());
                A1[0, 2] = float.Parse(txtA13.Text.ToString());
                A1[1, 0] = float.Parse(txtA21.Text.ToString());
                A1[1, 1] = float.Parse(txtA22.Text.ToString());
                A1[1, 2] = float.Parse(txtA23.Text.ToString());
                A1[2, 0] = float.Parse(txtA31.Text.ToString());
                A1[2, 1] = float.Parse(txtA32.Text.ToString());
                A1[2, 2] = float.Parse(txtA33.Text.ToString());

                b[0] = float.Parse(txtB1.Text.ToString());
                b[1] = float.Parse(txtB2.Text.ToString());
                b[2] = float.Parse(txtB3.Text.ToString());

                detA = Determinante(A);

                if (detA == 0)
                {
                    MessageBox.Show("Sistema incompatible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Sustitución de columna de X
                    
                    //Recuperar los valores originales
                    for (i = 0; i < 3; i++)
                        for (j = 0; j < 3; j++)
                            A[i, j] = A1[i, j];

                    //Sustitución de b sobre la columna de k
                    for (i = 0; i < 3; i++)
                        A[i, 0] = b[i];

                    detx = Determinante(A);

                    X = (float)(detx / detA);

                    txtX.Text = X.ToString();

                    //Recuperar los valores originales
                    for (i = 0; i < 3; i++)
                        for (j = 0; j < 3; j++)
                            A[i, j] = A1[i, j];

                    //Sustitución de b sobre la columna de k
                    for (i = 0; i < 3; i++)
                        A[i, 1] = b[i];

                    detx = Determinante(A);

                    X = (float)(detx / detA);

                    txtY.Text = X.ToString();

                    //Recuperar los valores originales
                    for (i = 0; i < 3; i++)
                        for (j = 0; j < 3; j++)
                            A[i, j] = A1[i, j];

                    //Sustitución de b sobre la columna de k
                    for (i = 0; i < 3; i++)
                        A[i, 2] = b[i];

                    detx = Determinante(A);

                    X = (float)(detx / detA);

                    txtZ.Text = X.ToString();

                }

            }
        }
    }
}