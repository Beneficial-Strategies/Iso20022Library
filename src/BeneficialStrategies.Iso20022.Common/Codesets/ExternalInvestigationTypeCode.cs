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
[IsoId("_agVCUEk0Ee2pGuIgvBXIzg")]
[Description(@"Specifies the investigation type, as published in an external investigation type code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationTypeCode>))]
public readonly struct ExternalInvestigationTypeCode : IIsoExternalCode, IEquatable<ExternalInvestigationTypeCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation type code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationTypeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationTypeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationTypeCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationTypeCode"/>.</summary>
    public static implicit operator ExternalInvestigationTypeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationTypeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationTypeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationTypeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationTypeCode a, ExternalInvestigationTypeCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationTypeCode a, ExternalInvestigationTypeCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationTypeCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationTypeCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationTypeCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationTypeCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Investigation relating to an account.</summary>
    [IsoId("__-YKL9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relating to an account.")]
    public static readonly ExternalInvestigationTypeCode AccountRelatedInvestigation = new("ACCT");

    /// <summary>Creditor claims non-receipt of payment.</summary>
    [IsoId("__-YKKNYUEe68t8Cw380-tA")]
    [Description(@"Creditor claims non-receipt of payment.")]
    public static readonly ExternalInvestigationTypeCode CreditorClaimNonReceipt = new("CCNR");

    /// <summary>Creditor agent claims non-receipt of cover or settlement.</summary>
    [IsoId("__-YKKdYUEe68t8Cw380-tA")]
    [Description(@"Creditor agent claims non-receipt of cover or settlement.")]
    public static readonly ExternalInvestigationTypeCode CreditorAgentClaimCoverNonReceipt = new("CONR");

    /// <summary>Other request type.</summary>
    [IsoId("__-YKMtYUEe68t8Cw380-tA")]
    [Description(@"Other request type.")]
    public static readonly ExternalInvestigationTypeCode Other = new("OTHR");

    /// <summary>Payment initiation has not been settled or confirmed.</summary>
    [IsoId("__-YKK9YUEe68t8Cw380-tA")]
    [Description(@"Payment initiation has not been settled or confirmed.")]
    public static readonly ExternalInvestigationTypeCode PaymentInitiationNotConfirmed = new("PINC");

    /// <summary>Request from International Monetary Fund.</summary>
    [IsoId("__-YKMdYUEe68t8Cw380-tA")]
    [Description(@"Request from International Monetary Fund.")]
    public static readonly ExternalInvestigationTypeCode RequestFromIMF = new("RIMF");

    /// <summary>Investigation relating to charges that have been taken or are requested.</summary>
    [IsoId("__-YKMNYUEe68t8Cw380-tA")]
    [Description(@"Investigation relating to charges that have been taken or are requested.")]
    public static readonly ExternalInvestigationTypeCode RequestRelatedToCharges = new("RQCH");

    /// <summary>Debit authorisation on an entry is requested.</summary>
    [IsoId("__-YKLtYUEe68t8Cw380-tA")]
    [Description(@"Debit authorisation on an entry is requested.")]
    public static readonly ExternalInvestigationTypeCode RequestDebitAuthorisation = new("RQDA");

    /// <summary>Further information is required on a payment, entry, message or instruction.</summary>
    [IsoId("__-YKKtYUEe68t8Cw380-tA")]
    [Description(@"Further information is required on a payment, entry, message or instruction.")]
    public static readonly ExternalInvestigationTypeCode RequestForInformation = new("RQFI");

    /// <summary>Use of funds on an entry is requested.</summary>
    [IsoId("__-YKLdYUEe68t8Cw380-tA")]
    [Description(@"Use of funds on an entry is requested.")]
    public static readonly ExternalInvestigationTypeCode RequestUseOfFunds = new("RQUF");

    /// <summary>Revaluation of an entry is requested.</summary>
    [IsoId("__-YKLNYUEe68t8Cw380-tA")]
    [Description(@"Revaluation of an entry is requested.")]
    public static readonly ExternalInvestigationTypeCode RequestValueDateAdjustment = new("RQVA");

    /// <summary>A booked entry cannot be applied by the creditor.</summary>
    [IsoId("__-YKJ9YUEe68t8Cw380-tA")]
    [Description(@"A booked entry cannot be applied by the creditor.")]
    public static readonly ExternalInvestigationTypeCode UnableToApplyByCreditor = new("UTAP");
}
