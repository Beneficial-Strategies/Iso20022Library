// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using System.Xml;

namespace BeneficialStrategies.Iso20022;

public class Iso20022XmlQualifiedNameJsonConverterTests
{
    private record Wrapper
    {
        public required XmlQualifiedName QualifiedName { get; init; }
    }

    [Fact]
    public void RoundTrip_WithNamespace_Succeeds()
    {
        var original = new Wrapper { QualifiedName = new XmlQualifiedName("Foo", "http://example.com/schema") };

        var json = JsonSerializer.Serialize(original, Iso20022JsonSerializerOptions.Default);
        var roundTripped = JsonSerializer.Deserialize<Wrapper>(json, Iso20022JsonSerializerOptions.Default);

        Assert.Equal(original.QualifiedName, roundTripped!.QualifiedName);
    }

    [Fact]
    public void RoundTrip_EmptyNamespace_Succeeds()
    {
        var original = new Wrapper { QualifiedName = new XmlQualifiedName("Foo") };

        var json = JsonSerializer.Serialize(original, Iso20022JsonSerializerOptions.Default);
        var roundTripped = JsonSerializer.Deserialize<Wrapper>(json, Iso20022JsonSerializerOptions.Default);

        Assert.Equal(original.QualifiedName, roundTripped!.QualifiedName);
    }

    [Fact]
    public void Write_NamespaceContainingColons_UsesLastColonAsLocalNameSeparator()
    {
        // The namespace URI itself contains colons ("http://..."); the converter must split on
        // the LAST colon when reading, not the first, or this would misparse.
        var original = new Wrapper { QualifiedName = new XmlQualifiedName("Foo", "http://example.com/schema") };

        var json = JsonSerializer.Serialize(original, Iso20022JsonSerializerOptions.Default);

        Assert.Contains("http://example.com/schema:Foo", json);
    }
}
