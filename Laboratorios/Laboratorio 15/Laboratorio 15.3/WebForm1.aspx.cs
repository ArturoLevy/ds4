<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio__15._3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            String texto = TextBox1.Text;
            Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "MessageBox", "window.alert('Hola: " + texto + "');", true);
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio__15._3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            String texto = TextBox1.Text;
            Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "MessageBox", "window.alert('Hola: " + texto + "');", true);
        }
    }
>>>>>>> 3508c144e3f7c6cb28bcb432fc83f806220353a7
}