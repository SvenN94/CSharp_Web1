using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MVCSportStore.Models;

namespace MVCSportStore.TagHelpers
{
    [HtmlTargetElement("page-link", Attributes="paging-info")]
    public class PageLinkTagHelpr
    {
        public PagingInfo PagingInfo { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.AppendHtml(GetPaginationLinks(PagingInfo));
        }
        private TagBuilder GetPaginationLinks(PagingInfo pagingInfo)
        {
            TagBuilder ul = new TagBuilder("ul");
            ul.Attributes["class"] = "pagination";
            for (int page = 1; page <= pagingInfo.TotalPages; page++)
            {
                ul.InnerHtml.AppendHtml(
                    GetPaginationLink(page, page == pagingInfo.CurrentPage));
            }
            return ul;
        }
        private TagBuilder GetPaginationLink (int page, bool active)
        {
            string pageLinkActive = "btn border border-primary";
            string pageLink = "btn border border-secondary";
            TagBuilder li = new TagBuilder("li");
            li.Attributes["class"] = "page-item";
            TagBuilder a = new TagBuilder("a");
            a.Attributes["class"] = (active) ? pageLinkActive : pageLink;
            a.Attributes["href"] = $"/Home.Index/{page}";
            a.Attributes["title"]=$"Click to go page {page}";
            a.InnerHtml.Append($"{page}");
            li.InnerHtml.AppendHtml(a);
            return li;

        }

    }
}
