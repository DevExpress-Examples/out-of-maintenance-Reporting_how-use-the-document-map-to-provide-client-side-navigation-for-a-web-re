using System;
using DevExpress.XtraReports.Web;
// ...

namespace WebDocumentMap {
    public partial class _Default : System.Web.UI.Page {

        protected override void OnPreRender(EventArgs e) {
            SiteMapBookmarkFiller.FillSiteMapWithBookmarks(ASPxSiteMapDataSource1, 
                ReportViewer1);
            base.OnPreRender(e);
        }


    }
}



