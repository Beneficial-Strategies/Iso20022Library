// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// Reads and writes any <see cref="IIsoSimpleValue{T}"/> struct (where T is <see cref="string"/>)
/// as a plain JSON string.  Used by length-constrained text types such as <c>Max35Text</c>.
/// </summary>
/// <remarks>
/// On deserialization the JSON string is passed to the struct's public <c>(string value)</c>
/// constructor, which validates ISO constraints and throws <see cref="Iso20022FormatException"/>
/// on failure.  The converter re-wraps that as <see cref="JsonException"/> so the JSON stack
/// sees a clean contract-compliant exception.
/// </remarks>
/// <typeparam name="T">The simple-value struct type.</typeparam>
public sealed class Iso20022SimpleValueJsonConverter<T> : JsonConverter<T>
    where T : struct, IIsoSimpleValue<string>
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
        catch (System.Reflection.TargetInvocationException ex) when (ex.InnerException is ArgumentNullException)
        {
            // Should never happen (we checked for null above), but guard anyway.
            throw new JsonException($"Unexpected null constructing {typeof(T).Name}.", ex);
        }
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.Value);
}
