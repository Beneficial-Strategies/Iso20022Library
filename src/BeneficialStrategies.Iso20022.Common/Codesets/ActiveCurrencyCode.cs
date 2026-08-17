// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// A code allocated to a currency by a Maintenance Agency under an international identification scheme as described in the latest edition of the international standard ISO 4217 &quot;Codes for the representation of currencies and funds&quot;.
/// </summary>
/// <remarks>
/// Per MCP, a versioned restriction of ParentCurrencyCode — the currently-active subset of all currency codes ever allocated (contrast ActiveOrHistoricCurrencyCode, which also includes withdrawn codes).
/// Pattern facet from MCP get_code_set_details: [A-Z]{3,3}
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_bqIp5tp-Ed-ak6NoX_4Aeg_-1326801359")]
[Description(@"A code allocated to a currency by a Maintenance Agency under an international identification scheme as described in the latest edition of the international standard ISO 4217 ""Codes for the representation of currencies and funds"".")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ActiveCurrencyCode>))]
public readonly struct ActiveCurrencyCode : IIsoExternalCode, IEquatable<ActiveCurrencyCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^[A-Z]{3}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ActiveCurrencyCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ActiveCurrencyCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ActiveCurrencyCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ActiveCurrencyCode"/>.</summary>
    public static implicit operator ActiveCurrencyCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ActiveCurrencyCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ActiveCurrencyCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ActiveCurrencyCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ActiveCurrencyCode a, ActiveCurrencyCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ActiveCurrencyCode a, ActiveCurrencyCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ActiveCurrencyCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ActiveCurrencyCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ActiveCurrencyCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ActiveCurrencyCode b) => a != b.Value;
}
