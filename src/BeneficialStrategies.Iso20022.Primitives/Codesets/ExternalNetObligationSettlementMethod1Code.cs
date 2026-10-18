// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the settlement method for the net obligation.
/// </summary>
/// <remarks>
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Versioned restriction of <see cref="ExternalNetObligationSettlementMethodCode"/>. No length
/// facet or definition text of its own is published by MCP for this restriction; the base type's
/// length facet (minLength=1, maxLength=4) and definition text are reused per convention. No code
/// values are currently published for this code set in the MCP snapshot; kept as a permissive
/// open struct per CLAUDE.md's external-standard-exception guidance.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_TP_Z8HguEfCdoODv2ypKfw")]
[Description(@"Specifies the settlement method for the net obligation.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalNetObligationSettlementMethod1Code>))]
public readonly struct ExternalNetObligationSettlementMethod1Code : IIsoExternalCode, IEquatable<ExternalNetObligationSettlementMethod1Code>
{
    /// <summary>ISO 20022 format constraint for this external code set.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalNetObligationSettlementMethod1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalNetObligationSettlementMethod1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalNetObligationSettlementMethod1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalNetObligationSettlementMethod1Code"/>.</summary>
    public static implicit operator ExternalNetObligationSettlementMethod1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalNetObligationSettlementMethod1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalNetObligationSettlementMethod1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalNetObligationSettlementMethod1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalNetObligationSettlementMethod1Code a, ExternalNetObligationSettlementMethod1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalNetObligationSettlementMethod1Code a, ExternalNetObligationSettlementMethod1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalNetObligationSettlementMethod1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalNetObligationSettlementMethod1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalNetObligationSettlementMethod1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalNetObligationSettlementMethod1Code b) => a != b.Value;
}
