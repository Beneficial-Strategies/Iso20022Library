// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external service level code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amolhdp-Ed-ak6NoX_4Aeg_-670764132")]
[Description(@"Specifies the external service level code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalServiceLevelCode))]
public enum ExternalServiceLevel1Code
{
    /// <summary>
    /// Payment through internal book transfer.
    /// Encoded/decoded by serializers as &quot;BKTR&quot;.
    /// </summary>
    [EnumMember(Value = "BKTR")]
    [IsoId("_t8zlGPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment through internal book transfer.")]
    BookTransaction = ExternalServiceLevelCode.BookTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tracked Customer Credit Transfer.
    /// Encoded/decoded by serializers as &quot;G001&quot;.
    /// </summary>
    [EnumMember(Value = "G001")]
    [IsoId("_t8zlG_RYEeuLhpyIdtJzwg")]
    [Description(@"Tracked Customer Credit Transfer.")]
    TrackedCustomerCreditTransfer = ExternalServiceLevelCode.TrackedCustomerCreditTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tracked Stop and Recall 
    /// Encoded/decoded by serializers as &quot;G002&quot;.
    /// </summary>
    [EnumMember(Value = "G002")]
    [IsoId("_t8zlHvRYEeuLhpyIdtJzwg")]
    [Description(@"Tracked Stop and Recall ")]
    TrackedStopAndRecall = ExternalServiceLevelCode.TrackedStopAndRecall, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tracked Outbound Corporate Transfer.
    /// Encoded/decoded by serializers as &quot;G003&quot;.
    /// </summary>
    [EnumMember(Value = "G003")]
    [IsoId("_t89WEvRYEeuLhpyIdtJzwg")]
    [Description(@"Tracked Outbound Corporate Transfer.")]
    TrackedOutboundCorporateTransfer = ExternalServiceLevelCode.TrackedOutboundCorporateTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tracked Financial Institution Transfer.
    /// Encoded/decoded by serializers as &quot;G004&quot;.
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("_t89WFfRYEeuLhpyIdtJzwg")]
    [Description(@"Tracked Financial Institution Transfer.")]
    TrackedFinancialInstitutionTransfer = ExternalServiceLevelCode.TrackedFinancialInstitutionTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payments must be executed following the NPC Area Payment scheme.
    /// Encoded/decoded by serializers as &quot;NPCA&quot;.
    /// </summary>
    [EnumMember(Value = "NPCA")]
    [IsoId("_t89WGPRYEeuLhpyIdtJzwg")]
    [Description(@"Payments must be executed following the NPC Area Payment scheme.")]
    NordicPaymentsCouncilAreaTransfer = ExternalServiceLevelCode.NordicPaymentsCouncilAreaTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment must be executed as a non-urgent transaction with priority settlement.
    /// Encoded/decoded by serializers as &quot;NUGP&quot;.
    /// </summary>
    [EnumMember(Value = "NUGP")]
    [IsoId("_t9GgAvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed as a non-urgent transaction with priority settlement.")]
    NonurgentPriorityPayment = ExternalServiceLevelCode.NonurgentPriorityPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment must be executed as a non-urgent transaction, which is typically identified as an ACH or low value transaction. 
    /// Encoded/decoded by serializers as &quot;NURG&quot;.
    /// </summary>
    [EnumMember(Value = "NURG")]
    [IsoId("_t9GgBfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed as a non-urgent transaction, which is typically identified as an ACH or low value transaction. ")]
    NonurgentPayment = ExternalServiceLevelCode.NonurgentPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction must be processed according to the EBA Priority Service.
    /// Encoded/decoded by serializers as &quot;PRPT&quot;.
    /// </summary>
    [EnumMember(Value = "PRPT")]
    [IsoId("_t9GgCPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction must be processed according to the EBA Priority Service.")]
    EBAPriorityService = ExternalServiceLevelCode.EBAPriorityService, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment must be executed with same day value to the creditor.
    /// Encoded/decoded by serializers as &quot;SDVA&quot;.
    /// </summary>
    [EnumMember(Value = "SDVA")]
    [IsoId("_t9GgC_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed with same day value to the creditor.")]
    SameDayValue = ExternalServiceLevelCode.SameDayValue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment must be executed following the Single Euro Payments Area scheme.
    /// Encoded/decoded by serializers as &quot;SEPA&quot;.
    /// </summary>
    [EnumMember(Value = "SEPA")]
    [IsoId("_t9GgDvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed following the Single Euro Payments Area scheme.")]
    SingleEuroPaymentsArea = ExternalServiceLevelCode.SingleEuroPaymentsArea, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment execution following the cheque agreement and traveller cheque agreement of the German Banking Industry Committee (Die Deutsche Kreditwirtschaft - DK) and Deutsche Bundesbank – Scheck Verrechnung Deutschland
    /// Encoded/decoded by serializers as &quot;SVDE&quot;.
    /// </summary>
    [EnumMember(Value = "SVDE")]
    [IsoId("_t9QRAvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment execution following the cheque agreement and traveller cheque agreement of the German Banking Industry Committee (Die Deutsche Kreditwirtschaft - DK) and Deutsche Bundesbank – Scheck Verrechnung Deutschland")]
    DomesticChequeClearingAndSettlement = ExternalServiceLevelCode.DomesticChequeClearingAndSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment must be executed as an urgent transaction cleared through a real-time gross settlement system, which is typically identified as a wire or high value transaction.  
    /// Encoded/decoded by serializers as &quot;URGP&quot;.
    /// </summary>
    [EnumMember(Value = "URGP")]
    [IsoId("_t9QRBfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed as an urgent transaction cleared through a real-time gross settlement system, which is typically identified as a wire or high value transaction.  ")]
    UrgentPayment = ExternalServiceLevelCode.UrgentPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment must be executed as an urgent transaction cleared through a real-time net settlement system, which is typically identified as a wire or high value transaction.  
    /// Encoded/decoded by serializers as &quot;URNS&quot;.
    /// </summary>
    [EnumMember(Value = "URNS")]
    [IsoId("_t9aCAvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment must be executed as an urgent transaction cleared through a real-time net settlement system, which is typically identified as a wire or high value transaction.  ")]
    UrgentPaymentNetSettlement = ExternalServiceLevelCode.UrgentPaymentNetSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used for payment initiation to identify that a Payment or Direct Debit initiation must be executed as an instant or real-time payment instrument.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_ThOEoVD-Eey6cYDbEubNXg")]
    [Description(@"Used for payment initiation to identify that a Payment or Direct Debit initiation must be executed as an instant or real-time payment instrument.")]
    InstantCreditTransferOrInstantDirectDebit = ExternalServiceLevelCode.InstantCreditTransferOrInstantDirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request to Pay (RTP) transaction refers to an RTP scheme (such as for example the SEPA Request to Pay (SRTP) scheme).
    /// Encoded/decoded by serializers as &quot;SRTP&quot;.
    /// </summary>
    [EnumMember(Value = "SRTP")]
    [IsoId("_Tt5OsVD-Eey6cYDbEubNXg")]
    [Description(@"Request to Pay (RTP) transaction refers to an RTP scheme (such as for example the SEPA Request to Pay (SRTP) scheme).")]
    ServiceRequestToPay = ExternalServiceLevelCode.ServiceRequestToPay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheck Verarbeitung Austria (Cheque Processing).
    /// Encoded/decoded by serializers as &quot;SVAT&quot;.
    /// </summary>
    [EnumMember(Value = "SVAT")]
    [IsoId("_HouqgY5FEeyANo-d7JlQ1A")]
    [Description(@"Scheck Verarbeitung Austria (Cheque Processing).")]
    ScheckVerarbeitungAustria = ExternalServiceLevelCode.ScheckVerarbeitungAustria, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies the service conditions applicable to a tracked exceptions and investigations case.
    /// Encoded/decoded by serializers as &quot;G006&quot;.
    /// </summary>
    [EnumMember(Value = "G006")]
    [IsoId("_G0Cf4eAjEey0k8vo1GQhqQ")]
    [Description(@"Specifies the service conditions applicable to a tracked exceptions and investigations case.")]
    TrackedCaseManagement = ExternalServiceLevelCode.TrackedCaseManagement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies the service level for a tracked inbound customer credit transfer.
    /// Encoded/decoded by serializers as &quot;G007&quot;.
    /// </summary>
    [EnumMember(Value = "G007")]
    [IsoId("_HFnYEeAjEey0k8vo1GQhqQ")]
    [Description(@"Specifies the service level for a tracked inbound customer credit transfer.")]
    TrackedInboundCustomerCreditTransfer = ExternalServiceLevelCode.TrackedInboundCustomerCreditTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tracked Instant Customer Credit Transfer.
    /// Encoded/decoded by serializers as &quot;G005&quot;.
    /// </summary>
    [EnumMember(Value = "G005")]
    [IsoId("_HTL6AeAjEey0k8vo1GQhqQ")]
    [Description(@"Tracked Instant Customer Credit Transfer.||")]
    TrackedInstantCustomerCreditTransfer = ExternalServiceLevelCode.TrackedInstantCustomerCreditTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies the service level for a tracked low-value cross-border customer credit transfer.
    /// Encoded/decoded by serializers as &quot;G009&quot;.
    /// </summary>
    [EnumMember(Value = "G009")]
    [IsoId("_HdnBUeAjEey0k8vo1GQhqQ")]
    [Description(@"Specifies the service level for a tracked low-value cross-border customer credit transfer.")]
    TrackedLowValueCrossBorderCustomerCreditTransfer = ExternalServiceLevelCode.TrackedLowValueCrossBorderCustomerCreditTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is to be treated as an advice and only applied to the account of the creditor or next agent after settlement of the cover has been confirmed.
    /// Encoded/decoded by serializers as &quot;WFSM&quot;.
    /// </summary>
    [EnumMember(Value = "WFSM")]
    [IsoId("_T8HuAmvcEe2F6NrIyOmXcA")]
    [Description(@"Transaction is to be treated as an advice and only applied to the account of the creditor or next agent after settlement of the cover has been confirmed.")]
    WaitForSettlement = ExternalServiceLevelCode.WaitForSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is executed following a Euro One-Leg Out Scheme.
    /// Encoded/decoded by serializers as &quot;EOLO&quot;.
    /// </summary>
    [EnumMember(Value = "EOLO")]
    [IsoId("_9m6qUv7KEe2ORYPQEd-Clg")]
    [Description(@"Payment is executed following a Euro One-Leg Out Scheme.")]
    EuroOneLegOut = ExternalServiceLevelCode.EuroOneLegOut, // same ordinal as derivation source for type conversions
    
}
