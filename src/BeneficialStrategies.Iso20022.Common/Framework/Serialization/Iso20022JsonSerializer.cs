// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// JSON (de)serialization helpers for ISO 20022 message records, layered over
/// <see cref="System.Text.Json.JsonSerializer"/> configured with
/// <see cref="Iso20022JsonSerializerOptions.Default"/>.
/// </summary>
/// <remarks>
/// A thin, symmetrical counterpart to <see cref="Iso20022XmlSerializer"/> — most consumers can
/// (and today, do) call <c>System.Text.Json.JsonSerializer.Deserialize&lt;T&gt;(json,
/// Iso20022JsonSerializerOptions.Default)</c> directly; this class exists mainly for the
/// non-throwing <see cref="TryDeserialize{TMessage}"/> entry point, which callers building
/// exception-free "deserialize then validate" pipelines want but the BCL doesn't offer directly.
/// </remarks>
public static class Iso20022JsonSerializer
{
    /// <summary>Serializes an ISO 20022 message record to a JSON string.</summary>
    public static string SerializeToString<TMessage>(TMessage message)
        where TMessage : IOuterRecord =>
        JsonSerializer.Serialize(message, Iso20022JsonSerializerOptions.Default);

    /// <summary>Deserializes a JSON string to an ISO 20022 message record.</summary>
    /// <exception cref="JsonException">
    /// The JSON is malformed, or a value violates an ISO 20022 format constraint — every
    /// converter in <see cref="Iso20022JsonSerializerOptions.Default"/> wraps
    /// <see cref="Iso20022FormatException"/> as <see cref="JsonException"/>, so this single
    /// exception type covers both cases. See this project's own <c>CLAUDE.md</c> serialization
    /// contract table.
    /// </exception>
    public static TMessage Deserialize<TMessage>(string json)
        where TMessage : IOuterRecord =>
        JsonSerializer.Deserialize<TMessage>(json, Iso20022JsonSerializerOptions.Default)
        ?? throw new JsonException($"Deserializing '{typeof(TMessage).Name}' produced a null result.");

    /// <summary>
    /// Attempts to deserialize a JSON string to an ISO 20022 message record without throwing.
    /// </summary>
    /// <remarks>
    /// A <see langword="null"/> or empty <paramref name="json"/> argument is treated as a parse
    /// failure the same way malformed JSON text is, rather than throwing
    /// <see cref="ArgumentNullException"/>.
    /// </remarks>
    /// <returns><see langword="true"/> if deserialization succeeded; otherwise <see langword="false"/>.</returns>
    public static bool TryDeserialize<TMessage>(
        string? json,
        [NotNullWhen(true)] out TMessage? message,
        out Exception? error
    )
        where TMessage : class, IOuterRecord
    {
        try
        {
            if (string.IsNullOrEmpty(json))
                throw new JsonException("JSON payload is null or empty.");

            message = Deserialize<TMessage>(json);
            error = null;
            return true;
        }
        catch (Exception ex) when (ex is JsonException or NotSupportedException)
        {
            message = null;
            error = ex;
            return false;
        }
    }
}
