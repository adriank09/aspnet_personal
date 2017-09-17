using System.Web;
using System.Web.Optimization;

namespace AdrianKhor
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            const string bowerComponents = "~/bower_components";
            string[] scripts = 
            {
                bowerComponents + "/jQuery/dist/jquery.js",
                bowerComponents + "/bootstrap/dist/js/bootstrap.js",
                bowerComponents + "/popper.js/dist/popper.js",
                bowerComponents + "/popper.js/dist/popper-utils.js",
                bowerComponents + "/vue/dist/vue.js"
            };
            string[] styles =
            {
                bowerComponents + "/bootstrap/dist/css/bootstrap.css",
                bowerComponents + "/font-awesome/css/font-awesome.css"
            };

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(scripts));
            bundles.Add(new ScriptBundle("~/bundles/styles").Include(styles));


            
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
                      
        }
    }
}
