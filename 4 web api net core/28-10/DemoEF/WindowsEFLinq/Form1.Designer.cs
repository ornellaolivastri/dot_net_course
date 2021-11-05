
namespace WindowsEFLinq
{
    partial class Form1
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
            this.btnTraerTodo = new System.Windows.Forms.Button();
            this.btnTraerPorCategoria = new System.Windows.Forms.Button();
            this.btnTraerPorNombreProducto = new System.Windows.Forms.Button();
            this.btnTraerPorID = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.btnTraerProductoCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodo
            // 
            this.btnTraerTodo.Location = new System.Drawing.Point(258, 12);
            this.btnTraerTodo.Name = "btnTraerTodo";
            this.btnTraerTodo.Size = new System.Drawing.Size(259, 23);
            this.btnTraerTodo.TabIndex = 0;
            this.btnTraerTodo.Text = "traer todos los productos";
            this.btnTraerTodo.UseVisualStyleBackColor = true;
            this.btnTraerTodo.Click += new System.EventHandler(this.btnTraerTodo_Click);
            // 
            // btnTraerPorCategoria
            // 
            this.btnTraerPorCategoria.Location = new System.Drawing.Point(258, 41);
            this.btnTraerPorCategoria.Name = "btnTraerPorCategoria";
            this.btnTraerPorCategoria.Size = new System.Drawing.Size(259, 23);
            this.btnTraerPorCategoria.TabIndex = 1;
            this.btnTraerPorCategoria.Text = "traer todos los productos por categoria";
            this.btnTraerPorCategoria.UseVisualStyleBackColor = true;
            this.btnTraerPorCategoria.Click += new System.EventHandler(this.btnTraerPorCategoria_Click);
            // 
            // btnTraerPorNombreProducto
            // 
            this.btnTraerPorNombreProducto.Location = new System.Drawing.Point(258, 70);
            this.btnTraerPorNombreProducto.Name = "btnTraerPorNombreProducto";
            this.btnTraerPorNombreProducto.Size = new System.Drawing.Size(259, 23);
            this.btnTraerPorNombreProducto.TabIndex = 2;
            this.btnTraerPorNombreProducto.Text = "traer por nombre de producto";
            this.btnTraerPorNombreProducto.UseVisualStyleBackColor = true;
            this.btnTraerPorNombreProducto.Click += new System.EventHandler(this.btnTraerPorNombreProducto_Click);
            // 
            // btnTraerPorID
            // 
            this.btnTraerPorID.Location = new System.Drawing.Point(258, 99);
            this.btnTraerPorID.Name = "btnTraerPorID";
            this.btnTraerPorID.Size = new System.Drawing.Size(259, 23);
            this.btnTraerPorID.TabIndex = 3;
            this.btnTraerPorID.Text = "traer por ID";
            this.btnTraerPorID.UseVisualStyleBackColor = true;
            this.btnTraerPorID.Click += new System.EventHandler(this.btnTraerPorID_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridProductos.Location = new System.Drawing.Point(0, 138);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(800, 312);
            this.gridProductos.TabIndex = 4;
            // 
            // btnTraerProductoCategoria
            // 
            this.btnTraerProductoCategoria.Location = new System.Drawing.Point(80, 23);
            this.btnTraerProductoCategoria.Name = "btnTraerProductoCategoria";
            this.btnTraerProductoCategoria.Size = new System.Drawing.Size(75, 81);
            this.btnTraerProductoCategoria.TabIndex = 5;
            this.btnTraerProductoCategoria.Text = "traer producto categoria";
            this.btnTraerProductoCategoria.UseVisualStyleBackColor = true;
            this.btnTraerProductoCategoria.Click += new System.EventHandler(this.btnTraerProductoCategoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTraerProductoCategoria);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnTraerPorID);
            this.Controls.Add(this.btnTraerPorNombreProducto);
            this.Controls.Add(this.btnTraerPorCategoria);
            this.Controls.Add(this.btnTraerTodo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodo;
        private System.Windows.Forms.Button btnTraerPorCategoria;
        private System.Windows.Forms.Button btnTraerPorNombreProducto;
        private System.Windows.Forms.Button btnTraerPorID;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Button btnTraerProductoCategoria;
    }
}

