// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the language name according to the ISO 639-1 codes. The type is validated by the list of values coded with two alphabetic characters, defined in the standard.
/// </summary>
/// <remarks>
/// Pattern facet from MCP get_code_set_details: [a-z]{2,2}
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_TUmCIAEcEeCQm6a_G2yO_w_637447613")]
[Description(@"Identification of the language name according to the ISO 639-1 codes. The type is validated by the list of values coded with two alphabetic characters, defined in the standard.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ISO2ALanguageCode>))]
public readonly struct ISO2ALanguageCode : IIsoExternalCode, IEquatable<ISO2ALanguageCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^[a-z]{2}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ISO2ALanguageCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ISO2ALanguageCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ISO2ALanguageCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ISO2ALanguageCode"/>.</summary>
    public static implicit operator ISO2ALanguageCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ISO2ALanguageCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ISO2ALanguageCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISO2ALanguageCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ISO2ALanguageCode a, ISO2ALanguageCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISO2ALanguageCode a, ISO2ALanguageCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISO2ALanguageCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISO2ALanguageCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISO2ALanguageCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISO2ALanguageCode b) => a != b.Value;
}
