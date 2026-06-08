// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external domain code of the bank transaction code in the format of character string with a maximum length of 4 characters.
/// </summary>
/// <remarks>
/// This is the top level of the three-level Bank Transaction Code (BTC) hierarchy:
/// <b>Domain → Family → Sub-Family</b>.
/// <para>
/// Valid values are maintained externally by the ISO 20022 Registration Authority.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </para>
/// <para>
/// <b>Known domains:</b>
/// ACMT (Account Management), CAMT (Cash Management), CMDT (Commodities),
/// DERV (Derivatives), FORX (Foreign Exchange), LDAS (Loans, Deposits &amp; Syndications),
/// PMNT (Payments), PMET (Precious Metal), SECU (Securities), TRAD (Trade Services),
/// XTND (Extended Domain).
/// </para>
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_amL5ldp-Ed-ak6NoX_4Aeg_-2012123129")]
[Description(@"Specifies the external domain code of the bank transaction code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalBankTransactionDomainCode>))]
public readonly struct ExternalBankTransactionDomainCode : IIsoExternalCode, IEquatable<ExternalBankTransactionDomainCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given domain code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalBankTransactionDomainCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalBankTransactionDomainCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalBankTransactionDomainCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalBankTransactionDomainCode"/>.</summary>
    public static implicit operator ExternalBankTransactionDomainCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalBankTransactionDomainCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalBankTransactionDomainCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalBankTransactionDomainCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalBankTransactionDomainCode a, ExternalBankTransactionDomainCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalBankTransactionDomainCode a, ExternalBankTransactionDomainCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalBankTransactionDomainCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalBankTransactionDomainCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalBankTransactionDomainCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalBankTransactionDomainCode b) => a != b.Value;
}
