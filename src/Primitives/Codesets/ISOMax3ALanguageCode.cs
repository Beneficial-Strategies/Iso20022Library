// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the language name in accordance with ISO 639-1 and ISO 639-2. The type is validated by the list of values coded with two or three alphabetic characters, defined in the standard.
/// </summary>
/// <remarks>
/// Pattern facet from MCP get_code_set_details: [a-z]{2,3}
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_zfXzMcWcEeuhguwJmlgagQ")]
[Description(@"Identification of the language name in accordance with ISO 639-1 and ISO 639-2. The type is validated by the list of values coded with two or three alphabetic characters, defined in the standard.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ISOMax3ALanguageCode>))]
public readonly struct ISOMax3ALanguageCode : IIsoExternalCode, IEquatable<ISOMax3ALanguageCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^[a-z]{2,3}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ISOMax3ALanguageCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ISOMax3ALanguageCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ISOMax3ALanguageCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ISOMax3ALanguageCode"/>.</summary>
    public static implicit operator ISOMax3ALanguageCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ISOMax3ALanguageCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ISOMax3ALanguageCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISOMax3ALanguageCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ISOMax3ALanguageCode a, ISOMax3ALanguageCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISOMax3ALanguageCode a, ISOMax3ALanguageCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISOMax3ALanguageCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISOMax3ALanguageCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISOMax3ALanguageCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISOMax3ALanguageCode b) => a != b.Value;
}
