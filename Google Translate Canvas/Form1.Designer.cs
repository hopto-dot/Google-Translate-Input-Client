
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
            this.btnClear = new System.Windows.Forms.Button();
            this.canvas1 = new Google_Translate_Canvas.Canvas();
            this.lblOutput = new System.Windows.Forms.Label();
            this.flpSuggestions = new System.Windows.Forms.FlowLayoutPanel();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 69);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // canvas1
            // 
            this.canvas1.BackColor = System.Drawing.Color.White;
            this.canvas1.Location = new System.Drawing.Point(175, 12);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(500, 500);
            this.canvas1.TabIndex = 2;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(12, 811);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(834, 171);
            this.lblOutput.TabIndex = 3;
            // 
            // flpSuggestions
            // 
            this.flpSuggestions.Location = new System.Drawing.Point(12, 528);
            this.flpSuggestions.Name = "flpSuggestions";
            this.flpSuggestions.Size = new System.Drawing.Size(827, 166);
            this.flpSuggestions.TabIndex = 4;
            // 
            // tbxInput
            // 
            this.tbxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInput.Location = new System.Drawing.Point(12, 709);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(827, 44);
            this.tbxInput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 881);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.flpSuggestions);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.canvas1);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private Canvas canvas1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.FlowLayoutPanel flpSuggestions;
        private System.Windows.Forms.TextBox tbxInput;
    }
}

