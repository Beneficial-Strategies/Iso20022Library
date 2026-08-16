// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// System of National Accounts (SNA) Sector. Hierarchical classification of the sectors, as defined in the System of National Accounts 2008, as published by the United Nations.
/// </summary>
/// <remarks>
/// ISO 20022 itself defines no format for this identifier ("IdentifierSet, no formal pattern").
/// Per CLAUDE.md's exception for primitives defined by an external standard: the top-level 2008
/// SNA institutional sector codes are confirmed as <c>S1</c> (total economy), <c>S11</c>
/// (non-financial corporations), <c>S12</c> (financial corporations), <c>S13</c> (general
/// government), <c>S14</c>/<c>S15</c> (households / NPISH), <c>S2</c> (rest of world) — i.e.
/// <c>S</c> followed by digits. Source:
/// <see href="https://unstats.un.org/unsd/nationalaccount/docs/sna2008.pdf">UN Statistics Division — System of National Accounts, 2008</see>.
/// National/regional implementations (e.g. Eurostat's ESA sector table) subdivide further with
/// more digits (sub-sectors like S121, S1311...) — the exact maximum subdivision depth wasn't
/// independently confirmed, so the digit count below is a generous, not verified-exact, bound.
/// Tighten if an authoritative maximum depth is ever confirmed.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_TfPuobzXEeSVlt2o_pgoFw")]
[Description(@"System of National Accounts (SNA) Sector. Hierarchical classification of the sectors, as defined in the System of National Accounts 2008, as published by the United Nations.")]
[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<SNA2008SectorIdentifier>))]
public readonly struct SNA2008SectorIdentifier : IIsoSimpleValue<string>, IEquatable<SNA2008SectorIdentifier>
{
    /// <summary>"S" followed by 1-4 digits — confirmed shape, generous (not verified-exact) depth bound (see type remarks for source).</summary>
    public const string Pattern = @"^S[0-9]{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public SNA2008SectorIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(SNA2008SectorIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out SNA2008SectorIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="SNA2008SectorIdentifier"/>.</summary>
    public static implicit operator SNA2008SectorIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(SNA2008SectorIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(SNA2008SectorIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is SNA2008SectorIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(SNA2008SectorIdentifier a, SNA2008SectorIdentifier b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(SNA2008SectorIdentifier a, SNA2008SectorIdentifier b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(SNA2008SectorIdentifier a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(SNA2008SectorIdentifier a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, SNA2008SectorIdentifier b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, SNA2008SectorIdentifier b) => a != b.Value;
}
