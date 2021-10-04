
namespace AlbumCollection
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
            this.originalListLabel = new System.Windows.Forms.Label();
            this.sortedListLabel = new System.Windows.Forms.Label();
            this.enterLabel = new System.Windows.Forms.Label();
            this.albumInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originalListLabel
            // 
            this.originalListLabel.BackColor = System.Drawing.Color.White;
            this.originalListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalListLabel.Location = new System.Drawing.Point(42, 284);
            this.originalListLabel.Name = "originalListLabel";
            this.originalListLabel.Size = new System.Drawing.Size(708, 450);
            this.originalListLabel.TabIndex = 0;
            this.originalListLabel.Text = "Original Order\r\n****************";
            // 
            // sortedListLabel
            // 
            this.sortedListLabel.BackColor = System.Drawing.Color.White;
            this.sortedListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortedListLabel.Location = new System.Drawing.Point(803, 284);
            this.sortedListLabel.Name = "sortedListLabel";
            this.sortedListLabel.Size = new System.Drawing.Size(708, 450);
            this.sortedListLabel.TabIndex = 1;
            this.sortedListLabel.Text = "Sorted Order\r\n****************";
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Location = new System.Drawing.Point(42, 101);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(320, 32);
            this.enterLabel.TabIndex = 2;
            this.enterLabel.Text = "Enter Album Information";
            // 
            // albumInput
            // 
            this.albumInput.Location = new System.Drawing.Point(378, 98);
            this.albumInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.albumInput.Name = "albumInput";
            this.albumInput.Size = new System.Drawing.Size(772, 38);
            this.albumInput.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1181, 81);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(173, 70);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(1358, 81);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(173, 70);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Location = new System.Drawing.Point(588, 183);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(943, 74);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1626, 1149);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.albumInput);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.sortedListLabel);
            this.Controls.Add(this.originalListLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Album Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originalListLabel;
        private System.Windows.Forms.Label sortedListLabel;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox albumInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

