using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPaneUI
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;

        public Form1()
        {
            InitializeComponent();
            OutlookUI();
        }


        public void OutlookUI()
        {
            // Create an instance of each control being used.
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            // Insert code here to hook up event methods.

            // Set properties of TreeView control.
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Width = this.ClientSize.Width / 3;
            this.treeView1.TabIndex = 0;
            this.treeView1.Nodes.Add("treeView");

            // Set properties of ListView control.
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.Height = this.ClientSize.Height * 2 / 3;
            this.listView1.TabIndex = 0;
            this.listView1.Items.Add("listView");

            // Set properties of RichTextBox control.
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "richTextBox1";

            // Set properties of Panel's Splitter control.
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            // Width is irrelevant if splitter is docked to Top.
            this.splitter2.Height = 3;
            // Use a different color to distinguish the two splitters.
            this.splitter2.BackColor = Color.Blue;
            this.splitter2.TabIndex = 1;
            // Set TabStop to false for ease of use when negotiating
            // the user interface.
            this.splitter2.TabStop = false;

            // Set properties of Form's Splitter control.
            this.splitter1.Location = new System.Drawing.Point(121, 0);
            this.splitter1.Size = new System.Drawing.Size(3, 273);
            this.splitter1.BackColor = Color.Red;
            this.splitter1.TabIndex = 1;
            // Set TabStop to false for ease of use when negotiating
            // the user interface.
            this.splitter1.TabStop = false;

            // Add the appropriate controls to the Panel.
            // The order of the controls in this call is critical.
            this.panel1.Controls.AddRange(new System.Windows.Forms.Control[]
               {richTextBox1, splitter2, listView1});

            // Set properties of Panel control.
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.TabIndex = 2;

            // Add the rest of the controls to the form.
            // The order of the controls in this call is critical.
            this.Controls.AddRange(new System.Windows.Forms.Control[]
               {panel1, splitter1, treeView1});
            this.Text = "Intricate UI Example";
        }
    }
}
