namespace Module18.Builder
{
    internal abstract class TemplateBuilder
    {
        public Template Template { get; set; }

        public void CreateTemplate()
        {
            Template = new Template();
        }

        public abstract void BuildHeader();
        public abstract void BuildBody();
        public abstract void BuildFooter();
    }
}
