// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// <see cref="JsonConverterFactory"/> that handles <see cref="ImmutableValueList{T}"/>,
/// <see cref="ValueList{T}"/>, and <see cref="SimpleValueList{T}"/> for
/// <see cref="System.Text.Json"/> serialization.
/// </summary>
/// <remarks>
/// Register once via <see cref="JsonSerializerOptions.Converters"/>:
/// <code>
/// options.Converters.Add(ImmutableValueListConverterFactory.Instance);
/// </code>
/// This is required for MassTransit (or any STJ-based serializer) to correctly
/// round-trip collection properties on ISO 20022 message records.
/// </remarks>
public sealed class ImmutableValueListConverterFactory : JsonConverterFactory
{
    /// <summary>Singleton — no state, safe to share.</summary>
    public static readonly ImmutableValueListConverterFactory Instance = new();

    /// <inheritdoc/>
    public override bool CanConvert(Type typeToConvert)
    {
        if (!typeToConvert.IsGenericType) return false;
        var def = typeToConvert.GetGenericTypeDefinition();
        return def == typeof(ImmutableValueList<>)
            || def == typeof(ValueList<>)
            || def == typeof(SimpleValueList<>);
    }

    /// <inheritdoc/>
    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var elementType = typeToConvert.GetGenericArguments()[0];
        var converterType = typeof(ImmutableValueListConverter<>).MakeGenericType(elementType);
        return (JsonConverter)Activator.CreateInstance(converterType, typeToConvert)!;
    }
}

/// <summary>
/// Reads and writes <see cref="ImmutableValueList{T}"/> (and its subclasses
/// <see cref="ValueList{T}"/> / <see cref="SimpleValueList{T}"/>) as JSON arrays.
/// </summary>
internal sealed class ImmutableValueListConverter<T> : JsonConverter<ImmutableValueList<T>>
{
    private readonly Type _concreteType;

    public ImmutableValueListConverter(Type concreteType) => _concreteType = concreteType;

    public override ImmutableValueList<T>? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return null;

        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException(
                $"Expected a JSON array to deserialize {typeToConvert.Name}, got {reader.TokenType}.");

        var items = new List<T>();
        while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
            items.Add(JsonSerializer.Deserialize<T>(ref reader, options)!);

        if (_concreteType == typeof(ValueList<T>))       return new ValueList<T>(items);
        if (_concreteType == typeof(SimpleValueList<T>)) return new SimpleValueList<T>(items);
        return new ImmutableValueList<T>(items);
    }

    public override void Write(
        Utf8JsonWriter writer,
        ImmutableValueList<T> value,
        JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        foreach (var item in value)
            JsonSerializer.Serialize(writer, item, typeof(T), options);
        writer.WriteEndArray();
    }
}
