/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 23/03/2021
 * Time: 14:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace nomeSenha
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox listBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.OldLace;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(53, 23);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(157, 186);
			this.listBox1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCoral;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.listBox1);
			this.Name = "MainForm";
			this.Text = "nomeSenha";
			this.ResumeLayout(false);

		}
	}
}
