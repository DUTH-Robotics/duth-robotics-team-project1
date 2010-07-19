using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;


using System.Drawing.Drawing2D;
using System.Drawing.Text;
//using System.IO;







namespace ColorSyntaxEditor
{

	public class Form1 : System.Windows.Forms.Form
	{
	//	private ColorSyntaxEditor.FlickerFreeRichEditTextBox richTextBox1;

		private TD.Eyefinder.NavigationBar navigationBar2;
		private TD.Eyefinder.NavigationPane navigationPane6;
		private TD.Eyefinder.NavigationPane navigationPane7;
		private TD.Eyefinder.NavigationPane navigationPane8;
		private TD.Eyefinder.NavigationPane navigationPane10;
		private TD.Eyefinder.NavigationPane navigationPane11;
		private TD.Eyefinder.NavigationPane navigationPane12;
		private TD.Eyefinder.HeaderControl headerControl1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private TD.Eyefinder.HeaderControl headerControl2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private TD.Eyefinder.HeaderControl headerControl3;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private TD.Eyefinder.HeaderControl headerControl4;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.Button button26;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private TD.Eyefinder.HeaderControl headerControl6;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Button button27;
		private System.Windows.Forms.Button button29;
		private System.Windows.Forms.Button button30;
		private System.Windows.Forms.Button button31;
		private System.Windows.Forms.Button button28;
		private System.Windows.Forms.Button button32;
		private TD.Eyefinder.HeaderControl headerControl7;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.LinkLabel linkLabel5;
		private System.Windows.Forms.LinkLabel linkLabel6;
		private System.Windows.Forms.LinkLabel linkLabel7;
		private System.Windows.Forms.Label label33;
		private TD.Eyefinder.HeaderControl headerControl8;
		private TD.Eyefinder.HeaderControl headerControl9;
		private TD.Eyefinder.HeaderControl headerControl10;
		private TD.Eyefinder.HeaderControl headerControl11;
		private TD.Eyefinder.HeaderControl headerControl12;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.LinkLabel linkLabel8;
		private System.Windows.Forms.LinkLabel linkLabel9;
		private System.Windows.Forms.LinkLabel linkLabel10;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Button button33;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Button button34;
		private System.Windows.Forms.Button button35;
		private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button button38;
	    private System.ComponentModel.IContainer components=null ;
		private bool populating = true;
		private SyntaxReader TheSyntaxReader;
        private ColorSyntaxEditor.FlickerFreeRichEditTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabPage tabPage3;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
	//	private WindowsControlLibrary2.entoles entoles5;
	//	private WindowsControlLibrary2.entoles entoles6;
//		private WindowsControlLibrary2.entoles entoles3;
//		private WindowsControlLibrary2.entoles entoles4;
		//private WindowsControlLibrary2.entoles entoles2;
        //private WindowsControlLibrary2.entoles entoles1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown7;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private ToolStripMenuItem teachModeToolStripMenuItem;
        private ToolStripMenuItem writeCodeToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem runDemosToolStripMenuItem;
        private ToolStripMenuItem switchOnOnboarCameraToolStripMenuItem;
        private ToolStripMenuItem switchOnEnviromentCameraToolStripMenuItem;
        private ToolStripMenuItem calibrateCameraToolStripMenuItem;
        private ToolStripMenuItem managePortsToolStripMenuItem;
        private ToolStripMenuItem setRobotManuallyToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private Panel panel1;
        private Button button44;
        private Button button45;
        private Button button46;
        private Button button42;
        private Button button43;
        private Button button41;
        private Button button40;
        private Panel panel3;
        private Label label1;
        private Button button48;
        private Button button47;
        private Button button39;
        private properties_control properties_control1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem1;
        private ToolStripMenuItem optionsToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
		private  Color kCommentColor = Color.Green;
		

