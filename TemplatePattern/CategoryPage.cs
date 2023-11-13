namespace TemplatePattern;

public class CategoryPage : WebPageTemplate
{
    protected override void RenderHeader()
    {
        Console.WriteLine("Category Header");
    }

    protected override void RenderContent()
    {
        Console.WriteLine("Category Content");
    }

    protected override void RenderFooter()
    {
        Console.WriteLine("Category Footer");
    }
}