using IronPdf;
using System.Diagnostics;

StaticWeb();

void HelloWorldDemo()
{

	var Renderer = new IronPdf.ChromePdfRenderer();

	using var pdf = Renderer.RenderHtmlAsPdf("<h1>hello world</h1>");

	pdf.SaveAs("output.pdf");

}

void StaticWeb()
{

	var sw = new Stopwatch();
	sw.Start();
  var Renderer = new IronPdf.ChromePdfRenderer(); 
	Renderer.RenderingOptions.RenderDelay = 1000;
	using var pdf = Renderer.RenderUrlAsPdf("https://kliptokaspnetcore.azurewebsites.net/");

	pdf.SaveAs("kliptokstatic-iron.pdf");
	Console.WriteLine($"Completed rendering in {sw.ElapsedMilliseconds}ms");

}

void FullWeb()
{

	var sw = new Stopwatch();
	sw.Start();
	var Renderer = new IronPdf.ChromePdfRenderer();
	Renderer.RenderingOptions.RenderDelay = 1000;
	using var pdf = Renderer.RenderUrlAsPdf("https://espn.com/");

	pdf.SaveAs("espn-iron.pdf");
	Console.WriteLine($"Completed rendering in {sw.ElapsedMilliseconds}ms");

}

void FormWeb()
{

	var sw = new Stopwatch();
	sw.Start();
	var Renderer = new IronPdf.ChromePdfRenderer();
	Renderer.RenderingOptions.RenderDelay = 1000;
	using var pdf = Renderer.RenderUrlAsPdf("https://localhost:7245/");

	pdf.SaveAs("form-iron.pdf");
	Console.WriteLine($"Completed rendering in {sw.ElapsedMilliseconds}ms");

}