// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml;
using System.Xml.Schema;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// A fact that runs only when <c>ISO20022_XSD_DIR</c> names a folder with ISO's published message schemas
/// (<c>camt.062.001.03.xsd</c> and so on, from the archives on iso20022.org). The schemas are ISO's and are not in this repository.
/// </summary>
public sealed class FactIfIsoXsdsAttribute : FactAttribute
{
    public FactIfIsoXsdsAttribute()
    {
        if (IsoXsd.Folder is null)
            Skip = "Set ISO20022_XSD_DIR to a folder with ISO's message XSDs to run this test.";
    }
}

/// <summary>The same for a theory.</summary>
public sealed class TheoryIfIsoXsdsAttribute : TheoryAttribute
{
    public TheoryIfIsoXsdsAttribute()
    {
        if (IsoXsd.Folder is null)
            Skip = "Set ISO20022_XSD_DIR to a folder with ISO's message XSDs to run this test.";
    }
}

internal static class IsoXsd
{
    public static string? Folder
    {
        get
        {
            var dir = Environment.GetEnvironmentVariable("ISO20022_XSD_DIR");
            return !string.IsNullOrEmpty(dir) && Directory.Exists(dir) ? dir : null;
        }
    }

    public static XmlSchemaSet Schema(string messageId)
    {
        var path = Path.Combine(Folder!, messageId + ".xsd");
        var set = new XmlSchemaSet();
        using var reader = XmlReader.Create(path);
        set.Add(null, reader);
        set.Compile();
        return set;
    }

    /// <summary>The problems <paramref name="xml"/> has against <paramref name="schema"/>, one per line; empty when it is valid.</summary>
    public static List<string> Validate(string xml, XmlSchemaSet schema)
    {
        var problems = new List<string>();
        var settings = new XmlReaderSettings { ValidationType = ValidationType.Schema, Schemas = schema };
        settings.ValidationEventHandler += (_, e) => problems.Add($"{e.Severity}: {e.Message} (line {e.Exception?.LineNumber}, position {e.Exception?.LinePosition})");
        using var reader = XmlReader.Create(new StringReader(xml), settings);
        while (reader.Read()) { }
        return problems;
    }
}

/// <summary>What the serializer writes validates against ISO's published XSD of the message.</summary>
public class IsoXsdValidationTests
{
    private static readonly string[] SampleIds =
    [
        "camt.053.001.01", "camt.054.001.01", "pacs.002.001.15", "pacs.004.001.14", "pacs.008.001.13", "pacs.009.001.12", "pain.001.001.11", "pain.002.001.13",
    ];

    private static string Sample(string id)
    {
        var asm = typeof(IsoXsdValidationTests).Assembly;
        var name = asm.GetManifestResourceNames().Single(n => n.EndsWith($".{id}_sample.xml", StringComparison.Ordinal));
        using var reader = new StreamReader(asm.GetManifestResourceStream(name)!);
        return reader.ReadToEnd();
    }

    private static string ReadAndWriteBack(string id, string xml)
    {
        var type = Iso20022MessageTypeRegistry.ByIsoIdentifier[id];
        var read = typeof(Iso20022XmlSerializer).GetMethods().Single(m => m.Name == "TryRead" && m.GetParameters()[0].ParameterType == typeof(string)).MakeGenericMethod(type);
        var result = read.Invoke(null, [xml])!;
        var issues = (System.Collections.IEnumerable)result.GetType().GetProperty("Issues")!.GetValue(result)!;
        var message = result.GetType().GetProperty("Message")!.GetValue(result);
        Assert.True(message is not null, $"{id}: the sample is not read: " + string.Join("; ", issues.Cast<object>()));
        var write = typeof(Iso20022XmlSerializer).GetMethod("SerializeToString")!.MakeGenericMethod(type);
        return (string)write.Invoke(null, [message])!;
    }

    [TheoryIfIsoXsds]
    [MemberData(nameof(Samples))]
    public void ASampleReadAndWrittenBack_ValidatesAgainstTheIsoXsd(string id)
    {
        var schema = IsoXsd.Schema(id);
        var original = Sample(id);
        Assert.Empty(IsoXsd.Validate(original, schema)); // the sample itself is valid: it is the right schema for it

        var written = ReadAndWriteBack(id, original);
        var problems = IsoXsd.Validate(written, schema);
        Assert.True(problems.Count == 0, $"{id} as written:" + Environment.NewLine + string.Join(Environment.NewLine, problems.Take(10)));
    }

    public static IEnumerable<object[]> Samples() => SampleIds.Select(id => new object[] { id });

    // camt.062: CurrencyFactors1.ShortPositionLimit and MinimumPayInAmount are ImpliedCurrencyAndAmount, in the XSD a plain
    // xs:decimal restriction (fractionDigits 5, totalDigits 18, minInclusive 0) and no Ccy attribute.
    private const string PayInSchedule = """
        <?xml version="1.0" encoding="UTF-8"?>
        <Document xmlns="urn:iso:std:iso:20022:tech:xsd:camt.062.001.03">
          <PayInSchdl>
            <PtyId><AnyBIC><AnyBIC>DEUTDEFF</AnyBIC></AnyBIC></PtyId>
            <RptData>
              <MsgId>MSG-1</MsgId><ValDt>2026-01-02</ValDt><DtAndTmStmp>2026-01-02T10:00:00</DtAndTmStmp><Tp>OFFI</Tp><SchdlTp>ABCD</SchdlTp>
            </RptData>
            <PayInFctrs>
              <AggtShrtPosLmt Ccy="EUR">5.00</AggtShrtPosLmt>
              <CcyFctrs><Ccy>USD</Ccy><ShrtPosLmt>100.50</ShrtPosLmt><MinPayInAmt>10</MinPayInAmt><VoltlyMrgn>5</VoltlyMrgn></CcyFctrs>
            </PayInFctrs>
          </PayInSchdl>
        </Document>
        """;

    [FactIfIsoXsds]
    public void AnImpliedCurrencyAmount_IsWrittenAsTheXsdWantsIt()
    {
        var schema = IsoXsd.Schema("camt.062.001.03");
        Assert.Empty(IsoXsd.Validate(PayInSchedule, schema));

        var written = ReadAndWriteBack("camt.062.001.03", PayInSchedule);

        var problems = IsoXsd.Validate(written, schema);
        Assert.True(problems.Count == 0, string.Join(Environment.NewLine, problems));
        Assert.DoesNotContain("<ShrtPosLmt Ccy", written);
    }
}
