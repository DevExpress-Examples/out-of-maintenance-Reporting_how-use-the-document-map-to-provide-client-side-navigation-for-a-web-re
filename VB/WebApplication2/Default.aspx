﻿<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeBehind="Default.aspx.vb" Inherits="WebApplication2._Default" %>

<%@ Register assembly="DevExpress.XtraReports.v11.1.Web, Version=11.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
	<h2>
		Welcome to ASP.NET!
	</h2>
	<div style="padding:15px;">

		<dx:ReportToolbar ID="ReportToolbar1" runat="server" 
			ReportViewerID="ReportViewer1" ShowDefaultButtons="False">
			<Items>
				<dx:ReportToolbarButton ItemKind="Search" />
				<dx:ReportToolbarSeparator />
				<dx:ReportToolbarButton ItemKind="PrintReport" />
				<dx:ReportToolbarButton ItemKind="PrintPage" />
				<dx:ReportToolbarSeparator />
				<dx:ReportToolbarButton Enabled="False" ItemKind="FirstPage" />
				<dx:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" />
				<dx:ReportToolbarLabel ItemKind="PageLabel" />
				<dx:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
				</dx:ReportToolbarComboBox>
				<dx:ReportToolbarLabel ItemKind="OfLabel" />
				<dx:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
				<dx:ReportToolbarButton ItemKind="NextPage" />
				<dx:ReportToolbarButton ItemKind="LastPage" />
				<dx:ReportToolbarSeparator />
				<dx:ReportToolbarButton ItemKind="SaveToDisk" />
				<dx:ReportToolbarButton ItemKind="SaveToWindow" />
				<dx:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
					<elements>
						<dx:ListElement Value="pdf" />
						<dx:ListElement Value="xls" />
						<dx:ListElement Value="xlsx" />
						<dx:ListElement Value="rtf" />
						<dx:ListElement Value="mht" />
						<dx:ListElement Value="html" />
						<dx:ListElement Value="txt" />
						<dx:ListElement Value="csv" />
						<dx:ListElement Value="png" />
					</elements>
				</dx:ReportToolbarComboBox>
			</Items>
			<styles>
				<LabelStyle><Margins MarginLeft='3px' MarginRight='3px' /></LabelStyle>
			</styles>
		</dx:ReportToolbar>
		<br />

		<table border="0" cellpadding="10" cellspacing="0">
		<tr>
		<td valign="top"><dx:ReportDocumentMap ID="ReportDocumentMap1" runat="server" 
			ReportViewerID="ReportViewer1">
		</dx:ReportDocumentMap>
		</td>
		<td valign="top">
		<dx:ReportViewer ID="ReportViewer1" runat="server" 
			Report="<%#New WebApplication2.XtraReport1()%>" 
			ReportName="WebApplication2.XtraReport1">
		</dx:ReportViewer>
		</td>
		</tr>
		</table>

	</div>

	</p>
</asp:Content>