// Rewrites the tests of a project from the message records to the interfaces and the Factory:
//   new Foo { A = x }        ->  IsoDataFactory.Make<IFoo>(b => b.Set(x => x.A).To(x))
//   new() { A = x }          ->  the same, with the type the compiler infers
//   source with { A = x }    ->  IsoDataFactory.With(source, b => b.Set(x => x.A).To(x))
//   a record type in a type position (a return type, a declaration, a pattern, typeof) -> its interface
// Usage: Rewriter <project.csproj> <folder or file under the project>... [--dry]
// It rewrites in place and prints what it rewrote and what it left alone. A construction it cannot read (a nested object initializer, say) is left as it is.
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;

MSBuildLocator.RegisterDefaults();
return await Run(args);

static async Task<int> Run(string[] args)
{
    var dry = args.Contains("--dry");
    var positional = args.Where(a => !a.StartsWith("--")).ToArray();
    if (positional.Length < 2)
    {
        Console.Error.WriteLine("Usage: Rewriter <project.csproj> <folder or file>... [--dry]");
        return 2;
    }
    using var workspace = MSBuildWorkspace.Create();
    workspace.WorkspaceFailed += (_, e) => { if (e.Diagnostic.Kind == WorkspaceDiagnosticKind.Failure) Console.Error.WriteLine(e.Diagnostic.Message); };
    var project = await workspace.OpenProjectAsync(Path.GetFullPath(positional[0]));
    var compilation = (await project.GetCompilationAsync())!;
    var roots = positional.Skip(1).Select(Path.GetFullPath).ToArray();
    int files = 0, made = 0, withs = 0, types = 0, left = 0;
    foreach (var document in project.Documents)
    {
        if (document.FilePath is null || !roots.Any(r => document.FilePath.StartsWith(r))) continue;
        var tree = (await document.GetSyntaxTreeAsync())!;
        var model = compilation.GetSemanticModel(tree);
        var rewriter = new ModelRewriter(model, compilation);
        var root = rewriter.Visit(await tree.GetRootAsync());
        made += rewriter.Made; withs += rewriter.Withs; types += rewriter.Types; left += rewriter.Left.Count;
        foreach (var l in rewriter.Left) Console.WriteLine($"LEFT {Path.GetFileName(document.FilePath)}: {l}");
        if (rewriter.Made + rewriter.Withs + rewriter.Types == 0) continue;
        files++;
        if (!dry) await File.WriteAllTextAsync(document.FilePath, root.ToFullString());
    }
    Console.WriteLine($"{files} files: {made} constructions, {withs} with-expressions, {types} type references; {left} left alone{(dry ? " (dry run)" : "")}");
    return 0;
}

sealed class ModelRewriter(SemanticModel model, Compilation compilation) : CSharpSyntaxRewriter
{
    public int Made, Withs, Types;
    public List<string> Left { get; } = [];

    // The interface of a record of the message model, or null when the type is not one of them (a code set, an amount, a BCL type).
    private INamedTypeSymbol? InterfaceOf(ITypeSymbol? type)
    {
        if (type is not INamedTypeSymbol { TypeKind: TypeKind.Class } named) return null;
        var ns = named.ContainingNamespace?.ToDisplayString();
        if (ns is null || !ns.StartsWith("BeneficialStrategies.Iso20022")) return null;
        if (named.ContainingAssembly?.Name != "BeneficialStrategies.Iso20022.Common") return null;
        var name = "I" + named.Name.TrimEnd('_');
        return compilation.GetTypeByMetadataName($"{ns}.{name}");
    }

    private static int Depth(SyntaxNode node) =>
        node.Ancestors().Count(a => a is ObjectCreationExpressionSyntax or ImplicitObjectCreationExpressionSyntax or WithExpressionSyntax { Initializer.Expressions.Count: > 0 });

    private static string Indent(SyntaxNode node)
    {
        var line = node.SyntaxTree.GetText().Lines.GetLineFromPosition(node.SpanStart);
        var text = line.ToString();
        return new string(' ', text.Length - text.TrimStart().Length);
    }

    // `A = x, B = y` as `.Set(x => x.A).To(x)` lines; null when the initializer holds something else.
    private string? Chain(InitializerExpressionSyntax? initializer, SyntaxNode at, string indent, int depth)
    {
        if (initializer is null) return "";
        var x = depth == 0 ? "x" : $"x{depth + 1}";
        var lines = new List<string>();
        foreach (var e in initializer.Expressions)
        {
            if (e is not AssignmentExpressionSyntax { Left: IdentifierNameSyntax name } assignment) return null;
            var value = ((ExpressionSyntax)Visit(assignment.Right)).ToFullString().Trim();
            lines.Add($"{indent}.Set({x} => {x}.{name.Identifier.Text}).To({value})");
        }
        return lines.Count == 0 ? "" : "\n" + string.Join("\n", lines);
    }

