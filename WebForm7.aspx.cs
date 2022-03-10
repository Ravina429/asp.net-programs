using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name, desig;
            name = TextBox1.Text;
            desig = TextBox1.Text;

            Label1.Text = "employee name is:- " + name;

            int bs, total = 0;

            bs=Convert.ToInt32(TextBox1.Text);

            if(desig=="manager")
            {
                Label2.Text = "Bonous is 5000";
                total = bs + 5000;
                Label3.Text = "Total salary is:- " + total;
            }

            else if (desig == "clerk")
            {
                Label2.Text = "Bonous is 2000";
                total = bs + 2000;
                Label3.Text = "Total salary is:- " + total;
            }
            else if (desig == "peon")
            {
                Label2.Text = "Bonous is 1000";
                total = bs + 1000;
                Label3.Text = "Total salary is:- " + total;
            }
        }
    }
}