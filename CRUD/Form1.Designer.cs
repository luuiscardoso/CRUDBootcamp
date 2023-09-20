namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnNovoProduto = new Button();
            btnRemover = new Button();
            btnEditar = new Button();
            lblBuscar = new Label();
            tstIdBuscar = new TextBox();
            btnBuscar = new Button();
            lblProduto = new Label();
            tstProduto = new TextBox();
            lblId = new Label();
            tstId = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNovoProduto
            // 
            btnNovoProduto.Location = new Point(206, 346);
            btnNovoProduto.Name = "btnNovoProduto";
            btnNovoProduto.Size = new Size(98, 29);
            btnNovoProduto.TabIndex = 0;
            btnNovoProduto.Text = "ADICIONAR";
            btnNovoProduto.UseVisualStyleBackColor = true;
            btnNovoProduto.Click += btnNovoProduto_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(347, 346);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(97, 29);
            btnRemover.TabIndex = 1;
            btnRemover.Text = "REMOVER";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(489, 346);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(261, 264);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(94, 15);
            lblBuscar.TabIndex = 3;
            lblBuscar.Text = "BUSCAR POR ID:";
            // 
            // tstIdBuscar
            // 
            tstIdBuscar.Location = new Point(361, 261);
            tstIdBuscar.Name = "tstIdBuscar";
            tstIdBuscar.Size = new Size(60, 23);
            tstIdBuscar.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(431, 261);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(30, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(292, 159);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(63, 15);
            lblProduto.TabIndex = 6;
            lblProduto.Text = "PRODUTO:";
            // 
            // tstProduto
            // 
            tstProduto.Location = new Point(361, 156);
            tstProduto.Name = "tstProduto";
            tstProduto.Size = new Size(100, 23);
            tstProduto.TabIndex = 7;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(332, 211);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 8;
            lblId.Text = "ID:";
            // 
            // tstId
            // 
            tstId.Location = new Point(361, 208);
            tstId.Name = "tstId";
            tstId.Size = new Size(100, 23);
            tstId.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(361, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 450);
            Controls.Add(pictureBox1);
            Controls.Add(tstId);
            Controls.Add(lblId);
            Controls.Add(tstProduto);
            Controls.Add(lblProduto);
            Controls.Add(btnBuscar);
            Controls.Add(tstIdBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(btnEditar);
            Controls.Add(btnRemover);
            Controls.Add(btnNovoProduto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovoProduto;
        private Button btnRemover;
        private Button btnEditar;
        private Label lblBuscar;
        private TextBox tstIdBuscar;
        private Button btnBuscar;
        private Label lblProduto;
        private TextBox tstProduto;
        private Label lblId;
        private TextBox tstId;
        private PictureBox pictureBox1;
    }
}