using System;
using System.Web.UI;
using System.Web.UI.WebControls;
// Name: Jacob Farrell, Chase Detrick, Matthew Boutros, Andrew Rozsits
// email:  farrelcj @mail.uc.edu, detriccg @mail.uc.edu, boutromw @mail.uc.edu, rozsitaj @mail.uc.edu
// Assignment Number: Assignment 11/ Final Project
// Due Date:   12 / 12 / 2024
// Course #/Section:   IS3050 (002)
// Semester / Year:   Fall 2024
// Brief Description of the assignment:  This is our final project for IS3050, in this project we recreated the website LeetCode. Each member of our team solved and created code from the hard section 
//                                        of LeetCode. Utilizing github we created a our own version of LeetCode.
// Brief Description of what this module does. This module demonstrates our ability to collaboratively work on creating a functional website.
// Citations: chatgpt.com, stackoverflow.com
// Anything else that's relevant:
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
