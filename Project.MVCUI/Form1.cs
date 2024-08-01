using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Project.BLL.DesignPatterns.GenericRepository.EFConcRap;
namespace Project.MVCUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		//	_cRep = new CategoryRepository();
		}
		//CategoryRepository _cRep;
		private void btnKategoriler_Click(object sender, EventArgs e)
		{
		//	lstKategoriler.DataSource = _cRep.GetActives();
		}
	}
}
