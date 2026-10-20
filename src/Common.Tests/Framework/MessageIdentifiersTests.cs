// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Framework;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// The identifier, the document namespace and the area of a message agree: two messages that share an identifier (supl.010.001.06 was the
/// identifier of two) would share an XML namespace and one would be unreachable by the registry (#47).
/// </summary>
public class MessageIdentifiersTests
{
    private static IEnumerable<(Type Type, string Identifier, string Namespace)> Messages() =>
        typeof(BeneficialStrategies.Iso20022.pacs.FIToFICustomerCreditTransferV14)
            .Assembly.GetExportedTypes()
            .Where(t => typeof(IOuterRecord).IsAssignableFrom(t) && t.IsClass)
            .Select(t => (t, (string)t.GetField("IsoIdentifier")!.GetRawConstantValue()!, (string)t.GetField("DocumentNamespace")!.GetRawConstantValue()!));

    [Fact]
    public void EveryMessageHasItsOwnIdentifier()
    {
        var shared = Messages().GroupBy(m => m.Identifier).Where(g => g.Count() > 1).Select(g => $"{g.Key}: {string.Join(", ", g.Select(m => m.Type.Name))}").ToList();
        Assert.True(shared.Count == 0, "Identifiers used by more than one message:" + Environment.NewLine + string.Join(Environment.NewLine, shared));
    }

    [Fact]
    public void TheNamespaceOfADocumentEndsWithItsIdentifier()
    {
        var wrong = Messages().Where(m => m.Namespace != "urn:iso:std:iso:20022:tech:xsd:" + m.Identifier).Select(m => $"{m.Type.Name}: {m.Identifier} / {m.Namespace}").ToList();
        Assert.True(wrong.Count == 0, string.Join(Environment.NewLine, wrong));
    }

    [Fact]
    public void TheAreaOfAMessageIsThatOfItsNamespace()
    {
        var wrong = Messages().Where(m => m.Type.Namespace != "BeneficialStrategies.Iso20022." + m.Identifier[..4]).Select(m => $"{m.Type.FullName}: {m.Identifier}").ToList();
        Assert.True(wrong.Count == 0, string.Join(Environment.NewLine, wrong.Take(20)));
    }
}
