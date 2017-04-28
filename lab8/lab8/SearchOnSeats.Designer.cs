namespace lab7
{
    partial class SearchOnSeats
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
            this.Button_SearchOnSeats = new System.Windows.Forms.Button();
            this.TextBox_SearachOnSeats = new System.Windows.Forms.TextBox();
            this.Label_SearachOnSeats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_SearchOnSeats
            // 
            this.Button_SearchOnSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_SearchOnSeats.Location = new System.Drawing.Point(74, 93);
            this.Button_SearchOnSeats.Name = "Button_SearchOnSeats";
            this.Button_SearchOnSeats.Size = new System.Drawing.Size(190, 40);
            this.Button_SearchOnSeats.TabIndex = 1;
            this.Button_SearchOnSeats.Text = "Найти";
            this.Button_SearchOnSeats.UseVisualStyleBackColor = true;
            this.Button_SearchOnSeats.Click += new System.EventHandler(this.Button_SearchOnSeats_Click);
            // 
            // TextBox_SearachOnSeats
            // 
            this.TextBox_SearachOnSeats.Location = new System.Drawing.Point(74, 54);
            this.TextBox_SearachOnSeats.Name = "TextBox_SearachOnSeats";
            this.TextBox_SearachOnSeats.Size = new System.Drawing.Size(190, 20);
            this.TextBox_SearachOnSeats.TabIndex = 2;
            // 
            // Label_SearachOnSeats
            // 
            this.Label_SearachOnSeats.AutoSize = true;
            this.Label_SearachOnSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_SearachOnSeats.Location = new System.Drawing.Point(70, 18);
            this.Label_SearachOnSeats.Name = "Label_SearachOnSeats";
            this.Label_SearachOnSeats.Size = new System.Drawing.Size(201, 20);
            this.Label_SearachOnSeats.TabIndex = 3;
            this.Label_SearachOnSeats.Text = "Поик по количеству мест";
            // 
            // SearchOnSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.Label_SearachOnSeats);
            this.Controls.Add(this.TextBox_SearachOnSeats);
            this.Controls.Add(this.Button_SearchOnSeats);
            this.Name = "SearchOnSeats";
            this.Text = "SearchOnSeats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_SearchOnSeats;
        private System.Windows.Forms.TextBox TextBox_SearachOnSeats;
        private System.Windows.Forms.Label Label_SearachOnSeats;
    }
}