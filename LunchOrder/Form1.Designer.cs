
namespace LunchOrder
{
    partial class frmLunchOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLunchOrder));
            System.Windows.Forms.Label label2;
            this.grbHam = new System.Windows.Forms.GroupBox();
            this.chkHam3 = new System.Windows.Forms.CheckBox();
            this.chkHam2 = new System.Windows.Forms.CheckBox();
            this.chkHam1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radHamburger = new System.Windows.Forms.RadioButton();
            this.radPizza = new System.Windows.Forms.RadioButton();
            this.radSalad = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.grbHam.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHam
            // 
            this.grbHam.BackColor = System.Drawing.Color.Transparent;
            this.grbHam.Controls.Add(this.chkHam3);
            this.grbHam.Controls.Add(this.chkHam2);
            this.grbHam.Controls.Add(this.chkHam1);
            this.grbHam.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbHam.Location = new System.Drawing.Point(1039, 155);
            this.grbHam.Name = "grbHam";
            this.grbHam.Size = new System.Drawing.Size(616, 321);
            this.grbHam.TabIndex = 1;
            this.grbHam.TabStop = false;
            this.grbHam.Text = "Add-on items ($.75/each)";
            // 
            // chkHam3
            // 
            this.chkHam3.AutoSize = true;
            this.chkHam3.Location = new System.Drawing.Point(30, 232);
            this.chkHam3.Name = "chkHam3";
            this.chkHam3.Size = new System.Drawing.Size(279, 61);
            this.chkHam3.TabIndex = 0;
            this.chkHam3.Text = "French fries";
            this.chkHam3.UseVisualStyleBackColor = true;
            this.chkHam3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkHam2
            // 
            this.chkHam2.AutoSize = true;
            this.chkHam2.Location = new System.Drawing.Point(30, 153);
            this.chkHam2.Name = "chkHam2";
            this.chkHam2.Size = new System.Drawing.Size(615, 61);
            this.chkHam2.TabIndex = 0;
            this.chkHam2.Text = "Ketchup, mustard, and mayo";
            this.chkHam2.UseVisualStyleBackColor = true;
            this.chkHam2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkHam1
            // 
            this.chkHam1.AutoSize = true;
            this.chkHam1.Location = new System.Drawing.Point(30, 73);
            this.chkHam1.Name = "chkHam1";
            this.chkHam1.Size = new System.Drawing.Size(592, 61);
            this.chkHam1.TabIndex = 0;
            this.chkHam1.Text = "Lettuce, tomato, and onions";
            this.chkHam1.UseVisualStyleBackColor = true;
            this.chkHam1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtOrderTotal);
            this.groupBox3.Controls.Add(this.txtTax);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.lbTotal);
            this.groupBox3.Controls.Add(this.lbTax);
            this.groupBox3.Controls.Add(this.lbSubtotal);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(1049, 634);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 261);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtOrderTotal.Location = new System.Drawing.Point(347, 197);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(246, 65);
            this.txtOrderTotal.TabIndex = 1;
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTax.Location = new System.Drawing.Point(347, 134);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(246, 65);
            this.txtTax.TabIndex = 1;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSubtotal.Location = new System.Drawing.Point(347, 71);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(246, 65);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbTotal.Location = new System.Drawing.Point(68, 194);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(261, 57);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Order Total:";
            // 
            // lbTax
            // 
            this.lbTax.AutoSize = true;
            this.lbTax.Location = new System.Drawing.Point(66, 134);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(202, 57);
            this.lbTax.TabIndex = 0;
            this.lbTax.Text = "Tax (5%):";
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Location = new System.Drawing.Point(66, 74);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(198, 57);
            this.lbSubtotal.TabIndex = 0;
            this.lbSubtotal.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaceOrder.Location = new System.Drawing.Point(1049, 535);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(244, 68);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1417, 535);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(244, 68);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(838, 935);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(244, 68);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.radSalad);
            this.groupBox2.Controls.Add(this.radPizza);
            this.groupBox2.Controls.Add(this.radHamburger);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(263, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 762);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Menu";
            // 
            // radHamburger
            // 
            this.radHamburger.AutoSize = true;
            this.radHamburger.Checked = true;
            this.radHamburger.Location = new System.Drawing.Point(40, 91);
            this.radHamburger.Name = "radHamburger";
            this.radHamburger.Size = new System.Drawing.Size(422, 67);
            this.radHamburger.TabIndex = 0;
            this.radHamburger.TabStop = true;
            this.radHamburger.Text = "Hamburger - $6.95";
            this.radHamburger.UseVisualStyleBackColor = true;
            this.radHamburger.CheckedChanged += new System.EventHandler(this.radHamburger_CheckedChanged_1);
            // 
            // radPizza
            // 
            this.radPizza.AutoSize = true;
            this.radPizza.Location = new System.Drawing.Point(44, 348);
            this.radPizza.Name = "radPizza";
            this.radPizza.Size = new System.Drawing.Size(308, 67);
            this.radPizza.TabIndex = 1;
            this.radPizza.Text = "Pizza - $5.95";
            this.radPizza.UseVisualStyleBackColor = true;
            this.radPizza.CheckedChanged += new System.EventHandler(this.radPizza_CheckedChanged_1);
            // 
            // radSalad
            // 
            this.radSalad.AutoSize = true;
            this.radSalad.Location = new System.Drawing.Point(40, 591);
            this.radSalad.Name = "radSalad";
            this.radSalad.Size = new System.Drawing.Size(315, 67);
            this.radSalad.TabIndex = 2;
            this.radSalad.Text = "Salad - $4.95";
            this.radSalad.UseVisualStyleBackColor = true;
            this.radSalad.CheckedChanged += new System.EventHandler(this.radSalad_CheckedChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(449, 294);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 207);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(449, 542);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(267, 214);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(627, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 128);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to Lunch Box!!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(1693, 1035);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(319, 52);
            label2.TabIndex = 6;
            label2.Text = "copyright Yisi Dong";
            // 
            // frmLunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2024, 1096);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbHam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLunchOrder";
            this.Text = "Lunch Order";
            this.grbHam.ResumeLayout(false);
            this.grbHam.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbHam;
        private System.Windows.Forms.CheckBox chkHam1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkHam3;
        private System.Windows.Forms.CheckBox chkHam2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radSalad;
        private System.Windows.Forms.RadioButton radPizza;
        private System.Windows.Forms.RadioButton radHamburger;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

