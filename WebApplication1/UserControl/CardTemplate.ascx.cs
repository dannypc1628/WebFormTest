using System;

namespace WebApplication1.UserControl
{
    public partial class CardTemplate : System.Web.UI.UserControl
    {
        public Model.Card Card { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Title.Text = Card.Title;
            Content.Text = Card.Content;
        }
    }
}