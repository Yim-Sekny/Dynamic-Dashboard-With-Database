using System.Web;
using System.Web.Optimization;

namespace DynamicWidgetDashboard
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-3.2.1.min.js",
                    "~/Content/chart-js/js/chart.min.js",
                    "~/Content/gridstack/js/jquery-ui.min.js",
                    "~/Content/gridstack/js/lodash.min.js",
                    "~/Content/gridstack/js/knockout-min.js",
                    "~/Content/gridstack/js/gridstack.js",
                    "~/Content/gridstack/js/gridstack.jQueryUI.js",
                    "~/Content/gridstack/js/gridstack-directive.js",
                    "~/Scripts/angular.min.js"
                    ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap/css/bootstrap.min.css",
                "~/Content/common.css",
                "~/Content/gridstack/css/gridstack.css",
                "~/Scripts/angular-csp.css"
                ));
            // bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        // "~/Scripts/jquery-{version}.js"));

            // bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        // "~/Scripts/jquery.validate*"));

            // // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            // bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        // "~/Scripts/modernizr-*"));

            // bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      // "~/Scripts/bootstrap.js",
                      // "~/Scripts/respond.js"));

            // bundles.Add(new StyleBundle("~/Content/css").Include(
                      // "~/Content/bootstrap.css",
                      // "~/Content/site.css"));
        }
    }
}
