using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier
{
    public partial class Printer
    {
        private Doc PrintOmittedArraySizeExpressionSyntax(
            OmittedArraySizeExpressionSyntax node)
        {
            return Doc.Null;
        }
    }
}
