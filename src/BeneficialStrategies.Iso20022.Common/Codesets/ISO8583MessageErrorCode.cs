// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code that identifies the error condition, such as missing data or non-numeric data (ISO 8583, Message error codes).
/// </summary>
/// <remarks>
/// Pattern facet from MCP get_code_set_details: [0-9]{4,4}
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_MrIVoEMDEfCQAqQ9lolFUg")]
[Description(@"Code that identifies the error condition, such as missing data or non-numeric data (ISO 8583, Message error codes).")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ISO8583MessageErrorCode>))]
public readonly struct ISO8583MessageErrorCode : IIsoExternalCode, IEquatable<ISO8583MessageErrorCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^[0-9]{4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ISO8583MessageErrorCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ISO8583MessageErrorCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ISO8583MessageErrorCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ISO8583MessageErrorCode"/>.</summary>
    public static implicit operator ISO8583MessageErrorCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ISO8583MessageErrorCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ISO8583MessageErrorCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISO8583MessageErrorCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ISO8583MessageErrorCode a, ISO8583MessageErrorCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISO8583MessageErrorCode a, ISO8583MessageErrorCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISO8583MessageErrorCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISO8583MessageErrorCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISO8583MessageErrorCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISO8583MessageErrorCode b) => a != b.Value;
}
