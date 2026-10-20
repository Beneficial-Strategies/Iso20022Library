// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of post trade event, as published in an external post trade event type code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// Per MCP, a versioned restriction of ExternalPostTradeEventTypeCode.
/// Length facet from MCP: 1-4 characters
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_qgHkIBKhEe-gDPwV33LaCw")]
[Description(@"Specifies the type of post trade event, as published in an external post trade event type code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPostTradeEventType1Code>))]
public readonly struct ExternalPostTradeEventType1Code : IIsoExternalCode, IEquatable<ExternalPostTradeEventType1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPostTradeEventType1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPostTradeEventType1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPostTradeEventType1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPostTradeEventType1Code"/>.</summary>
    public static implicit operator ExternalPostTradeEventType1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPostTradeEventType1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPostTradeEventType1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPostTradeEventType1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTradeEventType1Code a, ExternalPostTradeEventType1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTradeEventType1Code a, ExternalPostTradeEventType1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalPostTradeEventType1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalPostTradeEventType1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalPostTradeEventType1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalPostTradeEventType1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Trade will be settled early.</summary>
    [IsoId("_U5SB8fXXEe-Ig-GynGPh9A")]
    [Description(@"Trade will be settled early.")]
    public static readonly ExternalPostTradeEventType1Code EarlyDelivery = new("EAMT");

    /// <summary>Trade will be partially settled early.</summary>
    [IsoId("_U5TQEfXXEe-Ig-GynGPh9A")]
    [Description(@"Trade will be partially settled early.")]
    public static readonly ExternalPostTradeEventType1Code PartialEarlyDelivery = new("PEAM");

    /// <summary>Part of the trade will be settled on its original date and the remainder will rollover.</summary>
    [IsoId("_U5T3IfXXEe-Ig-GynGPh9A")]
    [Description(@"Part of the trade will be settled on its original date and the remainder will rollover.")]
    public static readonly ExternalPostTradeEventType1Code PartialUnwindRollover = new("PRUR");

    /// <summary>Part of the trade will not be settled.</summary>
    [IsoId("_U5UeMfXXEe-Ig-GynGPh9A")]
    [Description(@"Part of the trade will not be settled.")]
    public static readonly ExternalPostTradeEventType1Code PartialUnwind = new("PRUW");

    /// <summary>Rollover of a previous trade.</summary>
    [IsoId("_U5VFQfXXEe-Ig-GynGPh9A")]
    [Description(@"Rollover of a previous trade.")]
    public static readonly ExternalPostTradeEventType1Code Rollover = new("ROLL");

    /// <summary>Trade will not be settled.</summary>
    [IsoId("_U5VsUfXXEe-Ig-GynGPh9A")]
    [Description(@"Trade will not be settled.")]
    public static readonly ExternalPostTradeEventType1Code Unwind = new("UNWD");

    /// <summary>Original trade will not settle on its original date, but will be rolled over.</summary>
    [IsoId("_U5WTYfXXEe-Ig-GynGPh9A")]
    [Description(@"Original trade will not settle on its original date, but will be rolled over.")]
    public static readonly ExternalPostTradeEventType1Code UnwindRollover = new("UNWR");
}
