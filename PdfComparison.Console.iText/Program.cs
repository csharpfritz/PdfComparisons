using iText.Html2pdf;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Diagnostics;

await FormWeb();

async Task FormWeb()
{

	var sw = Stopwatch.StartNew();
	using (PdfWriter pdfWriter = new PdfWriter("form-iText.pdf"))
	{
		
		var client = new HttpClient();
		var stream = await client.GetStreamAsync("https://localhost:7245/");
		HtmlConverter.ConvertToPdf(stream, pdfWriter);

	}

	Console.WriteLine($"Elapsed: {sw.ElapsedMilliseconds}ms");


}

async Task FullWeb()
{

	var sw = Stopwatch.StartNew();
	using (PdfWriter pdfWriter = new PdfWriter("espn-iText.pdf"))
	{
		var client = new HttpClient();
		var stream = await client.GetStreamAsync("https://espn.com/");
		HtmlConverter.ConvertToPdf(stream, pdfWriter);

	}

	Console.WriteLine($"Elapsed: {sw.ElapsedMilliseconds}ms");


}

async Task StaticWeb()
{

	var sw = Stopwatch.StartNew();
	using (PdfWriter pdfWriter = new PdfWriter("staticweb-iText.pdf"))
	{
		var client = new HttpClient();
		var stream = await client.GetStreamAsync("https://kliptokaspnetcore.azurewebsites.net/");
		HtmlConverter.ConvertToPdf(stream, pdfWriter);

	}

	Console.WriteLine($"Elapsed: {sw.ElapsedMilliseconds}ms");


}

void HelloWorld()
{

	using (PdfWriter pdfWriter = new PdfWriter("hello.pdf"))
	using (PdfDocument pdfDocument = new PdfDocument(pdfWriter))
	using (Document document = new Document(pdfDocument))
	{
		document.Add(new Paragraph("Hello World!"));
	}


}