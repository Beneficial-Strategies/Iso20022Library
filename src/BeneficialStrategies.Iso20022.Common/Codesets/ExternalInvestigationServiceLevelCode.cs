// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation service level, as published in an external investigation service level code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_aWp4EE-6Ee2Vhrd5MAjFrA")]
[Description(@"Specifies the investigation service level, as published in an external investigation service level code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationServiceLevelCode>))]
public readonly struct ExternalInvestigationServiceLevelCode : IIsoExternalCode, IEquatable<ExternalInvestigationServiceLevelCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation service level code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationServiceLevelCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationServiceLevelCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationServiceLevelCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationServiceLevelCode"/>.</summary>
    public static implicit operator ExternalInvestigationServiceLevelCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationServiceLevelCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationServiceLevelCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationServiceLevelCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationServiceLevelCode a, ExternalInvestigationServiceLevelCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationServiceLevelCode a, ExternalInvestigationServiceLevelCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationServiceLevelCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationServiceLevelCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationServiceLevelCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationServiceLevelCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Response expected within one business day.</summary>
    [IsoId("__-02FtYUEe68t8Cw380-tA")]
    [Description(@"Response expected within one business day.")]
    public static readonly ExternalInvestigationServiceLevelCode RespondWithinOneBusinessDay = new("R01D");

    /// <summary>Response expected within three business days.</summary>
    [IsoId("__-02F9YUEe68t8Cw380-tA")]
    [Description(@"Response expected within three business days.")]
    public static readonly ExternalInvestigationServiceLevelCode RespondWithinThreeBusinessDays = new("R03D");

    /// <summary>Response expected within five business days.</summary>
    [IsoId("__-02GNYUEe68t8Cw380-tA")]
    [Description(@"Response expected within five business days.")]
    public static readonly ExternalInvestigationServiceLevelCode RespondWithinFiveBusinessDays = new("R05D");

    /// <summary>Response expected within ten business days.</summary>
    [IsoId("__-02GdYUEe68t8Cw380-tA")]
    [Description(@"Response expected within ten business days.")]
    public static readonly ExternalInvestigationServiceLevelCode RespondWithinTenBusinessDays = new("R10D");

    /// <summary>Response expected within fifteen business days.</summary>
    [IsoId("__-02GtYUEe68t8Cw380-tA")]
    [Description(@"Response expected within fifteen business days.")]
    public static readonly ExternalInvestigationServiceLevelCode RespondWithinFifteenBusinessDays = new("R15D");
}
