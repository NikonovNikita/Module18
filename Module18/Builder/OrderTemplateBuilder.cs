namespace Module18.Builder;

internal class OrderTemplateBuilder : TemplateBuilder
{
    public override void BuildBody()
    {
        Template.Body = new Body { Text = "Ваш номер заказа - 534" };
    }

    public override void BuildFooter()
    {
        Template.Footer = new Footer { Text = "OOO ЛучшийСервис, contact@bestservice.ru" };
    }

    public override void BuildHeader()
    {
        Template.Header = new Header { Text = "Здравствуйте, спасибо за заказ!" };
    }
}
