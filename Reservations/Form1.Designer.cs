namespace Reservations
{
    partial class Form1
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
            this.Label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtAvgPrice = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(29, 79);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(128, 20);
            this.Label5.TabIndex = 34;
            this.Label5.Text = "Number of nights:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(176, 191);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 30);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(40, 191);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 30);
            this.btnCalculate.TabIndex = 32;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(167, 46);
            this.txtDepartureDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(116, 22);
            this.txtDepartureDate.TabIndex = 29;
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(167, 14);
            this.txtArrivalDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(116, 22);
            this.txtArrivalDate.TabIndex = 28;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(29, 111);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(128, 20);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "Total price:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(31, 47);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(128, 20);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "Departure date:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(31, 15);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(128, 20);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "Arrival date:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(165, 78);
            this.txtNights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNights.Name = "txtNights";
            this.txtNights.ReadOnly = true;
            this.txtNights.Size = new System.Drawing.Size(116, 22);
            this.txtNights.TabIndex = 35;
            this.txtNights.TabStop = false;
            // 
            // txtAvgPrice
            // 
            this.txtAvgPrice.Location = new System.Drawing.Point(165, 142);
            this.txtAvgPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAvgPrice.Name = "txtAvgPrice";
            this.txtAvgPrice.ReadOnly = true;
            this.txtAvgPrice.Size = new System.Drawing.Size(116, 22);
            this.txtAvgPrice.TabIndex = 36;
            this.txtAvgPrice.TabStop = false;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(165, 110);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(117, 22);
            this.txtTotalPrice.TabIndex = 37;
            this.txtTotalPrice.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Avg. price per night:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(312, 242);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtAvgPrice);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.txtArrivalDate);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnCalculate;
        internal System.Windows.Forms.TextBox txtDepartureDate;
        internal System.Windows.Forms.TextBox txtArrivalDate;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtAvgPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label3;
    }
}