    private SyntaxNode Make(ExpressionSyntax node, InitializerExpressionSyntax? initializer, Func<SyntaxNode> unchanged)
    {
        var type = model.GetTypeInfo(node).Type;
        var iface = InterfaceOf(type);
        if (iface is null) return unchanged();
        var depth = Depth(node);
        var b = depth == 0 ? "b" : $"b{depth + 1}";
        var chain = Chain(initializer, node, Indent(node) + "    ", depth);
        if (chain is null)
        {
            Left.Add($"{node.ToString().Split('\n')[0].Trim()} (line {node.GetLocation().GetLineSpan().StartLinePosition.Line + 1})");
            return unchanged();
        }
        Made++;
        var name = iface.ToMinimalDisplayString(model, node.SpanStart);
        var text = chain.Length == 0 ? $"IsoDataFactory.Make<{name}>()" : $"IsoDataFactory.Make<{name}>({b} => {b}{chain})";
        return SyntaxFactory.ParseExpression(text).WithTriviaFrom(node);
    }

    public override SyntaxNode? VisitObjectCreationExpression(ObjectCreationExpressionSyntax node) => Make(node, node.Initializer, () => base.VisitObjectCreationExpression(node)!);

    public override SyntaxNode? VisitImplicitObjectCreationExpression(ImplicitObjectCreationExpressionSyntax node) => Make(node, node.Initializer, () => base.VisitImplicitObjectCreationExpression(node)!);

    public override SyntaxNode? VisitWithExpression(WithExpressionSyntax node)
    {
        var iface = InterfaceOf(model.GetTypeInfo(node).Type);
        if (iface is null) return base.VisitWithExpression(node);
        var depth = Depth(node);
        var b = depth == 0 ? "b" : $"b{depth + 1}";
        var chain = Chain(node.Initializer, node, Indent(node) + "    ", depth);
        if (chain is null) { Left.Add($"with at line {node.GetLocation().GetLineSpan().StartLinePosition.Line + 1}"); return base.VisitWithExpression(node); }
        Withs++;
        var source = ((ExpressionSyntax)Visit(node.Expression)).ToFullString().Trim();
        var text = chain.Length == 0 ? source : $"IsoDataFactory.With({source}, {b} => {b}{chain})";
        return SyntaxFactory.ParseExpression(text).WithTriviaFrom(node);
    }

    // `using Agent = ...Party40Choice.Agent;` names a record: the alias and its target become the interface.
    public override SyntaxNode? VisitUsingDirective(UsingDirectiveSyntax node)
    {
        if (node.Alias is null || model.GetSymbolInfo(node.NamespaceOrType).Symbol is not INamedTypeSymbol type || InterfaceOf(type) is not { } iface)
            return base.VisitUsingDirective(node);
        Types++;
        ExpressionSyntax? target = node.NamespaceOrType switch
        {
            QualifiedNameSyntax q => q.WithRight(SyntaxFactory.IdentifierName(iface.Name)),
            IdentifierNameSyntax => SyntaxFactory.IdentifierName(iface.Name),
            _ => null,
        };
        if (target is null) return base.VisitUsingDirective(node);
        return node.WithAlias(node.Alias.WithName(SyntaxFactory.IdentifierName(iface.Name))).WithNamespaceOrType((NameSyntax)target.WithTriviaFrom(node.NamespaceOrType));
    }

    // A record type named where a type is expected becomes its interface; a use of the record's static members stays.
    public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
    {
        if (node.Parent is ObjectCreationExpressionSyntax creation && creation.Type == node) return base.VisitIdentifierName(node);
        if (node.Parent is QualifiedNameSyntax qualified && qualified.Left == node) return base.VisitIdentifierName(node);
        if (node.Parent is MemberAccessExpressionSyntax { Expression: var e } && e == node) return base.VisitIdentifierName(node);
        if (node.IsVar) return base.VisitIdentifierName(node);
        if (model.GetSymbolInfo(node).Symbol is not INamedTypeSymbol type) return base.VisitIdentifierName(node);
        var iface = InterfaceOf(type);
        if (iface is null) return base.VisitIdentifierName(node);
        Types++;
        return node.WithIdentifier(SyntaxFactory.Identifier(node.Identifier.LeadingTrivia, iface.Name, node.Identifier.TrailingTrivia));
    }
}
