// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// Reads and writes an <see cref="IIsoSimpleValue{TValue}"/> numeric struct as a JSON string
/// (e.g. <c>"42"</c>) to preserve backward compatibility with the prior <c>System.String</c>
/// representation. The struct's public <c>(string value)</c> constructor is invoked on
/// deserialization; <c>Value.ToString()</c> produces the wire string on serialization.
/// </summary>
/// <typeparam name="TStruct">The numeric simple-value struct type.</typeparam>
/// <typeparam name="TValue">The underlying numeric type (int, long, byte, etc.).</typeparam>
public sealed class Iso20022NumericValueJsonConverter<TStruct, TValue> : JsonConverter<TStruct>
    where TStruct : struct, IIsoSimpleValue<TValue>
    where TValue : struct
{
    /// <inheritdoc/>
    public override TStruct Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // Accept either a JSON string ("42") or a JSON number (42) for flexibility.
        var str = reader.TokenType == JsonTokenType.Number
            ? reader.GetInt64().ToString()
            : (reader.GetString()
               ?? throw new JsonException($"Expected a string or number for {typeof(TStruct).Name}."));
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
        => writer.WriteStringValue(value.Value.ToString());
}
