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
/// Length facet from MCP: minLength=1, maxLength=4. No code values are currently published for
/// this code set in the MCP snapshot; kept as a permissive open struct per CLAUDE.md's
/// external-standard-exception guidance.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_io6m06M6Ee-Az6cqXa0OFw")]
[Description(@"Specifies the reason for the exemption to produce a prospectus.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalProspectusExemptionReasonCode>))]
public readonly struct ExternalProspectusExemptionReasonCode : IIsoExternalCode, IEquatable<ExternalProspectusExemptionReasonCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalProspectusExemptionReasonCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalProspectusExemptionReasonCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalProspectusExemptionReasonCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalProspectusExemptionReasonCode"/>.</summary>
    public static implicit operator ExternalProspectusExemptionReasonCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalProspectusExemptionReasonCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalProspectusExemptionReasonCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalProspectusExemptionReasonCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalProspectusExemptionReasonCode a, ExternalProspectusExemptionReasonCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalProspectusExemptionReasonCode a, ExternalProspectusExemptionReasonCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalProspectusExemptionReasonCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalProspectusExemptionReasonCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalProspectusExemptionReasonCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalProspectusExemptionReasonCode b) => a != b.Value;
}
