// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zu_aYOIZEe-eFYnrXcX-mQ")]
[Description(@"Specifies the type of entity.")]
[Derivations(typeof(ExternalEntityType1Code))]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalEntityTypeCode>))]
public readonly struct ExternalEntityTypeCode : IIsoExternalCode, IEquatable<ExternalEntityTypeCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given entity type code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalEntityTypeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalEntityTypeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalEntityTypeCode result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalEntityTypeCode"/>.</summary>
    public static implicit operator ExternalEntityTypeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalEntityTypeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalEntityTypeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalEntityTypeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(ExternalEntityTypeCode a, ExternalEntityTypeCode b) => a.Equals(b);
    public static bool operator !=(ExternalEntityTypeCode a, ExternalEntityTypeCode b) => !a.Equals(b);
    public static bool operator ==(ExternalEntityTypeCode a, string? b) => a.Value == b;
    public static bool operator !=(ExternalEntityTypeCode a, string? b) => a.Value != b;
    public static bool operator ==(string? a, ExternalEntityTypeCode b) => a == b.Value;
    public static bool operator !=(string? a, ExternalEntityTypeCode b) => a != b.Value;
}
