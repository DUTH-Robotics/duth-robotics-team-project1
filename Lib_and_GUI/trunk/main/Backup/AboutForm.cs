using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ColorSyntaxEditor
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class AboutForm : System.Windows.Forms.Form
	{
		private TD.Eyefinder.HeaderControl headerControl1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.Panel panel2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AboutForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AboutForm));
			this.headerControl1 = new TD.Eyefinder.HeaderControl();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.label7 = new System.Windows.Forms.Label();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.headerControl1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// headerControl1
			// 
			this.headerControl1.BackColor = System.Drawing.Color.White;
			this.headerControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.button1,
																						 this.label4,
																						 this.label3,
																						 this.label2,
																						 this.label1,
																						 this.panel1});
			this.headerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.headerControl1.HeaderFont = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.headerControl1.Name = "headerControl1";
			this.headerControl1.Size = new System.Drawing.Size(376, 256);
			this.headerControl1.TabIndex = 0;
			this.headerControl1.Text = "About";
			this.headerControl1.Click += new System.EventHandler(this.headerControl1_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(216, 224);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 24);
			this.button1.TabIndex = 8;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(161)));
			this.label4.Location = new System.Drawing.Point(16, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(352, 38);
			this.label4.TabIndex = 4;
			this.label4.Text = "Department of Electrical And Computer Engineering  Democritus University Of Thace" +
				" - Automatic Control System  Laboratory";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(161)));
			this.label3.Location = new System.Drawing.Point(16, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(264, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Impemented By Savvas Hadjichristofis";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(161)));
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(272, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Accosiate Professor Ioannis Butalis";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(161)));
			this.label1.Location = new System.Drawing.Point(8, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(360, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "RoboSoft - Robot Control Software Ver 0.1";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel2});
			this.panel1.Location = new System.Drawing.Point(8, 136);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(360, 80);
			this.panel1.TabIndex = 13;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Gainsboro;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.linkLabel2,
																				 this.label7,
																				 this.linkLabel3,
																				 this.label6,
																				 this.label5,
																				 this.linkLabel1,
																				 this.linkLabel4});
			this.panel2.Location = new System.Drawing.Point(-1, -1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(361, 80);
			this.panel2.TabIndex = 14;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// linkLabel2
			// 
			this.linkLabel2.BackColor = System.Drawing.Color.Gainsboro;
			this.linkLabel2.Location = new System.Drawing.Point(99, 40);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(120, 17);
			this.linkLabel2.TabIndex = 6;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Http://www.ee.duth.gr";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Gainsboro;
			this.label7.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(161)));
			this.label7.Location = new System.Drawing.Point(3, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "Foundation Site:";
			// 
			// linkLabel3
			// 
			this.linkLabel3.BackColor = System.Drawing.Color.Gainsboro;
			this.linkLabel3.Location = new System.Drawing.Point(99, 56);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(144, 16);
			this.linkLabel3.TabIndex = 7;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "Http://www.acsl.ee..duth.gr";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Gainsboro;
			this.label6.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(161)));
			this.label6.Location = new System.Drawing.Point(3, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Bugs Report:";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Gainsboro;
			this.label5.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(161)));
			this.label5.Location = new System.Drawing.Point(3, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Official Site:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.BackColor = System.Drawing.Color.Gainsboro;
			this.linkLabel1.Location = new System.Drawing.Point(99, 24);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(112, 16);
			this.linkLabel1.TabIndex = 5;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "savvash@gmail.com";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// linkLabel4
			// 
			this.linkLabel4.BackColor = System.Drawing.Color.Gainsboro;
			this.linkLabel4.Location = new System.Drawing.Point(99, 8);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(186, 16);
			this.linkLabel4.TabIndex = 9;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "http://acsl.ee.duth.gr/savvash";
			// 
			// AboutForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(376, 256);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.headerControl1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About img(Rummager)";
			this.headerControl1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
		//System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
		}

		private void headerControl1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}
	}
}
