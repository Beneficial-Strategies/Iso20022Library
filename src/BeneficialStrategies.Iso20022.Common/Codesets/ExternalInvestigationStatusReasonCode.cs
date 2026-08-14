// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the investigation status, as published in an external investigation status reason code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_sMQ0QE-lEe2Vhrd5MAjFrA")]
[Description(@"Specifies the reason for the investigation status, as published in an external investigation status reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationStatusReasonCode>))]
public readonly struct ExternalInvestigationStatusReasonCode : IIsoExternalCode, IEquatable<ExternalInvestigationStatusReasonCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation status reason code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationStatusReasonCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationStatusReasonCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationStatusReasonCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationStatusReasonCode"/>.</summary>
    public static implicit operator ExternalInvestigationStatusReasonCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationStatusReasonCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationStatusReasonCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationStatusReasonCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationStatusReasonCode a, ExternalInvestigationStatusReasonCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationStatusReasonCode a, ExternalInvestigationStatusReasonCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationStatusReasonCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationStatusReasonCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationStatusReasonCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationStatusReasonCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Awaiting debit authorisation from customer.</summary>
    [IsoId("__-rFEdYUEe68t8Cw380-tA")]
    [Description(@"Awaiting debit authorisation from customer.")]
    public static readonly ExternalInvestigationStatusReasonCode AwaitingDebitAuthorityFromCustomer = new("ADAC");

    /// <summary>Request message has been directed at an incorrect agent or party.</summary>
    [IsoId("__-hUbdYUEe68t8Cw380-tA")]
    [Description(@"Request message has been directed at an incorrect agent or party.")]
    public static readonly ExternalInvestigationStatusReasonCode IncorrectAgentOrParty = new("AGNT");

    /// <summary>Investigation request not accepted as the transaction has already been returned.</summary>
    [IsoId("__-rFF9YUEe68t8Cw380-tA")]
    [Description(@"Investigation request not accepted as the transaction has already been returned.")]
    public static readonly ExternalInvestigationStatusReasonCode AlreadyReturned = new("ARDT");

    /// <summary>Underlying transaction already rejected.</summary>
    [IsoId("__-rFFtYUEe68t8Cw380-tA")]
    [Description(@"Underlying transaction already rejected.")]
    public static readonly ExternalInvestigationStatusReasonCode AlreadyRejectedTransaction = new("ARJT");

    /// <summary>Awaiting reply from customer.</summary>
    [IsoId("__-rFEtYUEe68t8Cw380-tA")]
    [Description(@"Awaiting reply from customer.")]
    public static readonly ExternalInvestigationStatusReasonCode AwaitingReplyFromCustomer = new("ARPL");

    /// <summary>Investigation closed as cancellation request for underlying transaction has been sent.</summary>
    [IsoId("__-rFENYUEe68t8Cw380-tA")]
    [Description(@"Investigation closed as cancellation request for underlying transaction has been sent.")]
    public static readonly ExternalInvestigationStatusReasonCode ClosedAsCancellationRequestSent = new("CACR");

    /// <summary>Investigation closed as per the request message.</summary>
    [IsoId("__-hUcdYUEe68t8Cw380-tA")]
    [Description(@"Investigation closed as per the request message.")]
    public static readonly ExternalInvestigationStatusReasonCode ClosedAsPerRequest = new("CAPR");

    /// <summary>Is related to a Correction Made as Per Inquiry procedure for investigation status Closed (CLSD).</summary>
    [IsoId("_o9wWYIKAEfCff8wf3dEAMw")]
    [Description(@"Is related to a Correction Made as Per Inquiry procedure for investigation status Closed (CLSD).")]
    public static readonly ExternalInvestigationStatusReasonCode CorrectionMadeAsPerInquiry = new("CMPI");

    /// <summary>Request message is duplicate, duplicate request message is rejected.</summary>
    [IsoId("__-hUbtYUEe68t8Cw380-tA")]
    [Description(@"Request message is duplicate, duplicate request message is rejected.")]
    public static readonly ExternalInvestigationStatusReasonCode DuplicateRequest = new("DU01");

    /// <summary>Special follow-up is taking place.</summary>
    [IsoId("__-02EtYUEe68t8Cw380-tA")]
    [Description(@"Special follow-up is taking place.")]
    public static readonly ExternalInvestigationStatusReasonCode Escalation = new("ESCA");

    /// <summary>Request message forwarded to another agent or party, these may be indicated in NextResponder element.</summary>
    [IsoId("__-hUcNYUEe68t8Cw380-tA")]
    [Description(@"Request message forwarded to another agent or party, these may be indicated in NextResponder element.")]
    public static readonly ExternalInvestigationStatusReasonCode InvestigationRequestForwardedToAgentOrParty = new("FTNA");

    /// <summary>Indicates that the credit claim non receipt investigation is pending as the cover creditor is waiting for the credit of the cover.</summary>
    [IsoId("__bI0cPg-Ee-qYYWvwsxo3Q")]
    [Description(@"Indicates that the credit claim non receipt investigation is pending as the cover creditor is waiting for the credit of the cover.")]
    public static readonly ExternalInvestigationStatusReasonCode WaitingForCover = new("G004");

    /// <summary>Incorrect investigation type used in request message.</summary>
    [IsoId("__-02E9YUEe68t8Cw380-tA")]
    [Description(@"Incorrect investigation type used in request message.")]
    public static readonly ExternalInvestigationStatusReasonCode IncorrectInvestigationType = new("INIT");

    /// <summary>Collation of response data is still ongoing.</summary>
    [IsoId("__-rFFNYUEe68t8Cw380-tA")]
    [Description(@"Collation of response data is still ongoing.")]
    public static readonly ExternalInvestigationStatusReasonCode InProgress = new("INPO");

    /// <summary>Reported when the request cannot be accepted because of regulatory rules.</summary>
    [IsoId("__-02EdYUEe68t8Cw380-tA")]
    [Description(@"Reported when the request cannot be accepted because of regulatory rules.")]
    public static readonly ExternalInvestigationStatusReasonCode LegalDecision = new("LEGL");

    /// <summary>See ResponseData element for additional information.</summary>
    [IsoId("__-hUb9YUEe68t8Cw380-tA")]
    [Description(@"See ResponseData element for additional information.")]
    public static readonly ExternalInvestigationStatusReasonCode Narrative = new("NARR");

    /// <summary>No additional information in relation to the request can be provided.</summary>
    [IsoId("__-02FdYUEe68t8Cw380-tA")]
    [Description(@"No additional information in relation to the request can be provided.")]
    public static readonly ExternalInvestigationStatusReasonCode NoAdditionalInformationAvailable = new("NOAD");

    /// <summary>No reply from customer.</summary>
    [IsoId("__-rFE9YUEe68t8Cw380-tA")]
    [Description(@"No reply from customer.")]
    public static readonly ExternalInvestigationStatusReasonCode NoAnswerFromCustomer = new("NOAS");

    /// <summary>Underlying transaction never received.</summary>
    [IsoId("__-rFFdYUEe68t8Cw380-tA")]
    [Description(@"Underlying transaction never received.")]
    public static readonly ExternalInvestigationStatusReasonCode NoOriginalTransactionReceived = new("NOOR");

    /// <summary>Response message partially addresses the request, a further response message will follow.</summary>
    [IsoId("__-02FNYUEe68t8Cw380-tA")]
    [Description(@"Response message partially addresses the request, a further response message will follow.")]
    public static readonly ExternalInvestigationStatusReasonCode PartialResponse = new("PARE");

    /// <summary>Regulatory Reason.</summary>
    [IsoId("__-02ENYUEe68t8Cw380-tA")]
    [Description(@"Regulatory Reason.")]
    public static readonly ExternalInvestigationStatusReasonCode RegulatoryReason = new("RR04");
}
