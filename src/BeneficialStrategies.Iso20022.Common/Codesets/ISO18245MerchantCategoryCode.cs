// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code used to enable the classification of merchants into specific categories based on the type of business, trade or services supplied. Values are specified only for those merchant categories that are generally expected to originate retail financial transactions (ISO 18245). The code is checked against the list of merchant categories coded with four digit characters, defined in the standard.
/// </summary>
/// <remarks>
/// Pattern facet from MCP get_code_set_details: [0-9]{4,4}
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_UGGW8cpBEeuuJ571wNLKkA")]
[Description(@"Code used to enable the classification of merchants into specific categories based on the type of business, trade or services supplied. Values are specified only for those merchant categories that are generally expected to originate retail financial transactions (ISO 18245). The code is checked against the list of merchant categories coded with four digit characters, defined in the standard.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ISO18245MerchantCategoryCode>))]
public readonly struct ISO18245MerchantCategoryCode : IIsoExternalCode, IEquatable<ISO18245MerchantCategoryCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^[0-9]{4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ISO18245MerchantCategoryCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ISO18245MerchantCategoryCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ISO18245MerchantCategoryCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ISO18245MerchantCategoryCode"/>.</summary>
    public static implicit operator ISO18245MerchantCategoryCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ISO18245MerchantCategoryCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ISO18245MerchantCategoryCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISO18245MerchantCategoryCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ISO18245MerchantCategoryCode a, ISO18245MerchantCategoryCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISO18245MerchantCategoryCode a, ISO18245MerchantCategoryCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISO18245MerchantCategoryCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISO18245MerchantCategoryCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISO18245MerchantCategoryCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISO18245MerchantCategoryCode b) => a != b.Value;
}
