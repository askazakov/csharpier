using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintTryStatementSyntax(TryStatementSyntax node)
        {
            var parts = new Parts();
            parts.Push(this.PrintExtraNewLines(node));
            parts.Push(this.PrintAttributeLists(node, node.AttributeLists));
            parts.Push(
                this.PrintSyntaxToken(node.TryKeyword),
                this.PrintBlockSyntax(node.Block),
                HardLine,
                Join(HardLine, node.Catches.Select(this.PrintCatchClauseSyntax))
            );
            if (node.Finally != null)
            {
                parts.Push(
                    HardLine,
                    this.PrintFinallyClauseSyntax(node.Finally)
                );
            }
            return Concat(parts);
        }
    }
}
