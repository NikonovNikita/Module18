using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Builder;

internal class TemplateEngine
{
    public Template GenerateTemplate(TemplateBuilder tBuilder)
    {
        tBuilder.CreateTemplate();

        tBuilder.BuildHeader();
        tBuilder.BuildBody();
        tBuilder.BuildFooter();

        return tBuilder.Template;
    }
}