		public Form1()
		{
				
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.MakeColorSyntaxForAllText(richTextBox1.Text);
			TheSyntaxReader = new SyntaxReader("php.syntax");
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		



		// Γενικες Μεταβλητες

        
        ArrayList PropertiesTextboxes = new ArrayList();
        ArrayList PropertiesLabels = new ArrayList();
        ArrayList PropertiesButtons = new ArrayList();

        ArrayList PropertiesCommands = new ArrayList();
        ArrayList PropertiesShortcuts = new ArrayList();


		// Τελος Γενικων Μεταβλητων

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navigationBar2 = new TD.Eyefinder.NavigationBar();
            this.navigationPane6 = new TD.Eyefinder.NavigationPane();
            this.navigationPane7 = new TD.Eyefinder.NavigationPane();
            this.navigationPane8 = new TD.Eyefinder.NavigationPane();
            this.navigationPane10 = new TD.Eyefinder.NavigationPane();
            this.headerControl12 = new TD.Eyefinder.HeaderControl();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.label28 = new System.Windows.Forms.Label();
            this.navigationPane11 = new TD.Eyefinder.NavigationPane();
            this.headerControl7 = new TD.Eyefinder.HeaderControl();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.label33 = new System.Windows.Forms.Label();
            this.navigationPane12 = new TD.Eyefinder.NavigationPane();
            this.headerControl2 = new TD.Eyefinder.HeaderControl();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.headerControl1 = new TD.Eyefinder.HeaderControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerControl3 = new TD.Eyefinder.HeaderControl();
            this.headerControl6 = new TD.Eyefinder.HeaderControl();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.headerControl4 = new TD.Eyefinder.HeaderControl();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button28 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.headerControl8 = new TD.Eyefinder.HeaderControl();
            this.headerControl10 = new TD.Eyefinder.HeaderControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button48 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.properties_control1 = new ColorSyntaxEditor.properties_control();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.headerControl9 = new TD.Eyefinder.HeaderControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new ColorSyntaxEditor.FlickerFreeRichEditTextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.button37 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.headerControl11 = new TD.Eyefinder.HeaderControl();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button38 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label29 = new System.Windows.Forms.Label();
            this.button33 = new System.Windows.Forms.Button();
            this.teachModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.runDemosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchOnOnboarCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchOnEnviromentCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrateCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRobotManuallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationBar2.SuspendLayout();
            this.navigationPane10.SuspendLayout();
            this.headerControl12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.navigationPane11.SuspendLayout();
            this.headerControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.navigationPane12.SuspendLayout();
            this.headerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.headerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.headerControl3.SuspendLayout();
            this.headerControl6.SuspendLayout();
            this.headerControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.headerControl8.SuspendLayout();
            this.headerControl10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.headerControl9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.headerControl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationBar2
            // 
            this.navigationBar2.BackColor = System.Drawing.Color.SteelBlue;
            this.navigationBar2.Controls.Add(this.navigationPane6);
            this.navigationBar2.Controls.Add(this.navigationPane7);
            this.navigationBar2.Controls.Add(this.navigationPane8);
            this.navigationBar2.Controls.Add(this.navigationPane10);
            this.navigationBar2.Controls.Add(this.navigationPane11);
            this.navigationBar2.Controls.Add(this.navigationPane12);
            this.navigationBar2.DrawActionsButton = false;
            this.navigationBar2.DrawGripper = false;
            this.navigationBar2.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.navigationBar2.Location = new System.Drawing.Point(0, 24);
            this.navigationBar2.Name = "navigationBar2";
            this.navigationBar2.PaneFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.navigationBar2.SelectedPane = this.navigationPane10;
            this.navigationBar2.ShowPanes = 6;
            this.navigationBar2.Size = new System.Drawing.Size(144, 597);
            this.navigationBar2.TabIndex = 0;
            // 
            // navigationPane6
            // 
            this.navigationPane6.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane6.LargeImage = ((System.Drawing.Image)(resources.GetObject("navigationPane6.LargeImage")));
            this.navigationPane6.Location = new System.Drawing.Point(1, 26);
            this.navigationPane6.Name = "navigationPane6";
            this.navigationPane6.Size = new System.Drawing.Size(142, 402);
            this.navigationPane6.TabIndex = 0;
            this.navigationPane6.Text = "Load MVF Files";
            // 
            // navigationPane7
            // 
            this.navigationPane7.LargeImage = ((System.Drawing.Image)(resources.GetObject("navigationPane7.LargeImage")));
            this.navigationPane7.Location = new System.Drawing.Point(1, 26);
            this.navigationPane7.Name = "navigationPane7";
            this.navigationPane7.Size = new System.Drawing.Size(142, 402);
            this.navigationPane7.TabIndex = 1;
            this.navigationPane7.Text = "Machine Vision";
            // 
            // navigationPane8
            // 
            this.navigationPane8.LargeImage = ((System.Drawing.Image)(resources.GetObject("navigationPane8.LargeImage")));
            this.navigationPane8.Location = new System.Drawing.Point(1, 26);
            this.navigationPane8.Name = "navigationPane8";
            this.navigationPane8.Size = new System.Drawing.Size(142, 402);
            this.navigationPane8.TabIndex = 2;
            this.navigationPane8.Text = "Camera ";
            // 
            // navigationPane10
            // 
            this.navigationPane10.Controls.Add(this.headerControl12);
            this.navigationPane10.LargeImage = ((System.Drawing.Image)(resources.GetObject("navigationPane10.LargeImage")));
            this.navigationPane10.Location = new System.Drawing.Point(1, 26);
            this.navigationPane10.Name = "navigationPane10";
            this.navigationPane10.Size = new System.Drawing.Size(142, 402);
            this.navigationPane10.TabIndex = 4;
            this.navigationPane10.Text = "Write Code";
            this.navigationPane10.Click += new System.EventHandler(this.navigationPane10_Click);
            // 
            // headerControl12
            // 
            this.headerControl12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headerControl12.Controls.Add(this.pictureBox8);
            this.headerControl12.Controls.Add(this.linkLabel8);
            this.headerControl12.Controls.Add(this.linkLabel9);
            this.headerControl12.Controls.Add(this.linkLabel10);
            this.headerControl12.Controls.Add(this.label28);
            this.headerControl12.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl12.Location = new System.Drawing.Point(5, 7);
            this.headerControl12.Name = "headerControl12";
            this.headerControl12.Size = new System.Drawing.Size(131, 368);
            this.headerControl12.TabIndex = 2;
            this.headerControl12.Text = "Help";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(4, 36);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(16, 16);
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            // 
            // linkLabel8
            // 
            this.linkLabel8.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel8.Image")));
            this.linkLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel8.Location = new System.Drawing.Point(9, 288);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(112, 16);
            this.linkLabel8.TabIndex = 11;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "      Change Licence";
            // 
            // linkLabel9
            // 
            this.linkLabel9.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel9.Image")));
            this.linkLabel9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel9.Location = new System.Drawing.Point(9, 240);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(112, 16);
            this.linkLabel9.TabIndex = 10;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "      Manage Ports";
            // 
            // linkLabel10
            // 
            this.linkLabel10.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel10.Image")));
            this.linkLabel10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel10.Location = new System.Drawing.Point(8, 264);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(112, 16);
            this.linkLabel10.TabIndex = 9;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "      Manage Cameras";
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(21, 37);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(105, 192);
            this.label28.TabIndex = 2;
            this.label28.Text = "If you are familiar with computer programming use editor to program the robot. El" +
                "se use the shortcuts to give your commands. After completing the source, press “" +
                "Compile and Run\"";
            // 
            // navigationPane11
            // 
            this.navigationPane11.BackColor = System.Drawing.Color.SteelBlue;
            this.navigationPane11.Controls.Add(this.headerControl7);
            this.navigationPane11.LargeImage = ((System.Drawing.Image)(resources.GetObject("navigationPane11.LargeImage")));
            this.navigationPane11.Location = new System.Drawing.Point(1, 26);
            this.navigationPane11.Name = "navigationPane11";
            this.navigationPane11.Size = new System.Drawing.Size(142, 402);
            this.navigationPane11.TabIndex = 5;
            this.navigationPane11.Text = "Teach Mode";
            // 
            // headerControl7
            // 
            this.headerControl7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headerControl7.Controls.Add(this.pictureBox7);
            this.headerControl7.Controls.Add(this.linkLabel5);
            this.headerControl7.Controls.Add(this.linkLabel6);
            this.headerControl7.Controls.Add(this.linkLabel7);
            this.headerControl7.Controls.Add(this.label33);
            this.headerControl7.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl7.Location = new System.Drawing.Point(5, 7);
            this.headerControl7.Name = "headerControl7";
            this.headerControl7.Size = new System.Drawing.Size(131, 368);
            this.headerControl7.TabIndex = 1;
            this.headerControl7.Text = "Help";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(4, 36);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(16, 16);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // linkLabel5
            // 
            this.linkLabel5.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel5.Image")));
            this.linkLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel5.Location = new System.Drawing.Point(9, 288);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(112, 16);
            this.linkLabel5.TabIndex = 11;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "      Change Licence";
            // 
            // linkLabel6
            // 
            this.linkLabel6.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel6.Image")));
            this.linkLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel6.Location = new System.Drawing.Point(9, 240);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(112, 16);
            this.linkLabel6.TabIndex = 10;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "      Manage Ports";
            // 
            // linkLabel7
            // 
            this.linkLabel7.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel7.Image")));
            this.linkLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel7.Location = new System.Drawing.Point(8, 264);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(112, 16);
            this.linkLabel7.TabIndex = 9;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "      Manage Cameras";
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(21, 37);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(105, 192);
            this.label33.TabIndex = 2;
            this.label33.Text = resources.GetString("label33.Text");
            // 
            // navigationPane12
            // 
            this.navigationPane12.BackColor = System.Drawing.Color.SteelBlue;
            this.navigationPane12.Controls.Add(this.headerControl2);
            this.navigationPane12.LargeImage = ((System.Drawing.Image)(resources.GetObject("navigationPane12.LargeImage")));
            this.navigationPane12.Location = new System.Drawing.Point(1, 26);
            this.navigationPane12.Name = "navigationPane12";
            this.navigationPane12.Size = new System.Drawing.Size(142, 402);
            this.navigationPane12.TabIndex = 6;
            this.navigationPane12.Text = "General";
            // 
            // headerControl2
            // 
            this.headerControl2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headerControl2.Controls.Add(this.pictureBox5);
            this.headerControl2.Controls.Add(this.pictureBox4);
            this.headerControl2.Controls.Add(this.pictureBox3);
            this.headerControl2.Controls.Add(this.pictureBox2);
            this.headerControl2.Controls.Add(this.linkLabel4);
            this.headerControl2.Controls.Add(this.linkLabel2);
            this.headerControl2.Controls.Add(this.linkLabel3);
            this.headerControl2.Controls.Add(this.label10);
            this.headerControl2.Controls.Add(this.label12);
            this.headerControl2.Controls.Add(this.label8);
            this.headerControl2.Controls.Add(this.label9);
            this.headerControl2.Controls.Add(this.label7);
            this.headerControl2.Controls.Add(this.label6);
            this.headerControl2.Controls.Add(this.label5);
            this.headerControl2.Controls.Add(this.label4);
            this.headerControl2.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl2.Location = new System.Drawing.Point(5, 7);
            this.headerControl2.Name = "headerControl2";
            this.headerControl2.Size = new System.Drawing.Size(131, 368);
            this.headerControl2.TabIndex = 0;
            this.headerControl2.Text = "Status";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(9, 201);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 16);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 150);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel4
            // 
            this.linkLabel4.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel4.Image")));
            this.linkLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel4.Location = new System.Drawing.Point(9, 288);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(112, 16);
            this.linkLabel4.TabIndex = 11;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "      Change Licence";
            // 
            // linkLabel2
            // 
            this.linkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel2.Image")));
            this.linkLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel2.Location = new System.Drawing.Point(9, 240);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(112, 16);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "      Manage Ports";
            // 
            // linkLabel3
            // 
            this.linkLabel3.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel3.Image")));
            this.linkLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel3.Location = new System.Drawing.Point(8, 264);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(112, 16);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "      Manage Cameras";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.Location = new System.Drawing.Point(28, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Full Version";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(9, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Licence";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(28, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 14);
            this.label8.TabIndex = 5;
            this.label8.Text = "Not Connected";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(9, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Enviroment Camera";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(28, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "Not Connected";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "OnBoard Camera";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(27, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Not Connected";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Robot Status";
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headerControl1.BuddyPane = this.navigationPane12;
            this.headerControl1.Controls.Add(this.linkLabel1);
            this.headerControl1.Controls.Add(this.label2);
            this.headerControl1.Controls.Add(this.label3);
            this.headerControl1.Controls.Add(this.pictureBox1);
            this.headerControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.headerControl1.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl1.Location = new System.Drawing.Point(144, 24);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(752, 597);
            this.headerControl1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(11, 80);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(464, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Property of Democritus University of Thrace – ACS Laboratory ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "RoboSoft - Robot Control Software Ver 0.1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(8, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plus Neural Networks and Machine Vision Controls";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 447);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // headerControl3
            // 
            this.headerControl3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headerControl3.BuddyPane = this.navigationPane11;
            this.headerControl3.Controls.Add(this.headerControl6);
            this.headerControl3.Controls.Add(this.headerControl4);
            this.headerControl3.Controls.Add(this.button14);
            this.headerControl3.Controls.Add(this.button13);
            this.headerControl3.Controls.Add(this.button12);
            this.headerControl3.Controls.Add(this.button11);
            this.headerControl3.Controls.Add(this.button10);
            this.headerControl3.Controls.Add(this.button9);
            this.headerControl3.Controls.Add(this.button8);
            this.headerControl3.Controls.Add(this.button7);
            this.headerControl3.Controls.Add(this.button6);
            this.headerControl3.Controls.Add(this.button5);
            this.headerControl3.Controls.Add(this.button3);
            this.headerControl3.Controls.Add(this.button4);
            this.headerControl3.Controls.Add(this.button2);
            this.headerControl3.Controls.Add(this.button1);
            this.headerControl3.Controls.Add(this.pictureBox6);
            this.headerControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.headerControl3.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl3.Location = new System.Drawing.Point(144, 24);
            this.headerControl3.Name = "headerControl3";
            this.headerControl3.Size = new System.Drawing.Size(752, 597);
            this.headerControl3.TabIndex = 2;
            // 
            // headerControl6
            // 
            this.headerControl6.Controls.Add(this.button31);
            this.headerControl6.Controls.Add(this.button30);
            this.headerControl6.Controls.Add(this.button29);
            this.headerControl6.Controls.Add(this.button27);
            this.headerControl6.Controls.Add(this.textBox14);
            this.headerControl6.Controls.Add(this.label27);
            this.headerControl6.Controls.Add(this.textBox9);
            this.headerControl6.Controls.Add(this.label22);
            this.headerControl6.Controls.Add(this.textBox8);
            this.headerControl6.Controls.Add(this.label21);
            this.headerControl6.Controls.Add(this.textBox10);
            this.headerControl6.Controls.Add(this.label23);
            this.headerControl6.Controls.Add(this.textBox11);
            this.headerControl6.Controls.Add(this.label24);
            this.headerControl6.Controls.Add(this.label25);
            this.headerControl6.Controls.Add(this.textBox12);
            this.headerControl6.Controls.Add(this.label26);
            this.headerControl6.Controls.Add(this.textBox13);
            this.headerControl6.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl6.Location = new System.Drawing.Point(340, 343);
            this.headerControl6.Name = "headerControl6";
            this.headerControl6.Size = new System.Drawing.Size(344, 224);
            this.headerControl6.TabIndex = 16;
            this.headerControl6.Text = "Current Position";
            // 
            // button31
            // 
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button31.Location = new System.Drawing.Point(176, 174);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(152, 24);
            this.button31.TabIndex = 31;
            this.button31.Text = "Swich onOutSide Camera";
            // 
            // button30
            // 
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button30.Location = new System.Drawing.Point(176, 142);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(152, 24);
            this.button30.TabIndex = 30;
            this.button30.Text = "Swich on OnBoard Camera";
            // 
            // button29
            // 
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button29.Location = new System.Drawing.Point(176, 110);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(152, 24);
            this.button29.TabIndex = 29;
            this.button29.Text = "Copy Position";
            // 
            // button27
            // 
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button27.Location = new System.Drawing.Point(176, 78);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(152, 24);
            this.button27.TabIndex = 28;
            this.button27.Text = "Reset to Reference";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(244, 37);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(56, 20);
            this.textBox14.TabIndex = 27;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(188, 40);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 24);
            this.label27.TabIndex = 26;
            this.label27.Text = "Grapper:    ";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(60, 188);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(64, 20);
            this.textBox9.TabIndex = 25;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(8, 190);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 24);
            this.label22.TabIndex = 24;
            this.label22.Text = "C Axis:    ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(60, 39);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(64, 20);
            this.textBox8.TabIndex = 23;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(8, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 24);
            this.label21.TabIndex = 22;
            this.label21.Text = "X Axis:    ";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(60, 70);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(64, 20);
            this.textBox10.TabIndex = 25;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(8, 70);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 24);
            this.label23.TabIndex = 24;
            this.label23.Text = "Y Axis:    ";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(60, 101);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(64, 20);
            this.textBox11.TabIndex = 25;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(8, 100);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 24);
            this.label24.TabIndex = 24;
            this.label24.Text = "Z Axis:    ";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(8, 130);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 24);
            this.label25.TabIndex = 24;
            this.label25.Text = "A Axis:    ";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(60, 133);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(64, 20);
            this.textBox12.TabIndex = 25;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(8, 160);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 24);
            this.label26.TabIndex = 24;
            this.label26.Text = "B Axis:    ";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(60, 161);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(64, 20);
            this.textBox13.TabIndex = 25;
            // 
            // headerControl4
            // 
            this.headerControl4.Controls.Add(this.numericUpDown6);
            this.headerControl4.Controls.Add(this.numericUpDown7);
            this.headerControl4.Controls.Add(this.numericUpDown4);
            this.headerControl4.Controls.Add(this.numericUpDown5);
            this.headerControl4.Controls.Add(this.numericUpDown3);
            this.headerControl4.Controls.Add(this.numericUpDown2);
            this.headerControl4.Controls.Add(this.numericUpDown1);
            this.headerControl4.Controls.Add(this.label20);
            this.headerControl4.Controls.Add(this.button21);
            this.headerControl4.Controls.Add(this.button22);
            this.headerControl4.Controls.Add(this.label17);
            this.headerControl4.Controls.Add(this.button23);
            this.headerControl4.Controls.Add(this.button24);
            this.headerControl4.Controls.Add(this.label18);
            this.headerControl4.Controls.Add(this.button25);
            this.headerControl4.Controls.Add(this.button26);
            this.headerControl4.Controls.Add(this.label19);
            this.headerControl4.Controls.Add(this.button19);
            this.headerControl4.Controls.Add(this.button20);
            this.headerControl4.Controls.Add(this.label16);
            this.headerControl4.Controls.Add(this.button17);
            this.headerControl4.Controls.Add(this.button18);
            this.headerControl4.Controls.Add(this.label15);
            this.headerControl4.Controls.Add(this.button16);
            this.headerControl4.Controls.Add(this.button15);
            this.headerControl4.Controls.Add(this.label14);
            this.headerControl4.Controls.Add(this.button28);
            this.headerControl4.Controls.Add(this.button32);
            this.headerControl4.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl4.Location = new System.Drawing.Point(340, 48);
            this.headerControl4.Name = "headerControl4";
            this.headerControl4.Size = new System.Drawing.Size(344, 280);
            this.headerControl4.TabIndex = 15;
            this.headerControl4.Text = "Control Panel";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown6.Location = new System.Drawing.Point(88, 40);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown6.TabIndex = 42;
            this.numericUpDown6.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown7.Location = new System.Drawing.Point(88, 71);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown7.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown7.TabIndex = 41;
            this.numericUpDown7.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown4.Location = new System.Drawing.Point(88, 110);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown4.TabIndex = 40;
            this.numericUpDown4.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown5.Location = new System.Drawing.Point(88, 141);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown5.TabIndex = 39;
            this.numericUpDown5.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(88, 176);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown3.TabIndex = 38;
            this.numericUpDown3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(88, 211);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown2.TabIndex = 37;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(88, 244);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(12, 246);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(172, 24);
            this.label20.TabIndex = 24;
            this.label20.Text = "Grapper:  Step                          /8";
            // 
            // button21
            // 
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button21.Location = new System.Drawing.Point(260, 209);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(64, 24);
            this.button21.TabIndex = 23;
            this.button21.Text = "Move -";
            // 
            // button22
            // 
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button22.Location = new System.Drawing.Point(188, 209);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(64, 24);
            this.button22.TabIndex = 22;
            this.button22.Text = "Move +";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(12, 213);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(320, 24);
            this.label17.TabIndex = 20;
            this.label17.Text = "C Axis:    Step                          mm";
            // 
            // button23
            // 
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button23.Location = new System.Drawing.Point(261, 169);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(64, 24);
            this.button23.TabIndex = 19;
            this.button23.Text = "Move -";
            // 
            // button24
            // 
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button24.Location = new System.Drawing.Point(189, 169);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(64, 24);
            this.button24.TabIndex = 18;
            this.button24.Text = "Move +";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(8, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(320, 24);
            this.label18.TabIndex = 16;
            this.label18.Text = "B Axis:    Step                          mm";
            // 
            // button25
            // 
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button25.Location = new System.Drawing.Point(261, 137);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(64, 24);
            this.button25.TabIndex = 15;
            this.button25.Text = "Move -";
            // 
            // button26
            // 
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button26.Location = new System.Drawing.Point(189, 137);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(64, 24);
            this.button26.TabIndex = 14;
            this.button26.Text = "Move +";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(13, 145);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(320, 24);
            this.label19.TabIndex = 12;
            this.label19.Text = "A Axis:    Step                          mm";
            // 
            // button19
            // 
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button19.Location = new System.Drawing.Point(259, 104);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(64, 24);
            this.button19.TabIndex = 11;
            this.button19.Text = "Move -";
            // 
            // button20
            // 
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button20.Location = new System.Drawing.Point(187, 104);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(64, 24);
            this.button20.TabIndex = 10;
            this.button20.Text = "Move +";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(11, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(320, 24);
            this.label16.TabIndex = 8;
            this.label16.Text = "Z Axis:    Step                          mm";
            // 
            // button17
            // 
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button17.Location = new System.Drawing.Point(260, 70);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(64, 24);
            this.button17.TabIndex = 7;
            this.button17.Text = "Move -";
            // 
            // button18
            // 
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button18.Location = new System.Drawing.Point(188, 70);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(64, 24);
            this.button18.TabIndex = 6;
            this.button18.Text = "Move +";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(12, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(320, 24);
            this.label15.TabIndex = 4;
            this.label15.Text = "Y Axis:    Step                          mm";
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button16.Location = new System.Drawing.Point(260, 36);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(64, 24);
            this.button16.TabIndex = 3;
            this.button16.Text = "Move -";
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button15.Location = new System.Drawing.Point(188, 36);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(64, 24);
            this.button15.TabIndex = 2;
            this.button15.Text = "Move +";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(12, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(320, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "X Axis:    Step                          mm";
            // 
            // button28
            // 
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button28.Location = new System.Drawing.Point(189, 242);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(64, 24);
            this.button28.TabIndex = 22;
            this.button28.Text = "+";
            // 
            // button32
            // 
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button32.Location = new System.Drawing.Point(261, 242);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(64, 24);
            this.button32.TabIndex = 23;
            this.button32.Text = " -";
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.Location = new System.Drawing.Point(145, 326);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(24, 24);
            this.button14.TabIndex = 14;
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(213, 330);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(24, 24);
            this.button13.TabIndex = 13;
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(213, 285);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(24, 29);
            this.button12.TabIndex = 12;
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(148, 285);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(24, 29);
            this.button11.TabIndex = 11;
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(177, 347);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(22, 24);
            this.button10.TabIndex = 10;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(178, 264);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(24, 29);
            this.button9.TabIndex = 9;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(101, 323);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 48);
            this.button8.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(141, 178);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 48);
            this.button7.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(102, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 48);
            this.button6.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(141, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 46);
            this.button5.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(176, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 40);
            this.button3.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(96, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 40);
            this.button4.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(179, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 42);
            this.button2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(95, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 40);
            this.button1.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(47, 61);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(240, 520);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // headerControl8
            // 
            this.headerControl8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headerControl8.BuddyPane = this.navigationPane10;
            this.headerControl8.Controls.Add(this.headerControl10);
            this.headerControl8.Controls.Add(this.headerControl9);
            this.headerControl8.Controls.Add(this.headerControl11);
            this.headerControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.headerControl8.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl8.Location = new System.Drawing.Point(144, 24);
            this.headerControl8.Name = "headerControl8";
            this.headerControl8.Size = new System.Drawing.Size(752, 597);
            this.headerControl8.TabIndex = 3;
            // 
            // headerControl10
            // 
            this.headerControl10.Controls.Add(this.panel3);
            this.headerControl10.Controls.Add(this.tabControl1);
            this.headerControl10.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl10.Location = new System.Drawing.Point(438, 42);
            this.headerControl10.Name = "headerControl10";
            this.headerControl10.Size = new System.Drawing.Size(306, 347);
            this.headerControl10.TabIndex = 1;
            this.headerControl10.Text = "Commands";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button48);
            this.panel3.Controls.Add(this.button47);
            this.panel3.Controls.Add(this.button39);
            this.panel3.Controls.Add(this.properties_control1);
            this.panel3.Location = new System.Drawing.Point(2, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 314);
            this.panel3.TabIndex = 5;
            this.panel3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button48
            // 
            this.button48.Location = new System.Drawing.Point(13, 285);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(123, 25);
            this.button48.TabIndex = 3;
            this.button48.Text = "Get From Tech Mode";
            this.button48.UseVisualStyleBackColor = true;
            // 
            // button47
            // 
            this.button47.Location = new System.Drawing.Point(225, 286);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(64, 25);
            this.button47.TabIndex = 2;
            this.button47.Text = "Cancel";
            this.button47.UseVisualStyleBackColor = true;
            this.button47.Click += new System.EventHandler(this.button47_Click);
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(149, 286);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(64, 25);
            this.button39.TabIndex = 1;
            this.button39.Text = "Submit";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // properties_control1
            // 
            this.properties_control1.Location = new System.Drawing.Point(12, 1);
            this.properties_control1.Name = "properties_control1";
            this.properties_control1.Size = new System.Drawing.Size(279, 279);
            this.properties_control1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(3, 30);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 313);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(292, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Move";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button44);
            this.panel1.Controls.Add(this.button45);
            this.panel1.Controls.Add(this.button46);
            this.panel1.Controls.Add(this.button42);
            this.panel1.Controls.Add(this.button43);
            this.panel1.Controls.Add(this.button41);
            this.panel1.Controls.Add(this.button40);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 263);
            this.panel1.TabIndex = 18;
            // 
            // button44
            // 
            this.button44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button44.Image = ((System.Drawing.Image)(resources.GetObject("button44.Image")));
            this.button44.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button44.Location = new System.Drawing.Point(0, 261);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(264, 43);
            this.button44.TabIndex = 13;
            this.button44.Text = "LIN Axis XY\r\nShortcut: linxy";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // button45
            // 
            this.button45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button45.Image = ((System.Drawing.Image)(resources.GetObject("button45.Image")));
            this.button45.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button45.Location = new System.Drawing.Point(0, 218);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(264, 43);
            this.button45.TabIndex = 12;
            this.button45.Text = "Orthogonal Point To Point \r\nShortcut: optp";
            this.button45.UseVisualStyleBackColor = true;
            this.button45.Click += new System.EventHandler(this.button45_Click);
            // 
            // button46
            // 
            this.button46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button46.Image = ((System.Drawing.Image)(resources.GetObject("button46.Image")));
            this.button46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button46.Location = new System.Drawing.Point(0, 175);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(264, 43);
            this.button46.TabIndex = 11;
            this.button46.Text = "Circular (Arc)\r\nShortcut: acircular\r\n";
            this.button46.UseVisualStyleBackColor = true;
            this.button46.Click += new System.EventHandler(this.button46_Click);
            // 
            // button42
            // 
            this.button42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button42.Image = ((System.Drawing.Image)(resources.GetObject("button42.Image")));
            this.button42.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button42.Location = new System.Drawing.Point(0, 132);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(264, 43);
            this.button42.TabIndex = 10;
            this.button42.Text = "Circular (Center)\r\nShortcut: ccircular";
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button43
            // 
            this.button43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button43.Image = ((System.Drawing.Image)(resources.GetObject("button43.Image")));
            this.button43.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button43.Location = new System.Drawing.Point(0, 89);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(264, 43);
            this.button43.TabIndex = 9;
            this.button43.Text = "Linear Move \r\nShortcut: lmove";
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.button43_Click);
            // 
            // button41
            // 
            this.button41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button41.Image = ((System.Drawing.Image)(resources.GetObject("button41.Image")));
            this.button41.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button41.Location = new System.Drawing.Point(0, 46);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(264, 43);
            this.button41.TabIndex = 8;
            this.button41.Text = "Point To Point \r\nShortcut: ptp";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button40
            // 
            this.button40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button40.Image = ((System.Drawing.Image)(resources.GetObject("button40.Image")));
            this.button40.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button40.Location = new System.Drawing.Point(0, 3);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(264, 43);
            this.button40.TabIndex = 7;
            this.button40.Text = "Reference\r\nShortcut: reference";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(292, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Robot Parameters";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(292, 269);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Arithmetic Commands";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(292, 269);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Program Parameters";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 40);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(292, 269);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Programm Flow";
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 40);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(292, 269);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Favorites";
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 40);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(292, 269);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Custom";
            // 
            // headerControl9
            // 
            this.headerControl9.Controls.Add(this.panel2);
            this.headerControl9.Controls.Add(this.button37);
            this.headerControl9.Controls.Add(this.button36);
            this.headerControl9.Controls.Add(this.button35);
            this.headerControl9.Controls.Add(this.button34);
            this.headerControl9.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl9.Location = new System.Drawing.Point(8, 40);
            this.headerControl9.Name = "headerControl9";
            this.headerControl9.Size = new System.Drawing.Size(424, 536);
            this.headerControl9.TabIndex = 0;
            this.headerControl9.Text = "Editor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.numberLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 509);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.AllowDrop = true;
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(31, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(388, 503);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll_1);
            // 
            // numberLabel
            // 
            this.numberLabel.BackColor = System.Drawing.Color.Silver;
            this.numberLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.numberLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numberLabel.Location = new System.Drawing.Point(0, 0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(31, 509);
            this.numberLabel.TabIndex = 10;
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.White;
            this.button37.Image = ((System.Drawing.Image)(resources.GetObject("button37.Image")));
            this.button37.Location = new System.Drawing.Point(313, 1);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(25, 25);
            this.button37.TabIndex = 4;
            this.button37.UseVisualStyleBackColor = false;
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.White;
            this.button36.Image = ((System.Drawing.Image)(resources.GetObject("button36.Image")));
            this.button36.Location = new System.Drawing.Point(341, 1);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(25, 25);
            this.button36.TabIndex = 3;
            this.button36.UseVisualStyleBackColor = false;
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.White;
            this.button35.Image = ((System.Drawing.Image)(resources.GetObject("button35.Image")));
            this.button35.Location = new System.Drawing.Point(369, 1);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(25, 25);
            this.button35.TabIndex = 2;
            this.button35.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.White;
            this.button34.Image = ((System.Drawing.Image)(resources.GetObject("button34.Image")));
            this.button34.Location = new System.Drawing.Point(397, 1);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(25, 25);
            this.button34.TabIndex = 1;
            this.button34.UseVisualStyleBackColor = false;
            // 
            // headerControl11
            // 
            this.headerControl11.Controls.Add(this.richTextBox2);
            this.headerControl11.Controls.Add(this.button38);
            this.headerControl11.Controls.Add(this.pictureBox9);
            this.headerControl11.Controls.Add(this.label29);
            this.headerControl11.Controls.Add(this.button33);
            this.headerControl11.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl11.Location = new System.Drawing.Point(438, 395);
            this.headerControl11.Name = "headerControl11";
            this.headerControl11.Size = new System.Drawing.Size(306, 180);
            this.headerControl11.TabIndex = 2;
            this.headerControl11.Text = "Compliler";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox2.Location = new System.Drawing.Point(8, 32);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(288, 72);
            this.richTextBox2.TabIndex = 38;
            this.richTextBox2.Text = "Compiler ACSLRL@0.1: Status:<Ready>";
            // 
            // button38
            // 
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button38.Location = new System.Drawing.Point(19, 145);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(128, 24);
            this.button38.TabIndex = 36;
            this.button38.Text = "Step Execute";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(9, 110);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(16, 16);
            this.pictureBox9.TabIndex = 34;
            this.pictureBox9.TabStop = false;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(27, 110);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(272, 32);
            this.label29.TabIndex = 33;
            this.label29.Text = "Be sure that nobody is in the robot region and you have direct access to emergenc" +
                "y stop button";
            // 
            // button33
            // 
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button33.Location = new System.Drawing.Point(163, 145);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(128, 24);
            this.button33.TabIndex = 32;
            this.button33.Text = "Compile and Run";
            // 
            // teachModeToolStripMenuItem
            // 
            this.teachModeToolStripMenuItem.Name = "teachModeToolStripMenuItem";
            this.teachModeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.teachModeToolStripMenuItem.Text = "Teach Mode";
            // 
            // writeCodeToolStripMenuItem
            // 
            this.writeCodeToolStripMenuItem.Name = "writeCodeToolStripMenuItem";
            this.writeCodeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.writeCodeToolStripMenuItem.Text = "Write Code";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 6);
            // 
            // runDemosToolStripMenuItem
            // 
            this.runDemosToolStripMenuItem.Name = "runDemosToolStripMenuItem";
            this.runDemosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.runDemosToolStripMenuItem.Text = "Run Demos";
            // 
            // switchOnOnboarCameraToolStripMenuItem
            // 
            this.switchOnOnboarCameraToolStripMenuItem.Name = "switchOnOnboarCameraToolStripMenuItem";
            this.switchOnOnboarCameraToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.switchOnOnboarCameraToolStripMenuItem.Text = "Switch On Onboar Camera";
            // 
            // switchOnEnviromentCameraToolStripMenuItem
            // 
            this.switchOnEnviromentCameraToolStripMenuItem.Name = "switchOnEnviromentCameraToolStripMenuItem";
            this.switchOnEnviromentCameraToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.switchOnEnviromentCameraToolStripMenuItem.Text = "Switch On Enviroment Camera";
            // 
            // calibrateCameraToolStripMenuItem
            // 
            this.calibrateCameraToolStripMenuItem.Name = "calibrateCameraToolStripMenuItem";
            this.calibrateCameraToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.calibrateCameraToolStripMenuItem.Text = "Calibrate Camera";
            // 
            // managePortsToolStripMenuItem
            // 
            this.managePortsToolStripMenuItem.Name = "managePortsToolStripMenuItem";
            this.managePortsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.managePortsToolStripMenuItem.Text = "Manage Ports";
            // 
            // setRobotManuallyToolStripMenuItem
            // 
            this.setRobotManuallyToolStripMenuItem.Name = "setRobotManuallyToolStripMenuItem";
            this.setRobotManuallyToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.setRobotManuallyToolStripMenuItem.Text = "Set Robot Manually";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem1,
            this.optionsToolStripMenuItem1});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem1
            // 
            this.customizeToolStripMenuItem1.Name = "customizeToolStripMenuItem1";
            this.customizeToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.customizeToolStripMenuItem1.Text = "&Customize";
            this.customizeToolStripMenuItem1.Click += new System.EventHandler(this.customizeToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.optionsToolStripMenuItem1.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(126, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(896, 621);
            this.Controls.Add(this.navigationBar2);
            this.Controls.Add(this.headerControl8);
            this.Controls.Add(this.headerControl3);
            this.Controls.Add(this.headerControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoboSoft - Robot Control Software Ver 0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navigationBar2.ResumeLayout(false);
            this.navigationPane10.ResumeLayout(false);
            this.headerControl12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.navigationPane11.ResumeLayout(false);
            this.headerControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.navigationPane12.ResumeLayout(false);
            this.headerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.headerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.headerControl3.ResumeLayout(false);
            this.headerControl6.ResumeLayout(false);
            this.headerControl6.PerformLayout();
            this.headerControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.headerControl8.ResumeLayout(false);
            this.headerControl10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.headerControl9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.headerControl11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion




		struct WordAndPosition
		{
			public string Word;
			public int Position;
			public int Length;
			public override string ToString()
			{
				string s = "Word = " + Word + ", Position = " + Position + ", Length = " + Length + "\n";
				return s;
			}
		};

		WordAndPosition[] TheBuffer = new WordAndPosition[4000];


        private void updateNumberLabel()
{

    Point pos = new Point(0, 0);
    int firstIndex = richTextBox1.GetCharIndexFromPosition(pos);
    int firstLine = richTextBox1.GetLineFromCharIndex(firstIndex);

    pos.X = ClientRectangle.Width;
    pos.Y = ClientRectangle.Height;
    int lastIndex = richTextBox1.GetCharIndexFromPosition(pos);
    int lastLine = richTextBox1.GetLineFromCharIndex(lastIndex);

    pos = richTextBox1.GetPositionFromCharIndex(lastIndex);


    numberLabel.Text = "";
    for (int i = firstLine; i <= lastLine + 1; i++)
    {
        numberLabel.Text += i + 1 + "\n";
    }

}

        private void richTextBox1_VScroll_1(object sender, EventArgs e)
{

    int d = richTextBox1.GetPositionFromCharIndex(0).Y % 
                              (richTextBox1.Font.Height + 1);
    numberLabel.Location = new Point(0, d);

    updateNumberLabel();

}


		private void richTextBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{

			if (populating)
				return;

			ColorSyntaxEditor.FlickerFreeRichEditTextBox._Paint = false;			
			MakeColorSyntaxForCurrentLine();
			ColorSyntaxEditor.FlickerFreeRichEditTextBox._Paint = true;			


		 	if ( (e.KeyCode==Keys.Enter))
			{
			
 
			
				numberLabel.Font = new Font(richTextBox1.Font.FontFamily, 
				richTextBox1.Font.Size + 1.019f);
				updateNumberLabel();
			};



			}


		private void Form1_Load(object sender, System.EventArgs e)
		{
			

		updateNumberLabel();
		declaration();

       // panel3.Location =  new System.Drawing.Point(440, 70); 

            // Bazo se arrays ta stoixei tou properties window
        PropertiesTextboxes.Add(properties_control1.textBox1);
        PropertiesTextboxes.Add(properties_control1.textBox2);
        PropertiesTextboxes.Add(properties_control1.textBox3);
        PropertiesTextboxes.Add(properties_control1.textBox4);
        PropertiesTextboxes.Add(properties_control1.textBox5);
        PropertiesTextboxes.Add(properties_control1.textBox6);
        PropertiesTextboxes.Add(properties_control1.textBox7);
        PropertiesTextboxes.Add(properties_control1.textBox8);
        PropertiesTextboxes.Add(properties_control1.textBox9);
        PropertiesTextboxes.Add(properties_control1.textBox10);
        PropertiesTextboxes.Add(properties_control1.textBox11);
        PropertiesTextboxes.Add(properties_control1.textBox12);

        PropertiesLabels.Add(properties_control1.label1);
        PropertiesLabels.Add(properties_control1.label2);
        PropertiesLabels.Add(properties_control1.label3);
        PropertiesLabels.Add(properties_control1.label4);
        PropertiesLabels.Add(properties_control1.label5);
        PropertiesLabels.Add(properties_control1.label6);
        PropertiesLabels.Add(properties_control1.label7);
        PropertiesLabels.Add(properties_control1.label8);
        PropertiesLabels.Add(properties_control1.label9);
        PropertiesLabels.Add(properties_control1.label10);
        PropertiesLabels.Add(properties_control1.label11);
        PropertiesLabels.Add(properties_control1.label12);

        PropertiesButtons.Add(properties_control1.button1 );
        PropertiesButtons.Add(properties_control1.button2);
        PropertiesButtons.Add(properties_control1.button3);
        PropertiesButtons.Add(properties_control1.button4);
        PropertiesButtons.Add(properties_control1.button5);
        PropertiesButtons.Add(properties_control1.button6);
        PropertiesButtons.Add(properties_control1.button7);
        PropertiesButtons.Add(properties_control1.button8);
        PropertiesButtons.Add(properties_control1.button9);
        PropertiesButtons.Add(properties_control1.button10);
        PropertiesButtons.Add(properties_control1.button11);
        PropertiesButtons.Add(properties_control1.button12);

        // tolos array stoixeion tou properties window

}
		

		private bool TestComment(string s)
		{
			string testString = s.Trim();
			if ( (testString.Length >= 2) &&
				(testString[0] == '/')	  &&
				(testString[1] == '/')	  
				)
				return true;

			return false;
		}

		private int ParseLine(string s)
		{
			TheBuffer.Initialize();
			int count = 0;
			Regex r = new Regex(@"\w+|[^A-Za-z0-9_ \f\t\v]", RegexOptions.IgnoreCase|RegexOptions.Compiled);
			Match m;

			for (m = r.Match(s); m.Success ; m = m.NextMatch()) 
			{
				TheBuffer[count].Word = m.Value;
				TheBuffer[count].Position = m.Index;
				TheBuffer[count].Length = m.Length;
				//				Console.WriteLine("Next Word = " + m.Value);
				count++;
			}


			return count;
		}

		private Color Lookup(string s)
		{
			Color theColor = Color.Black;

			if (TheSyntaxReader.IsFunction(s))
			{
				theColor = Color.DarkRed   ;
			}

			if (TheSyntaxReader.IsKeyword(s))
			{
				theColor = Color.Blue;
			}

	
			return theColor;
		}

		private void MakeColorSyntaxForCurrentLine()
		{
			int CurrentSelectionStart = richTextBox1.SelectionStart;
			int CurrentSelectionLength = richTextBox1.SelectionLength;

			// find start of line
			int pos = CurrentSelectionStart;
			while ( (pos > 0) && (richTextBox1.Text[pos-1] != '\n'))
				pos--;

			int pos2 = CurrentSelectionStart;
			while ( (pos2 < richTextBox1.Text.Length) && 
				(richTextBox1.Text[pos2] != '\n') )
				pos2++;

			string s = richTextBox1.Text.Substring(pos, pos2 - pos);
			if (TestComment(s) == true)
			{
				richTextBox1.Select(pos, pos2-pos);
				richTextBox1.SelectionColor = kCommentColor;
			}
			else
			{
				string previousWord = "";
				int count = ParseLine(s);
				for  (int i = 0; i < count; i++)
				{
					WordAndPosition wp = TheBuffer[i];

					// check for comment
					if (wp.Word == "/" && previousWord == "/")
					{
						// color until end of line
						int posCommentStart = wp.Position - 1;
						int posCommentEnd = pos2;
						while (wp.Word != "\n" && i < count)
						{
							wp = TheBuffer[i];
							i++;
						}

						i--;

						posCommentEnd = pos2;
						richTextBox1.Select(posCommentStart + pos, posCommentEnd - (posCommentStart + pos));
						richTextBox1.SelectionColor = this.kCommentColor;

					}
					else
					{

						Color c = Lookup(wp.Word);
						richTextBox1.Select(wp.Position + pos, wp.Length);
						richTextBox1.SelectionColor = c;
					}

					previousWord = wp.Word;

				}
			}

			if (CurrentSelectionStart >=0)
				richTextBox1.Select(CurrentSelectionStart, CurrentSelectionLength);
			

		}

		private void MakeColorSyntaxForAllText(string s)
		{
			populating = true;

			int CurrentSelectionStart = richTextBox1.SelectionStart;
			int CurrentSelectionLength = richTextBox1.SelectionLength;

			int count = ParseLine(s);
			string previousWord = "";
			for (int i = 0; i < count; i++)
			{
				WordAndPosition wp = TheBuffer[i];

				// check for comment
				if (wp.Word == "/" && previousWord == "/")
				{
					// color until end of line
					int posCommentStart = wp.Position - 1;
					int posCommentEnd = i;
					while (wp.Word != "\n" && i < count)
					{
						wp = TheBuffer[i];
						i++;
					}

					i--;

					posCommentEnd = wp.Position;
					richTextBox1.Select(posCommentStart, posCommentEnd - posCommentStart);
					richTextBox1.SelectionColor = this.kCommentColor;

				}
				else
				{
				
					Color c = Lookup(wp.Word);
					richTextBox1.Select(wp.Position, wp.Length);
					richTextBox1.SelectionColor = c;
				}

				previousWord = wp.Word;

				//				Console.WriteLine(wp.ToString());
			}

			if (CurrentSelectionStart >=0)
				richTextBox1.Select(CurrentSelectionStart, CurrentSelectionLength);

			populating = false;

		}

		private void declaration()
		{
			richTextBox1.Text="// Democritus University of Thrace \n";
			MakeColorSyntaxForCurrentLine();
	
			richTextBox1.Text=richTextBox1.Text+	"// Automatic Control System Laboratory \n";
			MakeColorSyntaxForCurrentLine();
		
			richTextBox1.Text=richTextBox1.Text+ "// Robotics Script Language is loaded \n";
			MakeColorSyntaxForCurrentLine();
	
			richTextBox1.Text=richTextBox1.Text+"// Write your source here \n\n";
			MakeColorSyntaxForCurrentLine();



	
			numberLabel.Font = new Font(richTextBox1.Font.FontFamily, 
				richTextBox1.Font.Size + 1.019f);
			updateNumberLabel();





		}



	
		
		private void About()
		{
			AboutForm	about = new AboutForm();
			about.ShowDialog();
		}


        
        private void CustomizePropertiesMenu(string Command,string CShortcat, ArrayList labeltext)
        {
            TextBox temptextbox;
            Label templabel;
            Button tempbutton;



            for (int i = 0; i < labeltext.Count ; i++)
            {
                System.Collections.IEnumerator myEnumeratorT = PropertiesTextboxes.GetEnumerator(i, 1);
                myEnumeratorT.MoveNext();
                temptextbox = (TextBox)myEnumeratorT.Current;
                temptextbox.Text = "";
                temptextbox.Visible = true;

                System.Collections.IEnumerator myEnumeratorB = PropertiesButtons.GetEnumerator(i, 1);
                myEnumeratorB.MoveNext();
                tempbutton = (Button)myEnumeratorB.Current;
                tempbutton.Visible = true;


                System.Collections.IEnumerator myEnumeratorL = PropertiesLabels.GetEnumerator(i, 1);
                myEnumeratorL.MoveNext();
                templabel = (Label)myEnumeratorL.Current;
                templabel.Visible = true;

                System.Collections.IEnumerator myEnumeratorLT = labeltext.GetEnumerator(i, 1);
                myEnumeratorLT.MoveNext();
                templabel.Text = myEnumeratorLT.Current.ToString();

            }


            for (int i = labeltext.Count; i < 12; i++)
            {
                System.Collections.IEnumerator myEnumeratorT = PropertiesTextboxes.GetEnumerator(i, 1);
                myEnumeratorT.MoveNext();
                temptextbox = (TextBox)myEnumeratorT.Current;
                temptextbox.Visible=false;
              
                System.Collections.IEnumerator myEnumeratorL = PropertiesLabels.GetEnumerator(i, 1);
                myEnumeratorL.MoveNext();
                templabel = (Label)myEnumeratorL.Current;
                templabel.Visible = false;

                System.Collections.IEnumerator myEnumeratorB = PropertiesButtons.GetEnumerator(i, 1);
                myEnumeratorB.MoveNext();
                tempbutton = (Button )myEnumeratorB.Current;
                tempbutton.Visible = false;

            }
            

            panel3.Visible = true;
            properties_control1.label13.Text = Command;
            label1.Text = CShortcat.ToString();    
        }

        private void button41_Click(object sender, EventArgs e)
        {
            PropertiesCommands.Clear();
            PropertiesShortcuts.Clear();

            PropertiesCommands.Add("Move To Point (X)=");
            PropertiesCommands.Add("Move To Point (Y)=");
            PropertiesCommands.Add("Move To Point (Z)=");
            PropertiesCommands.Add("Target Angle (A)=");
            PropertiesCommands.Add("Target Angle (B)=");
            PropertiesCommands.Add("Target Angle (C)=");


            PropertiesShortcuts.Add("x=");
            PropertiesShortcuts.Add("y=");
            PropertiesShortcuts.Add("z=");
            PropertiesShortcuts.Add("a=");
            PropertiesShortcuts.Add("b=");
            PropertiesShortcuts.Add("c=");

            CustomizePropertiesMenu("Point To Point", "ptp", PropertiesCommands);
     
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {
            panel3.Visible  = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            TextBox temptextbox;

             richTextBox1.SelectedText = "\n" + "function " + label1.Text.ToString() + " begin ";
             MakeColorSyntaxForCurrentLine();

             richTextBox1.SelectedText = "\n";


            for (int i = 0; i < PropertiesShortcuts.Count; i++)
            {
                System.Collections.IEnumerator myEnumeratorS = PropertiesShortcuts.GetEnumerator(i, 1);
                myEnumeratorS.MoveNext();
                System.Collections.IEnumerator myEnumeratorT = PropertiesTextboxes.GetEnumerator(i, 1);
                myEnumeratorT.MoveNext();
                temptextbox = (TextBox)myEnumeratorT.Current;
                if ((i == 3) || (i == 6) || (i == 9))
                {
                   MakeColorSyntaxForCurrentLine();
                   richTextBox1.SelectedText =  "\n";
                }
                
                richTextBox1.SelectedText =richTextBox1.SelectedText + " " + myEnumeratorS.Current.ToString() + " " + temptextbox.Text + ";";

            }
            
            MakeColorSyntaxForCurrentLine();
            richTextBox1.SelectedText = "\n" + label1.Text.ToString() + " end";
            MakeColorSyntaxForCurrentLine();
            richTextBox1.SelectedText = "\n\n";
            updateNumberLabel();
            panel3.Visible = false;
        }

        private void customizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void button43_Click(object sender, EventArgs e)
        {
            PropertiesCommands.Clear();
            PropertiesShortcuts.Clear();

            PropertiesCommands.Add("Move To Point (X)=");
            PropertiesCommands.Add("Move To Point (Y)=");
            PropertiesCommands.Add("Move To Point (Z)=");
            PropertiesCommands.Add("Target Angle (A)=");
            PropertiesCommands.Add("Target Angle (B)=");
            PropertiesCommands.Add("Target Angle (C)=");


            PropertiesShortcuts.Add("x=");
            PropertiesShortcuts.Add("y=");
            PropertiesShortcuts.Add("z=");
            PropertiesShortcuts.Add("a=");
            PropertiesShortcuts.Add("b=");
            PropertiesShortcuts.Add("c=");

            CustomizePropertiesMenu("Linear Move", "lmove", PropertiesCommands);
        }

        private void button42_Click(object sender, EventArgs e)
        {
              PropertiesCommands.Clear();
            PropertiesShortcuts.Clear();

            PropertiesCommands.Add("Move To Point (X)=");
            PropertiesCommands.Add("Move To Point (Y)=");
            PropertiesCommands.Add("Move To Point (Z)=");
            PropertiesCommands.Add("Target Angle (A)=");
            PropertiesCommands.Add("Target Angle (B)=");
            PropertiesCommands.Add("Target Angle (C)=");
            PropertiesCommands.Add("Centre Point (X)=");
            PropertiesCommands.Add("Centre Point (Y)=");
            PropertiesCommands.Add("Centre Point (Z)=");
            PropertiesCommands.Add("Centre Angle (A)=");
            PropertiesCommands.Add("Centre Angle (B)=");
            PropertiesCommands.Add("Centre Angle (C)=");


            PropertiesShortcuts.Add("x=");
            PropertiesShortcuts.Add("y=");
            PropertiesShortcuts.Add("z=");
            PropertiesShortcuts.Add("a=");
            PropertiesShortcuts.Add("b=");
            PropertiesShortcuts.Add("c=");
            PropertiesShortcuts.Add("xc=");
            PropertiesShortcuts.Add("yc=");
            PropertiesShortcuts.Add("zc=");
            PropertiesShortcuts.Add("ac=");
            PropertiesShortcuts.Add("bc=");
            PropertiesShortcuts.Add("cc=");

            CustomizePropertiesMenu("Circular (Center)", "ccircular", PropertiesCommands);
    
        }

        private void button46_Click(object sender, EventArgs e)
        {
            PropertiesCommands.Clear();
            PropertiesShortcuts.Clear();

            PropertiesCommands.Add("Move To Point (X)=");
            PropertiesCommands.Add("Move To Point (Y)=");
            PropertiesCommands.Add("Move To Point (Z)=");
            PropertiesCommands.Add("Target Angle (A)=");
            PropertiesCommands.Add("Target Angle (B)=");
            PropertiesCommands.Add("Target Angle (C)=");
            PropertiesCommands.Add("Arc Point (X)=");
            PropertiesCommands.Add("Arc Point (Y)=");
            PropertiesCommands.Add("Arc Point (Z)=");
            PropertiesCommands.Add("Arc Angle (A)=");
            PropertiesCommands.Add("Arc Angle (B)=");
            PropertiesCommands.Add("Arc Angle (C)=");


            PropertiesShortcuts.Add("x=");
            PropertiesShortcuts.Add("y=");
            PropertiesShortcuts.Add("z=");
            PropertiesShortcuts.Add("a=");
            PropertiesShortcuts.Add("b=");
            PropertiesShortcuts.Add("c=");
            PropertiesShortcuts.Add("xa=");
            PropertiesShortcuts.Add("ya=");
            PropertiesShortcuts.Add("za=");
            PropertiesShortcuts.Add("aa=");
            PropertiesShortcuts.Add("ba=");
            PropertiesShortcuts.Add("ca=");

            CustomizePropertiesMenu("Circular (Arc)", "acircular", PropertiesCommands);
    
        }

        private void button45_Click(object sender, EventArgs e)
        {
            PropertiesCommands.Clear();
            PropertiesShortcuts.Clear();

            PropertiesCommands.Add("Move To Point (X)=");
            PropertiesCommands.Add("Move To Point (Y)=");
            PropertiesCommands.Add("Move To Point (Z1)=");
            PropertiesCommands.Add("Target Angle (A)=");
            PropertiesCommands.Add("Target Angle (B)=");
            PropertiesCommands.Add("Target Angle (C)=");
            PropertiesCommands.Add("Move To Point (Z2)=");

            PropertiesShortcuts.Add("x=");
            PropertiesShortcuts.Add("y=");
            PropertiesShortcuts.Add("z1=");
            PropertiesShortcuts.Add("a=");
            PropertiesShortcuts.Add("b=");
            PropertiesShortcuts.Add("c=");
            PropertiesShortcuts.Add("z2=");
            
            CustomizePropertiesMenu("Orthogonal Point To Point", "optp", PropertiesCommands);
      
        }

        private void button44_Click(object sender, EventArgs e)
        {
            PropertiesCommands.Clear();
            PropertiesShortcuts.Clear();

            PropertiesCommands.Add("Move To Point (X)=");
            PropertiesCommands.Add("Move To Point (Y)=");
            PropertiesCommands.Add("Move To Point (Z)=");
            PropertiesCommands.Add("Target Angle (A)=");
            PropertiesCommands.Add("Target Angle (B)=");
            PropertiesCommands.Add("Target Angle (C)=");


            PropertiesShortcuts.Add("x=");
            PropertiesShortcuts.Add("y=");
            PropertiesShortcuts.Add("z=");
            PropertiesShortcuts.Add("a=");
            PropertiesShortcuts.Add("b=");
            PropertiesShortcuts.Add("c=");

            CustomizePropertiesMenu("LinAxis XY", "linxy", PropertiesCommands);
      
        }

        private void button40_Click(object sender, EventArgs e)
        {
            PropertiesCommands.Clear();
            PropertiesShortcuts.Clear();


            PropertiesCommands.Add("Reference State=");
            PropertiesShortcuts.Add("ref");


            CustomizePropertiesMenu("Reference", "reference", PropertiesCommands);
      
        }

        private void navigationPane10_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }





	

		
		}

		

	
}
