// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the requested action reason, as published in an external investigation action reason code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_5go_cCVAEe6EvsLBQ6cYtA")]
[Description(@"Specifies the requested action reason, as published in an external investigation action reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationActionReasonCode>))]
public readonly struct ExternalInvestigationActionReasonCode : IIsoExternalCode, IEquatable<ExternalInvestigationActionReasonCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation action reason code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationActionReasonCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationActionReasonCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationActionReasonCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationActionReasonCode"/>.</summary>
    public static implicit operator ExternalInvestigationActionReasonCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationActionReasonCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationActionReasonCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationActionReasonCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationActionReasonCode a, ExternalInvestigationActionReasonCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationActionReasonCode a, ExternalInvestigationActionReasonCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationActionReasonCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationActionReasonCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationActionReasonCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationActionReasonCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Objection is raised as the compensation amount quoted on the investigation response appears incorrect.</summary>
    [IsoId("__-YKJNYUEe68t8Cw380-tA")]
    [Description(@"Objection is raised as the compensation amount quoted on the investigation response appears incorrect.")]
    public static readonly ExternalInvestigationActionReasonCode InvestigationResponseCompensationDisputed = new("IRCD");

    /// <summary>Objection is raised as the data provided on the investigation response is insufficent to address the original request.</summary>
    [IsoId("__-YKJdYUEe68t8Cw380-tA")]
    [Description(@"Objection is raised as the data provided on the investigation response is insufficent to address the original request.")]
    public static readonly ExternalInvestigationActionReasonCode InvestigationResponseIncomplete = new("IRIC");

    /// <summary>Closure is requested as the investigation request has been resolved by requestor.</summary>
    [IsoId("__-YKI9YUEe68t8Cw380-tA")]
    [Description(@"Closure is requested as the investigation request has been resolved by requestor.")]
    public static readonly ExternalInvestigationActionReasonCode InvestigationRequestResolved = new("IRRR");

    /// <summary>Closure is requested as the investigation request was sent in error.</summary>
    [IsoId("__-YKItYUEe68t8Cw380-tA")]
    [Description(@"Closure is requested as the investigation request was sent in error.")]
    public static readonly ExternalInvestigationActionReasonCode InvestigationRequestSentInError = new("IRSI");

    /// <summary>See AdditionalInformation element for action reason.</summary>
    [IsoId("__-YKJtYUEe68t8Cw380-tA")]
    [Description(@"See AdditionalInformation element for action reason.")]
    public static readonly ExternalInvestigationActionReasonCode Narrative = new("NARR");
}
