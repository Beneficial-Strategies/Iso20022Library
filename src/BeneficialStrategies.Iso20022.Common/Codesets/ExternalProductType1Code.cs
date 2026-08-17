// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of asset class a non-equity financial instrument can be classified as.
/// </summary>
/// <remarks>
/// Per MCP, a versioned restriction of ExternalProductTypeCode.
/// Length facet from MCP: 1-4 characters
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_bgvXwG8vEe6_0L6gLGEkbA")]
[Description(@"Specifies the type of asset class a non-equity financial instrument can be classified as.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalProductType1Code>))]
public readonly struct ExternalProductType1Code : IIsoExternalCode, IEquatable<ExternalProductType1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalProductType1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalProductType1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalProductType1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalProductType1Code"/>.</summary>
    public static implicit operator ExternalProductType1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalProductType1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalProductType1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalProductType1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalProductType1Code a, ExternalProductType1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalProductType1Code a, ExternalProductType1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalProductType1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalProductType1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalProductType1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalProductType1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Identifies categories of instruments that are commodities.</summary>
    [IsoId("_bhjQE28vEe6_0L6gLGEkbA")]
    [Description(@"Identifies categories of instruments that are commodities.")]
    public static readonly ExternalProductType1Code Commodity = new("COMM");

    /// <summary>Identifies categories of instruments that are credits.</summary>
    [IsoId("_bhjQL28vEe6_0L6gLGEkbA")]
    [Description(@"Identifies categories of instruments that are credits.")]
    public static readonly ExternalProductType1Code Credit = new("CRDT");

    /// <summary>Identifies categories of currency instruments.</summary>
    [IsoId("_bhjQF28vEe6_0L6gLGEkbA")]
    [Description(@"Identifies categories of currency instruments.")]
    public static readonly ExternalProductType1Code Currency = new("CURR");

    /// <summary>Identifies categories of instruments related to emission allowance.</summary>
    [IsoId("_bhjQMW8vEe6_0L6gLGEkbA")]
    [Description(@"Identifies categories of instruments related to emission allowance.")]
    public static readonly ExternalProductType1Code EmissionAllowance = new("EMAL");

    /// <summary>Identifies categories of instruments related to an equity.</summary>
    [IsoId("_bhjQGW8vEe6_0L6gLGEkbA")]
    [Description(@"Identifies categories of instruments related to an equity.")]
    public static readonly ExternalProductType1Code Equity = new("EQUI");

    /// <summary>Identifies categories of instruments that are interest rates based.</summary>
    [IsoId("_bhjQLW8vEe6_0L6gLGEkbA")]
    [Description(@"Identifies categories of instruments that are interest rates based.")]
    public static readonly ExternalProductType1Code InterestRate = new("INTR");

    /// <summary>Identifies categories of instruments classified as other C10.</summary>
    [IsoId("_bhjQOW8vEe6_0L6gLGEkbA")]
    [Description(@"Identifies categories of instruments classified as other C10.")]
    public static readonly ExternalProductType1Code OtherC10 = new("OCTN");
}
