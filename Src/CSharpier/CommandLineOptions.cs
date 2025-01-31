using System.CommandLine;
using System.CommandLine.Invocation;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpier
{
    public static class CommandLineOptions
    {
        internal delegate Task<int> Handler(
            string directory,
            bool validate,
            bool check,
            CancellationToken cancellationToken);

        public static RootCommand Create()
        {
            var rootCommand = new RootCommand
            {
                new Argument<string>(
                    "directoryOrFile"
                )
                {
                    Arity = ArgumentArity.ZeroOrOne,
                    Description = "A path to a directory containing files to format or a file to format. If a path is not specified the current directory is used"
                }.LegalFilePathsOnly(),
                new Option(
                    new[] { "--check", "-c" },
                    "Check that files are formatted. Will not write any changes."
                ),
                new Option(
                    new[] { "--fast", "-f" },
                    "Skip comparing syntax tree of formatted file to original file to validate changes."
                )
            };

            rootCommand.Description = "csharpier";

            return rootCommand;
        }
    }
}
