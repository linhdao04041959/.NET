using System.Web.UI;
using System.Web.UI.WebControls;

namespace Foodie.User
{
    public partial class Payment : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr, drl;
        DataTable dt;
        SqlTransaction transaction = null;

        string name = string.Empty;
        string cardno = string.Empty;
        string expiryDate = string.Empty;
        string cvv = string.Empty;
        string address = string.Empty;
        string paymentMode = string.Empty;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["userId"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void lbCardSubmit_Click(object sender, EventArgs e)
        {
        }

        protected void lbCodSubmit_Click(object sender, EventArgs e)
        {
        }
    }
}