﻿namespace CSharpEgitimKampi301.PresentationLayer
{
	partial class FrmProduct
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
			this.btnGetById = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.lblll = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnList = new System.Windows.Forms.Button();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.lblllllll = new System.Windows.Forms.Label();
			this.txtProductStock = new System.Windows.Forms.TextBox();
			this.lbllllll = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.labelll = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnList2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetById
			// 
			this.btnGetById.Location = new System.Drawing.Point(51, 474);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(219, 34);
			this.btnGetById.TabIndex = 25;
			this.btnGetById.Text = "Id\'ye göre getir";
			this.btnGetById.UseVisualStyleBackColor = true;
			this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(49, 349);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(219, 34);
			this.btnAdd.TabIndex = 24;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(49, 389);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(219, 34);
			this.btnDelete.TabIndex = 23;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(51, 434);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(219, 34);
			this.btnUpdate.TabIndex = 22;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(118, 50);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(155, 22);
			this.txtProductName.TabIndex = 18;
			// 
			// lblll
			// 
			this.lblll.AutoSize = true;
			this.lblll.Location = new System.Drawing.Point(42, 50);
			this.lblll.Name = "lblll";
			this.lblll.Size = new System.Drawing.Size(61, 16);
			this.lblll.TabIndex = 17;
			this.lblll.Text = "Ürün Adı:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(324, 27);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(525, 473);
			this.dataGridView1.TabIndex = 16;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(49, 309);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(106, 34);
			this.btnList.TabIndex = 15;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(118, 12);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(155, 22);
			this.txtProductId.TabIndex = 14;
			// 
			// lblllllll
			// 
			this.lblllllll.AutoSize = true;
			this.lblllllll.Location = new System.Drawing.Point(51, 12);
			this.lblllllll.Name = "lblllllll";
			this.lblllllll.Size = new System.Drawing.Size(52, 16);
			this.lblllllll.TabIndex = 13;
			this.lblllllll.Text = "Ürün Id:";
			// 
			// txtProductStock
			// 
			this.txtProductStock.Location = new System.Drawing.Point(118, 88);
			this.txtProductStock.Name = "txtProductStock";
			this.txtProductStock.Size = new System.Drawing.Size(155, 22);
			this.txtProductStock.TabIndex = 27;
			// 
			// lbllllll
			// 
			this.lbllllll.AutoSize = true;
			this.lbllllll.Location = new System.Drawing.Point(35, 88);
			this.lbllllll.Name = "lbllllll";
			this.lbllllll.Size = new System.Drawing.Size(68, 16);
			this.lbllllll.TabIndex = 26;
			this.lbllllll.Text = "Ürün Stok:";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Location = new System.Drawing.Point(118, 126);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(155, 22);
			this.txtProductPrice.TabIndex = 29;
			// 
			// labelll
			// 
			this.labelll.AutoSize = true;
			this.labelll.Location = new System.Drawing.Point(33, 126);
			this.labelll.Name = "labelll";
			this.labelll.Size = new System.Drawing.Size(70, 16);
			this.labelll.TabIndex = 28;
			this.labelll.Text = "Ürün Fiyat:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(43, 166);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 16);
			this.label6.TabIndex = 30;
			this.label6.Text = "Kategori:";
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(118, 166);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(155, 24);
			this.cmbCategory.TabIndex = 31;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(118, 209);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(155, 68);
			this.txtDescription.TabIndex = 32;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(40, 212);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 16);
			this.label7.TabIndex = 33;
			this.label7.Text = "Açıklama";
			// 
			// btnList2
			// 
			this.btnList2.Location = new System.Drawing.Point(161, 309);
			this.btnList2.Name = "btnList2";
			this.btnList2.Size = new System.Drawing.Size(101, 34);
			this.btnList2.TabIndex = 34;
			this.btnList2.Text = "Listele 2";
			this.btnList2.UseVisualStyleBackColor = true;
			this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
			// 
			// FrmProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(861, 512);
			this.Controls.Add(this.btnList2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.labelll);
			this.Controls.Add(this.txtProductStock);
			this.Controls.Add(this.lbllllll);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.lblll);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtProductId);
			this.Controls.Add(this.lblllllll);
			this.Name = "FrmProduct";
			this.Text = "FrmProduct";
			this.Load += new System.EventHandler(this.FrmProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetById;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label lblll;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtProductId;
		private System.Windows.Forms.Label lblllllll;
		private System.Windows.Forms.TextBox txtProductStock;
		private System.Windows.Forms.Label lbllllll;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label labelll;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnList2;
	}
}