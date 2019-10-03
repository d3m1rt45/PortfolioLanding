using System.Web;
using System.Web.Optimization;

namespace OnlinePortfolio
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jQuery/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jQuery/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Modernizr/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/smoothScroll").Include(
                        "~/Scripts/smooth-scroll.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Bootstrap/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                      "~/Content/FontAwesome/all.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Bootstrap/bootstrap.min.css",
                      "~/Content/AnimateCSS/animate.css",
                      "~/Content/HoverCSS/hover.css",
                      "~/Content/site.css"));
        }
    }
}
