
namespace Project.MVCUI
{
	partial class Form1
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
			this.lstKategoriler = new System.Windows.Forms.ListBox();
			this.btnKategoriler = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstKategoriler
			// 
			this.lstKategoriler.FormattingEnabled = true;
			this.lstKategoriler.ItemHeight = 16;
			this.lstKategoriler.Location = new System.Drawing.Point(423, 57);
			this.lstKategoriler.Name = "lstKategoriler";
			this.lstKategoriler.Size = new System.Drawing.Size(242, 292);
			this.lstKategoriler.TabIndex = 0;
			// 
			// btnKategoriler
			// 
			this.btnKategoriler.Location = new System.Drawing.Point(147, 124);
			this.btnKategoriler.Name = "btnKategoriler";
			this.btnKategoriler.Size = new System.Drawing.Size(204, 56);
			this.btnKategoriler.TabIndex = 1;
			this.btnKategoriler.Text = "Kategorileri Listele";
			this.btnKategoriler.UseVisualStyleBackColor = true;
			this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnKategoriler);
			this.Controls.Add(this.lstKategoriler);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstKategoriler;
		private System.Windows.Forms.Button btnKategoriler;
	}
}

