using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Optimization;

namespace JMHermanosMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // Plugin and main ===============================================
            var plugingAndMain = new ScriptBundle("~/bundles/PluginAndMain").Include(
                    //Plugins here ----------------
                    "~/Scripts/bootstrap.min.js"
                    //------------------------------------

                    // Main here----------------------------
                    // -------------------------------------
                    );
            plugingAndMain.Orderer = new PassthruBundleOrderer();
            bundles.Add(plugingAndMain);

            // Styles ===============================================
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/normalize.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.css",
                      "~/Content/backToTop.css",
                      "~/Content/main.css"
                      ));
        }
    }

    public class PassthruBundleOrderer : IBundleOrderer
    {
        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            return files;
        }
    }
}
