<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeBehind="Default.aspx.vb" Inherits="WebApplication2._Default" %>

<%@ Register assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
	<h2>
		Welcome to ASP.NET!
	</h2>
	<div style="padding:15px;">



		<dx:ASPxDocumentViewer ID="ASPxDocumentViewer1" runat="server" 
			ReportTypeName="WebApplication2.XtraReport1">
		</dx:ASPxDocumentViewer>



	</div>

	</p>
</asp:Content>