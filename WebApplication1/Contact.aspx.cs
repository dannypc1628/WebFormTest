using System;
using System.Collections.Generic;
using System.Web.UI;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var productA = new List<ItemProperty>()
            {
                new ItemProperty()
                {
                    ProductId = 1,
                    Order = 1,
                    PropertyType = "string",
                    PropertyName = "名稱",
                    MaxLength = 4
                },
                new ItemProperty()
                {
                    ProductId = 1,
                    Order = 2,
                    PropertyType = "string",
                    PropertyName = "SN",
                    MaxLength = 4
                },
                new ItemProperty()
                {
                    ProductId = 1,
                    Order =3,
                    PropertyType = "string",
                    PropertyName = "類型",
                    MaxLength = 4
                },
                new ItemProperty()
                {
                    ProductId = 1,
                    Order = 4,
                    PropertyType = "string",
                    PropertyName = "名稱",
                    MaxLength = 5
                },
                new ItemProperty()
                {
                    ProductId = 1,
                    Order = 4,
                    PropertyType = "int",
                    PropertyName = "名稱",
                    MaxLength = 5
                }
            };
        }

        public class ItemProperty
        {
            public int ProductId { get; set; }

            public int Order { get; set; }

            public string PropertyType { get; set; }

            public string PropertyName { get; set; }
            public bool IsRequired { get; set; }
            public int? MaxLength { get; set; }
            public int? MinLength { get; set; }
            public int? Max { get; set; }
            public int? Min { get; set; }
        }
    }
}