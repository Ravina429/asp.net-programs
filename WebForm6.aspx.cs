using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;

            n1=Convert.ToInt32(TextBox1.Text);
            n2=Convert.ToInt32(TextBox2.Text);
            n3=Convert.ToInt32(TextBox3.Text);

            if(n1<n2 && n1<n3)
            {
                Label1.Text = "Smaller no is =" + n1;
            }
            if(n2<n3 && n2<n1)
            {
                Label1.Text = "Smaller no is =" + n2;
            }
            if(n3<n2 && n3<n1)
            {
                Label1.Text = "Smaller no is =" + n3;
            }
        }
    }
}