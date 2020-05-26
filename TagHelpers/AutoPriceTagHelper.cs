using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelpers.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("auto-price")]
    public class AutoPriceTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]
        public string NotBoundId { get; set; }

        [HtmlAttributeName("model-name")]
        public string Model { get; set; }

        public string Make { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            String result = String.Format("<p>Model: {0}</p><p>Make: {1}</p>", Model, Make);
            output.Content.SetHtmlContent(result);
            output.TagName = "div";
        }
    }
}
