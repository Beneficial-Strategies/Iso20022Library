// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Schema;
using BeneficialStrategies.Iso20022.Framework;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Compares the record model of every message that has an XSD in <c>ISO20022_XSD_DIR</c> with the structure of that XSD:
/// the elements of each sequence and their order, their multiplicity, and the alternatives of each choice. The order matters:
/// a sequence in the XSD is rejected by a validator when the elements are written in another order.
/// </summary>
public class IsoXsdStructureTests
{
    private sealed class Report
    {
        public readonly Dictionary<string, List<string>> Problems = new();
        public readonly HashSet<string> Visited = [];
        public int Types;

        public void Add(string kind, string where, string detail) =>
            (Problems.TryGetValue(kind, out var l) ? l : Problems[kind] = []).Add($"{where}: {detail}");
    }

    private static (string Tag, PropertyInfo Property)[] Members(Type type) =>
        type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Select(p => (Tag: p.GetCustomAttribute<IsoXmlTagAttribute>()?.XmlTag, Property: p))
            .Where(x => x.Tag is not null)
            .Select(x => (x.Tag!, x.Property))
            .ToArray();

    private static Type Core(Type t)
    {
        t = Nullable.GetUnderlyingType(t) ?? t;
        if (t.IsGenericType && t.GetGenericArguments().Length == 1 && typeof(System.Collections.IEnumerable).IsAssignableFrom(t) && t != typeof(string))
            return t.GetGenericArguments()[0];
        return t;
    }

    private static bool IsCollection(Type t) =>
        (Nullable.GetUnderlyingType(t) ?? t) is { IsGenericType: true } g && g.Name.StartsWith("ValueList") || g_(t);

    private static bool g_(Type t) => t.IsGenericType && t.Name.Contains("ValueList");

    private static (string Tag, Type Variant)[] Variants(Type choice) =>
        choice
            .GetCustomAttributes<JsonDerivedTypeAttribute>()
            .Select(a => a.DerivedType)
            .Select(v =>
            {
                var classTag = v.GetCustomAttribute<IsoXmlTagAttribute>()?.XmlTag;
                var props = Members(v);
                return (Tag: classTag ?? (props.Length == 1 ? props[0].Tag : null), Variant: v);
            })
            .Where(x => x.Tag is not null)
            .Select(x => (x.Tag!, x.Variant))
            .ToArray();

