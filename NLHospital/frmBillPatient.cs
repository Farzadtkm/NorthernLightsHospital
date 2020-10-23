using System;
using System.ComponentModel;
using System.Data;
using NLHospitalLibrary;

namespace NLHospital
{
    /// <summary>
    /// Summary description for BillPatient.
    /// </summary>
    public class frmBillPatient : NLHBase
    {
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRTV;
        private System.Windows.Forms.Label lblTotalTV;
        private System.Windows.Forms.Label lblTotalPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalSemi;
        private System.Windows.Forms.Label lblPRate;
        private System.Windows.Forms.Label lblTotalPrivate;
        private System.Windows.Forms.Label lblRSemi;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private readonly Container components = null;

        public frmBillPatient()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRTV = new System.Windows.Forms.Label();
            this.lblTotalTV = new System.Windows.Forms.Label();
            this.lblRPhone = new System.Windows.Forms.Label();
            this.lblTotalPhone = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRSemi = new System.Windows.Forms.Label();
            this.lblTotalSemi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPRate = new System.Windows.Forms.Label();
            this.lblTotalPrivate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(29, 55);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(107, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Health Number:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(29, 83);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(56, 17);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Patient:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(528, 55);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(40, 17);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Length of stay:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Daily Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chargeable:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "TV";
            // 
            // lblRTV
            // 
            this.lblRTV.AutoSize = true;
            this.lblRTV.Location = new System.Drawing.Point(298, 157);
            this.lblRTV.Name = "lblRTV";
            this.lblRTV.Size = new System.Drawing.Size(46, 17);
            this.lblRTV.TabIndex = 8;
            this.lblRTV.Text = "label2";
            this.lblRTV.Visible = false;
            this.lblRTV.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTotalTV
            // 
            this.lblTotalTV.AutoSize = true;
            this.lblTotalTV.Location = new System.Drawing.Point(470, 157);
            this.lblTotalTV.Name = "lblTotalTV";
            this.lblTotalTV.Size = new System.Drawing.Size(46, 17);
            this.lblTotalTV.TabIndex = 9;
            this.lblTotalTV.Text = "label3";
            this.lblTotalTV.Visible = false;
            // 
            // lblRPhone
            // 
            this.lblRPhone.AutoSize = true;
            this.lblRPhone.Location = new System.Drawing.Point(298, 185);
            this.lblRPhone.Name = "lblRPhone";
            this.lblRPhone.Size = new System.Drawing.Size(46, 17);
            this.lblRPhone.TabIndex = 10;
            this.lblRPhone.Text = "label8";
            this.lblRPhone.Visible = false;
            // 
            // lblTotalPhone
            // 
            this.lblTotalPhone.AutoSize = true;
            this.lblTotalPhone.Location = new System.Drawing.Point(470, 185);
            this.lblTotalPhone.Name = "lblTotalPhone";
            this.lblTotalPhone.Size = new System.Drawing.Size(46, 17);
            this.lblTotalPhone.TabIndex = 11;
            this.lblTotalPhone.Text = "label9";
            this.lblTotalPhone.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Semi-Private Room";
            // 
            // lblRSemi
            // 
            this.lblRSemi.AutoSize = true;
            this.lblRSemi.Location = new System.Drawing.Point(298, 212);
            this.lblRSemi.Name = "lblRSemi";
            this.lblRSemi.Size = new System.Drawing.Size(54, 17);
            this.lblRSemi.TabIndex = 13;
            this.lblRSemi.Text = "label11";
            this.lblRSemi.Visible = false;
            // 
            // lblTotalSemi
            // 
            this.lblTotalSemi.AutoSize = true;
            this.lblTotalSemi.Location = new System.Drawing.Point(470, 212);
            this.lblTotalSemi.Name = "lblTotalSemi";
            this.lblTotalSemi.Size = new System.Drawing.Size(54, 17);
            this.lblTotalSemi.TabIndex = 14;
            this.lblTotalSemi.Text = "label12";
            this.lblTotalSemi.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(134, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total now due:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(470, 295);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(46, 17);
            this.lblGrandTotal.TabIndex = 17;
            this.lblGrandTotal.Text = "label3";
            this.lblGrandTotal.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(384, 351);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 26);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "Print";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(490, 351);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(90, 26);
            this.btnQuit.TabIndex = 19;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Admission ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(211, 22);
            this.txtID.TabIndex = 20;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(374, 9);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(192, 27);
            this.btnRetrieve.TabIndex = 22;
            this.btnRetrieve.Text = "Retrieve Patient Information";
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(144, 55);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(46, 17);
            this.lblHealth.TabIndex = 24;
            this.lblHealth.Text = "label9";
            this.lblHealth.Visible = false;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(461, 55);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(54, 17);
            this.lblDays.TabIndex = 25;
            this.lblDays.Text = "label11";
            this.lblDays.Visible = false;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(96, 83);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(54, 17);
            this.lblPatient.TabIndex = 26;
            this.lblPatient.Text = "label12";
            this.lblPatient.Visible = false;
            this.lblPatient.Click += new System.EventHandler(this.lblPatient_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Private Room";
            // 
            // lblPRate
            // 
            this.lblPRate.AutoSize = true;
            this.lblPRate.Location = new System.Drawing.Point(298, 240);
            this.lblPRate.Name = "lblPRate";
            this.lblPRate.Size = new System.Drawing.Size(46, 17);
            this.lblPRate.TabIndex = 28;
            this.lblPRate.Text = "label9";
            this.lblPRate.Visible = false;
            // 
            // lblTotalPrivate
            // 
            this.lblTotalPrivate.AutoSize = true;
            this.lblTotalPrivate.Location = new System.Drawing.Point(470, 240);
            this.lblTotalPrivate.Name = "lblTotalPrivate";
            this.lblTotalPrivate.Size = new System.Drawing.Size(54, 17);
            this.lblTotalPrivate.TabIndex = 29;
            this.lblTotalPrivate.Text = "label11";
            this.lblTotalPrivate.Visible = false;
            this.lblTotalPrivate.Click += new System.EventHandler(this.label11_Click);
            // 
            // frmBillPatient
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.lblTotalPrivate);
            this.Controls.Add(this.lblPRate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTotalSemi);
            this.Controls.Add(this.lblRSemi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalPhone);
            this.Controls.Add(this.lblRPhone);
            this.Controls.Add(this.lblTotalTV);
            this.Controls.Add(this.lblRTV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Name = "frmBillPatient";
            this.Text = "BillPatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ResumeLayout(bool v)
        {
            throw new NotImplementedException();
        }

        internal void Activate()
        {
            throw new NotImplementedException();
        }
        #endregion

        private void label6_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Close()
        {
            throw new NotImplementedException();
        }

        private void btnRetrieve_Click(object sender, System.EventArgs e)
        {
            string pID;
            string ID;
            int days = 0;
            decimal grandTotal = 0.0M;

            DataSet pDataSet = new DataSet();
            DataSet eDataSet = new DataSet();

            Extras oExtras = new Extras();
            Patients oPatients = new Patients();
            Rates oRates = new Rates();
            Admissions oAdmissions = new Admissions();

            ID = txtID.Text;
            eDataSet = oExtras.FindData(ID);

            pID = eDataSet.Tables["Extras"].Rows[0]["PatientID"].ToString();
            oPatients.GetPatientInfo(pID);

            oRates.GetRates();

            lblHealth.Text = pID;
            lblHealth.Visible = true;

            lblPatient.Text = oPatients.pFirst + " " + oPatients.pLast;
            lblPatient.Visible = true;

            lblDays.Text = (oAdmissions.GetDays(ID)).ToString();
            lblDays.Visible = true;
            days = Convert.ToInt32(lblDays.Text);

            if (Convert.ToBoolean(eDataSet.Tables["Extras"].Rows[0]["TV"]) == true)
            {
                lblRTV.Text = Convert.ToString(oRates.TVRate);
                lblRTV.Visible = true;
                lblTotalTV.Text = Convert.ToString(days * oRates.TVRate);
                lblTotalTV.Visible = true;
                grandTotal = Convert.ToDecimal(lblTotalTV.Text);
            }

            if (Convert.ToBoolean(eDataSet.Tables["Extras"].Rows[0]["Phone"]) == true)
            {
                lblRPhone.Text = Convert.ToString(oRates.PhoneRate);
                lblRPhone.Visible = true;
                lblTotalPhone.Text = Convert.ToString(days * oRates.PhoneRate);
                lblTotalPhone.Visible = true;
                grandTotal += Convert.ToDecimal(lblTotalPhone.Text);
            }

            if (Convert.ToBoolean(eDataSet.Tables["Extras"].Rows[0]["SemiPrivate"]) == true)
            {
                lblRSemi.Text = Convert.ToString(oRates.SemiRate);
                lblRSemi.Visible = true;
            }

            if (Convert.ToBoolean(eDataSet.Tables["Extras"].Rows[0]["Private"]) == true)
            {
                lblPRate.Text = Convert.ToString(oRates.PrivateRate);
                lblPRate.Visible = true;
            }




        }

        private void lblPatient_Click(object sender, System.EventArgs e)
        {

        }

        private void label11_Click(object sender, System.EventArgs e)
        {

        }
    }
}
