namespace TemplatePattern;

public class ProductPage : WebPageTemplate
{
    protected override void RenderHeader()
    {
        Console.WriteLine("Product Header");
    }

    protected override void RenderContent()
    {
        Console.WriteLine("Product Content");
    }

    protected override void RenderFooter()
    {
        Console.WriteLine("Product Footer");
    }
}