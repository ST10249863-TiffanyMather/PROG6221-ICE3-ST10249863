namespace CafeApp
{
    partial class Form1
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
            cmbItem = new ComboBox();
            nudQuantity = new NumericUpDown();
            btnAdd = new Button();
            btnDisplay = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // cmbItem
            // 
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(153, 30);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(121, 23);
            cmbItem.TabIndex = 0;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(154, 81);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 23);
            nudQuantity.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(60, 143);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(194, 143);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(80, 23);
            btnDisplay.TabIndex = 3;
            btnDisplay.Text = "Display Item ";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 33);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "Item: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 83);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "Quantity:";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 194);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDisplay);
            Controls.Add(btnAdd);
            Controls.Add(nudQuantity);
            Controls.Add(cmbItem);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbItem;
        private NumericUpDown nudQuantity;
        private Button btnAdd;
        private Button btnDisplay;
        private Label label1;
        private Label label2;
    }
}
