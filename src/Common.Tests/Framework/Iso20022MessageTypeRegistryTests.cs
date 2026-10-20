// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Framework;
using BeneficialStrategies.Iso20022.pacs;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Tests for <see cref="Iso20022MessageTypeRegistry"/> — the one-time reflection scan mapping
/// every <see cref="IOuterRecord"/> message type in the assembly to its ISO 20022 message
/// identifier and XML document namespace.
/// </summary>
public class Iso20022MessageTypeRegistryTests
{
    [Fact]
    public void ByIsoIdentifier_ContainsKnownMessage_MapsToCorrectType()
    {
        Assert.True(Iso20022MessageTypeRegistry.ByIsoIdentifier.TryGetValue("pacs.029.001.02", out var type));
        Assert.Equal(typeof(MultilateralSettlementRequestV02), type);
    }

    [Fact]
    public void ByDocumentNamespace_ContainsKnownMessage_MapsToCorrectType()
    {
        Assert.True(
            Iso20022MessageTypeRegistry.ByDocumentNamespace.TryGetValue(
                "urn:iso:std:iso:20022:tech:xsd:pacs.029.001.02",
                out var type
            )
        );
        Assert.Equal(typeof(MultilateralSettlementRequestV02), type);
    }

    [Fact]
    public void TryGetByIsoIdentifier_KnownIdentifier_ReturnsTrue()
    {
        var found = Iso20022MessageTypeRegistry.TryGetByIsoIdentifier("pacs.029.001.02", out var type);

        Assert.True(found);
        Assert.Equal(typeof(MultilateralSettlementRequestV02), type);
    }

    [Fact]
    public void TryGetByIsoIdentifier_UnknownIdentifier_ReturnsFalse()
    {
        var found = Iso20022MessageTypeRegistry.TryGetByIsoIdentifier("xxxx.999.999.99", out var type);

        Assert.False(found);
        Assert.Null(type);
    }

    [Fact]
    public void TryGetByDocumentNamespace_KnownNamespace_ReturnsTrue()
    {
        var found = Iso20022MessageTypeRegistry.TryGetByDocumentNamespace(
            "urn:iso:std:iso:20022:tech:xsd:pacs.029.001.02",
            out var type
        );

        Assert.True(found);
        Assert.Equal(typeof(MultilateralSettlementRequestV02), type);
    }

    [Fact]
    public void TryGetByDocumentNamespace_UnknownNamespace_ReturnsFalse()
    {
        var found = Iso20022MessageTypeRegistry.TryGetByDocumentNamespace("urn:not-iso20022", out var type);

        Assert.False(found);
        Assert.Null(type);
    }

    [Fact]
    public void Registry_OnlyContainsConcreteOuterRecordTypes()
    {
        // Every mapped type must actually implement IOuterRecord and be instantiable.
        foreach (var type in Iso20022MessageTypeRegistry.ByIsoIdentifier.Values)
        {
            Assert.False(type.IsAbstract);
            Assert.True(typeof(IOuterRecord).IsAssignableFrom(type));
        }
    }
}
