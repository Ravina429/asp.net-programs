using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int n1, n2, n3, total ;
            float per;
            string grade;
            n1 = Convert.ToInt32(TextBox1.Text);
            n2 = Convert.ToInt32(TextBox2.Text);
            n3 = Convert.ToInt32(TextBox3.Text);
            
            total = n1 + n2 + n3;
            Label1.Text = "Total Sub Marks=" + total;

            per = (total / 300f)* 100f;
            Label2.Text = "Percentage=" + per;

            if(per>=85)
            {
                Label3.Text= " grade  'A'";
            }
            else if(per>35 && per<84)
            {
                Label3.Text = " grade  'B'";
            }
            else
            {
                Label3.Text = " grade  'C'";
            }
            

        }
    }
}