// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external financial institution identification scheme name code in the format of character string with a maximum length of 4 characters.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ame0gNp-Ed-ak6NoX_4Aeg_-1716707444")]
[Description(@"Specifies the external financial institution identification scheme name code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalFinancialInstitutionIdentificationCode))]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalFinancialInstitutionIdentification1Code>))]
public readonly struct ExternalFinancialInstitutionIdentification1Code : IIsoExternalCode, IEquatable<ExternalFinancialInstitutionIdentification1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given identification scheme code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalFinancialInstitutionIdentification1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalFinancialInstitutionIdentification1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalFinancialInstitutionIdentification1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalFinancialInstitutionIdentification1Code"/>.</summary>
    public static implicit operator ExternalFinancialInstitutionIdentification1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalFinancialInstitutionIdentification1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalFinancialInstitutionIdentification1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalFinancialInstitutionIdentification1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalFinancialInstitutionIdentification1Code a, ExternalFinancialInstitutionIdentification1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalFinancialInstitutionIdentification1Code a, ExternalFinancialInstitutionIdentification1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalFinancialInstitutionIdentification1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalFinancialInstitutionIdentification1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalFinancialInstitutionIdentification1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalFinancialInstitutionIdentification1Code b) => a != b.Value;
}
