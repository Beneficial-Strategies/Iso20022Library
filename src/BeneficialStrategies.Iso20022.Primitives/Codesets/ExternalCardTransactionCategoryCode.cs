// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of card transaction in the format of character string with a maximum length of 4 characters.
/// </summary>
/// <remarks>
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_vvvlQOVMEeG_peKHD7roXg_867046187")]
[Description(@"Specifies the category of card transaction in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalCardTransactionCategoryCode>))]
public readonly struct ExternalCardTransactionCategoryCode : IIsoExternalCode, IEquatable<ExternalCardTransactionCategoryCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given category code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalCardTransactionCategoryCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalCardTransactionCategoryCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalCardTransactionCategoryCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalCardTransactionCategoryCode"/>.</summary>
    public static implicit operator ExternalCardTransactionCategoryCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalCardTransactionCategoryCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalCardTransactionCategoryCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalCardTransactionCategoryCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalCardTransactionCategoryCode a, ExternalCardTransactionCategoryCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalCardTransactionCategoryCode a, ExternalCardTransactionCategoryCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalCardTransactionCategoryCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalCardTransactionCategoryCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalCardTransactionCategoryCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalCardTransactionCategoryCode b) => a != b.Value;
}
