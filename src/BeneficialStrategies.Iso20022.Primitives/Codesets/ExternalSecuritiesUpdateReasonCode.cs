// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the securities update reason, as published in an external securities update reason code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// Per MCP, derived by ExternalSecuritiesUpdateReason1Code.
/// Length facet from MCP: 1-4 characters
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_krTys5I7EeuAlLVx8pyt3w")]
[Description(@"Specifies the securities update reason, as published in an external securities update reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalSecuritiesUpdateReasonCode>))]
public readonly struct ExternalSecuritiesUpdateReasonCode : IIsoExternalCode, IEquatable<ExternalSecuritiesUpdateReasonCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalSecuritiesUpdateReasonCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalSecuritiesUpdateReasonCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalSecuritiesUpdateReasonCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalSecuritiesUpdateReasonCode"/>.</summary>
    public static implicit operator ExternalSecuritiesUpdateReasonCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalSecuritiesUpdateReasonCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalSecuritiesUpdateReasonCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalSecuritiesUpdateReasonCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalSecuritiesUpdateReasonCode a, ExternalSecuritiesUpdateReasonCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalSecuritiesUpdateReasonCode a, ExternalSecuritiesUpdateReasonCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalSecuritiesUpdateReasonCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalSecuritiesUpdateReasonCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalSecuritiesUpdateReasonCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalSecuritiesUpdateReasonCode b) => a != b.Value;
}
