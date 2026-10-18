// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation type, as published in an external investigation type code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_yrXOgFB9Ee2JFb6fZWHubw")]
[Description(@"Specifies the investigation type, as published in an external investigation type code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationType1Code>))]
public readonly struct ExternalInvestigationType1Code : IIsoExternalCode, IEquatable<ExternalInvestigationType1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation type code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationType1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationType1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationType1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationType1Code"/>.</summary>
    public static implicit operator ExternalInvestigationType1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationType1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationType1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationType1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationType1Code a, ExternalInvestigationType1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationType1Code a, ExternalInvestigationType1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationType1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationType1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationType1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationType1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Investigation relating to an account.</summary>
    [IsoId("_8Mu8IRFsEfG0NpnTSh0Zcg")]
    [Description(@"Investigation relating to an account.")]
    public static readonly ExternalInvestigationType1Code AccountRelatedInvestigation = new("ACCT");

    /// <summary>Creditor claims non-receipt of payment.</summary>
    [IsoId("_8Mr40RFsEfG0NpnTSh0Zcg")]
    [Description(@"Creditor claims non-receipt of payment.")]
    public static readonly ExternalInvestigationType1Code CreditorClaimNonReceipt = new("CCNR");

    /// <summary>Creditor agent claims non-receipt of cover or settlement.</summary>
    [IsoId("_8Mr40xFsEfG0NpnTSh0Zcg")]
    [Description(@"Creditor agent claims non-receipt of cover or settlement.")]
    public static readonly ExternalInvestigationType1Code CreditorAgentClaimCoverNonReceipt = new("CONR");

    /// <summary>Other request type.</summary>
    [IsoId("_8MxYYRFsEfG0NpnTSh0Zcg")]
    [Description(@"Other request type.")]
    public static readonly ExternalInvestigationType1Code Other = new("OTHR");

    /// <summary>Payment initiation has not been settled or confirmed.</summary>
    [IsoId("_8Msf4xFsEfG0NpnTSh0Zcg")]
    [Description(@"Payment initiation has not been settled or confirmed.")]
    public static readonly ExternalInvestigationType1Code PaymentInitiationNotConfirmed = new("PINC");

    /// <summary>Request from International Monetary Fund.</summary>
    [IsoId("_8MwxURFsEfG0NpnTSh0Zcg")]
    [Description(@"Request from International Monetary Fund.")]
    public static readonly ExternalInvestigationType1Code RequestFromIMF = new("RIMF");

    /// <summary>Investigation relating to charges that have been taken or are requested.</summary>
    [IsoId("_8MwKQRFsEfG0NpnTSh0Zcg")]
    [Description(@"Investigation relating to charges that have been taken or are requested.")]
    public static readonly ExternalInvestigationType1Code RequestRelatedToCharges = new("RQCH");

    /// <summary>Debit authorisation on an entry is requested.</summary>
    [IsoId("_8MuVERFsEfG0NpnTSh0Zcg")]
    [Description(@"Debit authorisation on an entry is requested.")]
    public static readonly ExternalInvestigationType1Code RequestDebitAuthorisation = new("RQDA");

    /// <summary>Further information is required on a payment, entry, message or instruction.</summary>
    [IsoId("_8Msf4RFsEfG0NpnTSh0Zcg")]
    [Description(@"Further information is required on a payment, entry, message or instruction.")]
    public static readonly ExternalInvestigationType1Code RequestForInformation = new("RQFI");

    /// <summary>Use of funds on an entry is requested.</summary>
    [IsoId("_8MtG8xFsEfG0NpnTSh0Zcg")]
    [Description(@"Use of funds on an entry is requested.")]
    public static readonly ExternalInvestigationType1Code RequestUseOfFunds = new("RQUF");

    /// <summary>Revaluation of an entry is requested.</summary>
    [IsoId("_8MtG8RFsEfG0NpnTSh0Zcg")]
    [Description(@"Revaluation of an entry is requested.")]
    public static readonly ExternalInvestigationType1Code RequestValueDateAdjustment = new("RQVA");

    /// <summary>A booked entry cannot be applied by the creditor.</summary>
    [IsoId("_8MrRwRFsEfG0NpnTSh0Zcg")]
    [Description(@"A booked entry cannot be applied by the creditor.")]
    public static readonly ExternalInvestigationType1Code UnableToApplyByCreditor = new("UTAP");
}
