// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the priority levels for the BusinessFile.
/// </summary>
/// <remarks>
/// The different priorities are typically user / service / implementation dependent. The semantics of the different values for a File need to be defined by the relevant user community (SEG.).
/// No length/pattern facet published by MCP for this type (only a &quot;ValidationByTable&quot; constraint with no target table given) — external verification attempted, none found; kept permissive (non-empty string) per CLAUDE.md guidance rather than guessing a structure.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("__O3SchUbEfCfALVKQ4rOew")]
[Description(@"Specifies the priority levels for the BusinessFile.|The different priorities are typically user / service / implementation dependent. The semantics of the different values for a File need to be defined by the relevant user community (SEG.).")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<BusinessFilePriorityCode>))]
public readonly struct BusinessFilePriorityCode : IIsoExternalCode, IEquatable<BusinessFilePriorityCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.+$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public BusinessFilePriorityCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(BusinessFilePriorityCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out BusinessFilePriorityCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="BusinessFilePriorityCode"/>.</summary>
    public static implicit operator BusinessFilePriorityCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(BusinessFilePriorityCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(BusinessFilePriorityCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is BusinessFilePriorityCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(BusinessFilePriorityCode a, BusinessFilePriorityCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(BusinessFilePriorityCode a, BusinessFilePriorityCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(BusinessFilePriorityCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(BusinessFilePriorityCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, BusinessFilePriorityCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, BusinessFilePriorityCode b) => a != b.Value;
}
