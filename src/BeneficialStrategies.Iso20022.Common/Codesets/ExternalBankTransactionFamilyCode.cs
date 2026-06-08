// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external family code of the bank transaction code in the format of character string with a maximum length of 4 characters.
/// </summary>
/// <remarks>
/// This is the middle level of the three-level Bank Transaction Code (BTC) hierarchy:
/// Domain → <b>Family</b> → Sub-Family.
/// <para>
/// Valid values are maintained externally by the ISO 20022 Registration Authority.
/// The list of valid codes is an external code list published separately, and is a sub-list of the bank transaction domain list.
/// External code sets can be downloaded from www.iso20022.org.
/// </para>
/// <para>
/// Family codes are Domain-dependent — a code valid in one Domain may not exist in another.
/// The accompanying <see cref="ExternalBankTransactionSubFamilyCode"/> must be valid within the Domain/Family pair.
/// </para>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_amL5l9p-Ed-ak6NoX_4Aeg_-1575387014")]
[Description(@"Specifies the external family code of the bank transaction code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately, and is a sub-list of the bank transaction domain list.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalBankTransactionFamilyCode>))]
public readonly struct ExternalBankTransactionFamilyCode : IIsoExternalCode, IEquatable<ExternalBankTransactionFamilyCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given family code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalBankTransactionFamilyCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalBankTransactionFamilyCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalBankTransactionFamilyCode result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalBankTransactionFamilyCode"/>.</summary>
    public static implicit operator ExternalBankTransactionFamilyCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalBankTransactionFamilyCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalBankTransactionFamilyCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalBankTransactionFamilyCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalBankTransactionFamilyCode a, ExternalBankTransactionFamilyCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalBankTransactionFamilyCode a, ExternalBankTransactionFamilyCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalBankTransactionFamilyCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalBankTransactionFamilyCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalBankTransactionFamilyCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalBankTransactionFamilyCode b) => a != b.Value;
}
