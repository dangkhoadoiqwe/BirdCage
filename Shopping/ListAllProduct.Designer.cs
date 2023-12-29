namespace Shopping
{
    partial class ListAllProduct
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
            dataAllProduct = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtNamepro = new System.Windows.Forms.TextBox();
            txtPricePro = new System.Windows.Forms.TextBox();
            txtQuantiy = new System.Windows.Forms.TextBox();
            txtDepro = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtIdPRO = new System.Windows.Forms.TextBox();
            txtStatus = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtTime = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtImagePath = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            BtnAddProduct = new System.Windows.Forms.Button();
            BtnSavePro = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataAllProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataAllProduct
            // 
            dataAllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataAllProduct.Location = new System.Drawing.Point(12, 12);
            dataAllProduct.Name = "dataAllProduct";
            dataAllProduct.RowTemplate.Height = 25;
            dataAllProduct.Size = new System.Drawing.Size(281, 238);
            dataAllProduct.TabIndex = 0;
            dataAllProduct.CellContentClick += dataAllProduct_CellContentClick;
            dataAllProduct.SelectionChanged += ViewAPro;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(2, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên sản phẩm";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(2, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Giá sản phẩm";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(2, 125);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(109, 15);
            label3.TabIndex = 3;
            label3.Text = "Số lượng sản phẩm";
            label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(2, 185);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(93, 15);
            label4.TabIndex = 4;
            label4.Text = "Mô tả sản phẩm";
            label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNamepro
            // 
            txtNamepro.Location = new System.Drawing.Point(2, 34);
            txtNamepro.Name = "txtNamepro";
            txtNamepro.Size = new System.Drawing.Size(173, 23);
            txtNamepro.TabIndex = 5;
            // 
            // txtPricePro
            // 
            txtPricePro.Location = new System.Drawing.Point(2, 99);
            txtPricePro.Name = "txtPricePro";
            txtPricePro.Size = new System.Drawing.Size(173, 23);
            txtPricePro.TabIndex = 6;
            // 
            // txtQuantiy
            // 
            txtQuantiy.Location = new System.Drawing.Point(0, 143);
            txtQuantiy.Name = "txtQuantiy";
            txtQuantiy.Size = new System.Drawing.Size(173, 23);
            txtQuantiy.TabIndex = 7;
            txtQuantiy.TextChanged += txtQuantiy_TextChanged;
            // 
            // txtDepro
            // 
            txtDepro.Location = new System.Drawing.Point(0, 203);
            txtDepro.Name = "txtDepro";
            txtDepro.Size = new System.Drawing.Size(175, 23);
            txtDepro.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "JPEG, PNG, GIF";
            pictureBox1.Location = new System.Drawing.Point(299, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(256, 245);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIdPRO);
            groupBox1.Controls.Add(txtStatus);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTime);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtImagePath);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDepro);
            groupBox1.Controls.Add(txtQuantiy);
            groupBox1.Controls.Add(txtPricePro);
            groupBox1.Controls.Add(txtNamepro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(561, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(218, 388);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // txtIdPRO
            // 
            txtIdPRO.Location = new System.Drawing.Point(107, 11);
            txtIdPRO.Name = "txtIdPRO";
            txtIdPRO.Size = new System.Drawing.Size(66, 23);
            txtIdPRO.TabIndex = 15;
            // 
            // txtStatus
            // 
            txtStatus.Location = new System.Drawing.Point(68, 324);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(105, 23);
            txtStatus.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 327);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(59, 15);
            label7.TabIndex = 13;
            label7.Text = "Trạng thái";
            label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTime
            // 
            txtTime.Location = new System.Drawing.Point(2, 289);
            txtTime.Name = "txtTime";
            txtTime.Size = new System.Drawing.Size(175, 23);
            txtTime.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(0, 271);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 15);
            label6.TabIndex = 11;
            label6.Text = "Ngày bắt đầu";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new System.Drawing.Point(36, 238);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new System.Drawing.Size(139, 23);
            txtImagePath.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(2, 238);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(28, 15);
            label5.TabIndex = 9;
            label5.Text = "Img";
            // 
            // BtnAddProduct
            // 
            BtnAddProduct.Location = new System.Drawing.Point(12, 275);
            BtnAddProduct.Name = "BtnAddProduct";
            BtnAddProduct.Size = new System.Drawing.Size(75, 23);
            BtnAddProduct.TabIndex = 11;
            BtnAddProduct.Text = "AddImg";
            BtnAddProduct.UseVisualStyleBackColor = true;
            BtnAddProduct.Click += BtnAddPro_click;
            // 
            // BtnSavePro
            // 
            BtnSavePro.Location = new System.Drawing.Point(93, 276);
            BtnSavePro.Name = "BtnSavePro";
            BtnSavePro.Size = new System.Drawing.Size(73, 22);
            BtnSavePro.TabIndex = 12;
            BtnSavePro.Text = "Save";
            BtnSavePro.UseVisualStyleBackColor = true;
            BtnSavePro.Click += BtnSave_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(183, 276);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(65, 22);
            button1.TabIndex = 13;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnUpdate_click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(254, 276);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(67, 22);
            button2.TabIndex = 14;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnDeletPro;
            // 
            // ListAllProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(748, 401);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BtnSavePro);
            Controls.Add(BtnAddProduct);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(dataAllProduct);
            Name = "ListAllProduct";
            Text = "ListAllProduct";
            ((System.ComponentModel.ISupportInitialize)dataAllProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataAllProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamepro;
        private System.Windows.Forms.TextBox txtPricePro;
        private System.Windows.Forms.TextBox txtQuantiy;
        private System.Windows.Forms.TextBox txtDepro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Button BtnSavePro;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdPRO;
        private System.Windows.Forms.Button button2;
    }
}