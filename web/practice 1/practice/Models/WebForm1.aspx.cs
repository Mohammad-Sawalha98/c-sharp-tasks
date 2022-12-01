using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practice.Models
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "juguk";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = "hello welcome hoooome";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label malik=new Label();
            this.Controls.Add( malik);
            malik.Text = "hello welcome hooooooooooome";
        }
    }
}