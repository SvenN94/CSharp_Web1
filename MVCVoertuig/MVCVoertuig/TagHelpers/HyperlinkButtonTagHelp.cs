﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVCVoertuig.TagHelpers
{
    [HtmlTargetElement("a", Attributes = "button-color")]
    public class HyperlinkButtonTagHelp : TagHelper
    {

        public string ButtonColor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"btn btn-{ButtonColor}");
        }
    }
}
