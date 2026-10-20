// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external purpose code in the format of character string with a maximum length of 35 characters.
/// </summary>
/// <remarks>
/// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
/// Distinct from the current, actively-registered ExternalPurposeCode (already implemented in Codesets/ExternalPurposeCode.cs) — this is ISO 20022's own separate, legacy sibling type (registrationStatus=&quot;Provisionally Registered&quot; per MCP, despite the &quot;_Obsolete&quot; suffix baked into its own type name).
/// Length facet from MCP: minLength=1, maxLength=35
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_amolgdp-Ed-ak6NoX_4Aeg_-204533759")]
[Description(@"Specifies the external purpose code in the format of character string with a maximum length of 35 characters.|The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalPurposeCode_Obsolete>))]
public readonly struct ExternalPurposeCode_Obsolete : IIsoExternalCode, IEquatable<ExternalPurposeCode_Obsolete>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,35}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalPurposeCode_Obsolete(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalPurposeCode_Obsolete), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalPurposeCode_Obsolete result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalPurposeCode_Obsolete"/>.</summary>
    public static implicit operator ExternalPurposeCode_Obsolete(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalPurposeCode_Obsolete code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalPurposeCode_Obsolete other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalPurposeCode_Obsolete other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalPurposeCode_Obsolete a, ExternalPurposeCode_Obsolete b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalPurposeCode_Obsolete a, ExternalPurposeCode_Obsolete b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalPurposeCode_Obsolete a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalPurposeCode_Obsolete a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalPurposeCode_Obsolete b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalPurposeCode_Obsolete b) => a != b.Value;
}
