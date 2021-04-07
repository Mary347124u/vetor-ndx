/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 23/03/2021
 * Time: 14:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace nomeSenha
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			  
			InitializeComponent();
			 {
            int[] ndx = { 5, 0, 3, 1, 6, 2, 4 };
            string[] n = { "Antonio", "Carlos", "Helena", "Ariane", "Heloisa", "Antenor", "Catharine" };
            string[] s = { "73195555", "557711", "01410", "979491", "74123698", "40100104", "84267931" };
            for (int i=0; i<7; i++)
            {
                listBox1.Items.Add(n[ndx[i]]);
                listBox1.Items.Add(s[ndx[i]]);
            }
        }
			
            
            
		}
	}
}
