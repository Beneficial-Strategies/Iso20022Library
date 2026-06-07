// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external credit line type code in the format of character string with a maximum length of 4 characters.
/// </summary>
/// <remarks>
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_QJ-OIYZ6Eee8r9VKRbnJSg")]
[Description(@"Specifies the external credit line type code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code set published separately.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalCreditLineTypeCode>))]
public readonly struct ExternalCreditLineTypeCode : IIsoExternalCode, IEquatable<ExternalCreditLineTypeCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given credit line type code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalCreditLineTypeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalCreditLineTypeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalCreditLineTypeCode result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalCreditLineTypeCode"/>.</summary>
    public static implicit operator ExternalCreditLineTypeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalCreditLineTypeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalCreditLineTypeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalCreditLineTypeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(ExternalCreditLineTypeCode a, ExternalCreditLineTypeCode b) => a.Equals(b);
    public static bool operator !=(ExternalCreditLineTypeCode a, ExternalCreditLineTypeCode b) => !a.Equals(b);
    public static bool operator ==(ExternalCreditLineTypeCode a, string? b) => a.Value == b;
    public static bool operator !=(ExternalCreditLineTypeCode a, string? b) => a.Value != b;
    public static bool operator ==(string? a, ExternalCreditLineTypeCode b) => a == b.Value;
    public static bool operator !=(string? a, ExternalCreditLineTypeCode b) => a != b.Value;
}
