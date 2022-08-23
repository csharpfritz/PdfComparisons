using Aspose.Pdf;
using System.Net;

const string _DataDir = "..\\..\\..\\Samples";

await StaticWeb();

async Task StaticWeb()
{

	const string url = "https://kliptokaspnetcore.azurewebsites.net/";
	// Set page size A3 and Portrait orientation;   
	HtmlLoadOptions options = new HtmlLoadOptions(url)
	{
		PageInfo = { Width = 842, Height = 1191, IsLandscape = false }
	};
	var stream = await GetContentFromUrlAsStream(url);
	Document pdfDocument = new Document(stream, options);
	pdfDocument.Save("kliptokstatic-aspose.pdf");


}

static async Task<Stream> GetContentFromUrlAsStream(string url, ICredentials credentials = null)
{
//	using (var handler = new HttpClientHandler { Credentials = credentials })
	using (var httpClient = new HttpClient())
	{
		return await httpClient.GetStreamAsync(url);
	}
}

void HelloWorld()
{
	// Initialize document object
	Document document = new Document();
	// Add page
	Page page = document.Pages.Add();
	// Add text to new page
	page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Hello World!"));
	// Save updated PDF
	var outputFileName = System.IO.Path.Combine(_DataDir, "HelloWorld_out.pdf");
	document.Save(outputFileName);

}