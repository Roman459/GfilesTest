using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;



namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

       

        protected void TreeView1_SelectedNodeChanged1(object sender, EventArgs e)
        {
            TextBox2.Text = TreeView1.SelectedNode.Text;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
           
            TreeNode NODE = new TreeNode();
            NODE.Text = TextBox1.Text;

            TreeView1.Nodes.Add(NODE);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TreeNode NODE2 = new TreeNode();
            NODE2.Text = TextBox1.Text;

            TreeView1.SelectedNode.ChildNodes.Add(NODE2);
            
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
           
            if (TreeView1.Nodes.Contains(TreeView1.SelectedNode))
            {
                TreeView1.Nodes.Remove(TreeView1.SelectedNode);
            }
            else 
            { 
                TreeView1.SelectedNode.Parent.ChildNodes.Remove(TreeView1.SelectedNode);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           TreeView1.SelectedNode.Text = TextBox2.Text;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

       

       
      

        
        
    }
}
