using System;
using System.Collections.Generic;
using System.Web.UI;
using WebApplication1.Model;
using WebApplication1.Service;

namespace WebApplication1
{
    public partial class About : Page
    {
        private List<Card> Cards
        {
            get
            {
                if (_cards == null)
                {
                    var temp = (List<Card>)Session["Cards"] ?? new List<Card>();
                    _cards = temp;
                }

                return _cards;
            }
            set
            {
                if (value != null)
                {
                    _cards = value;
                    Session["Cards"] = _cards;
                }
            }
        }

        private List<Card> _cards;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Initionation();
            }
        }

        private void Initionation()
        {
            Cards = new List<Card>
            {
                new Card()
                {
                    Title = "AAA",
                    Content = "AAAAA"
                },
                new Card()
                {
                    Title = "BBB",
                    Content = "BBBBBBBB"
                },
                new Card()
                {
                    Title = "CCC",
                    Content = "CCCCCCCC"
                }
            };

            CreateCardTemplates();
        }

        private void CreateCardTemplates()
        {
            Panel1.Controls.Clear();
            foreach (var card in Cards)
            {
                var uc = (UserControl.CardTemplate)LoadControl("UserControl/CardTemplate.ascx");
                uc.Card = card;
                Panel1.Controls.Add(uc);
            }
        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            var card = new Card()
            {
                Title = TitleTextBox.Text,
                Content = ContentTextBox.Text
            };
            Cards.Add(card);
            CreateCardTemplates();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var ws = new ExeclService();
            ws.SetExcel(@"C:\Users\h1520\source\repos\WebFormTest\WebApplication1\Test.xlsx");

        }
    }
}