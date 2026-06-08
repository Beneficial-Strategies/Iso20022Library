// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external discrepancy type code in the format of a character string with a maximum length of 4 characters.
/// </summary>
/// <remarks>
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_-M07A27iEeKo25nLKvGr8w_192954030")]
[Description(@"Specifies the external discrepancy type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalDiscrepancyCode>))]
public readonly struct ExternalDiscrepancyCode : IIsoExternalCode, IEquatable<ExternalDiscrepancyCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given discrepancy code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalDiscrepancyCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalDiscrepancyCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalDiscrepancyCode result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalDiscrepancyCode"/>.</summary>
    public static implicit operator ExternalDiscrepancyCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalDiscrepancyCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalDiscrepancyCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalDiscrepancyCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalDiscrepancyCode a, ExternalDiscrepancyCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalDiscrepancyCode a, ExternalDiscrepancyCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalDiscrepancyCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalDiscrepancyCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalDiscrepancyCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalDiscrepancyCode b) => a != b.Value;
}
