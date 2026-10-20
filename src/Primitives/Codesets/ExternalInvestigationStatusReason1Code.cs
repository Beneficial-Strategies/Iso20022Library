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
[IsoId("_4evbwFEUEe2YkcF60skG_A")]
[Description(@"Specifies the reason for the investigation status, as published in an external investigation status reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationStatusReason1Code>))]
public readonly struct ExternalInvestigationStatusReason1Code : IIsoExternalCode, IEquatable<ExternalInvestigationStatusReason1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation status reason code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationStatusReason1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationStatusReason1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationStatusReason1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationStatusReason1Code"/>.</summary>
    public static implicit operator ExternalInvestigationStatusReason1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationStatusReason1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationStatusReason1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationStatusReason1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationStatusReason1Code a, ExternalInvestigationStatusReason1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationStatusReason1Code a, ExternalInvestigationStatusReason1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationStatusReason1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationStatusReason1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationStatusReason1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationStatusReason1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Awaiting debit authorisation from customer.</summary>
    [IsoId("___as3dYUEe68t8Cw380-tA")]
    [Description(@"Awaiting debit authorisation from customer.")]
    public static readonly ExternalInvestigationStatusReason1Code AwaitingDebitAuthorityFromCustomer = new("ADAC");

    /// <summary>Request message has been directed at an incorrect agent or party.</summary>
    [IsoId("___as0dYUEe68t8Cw380-tA")]
    [Description(@"Request message has been directed at an incorrect agent or party.")]
    public static readonly ExternalInvestigationStatusReason1Code IncorrectAgentOrParty = new("AGNT");

    /// <summary>Investigation request not accepted as the transaction has already been returned.</summary>
    [IsoId("___as6dYUEe68t8Cw380-tA")]
    [Description(@"Investigation request not accepted as the transaction has already been returned.")]
    public static readonly ExternalInvestigationStatusReason1Code AlreadyReturned = new("ARDT");

    /// <summary>Underlying transaction already rejected.</summary>
    [IsoId("___as59YUEe68t8Cw380-tA")]
    [Description(@"Underlying transaction already rejected.")]
    public static readonly ExternalInvestigationStatusReason1Code AlreadyRejectedTransaction = new("ARJT");

    /// <summary>Awaiting reply from customer.</summary>
    [IsoId("___as39YUEe68t8Cw380-tA")]
    [Description(@"Awaiting reply from customer.")]
    public static readonly ExternalInvestigationStatusReason1Code AwaitingReplyFromCustomer = new("ARPL");

    /// <summary>Investigation closed as cancellation request for underlying transaction has been sent.</summary>
    [IsoId("___as29YUEe68t8Cw380-tA")]
    [Description(@"Investigation closed as cancellation request for underlying transaction has been sent.")]
    public static readonly ExternalInvestigationStatusReason1Code ClosedAsCancellationRequestSent = new("CACR");

    /// <summary>Investigation closed as per the request message.</summary>
    [IsoId("___as2dYUEe68t8Cw380-tA")]
    [Description(@"Investigation closed as per the request message.")]
    public static readonly ExternalInvestigationStatusReason1Code ClosedAsPerRequest = new("CAPR");

    /// <summary>Is related to a Correction Made as Per Inquiry procedure for investigation status Closed (CLSD).</summary>
    [IsoId("_o9w9cYKAEfCff8wf3dEAMw")]
    [Description(@"Is related to a Correction Made as Per Inquiry procedure for investigation status Closed (CLSD).")]
    public static readonly ExternalInvestigationStatusReason1Code CorrectionMadeAsPerInquiry = new("CMPI");

    /// <summary>Request message is duplicate, duplicate request message is rejected.</summary>
    [IsoId("___as09YUEe68t8Cw380-tA")]
    [Description(@"Request message is duplicate, duplicate request message is rejected.")]
    public static readonly ExternalInvestigationStatusReason1Code DuplicateRequest = new("DU01");

    /// <summary>Special follow-up is taking place.</summary>
    [IsoId("___as79YUEe68t8Cw380-tA")]
    [Description(@"Special follow-up is taking place.")]
    public static readonly ExternalInvestigationStatusReason1Code Escalation = new("ESCA");

    /// <summary>Request message forwarded to another agent or party, these may be indicated in NextResponder element.</summary>
    [IsoId("___as19YUEe68t8Cw380-tA")]
    [Description(@"Request message forwarded to another agent or party, these may be indicated in NextResponder element.")]
    public static readonly ExternalInvestigationStatusReason1Code InvestigationRequestForwardedToAgentOrParty = new("FTNA");

    /// <summary>Indicates that the credit claim non receipt investigation is pending as the cover creditor is waiting for the credit of the cover.</summary>
    [IsoId("__bI0cvg-Ee-qYYWvwsxo3Q")]
    [Description(@"Indicates that the credit claim non receipt investigation is pending as the cover creditor is waiting for the credit of the cover.")]
    public static readonly ExternalInvestigationStatusReason1Code WaitingForCover = new("G004");

    /// <summary>Incorrect investigation type used in request message.</summary>
    [IsoId("___as8dYUEe68t8Cw380-tA")]
    [Description(@"Incorrect investigation type used in request message.")]
    public static readonly ExternalInvestigationStatusReason1Code IncorrectInvestigationType = new("INIT");

    /// <summary>Collation of response data is still ongoing.</summary>
    [IsoId("___as49YUEe68t8Cw380-tA")]
    [Description(@"Collation of response data is still ongoing.")]
    public static readonly ExternalInvestigationStatusReason1Code InProgress = new("INPO");

    /// <summary>Reported when the request cannot be accepted because of regulatory rules.</summary>
    [IsoId("___as7dYUEe68t8Cw380-tA")]
    [Description(@"Reported when the request cannot be accepted because of regulatory rules.")]
    public static readonly ExternalInvestigationStatusReason1Code LegalDecision = new("LEGL");

    /// <summary>See ResponseData element for additional information.</summary>
    [IsoId("___as1dYUEe68t8Cw380-tA")]
    [Description(@"See ResponseData element for additional information.")]
    public static readonly ExternalInvestigationStatusReason1Code Narrative = new("NARR");

    /// <summary>No additional information in relation to the request can be provided.</summary>
    [IsoId("___as9dYUEe68t8Cw380-tA")]
    [Description(@"No additional information in relation to the request can be provided.")]
    public static readonly ExternalInvestigationStatusReason1Code NoAdditionalInformationAvailable = new("NOAD");

    /// <summary>No reply from customer.</summary>
    [IsoId("___as4dYUEe68t8Cw380-tA")]
    [Description(@"No reply from customer.")]
    public static readonly ExternalInvestigationStatusReason1Code NoAnswerFromCustomer = new("NOAS");

    /// <summary>Underlying transaction never received.</summary>
    [IsoId("___as5dYUEe68t8Cw380-tA")]
    [Description(@"Underlying transaction never received.")]
    public static readonly ExternalInvestigationStatusReason1Code NoOriginalTransactionReceived = new("NOOR");

    /// <summary>Response message partially addresses the request, a further response message will follow.</summary>
    [IsoId("___as89YUEe68t8Cw380-tA")]
    [Description(@"Response message partially addresses the request, a further response message will follow.")]
    public static readonly ExternalInvestigationStatusReason1Code PartialResponse = new("PARE");

    /// <summary>Regulatory Reason.</summary>
    [IsoId("___as69YUEe68t8Cw380-tA")]
    [Description(@"Regulatory Reason.")]
    public static readonly ExternalInvestigationStatusReason1Code RegulatoryReason = new("RR04");
}
