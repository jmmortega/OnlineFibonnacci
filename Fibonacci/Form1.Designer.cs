namespace Fibonacci
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDo = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.linkLabelWhy = new System.Windows.Forms.LinkLabel();
            this.buttonShowCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(380, 32);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(75, 23);
            this.buttonDo.TabIndex = 0;
            this.buttonDo.Text = "Do";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(89, 35);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(285, 20);
            this.textBoxNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(42, 61);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(591, 251);
            this.textBoxResult.TabIndex = 4;
            // 
            // linkLabelWhy
            // 
            this.linkLabelWhy.AutoSize = true;
            this.linkLabelWhy.Location = new System.Drawing.Point(39, 330);
            this.linkLabelWhy.Name = "linkLabelWhy";
            this.linkLabelWhy.Size = new System.Drawing.Size(173, 13);
            this.linkLabelWhy.TabIndex = 6;
            this.linkLabelWhy.TabStop = true;
            this.linkLabelWhy.Text = "Why this fibonacci implementation?";
            this.linkLabelWhy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWhy_LinkClicked);
            // 
            // buttonShowCode
            // 
            this.buttonShowCode.Location = new System.Drawing.Point(461, 32);
            this.buttonShowCode.Name = "buttonShowCode";
            this.buttonShowCode.Size = new System.Drawing.Size(151, 23);
            this.buttonShowCode.TabIndex = 7;
            this.buttonShowCode.Text = "Show code";
            this.buttonShowCode.UseVisualStyleBackColor = true;
            this.buttonShowCode.Click += new System.EventHandler(this.buttonShowCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 392);
            this.Controls.Add(this.buttonShowCode);
            this.Controls.Add(this.linkLabelWhy);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.buttonDo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fibonacci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.LinkLabel linkLabelWhy;
        private System.Windows.Forms.Button buttonShowCode;
    }
}

