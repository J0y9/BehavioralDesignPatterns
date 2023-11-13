namespace TemplatePattern;

public abstract class WebPageTemplate
{
    public void RenderPage()
    {
        RenderHeader();
        RenderContent();
        RenderFooter();
    }

    protected abstract void RenderHeader();
    protected abstract void RenderContent();
    protected abstract void RenderFooter();
}