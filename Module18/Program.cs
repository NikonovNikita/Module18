using Module18.Builder;

class Program
{
    static void Main(string[] args)
    {
        var buildManager = new BuildManager(new ProductBuiler());
        buildManager.StartBuildingProcess();

        var product = buildManager.GetBuildingResult();


        //<Builder>//

        var templateEngine = new TemplateEngine();

        TemplateBuilder builder = new WelcomeTemplateBuilder();

        Template greetingsTemplate = templateEngine.GenerateTemplate(builder);
        Console.WriteLine(greetingsTemplate.ToString());

        builder = new OrderTemplateBuilder();
        
        Template orderTemplate = templateEngine.GenerateTemplate(builder);
        Console.WriteLine(orderTemplate.ToString());

        //</Builder>//
    }
}