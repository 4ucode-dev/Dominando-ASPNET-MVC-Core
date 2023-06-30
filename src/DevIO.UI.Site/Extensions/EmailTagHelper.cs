using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DevIO.UI.Site.Extensions;

public class EmailTagHelper : TagHelper
{
    public string EmailDomain { get; set; } = "desenvolvedor.io";
    override public async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var content = await output.GetChildContentAsync();
        var target = content.GetContent() + "@" + EmailDomain;

        output.TagName = "a";
        output.Attributes.SetAttribute("href", $"mailto:{target}");
        output.Content.SetContent(target);
    }
}
