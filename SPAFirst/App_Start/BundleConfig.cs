using System.Web;
using System.Web.Optimization;

namespace SPAFirst
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js",
					  "~/Scripts/respond.js"));


			bundles.Add(new ScriptBundle("~/bundles/bootstrap-rtl").Include(
					  "~/Scripts/bootstrap.rtl.min.js"));

			bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
					  "~/Scripts/knockout-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/linq").Include(
					  "~/Scripts/linq.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/bootstrap.theme.min.css",
					  "~/Content/site.css"));

			bundles.Add(new StyleBundle("~/Content/css-rtl").Include(
					  "~/Content/bootstrap.rtl.min.css",
					  "~/Content/site.css"));

		}

	}
}