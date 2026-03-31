// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the coded reason for the financing status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aqNd9tp-Ed-ak6NoX_4Aeg_-157998852")]
[Description(@"Specifies the coded reason for the financing status.")]
[DerivedFrom(typeof(FinancingStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FinancingStatusReason1Code>))]
#endif
public enum FinancingStatusReason1Code
{
    /// <summary>
    /// Cancellation request message was received after the end of the financing process previously activated.
    /// Encoded/decoded by serializers as &quot;CA01&quot;.
    /// </summary>
    [EnumMember(Value = "CA01")]
    [IsoId("_aqNd99p-Ed-ak6NoX_4Aeg_241885771")]
    [Description(
        @"Cancellation request message was received after the end of the financing process previously activated."
    )]
    CancellationRequestOutOfTime = FinancingStatusReasonCode.CancellationRequestOutOfTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request does not match with an invoice financing request received previously.
    /// Encoded/decoded by serializers as &quot;CA02&quot;.
    /// </summary>
    [EnumMember(Value = "CA02")]
    [IsoId("_aqNd-Np-Ed-ak6NoX_4Aeg_241886042")]
    [Description(
        @"Cancellation request does not match with an invoice financing request received previously."
    )]
    NoMatchingFinancingRequest = FinancingStatusReasonCode.NoMatchingFinancingRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Format of the account number specified is not correct.
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_aqXO8Np-Ed-ak6NoX_4Aeg_241886073")]
    [Description(@"Format of the account number specified is not correct.")]
    IncorrectAccountNumber = FinancingStatusReasonCode.IncorrectAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account number specified has been closed on the Receiver&apos;s books.
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_aqXO8dp-Ed-ak6NoX_4Aeg_241886134")]
    [Description(@"Account number specified has been closed on the Receiver's books.")]
    ClosedAccountNumber = FinancingStatusReasonCode.ClosedAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as &quot;AC06&quot;.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_aqXO8tp-Ed-ak6NoX_4Aeg_241886195")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount = FinancingStatusReasonCode.BlockedAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party who sent the request message is not recognised by the first agent.
    /// Encoded/decoded by serializers as &quot;BE08&quot;.
    /// </summary>
    [EnumMember(Value = "BE08")]
    [IsoId("_aqXO89p-Ed-ak6NoX_4Aeg_241886505")]
    [Description(@"Party who sent the request message is not recognised by the first agent.")]
    UnrecognisedFinancingRequestor = FinancingStatusReasonCode.UnrecognisedFinancingRequestor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party who forwarded the request message is not recognised by the first agent.
    /// Encoded/decoded by serializers as &quot;BE09&quot;.
    /// </summary>
    [EnumMember(Value = "BE09")]
    [IsoId("_aqXO9Np-Ed-ak6NoX_4Aeg_241886535")]
    [Description(@"Party who forwarded the request message is not recognised by the first agent.")]
    UnrecognisedIntermediaryAgent = FinancingStatusReasonCode.UnrecognisedIntermediaryAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financing Requestor is expected to send requests through a different Intermediary Agent.
    /// Encoded/decoded by serializers as &quot;BE10&quot;.
    /// </summary>
    [EnumMember(Value = "BE10")]
    [IsoId("_aqXO9dp-Ed-ak6NoX_4Aeg_241886596")]
    [Description(
        @"Financing Requestor is expected to send requests through a different Intermediary Agent."
    )]
    UnexpectedIntermediaryAgent = FinancingStatusReasonCode.UnexpectedIntermediaryAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party is not recognised by the first agent.
    /// Encoded/decoded by serializers as &quot;BE11&quot;.
    /// </summary>
    [EnumMember(Value = "BE11")]
    [IsoId("_aqXO9tp-Ed-ak6NoX_4Aeg_241886627")]
    [Description(@"Party is not recognised by the first agent.")]
    UnrecognisedParty = FinancingStatusReasonCode.UnrecognisedParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PaymentDueDate is occurring before the request message creation date.
    /// Encoded/decoded by serializers as &quot;DT02&quot;.
    /// </summary>
    [EnumMember(Value = "DT02")]
    [IsoId("_aqXO99p-Ed-ak6NoX_4Aeg_241886658")]
    [Description(@"PaymentDueDate is occurring before the request message creation date.")]
    InvalidPaymentDueDate = FinancingStatusReasonCode.InvalidPaymentDueDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request message received appears to have been duplicated.
    /// Encoded/decoded by serializers as &quot;ID01&quot;.
    /// </summary>
    [EnumMember(Value = "ID01")]
    [IsoId("_aqXO-Np-Ed-ak6NoX_4Aeg_241886688")]
    [Description(@"Request message received appears to have been duplicated.")]
    DuplicatedRequestMessage = FinancingStatusReasonCode.DuplicatedRequestMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request message received appears to have a wrong identification.
    /// Encoded/decoded by serializers as &quot;ID02&quot;.
    /// </summary>
    [EnumMember(Value = "ID02")]
    [IsoId("_aqXO-dp-Ed-ak6NoX_4Aeg_241886719")]
    [Description(@"Request message received appears to have a wrong identification.")]
    WrongIdentification = FinancingStatusReasonCode.WrongIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document number is invalid.
    /// Encoded/decoded by serializers as &quot;ID03&quot;.
    /// </summary>
    [EnumMember(Value = "ID03")]
    [IsoId("_aqgY4Np-Ed-ak6NoX_4Aeg_241886997")]
    [Description(@"Document number is invalid.")]
    InvalidDocumentNumber = FinancingStatusReasonCode.InvalidDocumentNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information bilateral agreed as mandatory is missing.
    /// Encoded/decoded by serializers as &quot;MI01&quot;.
    /// </summary>
    [EnumMember(Value = "MI01")]
    [IsoId("_aqgY4dp-Ed-ak6NoX_4Aeg_241887028")]
    [Description(@"Information bilateral agreed as mandatory is missing.")]
    MissingMandatoryInformation = FinancingStatusReasonCode.MissingMandatoryInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as &quot;NA01&quot;.
    /// </summary>
    [EnumMember(Value = "NA01")]
    [IsoId("_aqgY4tp-Ed-ak6NoX_4Aeg_241887058")]
    [Description(
        @"Reason is provided as narrative information in the additional reason information."
    )]
    Narrative = FinancingStatusReasonCode.Narrative, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was correctly received but the financing process has already been initiated.
    /// Encoded/decoded by serializers as &quot;CA03&quot;.
    /// </summary>
    [EnumMember(Value = "CA03")]
    [IsoId("_aqgY49p-Ed-ak6NoX_4Aeg_-1043988701")]
    [Description(
        @"Cancellation request was correctly received but the financing process has already been initiated."
    )]
    FinancingProcessAlreadyInitiated = FinancingStatusReasonCode.FinancingProcessAlreadyInitiated, // same ordinal as derivation source for type conversions
}
