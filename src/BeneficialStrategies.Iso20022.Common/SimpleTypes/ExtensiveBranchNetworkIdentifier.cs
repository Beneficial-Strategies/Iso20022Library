// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.SimpleTypes;

/// <summary>
/// The extensive branch network list of the Australian Bank State Branch (BSB) Code. The codes are used for identifying Australian financial institutions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YW-3ENp-Ed-ak6NoX_4Aeg_-1373497406")]
[Description(@"The extensive branch network list of the Australian Bank State Branch (BSB) Code. The codes are used for identifying Australian financial institutions.")]

[JsonConverter(typeof(Iso20022SimpleValueJsonConverter<ExtensiveBranchNetworkIdentifier>))]
public readonly struct ExtensiveBranchNetworkIdentifier : IIsoSimpleValue<string>, IEquatable<ExtensiveBranchNetworkIdentifier>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^AU[0-9]{6,6}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
    /// <exception cref="Iso20022FormatException">
    /// Thrown with <see cref="Iso20022FormatViolation.PatternMismatch"/> when the value
    /// does not satisfy <see cref="Pattern"/>.
    /// </exception>
    public ExtensiveBranchNetworkIdentifier(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExtensiveBranchNetworkIdentifier), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> when <paramref name="value"/> satisfies <see cref="Pattern"/>.</summary>
    public static bool TryCreate(string? value, [NotNullWhen(true)] out ExtensiveBranchNetworkIdentifier result)
    {
        if (value is not null && Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default; return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExtensiveBranchNetworkIdentifier"/>.</summary>
    public static implicit operator ExtensiveBranchNetworkIdentifier(string value) => new(value);
    /// <summary>Implicitly unwraps to the underlying string.</summary>
    public static implicit operator string(ExtensiveBranchNetworkIdentifier id) => id.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExtensiveBranchNetworkIdentifier other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExtensiveBranchNetworkIdentifier other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(ExtensiveBranchNetworkIdentifier a, ExtensiveBranchNetworkIdentifier b)  => a.Equals(b);
    public static bool operator !=(ExtensiveBranchNetworkIdentifier a, ExtensiveBranchNetworkIdentifier b)  => !a.Equals(b);
    public static bool operator ==(ExtensiveBranchNetworkIdentifier a, string? b)  => a.Value == b;
    public static bool operator !=(ExtensiveBranchNetworkIdentifier a, string? b)  => a.Value != b;
    public static bool operator ==(string? a, ExtensiveBranchNetworkIdentifier b)  => a == b.Value;
    public static bool operator !=(string? a, ExtensiveBranchNetworkIdentifier b)  => a != b.Value;
}
