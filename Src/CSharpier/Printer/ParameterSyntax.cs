using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintParameterSyntax(ParameterSyntax node)
        {
            var parts = new Parts();
            parts.Push(this.PrintAttributeLists(node, node.AttributeLists));
            parts.Push(this.PrintModifiers(node.Modifiers));
            if (node.Type != null)
            {
                parts.Push(this.Print(node.Type), SpaceIfNoPreviousComment);
            }

            parts.Push(this.PrintSyntaxToken(node.Identifier));
            if (node.Default != null)
            {
                parts.Push(this.PrintEqualsValueClauseSyntax(node.Default));
            }

            return Concat(parts);
        }
    }
}
