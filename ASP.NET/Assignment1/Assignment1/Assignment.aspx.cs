using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class Assignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "Select Num", "One", "Two", "Three", "Four", "Five" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "One")
            {
                Label1.Text = "Rs 54000";
            }
            else if (DropDownList1.Text == "Two")
            {
                Label1.Text = "Rs 56000";
            }
            else if (DropDownList1.Text == "Three")
            {
                Label1.Text = "Rs 58000";
            }
            else if (DropDownList1.Text == "Four")
            {
                Label1.Text = "Rs 60000";
            }
            else if (DropDownList1.Text == "Five")
            {
                Label1.Text = "Rs 62000";
            }
            else
                Label1.Text = "";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".png";
        }
    }
}