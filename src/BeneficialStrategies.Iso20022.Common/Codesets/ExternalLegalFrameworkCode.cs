// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the legal act framework.
/// </summary>
/// <remarks>
/// Per MCP, derived by ExternalLegalFramework1Code.
/// Length facet from MCP: minLength=1, maxLength=6
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_DOTdIJg4Ee6uVIkU2PD78Q")]
[Description(@"Specifies the legal act framework.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalLegalFrameworkCode>))]
public readonly struct ExternalLegalFrameworkCode : IIsoExternalCode, IEquatable<ExternalLegalFrameworkCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,6}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalLegalFrameworkCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalLegalFrameworkCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalLegalFrameworkCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalLegalFrameworkCode"/>.</summary>
    public static implicit operator ExternalLegalFrameworkCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalLegalFrameworkCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalLegalFrameworkCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalLegalFrameworkCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalLegalFrameworkCode a, ExternalLegalFrameworkCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalLegalFrameworkCode a, ExternalLegalFrameworkCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalLegalFrameworkCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalLegalFrameworkCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalLegalFrameworkCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalLegalFrameworkCode b) => a != b.Value;
}
