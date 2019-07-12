<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">




    <div class="jumbotron">
        <h1>Feeds Subscriber</h1>
        <p class="lead">Please enter the subscription service below and hit search:</p>
        <p>            
            <input class="input" id="SearchTxt" runat="server" value="http://news.google.fr/nwshp?hl=fr&tab=wn&output=rss"/>            
        </p>        
        <p>
            <a class="btn btn-default" href="#" runat="server" onServerClick="SearchFeeds_Click">Search &raquo;</a>            
        </p>
    </div>

    <div class="row">
        <div class="col-md-6">
            <h2>Feed Items</h2>
            <div runat="server" id="FeedItems" style="border:double;overflow:auto;height:400px"/>
            
        </div>
        <div class="col-md-6">
            <h2>Feed Detail</h2>
            <div runat="server" id="display" style="border:double;overflow:auto;height:400px">
                <iframe name="display" src="about:blank" style="display: block;width: 100%;height: 100%;border: none;"></iframe>
            </div>
        </div>        
    </div>
</asp:Content>
