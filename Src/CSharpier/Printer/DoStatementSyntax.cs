using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintDoStatementSyntax(DoStatementSyntax node)
        {
            return Concat(
                this.PrintExtraNewLines(node),
                this.PrintSyntaxToken(
                    node.DoKeyword,
                    node.Statement is not BlockSyntax ? " " : Doc.Null
                ),
                this.Print(node.Statement),
                HardLine,
                this.PrintSyntaxToken(node.WhileKeyword, " "),
                this.PrintSyntaxToken(node.OpenParenToken),
                this.Print(node.Condition),
                this.PrintSyntaxToken(node.CloseParenToken),
                this.PrintSyntaxToken(node.SemicolonToken)
            );
        }
    }
}
