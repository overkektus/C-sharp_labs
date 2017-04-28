namespace lab7
{
    partial class SearchOnCarrying
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
            this.Label_SearachOnCarrying = new System.Windows.Forms.Label();
            this.Button_SearchOnCarrying = new System.Windows.Forms.Button();
            this.TrackBar_SearchOnCarrying = new System.Windows.Forms.TrackBar();
            this.Label_SearchOnCarrying = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_SearchOnCarrying)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_SearachOnCarrying
            // 
            this.Label_SearachOnCarrying.AutoSize = true;
            this.Label_SearachOnCarrying.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_SearachOnCarrying.Location = new System.Drawing.Point(65, 19);
            this.Label_SearachOnCarrying.Name = "Label_SearachOnCarrying";
            this.Label_SearachOnCarrying.Size = new System.Drawing.Size(217, 20);
            this.Label_SearachOnCarrying.TabIndex = 5;
            this.Label_SearachOnCarrying.Text = "Поик по грузоподъёмности";
            // 
            // Button_SearchOnCarrying
            // 
            this.Button_SearchOnCarrying.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_SearchOnCarrying.Location = new System.Drawing.Point(74, 93);
            this.Button_SearchOnCarrying.Name = "Button_SearchOnCarrying";
            this.Button_SearchOnCarrying.Size = new System.Drawing.Size(190, 40);
            this.Button_SearchOnCarrying.TabIndex = 7;
            this.Button_SearchOnCarrying.Text = "Найти";
            this.Button_SearchOnCarrying.UseVisualStyleBackColor = true;
            this.Button_SearchOnCarrying.Click += new System.EventHandler(this.Button_SearchOnCarrying_Click);
            // 
            // TrackBar_SearchOnCarrying
            // 
            this.TrackBar_SearchOnCarrying.Location = new System.Drawing.Point(43, 47);
            this.TrackBar_SearchOnCarrying.Maximum = 100;
            this.TrackBar_SearchOnCarrying.Minimum = 10;
            this.TrackBar_SearchOnCarrying.Name = "TrackBar_SearchOnCarrying";
            this.TrackBar_SearchOnCarrying.Size = new System.Drawing.Size(267, 45);
            this.TrackBar_SearchOnCarrying.TabIndex = 8;
            this.TrackBar_SearchOnCarrying.Value = 10;
            this.TrackBar_SearchOnCarrying.ValueChanged += new System.EventHandler(this.TrackBar_SearchOnCarrying_ValueChanged);
            // 
            // Label_SearchOnCarrying
            // 
            this.Label_SearchOnCarrying.AutoSize = true;
            this.Label_SearchOnCarrying.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label_SearchOnCarrying.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_SearchOnCarrying.ForeColor = System.Drawing.Color.Maroon;
            this.Label_SearchOnCarrying.Location = new System.Drawing.Point(12, 50);
            this.Label_SearchOnCarrying.Name = "Label_SearchOnCarrying";
            this.Label_SearchOnCarrying.Size = new System.Drawing.Size(29, 20);
            this.Label_SearchOnCarrying.TabIndex = 18;
            this.Label_SearchOnCarrying.Text = "10";
            // 
            // SearchOnCarrying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.Label_SearchOnCarrying);
            this.Controls.Add(this.TrackBar_SearchOnCarrying);
            this.Controls.Add(this.Button_SearchOnCarrying);
            this.Controls.Add(this.Label_SearachOnCarrying);
            this.Name = "SearchOnCarrying";
            this.Text = "SearchOnCarrying";
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_SearchOnCarrying)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_SearachOnCarrying;
        private System.Windows.Forms.Button Button_SearchOnCarrying;
        private System.Windows.Forms.TrackBar TrackBar_SearchOnCarrying;
        private System.Windows.Forms.Label Label_SearchOnCarrying;
    }
}