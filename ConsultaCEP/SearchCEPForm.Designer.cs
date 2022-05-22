namespace ConsultaCEP
{
    partial class SearchCEPForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.CEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.GroupBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.district = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(309, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(182, 37);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Consultar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // CEP
            // 
            this.CEP.AutoSize = true;
            this.CEP.Location = new System.Drawing.Point(34, 27);
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(37, 20);
            this.CEP.TabIndex = 1;
            this.CEP.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.SystemColors.Info;
            this.txtCEP.Location = new System.Drawing.Point(34, 60);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(226, 27);
            this.txtCEP.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.Controls.Add(this.txtCity);
            this.Result.Controls.Add(this.txtStreet);
            this.Result.Controls.Add(this.txtState);
            this.Result.Controls.Add(this.txtDistrict);
            this.Result.Controls.Add(this.city);
            this.Result.Controls.Add(this.district);
            this.Result.Controls.Add(this.street);
            this.Result.Controls.Add(this.state);
            this.Result.Location = new System.Drawing.Point(34, 112);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(457, 226);
            this.Result.TabIndex = 0;
            this.Result.TabStop = false;
            this.Result.Text = "Resultado:";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.LightGray;
            this.txtCity.Location = new System.Drawing.Point(28, 168);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(323, 27);
            this.txtCity.TabIndex = 0;
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.LightGray;
            this.txtStreet.Location = new System.Drawing.Point(28, 43);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(423, 27);
            this.txtStreet.TabIndex = 0;
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.LightGray;
            this.txtState.Location = new System.Drawing.Point(357, 168);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(94, 27);
            this.txtState.TabIndex = 0;
            // 
            // txtDistrict
            // 
            this.txtDistrict.BackColor = System.Drawing.Color.LightGray;
            this.txtDistrict.Location = new System.Drawing.Point(28, 99);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(423, 27);
            this.txtDistrict.TabIndex = 0;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(28, 142);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 23);
            this.city.TabIndex = 0;
            this.city.Text = "Cidade:";
            this.city.Click += new System.EventHandler(this.city_Click);
            // 
            // district
            // 
            this.district.Location = new System.Drawing.Point(28, 73);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(100, 23);
            this.district.TabIndex = 0;
            this.district.Text = "Bairro:";
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(28, 23);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 23);
            this.street.TabIndex = 0;
            this.street.Text = "Rua:";
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(370, 142);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(65, 23);
            this.state.TabIndex = 0;
            this.state.Text = "Estado:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(378, 356);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Sair";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(278, 356);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 28);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Limpar";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SearchCEPForm
            // 
            this.ClientSize = new System.Drawing.Size(581, 413);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.CEP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SearchCEPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta CEP";
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearch;
        private Label CEP;
        private TextBox txtCEP;
        private GroupBox Result;
        private TextBox txtState;
        private Label state;
        private TextBox txtCity;
        private Label street;
        private TextBox txtStreet;
        private Label district;
        private TextBox txtDistrict;
        private Label city;
        private Button btnExit;
        private Button btnClear;
    }
}