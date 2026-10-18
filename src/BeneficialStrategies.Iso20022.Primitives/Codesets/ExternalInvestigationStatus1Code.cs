// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation status, as published in an external investigation status code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_w8jnQFEVEe2YkcF60skG_A")]
[Description(@"Specifies the investigation status, as published in an external investigation status code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationStatus1Code>))]
public readonly struct ExternalInvestigationStatus1Code : IIsoExternalCode, IEquatable<ExternalInvestigationStatus1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation status code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationStatus1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationStatus1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationStatus1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationStatus1Code"/>.</summary>
    public static implicit operator ExternalInvestigationStatus1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationStatus1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationStatus1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationStatus1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationStatus1Code a, ExternalInvestigationStatus1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationStatus1Code a, ExternalInvestigationStatus1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationStatus1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationStatus1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationStatus1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationStatus1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Investigation is closed.</summary>
    [IsoId("___asy9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is closed.")]
    public static readonly ExternalInvestigationStatus1Code InvestigationClosed = new("CLSD");

    /// <summary>Investigation is opened/pending.</summary>
    [IsoId("___aszdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is opened/pending.")]
    public static readonly ExternalInvestigationStatus1Code InvestigationPending = new("PDNG");

    /// <summary>Investigation is rejected.</summary>
    [IsoId("___asz9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is rejected.")]
    public static readonly ExternalInvestigationStatus1Code InvestigationRejected = new("RJCT");
}
