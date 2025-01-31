using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintDeclarationPatternSyntax(DeclarationPatternSyntax node)
        {
            return Concat(
                this.Print(node.Type),
                " ",
                this.Print(node.Designation)
            );
        }
    }
}
