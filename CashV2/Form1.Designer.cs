
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
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutputLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
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
            this.totalOutputLabel.Size = new System.Drawing.Size(0, 20);
            this.totalOutputLabel.TabIndex = 22;
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.AutoSize = true;
            this.taxOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.taxOutputLabel.Location = new System.Drawing.Point(192, 298);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(0, 20);
            this.taxOutputLabel.TabIndex = 23;
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.AutoSize = true;
            this.subTotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subTotalOutput.Location = new System.Drawing.Point(192, 262);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(0, 20);
            this.subTotalOutput.TabIndex = 24;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tenderedLabel.Location = new System.Drawing.Point(7, 418);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(77, 20);
            this.tenderedLabel.TabIndex = 25;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(196, 418);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(71, 20);
            this.tenderedInput.TabIndex = 26;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(49, 454);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(190, 22);
            this.changeButton.TabIndex = 27;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changeLabel.Location = new System.Drawing.Point(7, 502);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(65, 20);
            this.changeLabel.TabIndex = 28;
            this.changeLabel.Text = "Change";
            // 
            // changeOutputLabel
            // 
            this.changeOutputLabel.AutoSize = true;
            this.changeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changeOutputLabel.Location = new System.Drawing.Point(192, 502);
            this.changeOutputLabel.Name = "changeOutputLabel";
            this.changeOutputLabel.Size = new System.Drawing.Size(0, 20);
            this.changeOutputLabel.TabIndex = 29;
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(49, 560);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(190, 22);
            this.receiptButton.TabIndex = 30;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // receiptOutput
            // 
            this.receiptOutput.AutoSize = true;
            this.receiptOutput.BackColor = System.Drawing.Color.White;
            this.receiptOutput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.Location = new System.Drawing.Point(409, 117);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(0, 18);
            this.receiptOutput.TabIndex = 31;
            this.receiptOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(412, 560);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(190, 22);
            this.newOrderButton.TabIndex = 32;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(655, 626);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeOutputLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
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
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutputLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Button newOrderButton;
    }
}

