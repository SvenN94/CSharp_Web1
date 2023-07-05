﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using MVCVoertuig.Data;
using System.Text;

namespace MVCVoertuig.TagHelpers
{
    [HtmlTargetElement("car-info")]
    public class CarInfoTagHelper :TagHelper
    {
        [HtmlAttributeName("merk")]
        public string Merk { get; set; }
        VoertuigDbContext _context;
        public CarInfoTagHelper(VoertuigDbContext context)
        {
            _context = context;
        }

        private int GetCarCount()
        {
            int count = 0;
            if (string.IsNullOrEmpty(Merk))
            {
                count = _context.Voertuigen.Count();
            }
            else
            {
                count = _context.Voertuigen.Where(x => x.Merk == Merk).Count();
            }
            return count;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetHtmlContent(GetHtmlText());
        }
        private string GetHtmlText()
        {
            StringBuilder html = new StringBuilder();
            html.Append("<button type='button' class= 'btn border-primary m-2')>");
            html.Append("Aantal voertuigen");
            html.Append("<span class='badge bg-primary'>");
            html.Append($"{GetCarCount()}");
            html.Append("</span>");
            html.Append("</button>");
            return html.ToString();
        }
    }
}
