using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Builder;

internal class Template
{
    public Header Header { get; set; }
    public Body Body { get; set; }
    public Footer Footer { get; set; }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        if(Header != null)
            stringBuilder.Append(Header.Text +  "\n");

        if (Body != null)
            stringBuilder.Append($"{Body.Text}\n");

        if (Footer != null)
            stringBuilder.Append($"{Footer.Text}\n");

        return stringBuilder.ToString();
    }
}
