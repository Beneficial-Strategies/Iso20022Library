// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hokV-csaEemxFbEZK-FMzw")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalDebtorAgentInstruction1Code>))]
public readonly struct ExternalDebtorAgentInstruction1Code : IIsoExternalCode, IEquatable<ExternalDebtorAgentInstruction1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given debtor agent instruction code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalDebtorAgentInstruction1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalDebtorAgentInstruction1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalDebtorAgentInstruction1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalDebtorAgentInstruction1Code"/>.</summary>
    public static implicit operator ExternalDebtorAgentInstruction1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalDebtorAgentInstruction1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalDebtorAgentInstruction1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalDebtorAgentInstruction1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalDebtorAgentInstruction1Code a, ExternalDebtorAgentInstruction1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalDebtorAgentInstruction1Code a, ExternalDebtorAgentInstruction1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalDebtorAgentInstruction1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalDebtorAgentInstruction1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalDebtorAgentInstruction1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalDebtorAgentInstruction1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>(Ultimate) creditor must be paid by cheque.</summary>
    [IsoId("_g9a_cEi6Ee6rhpmMgC3iPQ")]
    [Description(@"(Ultimate) creditor must be paid by cheque.")]
    public static readonly ExternalDebtorAgentInstruction1Code PayCreditorByCheque = new("CHQB");

    /// <summary>Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.</summary>
    [IsoId("_g9aYZ0i6Ee6rhpmMgC3iPQ")]
    [Description(@"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.")]
    public static readonly ExternalDebtorAgentInstruction1Code HoldCashForCreditor = new("HOLD");

    /// <summary>Please advise/contact (ultimate) creditor/claimant by phone.</summary>
    [IsoId("_g9a_cki6Ee6rhpmMgC3iPQ")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone.")]
    public static readonly ExternalDebtorAgentInstruction1Code PhoneBeneficiary = new("PHOB");

    /// <summary>Indicates that a payer token is requested/used.</summary>
    [IsoId("_g9a_cUi6Ee6rhpmMgC3iPQ")]
    [Description(@"Indicates that a payer token is requested/used.")]
    public static readonly ExternalDebtorAgentInstruction1Code PayerTokenRequested = new("PRTK");

    /// <summary>Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.</summary>
    [IsoId("_g9a_c0i6Ee6rhpmMgC3iPQ")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.")]
    public static readonly ExternalDebtorAgentInstruction1Code Telecom = new("TELB");

    /// <summary>Token information.</summary>
    [IsoId("_g9a_dEi6Ee6rhpmMgC3iPQ")]
    [Description(@"Token information.")]
    public static readonly ExternalDebtorAgentInstruction1Code Token = new("TOKN");

    /// <summary>Additional validation information to be used in conjunction with the token.</summary>
    [IsoId("_g9a_dUi6Ee6rhpmMgC3iPQ")]
    [Description(@"Additional validation information to be used in conjunction with the token.")]
    public static readonly ExternalDebtorAgentInstruction1Code TokenValidation = new("VLTK");
}
