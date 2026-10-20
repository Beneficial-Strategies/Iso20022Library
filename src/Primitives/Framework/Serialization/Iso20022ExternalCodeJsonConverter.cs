// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// Reads and writes an ISO 20022 external code value (a <see cref="IIsoExternalCode"/>
/// <c>readonly struct</c>) as a plain JSON string.
/// </summary>
/// <typeparam name="T">The external code struct type.</typeparam>
public sealed class Iso20022ExternalCodeJsonConverter<T> : JsonConverter<T>
    where T : struct, IIsoExternalCode
{
    /// <inheritdoc/>
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var str = reader.GetString()
            ?? throw new JsonException($"Expected a string value for {typeof(T).Name}.");
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
        => writer.WriteStringValue(value.Value);
}
