using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Web.UI.HtmlControls;

public partial class _Default : Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    private string GetAlbumRSS(SyndicationItem album) {
        string url = "";
        foreach(SyndicationElementExtension ext in album.ElementExtensions)
            if(ext.OuterName == "itemRSS") url = ext.GetObject<string>();
                return (url);
    }

    protected void Visualize_Click(object sender, EventArgs e) {
        var href = ((System.Web.UI.HtmlControls.HtmlAnchor)sender).HRef;

        display.InnerHtml = "<iframe style='width:100%;height:100%;' frameborder='0' src='" + href + "'/>";
    }

    protected void SearchFeeds_Click(object sender, EventArgs e) {
        using(XmlReader reader = XmlReader.Create(SearchTxt.Value)) {
            SyndicationFeed feeds = SyndicationFeed.Load(reader);

            string albumRSS;

            foreach(SyndicationItem feed in feeds.Items) {
                FeedItems.InnerHtml = FeedItems.InnerHtml + string.Format("<br \'><a href='{0}' disabled='disabled' target='display' runtat='server' onServerClick='Visualize_Click'>{1}</a>", feed.Links[0].Uri, feed.Title.Text);
                albumRSS = GetAlbumRSS(feed);
            }
        }
    }
}