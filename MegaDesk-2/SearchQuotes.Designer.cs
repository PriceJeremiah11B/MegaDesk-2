namespace MegaDesk_2
{
    partial class SearchQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.listView = new System.Windows.Forms.ListView();
            this.CustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Width = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Depth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductionTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.MaterialCombo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerName,
            this.Width,
            this.Depth,
            this.Material,
            this.ProductionTime,
            this.FinalCost,
            this.Date});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 73);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 281);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // CustomerName
            // 
            this.CustomerName.Text = "Customer Name";
            this.CustomerName.Width = 124;
            // 
            // Width
            // 
            this.Width.Text = "Width";
            this.Width.Width = 69;
            // 
            // Depth
            // 
            this.Depth.Text = "Depth";
            this.Depth.Width = 72;
            // 
            // Material
            // 
            this.Material.Text = "Material";
            this.Material.Width = 104;
            // 
            // ProductionTime
            // 
            this.ProductionTime.Text = "Production Time";
            this.ProductionTime.Width = 114;
            // 
            // FinalCost
            // 
            this.FinalCost.Text = "Final Cost";
            this.FinalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FinalCost.Width = 82;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 96;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MaterialCombo
            // 
            this.MaterialCombo.FormattingEnabled = true;
            this.MaterialCombo.Location = new System.Drawing.Point(287, 25);
            this.MaterialCombo.Name = "MaterialCombo";
            this.MaterialCombo.Size = new System.Drawing.Size(121, 21);
            this.MaterialCombo.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Quit To Main Menu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MaterialCombo);
            this.Controls.Add(this.listView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.ColumnHeader Width;
        private System.Windows.Forms.ColumnHeader Depth;
        private System.Windows.Forms.ColumnHeader Material;
        private System.Windows.Forms.ColumnHeader ProductionTime;
        private System.Windows.Forms.ColumnHeader FinalCost;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox MaterialCombo;
        private System.Windows.Forms.Button button2;
    }
}