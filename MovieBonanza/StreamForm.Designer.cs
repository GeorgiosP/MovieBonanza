namespace MovieBonanza
{
    partial class StreamForm
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
            this.PurchaseInfoLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.ThankYouLabel = new System.Windows.Forms.Label();
            this.CheckoutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PurchaseInfoLabel
            // 
            this.PurchaseInfoLabel.AutoSize = true;
            this.PurchaseInfoLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseInfoLabel.Location = new System.Drawing.Point(110, 134);
            this.PurchaseInfoLabel.Name = "PurchaseInfoLabel";
            this.PurchaseInfoLabel.Size = new System.Drawing.Size(0, 23);
            this.PurchaseInfoLabel.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(244, 287);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(89, 35);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ThankYouLabel
            // 
            this.ThankYouLabel.AutoSize = true;
            this.ThankYouLabel.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankYouLabel.Location = new System.Drawing.Point(69, 9);
            this.ThankYouLabel.Name = "ThankYouLabel";
            this.ThankYouLabel.Size = new System.Drawing.Size(453, 27);
            this.ThankYouLabel.TabIndex = 2;
            this.ThankYouLabel.Text = "Thank you for using Movie Bonanza! ";
            // 
            // CheckoutLabel
            // 
            this.CheckoutLabel.AutoSize = true;
            this.CheckoutLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutLabel.Location = new System.Drawing.Point(110, 261);
            this.CheckoutLabel.Name = "CheckoutLabel";
            this.CheckoutLabel.Size = new System.Drawing.Size(412, 23);
            this.CheckoutLabel.TabIndex = 3;
            this.CheckoutLabel.Text = "If everything checks out click ok to start ";
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 352);
            this.Controls.Add(this.CheckoutLabel);
            this.Controls.Add(this.ThankYouLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PurchaseInfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StreamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StreamForm";
            this.Load += new System.EventHandler(this.StreamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PurchaseInfoLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label ThankYouLabel;
        private System.Windows.Forms.Label CheckoutLabel;
    }
}