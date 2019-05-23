namespace SysAlquiler
{
    partial class Buscar_concepto_form_Tarif
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
            this.dgv_concp = new System.Windows.Forms.DataGridView();
            this.txt_buscanom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_concp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_concp
            // 
            this.dgv_concp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgv_concp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_concp.Location = new System.Drawing.Point(12, 113);
            this.dgv_concp.Name = "dgv_concp";
            this.dgv_concp.Size = new System.Drawing.Size(495, 325);
            this.dgv_concp.TabIndex = 0;
            // 
            // txt_buscanom
            // 
            this.txt_buscanom.Location = new System.Drawing.Point(12, 71);
            this.txt_buscanom.Name = "txt_buscanom";
            this.txt_buscanom.Size = new System.Drawing.Size(245, 20);
            this.txt_buscanom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por Nombre de Concepto";
            // 
            // Buscar_concepto_form_Tarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscanom);
            this.Controls.Add(this.dgv_concp);
            this.Name = "Buscar_concepto_form_Tarif";
            this.Opacity = 0.9D;
            this.Text = "Buscar Concepto";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_concp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_concp;
        private System.Windows.Forms.TextBox txt_buscanom;
        private System.Windows.Forms.Label label1;
    }
}