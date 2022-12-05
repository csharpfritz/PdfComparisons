using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using System.Diagnostics;

internal class Program
{
	private static void Main(string[] args)
	{
		FormWeb();

		void FormWeb()
		{

			var sw = Stopwatch.StartNew();
			var htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.Blink);

			//Convert URL to PDF and save the PDF document. 
			var document = htmlConverter.Convert("https://localhost:7245/");
			htmlConverter.ConverterSettings.AdditionalDelay = 5000;

			//Save and closes the document. 

			using var file = File.OpenWrite("form-sync.pdf");
			document.Save(file);
			document.Close(true);
			Console.WriteLine($"Elapsed milliseconds: {sw.ElapsedMilliseconds}ms");

		}

		void FullWeb()
		{

			var sw = Stopwatch.StartNew();
			var htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.Blink);

			//Convert URL to PDF and save the PDF document. 
			var document = htmlConverter.Convert("https://espn.com/");
			htmlConverter.ConverterSettings.AdditionalDelay = 5000;
			//Save and closes the document. 

			using var file = File.OpenWrite("espn-sync.pdf");
			document.Save(file);
			document.Close(true);
			Console.WriteLine($"Elapsed milliseconds: {sw.ElapsedMilliseconds}ms");

		}

		void StaticWeb()
		{

			var sw = Stopwatch.StartNew();
			var htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.Blink);

			//Convert URL to PDF and save the PDF document. 
			var document = htmlConverter.Convert("https://kliptokaspnetcore.azurewebsites.net/");
			htmlConverter.ConverterSettings.AdditionalDelay = 5000;
			//Save and closes the document. 

			using var file = File.OpenWrite("kliptokstatic-sync.pdf");
			document.Save(file);
			document.Close(true);
			Console.WriteLine($"Elapsed milliseconds: {sw.ElapsedMilliseconds}ms");

		}

		void HelloWorld()
		{

			//var document = new PdfDocument();

			////Add a page

			//var page = document.Pages.Add();

			////Create Pdf graphics for the page

			//var graphics = page.Graphics;

			////Set the font

			////var font = new PdfStandardFont(PdfFontFamily.Helvetica, 36);

			//////Draw the text

			////graphics.DrawString("Hello world!", font, PdfBrushes.Black, new PointF(20, 20));

			////Saving the PDF to the MemoryStream

			//var f = File.Create("sample.pdf");

			//document.Save(f);

			//document.Close();

		}
	}
}