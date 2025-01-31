using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintParameterListSyntax(ParameterListSyntax node)
        {
            return Group(
                this.PrintSyntaxToken(node.OpenParenToken),
                node.Parameters.Count > 0
                    ? Indent(
                        SoftLine,
                        this.PrintSeparatedSyntaxList(
                            node.Parameters,
                            this.PrintParameterSyntax,
                            Line
                        )
                    )
                    : Doc.Null,
                this.PrintSyntaxToken(node.CloseParenToken)
            );
        }
    }
}
