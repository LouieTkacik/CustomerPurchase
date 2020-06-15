namespace TKACIK_Customer_Purchase
{
    partial class CustomerPurchaseForm
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
            this.purchasesListBox = new System.Windows.Forms.ListBox();
            this.fedTaxOutput = new System.Windows.Forms.Label();
            this.stateTaxOutput = new System.Windows.Forms.Label();
            this.beforeTaxesOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.fedTaxLabel = new System.Windows.Forms.Label();
            this.stateTaxLabel = new System.Windows.Forms.Label();
            this.noTaxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.pricesGroupBox = new System.Windows.Forms.GroupBox();
            this.itemNameInput = new System.Windows.Forms.TextBox();
            this.itemPriceInput = new System.Windows.Forms.TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemPriceLabel = new System.Windows.Forms.Label();
            this.addPurchaseButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.pricesGroupBox.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // purchasesListBox
            // 
            this.purchasesListBox.FormattingEnabled = true;
            this.purchasesListBox.Location = new System.Drawing.Point(113, 308);
            this.purchasesListBox.Name = "purchasesListBox";
            this.purchasesListBox.Size = new System.Drawing.Size(249, 95);
            this.purchasesListBox.TabIndex = 0;
            // 
            // fedTaxOutput
            // 
            this.fedTaxOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fedTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fedTaxOutput.Location = new System.Drawing.Point(56, 53);
            this.fedTaxOutput.Name = "fedTaxOutput";
            this.fedTaxOutput.Size = new System.Drawing.Size(104, 23);
            this.fedTaxOutput.TabIndex = 1;
            // 
            // stateTaxOutput
            // 
            this.stateTaxOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stateTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stateTaxOutput.Location = new System.Drawing.Point(56, 116);
            this.stateTaxOutput.Name = "stateTaxOutput";
            this.stateTaxOutput.Size = new System.Drawing.Size(104, 23);
            this.stateTaxOutput.TabIndex = 2;
            // 
            // beforeTaxesOutput
            // 
            this.beforeTaxesOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.beforeTaxesOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.beforeTaxesOutput.Location = new System.Drawing.Point(56, 177);
            this.beforeTaxesOutput.Name = "beforeTaxesOutput";
            this.beforeTaxesOutput.Size = new System.Drawing.Size(104, 23);
            this.beforeTaxesOutput.TabIndex = 3;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalOutput.Location = new System.Drawing.Point(56, 240);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(104, 23);
            this.totalOutput.TabIndex = 4;
            // 
            // fedTaxLabel
            // 
            this.fedTaxLabel.AutoSize = true;
            this.fedTaxLabel.Location = new System.Drawing.Point(25, 29);
            this.fedTaxLabel.Name = "fedTaxLabel";
            this.fedTaxLabel.Size = new System.Drawing.Size(66, 13);
            this.fedTaxLabel.TabIndex = 5;
            this.fedTaxLabel.Text = "Federal Tax:";
            // 
            // stateTaxLabel
            // 
            this.stateTaxLabel.AutoSize = true;
            this.stateTaxLabel.Location = new System.Drawing.Point(25, 87);
            this.stateTaxLabel.Name = "stateTaxLabel";
            this.stateTaxLabel.Size = new System.Drawing.Size(56, 13);
            this.stateTaxLabel.TabIndex = 6;
            this.stateTaxLabel.Text = "State Tax:";
            // 
            // noTaxLabel
            // 
            this.noTaxLabel.AutoSize = true;
            this.noTaxLabel.Location = new System.Drawing.Point(25, 154);
            this.noTaxLabel.Name = "noTaxLabel";
            this.noTaxLabel.Size = new System.Drawing.Size(62, 13);
            this.noTaxLabel.TabIndex = 7;
            this.noTaxLabel.Text = "Before Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(25, 213);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total:";
            // 
            // pricesGroupBox
            // 
            this.pricesGroupBox.Controls.Add(this.totalOutput);
            this.pricesGroupBox.Controls.Add(this.totalLabel);
            this.pricesGroupBox.Controls.Add(this.fedTaxOutput);
            this.pricesGroupBox.Controls.Add(this.noTaxLabel);
            this.pricesGroupBox.Controls.Add(this.stateTaxOutput);
            this.pricesGroupBox.Controls.Add(this.stateTaxLabel);
            this.pricesGroupBox.Controls.Add(this.beforeTaxesOutput);
            this.pricesGroupBox.Controls.Add(this.fedTaxLabel);
            this.pricesGroupBox.Location = new System.Drawing.Point(441, 91);
            this.pricesGroupBox.Name = "pricesGroupBox";
            this.pricesGroupBox.Size = new System.Drawing.Size(200, 295);
            this.pricesGroupBox.TabIndex = 9;
            this.pricesGroupBox.TabStop = false;
            // 
            // itemNameInput
            // 
            this.itemNameInput.Location = new System.Drawing.Point(172, 24);
            this.itemNameInput.Name = "itemNameInput";
            this.itemNameInput.Size = new System.Drawing.Size(100, 20);
            this.itemNameInput.TabIndex = 9;
            // 
            // itemPriceInput
            // 
            this.itemPriceInput.Location = new System.Drawing.Point(172, 66);
            this.itemPriceInput.Name = "itemPriceInput";
            this.itemPriceInput.Size = new System.Drawing.Size(100, 20);
            this.itemPriceInput.TabIndex = 10;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.Location = new System.Drawing.Point(50, 22);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(93, 20);
            this.itemNameLabel.TabIndex = 11;
            this.itemNameLabel.Text = "Item name: ";
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceLabel.Location = new System.Drawing.Point(56, 64);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(87, 20);
            this.itemPriceLabel.TabIndex = 12;
            this.itemPriceLabel.Text = "Item price: ";
            // 
            // addPurchaseButton
            // 
            this.addPurchaseButton.Location = new System.Drawing.Point(172, 109);
            this.addPurchaseButton.Name = "addPurchaseButton";
            this.addPurchaseButton.Size = new System.Drawing.Size(107, 56);
            this.addPurchaseButton.TabIndex = 13;
            this.addPurchaseButton.Text = "Add Purchase";
            this.addPurchaseButton.UseVisualStyleBackColor = true;
            this.addPurchaseButton.Click += new System.EventHandler(this.addPurchaseButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(85, 285);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(88, 20);
            this.receiptLabel.TabIndex = 14;
            this.receiptLabel.Text = "Purchases:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome to self check out!  Please enter your purchases!";
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.Location = new System.Drawing.Point(36, 109);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(107, 56);
            this.clearEntryButton.TabIndex = 16;
            this.clearEntryButton.Text = "Remove Purchase";
            this.clearEntryButton.UseVisualStyleBackColor = true;
            this.clearEntryButton.Click += new System.EventHandler(this.clearEntryButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(481, 407);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(120, 56);
            this.clearAllButton.TabIndex = 17;
            this.clearAllButton.Text = "Checkout ";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.itemPriceInput);
            this.inputGroupBox.Controls.Add(this.itemNameInput);
            this.inputGroupBox.Controls.Add(this.clearEntryButton);
            this.inputGroupBox.Controls.Add(this.itemNameLabel);
            this.inputGroupBox.Controls.Add(this.itemPriceLabel);
            this.inputGroupBox.Controls.Add(this.addPurchaseButton);
            this.inputGroupBox.Location = new System.Drawing.Point(53, 81);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(309, 185);
            this.inputGroupBox.TabIndex = 18;
            this.inputGroupBox.TabStop = false;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(596, 500);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(76, 29);
            this.quitButton.TabIndex = 19;
            this.quitButton.Text = "Shut Down";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // CustomerPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 582);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.pricesGroupBox);
            this.Controls.Add(this.purchasesListBox);
            this.Name = "CustomerPurchaseForm";
            this.Text = "CustomerPurchaseForm";
            this.Load += new System.EventHandler(this.CustomerPurchaseForm_Load);
            this.pricesGroupBox.ResumeLayout(false);
            this.pricesGroupBox.PerformLayout();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox purchasesListBox;
        private System.Windows.Forms.Label fedTaxOutput;
        private System.Windows.Forms.Label stateTaxOutput;
        private System.Windows.Forms.Label beforeTaxesOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label fedTaxLabel;
        private System.Windows.Forms.Label stateTaxLabel;
        private System.Windows.Forms.Label noTaxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.GroupBox pricesGroupBox;
        private System.Windows.Forms.TextBox itemNameInput;
        private System.Windows.Forms.TextBox itemPriceInput;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label itemPriceLabel;
        private System.Windows.Forms.Button addPurchaseButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.Button quitButton;
    }
}

