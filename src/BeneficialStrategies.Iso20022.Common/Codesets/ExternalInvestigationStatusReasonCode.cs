// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the investigation status, as published in an external investigation status reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sMQ0QE-lEe2Vhrd5MAjFrA")]
[Description(
    @"Specifies the reason for the investigation status, as published in an external investigation status reason code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalInvestigationStatusReason1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationStatusReasonCode>))]
public enum ExternalInvestigationStatusReasonCode
{
    /// <summary>
    /// Awaiting debit authorisation from customer.
    /// Encoded/decoded by serializers as &quot;ADAC&quot;.
    /// </summary>
    [EnumMember(Value = "ADAC")]
    [IsoId("__-rFEdYUEe68t8Cw380-tA")]
    [Description(@"Awaiting debit authorisation from customer.")]
    AwaitingDebitAuthorityFromCustomer,

    /// <summary>
    /// Request message has been directed at an incorrect agent or party.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("__-hUbdYUEe68t8Cw380-tA")]
    [Description(@"Request message has been directed at an incorrect agent or party.")]
    IncorrectAgentOrParty,

    /// <summary>
    /// Investigation request not accepted as the transaction has already been returned.
    /// Encoded/decoded by serializers as &quot;ARDT&quot;.
    /// </summary>
    [EnumMember(Value = "ARDT")]
    [IsoId("__-rFF9YUEe68t8Cw380-tA")]
    [Description(@"Investigation request not accepted as the transaction has already been returned.")]
    AlreadyReturned,

    /// <summary>
    /// Underlying transaction already rejected.
    /// Encoded/decoded by serializers as &quot;ARJT&quot;.
    /// </summary>
    [EnumMember(Value = "ARJT")]
    [IsoId("__-rFFtYUEe68t8Cw380-tA")]
    [Description(@"Underlying transaction already rejected.")]
    AlreadyRejectedTransaction,

    /// <summary>
    /// Awaiting reply from customer.
    /// Encoded/decoded by serializers as &quot;ARPL&quot;.
    /// </summary>
    [EnumMember(Value = "ARPL")]
    [IsoId("__-rFEtYUEe68t8Cw380-tA")]
    [Description(@"Awaiting reply from customer.")]
    AwaitingReplyFromCustomer,

    /// <summary>
    /// Investigation closed as cancellation request for underlying transaction has been sent.
    /// Encoded/decoded by serializers as &quot;CACR&quot;.
    /// </summary>
    [EnumMember(Value = "CACR")]
    [IsoId("__-rFENYUEe68t8Cw380-tA")]
    [Description(@"Investigation closed as cancellation request for underlying transaction has been sent.")]
    ClosedAsCancellationRequestSent,

    /// <summary>
    /// Investigation closed as per the request message.
    /// Encoded/decoded by serializers as &quot;CAPR&quot;.
    /// </summary>
    [EnumMember(Value = "CAPR")]
    [IsoId("__-hUcdYUEe68t8Cw380-tA")]
    [Description(@"Investigation closed as per the request message.")]
    ClosedAsPerRequest,

    /// <summary>
    /// Is related to a Correction Made as Per Inquiry procedure for investigation status Closed (CLSD).
    /// Encoded/decoded by serializers as &quot;CMPI&quot;.
    /// </summary>
    [EnumMember(Value = "CMPI")]
    [IsoId("_o9wWYIKAEfCff8wf3dEAMw")]
    [Description(@"Is related to a Correction Made as Per Inquiry procedure for investigation status Closed (CLSD).")]
    CorrectionMadeAsPerInquiry,

    /// <summary>
    /// Request message is duplicate, duplicate request message is rejected.
    /// Encoded/decoded by serializers as &quot;DU01&quot;.
    /// </summary>
    [EnumMember(Value = "DU01")]
    [IsoId("__-hUbtYUEe68t8Cw380-tA")]
    [Description(@"Request message is duplicate, duplicate request message is rejected.")]
    DuplicateRequest,

    /// <summary>
    /// Special follow-up is taking place.
    /// Encoded/decoded by serializers as &quot;ESCA&quot;.
    /// </summary>
    [EnumMember(Value = "ESCA")]
    [IsoId("__-02EtYUEe68t8Cw380-tA")]
    [Description(@"Special follow-up is taking place.")]
    Escalation,

    /// <summary>
    /// Request message forwarded to another agent or party, these may be indicated in NextResponder element.
    /// Encoded/decoded by serializers as &quot;FTNA&quot;.
    /// </summary>
    [EnumMember(Value = "FTNA")]
    [IsoId("__-hUcNYUEe68t8Cw380-tA")]
    [Description(@"Request message forwarded to another agent or party, these may be indicated in NextResponder element.")]
    InvestigationRequestForwardedToAgentOrParty,

    /// <summary>
    /// Indicates that the credit claim non receipt investigation is pending as the cover creditor is waiting for the credit of the cover.
    /// Encoded/decoded by serializers as &quot;G004&quot;.
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("__bI0cPg-Ee-qYYWvwsxo3Q")]
    [Description(@"Indicates that the credit claim non receipt investigation is pending as the cover creditor is waiting for the credit of the cover.")]
    WaitingForCover,

    /// <summary>
    /// Incorrect investigation type used in request message.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("__-02E9YUEe68t8Cw380-tA")]
    [Description(@"Incorrect investigation type used in request message.")]
    IncorrectInvestigationType,

    /// <summary>
    /// Collation of response data is still ongoing.
    /// Encoded/decoded by serializers as &quot;INPO&quot;.
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("__-rFFNYUEe68t8Cw380-tA")]
    [Description(@"Collation of response data is still ongoing.")]
    InProgress,

    /// <summary>
    /// Reported when the request cannot be accepted because of regulatory rules.
    /// Encoded/decoded by serializers as &quot;LEGL&quot;.
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("__-02EdYUEe68t8Cw380-tA")]
    [Description(@"Reported when the request cannot be accepted because of regulatory rules.")]
    LegalDecision,

    /// <summary>
    /// See ResponseData element for additional information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("__-hUb9YUEe68t8Cw380-tA")]
    [Description(@"See ResponseData element for additional information.")]
    Narrative,

    /// <summary>
    /// No additional information in relation to the request can be provided.
    /// Encoded/decoded by serializers as &quot;NOAD&quot;.
    /// </summary>
    [EnumMember(Value = "NOAD")]
    [IsoId("__-02FdYUEe68t8Cw380-tA")]
    [Description(@"No additional information in relation to the request can be provided.")]
    NoAdditionalInformationAvailable,

    /// <summary>
    /// No reply from customer.
    /// Encoded/decoded by serializers as &quot;NOAS&quot;.
    /// </summary>
    [EnumMember(Value = "NOAS")]
    [IsoId("__-rFE9YUEe68t8Cw380-tA")]
    [Description(@"No reply from customer.")]
    NoAnswerFromCustomer,

    /// <summary>
    /// Underlying transaction never received.
    /// Encoded/decoded by serializers as &quot;NOOR&quot;.
    /// </summary>
    [EnumMember(Value = "NOOR")]
    [IsoId("__-rFFdYUEe68t8Cw380-tA")]
    [Description(@"Underlying transaction never received.")]
    NoOriginalTransactionReceived,

    /// <summary>
    /// Response message partially addresses the request, a further response message will follow.
    /// Encoded/decoded by serializers as &quot;PARE&quot;.
    /// </summary>
    [EnumMember(Value = "PARE")]
    [IsoId("__-02FNYUEe68t8Cw380-tA")]
    [Description(@"Response message partially addresses the request, a further response message will follow.")]
    PartialResponse,

    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("__-02ENYUEe68t8Cw380-tA")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason,
}
