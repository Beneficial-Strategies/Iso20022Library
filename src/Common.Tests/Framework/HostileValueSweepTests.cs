// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Framework;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// The hostile-value sweep of #12: every leaf element and every attribute of two real messages is replaced, one at a time, by each of a
/// list of values that are wrong for almost any type. Whatever the type, reading must never throw, the old <c>TryDeserialize</c> must
/// agree with <c>TryRead</c>, and a rejection must name the element (#10).
/// </summary>
public class HostileValueSweepTests
{
    private static readonly string[] Hostile =
    [
        "", " ", "-1", "0", "1e400", "NaN", "99999999999999999999999999", "2026-13-45", "2026-02-30", "24:00:01", "23:59:60", "25:61:61",
        "2026-01-01T25:00:00", "9999-12-31T23:59:60Z", "ÄÖÜ漢字", "abc", "<", "&", new string('a', 5000),
    ];

    private static XDocument Load(string file)
    {
        var name = $"BeneficialStrategies.Iso20022.TestData.{file}";
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name) ?? throw new InvalidOperationException($"No embedded resource {name}.");
        return XDocument.Load(stream);
    }

    // The leaf elements (no child elements) and the attributes of a document, in document order, as (kind, index) addresses that stay
    // valid in a copy of the document.
    private static List<(bool IsAttribute, int Index)> Addresses(XDocument document)
    {
        var list = new List<(bool, int)>();
        var i = 0;
        foreach (var element in document.Descendants())
        {
            if (!element.HasElements)
                list.Add((false, i));
            foreach (var _ in element.Attributes().Where(a => !a.IsNamespaceDeclaration))
                list.Add((true, i));
            i++;
        }
        return list;
    }

    private static (XElement Element, XAttribute? Attribute) Find(XDocument document, (bool IsAttribute, int Index) at)
    {
        var element = document.Descendants().ElementAt(at.Index);
        return (element, at.IsAttribute ? element.Attributes().First(a => !a.IsNamespaceDeclaration) : null);
    }

    private static void Sweep<TMessage>(string file)
        where TMessage : class, IOuterRecord
    {
        var original = Load(file);
        Assert.True(Iso20022XmlSerializer.TryRead<TMessage>(original).Succeeded, "the untouched sample must read");
        var problems = new List<string>();
        int probes = 0, rejected = 0;
        foreach (var at in Addresses(original))
            foreach (var value in Hostile)
            {
                var copy = new XDocument(original);
                var (element, attribute) = Find(copy, at);
                var name = element.Name.LocalName;
                if (attribute is not null)
                    attribute.Value = value;
                else
                    element.Value = value;
                probes++;

                DeserializationResult<TMessage> read;
                bool tried;
                Exception? error;
                try
                {
                    read = Iso20022XmlSerializer.TryRead<TMessage>(copy);
                    tried = Iso20022XmlSerializer.TryDeserialize<TMessage>(copy, out _, out error);
                }
                catch (Exception ex)
                {
                    problems.Add($"{name}{(attribute is null ? "" : "/@" + attribute.Name.LocalName)} = '{(value.Length > 20 ? value[..20] : value)}' threw {ex.GetType().Name}");
                    continue;
                }

                if (read.Succeeded != tried)
                    problems.Add($"{name} = '{(value.Length > 20 ? value[..20] : value)}': TryRead {(read.Succeeded ? "accepts" : "rejects")} but TryDeserialize {(tried ? "accepts" : "rejects")}");
                if (read.Succeeded)
                    continue;
                rejected++;
                if (error is not Iso20022DeserializationException)
                    problems.Add($"{name} = '{(value.Length > 20 ? value[..20] : value)}': the error is {error?.GetType().Name}, not an Iso20022DeserializationException");
                if (!read.Issues.Any(i => i.Path.Contains(name)))
                    problems.Add($"{name} = '{(value.Length > 20 ? value[..20] : value)}': no problem names the element (paths: {string.Join(", ", read.Issues.Select(i => i.Path))})");
            }

        Assert.True(probes > 300, $"only {probes} probes");
        Assert.True(rejected > 100, $"only {rejected} rejections: the values are not as hostile as meant");
        Assert.True(problems.Count == 0, $"{problems.Count} problems in {probes} probes:{Environment.NewLine}" + string.Join(Environment.NewLine, problems.Take(40)));
    }

    [Fact]
    public void Pacs008_NothingEscapes_AndEveryRejectionNamesItsElement() => Sweep<BeneficialStrategies.Iso20022.pacs.FIToFICustomerCreditTransferV13>("pacs.008.001.13_sample.xml");

    [Fact]
    public void Camt053_NothingEscapes_AndEveryRejectionNamesItsElement() => Sweep<BeneficialStrategies.Iso20022.camt.BankToCustomerStatementV11>("camt.053.001.11_sample.xml");

    [Fact]
    public void ADeserializeOfBrokenXml_ThrowsAnExceptionThatCarriesEveryProblemAndTheFirstOnesPath()
    {
        var document = Load("pacs.008.001.13_sample.xml");
        document.Descendants().First(e => e.Name.LocalName == "IntrBkSttlmAmt").Value = "";
        document.Descendants().First(e => e.Name.LocalName == "MsgId").Value = new string('x', 100);

        var ex = Assert.Throws<Iso20022DeserializationException>(() => Iso20022XmlSerializer.Deserialize<BeneficialStrategies.Iso20022.pacs.FIToFICustomerCreditTransferV13>(document));

        Assert.True(ex.Issues.Count >= 2, ex.Message);
        Assert.Contains(ex.Issues, i => i.Path.EndsWith("IntrBkSttlmAmt") || i.Path.Contains("IntrBkSttlmAmt"));
        Assert.Contains(ex.Issues, i => i.Path.EndsWith("MsgId"));
        Assert.Equal(ex.Issues[0].Path, ex.Path);
        Assert.Contains("more problem", ex.Message);
    }
}
