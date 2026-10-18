// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the requested action, as published in an external investigation action code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_ezFrcBZdEe6d6Ip1Ob2kaQ")]
[Description(@"Specifies the requested action, as published in an external investigation action code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationActionCode>))]
public readonly struct ExternalInvestigationActionCode : IIsoExternalCode, IEquatable<ExternalInvestigationActionCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation action code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationActionCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationActionCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationActionCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationActionCode"/>.</summary>
    public static implicit operator ExternalInvestigationActionCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationActionCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationActionCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationActionCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationActionCode a, ExternalInvestigationActionCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationActionCode a, ExternalInvestigationActionCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationActionCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationActionCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationActionCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationActionCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Responder is requested to close the investigation. All investigation requests relating to the investigation may be disregarded.</summary>
    [IsoId("__-OZINYUEe68t8Cw380-tA")]
    [Description(@"Responder is requested to close the investigation. All investigation requests relating to the investigation may be disregarded.")]
    public static readonly ExternalInvestigationActionCode RequestInvestigationClosure = new("RQCL");

    /// <summary>Responder is requested to review an earlier response as the requestor objects to it.</summary>
    [IsoId("__-YKIdYUEe68t8Cw380-tA")]
    [Description(@"Responder is requested to review an earlier response as the requestor objects to it.")]
    public static readonly ExternalInvestigationActionCode RequestObjection = new("RQOB");

    /// <summary>Responder is requested to provide the status of the investigation.</summary>
    [IsoId("__-YKINYUEe68t8Cw380-tA")]
    [Description(@"Responder is requested to provide the status of the investigation.")]
    public static readonly ExternalInvestigationActionCode RequestInvestigationStatus = new("RQST");
}
