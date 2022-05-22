namespace ConsultaCEP
{
    public partial class SearchCEPForm : Form
    {
        public SearchCEPForm()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                using (var ws = new WebServiceCorreios.AtendeClienteClient())
                {
                    try
                    {

                        var adress = ws.consultaCEP(txtCEP.Text.Trim());
                        this.txtStreet.Text = adress.end;
                        this.txtDistrict.Text = adress.bairro;
                        this.txtCity.Text = adress.cidade;
                        this.txtState.Text = adress.uf;
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            else
            {
                MessageBox.Show("Informe um CEP Valido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCEP.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtDistrict.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtState.Text = string.Empty;

        }

        private void city_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}