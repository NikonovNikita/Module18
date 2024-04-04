using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Builder;

internal class WelcomeTemplateBuilder : TemplateBuilder
{
    public override void BuildBody()
    {
        Template.Body = new Body { Text = "Спасибо за регистрацию в нашем приложении" };
    }

    public override void BuildFooter() { }

    public override void BuildHeader()
    {
        Template.Header = new Header { Text = "Здравствуйте!" };
    }
}
