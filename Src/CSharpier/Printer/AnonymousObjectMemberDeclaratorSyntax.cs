using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintAnonymousObjectMemberDeclaratorSyntax(
            AnonymousObjectMemberDeclaratorSyntax node)
        {
            var parts = new Parts();
            if (node.NameEquals != null)
            {
                parts.Push(
                    this.PrintSyntaxToken(node.NameEquals.Name.Identifier, " ")
                );
                parts.Push(
                    this.PrintSyntaxToken(node.NameEquals.EqualsToken, " ")
                );
            }
            parts.Push(this.Print(node.Expression));
            return Concat(parts);
        }
    }
}
