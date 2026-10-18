// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Framework;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Every variant of every choice in the newest spec snapshot (<c>snapshot-sync/*/spec-snapshot.tsv</c>) exists in the code with
/// the XML tag the dictionary gives it, and a variant that holds a single value has the dictionary's type for it. That is what
/// decides the element name and the content of a choice in the XML (the XSD of a choice is generated from the same entries).
/// </summary>
public class ChoiceVariantsMatchTheDictionaryTests
{
    private sealed record Variant(string Choice, string Name, string Tag, string Type);

    private static string? FindSnapshot()
    {
        var dir = new DirectoryInfo(AppContext.BaseDirectory);
        for (var i = 0; i < 5 && dir.Parent is not null; i++)
            dir = dir.Parent;
        var root = Path.Combine(dir.FullName, "snapshot-sync");
        return Directory.Exists(root)
            ? Directory.GetDirectories(root).OrderBy(d => d, StringComparer.Ordinal).Select(d => Path.Combine(d, "spec-snapshot.tsv")).LastOrDefault(File.Exists)
            : null;
    }

    private static IEnumerable<Variant> DictionaryVariants(string path) =>
        File.ReadLines(path)
            .Where(l => l.StartsWith("VARIANT\t"))
            .Select(l => l.Split('\t'))
            .Select(f => new Variant(f[1], f[3], f[4], f[5]));

    private static Type? FindVariant(Variant v) =>
        typeof(Iso20022XmlSerializer).Assembly.GetType($"BeneficialStrategies.Iso20022.Choices.{v.Choice}.{v.Name}");

    private static string? TagOf(Type variant)
    {
        var classTag = variant.GetCustomAttribute<IsoXmlTagAttribute>();
        if (classTag is not null)
            return classTag.XmlTag;
        var props = variant.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        return props.Length == 1 ? props[0].GetCustomAttribute<IsoXmlTagAttribute>()?.XmlTag : null;
    }

    [Fact]
    public void EveryVariantOfTheDictionary_ExistsWithItsXmlTag()
    {
        var snapshot = FindSnapshot();
        Assert.NotNull(snapshot);
        var problems = new List<string>();
        var count = 0;
        foreach (var v in DictionaryVariants(snapshot!))
        {
            count++;
            var type = FindVariant(v);
            if (type is null)
            {
                problems.Add($"{v.Choice}.{v.Name}: no such variant");
                continue;
            }
            var tag = TagOf(type);
            // the one variant that holds open content (xs:any): InvestigationResult1Choice.Result, #19
            if (tag != v.Tag && v is not { Choice: "InvestigationResult1Choice", Name: "Result" })
                problems.Add($"{v.Choice}.{v.Name}: tag {tag ?? "(none)"}, dictionary {v.Tag}");
        }
        Assert.True(count > 11000, $"only {count} variants read from {snapshot}");
        Assert.True(problems.Count == 0, $"{problems.Count} of {count} variants differ:" + Environment.NewLine + string.Join(Environment.NewLine, problems.Take(40)));
    }

    [Fact]
    public void TheVariantsThatHoldAnImpliedAmount_HaveTheDictionarysTagAndType()
    {
        var snapshot = FindSnapshot();
        Assert.NotNull(snapshot);
        var implied = new[] { "ImpliedCurrencyAndAmount", "ImpliedCurrencyAnd20Amount", "RestrictedFINImpliedCurrencyAndAmount" };
        var variants = DictionaryVariants(snapshot!).Where(v => implied.Contains(v.Type)).ToList();
        Assert.Equal(51, variants.Count);
        foreach (var v in variants)
        {
            var type = FindVariant(v);
            Assert.NotNull(type);
            Assert.Equal(v.Tag, TagOf(type!));
            Assert.Equal(v.Type, type!.GetProperty("Value")!.PropertyType.Name);
        }
    }

    [Fact]
    public void AVariantThatHoldsOneValue_HasTheDictionarysTypeForIt()
    {
        var snapshot = FindSnapshot();
        Assert.NotNull(snapshot);
        var problems = new List<string>();
        var checkedCount = 0;
        foreach (var v in DictionaryVariants(snapshot!))
        {
            var type = FindVariant(v);
            // a variant with a class-level tag has the members of the component inlined; its first member is not "the" value
            if (type is null || type.GetCustomAttribute<IsoXmlTagAttribute>() is not null)
                continue;
            var value = type.GetProperty("Value", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            if (value is null)
                continue;
            checkedCount++;
            var core = Nullable.GetUnderlyingType(value.PropertyType) ?? value.PropertyType;
            // an abstract choice record is named with a trailing underscore; a few dictionary types are .NET types (Percentage14Rate is a decimal)
            if (core.Name.TrimEnd('_') != v.Type && core.Namespace?.StartsWith("System") != true)
                problems.Add($"{v.Choice}.{v.Name}: Value is {core.Name}, dictionary {v.Type}");
        }
        Assert.True(checkedCount > 1000, $"only {checkedCount} single-value variants were compared");
        Assert.True(problems.Count == 0, $"{problems.Count} of {checkedCount} variants differ:" + Environment.NewLine + string.Join(Environment.NewLine, problems.Take(40)));
    }
}
