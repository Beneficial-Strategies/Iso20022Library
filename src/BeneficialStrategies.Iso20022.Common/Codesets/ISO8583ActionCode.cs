// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code which defines the action taken or to be taken as well as the reason for taking this action (ISO 8583:1993, 2003, 2023, Action codes). The code is checked against the list of Action codes with 3 or 4 digits numeric codes, defined in the standard.
/// </summary>
/// <remarks>
/// Pattern facet from MCP get_code_set_details: [0-9]{3,4}
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_HP6N4H9uEfCmC4yYaU27Kg")]
[Description(@"Code which defines the action taken or to be taken as well as the reason for taking this action (ISO 8583:1993, 2003, 2023, Action codes). The code is checked against the list of Action codes with 3 or 4 digits numeric codes, defined in the standard.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ISO8583ActionCode>))]
public readonly struct ISO8583ActionCode : IIsoExternalCode, IEquatable<ISO8583ActionCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^[0-9]{3,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ISO8583ActionCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ISO8583ActionCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ISO8583ActionCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ISO8583ActionCode"/>.</summary>
    public static implicit operator ISO8583ActionCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ISO8583ActionCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ISO8583ActionCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ISO8583ActionCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ISO8583ActionCode a, ISO8583ActionCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ISO8583ActionCode a, ISO8583ActionCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ISO8583ActionCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ISO8583ActionCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ISO8583ActionCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ISO8583ActionCode b) => a != b.Value;
}
