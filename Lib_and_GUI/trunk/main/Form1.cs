using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using solvenmove;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Collections.Generic;
using WiimoteLib;


//*****************************************************************************************
//                           LICENSE INFORMATION
//*****************************************************************************************
//   5-DOF Robotic Arm Interface Version 1.1
//   Windows application to use a 5-Degrees-Of-Freedom robotic arm
//   
//   Copyright (C) 2010 
//   Apostolos KOUTSOKALIS, Konstantinos MANOLIS, Athanasios VELLIOS, 
//   Yiannis S. BOUTALIS, Savvas A. CHATZICHRISTOFIS

//   Emails: aposkout@ee.duth.gr, konsmano1@ee.duth.gr, athavell@ee.duth.gr,
//   ybout@ee.duth.gr, schatzic@ee.duth.gr
//
//   Special thanks to Themistoklis KYRGOS and Chris MAVRAKIS for their precious help
//   
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>.


namespace ColorSyntaxEditor
{

    public class Form1 : System.Windows.Forms.Form
    {
        //Declare object of highlvl type
        public volatile highlvl ir52c;
        private delegate void UpdateWiimoteStateDelegate(WiimoteChangedEventArgs args);

        #region Automatic definitions
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
        private System.Windows.Forms.Button nup;
        private System.Windows.Forms.Button ndown;
        private System.Windows.Forms.Button aup;
        private System.Windows.Forms.Button sup;
        private System.Windows.Forms.Button adown;
        private System.Windows.Forms.Button sdown;
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
        private TD.Eyefinder.HeaderControl headerControl12;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label numberLabel;
        private System.ComponentModel.IContainer components = null;
        private bool populating = true;
        private SyntaxReader TheSyntaxReader;
        private ColorSyntaxEditor.FlickerFreeRichEditTextBox richTextBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabPage tabPage3;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private NumericUpDown xstep;
        private NumericUpDown ystep;
        private NumericUpDown zstep;
        private NumericUpDown nstep;
        private NumericUpDown sstep;
        private NumericUpDown astep;
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
        private MenuStrip menuStrip2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label30;
        private Label label13;
        private Label label11;
        private Label label31;
        private Label label32;
        private Label label34;
        public volatile RichTextBox DebugDsp;
        private TextBox textBox1;
        private TD.Eyefinder.HeaderControl headerControl11;
        private Button button9;
        private Button button38;
        private PictureBox pictureBox9;
        private Label label29;
        private Button button33;
        private Button button10;
        private Button button11;
        private SaveFileDialog saveFD;
        private OpenFileDialog openFileDialog1;
        private Button button12;
        private Button button13;
        private Button button14;
        private TextBox richTextBox3;
        private Button button31;
        private Button button49;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown5;
        private Label label37;
        private Label label36;
        private Label label35;
        private NumericUpDown numericUpDown6;
        private Label label21;
        private Label label38;
        private Label label40;
        private Label label39;
        private Label label46;
        private Label label43;
        private Label label45;
        private Label label44;
        private Label label42;
        private Label label41;
        private TD.Eyefinder.HeaderControl headerControl5;
        private CheckBox checkBox1;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Label label53;
        private Label label52;
        private Label label51;
        private Label label50;
        private Label label49;
        private Label label48;
        private Label label47;
        private Timer timer1;
        private Timer timer2;
        private Timer timer3;
        private Timer timer4;
        private Timer timer5;
        private Color kCommentColor = Color.Green;
        #endregion

        public Form1()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
            this.MakeColorSyntaxForAllText(richTextBox1.Text);
            TheSyntaxReader = new SyntaxReader("php.syntax");
        }

