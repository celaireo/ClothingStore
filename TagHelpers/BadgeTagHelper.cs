using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ClothingStore.TagHelpers
{
    [HtmlTargetElement("badge")]
    public class BadgeTagHelper : TagHelper
    {
        public string Text { get; set; } = string.Empty;
        public string Variant { get; set; } = "primary";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.Attributes.SetAttribute("class", $"badge bg-{Variant}");
            output.Content.SetContent(Text);
        }
    }
}