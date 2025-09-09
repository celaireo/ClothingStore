using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Globalization;

namespace ClothingStore.TagHelpers
{
    [HtmlTargetElement("price")]
    public class PriceTagHelper : TagHelper
    {
        public decimal Value { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.Content.SetContent(Value.ToString("C", CultureInfo.CurrentCulture));
            output.Attributes.SetAttribute("class", "text-success fw-bold");
        }
    }
}