namespace MegaDesk_2
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.drawerNumberBox = new System.Windows.Forms.TextBox();
            this.DepthBox = new System.Windows.Forms.TextBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.MaterialCombo = new System.Windows.Forms.ComboBox();
            this.sevenDayRadio = new System.Windows.Forms.RadioButton();
            this.fiveDayRadio = new System.Windows.Forms.RadioButton();
            this.threeDayRadio = new System.Windows.Forms.RadioButton();
            this.normalRadio = new System.Windows.Forms.RadioButton();
            this.rushButton = new System.Windows.Forms.Button();
            this.CreateQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(209, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Customer Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Production Time";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "# of Drawers";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Depth";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Width";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Surface Material";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerNameBox
            // 
            this.customerNameBox.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameBox.Location = new System.Drawing.Point(397, 71);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(121, 29);
            this.customerNameBox.TabIndex = 28;
            this.customerNameBox.TextChanged += new System.EventHandler(this.customerNameBox_TextChanged);
            // 
            // drawerNumberBox
            // 
            this.drawerNumberBox.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerNumberBox.Location = new System.Drawing.Point(397, 214);
            this.drawerNumberBox.Name = "drawerNumberBox";
            this.drawerNumberBox.Size = new System.Drawing.Size(121, 29);
            this.drawerNumberBox.TabIndex = 27;
            this.drawerNumberBox.TextChanged += new System.EventHandler(this.drawerNumberBox_TextChanged);
            // 
            // DepthBox
            // 
            this.DepthBox.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthBox.Location = new System.Drawing.Point(397, 176);
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(121, 29);
            this.DepthBox.TabIndex = 26;
            this.DepthBox.TextChanged += new System.EventHandler(this.DepthBox_TextChanged);
            // 
            // WidthBox
            // 
            this.WidthBox.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthBox.Location = new System.Drawing.Point(397, 142);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(121, 29);
            this.WidthBox.TabIndex = 25;
            this.WidthBox.TextChanged += new System.EventHandler(this.WidthBox_TextChanged);
            // 
            // MaterialCombo
            // 
            this.MaterialCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MaterialCombo.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialCombo.FormattingEnabled = true;
            this.MaterialCombo.Location = new System.Drawing.Point(397, 107);
            this.MaterialCombo.Name = "MaterialCombo";
            this.MaterialCombo.Size = new System.Drawing.Size(121, 30);
            this.MaterialCombo.TabIndex = 24;
            this.MaterialCombo.SelectedIndexChanged += new System.EventHandler(this.MaterialCombo_SelectedIndexChanged);
            // 
            // sevenDayRadio
            // 
            this.sevenDayRadio.AutoSize = true;
            this.sevenDayRadio.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenDayRadio.Location = new System.Drawing.Point(397, 337);
            this.sevenDayRadio.Name = "sevenDayRadio";
            this.sevenDayRadio.Size = new System.Drawing.Size(78, 26);
            this.sevenDayRadio.TabIndex = 32;
            this.sevenDayRadio.TabStop = true;
            this.sevenDayRadio.Text = "7 Days";
            this.sevenDayRadio.UseVisualStyleBackColor = true;
            this.sevenDayRadio.Visible = false;
            // 
            // fiveDayRadio
            // 
            this.fiveDayRadio.AutoSize = true;
            this.fiveDayRadio.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveDayRadio.Location = new System.Drawing.Point(397, 314);
            this.fiveDayRadio.Name = "fiveDayRadio";
            this.fiveDayRadio.Size = new System.Drawing.Size(78, 26);
            this.fiveDayRadio.TabIndex = 31;
            this.fiveDayRadio.TabStop = true;
            this.fiveDayRadio.Text = "5 Days";
            this.fiveDayRadio.UseVisualStyleBackColor = true;
            this.fiveDayRadio.Visible = false;
            // 
            // threeDayRadio
            // 
            this.threeDayRadio.AutoSize = true;
            this.threeDayRadio.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDayRadio.Location = new System.Drawing.Point(397, 291);
            this.threeDayRadio.Name = "threeDayRadio";
            this.threeDayRadio.Size = new System.Drawing.Size(78, 26);
            this.threeDayRadio.TabIndex = 30;
            this.threeDayRadio.TabStop = true;
            this.threeDayRadio.Text = "3 Days";
            this.threeDayRadio.UseVisualStyleBackColor = true;
            this.threeDayRadio.Visible = false;
            // 
            // normalRadio
            // 
            this.normalRadio.AutoSize = true;
            this.normalRadio.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalRadio.Location = new System.Drawing.Point(397, 268);
            this.normalRadio.Name = "normalRadio";
            this.normalRadio.Size = new System.Drawing.Size(158, 26);
            this.normalRadio.TabIndex = 29;
            this.normalRadio.TabStop = true;
            this.normalRadio.Text = "Normal (14 Days)";
            this.normalRadio.UseVisualStyleBackColor = true;
            // 
            // rushButton
            // 
            this.rushButton.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushButton.Location = new System.Drawing.Point(553, 268);
            this.rushButton.Name = "rushButton";
            this.rushButton.Size = new System.Drawing.Size(88, 34);
            this.rushButton.TabIndex = 33;
            this.rushButton.Text = "Show Rush Options";
            this.rushButton.UseVisualStyleBackColor = true;
            // 
            // CreateQuote
            // 
            this.CreateQuote.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateQuote.Location = new System.Drawing.Point(203, 353);
            this.CreateQuote.Name = "CreateQuote";
            this.CreateQuote.Size = new System.Drawing.Size(88, 35);
            this.CreateQuote.TabIndex = 34;
            this.CreateQuote.Text = "Create ";
            this.CreateQuote.UseVisualStyleBackColor = true;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateQuote);
            this.Controls.Add(this.rushButton);
            this.Controls.Add(this.sevenDayRadio);
            this.Controls.Add(this.fiveDayRadio);
            this.Controls.Add(this.threeDayRadio);
            this.Controls.Add(this.normalRadio);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.drawerNumberBox);
            this.Controls.Add(this.DepthBox);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.MaterialCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MaterialCombo;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.TextBox DepthBox;
        private System.Windows.Forms.TextBox drawerNumberBox;
        private System.Windows.Forms.Button CreateQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton normalRadio;
        private System.Windows.Forms.RadioButton threeDayRadio;
        private System.Windows.Forms.RadioButton fiveDayRadio;
        private System.Windows.Forms.Button rushButton;
        private System.Windows.Forms.RadioButton sevenDayRadio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerNameBox;
    }
}