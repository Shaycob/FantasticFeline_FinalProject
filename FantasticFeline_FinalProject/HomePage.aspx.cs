using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FantasticFeline_FinalProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void CalendarControl_DayRender(object sender, DayRenderEventArgs e)
        {
            e.Cell.ForeColor = System.Drawing.Color.White;
            e.Cell.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
        }

        protected void RedirectToGoogle(object sender, EventArgs e)
        {
            Response.Redirect("https://www.google.com");
        }

        protected void RedirectToMeta(object sender, EventArgs e)
        {
            Response.Redirect("https://about.facebook.com/meta/");
        }

        protected void RedirectToOracle(object sender, EventArgs e)
        {
            Response.Redirect("https://www.oracle.com");
        }

        protected void RedirectToMicrosoft(object sender, EventArgs e)
        {
            Response.Redirect("https://www.microsoft.com");
        }

        protected void RedirectToNvidia(object sender, EventArgs e)
        {
            Response.Redirect("https://www.nvidia.com");
        }

        protected void RedirectToPayPal(object sender, EventArgs e)
        {
            Response.Redirect("https://www.paypal.com");
        }
    }
}