
using System.Web.Optimization;

namespace SistemaReservas
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new ScriptBundle("~/bundles/Admin").Include(
                   "~/Scripts/ace-elements.min.js" ,
                      "~/Scripts/jquery-2.1.4.min.js",
                   "~/Scripts/ace.min.js",
                   
                  
                     "~/Scripts/Professor.js"));

          


            bundles.Add(new StyleBundle("~/Content/bootv4/css").Include(
                 "~/Content/bootv4/bootstrapv4.min.css",
                   "~/Content/bootv4/font-awesome.min.css",
                     "~/Content/bootv4/FooterForm.css",
                      "~/Content/bootv4/sb-admin.css"));
          
            bundles.Add(new StyleBundle("~/Content/template").Include(
                 "~/Content/ace-part2.min.css",
                   "~/Content/ace-rtl.min.css",
                     "~/Content/ace-skins.min.css",
                      "~/Content/ace.min.css",
                       "~/Content/bootstrap.min.css",
                     "~/Content/font-awesome.min.css",
                      "~/Content/fonts.googleapis.com.css"
                       ));
        }
    }
}