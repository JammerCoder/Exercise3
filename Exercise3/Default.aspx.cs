using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuess_Click(object sender, EventArgs e)
        {
            //if(this.txtName.Text == "Mary" ||this.txtName.Text == "MaryAnn" ||this.txtName.Text == "MARYANN" ||this.txtName.Text == "Ginger")
            //{
            //    if (this.txtName.Text == "Mary")
            //        this.lblResult.Text = "Sort Of...";

            //    if (this.txtName.Text == "MaryAnn")
            //        this.lblResult.Text = "Maybe?";

            //    if (this.txtName.Text == "MARYANN")
            //        this.lblResult.Text = "YES!";

            //    if (this.txtName.Text == "Ginger")
            //        this.lblResult.Text = "AWESOME!";
            //}
            //else
            //    this.lblResult.Text = "NO!";

            switch(this.txtName.Text)
            {
                case "Mary":
                    this.lblResult.Text = "Sort Of...";
                    break;

                case "MaryAnn":
                    this.lblResult.Text = "Maybe?";
                    break;

                case "MARYANN":
                    this.lblResult.Text = "YES!";
                    break;

                case "Ginger":
                    this.lblResult.Text = "AWESOME!";
                    break;

                default:
                    this.lblResult.Text = "NO!";
                    break;
            }

        }
    }
}