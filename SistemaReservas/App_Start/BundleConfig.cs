
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/Professor").Include(
                     "~/Scripts/Professor.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/ReservaGeral.css",
                       "~/Content/Componentes.css"
                                 ));
            bundles.Add(new StyleBundle("~/Content/bootv4/css").Include(
                 "~/Content/bootv4/bootstrapv4.min.css",
                   "~/Content/bootv4/font-awesome.min.css",
                     "~/Content/bootv4/FooterForm.css",
                      "~/Content/bootv4/sb-admin.css"
                       ));
        }
    }
}