    private static void CompareType(XmlSchemaType? xsd, Type clr, string where, Report report)
    {
        if (xsd is not XmlSchemaComplexType complex)
            return;
        if (!report.Visited.Add(complex.QualifiedName + "|" + clr.FullName))
            return;
        report.Types++;

        var particle = complex.ContentTypeParticle;
        if (particle is XmlSchemaChoice choice)
        {
            var elements = choice.Items.OfType<XmlSchemaElement>().ToList();
            if (!clr.IsAbstract)
            {
                report.Add("choice-not-abstract", where, $"{clr.Name} is not a choice");
                return;
            }
            var variants = Variants(clr);
            var xsdNames = elements.Select(e => e.Name!).ToHashSet();
            var clrNames = variants.Select(v => v.Tag).ToHashSet();
            foreach (var missing in xsdNames.Except(clrNames))
                report.Add("choice-variant-missing-in-code", where, $"{clr.Name} has no variant <{missing}>");
            foreach (var extra in clrNames.Except(xsdNames))
                report.Add("choice-variant-not-in-xsd", where, $"{clr.Name} has variant <{extra}> that the XSD does not");
            foreach (var e in elements)
            {
                var v = variants.FirstOrDefault(x => x.Tag == e.Name);
                if (v.Variant is null)
                    continue;
                var classTag = v.Variant.GetCustomAttribute<IsoXmlTagAttribute>() is not null;
                var members = Members(v.Variant);
                if (e.ElementSchemaType is XmlSchemaComplexType ec)
                {
                    if (classTag)
                        CompareType(ec, v.Variant, $"{where}/{e.Name}", report);
                    else if (members.Length == 1)
                        CompareType(ec, Core(members[0].Property.PropertyType), $"{where}/{e.Name}", report);
                    else
                        report.Add("variant-has-no-members", $"{where}/{e.Name}", $"{v.Variant.Name} has {members.Length} members for a complex XSD type {ec.Name}");
                }
            }
            return;
        }

        var seq = particle as XmlSchemaSequence;
        if (seq is null)
            return; // simple content (amounts) or empty
        var xsdElements = seq.Items.OfType<XmlSchemaElement>().ToList();
        if (clr.IsAbstract)
        {
            report.Add("sequence-but-code-has-a-choice", where, clr.Name);
            return;
        }
        var members2 = Members(clr);
        var xsdTags = xsdElements.Select(e => e.Name!).ToArray();
        var clrTags = members2.Select(m => m.Tag).ToArray();
        if (!xsdTags.OrderBy(x => x).SequenceEqual(clrTags.OrderBy(x => x)))
        {
            var missing = xsdTags.Except(clrTags).ToArray();
            var extra = clrTags.Except(xsdTags).ToArray();
            report.Add("element-names", where, $"{clr.Name}: missing in code [{string.Join(",", missing)}], not in XSD [{string.Join(",", extra)}]");
        }
        else if (!xsdTags.SequenceEqual(clrTags))
        {
            report.Add("element-order", where, $"{clr.Name}: XSD {string.Join(",", xsdTags)} / code {string.Join(",", clrTags)}");
        }
        foreach (var e in xsdElements)
        {
            var m = members2.FirstOrDefault(x => x.Tag == e.Name);
            if (m.Property is null)
                continue;
            var optional = e.MinOccurs == 0;
            var many = e.MaxOccurs > 1;
            var isCollection = IsCollection(m.Property.PropertyType);
            var isRequiredMember = m.Property.GetCustomAttribute<System.Runtime.CompilerServices.RequiredMemberAttribute>() is not null;
            if (many != isCollection)
                report.Add("multiplicity-many", $"{where}/{e.Name}", $"{clr.Name}.{m.Property.Name}: XSD max {e.MaxOccurs}, code {(isCollection ? "collection" : "single")}");
            else if (!many && optional == isRequiredMember)
                report.Add("multiplicity-optional", $"{where}/{e.Name}", $"{clr.Name}.{m.Property.Name}: XSD min {e.MinOccurs}, code {(isRequiredMember ? "required" : "optional")}");
            CompareType(e.ElementSchemaType as XmlSchemaComplexType, Core(m.Property.PropertyType), $"{where}/{e.Name}", report);
        }
    }

    // A scan, not a gate: it reports what differs (#41) and fails while anything does, so it runs only when asked
    // (ISO20022_XSD_SCAN=1, with ISO20022_XSD_DIR), and writes structure-report.txt and structure-problems.tsv into the XSD folder.
    [FactIfIsoXsds]
    public void EveryMessageHasTheStructureOfItsXsd()
    {
        if (Environment.GetEnvironmentVariable("ISO20022_XSD_SCAN") != "1")
            return; // not asked for
        var report = new Report();
        var checkedMessages = 0;
        foreach (var path in Directory.GetFiles(IsoXsd.Folder!, "*.xsd").OrderBy(p => p, StringComparer.Ordinal))
        {
            var id = Path.GetFileNameWithoutExtension(path);
            if (!Iso20022MessageTypeRegistry.ByIsoIdentifier.TryGetValue(id, out var type))
                continue;
            XmlSchemaSet set;
            try { set = IsoXsd.Schema(id); } catch (Exception) { continue; }
            var document = set.GlobalElements.Values.OfType<XmlSchemaElement>().FirstOrDefault(e => e.Name == "Document");
            if (document?.ElementSchemaType is not XmlSchemaComplexType dc || dc.ContentTypeParticle is not XmlSchemaSequence s || s.Items.OfType<XmlSchemaElement>().FirstOrDefault() is not { } root)
                continue;
            checkedMessages++;
            CompareType(root.ElementSchemaType, type, id, report);
        }

        var text = new StringBuilder();
        text.AppendLine($"{checkedMessages} messages, {report.Types} type pairs compared");
        foreach (var (kind, list) in report.Problems.OrderByDescending(p => p.Value.Count))
        {
            text.AppendLine($"== {kind}: {list.Count}");
            foreach (var x in list.Take(8))
                text.AppendLine("   " + x);
        }
        File.WriteAllText(Path.Combine(IsoXsd.Folder!, "structure-report.txt"), text.ToString());
        File.WriteAllLines(
            Path.Combine(IsoXsd.Folder!, "structure-problems.tsv"),
            report.Problems.SelectMany(p => p.Value.Select(v => p.Key + "\t" + v))
        );
        Assert.True(report.Problems.Count == 0, text.ToString());
    }
}
