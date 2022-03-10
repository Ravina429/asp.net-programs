using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string day;
            int n = 0;
            n=Convert.ToInt32(TextBox1.Text);

            switch(n)
            {
                case 1:
                    Label1.Text = "monday";
                    break;
                    case 2:
                    Label1.Text = "tuesday";
                    break ;
                    case 3:
                    Label1.Text = "wednesday";
                    break;
                case 4:
                    Label1.Text = "thursday";
                    break;
                case 5:
                    Label1.Text = "friday";
                    break;
                case 6:
                    Label1.Text = "saturday";
                    break;
                case 7:
                    Label1.Text = "sunday";
                    break;
                    
            }
        }
    }
}