// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// Reads and writes an <see cref="IIsoSimpleValue{TValue}"/> struct (where T is <see cref="byte"/>[])
/// as a base64-encoded JSON string. Used by binary types such as <c>XsdBase64Binary</c>.
/// </summary>
/// <remarks>
/// Neither <see cref="Iso20022SimpleValueJsonConverter{T}"/> (hardcoded to <see cref="string"/>)
/// nor <see cref="Iso20022NumericValueJsonConverter{TStruct,TValue}"/> (constrained to
/// <c>TValue : struct</c> — <see cref="byte"/>[] is a reference type) fit a binary-backed simple
/// value, so this is a dedicated converter following the same shape: deserialize by invoking the
/// struct's own <c>(string value)</c> constructor (which base64-decodes and validates), serialize
/// by calling the struct's own <see cref="object.ToString"/> override (which base64-encodes).
/// </remarks>
/// <typeparam name="T">The binary-backed simple-value struct type.</typeparam>
public sealed class Iso20022BinaryValueJsonConverter<T> : JsonConverter<T>
    where T : struct, IIsoSimpleValue<byte[]>
{
    /// <inheritdoc/>
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var str = reader.GetString()
            ?? throw new JsonException($"Expected a base64 string value for {typeof(T).Name}.");
        try
        {
            return (T)Activator.CreateInstance(typeof(T), str)!;
        }
        catch (System.Reflection.TargetInvocationException ex) when (ex.InnerException is Iso20022FormatException fmt)
        {
            throw new JsonException(fmt.Message, ex);
        }
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.ToString());
}
