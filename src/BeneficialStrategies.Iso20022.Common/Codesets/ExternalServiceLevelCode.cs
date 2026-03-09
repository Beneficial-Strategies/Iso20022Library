// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jo7HwIMlEeeBDNMiErKunw")]
[Description(@"Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalServiceLevel1Code))]
public enum ExternalServiceLevelCode
{
    /// <summary>
    /// Payment through internal book transfer.
    /// Encoded/decoded by serializers as &quot;BKTR&quot;.
    /// </summary>
    [EnumMember(Value = "BKTR")]
    [IsoId("_t8zlFvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment through internal book transfer.")]
    BookTransaction,
    
    /// <summary>
    /// Tracked Customer Credit Transfer.
    /// Encoded/decoded by serializers as &quot;G001&quot;.
    /// </summary>
    [EnumMember(Value = "G001")]
    [IsoId("_t8zlGfRYEeuLhpyIdtJzwg")]
    [Description(@"Tracked Customer Credit Transfer.")]
    TrackedCustomerCreditTransfer,
    
    /// <summary>
    /// Tracked Stop and Recall 
    /// Encoded/decoded by serializers as &quot;G002&quot;.
    /// </summary>
    [EnumMember(Value = "G002")]
    [IsoId("_t8zlHPRYEeuLhpyIdtJzwg")]
    [Description(@"Tracked Stop and Recall ")]
    TrackedStopAndRecall,
    
    /// <summary>
    /// Tracked Outbound Corporate Transfer.
    /// Encoded/decoded by serializers as &quot;G003&quot;.
    /// </summary>
    [EnumMember(Value = "G003")]
    [IsoId("_t89WEPRYEeuLhpyIdtJzwg")]
    [Description(@"Tracked Outbound Corporate Transfer.")]
    TrackedOutboundCorporateTransfer,
    
    /// <summary>
    /// Tracked Financial Institution Transfer.
    /// Encoded/decoded by serializers as &quot;G004&quot;.
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("_t89WE_RYEeuLhpyIdtJzwg")]
    [Description(@"Tracked Financial Institution Transfer.")]
    TrackedFinancialInstitutionTransfer,
    
    /// <summary>
    /// Payments must be executed following the NPC Area Payment scheme.
    /// Encoded/decoded by serializers as &quot;NPCA&quot;.
    /// </summary>
    [EnumMember(Value = "NPCA")]
    [IsoId("_t89WFvRYEeuLhpyIdtJzwg")]
    [Description(@"Payments must be executed following the NPC Area Payment scheme.")]
    NordicPaymentsCouncilAreaTransfer,
    
    /// <summary>
    /// Payment must be executed as a non-urgent transaction with priority settlement.
    /// Encoded/decoded by serializers as &quot;NUGP&quot;.
    /// </summary>
    [EnumMember(Value = "NUGP")]
    [IsoId("_t9GgAPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed as a non-urgent transaction with priority settlement.")]
    NonurgentPriorityPayment,
    
    /// <summary>
    /// Payment must be executed as a non-urgent transaction, which is typically identified as an ACH or low value transaction. 
    /// Encoded/decoded by serializers as &quot;NURG&quot;.
    /// </summary>
    [EnumMember(Value = "NURG")]
    [IsoId("_t9GgA_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed as a non-urgent transaction, which is typically identified as an ACH or low value transaction. ")]
    NonurgentPayment,
    
    /// <summary>
    /// Transaction must be processed according to the EBA Priority Service.
    /// Encoded/decoded by serializers as &quot;PRPT&quot;.
    /// </summary>
    [EnumMember(Value = "PRPT")]
    [IsoId("_t9GgBvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction must be processed according to the EBA Priority Service.")]
    EBAPriorityService,
    
    /// <summary>
    /// Payment must be executed with same day value to the creditor.
    /// Encoded/decoded by serializers as &quot;SDVA&quot;.
    /// </summary>
    [EnumMember(Value = "SDVA")]
    [IsoId("_t9GgCfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed with same day value to the creditor.")]
    SameDayValue,
    
    /// <summary>
    /// Payment must be executed following the Single Euro Payments Area scheme.
    /// Encoded/decoded by serializers as &quot;SEPA&quot;.
    /// </summary>
    [EnumMember(Value = "SEPA")]
    [IsoId("_t9GgDPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed following the Single Euro Payments Area scheme.")]
    SingleEuroPaymentsArea,
    
    /// <summary>
    /// Payment execution following the cheque agreement and traveller cheque agreement of the German Banking Industry Committee (Die Deutsche Kreditwirtschaft - DK) and Deutsche Bundesbank – Scheck Verrechnung Deutschland
    /// Encoded/decoded by serializers as &quot;SVDE&quot;.
    /// </summary>
    [EnumMember(Value = "SVDE")]
    [IsoId("_t9QRAPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment execution following the cheque agreement and traveller cheque agreement of the German Banking Industry Committee (Die Deutsche Kreditwirtschaft - DK) and Deutsche Bundesbank – Scheck Verrechnung Deutschland")]
    DomesticChequeClearingAndSettlement,
    
    /// <summary>
    /// Payment must be executed as an urgent transaction cleared through a real-time gross settlement system, which is typically identified as a wire or high value transaction.  
    /// Encoded/decoded by serializers as &quot;URGP&quot;.
    /// </summary>
    [EnumMember(Value = "URGP")]
    [IsoId("_t9QRA_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed as an urgent transaction cleared through a real-time gross settlement system, which is typically identified as a wire or high value transaction.  ")]
    UrgentPayment,
    
    /// <summary>
    /// Payment must be executed as an urgent transaction cleared through a real-time net settlement system, which is typically identified as a wire or high value transaction.  
    /// Encoded/decoded by serializers as &quot;URNS&quot;.
    /// </summary>
    [EnumMember(Value = "URNS")]
    [IsoId("_t9aCAPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed as an urgent transaction cleared through a real-time net settlement system, which is typically identified as a wire or high value transaction.  ")]
    UrgentPaymentNetSettlement,
    
    /// <summary>
    /// Used for payment initiation to identify that a Payment or Direct Debit initiation must be executed as an instant or real-time payment instrument.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_JkJM8FD9Eey6cYDbEubNXg")]
    [Description(@"Used for payment initiation to identify that a Payment or Direct Debit initiation must be executed as an instant or real-time payment instrument.")]
    InstantCreditTransferOrInstantDirectDebit,
    
    /// <summary>
    /// Request to Pay (RTP) transaction refers to an RTP scheme (such as for example the SEPA Request to Pay (SRTP) scheme).
    /// Encoded/decoded by serializers as &quot;SRTP&quot;.
    /// </summary>
    [EnumMember(Value = "SRTP")]
    [IsoId("_BrMeQFD-Eey6cYDbEubNXg")]
    [Description(@"Request to Pay (RTP) transaction refers to an RTP scheme (such as for example the SEPA Request to Pay (SRTP) scheme).")]
    ServiceRequestToPay,
    
    /// <summary>
    /// Scheck Verarbeitung Austria (Cheque Processing).
    /// Encoded/decoded by serializers as &quot;SVAT&quot;.
    /// </summary>
    [EnumMember(Value = "SVAT")]
    [IsoId("_4Rs2II5EEeyANo-d7JlQ1A")]
    [Description(@"Scheck Verarbeitung Austria (Cheque Processing).")]
    ScheckVerarbeitungAustria,
    
    /// <summary>
    /// Tracked Instant Customer Credit Transfer.
    /// Encoded/decoded by serializers as &quot;G005&quot;.
    /// </summary>
    [EnumMember(Value = "G005")]
    [IsoId("_adonkOAhEey0k8vo1GQhqQ")]
    [Description(@"Tracked Instant Customer Credit Transfer.||")]
    TrackedInstantCustomerCreditTransfer,
    
    /// <summary>
    /// Specifies the service conditions applicable to a tracked exceptions and investigations case.
    /// Encoded/decoded by serializers as &quot;G006&quot;.
    /// </summary>
    [EnumMember(Value = "G006")]
    [IsoId("__L4RIOAhEey0k8vo1GQhqQ")]
    [Description(@"Specifies the service conditions applicable to a tracked exceptions and investigations case.")]
    TrackedCaseManagement,
    
    /// <summary>
    /// Specifies the service level for a tracked inbound customer credit transfer.
    /// Encoded/decoded by serializers as &quot;G007&quot;.
    /// </summary>
    [EnumMember(Value = "G007")]
    [IsoId("_MKyXkOAiEey0k8vo1GQhqQ")]
    [Description(@"Specifies the service level for a tracked inbound customer credit transfer.")]
    TrackedInboundCustomerCreditTransfer,
    
    /// <summary>
    /// Specifies the service level for a tracked low-value cross-border customer credit transfer.
    /// Encoded/decoded by serializers as &quot;G009&quot;.
    /// </summary>
    [EnumMember(Value = "G009")]
    [IsoId("_h5ZZEOAiEey0k8vo1GQhqQ")]
    [Description(@"Specifies the service level for a tracked low-value cross-border customer credit transfer.")]
    TrackedLowValueCrossBorderCustomerCreditTransfer,
    
    /// <summary>
    /// Transaction is to be treated as an advice and only applied to the account of the creditor or next agent after settlement of the cover has been confirmed.
    /// Encoded/decoded by serializers as &quot;WFSM&quot;.
    /// </summary>
    [EnumMember(Value = "WFSM")]
    [IsoId("_T8HuAGvcEe2F6NrIyOmXcA")]
    [Description(@"Transaction is to be treated as an advice and only applied to the account of the creditor or next agent after settlement of the cover has been confirmed.")]
    WaitForSettlement,
    
    /// <summary>
    /// Payment is executed following a Euro One-Leg Out Scheme.
    /// Encoded/decoded by serializers as &quot;EOLO&quot;.
    /// </summary>
    [EnumMember(Value = "EOLO")]
    [IsoId("_9m6qUP7KEe2ORYPQEd-Clg")]
    [Description(@"Payment is executed following a Euro One-Leg Out Scheme.")]
    EuroOneLegOut,
    
}
