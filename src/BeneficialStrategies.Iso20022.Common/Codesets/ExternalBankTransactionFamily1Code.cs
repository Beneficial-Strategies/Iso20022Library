// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the bank transaction code family, as published in an external bank transaction code family code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amL5ltp-Ed-ak6NoX_4Aeg_482415289")]
[Description(@"Specifies the bank transaction code family, as published in an external bank transaction code family code list.")]
[DerivedFrom(typeof(ExternalBankTransactionFamilyCode))]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalBankTransactionFamily1Code>))]
public readonly struct ExternalBankTransactionFamily1Code : IIsoExternalCode, IEquatable<ExternalBankTransactionFamily1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given family code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalBankTransactionFamily1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalBankTransactionFamily1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalBankTransactionFamily1Code result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalBankTransactionFamily1Code"/>.</summary>
    public static implicit operator ExternalBankTransactionFamily1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalBankTransactionFamily1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalBankTransactionFamily1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalBankTransactionFamily1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(ExternalBankTransactionFamily1Code a, ExternalBankTransactionFamily1Code b) => a.Equals(b);
    public static bool operator !=(ExternalBankTransactionFamily1Code a, ExternalBankTransactionFamily1Code b) => !a.Equals(b);
    public static bool operator ==(ExternalBankTransactionFamily1Code a, string? b) => a.Value == b;
    public static bool operator !=(ExternalBankTransactionFamily1Code a, string? b) => a.Value != b;
    public static bool operator ==(string? a, ExternalBankTransactionFamily1Code b) => a == b.Value;
    public static bool operator !=(string? a, ExternalBankTransactionFamily1Code b) => a != b.Value;
}
