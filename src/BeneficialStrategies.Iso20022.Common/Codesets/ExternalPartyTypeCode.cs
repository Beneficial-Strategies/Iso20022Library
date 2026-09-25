// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external type of the party in the format of character string with a maximum length of 4 characters.
/// </summary>
/// <remarks>
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Length facet from MCP: minLength=1, maxLength=4. No code values are currently published for
/// this code set in the MCP snapshot; kept as a permissive open struct per CLAUDE.md's
/// external-standard-exception guidance.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_nEjIhhb-EeiyVv5j1vf1VQ")]
[Description(@"Specifies the external type of the party in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPartyTypeCode>))]
public readonly struct ExternalPartyTypeCode : IIsoExternalCode, IEquatable<ExternalPartyTypeCode>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPartyTypeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPartyTypeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPartyTypeCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPartyTypeCode"/>.</summary>
    public static implicit operator ExternalPartyTypeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPartyTypeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPartyTypeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPartyTypeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalPartyTypeCode a, ExternalPartyTypeCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalPartyTypeCode a, ExternalPartyTypeCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalPartyTypeCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalPartyTypeCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalPartyTypeCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalPartyTypeCode b) => a != b.Value;
}
