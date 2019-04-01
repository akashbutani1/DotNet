using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        akash.WebService1 ws = new akash.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            lblresult.Text = ws.Add(Convert.ToInt16(txtbox1.Text), Convert.ToInt16(txtbox2.Text)).ToString();
        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            lblresult.Text = ws.Sub(Convert.ToInt16(txtbox1.Text), Convert.ToInt16(txtbox2.Text)).ToString();
        }

        protected void btnmul_Click(object sender, EventArgs e)
        {
            lblresult.Text = ws.Mul(Convert.ToInt16(txtbox1.Text), Convert.ToInt16(txtbox2.Text)).ToString();
        }

        protected void btndiv_Click(object sender, EventArgs e)
        {
            lblresult.Text = ws.Div(Convert.ToInt16(txtbox1.Text), Convert.ToInt16(txtbox2.Text)).ToString();
        }
    }
}