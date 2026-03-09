// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the coded reason for the financing status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aqgY5Np-Ed-ak6NoX_4Aeg_1593858714")]
[Description(@"Specifies the coded reason for the financing status.")]
[Derivations(typeof(FinancingStatusReason1Code))]
public enum FinancingStatusReasonCode
{
    /// <summary>
    /// Cancellation request message was received after the end of the financing process previously activated.
    /// Encoded/decoded by serializers as &quot;CA01&quot;.
    /// </summary>
    [EnumMember(Value = "CA01")]
    [IsoId("_aqgY5dp-Ed-ak6NoX_4Aeg_2026989661")]
    [Description(@"Cancellation request message was received after the end of the financing process previously activated.")]
    CancellationRequestOutOfTime,
    
    /// <summary>
    /// Cancellation request does not match with an invoice financing request received previously.
    /// Encoded/decoded by serializers as &quot;CA02&quot;.
    /// </summary>
    [EnumMember(Value = "CA02")]
    [IsoId("_aqgY5tp-Ed-ak6NoX_4Aeg_-2145148024")]
    [Description(@"Cancellation request does not match with an invoice financing request received previously.")]
    NoMatchingFinancingRequest,
    
    /// <summary>
    /// Format of the account number specified is not correct.
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_aqgY59p-Ed-ak6NoX_4Aeg_-1839463830")]
    [Description(@"Format of the account number specified is not correct.")]
    IncorrectAccountNumber,
    
    /// <summary>
    /// Account number specified has been closed on the Receiver&apos;s books.
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_aqgY6Np-Ed-ak6NoX_4Aeg_-1773894940")]
    [Description(@"Account number specified has been closed on the Receiver's books.")]
    ClosedAccountNumber,
    
    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as &quot;AC06&quot;.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_aqgY6dp-Ed-ak6NoX_4Aeg_-1629823277")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount,
    
    /// <summary>
    /// Party who sent the request message is not recognised by the first agent.
    /// Encoded/decoded by serializers as &quot;BE08&quot;.
    /// </summary>
    [EnumMember(Value = "BE08")]
    [IsoId("_aqqJ4Np-Ed-ak6NoX_4Aeg_-1370314185")]
    [Description(@"Party who sent the request message is not recognised by the first agent.")]
    UnrecognisedFinancingRequestor,
    
    /// <summary>
    /// Party who forwarded the request message is not recognised by the first agent.
    /// Encoded/decoded by serializers as &quot;BE09&quot;.
    /// </summary>
    [EnumMember(Value = "BE09")]
    [IsoId("_aqqJ4dp-Ed-ak6NoX_4Aeg_-1311208902")]
    [Description(@"Party who forwarded the request message is not recognised by the first agent.")]
    UnrecognisedIntermediaryAgent,
    
    /// <summary>
    /// Financing Requestor is expected to send requests through a different Intermediary Agent.
    /// Encoded/decoded by serializers as &quot;BE10&quot;.
    /// </summary>
    [EnumMember(Value = "BE10")]
    [IsoId("_aqqJ4tp-Ed-ak6NoX_4Aeg_-1266880934")]
    [Description(@"Financing Requestor is expected to send requests through a different Intermediary Agent.")]
    UnexpectedIntermediaryAgent,
    
    /// <summary>
    /// Party is not recognised by the first agent.
    /// Encoded/decoded by serializers as &quot;BE11&quot;.
    /// </summary>
    [EnumMember(Value = "BE11")]
    [IsoId("_aqqJ49p-Ed-ak6NoX_4Aeg_1821701733")]
    [Description(@"Party is not recognised by the first agent.")]
    UnrecognisedParty,
    
    /// <summary>
    /// PaymentDueDate is occurring before the request message creation date.
    /// Encoded/decoded by serializers as &quot;DT02&quot;.
    /// </summary>
    [EnumMember(Value = "DT02")]
    [IsoId("_aqqJ5Np-Ed-ak6NoX_4Aeg_1866029794")]
    [Description(@"PaymentDueDate is occurring before the request message creation date.")]
    InvalidPaymentDueDate,
    
    /// <summary>
    /// Request message received appears to have been duplicated.
    /// Encoded/decoded by serializers as &quot;ID01&quot;.
    /// </summary>
    [EnumMember(Value = "ID01")]
    [IsoId("_aqqJ5dp-Ed-ak6NoX_4Aeg_1911282601")]
    [Description(@"Request message received appears to have been duplicated.")]
    DuplicatedRequestMessage,
    
    /// <summary>
    /// Request message received appears to have a wrong identification.
    /// Encoded/decoded by serializers as &quot;ID02&quot;.
    /// </summary>
    [EnumMember(Value = "ID02")]
    [IsoId("_aqqJ5tp-Ed-ak6NoX_4Aeg_1962075947")]
    [Description(@"Request message received appears to have a wrong identification.")]
    WrongIdentification,
    
    /// <summary>
    /// Document number is invalid.
    /// Encoded/decoded by serializers as &quot;ID03&quot;.
    /// </summary>
    [EnumMember(Value = "ID03")]
    [IsoId("_aqqJ59p-Ed-ak6NoX_4Aeg_2007330031")]
    [Description(@"Document number is invalid.")]
    InvalidDocumentNumber,
    
    /// <summary>
    /// Information bilateral agreed as mandatory is missing.
    /// Encoded/decoded by serializers as &quot;MI01&quot;.
    /// </summary>
    [EnumMember(Value = "MI01")]
    [IsoId("_aqqJ6Np-Ed-ak6NoX_4Aeg_2061816615")]
    [Description(@"Information bilateral agreed as mandatory is missing.")]
    MissingMandatoryInformation,
    
    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as &quot;NA01&quot;.
    /// </summary>
    [EnumMember(Value = "NA01")]
    [IsoId("_aqzT0Np-Ed-ak6NoX_4Aeg_-1974565756")]
    [Description(@"Reason is provided as narrative information in the additional reason information.")]
    Narrative,
    
    /// <summary>
    /// Cancellation request was correctly received but the financing process has already been initiated.
    /// Encoded/decoded by serializers as &quot;CA03&quot;.
    /// </summary>
    [EnumMember(Value = "CA03")]
    [IsoId("_aqzT0dp-Ed-ak6NoX_4Aeg_-1398619641")]
    [Description(@"Cancellation request was correctly received but the financing process has already been initiated.")]
    FinancingProcessAlreadyInitiated,
    
}
