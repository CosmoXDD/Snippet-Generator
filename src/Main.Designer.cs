namespace Snippet_Generator
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.snippet = new System.Windows.Forms.TextBox();
            this.text_1 = new System.Windows.Forms.Label();
            this.text_2 = new System.Windows.Forms.Label();
            this.text_3 = new System.Windows.Forms.Label();
            this.text_4 = new System.Windows.Forms.Label();
            this.text_5 = new System.Windows.Forms.Label();
            this.snippet_name = new System.Windows.Forms.TextBox();
            this.snippet_description = new System.Windows.Forms.TextBox();
            this.snippet_prefix = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // snippet
            // 
            this.snippet.Location = new System.Drawing.Point(167, 12);
            this.snippet.Multiline = true;
            this.snippet.Name = "snippet";
            this.snippet.Size = new System.Drawing.Size(390, 399);
            this.snippet.TabIndex = 0;
            // 
            // text_1
            // 
            this.text_1.AutoSize = true;
            this.text_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_1.Location = new System.Drawing.Point(12, 12);
            this.text_1.Name = "text_1";
            this.text_1.Size = new System.Drawing.Size(141, 20);
            this.text_1.TabIndex = 1;
            this.text_1.Text = "Snippet Generator";
            // 
            // text_2
            // 
            this.text_2.AutoSize = true;
            this.text_2.Location = new System.Drawing.Point(81, 32);
            this.text_2.Name = "text_2";
            this.text_2.Size = new System.Drawing.Size(72, 13);
            this.text_2.TabIndex = 2;
            this.text_2.Text = "By: CosmoXD";
            // 
            // text_3
            // 
            this.text_3.AutoSize = true;
            this.text_3.Location = new System.Drawing.Point(13, 131);
            this.text_3.Name = "text_3";
            this.text_3.Size = new System.Drawing.Size(63, 13);
            this.text_3.TabIndex = 3;
            this.text_3.Text = "Description:";
            // 
            // text_4
            // 
            this.text_4.AutoSize = true;
            this.text_4.Location = new System.Drawing.Point(13, 74);
            this.text_4.Name = "text_4";
            this.text_4.Size = new System.Drawing.Size(38, 13);
            this.text_4.TabIndex = 4;
            this.text_4.Text = "Name:";
            // 
            // text_5
            // 
            this.text_5.AutoSize = true;
            this.text_5.Location = new System.Drawing.Point(13, 221);
            this.text_5.Name = "text_5";
            this.text_5.Size = new System.Drawing.Size(36, 13);
            this.text_5.TabIndex = 5;
            this.text_5.Text = "Prefix:";
            // 
            // snippet_name
            // 
            this.snippet_name.Location = new System.Drawing.Point(16, 91);
            this.snippet_name.Name = "snippet_name";
            this.snippet_name.Size = new System.Drawing.Size(137, 20);
            this.snippet_name.TabIndex = 6;
            // 
            // snippet_description
            // 
            this.snippet_description.Location = new System.Drawing.Point(16, 148);
            this.snippet_description.Multiline = true;
            this.snippet_description.Name = "snippet_description";
            this.snippet_description.Size = new System.Drawing.Size(137, 50);
            this.snippet_description.TabIndex = 7;
            // 
            // snippet_prefix
            // 
            this.snippet_prefix.Location = new System.Drawing.Point(16, 237);
            this.snippet_prefix.Name = "snippet_prefix";
            this.snippet_prefix.Size = new System.Drawing.Size(137, 20);
            this.snippet_prefix.TabIndex = 8;
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(16, 280);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(137, 46);
            this.btn_1.TabIndex = 9;
            this.btn_1.Text = "Help";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(50, 388);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(60, 23);
            this.btn_2.TabIndex = 10;
            this.btn_2.Text = "Exit";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(16, 347);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(137, 24);
            this.btn_3.TabIndex = 11;
            this.btn_3.Text = "Generate";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 423);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.snippet_prefix);
            this.Controls.Add(this.snippet_description);
            this.Controls.Add(this.snippet_name);
            this.Controls.Add(this.text_5);
            this.Controls.Add(this.text_4);
            this.Controls.Add(this.text_3);
            this.Controls.Add(this.text_2);
            this.Controls.Add(this.text_1);
            this.Controls.Add(this.snippet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main | Snippet Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox snippet;
        private System.Windows.Forms.Label text_1;
        private System.Windows.Forms.Label text_2;
        private System.Windows.Forms.Label text_3;
        private System.Windows.Forms.Label text_4;
        private System.Windows.Forms.Label text_5;
        private System.Windows.Forms.TextBox snippet_name;
        private System.Windows.Forms.TextBox snippet_description;
        private System.Windows.Forms.TextBox snippet_prefix;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
    }
}