        // General Variables
        Wiimote wm;
        int n = 0;
        Boolean GripStatus = true;
        double[] difMidPX = new double[100000];
        double[] difMidPY = new double[100000];
        ArrayList PropertiesTextboxes = new ArrayList();
        ArrayList PropertiesLabels = new ArrayList();
        ArrayList PropertiesButtons = new ArrayList();
        ArrayList PropertiesCommands = new ArrayList();
        ArrayList PropertiesShortcuts = new ArrayList();
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
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
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button49 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.DebugDsp = new System.Windows.Forms.RichTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.headerControl6 = new TD.Eyefinder.HeaderControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.xstep = new System.Windows.Forms.NumericUpDown();
            this.ystep = new System.Windows.Forms.NumericUpDown();
            this.zstep = new System.Windows.Forms.NumericUpDown();
            this.nstep = new System.Windows.Forms.NumericUpDown();
            this.sstep = new System.Windows.Forms.NumericUpDown();
            this.astep = new System.Windows.Forms.NumericUpDown();
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
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.sdown = new System.Windows.Forms.Button();
            this.adown = new System.Windows.Forms.Button();
            this.sup = new System.Windows.Forms.Button();
            this.aup = new System.Windows.Forms.Button();
            this.ndown = new System.Windows.Forms.Button();
            this.nup = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.headerControl8 = new TD.Eyefinder.HeaderControl();
            this.headerControl10 = new TD.Eyefinder.HeaderControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button48 = new System.Windows.Forms.Button();
            this.properties_control1 = new ColorSyntaxEditor.properties_control();
            this.button47 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
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
            this.richTextBox3 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label29 = new System.Windows.Forms.Label();
            this.button33 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
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
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.headerControl5 = new TD.Eyefinder.HeaderControl();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.headerControl6.SuspendLayout();
            this.headerControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xstep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ystep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zstep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nstep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sstep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.astep)).BeginInit();
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
            this.headerControl5.SuspendLayout();
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
            this.navigationBar2.SelectedPane = this.navigationPane6;
            this.navigationBar2.ShowPanes = 6;
            this.navigationBar2.Size = new System.Drawing.Size(144, 672);
            this.navigationBar2.TabIndex = 0;
            // 
            // navigationPane6
            // 
            this.navigationPane6.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane6.LargeImage = ((System.Drawing.Image)(resources.GetObject("navigationPane6.LargeImage")));
            this.navigationPane6.Location = new System.Drawing.Point(1, 26);
            this.navigationPane6.Name = "navigationPane6";
            this.navigationPane6.Size = new System.Drawing.Size(142, 477);
            this.navigationPane6.TabIndex = 0;
            this.navigationPane6.Text = "Wiimote mode";
            // 
            // navigationPane7
            // 
            this.navigationPane7.LargeImage = ((System.Drawing.Image)(resources.GetObject("navigationPane7.LargeImage")));
            this.navigationPane7.Location = new System.Drawing.Point(1, 26);
            this.navigationPane7.Name = "navigationPane7";
            this.navigationPane7.Size = new System.Drawing.Size(142, 477);
            this.navigationPane7.TabIndex = 1;
            this.navigationPane7.Text = "Machine Vision";
            // 
            // navigationPane8
            // 
            this.navigationPane8.LargeImage = ((System.Drawing.Image)(resources.GetObject("navigationPane8.LargeImage")));
            this.navigationPane8.Location = new System.Drawing.Point(1, 26);
            this.navigationPane8.Name = "navigationPane8";
            this.navigationPane8.Size = new System.Drawing.Size(142, 477);
            this.navigationPane8.TabIndex = 2;
            this.navigationPane8.Text = "Camera ";
            // 
            // navigationPane10
            // 
            this.navigationPane10.Controls.Add(this.headerControl12);
            this.navigationPane10.LargeImage = ((System.Drawing.Image)(resources.GetObject("navigationPane10.LargeImage")));
            this.navigationPane10.Location = new System.Drawing.Point(1, 26);
            this.navigationPane10.Name = "navigationPane10";
            this.navigationPane10.Size = new System.Drawing.Size(142, 477);
            this.navigationPane10.TabIndex = 4;
            this.navigationPane10.Text = "Batch mode";
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
            this.navigationPane11.Size = new System.Drawing.Size(142, 477);
            this.navigationPane11.TabIndex = 5;
            this.navigationPane11.Text = "Manual mode";
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
            this.navigationPane12.Size = new System.Drawing.Size(142, 477);
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
            this.headerControl3.Controls.Add(this.label40);
            this.headerControl3.Controls.Add(this.label39);
            this.headerControl3.Controls.Add(this.label46);
            this.headerControl3.Controls.Add(this.label43);
            this.headerControl3.Controls.Add(this.label45);
            this.headerControl3.Controls.Add(this.label44);
            this.headerControl3.Controls.Add(this.label42);
            this.headerControl3.Controls.Add(this.label41);
            this.headerControl3.Controls.Add(this.label38);
            this.headerControl3.Controls.Add(this.label37);
            this.headerControl3.Controls.Add(this.label36);
            this.headerControl3.Controls.Add(this.label35);
            this.headerControl3.Controls.Add(this.numericUpDown6);
            this.headerControl3.Controls.Add(this.numericUpDown5);
            this.headerControl3.Controls.Add(this.numericUpDown4);
            this.headerControl3.Controls.Add(this.numericUpDown3);
            this.headerControl3.Controls.Add(this.numericUpDown2);
            this.headerControl3.Controls.Add(this.numericUpDown1);
            this.headerControl3.Controls.Add(this.button49);
            this.headerControl3.Controls.Add(this.button31);
            this.headerControl3.Controls.Add(this.DebugDsp);
            this.headerControl3.Controls.Add(this.label30);
            this.headerControl3.Controls.Add(this.label13);
            this.headerControl3.Controls.Add(this.label11);
            this.headerControl3.Controls.Add(this.radioButton3);
            this.headerControl3.Controls.Add(this.radioButton2);
            this.headerControl3.Controls.Add(this.radioButton1);
            this.headerControl3.Controls.Add(this.headerControl6);
            this.headerControl3.Controls.Add(this.headerControl4);
            this.headerControl3.Controls.Add(this.sdown);
            this.headerControl3.Controls.Add(this.adown);
            this.headerControl3.Controls.Add(this.sup);
            this.headerControl3.Controls.Add(this.aup);
            this.headerControl3.Controls.Add(this.ndown);
            this.headerControl3.Controls.Add(this.nup);
            this.headerControl3.Controls.Add(this.button8);
            this.headerControl3.Controls.Add(this.button7);
            this.headerControl3.Controls.Add(this.button6);
            this.headerControl3.Controls.Add(this.button5);
            this.headerControl3.Controls.Add(this.button3);
            this.headerControl3.Controls.Add(this.button4);
            this.headerControl3.Controls.Add(this.button2);
            this.headerControl3.Controls.Add(this.button1);
            this.headerControl3.Controls.Add(this.pictureBox6);
            this.headerControl3.Controls.Add(this.menuStrip2);
            this.headerControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.headerControl3.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl3.Location = new System.Drawing.Point(144, 24);
            this.headerControl3.Name = "headerControl3";
            this.headerControl3.Size = new System.Drawing.Size(752, 672);
            this.headerControl3.TabIndex = 2;
            this.headerControl3.Click += new System.EventHandler(this.headerControl3_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(176, 641);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(31, 13);
            this.label40.TabIndex = 76;
            this.label40.Text = "Yaw:";
            this.label40.Click += new System.EventHandler(this.label38_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(176, 615);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(34, 13);
            this.label39.TabIndex = 76;
            this.label39.Text = "Pitch:";
            this.label39.Click += new System.EventHandler(this.label38_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(121, 641);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(21, 13);
            this.label46.TabIndex = 76;
            this.label46.Text = "cm";
            this.label46.Click += new System.EventHandler(this.label38_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(285, 641);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(45, 13);
            this.label43.TabIndex = 76;
            this.label43.Text = "degrees";
            this.label43.Click += new System.EventHandler(this.label38_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(121, 615);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(21, 13);
            this.label45.TabIndex = 76;
            this.label45.Text = "cm";
            this.label45.Click += new System.EventHandler(this.label38_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(121, 589);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(21, 13);
            this.label44.TabIndex = 76;
            this.label44.Text = "cm";
            this.label44.Click += new System.EventHandler(this.label38_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(285, 615);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(45, 13);
            this.label42.TabIndex = 76;
            this.label42.Text = "degrees";
            this.label42.Click += new System.EventHandler(this.label38_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(285, 589);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(45, 13);
            this.label41.TabIndex = 76;
            this.label41.Text = "degrees";
            this.label41.Click += new System.EventHandler(this.label38_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(176, 589);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(28, 13);
            this.label38.TabIndex = 76;
            this.label38.Text = "Roll:";
            this.label38.Click += new System.EventHandler(this.label38_Click);
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(6, 641);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(40, 24);
            this.label37.TabIndex = 69;
            this.label37.Text = "Z Axis:    ";
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(6, 615);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(40, 24);
            this.label36.TabIndex = 69;
            this.label36.Text = "Y Axis:    ";
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(6, 589);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(40, 24);
            this.label35.TabIndex = 69;
            this.label35.Text = "X Axis:    ";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown6.Location = new System.Drawing.Point(215, 639);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown6.TabIndex = 74;
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown5.Location = new System.Drawing.Point(215, 613);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown5.TabIndex = 73;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown4.Location = new System.Drawing.Point(215, 587);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown4.TabIndex = 72;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(59, 640);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown3.TabIndex = 71;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(59, 613);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown2.TabIndex = 70;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(59, 587);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 69;
            // 
            // button49
            // 
            this.button49.Location = new System.Drawing.Point(423, 592);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(82, 56);
            this.button49.TabIndex = 68;
            this.button49.Text = "Go to Catch-Letters position";
            this.button49.UseVisualStyleBackColor = true;
            this.button49.Click += new System.EventHandler(this.button49_Click_2);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(340, 597);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(61, 47);
            this.button31.TabIndex = 67;
            this.button31.Text = "Absolute move";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // DebugDsp
            // 
            this.DebugDsp.Location = new System.Drawing.Point(511, 570);
            this.DebugDsp.Name = "DebugDsp";
            this.DebugDsp.Size = new System.Drawing.Size(173, 98);
            this.DebugDsp.TabIndex = 66;
            this.DebugDsp.Text = "";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(271, 365);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(28, 13);
            this.label30.TabIndex = 23;
            this.label30.Text = "Yaw";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(267, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Pitch";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Roll";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(236, 533);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(84, 17);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.Text = "Euler Angles";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.EulerradioCheck);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(236, 517);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 17);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Roll Pitch Yaw";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.RPYradioCheck);
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(236, 501);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.Text = "N S A";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.NSAradioCheck);
            // 
            // headerControl6
            // 
            this.headerControl6.Controls.Add(this.textBox1);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 68;
            // 
            // button30
            // 
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button30.Location = new System.Drawing.Point(176, 117);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(152, 24);
            this.button30.TabIndex = 30;
            this.button30.Text = "GoToHome Init";
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button29
            // 
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button29.Location = new System.Drawing.Point(176, 183);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(152, 24);
            this.button29.TabIndex = 29;
            this.button29.Text = "Send Command";
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button27
            // 
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button27.Location = new System.Drawing.Point(176, 78);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(152, 24);
            this.button27.TabIndex = 28;
            this.button27.Text = "Full Init";
            this.button27.Click += new System.EventHandler(this.button27_Click);
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
            this.label27.Text = "Gripper:    ";
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
            this.label22.Text = "Yaw:";
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
            this.label25.Text = "Roll:";
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
            this.label26.Text = "Pitch:";
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
            this.headerControl4.Controls.Add(this.xstep);
            this.headerControl4.Controls.Add(this.ystep);
            this.headerControl4.Controls.Add(this.zstep);
            this.headerControl4.Controls.Add(this.nstep);
            this.headerControl4.Controls.Add(this.sstep);
            this.headerControl4.Controls.Add(this.astep);
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
            this.headerControl4.Controls.Add(this.label31);
            this.headerControl4.Controls.Add(this.label32);
            this.headerControl4.Controls.Add(this.label34);
            this.headerControl4.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl4.Location = new System.Drawing.Point(340, 48);
            this.headerControl4.Name = "headerControl4";
            this.headerControl4.Size = new System.Drawing.Size(344, 280);
            this.headerControl4.TabIndex = 15;
            this.headerControl4.Text = "Control Panel";
            // 
            // xstep
            // 
            this.xstep.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xstep.Location = new System.Drawing.Point(88, 40);
            this.xstep.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.xstep.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xstep.Name = "xstep";
            this.xstep.Size = new System.Drawing.Size(64, 20);
            this.xstep.TabIndex = 42;
            this.xstep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ystep
            // 
            this.ystep.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ystep.Location = new System.Drawing.Point(88, 71);
            this.ystep.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ystep.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ystep.Name = "ystep";
            this.ystep.Size = new System.Drawing.Size(64, 20);
            this.ystep.TabIndex = 41;
            this.ystep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // zstep
            // 
            this.zstep.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.zstep.Location = new System.Drawing.Point(88, 110);
            this.zstep.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.zstep.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.zstep.Name = "zstep";
            this.zstep.Size = new System.Drawing.Size(64, 20);
            this.zstep.TabIndex = 40;
            this.zstep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.zstep.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // nstep
            // 
            this.nstep.Location = new System.Drawing.Point(88, 141);
            this.nstep.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nstep.Name = "nstep";
            this.nstep.Size = new System.Drawing.Size(64, 20);
            this.nstep.TabIndex = 39;
            this.nstep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // sstep
            // 
            this.sstep.Location = new System.Drawing.Point(88, 176);
            this.sstep.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.sstep.Name = "sstep";
            this.sstep.Size = new System.Drawing.Size(64, 20);
            this.sstep.TabIndex = 38;
            this.sstep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sstep.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // astep
            // 
            this.astep.Location = new System.Drawing.Point(88, 211);
            this.astep.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.astep.Name = "astep";
            this.astep.Size = new System.Drawing.Size(64, 20);
            this.astep.TabIndex = 37;
            this.astep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(54, 245);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 24);
            this.label20.TabIndex = 24;
            this.label20.Text = "Gripper:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // button21
            // 
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button21.Location = new System.Drawing.Point(260, 209);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(64, 24);
            this.button21.TabIndex = 23;
            this.button21.Text = "Move -";
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button22.Location = new System.Drawing.Point(188, 209);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(64, 24);
            this.button22.TabIndex = 22;
            this.button22.Text = "Move +";
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(12, 213);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 24);
            this.label17.TabIndex = 20;
            this.label17.Text = "Yaw:";
            // 
            // button23
            // 
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button23.Location = new System.Drawing.Point(261, 169);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(64, 24);
            this.button23.TabIndex = 19;
            this.button23.Text = "Move -";
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button24.Location = new System.Drawing.Point(189, 169);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(64, 24);
            this.button24.TabIndex = 18;
            this.button24.Text = "Move +";
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(13, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 24);
            this.label18.TabIndex = 16;
            this.label18.Text = "Pitch:";
            // 
            // button25
            // 
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button25.Location = new System.Drawing.Point(261, 137);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(64, 24);
            this.button25.TabIndex = 15;
            this.button25.Text = "Move -";
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button26.Location = new System.Drawing.Point(188, 137);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(64, 24);
            this.button26.TabIndex = 14;
            this.button26.Text = "Move +";
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(13, 145);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 24);
            this.label19.TabIndex = 12;
            this.label19.Text = "Roll:";
            // 
            // button19
            // 
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button19.Location = new System.Drawing.Point(259, 104);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(64, 24);
            this.button19.TabIndex = 11;
            this.button19.Text = "Move -";
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button20.Location = new System.Drawing.Point(188, 104);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(64, 24);
            this.button20.TabIndex = 10;
            this.button20.Text = "Move +";
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(11, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(320, 24);
            this.label16.TabIndex = 8;
            this.label16.Text = "Z Axis:    Step                          cm";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // button17
            // 
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button17.Location = new System.Drawing.Point(260, 70);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(64, 24);
            this.button17.TabIndex = 7;
            this.button17.Text = "Move -";
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button18.Location = new System.Drawing.Point(188, 70);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(64, 24);
            this.button18.TabIndex = 6;
            this.button18.Text = "Move +";
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(12, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(320, 24);
            this.label15.TabIndex = 4;
            this.label15.Text = "Y Axis:    Step                          cm";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button16.Location = new System.Drawing.Point(260, 36);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(64, 24);
            this.button16.TabIndex = 3;
            this.button16.Text = "Move -";
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button15.Location = new System.Drawing.Point(188, 36);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(64, 24);
            this.button15.TabIndex = 2;
            this.button15.Text = "Move +";
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(12, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(320, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "X Axis:    Step                          cm";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // button28
            // 
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button28.Location = new System.Drawing.Point(140, 242);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(64, 24);
            this.button28.TabIndex = 22;
            this.button28.Text = "Open";
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button32
            // 
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button32.Location = new System.Drawing.Point(218, 242);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(64, 24);
            this.button32.TabIndex = 23;
            this.button32.Text = "Close";
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(26, 145);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(302, 24);
            this.label31.TabIndex = 43;
            this.label31.Text = "          Step                          deg";
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(26, 177);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(306, 24);
            this.label32.TabIndex = 44;
            this.label32.Text = "          Step                          deg";
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(26, 212);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(306, 24);
            this.label34.TabIndex = 45;
            this.label34.Text = "          Step                          deg";
            // 
            // sdown
            // 
            this.sdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sdown.Image = ((System.Drawing.Image)(resources.GetObject("sdown.Image")));
            this.sdown.Location = new System.Drawing.Point(145, 326);
            this.sdown.Name = "sdown";
            this.sdown.Size = new System.Drawing.Size(24, 24);
            this.sdown.TabIndex = 14;
            this.sdown.Click += new System.EventHandler(this.button14_Click);
            // 
            // adown
            // 
            this.adown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adown.Image = ((System.Drawing.Image)(resources.GetObject("adown.Image")));
            this.adown.Location = new System.Drawing.Point(213, 330);
            this.adown.Name = "adown";
            this.adown.Size = new System.Drawing.Size(24, 24);
            this.adown.TabIndex = 13;
            this.adown.Click += new System.EventHandler(this.adown_Click);
            // 
            // sup
            // 
            this.sup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sup.Image = ((System.Drawing.Image)(resources.GetObject("sup.Image")));
            this.sup.Location = new System.Drawing.Point(213, 285);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(24, 29);
            this.sup.TabIndex = 12;
            this.sup.Click += new System.EventHandler(this.sup_Click);
            // 
            // aup
            // 
            this.aup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aup.Image = ((System.Drawing.Image)(resources.GetObject("aup.Image")));
            this.aup.Location = new System.Drawing.Point(148, 285);
            this.aup.Name = "aup";
            this.aup.Size = new System.Drawing.Size(24, 29);
            this.aup.TabIndex = 11;
            this.aup.Click += new System.EventHandler(this.aup_Click);
            // 
            // ndown
            // 
            this.ndown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ndown.Image = ((System.Drawing.Image)(resources.GetObject("ndown.Image")));
            this.ndown.Location = new System.Drawing.Point(177, 347);
            this.ndown.Name = "ndown";
            this.ndown.Size = new System.Drawing.Size(22, 24);
            this.ndown.TabIndex = 10;
            this.ndown.Click += new System.EventHandler(this.ndown_Click);
            // 
            // nup
            // 
            this.nup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nup.Image = ((System.Drawing.Image)(resources.GetObject("nup.Image")));
            this.nup.Location = new System.Drawing.Point(178, 264);
            this.nup.Name = "nup";
            this.nup.Size = new System.Drawing.Size(24, 29);
            this.nup.TabIndex = 9;
            this.nup.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(101, 323);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 48);
            this.button8.TabIndex = 8;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(141, 175);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 48);
            this.button7.TabIndex = 7;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(102, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 48);
            this.button6.TabIndex = 6;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(141, 93);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 46);
            this.button5.TabIndex = 5;
            this.button5.Click += new System.EventHandler(this.Button5_clicked);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(176, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 40);
            this.button3.TabIndex = 4;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(96, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 40);
            this.button4.TabIndex = 3;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(179, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 42);
            this.button2.TabIndex = 2;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(95, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 40);
            this.button1.TabIndex = 1;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(1, 26);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(750, 24);
            this.menuStrip2.TabIndex = 17;
            this.menuStrip2.Text = "menuStrip2";
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
            this.headerControl8.Location = new System.Drawing.Point(143, 23);
            this.headerControl8.Name = "headerControl8";
            this.headerControl8.Size = new System.Drawing.Size(752, 580);
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
            this.panel3.Controls.Add(this.properties_control1);
            this.panel3.Controls.Add(this.button47);
            this.panel3.Controls.Add(this.button39);
            this.panel3.Location = new System.Drawing.Point(3, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 314);
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
            // properties_control1
            // 
            this.properties_control1.Location = new System.Drawing.Point(-3, -3);
            this.properties_control1.Margin = new System.Windows.Forms.Padding(4);
            this.properties_control1.Name = "properties_control1";
            this.properties_control1.Size = new System.Drawing.Size(305, 283);
            this.properties_control1.TabIndex = 0;
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
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button43);
            this.panel1.Controls.Add(this.button41);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 263);
            this.panel1.TabIndex = 18;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(0, 131);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(264, 43);
            this.button11.TabIndex = 10;
            this.button11.Text = "Absolute Move \r\nShortcut: absmove";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
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
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(47, 201);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 25);
            this.button9.TabIndex = 5;
            this.button9.Text = "gripopen";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_2);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(153, 201);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(64, 25);
            this.button10.TabIndex = 39;
            this.button10.Text = "gripclose";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
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
            this.richTextBox1.Location = new System.Drawing.Point(31, 0);
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
            this.headerControl11.Controls.Add(this.richTextBox3);
            this.headerControl11.Controls.Add(this.button13);
            this.headerControl11.Controls.Add(this.button12);
            this.headerControl11.Controls.Add(this.button14);
            this.headerControl11.Controls.Add(this.button38);
            this.headerControl11.Controls.Add(this.pictureBox9);
            this.headerControl11.Controls.Add(this.label29);
            this.headerControl11.Controls.Add(this.button33);
            this.headerControl11.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl11.Location = new System.Drawing.Point(438, 395);
            this.headerControl11.Name = "headerControl11";
            this.headerControl11.Size = new System.Drawing.Size(306, 180);
            this.headerControl11.TabIndex = 2;
            this.headerControl11.Text = "Execute Options";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(24, 88);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(31, 20);
            this.richTextBox3.TabIndex = 43;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(206, 114);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(64, 26);
            this.button13.TabIndex = 41;
            this.button13.Text = "Stop";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button12.Location = new System.Drawing.Point(32, 115);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(154, 25);
            this.button12.TabIndex = 40;
            this.button12.Text = "Execute Commands with loop";
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button14.Location = new System.Drawing.Point(67, 86);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(218, 24);
            this.button14.TabIndex = 42;
            this.button14.Text = "Execute Commands with certain loop";
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // button38
            // 
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button38.Location = new System.Drawing.Point(15, 145);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(127, 24);
            this.button38.TabIndex = 36;
            this.button38.Text = "Step Execute";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(7, 42);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(15, 16);
            this.pictureBox9.TabIndex = 34;
            this.pictureBox9.TabStop = false;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(23, 42);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(273, 33);
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
            this.button33.Text = "Execute Commands";
            this.button33.Click += new System.EventHandler(this.StartParsing);
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(148, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // headerControl5
            // 
            this.headerControl5.Controls.Add(this.label53);
            this.headerControl5.Controls.Add(this.label52);
            this.headerControl5.Controls.Add(this.label51);
            this.headerControl5.Controls.Add(this.label50);
            this.headerControl5.Controls.Add(this.label49);
            this.headerControl5.Controls.Add(this.label48);
            this.headerControl5.Controls.Add(this.label47);
            this.headerControl5.Controls.Add(this.checkBox10);
            this.headerControl5.Controls.Add(this.checkBox9);
            this.headerControl5.Controls.Add(this.checkBox8);
            this.headerControl5.Controls.Add(this.checkBox7);
            this.headerControl5.Controls.Add(this.checkBox6);
            this.headerControl5.Controls.Add(this.checkBox5);
            this.headerControl5.Controls.Add(this.checkBox4);
            this.headerControl5.Controls.Add(this.checkBox3);
            this.headerControl5.Controls.Add(this.checkBox2);
            this.headerControl5.Controls.Add(this.checkBox1);
            this.headerControl5.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.headerControl5.Location = new System.Drawing.Point(143, 24);
            this.headerControl5.Name = "headerControl5";
            this.headerControl5.Size = new System.Drawing.Size(521, 390);
            this.headerControl5.TabIndex = 5;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(398, 172);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(41, 13);
            this.label53.TabIndex = 16;
            this.label53.Text = "label53";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(396, 107);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(56, 13);
            this.label52.TabIndex = 15;
            this.label52.Text = "GripStatus";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(393, 147);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(25, 13);
            this.label51.TabIndex = 14;
            this.label51.Text = "Roll";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(420, 70);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(31, 13);
            this.label50.TabIndex = 13;
            this.label50.Text = "MidY";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(421, 213);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(41, 13);
            this.label49.TabIndex = 12;
            this.label49.Text = "label49";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(342, 213);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(41, 13);
            this.label48.TabIndex = 11;
            this.label48.Text = "label48";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(368, 70);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(31, 13);
            this.label47.TabIndex = 10;
            this.label47.Text = "MidX";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(189, 222);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(54, 17);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Minus";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(81, 222);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(46, 17);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Plus";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(189, 147);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(47, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Two";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(189, 187);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(54, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Down";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(81, 187);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(40, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Up";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(189, 70);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(33, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "B";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(81, 147);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(46, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "One";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(189, 107);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(43, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "IR2";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(81, 107);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(43, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "IR1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(81, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(33, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "A";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(896, 696);
            this.Controls.Add(this.headerControl5);
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
            this.headerControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.headerControl6.ResumeLayout(false);
            this.headerControl6.PerformLayout();
            this.headerControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xstep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ystep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zstep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nstep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sstep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.astep)).EndInit();
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
            this.headerControl11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.headerControl5.ResumeLayout(false);
            this.headerControl5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Editor
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

            System.Drawing.Point pos = new System.Drawing.Point(0, 0);
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
            numberLabel.Location = new System.Drawing.Point(0, d);

            updateNumberLabel();

        }

        private void richTextBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (populating) return;
            ColorSyntaxEditor.FlickerFreeRichEditTextBox._Paint = false;
            MakeColorSyntaxForCurrentLine();
            ColorSyntaxEditor.FlickerFreeRichEditTextBox._Paint = true;

            if ((e.KeyCode == Keys.Enter))
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
            ir52c = new highlvl(DebugDsp);
            
            // Saving properties window elements into arrays
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

            PropertiesButtons.Add(properties_control1.button1);
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

            // create a new instance of the Wiimote
            wm = new Wiimote();

            // setup the event to handle state changes
            wm.WiimoteChanged += wm_WiimoteChanged;

            // setup the event to handle insertion/removal of extensions
            wm.WiimoteExtensionChanged += wm_WiimoteExtensionChanged;

            // connect to the Wiimote
            wm.Connect();

            // set the report type to return the IR sensor and accelerometer data (buttons always come back)
            wm.SetReportType(InputReport.IRAccel, true);

            }

        void wm_WiimoteExtensionChanged(object sender, WiimoteExtensionChangedEventArgs args)
        {
            if (args.Inserted)
                wm.SetReportType(InputReport.IRExtensionAccel, true);    // return extension data
            else
                wm.SetReportType(InputReport.IRAccel, true);            // back to original mode
        }

        void wm_WiimoteChanged(object sender, WiimoteChangedEventArgs args)
        {
            // current state information
            UpdateState(args);

        }

        //gia na mporei na kanei polla threads mazi
        public void UpdateState(WiimoteChangedEventArgs args)
        {
            BeginInvoke(new UpdateWiimoteStateDelegate(UpdateWiimoteChanged), args);
        }

        WiimoteState ws;
        public void UpdateWiimoteChanged(WiimoteChangedEventArgs args)
        {
            ws = args.WiimoteState;
            //energopoiisi timer gia ti thesi tou vraxiona
            if (ws.ButtonState.A)
            {
                timer1.Enabled = true;
                timer1.Start();

            }
            else
            {
                timer1.Enabled = false;
                n = 0;
            }


            //energopoiisi timer gia prosanarolismo tou gripper
            if ((ws.ButtonState.One) & ((ws.AccelState.Values.X > 0.25) || (ws.AccelState.Values.X < -0.25)))
            {
                timer2.Enabled = true;
                timer2.Start();
            }
            else { timer2.Enabled = false; }

            //pitch 
            if (ws.ButtonState.Two)
            {
                timer5.Enabled = true;
                timer5.Start();
            }
            else { timer5.Enabled = false; }



            //timer gia open/closed
            timer1.Enabled = true;
            timer1.Start();

            if (ws.ButtonState.Plus)
            {
                //init
                ir52c.movehigh_abs(0, 0, 857, 0, 90, 0);
            }

            if (ws.ButtonState.Minus)
            {
                //puzzle button state
                ir52c.movehigh_abs(300, 0, 50, 0, -90, 0);
            }

            if (GripStatus)
            {
                label52.Text = "Open";
            }
            else
            { label52.Text = "Closed"; }


            //energopoiisi timer gia ton 3o axona
            if ((ws.ButtonState.Up) || (ws.ButtonState.Down))
            {

                timer4.Enabled = true;
                timer4.Start();
            }
            else
            {
                timer4.Enabled = false;
            }




            checkBox6.Checked = ws.ButtonState.Up;
            checkBox7.Checked = ws.ButtonState.Down;
            checkBox4.Checked = ws.ButtonState.One;
            checkBox1.Checked = ws.ButtonState.A;
            checkBox5.Checked = ws.ButtonState.B;
            checkBox2.Checked = ws.IRState.IRSensors[0].Found;
            checkBox3.Checked = ws.IRState.IRSensors[1].Found;
            checkBox8.Checked = ws.ButtonState.Two;
            checkBox9.Checked = ws.ButtonState.Plus;
            checkBox10.Checked = ws.ButtonState.Minus;


            if (ws.ButtonState.A)
            {
                label53.Text = ws.AccelState.Values.X.ToString();
            }
        }

        
        private bool TestComment(string s)
        {
            string testString = s.Trim();
            if ((testString.Length >= 2) &&
                (testString[0] == '/') &&
                (testString[1] == '/')
                )
                return true;

            return false;
        }

        private int ParseLine(string s)
        {
            TheBuffer.Initialize();
            int count = 0;
            Regex r = new Regex(@"\w+|[^A-Za-z0-9_ \f\t\v]", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            Match m;

            for (m = r.Match(s); m.Success; m = m.NextMatch())
            {
                TheBuffer[count].Word = m.Value;
                TheBuffer[count].Position = m.Index;
                TheBuffer[count].Length = m.Length;
                count++;
            }


            return count;
        }

        private Color Lookup(string s)
        {
            Color theColor = Color.Black;

            if (TheSyntaxReader.IsFunction(s))
            {
                theColor = Color.DarkRed;
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

            //Find start of line
            int pos = CurrentSelectionStart;
            while ((pos > 0) && (richTextBox1.Text[pos - 1] != '\n'))
                pos--;

            int pos2 = CurrentSelectionStart;
            while ((pos2 < richTextBox1.Text.Length) &&
                (richTextBox1.Text[pos2] != '\n'))
                pos2++;

            string s = richTextBox1.Text.Substring(pos, pos2 - pos);
            if (TestComment(s) == true)
            {
                richTextBox1.Select(pos, pos2 - pos);
                richTextBox1.SelectionColor = kCommentColor;
            }
            else
            {
                string previousWord = "";
                int count = ParseLine(s);
                for (int i = 0; i < count; i++)
                {
                    WordAndPosition wp = TheBuffer[i];

                    //Check for comment
                    if (wp.Word == "/" && previousWord == "/")
                    {
                        //Color until end of line
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

            if (CurrentSelectionStart >= 0)
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

                //Check for comment
                if (wp.Word == "/" && previousWord == "/")
                {
                    //Color until end of line
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

            }

            if (CurrentSelectionStart >= 0)
                richTextBox1.Select(CurrentSelectionStart, CurrentSelectionLength);

            populating = false;

        }

        private void declaration()
        {
            richTextBox1.Text = "// Democritus University of Thrace \n";
            MakeColorSyntaxForCurrentLine();

            richTextBox1.Text = richTextBox1.Text + "// Automatic Control System Laboratory \n";
            MakeColorSyntaxForCurrentLine();

            richTextBox1.Text = richTextBox1.Text + "// Robotics Script Language is loaded \n";
            MakeColorSyntaxForCurrentLine();

            richTextBox1.Text = richTextBox1.Text + "// Write your source through the appropriate buttons \n\n";
            MakeColorSyntaxForCurrentLine();


            numberLabel.Font = new Font(richTextBox1.Font.FontFamily,
                richTextBox1.Font.Size + 1.019f);
            updateNumberLabel();

        }

        private void About()
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }



        private void CustomizePropertiesMenu(string Command, string CShortcat, ArrayList labeltext)
        {
            TextBox temptextbox;
            Label templabel;
            Button tempbutton;



            for (int i = 0; i < labeltext.Count; i++)
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
                temptextbox.Visible = false;

                System.Collections.IEnumerator myEnumeratorL = PropertiesLabels.GetEnumerator(i, 1);
                myEnumeratorL.MoveNext();
                templabel = (Label)myEnumeratorL.Current;
                templabel.Visible = false;

                System.Collections.IEnumerator myEnumeratorB = PropertiesButtons.GetEnumerator(i, 1);
                myEnumeratorB.MoveNext();
                tempbutton = (Button)myEnumeratorB.Current;
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

            PropertiesCommands.Add("Move To Point (X2)=");
            PropertiesCommands.Add("Move To Point (Y2)=");
            PropertiesCommands.Add("Move To Point (Z2)=");
            PropertiesCommands.Add("Target Angle (A)=");
            PropertiesCommands.Add("Target Angle (B)=");
            PropertiesCommands.Add("Target Angle (C)=");


            PropertiesShortcuts.Add("x2=");
            PropertiesShortcuts.Add("y2=");
            PropertiesShortcuts.Add("z2=");
            PropertiesShortcuts.Add("a=");
            PropertiesShortcuts.Add("b=");
            PropertiesShortcuts.Add("c=");

            CustomizePropertiesMenu("Point To Point", "ptp", PropertiesCommands);

        }
        

        private void button2_Down(object sender, EventArgs e)
        {
            do
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.EnableRaisingEvents = false;
                proc.StartInfo.FileName = "calc";
                proc.Start();
            } while (false);
        }

        private bool button2_Up(object sender, EventArgs e)
        {
            return false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            TextBox temptextbox;

            richTextBox1.SelectedText = "\n" + "function " + label1.Text.ToString() + " begin";
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
                    richTextBox1.SelectedText = "\n";
                }
                if (temptextbox.Text == "") {temptextbox.Text = "0";}
                richTextBox1.SelectedText = richTextBox1.SelectedText + " " + myEnumeratorS.Current.ToString() + temptextbox.Text + ";";

            }

            MakeColorSyntaxForCurrentLine();
            richTextBox1.SelectedText = "\n" + " " + label1.Text.ToString() + " end;";
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
        #endregion

        #region Unused buttons
        private void navigationPane10_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void headerControl3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button49_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }


        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Button Cliks
        private void Init_Click(object sender, EventArgs e)
        {
            ir52c.init("full");
        }
        
        public void RelativeMove(int i, int j, int mm)
        {
            if (j == 3)
            {
                if (i == 0) ir52c.movehigh_rel(mm, 0, 0, 0, 0, 0);
                if (i == 1) ir52c.movehigh_rel(0, mm, 0, 0, 0, 0);
                if (i == 2) ir52c.movehigh_rel(0, 0, mm, 0, 0, 0);
            }
        }

        public void RelativeMove(int x, int y, int z, int r, int p, int ya)
        {
            ir52c.movehigh_rel(x, y, z, r, p, ya);
        }

        //roll
        //pitch
        //yaw
        //Rotate relatively
        public void Rotate(int R, int P,int Y)
        {
            ir52c.movehigh_rel(0, 0, 0, R, P, Y);
        }

        //Move x right (+)
        private void button2_Click(object sender, EventArgs e)
        {
            RelativeMove(0, 3, (int)xstep.Value * 10);
        }

        //Move y down (-)
        private void button7_Click(object sender, EventArgs e)
        {
            RelativeMove(1, 3, (int)-ystep.Value * 10);
        }

        //Move y up
        private void Button5_clicked(object sender, EventArgs e)
        {
            RelativeMove(1, 3, (int)ystep.Value * 10);
        }

        //Move x left (-)
        private void button1_Click(object sender, EventArgs e)
        {
            RelativeMove(0, 3, (int)-xstep.Value * 10);
        }

        //Move z up
        private void button6_Click(object sender, EventArgs e)
        {
            RelativeMove(2, 3, (int)zstep.Value * 10);
        }

        //Move z down (-)
        private void button8_Click(object sender, EventArgs e)
        {
            ir52c.movehigh_rel(0, 0, (int)-zstep.Value * 10, 0, 0, 0);
        }

        //Yaw up (+)
        private void aup_Click(object sender, EventArgs e)
        {
            Rotate(0, 0, (int)astep.Value);
        }

        //Pitch down (-)
        private void button14_Click(object sender, EventArgs e)
        {
            Rotate(0,(int)-sstep.Value, 0);
        }

        //Roll up (+)
        private void button9_Click(object sender, EventArgs e)
        {
            Rotate((int)nstep.Value, 0, 0);
        }
        
        private void button28_Click(object sender, EventArgs e)
        {
            OpenGripper();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenGripper();
        }

        //Open Gripper
        private void OpenGripper()
        {
            ir52c.GripperOpen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CloseGripper();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            CloseGripper();
        }

        //Close Gripper
        private void CloseGripper()
        {
            ir52c.GripperClose();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            ir52c.lowlvlobj.TalkToBot(textBox1.Text.Trim());
        }

        int k = 0;

        private void StartParsing(object sender, EventArgs e)
        {
            parsing(richTextBox1.Text);
        }

        private void gripopen_Click()
        {
            TextBox temptextbox;

            richTextBox1.SelectedText = "\n" + "function " + "gripopen";
            MakeColorSyntaxForCurrentLine();
            MakeColorSyntaxForCurrentLine();
            richTextBox1.SelectedText = "\n" + " end;";
            MakeColorSyntaxForCurrentLine();
            richTextBox1.SelectedText = "\n";
            updateNumberLabel();
            panel3.Visible = false;
        }

        private void gripclose_Click()
        {
            TextBox temptextbox;

            richTextBox1.SelectedText = "\n" + "function " + "gripclose";
            MakeColorSyntaxForCurrentLine();
            MakeColorSyntaxForCurrentLine();
            richTextBox1.SelectedText = "\n" + " end;";
            MakeColorSyntaxForCurrentLine();
            richTextBox1.SelectedText = "\n";
            updateNumberLabel();
            panel3.Visible = false;
        }


        private void button9_Click_2(object sender, EventArgs e)
        {
            gripopen_Click();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            gripclose_Click();
        }

        //Roll down (-)
        private void ndown_Click(object sender, EventArgs e)
        {
            Rotate((int)-nstep.Value, 0, 0);
        }

        //Pitch up (+)
        private void sup_Click(object sender, EventArgs e)
        {
            Rotate(0, (int)sstep.Value, 0);
        }

        //Yaw down (-)
        private void adown_Click(object sender, EventArgs e)
        {
            Rotate(0, 0, (int)-astep.Value);
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            PropertiesCommands.Clear();
            PropertiesShortcuts.Clear();

            PropertiesCommands.Add("Move To Point (X1)=");
            PropertiesCommands.Add("Move To Point (Y1)=");
            PropertiesCommands.Add("Move To Point (Z1)=");
            PropertiesCommands.Add("Target Angle (A)=");
            PropertiesCommands.Add("Target Angle (B)=");
            PropertiesCommands.Add("Target Angle (C)=");


            PropertiesShortcuts.Add("x1=");
            PropertiesShortcuts.Add("y1=");
            PropertiesShortcuts.Add("z1=");
            PropertiesShortcuts.Add("a=");
            PropertiesShortcuts.Add("b=");
            PropertiesShortcuts.Add("c=");

            CustomizePropertiesMenu("Absolute", "abs", PropertiesCommands);

        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            string Saved_File = "";

            saveFD.InitialDirectory = "C:";
            saveFD.Title = "Save a Text File";
            saveFD.FileName = "";

            saveFD.Filter = "Text Files|*.txt|All Files|*.*";

            if (saveFD.ShowDialog() != DialogResult.Cancel)
            {
                Saved_File = saveFD.FileName;
                richTextBox1.SaveFile(Saved_File, RichTextBoxStreamType.PlainText);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                richTextBox1.Text += Convert.ToString(sr.ReadToEnd());
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Saved_File = "";
            Saved_File = saveFD.FileName;
            richTextBox1.SaveFile(Saved_File, RichTextBoxStreamType.PlainText);
        }

        //When the NSA radiobutton in clicked:
        private void NSAradioCheck(object sender, EventArgs e)
        {
            label25.Text = "N:";
            label26.Text = "S:";
            label22.Text = "A:";
            label19.Text = "N:";
            label18.Text = "S:";
            label17.Text = "A:";
            label11.Text = "N";
            label13.Text = "S";
            label30.Text = "A";
        }

        //When the RollPitchYow radiobutton in clicked:
        private void RPYradioCheck(object sender, EventArgs e)
        {
            label25.Text = "Roll:";
            label26.Text = "Pitch:";
            label22.Text = "Yaw:";
            label19.Text = "Roll:";
            label18.Text = "Pitch:";
            label17.Text = "Yaw:";
            label11.Text = "Roll";
            label13.Text = "Pitch";
            label30.Text = "Yaw";
        }

        //When the Euler Angles radiobutton in clicked:
        private void EulerradioCheck(object sender, EventArgs e)
        {
            label25.Text = "Theta:";
            label26.Text = "Phi:";
            label22.Text = "Psi:";
            label19.Text = "Theta:";
            label18.Text = "Phi:";
            label17.Text = "Psi:";
            label11.Text = "Theta";
            label13.Text = "Phi";
            label30.Text = "Psi";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            ir52c.init("full"); //Do a full initialization
        }

        private void button31_Click(object sender, EventArgs e)
        {
            ir52c.movehigh_abs((int)numericUpDown1.Value * 10, (int)numericUpDown2.Value * 10, (int)numericUpDown3.Value * 10, (int)numericUpDown4.Value, (int)numericUpDown5.Value, (int)numericUpDown6.Value);
            //ir52c.movehigh_abs(0, 0, 700, 0, 0, 0);
        }

        private void button49_Click_2(object sender, EventArgs e)
        {
            ir52c.movehigh_abs(300, 0, 50, 0, -90, 0);
        }

        //z move +
        private void button20_Click(object sender, EventArgs e)
        {
            button6_Click(sender, e);
        }

        //z move -
        private void button19_Click(object sender, EventArgs e)
        {
            button8_Click(sender, e);
        }

        //x move -
        private void button16_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        //x move +
        private void button15_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        //y move +
        private void button18_Click(object sender, EventArgs e)
        {
            Button5_clicked(sender, e);
        }

        //y move -
        private void button17_Click(object sender, EventArgs e)
        {
            button7_Click(sender, e);
        }

        //Roll move +
        private void button26_Click(object sender, EventArgs e)
        {
            button9_Click(sender, e);
        }

        //Roll move -
        private void button25_Click(object sender, EventArgs e)
        {
            ndown_Click(sender, e);
        }

        //Pitch move +
        private void button24_Click(object sender, EventArgs e)
        {
            sup_Click(sender, e);
        }

        //Pitch move -
        private void button23_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
        }

        //Yaw move +
        private void button22_Click(object sender, EventArgs e)
        {
            aup_Click(sender, e);
        }

        //Yaw move -
        private void button21_Click(object sender, EventArgs e)
        {
            adown_Click(sender, e);
        }

        #endregion

        #region Parser
        //Normal parsing
        #region Normal
        public void parsing(string text)
        {
            char[] delimiterChars = { '\n' };
            char[] delimiterChars2 = { ' ', '=', ';', '\t' }; 

            string temp;

            string[] lines = text.Split(delimiterChars);

            //Text is the "extracted" string
            text = "";

            //Removal of all user comments
            foreach (string s in lines)
            {
                if (s.Length >= 2) if (!(s[0] == '/' && s[1] == '/'))
                    {
                        temp = s;
                        for (int i = 0; i < s.Length - 1; i++)
                        {
                            if (s[i] == '/' && s[i + 1] == '/') temp = s.Substring(0, i);
                        }
                        text += temp;
                    }
            }

            string x;
            lines = text.Split(delimiterChars2);
            Console.WriteLine(text);
            text = "";

            //Step by step checking for linear move
            int l = 0;
            int status = 0;
            while (l < lines.Length)
            {
                switch (status)
                {
                    case 0:
                        if (lines[l] == "function") { status = 1; }
                        else if (lines[l] == "") { break; }
                        else { MessageBox.Show("Instead of word function, "+lines[l]+" was found", "Error"); status = -1; }
                        break;
                    case 1:
                        if (lines[l] == "lmove") { status = 2; }
                        else if (lines[l] == "ptp") { status = -2; }
                        else if (lines[l] == "abs") {status = 21;}
                        else if (lines[l] == "gripopen") { OpenGripper(); status = 5; }
                        else if (lines[l] == "gripclose") { CloseGripper(); status = 5; }
                        else if (lines[l] == "") { break; }
                        else { MessageBox.Show("Instead of word lmove, " + lines[l] + " was found", "Error"); status = -1; }
                        break;
                    case 2:
                        if (lines[l] == "begin") { status = 3; }
                        else if (lines[l] == "") { break; }
                        else { MessageBox.Show("Instead of word begin, " + lines[l] + " was found", "Error"); status = -1; }
                        break;
                    case -2:
                        if (lines[l] == "begin") { status = -3; }
                        else if (lines[l] == "") { break; }
                        else { MessageBox.Show("Instead of word begin, " + lines[l] + " was found", "Error"); status = -1; }
                        break;
                    case 21:
                        if (lines[l] == "begin") { status = 31; }
                        else if (lines[l] == "") { break; }
                        else { MessageBox.Show("Instead of word begin, " + lines[l] + " was found", "Error"); status = -1; }
                        break;
                    case 3:
                        //while (l < lines.Length)
                        //{                        
                        switch (lines[l])
                        {
                            case "":
                                break;
                            case "x":
                                RelativeMove(0, 3, Convert.ToInt32(lines[++l]) * 10);
                                break;
                            case "y":
                                RelativeMove(1, 3, Convert.ToInt32(lines[++l]) * 10);
                                break;
                            case "z":
                                RelativeMove(2, 3, Convert.ToInt32(lines[++l]) * 10);
                                break;
                            case "a":
                                Rotate(Convert.ToInt32(lines[++l]),0,0);
                                    break;
                            case "b":
                                Rotate(0,Convert.ToInt32(lines[++l]),0);
                                    break;
                            case "c":
                                    Rotate(0,0,Convert.ToInt32(lines[++l]));
                                    status = 4;
                                    break;
                            default:
                                    MessageBox.Show("Instead of x,y,z,a,b or c, " + lines[l] + " was found", "Error");
                                status = -1;
                                break;
                        }

                        //}                        
                        break;
                    case -3:
                        switch (lines[l])
                        {
                            case "":
                                break;
                            case "x2":
                                RelativeMove(0, 3, Convert.ToInt32(lines[++l]) * 10);
                                break;
                            case "y2":
                                RelativeMove(1, 3, Convert.ToInt32(lines[++l]) * 10);
                                break;
                            case "z2":
                                RelativeMove(2, 3, Convert.ToInt32(lines[++l]) * 10);
                                break;
                            case "a":
                                Rotate(Convert.ToInt32(lines[++l]), 0, 0);
                                break;
                            case "b":
                                Rotate(0, Convert.ToInt32(lines[++l]), 0);
                                break;
                            case "c":
                                Rotate(0, 0, Convert.ToInt32(lines[++l]));
                                status = -4;
                                break;
                            default:
                                MessageBox.Show("Instead of x2,y2,z2,a,b or c, " + lines[l] + " was found", "Error");
                                status = -1;
                                break;
                        }
                        break;
                    case 31:
                        //while (l < lines.Length)
                        //{                        
                        switch (lines[l])
                        {
                            case "":
                                break;
                            case "x1":
                                ir52c.movehigh_abs(Convert.ToInt32(lines[++l]), 0, 0, 0, 0, 0);                                
                                break;
                            case "y1":
                                ir52c.movehigh_abs(0, Convert.ToInt32(lines[++l]), 0, 0, 0, 0); 
                                break;
                            case "z1":                                
                                ir52c.movehigh_abs(0, 0, Convert.ToInt32(lines[++l]), 0, 0, 0);
                                break;
                            case "a":
                                ir52c.movehigh_abs(0, 0, 0, Convert.ToInt32(lines[++l]), 0, 0);
                                break;
                            case "b":
                                ir52c.movehigh_abs(0, 0, 0, 0, Convert.ToInt32(lines[++l]), 0);
                                break;
                            case "c":
                                ir52c.movehigh_abs(0, 0, 0, 0, 0, Convert.ToInt32(lines[++l]));
                                status = 41;
                                break;
                            default:
                                MessageBox.Show("Instead of x,y,z,a,b or c, " + lines[l] + " was found", "Error");
                                status = -1;
                                break;
                        }

                        //}                        
                        break;
                    case 4:
                        if (lines[l] == "lmove") { status = 5; }
                        else if (lines[l] == "") { break; }
                        else { MessageBox.Show("Instead of word lmove, " +lines[l] + " was found", "Error"); status = -1; }
                        break;
                    case -4:
                        if (lines[l] == "ptp") { status = 5; }
                        else if (lines[l] == "") { break; }
                        else { MessageBox.Show("Instead of word ptp, "+lines[l]+ " was found", "Error"); status = -1; }
                        break;
                    case 41:
                        if (lines[l] == "abs") { status = 5; }
                        else if (lines[l] == "") { break; }
                        else { MessageBox.Show("Instead of word ptp, " + lines[l] + " was found", "Error"); status = -1; }
                        break;
                    case 5:
                        if (lines[l] == "end") { status = 0; }
                        else if (lines[l] == "") { break; }
                        else { MessageBox.Show("Instead of word end, "+lines[l] + " was found", "Error"); status = -1; }
                        break;
                    case -1:
                        break;
                }
                ++l;
            }
        }
        #endregion


        //button infinite loop
        private void button12_Click(object sender, EventArgs e)
        {
            parsing2(richTextBox1.Text);
        }

        //parsing inside an infinite loop
        #region Infinite
        public void parsing2(string text)
        {
            char[] delimiterChars = { '\n' };
            char[] delimiterChars2 = { ' ', '=', ';', '\t' }; //s 

            string temp;

            string[] lines = text.Split(delimiterChars);

            //text is the "extracted" string
            text = "";

            //removal of all coments
            foreach (string s in lines)
            {
                if (s.Length >= 2) if (!(s[0] == '/' && s[1] == '/'))
                    {
                        temp = s;
                        for (int i = 0; i < s.Length - 1; i++)
                        {
                            if (s[i] == '/' && s[i + 1] == '/') temp = s.Substring(0, i);
                        }
                        text += temp;
                    }
            }

            string x;
            lines = text.Split(delimiterChars2);
            Console.WriteLine(text);
            text = "";

            //step by step checking for linear move
            int l = 0;
            int status = 0;
            while (k == 0)
            {
                while (l < lines.Length)
                {
                    switch (status)
                    {
                        case 0:
                            if (lines[l] == "function") { status = 1; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word function, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case 1:
                            if (lines[l] == "lmove") { status = 2; }
                            else if (lines[l] == "ptp") { status = -2; }
                            else if (lines[l] == "abs") { status = 21; }
                            else if (lines[l] == "gripopen") { OpenGripper(); status = 5; }
                            else if (lines[l] == "gripclose") { CloseGripper(); status = 5; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word lmove, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case 2:
                            if (lines[l] == "begin") { status = 3; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word begin, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case -2:
                            if (lines[l] == "begin") { status = -3; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word begin, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case 21:
                            if (lines[l] == "begin") { status = 31; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word begin, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case 3:
                            //while (l < lines.Length)
                            //{                        
                            switch (lines[l])
                            {
                                case "":
                                    break;
                                case "x":
                                    RelativeMove(0, 3, Convert.ToInt32(lines[++l]) * 10);
                                    break;
                                case "y":
                                    RelativeMove(1, 3, Convert.ToInt32(lines[++l]) * 10);
                                    break;
                                case "z":
                                    RelativeMove(2, 3, Convert.ToInt32(lines[++l]) * 10);
                                    break;
                                case "a":
                                    Rotate(Convert.ToInt32(lines[++l]), 0, 0);
                                    break;
                                case "b":
                                    Rotate(0, Convert.ToInt32(lines[++l]), 0);
                                    break;
                                case "c":
                                    Rotate(0, 0, Convert.ToInt32(lines[++l]));
                                    status = 4;
                                    break;
                                default:
                                    MessageBox.Show("Instead of x,y,z,a,b or c, " + lines[l] + " was found", "Error");
                                    status = -1;
                                    break;
                            }

                            //}                        
                            break;
                        case -3:
                            switch (lines[l])
                            {
                                case "":
                                    break;
                                case "x2":
                                    RelativeMove(0, 3, Convert.ToInt32(lines[++l]) * 10);
                                    break;
                                case "y2":
                                    RelativeMove(1, 3, Convert.ToInt32(lines[++l]) * 10);
                                    break;
                                case "z2":
                                    RelativeMove(2, 3, Convert.ToInt32(lines[++l]) * 10);
                                    break;
                                case "a":
                                    Rotate(Convert.ToInt32(lines[++l]), 0, 0);
                                    break;
                                case "b":
                                    Rotate(0, Convert.ToInt32(lines[++l]), 0);
                                    break;
                                case "c":
                                    Rotate(0, 0, Convert.ToInt32(lines[++l]));
                                    status = -4;
                                    break;
                                default:
                                    MessageBox.Show("Instead of x2,y2,z2,a,b or c, " + lines[l] + " was found", "Error");
                                    status = -1;
                                    break;
                            }
                            break;
                        case 31:
                            //while (l < lines.Length)
                            //{                        
                            switch (lines[l])
                            {
                                case "":
                                    break;
                                case "x1":
                                    ir52c.movehigh_abs(Convert.ToInt32(lines[++l]), 0, 0, 0, 0, 0);
                                    break;
                                case "y1":
                                    ir52c.movehigh_abs(0, Convert.ToInt32(lines[++l]), 0, 0, 0, 0);
                                    break;
                                case "z1":
                                    ir52c.movehigh_abs(0, 0, Convert.ToInt32(lines[++l]), 0, 0, 0);
                                    break;
                                case "a":
                                    ir52c.movehigh_abs(0, 0, 0, Convert.ToInt32(lines[++l]), 0, 0);
                                    break;
                                case "b":
                                    ir52c.movehigh_abs(0, 0, 0, 0, Convert.ToInt32(lines[++l]), 0);
                                    break;
                                case "c":
                                    ir52c.movehigh_abs(0, 0, 0, 0, 0, Convert.ToInt32(lines[++l]));
                                    status = 41;
                                    break;
                                default:
                                    MessageBox.Show("Instead of x,y,z,a,b or c, " + lines[l] + " was found", "Error");
                                    status = -1;
                                    break;
                            }

                            //}                        
                            break;
                        case 4:
                            if (lines[l] == "lmove") { status = 5; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word lmove, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case -4:
                            if (lines[l] == "ptp") { status = 5; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word ptp, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case 41:
                            if (lines[l] == "abs") { status = 5; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word ptp, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case 5:
                            if (lines[l] == "end") { status = 0; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word end, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case -1:
                            break;
                    }
                    ++l;
                }
            }
        }
        #endregion

        //button Stop infinite loop
        private void button13_Click(object sender, EventArgs e)
        {
            k = 1;
        }


        //button parsing certain loop
        private void button14_Click_1(object sender, EventArgs e)
        {
            parsing3(richTextBox1.Text);
        }

        //parsing for a certain number of loops
        #region Certain Loops
        public void parsing3(string text)
        {
            char[] delimiterChars = { '\n' };
            char[] delimiterChars2 = { ' ', '=', ';', '\t' }; //s 

            string temp;

            string[] lines = text.Split(delimiterChars);

            //text is the "extracted" string
            text = "";

            //removal of all coments
            foreach (string s in lines)
            {
                if (s.Length >= 2) if (!(s[0] == '/' && s[1] == '/'))
                    {
                        temp = s;
                        for (int i = 0; i < s.Length - 1; i++)
                        {
                            if (s[i] == '/' && s[i + 1] == '/') temp = s.Substring(0, i);
                        }
                        text += temp;
                    }
            }

            string x;
            lines = text.Split(delimiterChars2);
            Console.WriteLine(text);
            text = "";

            int loop = 0;
            loop = Convert.ToInt32(richTextBox3.Text);

            //step by step checking for linear move
            int l = 0;
            int status = 0;
            while (loop > 0)
            {
                while (l < lines.Length)
                {
                    switch (status)
                    {
                        case 0:
                            if (lines[l] == "function") { status = 1; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word function, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case 1:
                            if (lines[l] == "lmove") { status = 2; }
                            else if (lines[l] == "ptp") { status = -2; }
                            else if (lines[l] == "abs") { status = 21; }
                            else if (lines[l] == "gripopen") { OpenGripper(); status = 5; }
                            else if (lines[l] == "gripclose") { CloseGripper(); status = 5; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word lmove, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case 2:
                            if (lines[l] == "begin") { status = 3; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word begin, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case -2:
                            if (lines[l] == "begin") { status = -3; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word begin, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case 21:
                            if (lines[l] == "begin") { status = 31; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word begin, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case 3:
                            //while (l < lines.Length)
                            //{                        
                            switch (lines[l])
                            {
                                case "":
                                    break;
                                case "x":
                                    RelativeMove(0, 3, Convert.ToInt32(lines[++l]) * 10);
                                    break;
                                case "y":
                                    RelativeMove(1, 3, Convert.ToInt32(lines[++l]) * 10);
                                    break;
                                case "z":
                                    RelativeMove(2, 3, Convert.ToInt32(lines[++l]) * 10);
                                    break;
                                case "a":
                                    Rotate(Convert.ToInt32(lines[++l]), 0, 0);
                                    break;
                                case "b":
                                    Rotate(0, Convert.ToInt32(lines[++l]), 0);
                                    break;
                                case "c":
                                    Rotate(0, 0, Convert.ToInt32(lines[++l]));
                                    status = 4;
                                    break;
                                default:
                                    MessageBox.Show("Instead of x,y,z,a,b or c, " + lines[l] + " was found", "Error");
                                    status = -1;
                                    break;
                            }

                            //}                        
                            break;
                        case -3:
                            switch (lines[l])
                            {
                                case "":
                                    break;
                                case "x2":
                                    RelativeMove(0, 3, Convert.ToInt32(lines[++l]) * 10);
                                    break;
                                case "y2":
                                    RelativeMove(1, 3, Convert.ToInt32(lines[++l]) * 10);
                                    break;
                                case "z2":
                                    RelativeMove(2, 3, Convert.ToInt32(lines[++l]) * 10);
                                    break;
                                case "a":
                                    Rotate(Convert.ToInt32(lines[++l]), 0, 0);
                                    break;
                                case "b":
                                    Rotate(0, Convert.ToInt32(lines[++l]), 0);
                                    break;
                                case "c":
                                    Rotate(0, 0, Convert.ToInt32(lines[++l]));
                                    status = -4;
                                    break;
                                default:
                                    MessageBox.Show("Instead of x2,y2,z2,a,b or c, " + lines[l] + " was found", "Error");
                                    status = -1;
                                    break;
                            }
                            break;
                        case 31:
                            //while (l < lines.Length)
                            //{                        
                            switch (lines[l])
                            {
                                case "":
                                    break;
                                case "x1":
                                    ir52c.movehigh_abs(Convert.ToInt32(lines[++l]), 0, 0, 0, 0, 0);
                                    break;
                                case "y1":
                                    ir52c.movehigh_abs(0, Convert.ToInt32(lines[++l]), 0, 0, 0, 0);
                                    break;
                                case "z1":
                                    ir52c.movehigh_abs(0, 0, Convert.ToInt32(lines[++l]), 0, 0, 0);
                                    break;
                                case "a":
                                    ir52c.movehigh_abs(0, 0, 0, Convert.ToInt32(lines[++l]), 0, 0);
                                    break;
                                case "b":
                                    ir52c.movehigh_abs(0, 0, 0, 0, Convert.ToInt32(lines[++l]), 0);
                                    break;
                                case "c":
                                    ir52c.movehigh_abs(0, 0, 0, 0, 0, Convert.ToInt32(lines[++l]));
                                    status = 41;
                                    break;
                                default:
                                    MessageBox.Show("Instead of x,y,z,a,b or c, " + lines[l] + " was found", "Error");
                                    status = -1;
                                    break;
                            }

                            //}                        
                            break;
                        case 4:
                            if (lines[l] == "lmove") { status = 5; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word lmove, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case -4:
                            if (lines[l] == "ptp") { status = 5; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word ptp, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case 41:
                            if (lines[l] == "abs") { status = 5; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word ptp, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case 5:
                            if (lines[l] == "end") { status = 0; }
                            else if (lines[l] == "") { break; }
                            else { MessageBox.Show("Instead of word end, " + lines[l] + " was found", "Error"); status = -1; }
                            break;
                        case -1:
                            break;
                    }
                    ++l;
                }
                --loop;
            }
        }
        #endregion

        private void button30_Click(object sender, EventArgs e)
        {
            //ir52c.init("gotohome"); //Old method, doing a partial initialization
            ir52c.movehigh_abs(0, 0, 857, 0, 90, 0);
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            double tempMidX;
            double tempMidY;


            if ((ws.IRState.IRSensors[0].Found) & (ws.IRState.IRSensors[1].Found))
            {
                n++;
                difMidPX[n] = (ws.IRState.Midpoint.X) * 200;
                difMidPY[n] = (ws.IRState.Midpoint.Y) * 200;
                if (n >= 2)
                {
                    tempMidX = difMidPX[n] - difMidPX[n - 1];
                    tempMidY = difMidPY[n] - difMidPY[n - 1];
                    label47.Text = tempMidX.ToString();
                    label50.Text = tempMidY.ToString();
                    if (tempMidX > tempMidY)
                    {
                        if (tempMidX > 0)
                        {
                            ir52c.movehigh_rel(0, -10, 0, 0, 0, 0);
                        }
                        if (tempMidX < 0)
                        {
                            ir52c.movehigh_rel(0, 10, 0, 0, 0, 0);
                        }
                    }
                    if (tempMidY > tempMidX)
                    {
                        if (tempMidY > 0)
                        {
                            ir52c.movehigh_rel(0, 0, 10, 0, 0, 0);
                        }
                        if (tempMidY < 0)
                        {
                            ir52c.movehigh_rel(0, 0, -10, 0, 0, 0);
                        }
                    }
                }

                // difMidPY[n] = (ws.IRState.Midpoint.Y) * 200;
                //if (n >= 2)
                //{
                //   tempMidY = difMidPY[n] - difMidPY[n - 1];
                //  if (tempMidY > 0)
                // {
                //     ir52c.movehigh_rel(0, 0, 10, 0, 0, 0);
                // //ir52c.movehigh_rel(0, 0, (int)zstep.Value * ((int)tempMidY * 100), 0, 0, 0);
                // //RelativeMove(2, 3, (int)zstep.Value * ((int)tempMidY * 100));
                // }
                //if (tempMidY < 0)
                // {
                //   ir52c.movehigh_rel(0, 0, -10, 0, 0, 0);
                //   //ir52c.movehigh_rel(0, 0, (int)zstep.Value * ((int)tempMidY * 100), 0, 0, 0);
                //  //RelativeMove(2, 3, (int)zstep.Value * ((int)tempMidY * 100));
                // }
                //  label50.Text = tempMidY.ToString();
                // }
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label51.Text = ws.AccelState.Values.X.ToString();
            if (ws.AccelState.Values.X > 0)
            {
                ir52c.movehigh_rel(0, 0, 0, 30, 0, 0);
            }

            if (ws.AccelState.Values.X < 0)
            {
                ir52c.movehigh_rel(0, 0, 0, -30, 0, 0);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (ws.ButtonState.B)
            {

                GripStatus = !GripStatus;
                if (GripStatus == true)
                {
                    CloseGripper();
                }
                else
                {
                    OpenGripper();
                }

            }




        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (ws.ButtonState.Up)
            {
                ir52c.movehigh_rel(50, 0, 0, 0, 0, 0);
            }

            if (ws.ButtonState.Down)
            {
                ir52c.movehigh_rel(-50, 0, 0, 0, 0, 0);
            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            double tempMidY;

            n++;
            difMidPY[n] = (ws.IRState.Midpoint.Y) * 200;
            if (n >= 2)
            {

                tempMidY = difMidPY[n] - difMidPY[n - 1];
                label50.Text = tempMidY.ToString();

                if (tempMidY > 0)
                {

                    ir52c.movehigh_rel(0, 0, 0, 0, 30, 0);
                }
                if (tempMidY < 0)
                {
                    ir52c.movehigh_rel(0, 0, 0, 0, -30, 0);
                }
            }
        }
    }
}
