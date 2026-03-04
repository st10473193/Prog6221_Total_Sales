namespace Total_Sales_03_03_2026
{
    partial class frmTotalSales
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
            btnSales = new Button();
            listDisplay = new ListBox();
            SuspendLayout();
            // 
            // btnSales
            // 
            btnSales.Location = new Point(149, 54);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(186, 64);
            btnSales.TabIndex = 0;
            btnSales.Text = "Open File Calculate Sales";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // listDisplay
            // 
            listDisplay.FormattingEnabled = true;
            listDisplay.Location = new Point(56, 135);
            listDisplay.Name = "listDisplay";
            listDisplay.Size = new Size(374, 279);
            listDisplay.TabIndex = 1;
            // 
            // frmTotalSales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 466);
            Controls.Add(listDisplay);
            Controls.Add(btnSales);
            Name = "frmTotalSales";
            Text = "Total Sales";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSales;
        private ListBox listDisplay;
    }
}
