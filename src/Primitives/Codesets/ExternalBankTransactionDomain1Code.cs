// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the bank transaction code domain, as published in an external bank transaction code domain code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amL5lNp-Ed-ak6NoX_4Aeg_450092509")]
[Description(@"Specifies the bank transaction code domain, as published in an external bank transaction code domain code list.")]
[DerivedFrom(typeof(ExternalBankTransactionDomainCode))]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalBankTransactionDomain1Code>))]
public readonly struct ExternalBankTransactionDomain1Code : IIsoExternalCode, IEquatable<ExternalBankTransactionDomain1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given domain code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalBankTransactionDomain1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalBankTransactionDomain1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalBankTransactionDomain1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalBankTransactionDomain1Code"/>.</summary>
    public static implicit operator ExternalBankTransactionDomain1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalBankTransactionDomain1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalBankTransactionDomain1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalBankTransactionDomain1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalBankTransactionDomain1Code a, ExternalBankTransactionDomain1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalBankTransactionDomain1Code a, ExternalBankTransactionDomain1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalBankTransactionDomain1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalBankTransactionDomain1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalBankTransactionDomain1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalBankTransactionDomain1Code b) => a != b.Value;
}
