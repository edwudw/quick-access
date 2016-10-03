namespace Textbook_Instant_Access
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
            this.addButton = new System.Windows.Forms.Button();
            this.quickAccessBox = new System.Windows.Forms.ListBox();
            this.addLabel = new System.Windows.Forms.Label();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(843, 404);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // quickAccessBox
            // 
            this.quickAccessBox.FormattingEnabled = true;
            this.quickAccessBox.Location = new System.Drawing.Point(17, 12);
            this.quickAccessBox.Name = "quickAccessBox";
            this.quickAccessBox.Size = new System.Drawing.Size(901, 368);
            this.quickAccessBox.TabIndex = 1;
            this.quickAccessBox.DoubleClick += new System.EventHandler(this.quickAccessBox_doubleClick);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Location = new System.Drawing.Point(19, 408);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(132, 13);
            this.addLabel.TabIndex = 2;
            this.addLabel.Text = "Add File to Quick Access: ";
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(157, 405);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(514, 20);
            this.addTextBox.TabIndex = 3;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(763, 404);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(74, 23);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(680, 403);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(77, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Tag = "";
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 451);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.quickAccessBox);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.formLoaded);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox quickAccessBox;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button removeButton;
    }
}

