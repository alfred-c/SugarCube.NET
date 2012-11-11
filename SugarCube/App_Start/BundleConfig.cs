using System.Web;
using System.Web.Optimization;

namespace SugarCube
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/Content/themes/custom-theme/css").Include(
                        "~/Content/themes/custom-theme/jquery-ui-1.8.16.custom.css"));

            bundles.Add(new StyleBundle("~/Content/themes/custom-theme/css-ie").Include(
                        "~/Content/themes/custom-theme/jquery.ui.1.8.16.ie.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                "~/Content/bootstrap-noicon.css",
                "~/Content/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap-responsive").Include(
                "~/Content/bootstrap-responsive.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/isotope").Include(
                "~/Scripts/jquery.isotope.js"));

            bundles.Add(new ScriptBundle("~/bundles/ckeditor").Include(
                "~/Scripts/ckeditor/ckeditor.js"));

            bundles.Add(new ScriptBundle("~/bundles/textchange").Include(
                "~/Scripts/textchange.js"));

            bundles.Add(new ScriptBundle("~/bundles/autoellipsis").Include(
                "~/Scripts/jquery.autoellipsis.js"));

            bundles.Add(new ScriptBundle("~/bundles/calendarPicker").Include(
                "~/Scripts/calendarPicker/jquery.calendarpicker.js",
                "~/Scripts/calendarPicker/jquery.mousewheel.js"));

            bundles.Add(new StyleBundle("~/Content/calendarPicker").Include(
                "~/Scripts/calendarPicker/jquery.calendarPicker.css"));
        }
    }
}