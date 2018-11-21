using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.IO;

namespace Roslyn
{
    class Program
    {
        static void Main(string[] args)
        {

            var code = File.ReadAllText("code.cs");
            var tree = SyntaxFactory.ParseSyntaxTree(code);

            var options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);

            var reference = new MetaDataFileReference(typeof(object).Assembly.Location);
            
            var compilation = CSharpCompilation.Create("test")
                                               .WithOptions(options)
                                               .AddSyntaxTrees(tree)
                                               ;
        }
    }
}
