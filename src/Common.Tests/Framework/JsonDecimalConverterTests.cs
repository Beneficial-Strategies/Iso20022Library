// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022;

/// <summary><see cref="Iso20022DecimalJsonConverter"/> reads the xs:decimal lexical form and nothing wider (#78).</summary>
public class JsonDecimalConverterTests
{
    private static decimal Read(string json) => JsonSerializer.Deserialize<decimal>(json, Iso20022JsonSerializerOptions.Default);

    [Theory]
    [InlineData("\"47250.00\"", 47250.00)]
    [InlineData("\"+5\"", 5)]
    [InlineData("\"5.\"", 5)]
    [InlineData("\".5\"", 0.5)]
    [InlineData("\"-0.25\"", -0.25)]
    [InlineData("\" 7 \"", 7)]
    [InlineData("12.5", 12.5)]
    public void AValueInTheDecimalForm_IsRead(string json, double expected) => Assert.Equal((decimal)expected, Read(json));

    [Theory]
    [InlineData("\"1,000.50\"")]
    [InlineData("\"1e2\"")]
    [InlineData("\"1E2\"")]
    [InlineData("1.5e3")]
    [InlineData("1E2")]
    [InlineData("\"\"")]
    [InlineData("\"abc\"")]
    public void AValueOutsideTheDecimalForm_IsAJsonException(string json) => Assert.Throws<JsonException>(() => Read(json));
}
