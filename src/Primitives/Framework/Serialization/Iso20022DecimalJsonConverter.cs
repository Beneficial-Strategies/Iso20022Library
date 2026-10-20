// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// Serializes <see cref="decimal"/> values as JSON strings rather than JSON numbers.
/// </summary>
/// <remarks>
/// Required by the ISO 20022 JSON binding specification (Annex A, 2018 whitepaper), rule 4b:
/// "All other data type values become strings — JSON numbers are not used, because JSON
/// parsers do not have a standard decimal precision for numbers."
/// This preserves the exact decimal representation of monetary amounts without floating-point
/// rounding.
/// </remarks>
public sealed class Iso20022DecimalJsonConverter : JsonConverter<decimal>
{
    /// <summary>Singleton — stateless, safe to share.</summary>
    public static readonly Iso20022DecimalJsonConverter Instance = new();

    // The xs:decimal lexical form: an optional sign, digits with an optional point, no thousands separator, no exponent.
    private const NumberStyles LexicalForm =
        NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite;

    /// <inheritdoc/>
    public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var str = reader.GetString();
            if (decimal.TryParse(str, LexicalForm, CultureInfo.InvariantCulture, out var value))
                return value;
            throw new JsonException($"Cannot parse '{str}' as a decimal.");
        }

        if (reader.TokenType == JsonTokenType.Number)
        {
            // The binding writes every decimal as a string; a number token is tolerated only in plain decimal notation.
            if (reader.ValueSpan.IndexOfAny((byte)'e', (byte)'E') >= 0)
                throw new JsonException("Cannot read a decimal written with an exponent; write it as a string of digits.");
            return reader.GetDecimal();
        }

        throw new JsonException($"Expected a JSON string or number for decimal, got {reader.TokenType}.");
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture));
}
