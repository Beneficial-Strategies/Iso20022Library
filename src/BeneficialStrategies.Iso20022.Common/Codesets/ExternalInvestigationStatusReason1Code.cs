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
[IsoId("_4evbwFEUEe2YkcF60skG_A")]
[Description(
    @"Specifies the reason for the investigation status, as published in an external investigation status reason code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalInvestigationStatusReasonCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationStatusReason1Code>))]
public enum ExternalInvestigationStatusReason1Code
{
    /// <summary>
    /// Awaiting debit authorisation from customer.
    /// Encoded/decoded by serializers as &quot;ADAC&quot;.
    /// </summary>
    [EnumMember(Value = "ADAC")]
    [IsoId("___as3dYUEe68t8Cw380-tA")]
    [Description(@"Awaiting debit authorisation from customer.")]
    AwaitingDebitAuthorityFromCustomer = ExternalInvestigationStatusReasonCode.AwaitingDebitAuthorityFromCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request message has been directed at an incorrect agent or party.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("___as0dYUEe68t8Cw380-tA")]
    [Description(@"Request message has been directed at an incorrect agent or party.")]
    IncorrectAgentOrParty = ExternalInvestigationStatusReasonCode.IncorrectAgentOrParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation request not accepted as the transaction has already been returned.
    /// Encoded/decoded by serializers as &quot;ARDT&quot;.
    /// </summary>
    [EnumMember(Value = "ARDT")]
    [IsoId("___as6dYUEe68t8Cw380-tA")]
    [Description(@"Investigation request not accepted as the transaction has already been returned.")]
    AlreadyReturned = ExternalInvestigationStatusReasonCode.AlreadyReturned, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying transaction already rejected.
    /// Encoded/decoded by serializers as &quot;ARJT&quot;.
    /// </summary>
    [EnumMember(Value = "ARJT")]
    [IsoId("___as59YUEe68t8Cw380-tA")]
    [Description(@"Underlying transaction already rejected.")]
    AlreadyRejectedTransaction = ExternalInvestigationStatusReasonCode.AlreadyRejectedTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting reply from customer.
    /// Encoded/decoded by serializers as &quot;ARPL&quot;.
    /// </summary>
    [EnumMember(Value = "ARPL")]
    [IsoId("___as39YUEe68t8Cw380-tA")]
    [Description(@"Awaiting reply from customer.")]
    AwaitingReplyFromCustomer = ExternalInvestigationStatusReasonCode.AwaitingReplyFromCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation closed as cancellation request for underlying transaction has been sent.
    /// Encoded/decoded by serializers as &quot;CACR&quot;.
    /// </summary>
    [EnumMember(Value = "CACR")]
    [IsoId("___as29YUEe68t8Cw380-tA")]
    [Description(@"Investigation closed as cancellation request for underlying transaction has been sent.")]
    ClosedAsCancellationRequestSent = ExternalInvestigationStatusReasonCode.ClosedAsCancellationRequestSent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation closed as per the request message.
    /// Encoded/decoded by serializers as &quot;CAPR&quot;.
    /// </summary>
    [EnumMember(Value = "CAPR")]
    [IsoId("___as2dYUEe68t8Cw380-tA")]
    [Description(@"Investigation closed as per the request message.")]
    ClosedAsPerRequest = ExternalInvestigationStatusReasonCode.ClosedAsPerRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Is related to a Correction Made as Per Inquiry procedure for investigation status Closed (CLSD).
    /// Encoded/decoded by serializers as &quot;CMPI&quot;.
    /// </summary>
    [EnumMember(Value = "CMPI")]
    [IsoId("_o9w9cYKAEfCff8wf3dEAMw")]
    [Description(@"Is related to a Correction Made as Per Inquiry procedure for investigation status Closed (CLSD).")]
    CorrectionMadeAsPerInquiry = ExternalInvestigationStatusReasonCode.CorrectionMadeAsPerInquiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request message is duplicate, duplicate request message is rejected.
    /// Encoded/decoded by serializers as &quot;DU01&quot;.
    /// </summary>
    [EnumMember(Value = "DU01")]
    [IsoId("___as09YUEe68t8Cw380-tA")]
    [Description(@"Request message is duplicate, duplicate request message is rejected.")]
    DuplicateRequest = ExternalInvestigationStatusReasonCode.DuplicateRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Special follow-up is taking place.
    /// Encoded/decoded by serializers as &quot;ESCA&quot;.
    /// </summary>
    [EnumMember(Value = "ESCA")]
    [IsoId("___as79YUEe68t8Cw380-tA")]
    [Description(@"Special follow-up is taking place.")]
    Escalation = ExternalInvestigationStatusReasonCode.Escalation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request message forwarded to another agent or party, these may be indicated in NextResponder element.
    /// Encoded/decoded by serializers as &quot;FTNA&quot;.
    /// </summary>
    [EnumMember(Value = "FTNA")]
    [IsoId("___as19YUEe68t8Cw380-tA")]
    [Description(@"Request message forwarded to another agent or party, these may be indicated in NextResponder element.")]
    InvestigationRequestForwardedToAgentOrParty = ExternalInvestigationStatusReasonCode.InvestigationRequestForwardedToAgentOrParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the credit claim non receipt investigation is pending as the cover creditor is waiting for the credit of the cover.
    /// Encoded/decoded by serializers as &quot;G004&quot;.
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("__bI0cvg-Ee-qYYWvwsxo3Q")]
    [Description(@"Indicates that the credit claim non receipt investigation is pending as the cover creditor is waiting for the credit of the cover.")]
    WaitingForCover = ExternalInvestigationStatusReasonCode.WaitingForCover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Incorrect investigation type used in request message.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("___as8dYUEe68t8Cw380-tA")]
    [Description(@"Incorrect investigation type used in request message.")]
    IncorrectInvestigationType = ExternalInvestigationStatusReasonCode.IncorrectInvestigationType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collation of response data is still ongoing.
    /// Encoded/decoded by serializers as &quot;INPO&quot;.
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("___as49YUEe68t8Cw380-tA")]
    [Description(@"Collation of response data is still ongoing.")]
    InProgress = ExternalInvestigationStatusReasonCode.InProgress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported when the request cannot be accepted because of regulatory rules.
    /// Encoded/decoded by serializers as &quot;LEGL&quot;.
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("___as7dYUEe68t8Cw380-tA")]
    [Description(@"Reported when the request cannot be accepted because of regulatory rules.")]
    LegalDecision = ExternalInvestigationStatusReasonCode.LegalDecision, // same ordinal as derivation source for type conversions

    /// <summary>
    /// See ResponseData element for additional information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("___as1dYUEe68t8Cw380-tA")]
    [Description(@"See ResponseData element for additional information.")]
    Narrative = ExternalInvestigationStatusReasonCode.Narrative, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No additional information in relation to the request can be provided.
    /// Encoded/decoded by serializers as &quot;NOAD&quot;.
    /// </summary>
    [EnumMember(Value = "NOAD")]
    [IsoId("___as9dYUEe68t8Cw380-tA")]
    [Description(@"No additional information in relation to the request can be provided.")]
    NoAdditionalInformationAvailable = ExternalInvestigationStatusReasonCode.NoAdditionalInformationAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No reply from customer.
    /// Encoded/decoded by serializers as &quot;NOAS&quot;.
    /// </summary>
    [EnumMember(Value = "NOAS")]
    [IsoId("___as4dYUEe68t8Cw380-tA")]
    [Description(@"No reply from customer.")]
    NoAnswerFromCustomer = ExternalInvestigationStatusReasonCode.NoAnswerFromCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying transaction never received.
    /// Encoded/decoded by serializers as &quot;NOOR&quot;.
    /// </summary>
    [EnumMember(Value = "NOOR")]
    [IsoId("___as5dYUEe68t8Cw380-tA")]
    [Description(@"Underlying transaction never received.")]
    NoOriginalTransactionReceived = ExternalInvestigationStatusReasonCode.NoOriginalTransactionReceived, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response message partially addresses the request, a further response message will follow.
    /// Encoded/decoded by serializers as &quot;PARE&quot;.
    /// </summary>
    [EnumMember(Value = "PARE")]
    [IsoId("___as89YUEe68t8Cw380-tA")]
    [Description(@"Response message partially addresses the request, a further response message will follow.")]
    PartialResponse = ExternalInvestigationStatusReasonCode.PartialResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("___as69YUEe68t8Cw380-tA")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason = ExternalInvestigationStatusReasonCode.RegulatoryReason, // same ordinal as derivation source for type conversions
}
