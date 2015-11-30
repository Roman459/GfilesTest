using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(textBox1.Text);
           // treeView1.Nodes[1].Nodes.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //treeView1.Nodes.Clear();
            //textBox1.Text = treeView1.Nodes.IndexOfKey;
           // treeView1.Nodes.IndexOf() = label1.Text;
           // TreeNode n = treeView1.SelectedNode;
             //label1.Text = Convert.ToString(n);
            //textBox2.AppendText(Convert.ToString(n));
           // treeView1.Nodes[0].Text = textBox2.Text;
            //treeView1.SelectedNode.Text = textBox2.Text;
            panel1.Visible = true;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(textBox1.Text);
            
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            textBox2.Clear();
           textBox2.AppendText(e.Node.Text);
            
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void treeView1_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Text = textBox2.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {


            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;

            treeView1.Nodes.Clear();

            using (Stream file = File.Open(fileName, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                object obj = bf.Deserialize(file);

                TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
                treeView1.Nodes.AddRange(nodeList);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fileName = saveFileDialog1.FileName;
            
            using (Stream file = File.Open(fileName, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, treeView1.Nodes.Cast<TreeNode>().ToList());
            }
        }

       

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

    }
}
