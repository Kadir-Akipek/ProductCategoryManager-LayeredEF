using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
	public partial class FrmCategory : Form
	{
		private readonly ICategoryService _categoryService;

		public FrmCategory()
		{
			_categoryService = new CategoryManager(new EfCategoryDal());
			InitializeComponent();
		}

		private void FrmCategory_Load(object sender, EventArgs e)
		{
			
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			var categoryCalues = _categoryService.TGetAll();
			dataGridView1.DataSource = categoryCalues;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Category category = new Category();
			category.CategoryName = txtCategoryName.Text;
			category.CategoryStatus = true;
			_categoryService.TInsert(category);
			MessageBox.Show("Ekleme başarılı");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			var deletedValues = _categoryService.TGetById(id);
			_categoryService.TDelete(deletedValues);
			MessageBox.Show("Silme başarılı");
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			var values = _categoryService.TGetById(id);
			dataGridView1.DataSource = values;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//Category category = new Category();
			int updatedId = int.Parse(txtCategoryId.Text);
			var updatedValue = _categoryService.TGetById(updatedId); //id ile istediğimiz satıra ulaştık
			updatedValue.CategoryName = txtCategoryName.Text; //id'sini aldığımız satırın name'ine gittik
			updatedValue.CategoryStatus = true;
			_categoryService.TUpdate(updatedValue);
		}
	}
}
