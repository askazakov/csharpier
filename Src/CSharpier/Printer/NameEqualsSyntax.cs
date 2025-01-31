using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintNameEqualsSyntax(NameEqualsSyntax node)
        {
            return Concat(
                this.Print(node.Name),
                SpaceIfNoPreviousComment,
                this.PrintSyntaxToken(node.EqualsToken, " ")
            );
        }
    }
}
