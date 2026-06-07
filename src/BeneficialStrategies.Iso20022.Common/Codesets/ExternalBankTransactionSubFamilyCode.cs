// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external sub-family code of the bank transaction code in the format of character string with a maximum length of 4 characters.
/// </summary>
/// <remarks>
/// This is the deepest level of the three-level Bank Transaction Code (BTC) hierarchy:
/// Domain → Family → <b>Sub-Family</b>.
/// <para>
/// Valid values are maintained externally by the ISO 20022 Registration Authority.
/// The list of valid codes is an external code list published separately, and is a sub-list of the bank transaction family code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </para>
/// <para>
/// Sub-Family codes are Domain+Family-dependent — you cannot validate a Sub-Family code
/// without knowing both the <see cref="ExternalBankTransactionDomainCode"/> and
/// <see cref="ExternalBankTransactionFamilyCode"/>.
/// </para>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_amVqkdp-Ed-ak6NoX_4Aeg_-1376829537")]
[Description(@"Specifies the external sub-family code of the bank transaction code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately, and is a sub-list of the bank transaction family code list.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalBankTransactionSubFamilyCode>))]
public readonly struct ExternalBankTransactionSubFamilyCode : IIsoExternalCode, IEquatable<ExternalBankTransactionSubFamilyCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given sub-family code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalBankTransactionSubFamilyCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalBankTransactionSubFamilyCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalBankTransactionSubFamilyCode result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalBankTransactionSubFamilyCode"/>.</summary>
    public static implicit operator ExternalBankTransactionSubFamilyCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalBankTransactionSubFamilyCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalBankTransactionSubFamilyCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalBankTransactionSubFamilyCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(ExternalBankTransactionSubFamilyCode a, ExternalBankTransactionSubFamilyCode b) => a.Equals(b);
    public static bool operator !=(ExternalBankTransactionSubFamilyCode a, ExternalBankTransactionSubFamilyCode b) => !a.Equals(b);
    public static bool operator ==(ExternalBankTransactionSubFamilyCode a, string? b) => a.Value == b;
    public static bool operator !=(ExternalBankTransactionSubFamilyCode a, string? b) => a.Value != b;
    public static bool operator ==(string? a, ExternalBankTransactionSubFamilyCode b) => a == b.Value;
    public static bool operator !=(string? a, ExternalBankTransactionSubFamilyCode b) => a != b.Value;
}
