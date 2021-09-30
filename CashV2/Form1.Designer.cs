
namespace CashV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.breadSticksInput = new System.Windows.Forms.TextBox();
            this.drinksInput = new System.Windows.Forms.TextBox();
            this.pizzaSlicesInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pizzaSlicesLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalLabel.Location = new System.Drawing.Point(7, 335);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 20);
            this.totalLabel.TabIndex = 21;
            this.totalLabel.Text = "Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.taxLabel.Location = new System.Drawing.Point(8, 298);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(34, 20);
            this.taxLabel.TabIndex = 20;
            this.taxLabel.Text = "Tax";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subTotalLabel.Location = new System.Drawing.Point(7, 262);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(77, 20);
            this.subTotalLabel.TabIndex = 19;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(49, 210);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(190, 22);
            this.calculateButton.TabIndex = 18;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // breadSticksInput
            // 
            this.breadSticksInput.Location = new System.Drawing.Point(196, 119);
            this.breadSticksInput.Name = "breadSticksInput";
            this.breadSticksInput.Size = new System.Drawing.Size(71, 20);
            this.breadSticksInput.TabIndex = 17;
            // 
            // drinksInput
            // 
            this.drinksInput.Location = new System.Drawing.Point(196, 165);
            this.drinksInput.Name = "drinksInput";
            this.drinksInput.Size = new System.Drawing.Size(71, 20);
            this.drinksInput.TabIndex = 16;
            // 
            // pizzaSlicesInput
            // 
            this.pizzaSlicesInput.Location = new System.Drawing.Point(196, 72);
            this.pizzaSlicesInput.Name = "pizzaSlicesInput";
            this.pizzaSlicesInput.Size = new System.Drawing.Size(71, 20);
            this.pizzaSlicesInput.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(8, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Number of Bread Sticks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Number of Drinks";
            // 
            // pizzaSlicesLabel
            // 
            this.pizzaSlicesLabel.AutoSize = true;
            this.pizzaSlicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pizzaSlicesLabel.Location = new System.Drawing.Point(8, 70);
            this.pizzaSlicesLabel.Name = "pizzaSlicesLabel";
            this.pizzaSlicesLabel.Size = new System.Drawing.Size(171, 20);
            this.pizzaSlicesLabel.TabIndex = 12;
            this.pizzaSlicesLabel.Text = "Number of Pizza Slices";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLabel.Location = new System.Drawing.Point(145, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(171, 31);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Pizza Palace";
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.AutoSize = true;
            this.totalOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalOutputLabel.Location = new System.Drawing.Point(192, 335);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(128, 20);
            this.totalOutputLabel.TabIndex = 22;
            this.totalOutputLabel.Text = "totalOutputLabel";
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.AutoSize = true;
            this.taxOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.taxOutputLabel.Location = new System.Drawing.Point(192, 298);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(118, 20);
            this.taxOutputLabel.TabIndex = 23;
            this.taxOutputLabel.Text = "taxOutputLabel";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.AutoSize = true;
            this.subTotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subTotalOutput.Location = new System.Drawing.Point(192, 262);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(158, 20);
            this.subTotalOutput.TabIndex = 24;
            this.subTotalOutput.Text = "subTotalOutputLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.taxOutputLabel);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.breadSticksInput);
            this.Controls.Add(this.drinksInput);
            this.Controls.Add(this.pizzaSlicesInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pizzaSlicesLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox breadSticksInput;
        private System.Windows.Forms.TextBox drinksInput;
        private System.Windows.Forms.TextBox pizzaSlicesInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pizzaSlicesLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.Label subTotalOutput;
    }
}

