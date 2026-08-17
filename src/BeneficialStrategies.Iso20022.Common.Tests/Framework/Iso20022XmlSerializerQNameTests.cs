// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml;
using BeneficialStrategies.Iso20022.Framework;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// End-to-end tests for <see cref="System.Xml.XmlQualifiedName"/> leaf-value support in
/// <see cref="Iso20022XmlSerializer"/> — added when the type was wired in as the first real
/// application of CLAUDE.md's "primitives defined by a W3C standard" exception. There is no real
/// ISO 20022 field using <c>IsoQName</c> yet (zero live usage as of this writing), so this uses a
/// minimal purpose-built <see cref="IOuterRecord"/> to exercise the actual public
/// Serialize/Deserialize pipeline rather than reaching into private methods via reflection.
/// </summary>
public class Iso20022XmlSerializerQNameTests
{
    private record QNameTestMessage : IOuterRecord
    {
        public const string DocumentNamespace = "urn:test:qname";
        public const string XmlTag = "Root";
        public const string DocumentElementName = "Document";

        [IsoXmlTag("Qn")]
        public required XmlQualifiedName QualifiedName { get; init; }
    }

    [Fact]
    public void Serialize_SameNamespaceAsDocument_WritesBareLocalName()
    {
        var message = new QNameTestMessage
        {
            QualifiedName = new XmlQualifiedName("Foo", "urn:test:qname"),
        };

        var doc = Iso20022XmlSerializer.Serialize(message);

        var qnEl = doc.Root!.Element(doc.Root.Name.Namespace + "Root")!.Element(doc.Root.Name.Namespace + "Qn")!;
        Assert.Equal("Foo", qnEl.Value);
    }

    [Fact]
    public void Serialize_EmptyNamespace_WritesBareLocalName()
    {
        var message = new QNameTestMessage
        {
            QualifiedName = new XmlQualifiedName("Foo"), // empty namespace
        };

        var doc = Iso20022XmlSerializer.Serialize(message);

        var qnEl = doc.Root!.Element(doc.Root.Name.Namespace + "Root")!.Element(doc.Root.Name.Namespace + "Qn")!;
        Assert.Equal("Foo", qnEl.Value);
    }

    [Fact]
    public void Serialize_DifferentNamespace_Throws()
    {
        var message = new QNameTestMessage
        {
            QualifiedName = new XmlQualifiedName("Foo", "urn:some:other:namespace"),
        };

        Assert.Throws<NotSupportedException>(() => Iso20022XmlSerializer.Serialize(message));
    }

    [Fact]
    public void RoundTrip_SameNamespaceAsDocument_Succeeds()
    {
        var original = new QNameTestMessage
        {
            QualifiedName = new XmlQualifiedName("Foo", "urn:test:qname"),
        };

        var xml = Iso20022XmlSerializer.SerializeToString(original);
        var roundTripped = Iso20022XmlSerializer.Deserialize<QNameTestMessage>(xml);

        Assert.Equal(original.QualifiedName, roundTripped.QualifiedName);
    }

    [Fact]
    public void Deserialize_BareLocalName_ResolvesAgainstDefaultNamespace()
    {
        const string xml = """
            <?xml version="1.0" encoding="UTF-8"?>
            <Document xmlns="urn:test:qname">
              <Root>
                <Qn>Foo</Qn>
              </Root>
            </Document>
            """;

        var message = Iso20022XmlSerializer.Deserialize<QNameTestMessage>(xml);

        Assert.Equal("Foo", message.QualifiedName.Name);
        Assert.Equal("urn:test:qname", message.QualifiedName.Namespace);
    }

    /// <summary>
    /// This serializer never itself writes a prefixed QName (see
    /// <see cref="Serialize_DifferentNamespace_Throws"/>), but a document produced by some other
    /// XML writer legitimately could — this proves parsing correctly resolves a real namespace
    /// prefix against the declarations in scope, not just the bare/default-namespace case.
    /// </summary>
    [Fact]
    public void Deserialize_PrefixedLocalName_ResolvesPrefixFromScope()
    {
        const string xml = """
            <?xml version="1.0" encoding="UTF-8"?>
            <Document xmlns="urn:test:qname" xmlns:other="urn:some:other:namespace">
              <Root>
                <Qn>other:Foo</Qn>
              </Root>
            </Document>
            """;

        var message = Iso20022XmlSerializer.Deserialize<QNameTestMessage>(xml);

        Assert.Equal("Foo", message.QualifiedName.Name);
        Assert.Equal("urn:some:other:namespace", message.QualifiedName.Namespace);
    }

    [Fact]
    public void Deserialize_UnboundPrefix_ThrowsFormatException()
    {
        const string xml = """
            <?xml version="1.0" encoding="UTF-8"?>
            <Document xmlns="urn:test:qname">
              <Root>
                <Qn>unbound:Foo</Qn>
              </Root>
            </Document>
            """;

        var ex = Assert.Throws<Iso20022FormatException>(() => Iso20022XmlSerializer.Deserialize<QNameTestMessage>(xml));
        Assert.Contains("unbound", ex.Message);
    }
}
