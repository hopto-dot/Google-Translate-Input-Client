
namespace Google_Translate_Canvas
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
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.flpSuggestions = new System.Windows.Forms.FlowLayoutPanel();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.canvas1 = new Google_Translate_Canvas.Canvas();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(8, 8);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 44);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.White;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(3, 467);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(556, 109);
            this.lblOutput.TabIndex = 3;
            // 
            // flpSuggestions
            // 
            this.flpSuggestions.Location = new System.Drawing.Point(8, 366);
            this.flpSuggestions.Margin = new System.Windows.Forms.Padding(2);
            this.flpSuggestions.Name = "flpSuggestions";
            this.flpSuggestions.Size = new System.Drawing.Size(553, 99);
            this.flpSuggestions.TabIndex = 4;
            // 
            // tbxInput
            // 
            this.tbxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInput.Location = new System.Drawing.Point(8, 332);
            this.tbxInput.Margin = new System.Windows.Forms.Padding(2);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(553, 30);
            this.tbxInput.TabIndex = 5;
            // 
            // canvas1
            // 
            this.canvas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.canvas1.Location = new System.Drawing.Point(117, 8);
            this.canvas1.Margin = new System.Windows.Forms.Padding(2);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(333, 320);
            this.canvas1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 524);
            this.Controls.Add(this.canvas1);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.flpSuggestions);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnClear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(585, 603);
            this.MinimumSize = new System.Drawing.Size(585, 481);
            this.Name = "Form1";
            this.Text = "Google Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.FlowLayoutPanel flpSuggestions;
        private System.Windows.Forms.TextBox tbxInput;
        private Canvas canvas1;
    }
}

