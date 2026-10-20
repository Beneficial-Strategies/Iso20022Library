// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Serialization;

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
        if (!typeToConvert.IsGenericType)
            return false;
        var def = typeToConvert.GetGenericTypeDefinition();
        return def == typeof(ImmutableValueList<>)
            || def == typeof(ValueList<>)
            || def == typeof(SimpleValueList<>);
    }

    /// <inheritdoc/>
    public override JsonConverter? CreateConverter(
        Type typeToConvert,
        JsonSerializerOptions options
    )
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
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType == JsonTokenType.Null)
            return null;

        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException(
                $"Expected a JSON array to deserialize {typeToConvert.Name}, got {reader.TokenType}."
            );

        var items = new List<T>();
        while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
        {
            try
            {
                items.Add(JsonSerializer.Deserialize<T>(ref reader, options)!);
            }
            catch (JsonException ex)
            {
                throw new JsonListElementException(items.Count, ex);
            }
        }

        if (_concreteType == typeof(ValueList<T>))
            return new ValueList<T>(items);
        if (_concreteType == typeof(SimpleValueList<T>))
            return new SimpleValueList<T>(items);
        return new ImmutableValueList<T>(items);
    }

    public override void Write(
        Utf8JsonWriter writer,
        ImmutableValueList<T> value,
        JsonSerializerOptions options
    )
    {
        writer.WriteStartArray();
        foreach (var item in value)
            JsonSerializer.Serialize(writer, item, typeof(T), options);
        writer.WriteEndArray();
    }
}

/// <summary>
/// A failure inside one element of a JSON array. The nested read that <see cref="ImmutableValueListConverter{T}"/> makes starts a new
/// path of its own, so the element's index and the path inside it are kept here. <c>System.Text.Json</c> sets <see cref="JsonException.Path"/>
/// to the path of the list when the exception passes through it; <see cref="WithWholePath"/> appends the rest.
/// </summary>
internal sealed class JsonListElementException : JsonException
{
    public JsonListElementException(int index, JsonException inner)
        : base(inner is JsonListElementException e ? e.Detail : WithoutPath(inner), inner)
    {
        Detail = inner is JsonListElementException nested ? nested.Detail : WithoutPath(inner);
        Tail = $"[{index}]" + inner.Path?.TrimStart('$') + (inner as JsonListElementException)?.Tail;
    }

    /// <summary>The message without any path, as the innermost converter wrote it.</summary>
    public string Detail { get; }

    /// <summary>The path below the list, such as <c>[1].amount.currency</c>.</summary>
    public string Tail { get; }

    /// <summary>The same failure as a plain exception whose <see cref="JsonException.Path"/> is the whole path.</summary>
    internal JsonException WithWholePath()
    {
        var path = Path + Tail;
        return new JsonException($"{Detail} Path: {path}", path, LineNumber, BytePositionInLine, this);
    }

    public override string Message => Path is null ? Detail : $"{Detail} Path: {Path}{Tail}";

    // System.Text.Json appends " Path: $.x | LineNumber: n | BytePositionInLine: n." to the message.
    private static string WithoutPath(JsonException ex)
    {
        var i = ex.Message.IndexOf(" Path: ", StringComparison.Ordinal);
        return i < 0 ? ex.Message : ex.Message[..i];
    }
}
