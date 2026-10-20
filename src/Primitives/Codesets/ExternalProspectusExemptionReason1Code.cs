// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the exemption to produce a prospectus.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// Versioned restriction of <see cref="ExternalProspectusExemptionReasonCode"/>. Length facet from
/// MCP: minLength=1, maxLength=4. No code values are currently published for this code set in the
/// MCP snapshot; kept as a permissive open struct per CLAUDE.md's external-standard-exception
/// guidance.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_io5_wKM6Ee-Az6cqXa0OFw")]
[Description(@"Specifies the reason for the exemption to produce a prospectus.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalProspectusExemptionReason1Code>))]
public readonly struct ExternalProspectusExemptionReason1Code : IIsoExternalCode, IEquatable<ExternalProspectusExemptionReason1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalProspectusExemptionReason1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalProspectusExemptionReason1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalProspectusExemptionReason1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalProspectusExemptionReason1Code"/>.</summary>
    public static implicit operator ExternalProspectusExemptionReason1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalProspectusExemptionReason1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalProspectusExemptionReason1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalProspectusExemptionReason1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalProspectusExemptionReason1Code a, ExternalProspectusExemptionReason1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalProspectusExemptionReason1Code a, ExternalProspectusExemptionReason1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalProspectusExemptionReason1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalProspectusExemptionReason1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalProspectusExemptionReason1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalProspectusExemptionReason1Code b) => a != b.Value;
}
