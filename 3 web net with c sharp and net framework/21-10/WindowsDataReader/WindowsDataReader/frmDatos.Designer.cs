
namespace WindowsDataReader
{
    partial class frmDatos
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
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.txtIdCategoriaParametros = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnTraerPorIdCategoria = new System.Windows.Forms.Button();
            this.btnTraerTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProduct
            // 
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridProduct.Location = new System.Drawing.Point(0, 146);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.Size = new System.Drawing.Size(598, 150);
            this.gridProduct.TabIndex = 0;
            // 
            // txtIdCategoriaParametros
            // 
            this.txtIdCategoriaParametros.Location = new System.Drawing.Point(202, 64);
            this.txtIdCategoriaParametros.Name = "txtIdCategoriaParametros";
            this.txtIdCategoriaParametros.Size = new System.Drawing.Size(100, 20);
            this.txtIdCategoriaParametros.TabIndex = 1;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(50, 69);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(104, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "traer por id categoria";
            // 
            // btnTraerPorIdCategoria
            // 
            this.btnTraerPorIdCategoria.Location = new System.Drawing.Point(347, 64);
            this.btnTraerPorIdCategoria.Name = "btnTraerPorIdCategoria";
            this.btnTraerPorIdCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnTraerPorIdCategoria.TabIndex = 3;
            this.btnTraerPorIdCategoria.Text = "buscar";
            this.btnTraerPorIdCategoria.UseVisualStyleBackColor = true;
            this.btnTraerPorIdCategoria.Click += new System.EventHandler(this.btnTraerPorIdCategoria_Click);
            // 
            // btnTraerTodo
            // 
            this.btnTraerTodo.Location = new System.Drawing.Point(465, 64);
            this.btnTraerTodo.Name = "btnTraerTodo";
            this.btnTraerTodo.Size = new System.Drawing.Size(75, 23);
            this.btnTraerTodo.TabIndex = 4;
            this.btnTraerTodo.Text = "traer todo";
            this.btnTraerTodo.UseVisualStyleBackColor = true;
            this.btnTraerTodo.Click += new System.EventHandler(this.btnTraerTodo_Click);
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 296);
            this.Controls.Add(this.btnTraerTodo);
            this.Controls.Add(this.btnTraerPorIdCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtIdCategoriaParametros);
            this.Controls.Add(this.gridProduct);
            this.Name = "frmDatos";
            this.Text = "frmDatos";
            this.Load += new System.EventHandler(this.frmDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProduct;
        private System.Windows.Forms.TextBox txtIdCategoriaParametros;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnTraerPorIdCategoria;
        private System.Windows.Forms.Button btnTraerTodo;
    }
}