// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// Reads and writes an <see cref="IIsoSimpleValue{TValue}"/> scalar struct as a JSON string
/// (e.g. <c>"42"</c>, <c>"true"</c>, <c>"INF"</c>) to preserve backward compatibility with the
/// prior <c>System.String</c> representation. The struct's public <c>(string value)</c>
/// constructor is invoked on deserialization — which applies the type's own wire-format rules
/// (e.g. lowercase boolean literals, <c>INF</c>/<c>NaN</c> for floating-point) — and the
/// struct's own <see cref="object.ToString"/> override produces the wire string on
/// serialization. Despite the name, this converter serves any numeric, boolean, or
/// floating-point <c>IIsoSimpleValue&lt;TValue&gt;</c> struct, not integers alone.
/// </summary>
/// <typeparam name="TStruct">The scalar simple-value struct type.</typeparam>
/// <typeparam name="TValue">The underlying value type (int, long, bool, float, double, etc.).</typeparam>
public sealed class Iso20022NumericValueJsonConverter<TStruct, TValue> : JsonConverter<TStruct>
    where TStruct : struct, IIsoSimpleValue<TValue>
    where TValue : struct
{
    /// <inheritdoc/>
    public override TStruct Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // Accept a JSON string ("42", "true", "INF"), a JSON number (42, 42.5), or a JSON
        // boolean literal (true/false) for flexibility — decoding the raw token bytes preserves
        // numeric precision (including decimals) rather than forcing an int64 round trip.
        var str = reader.TokenType switch
        {
            JsonTokenType.String => reader.GetString()
                ?? throw new JsonException($"Expected a non-null string for {typeof(TStruct).Name}."),
            JsonTokenType.Number => Encoding.UTF8.GetString(reader.ValueSpan),
            JsonTokenType.True => "true",
            JsonTokenType.False => "false",
            _ => throw new JsonException($"Expected a string, number, or boolean for {typeof(TStruct).Name}."),
        };
        try
        {
            return (TStruct)Activator.CreateInstance(typeof(TStruct), str)!;
        }
        catch (System.Reflection.TargetInvocationException ex) when (ex.InnerException is Iso20022FormatException fmt)
        {
            throw new JsonException(fmt.Message, ex);
        }
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, TStruct value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.ToString());
}
