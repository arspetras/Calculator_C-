namespace Calculator
{
    partial class Calculator
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
            this.inputTab = new System.Windows.Forms.TextBox();
            this.resultTab = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.DevideButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTab
            // 
            this.inputTab.AccessibleName = "inputTab";
            this.inputTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTab.Location = new System.Drawing.Point(50, 274);
            this.inputTab.Name = "inputTab";
            this.inputTab.Size = new System.Drawing.Size(316, 38);
            this.inputTab.TabIndex = 3;
            this.inputTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultTab
            // 
            this.resultTab.AccessibleName = "resultTab";
            this.resultTab.BackColor = System.Drawing.SystemColors.Control;
            this.resultTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTab.Location = new System.Drawing.Point(50, 84);
            this.resultTab.Multiline = true;
            this.resultTab.Name = "resultTab";
            this.resultTab.ReadOnly = true;
            this.resultTab.Size = new System.Drawing.Size(316, 152);
            this.resultTab.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.AccessibleName = "addButton";
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(132, 342);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(40, 40);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.AccessibleName = "subtractButton";
            this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractButton.Location = new System.Drawing.Point(231, 342);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(40, 40);
            this.subtractButton.TabIndex = 6;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.AccessibleName = "multiplyButton";
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.Location = new System.Drawing.Point(132, 388);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(40, 40);
            this.multiplyButton.TabIndex = 7;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DevideButton
            // 
            this.DevideButton.AccessibleName = "DevideButton";
            this.DevideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevideButton.Location = new System.Drawing.Point(231, 388);
            this.DevideButton.Name = "DevideButton";
            this.DevideButton.Size = new System.Drawing.Size(40, 40);
            this.DevideButton.TabIndex = 8;
            this.DevideButton.Text = "/";
            this.DevideButton.UseVisualStyleBackColor = true;
            this.DevideButton.Click += new System.EventHandler(this.DevideButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.AccessibleName = "equalsButton";
            this.equalsButton.Enabled = false;
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(132, 434);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(139, 40);
            this.equalsButton.TabIndex = 9;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.DisplayResult);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 486);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.DevideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultTab);
            this.Controls.Add(this.inputTab);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputTab;
        private System.Windows.Forms.TextBox resultTab;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button DevideButton;
        private System.Windows.Forms.Button equalsButton;
    }
}

