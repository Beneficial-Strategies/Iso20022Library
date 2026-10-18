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
[IsoId("_3EMJUFEUEe2YkcF60skG_A")]
[Description(@"Specifies the investigation service level, as published in an external investigation service level code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationServiceLevel1Code>))]
public readonly struct ExternalInvestigationServiceLevel1Code : IIsoExternalCode, IEquatable<ExternalInvestigationServiceLevel1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation service level code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationServiceLevel1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationServiceLevel1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationServiceLevel1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationServiceLevel1Code"/>.</summary>
    public static implicit operator ExternalInvestigationServiceLevel1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationServiceLevel1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationServiceLevel1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationServiceLevel1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationServiceLevel1Code a, ExternalInvestigationServiceLevel1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationServiceLevel1Code a, ExternalInvestigationServiceLevel1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationServiceLevel1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationServiceLevel1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationServiceLevel1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationServiceLevel1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Response expected within one business day.</summary>
    [IsoId("___as99YUEe68t8Cw380-tA")]
    [Description(@"Response expected within one business day.")]
    public static readonly ExternalInvestigationServiceLevel1Code RespondWithinOneBusinessDay = new("R01D");

    /// <summary>Response expected within three business days.</summary>
    [IsoId("___as-dYUEe68t8Cw380-tA")]
    [Description(@"Response expected within three business days.")]
    public static readonly ExternalInvestigationServiceLevel1Code RespondWithinThreeBusinessDays = new("R03D");

    /// <summary>Response expected within five business days.</summary>
    [IsoId("___as-9YUEe68t8Cw380-tA")]
    [Description(@"Response expected within five business days.")]
    public static readonly ExternalInvestigationServiceLevel1Code RespondWithinFiveBusinessDays = new("R05D");

    /// <summary>Response expected within ten business days.</summary>
    [IsoId("___as_dYUEe68t8Cw380-tA")]
    [Description(@"Response expected within ten business days.")]
    public static readonly ExternalInvestigationServiceLevel1Code RespondWithinTenBusinessDays = new("R10D");

    /// <summary>Response expected within fifteen business days.</summary>
    [IsoId("___as_9YUEe68t8Cw380-tA")]
    [Description(@"Response expected within fifteen business days.")]
    public static readonly ExternalInvestigationServiceLevel1Code RespondWithinFifteenBusinessDays = new("R15D");
}
