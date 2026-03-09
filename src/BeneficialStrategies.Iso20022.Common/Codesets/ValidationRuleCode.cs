// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies all codes that are to be used in the formal validation rules.
/// Usage: those codes must not be used in message definitions, as the code set is used when the formal validation rules make reference of an external code sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pQycwB8_EeuaqdhZaJ3GHw")]
[Description(@"Specifies all codes that are to be used in the formal validation rules.||Usage: those codes must not be used in message definitions, as the code set is used when the formal validation rules make reference of an external code sets.")]
[Derivations(typeof(ValidationRuleStatus1Code),typeof(ValidationRuleCreditSettlement1Code),typeof(ValidationRuleConfirmation1Code),typeof(ValidationRuleSettlementInProcess1Code),typeof(ValidationRuleAnyBank1Code),typeof(ValidationRuleStatus2Code),typeof(ValidationRuleSpecifiedAddress1Code),typeof(ValidationRulePending1Code),typeof(ValidationRuleStatus3Code),typeof(ValidationRulePendingAndRejected1Code),typeof(ValidationRuleReceived1Code),typeof(ValidationRulePayCreditorByCheque1Code),typeof(ValidationRuleRejected1Code),typeof(ValidationRuleInstruction1Code),typeof(ValidationRuleNarrative1Code),typeof(ValidationRuleIssuanceType1Code))]
public enum ValidationRuleCode
{
    /// <summary>
    /// Accepted cancellation request.
    /// Encoded/decoded by serializers as &quot;ACCR&quot;.
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("_h-RVMh-yEeuxStysDTgLiw")]
    [Description(@"Accepted cancellation request.")]
    AcceptedCancellationRequest,
    
    /// <summary>
    /// Accepted customer profile.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_h-RVNB-yEeuxStysDTgLiw")]
    [Description(@"Accepted customer profile.")]
    AcceptedCustomerProfile,
    
    /// <summary>
    /// Accepted settlement completed.
    /// Encoded/decoded by serializers as &quot;ACSC&quot;.
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_h-RVNR-yEeuxStysDTgLiw")]
    [Description(@"Accepted settlement completed.")]
    AcceptedSettlementCompleted,
    
    /// <summary>
    /// Accepted settlement in process.
    /// Encoded/decoded by serializers as &quot;ACSP&quot;.
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_h-RVNh-yEeuxStysDTgLiw")]
    [Description(@"Accepted settlement in process.")]
    AcceptedSettlementInProcess,
    
    /// <summary>
    /// Accepted technical validation.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_h-RVNx-yEeuxStysDTgLiw")]
    [Description(@"Accepted technical validation.")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// Accepted with change.
    /// Encoded/decoded by serializers as &quot;ACWC&quot;.
    /// </summary>
    [EnumMember(Value = "ACWC")]
    [IsoId("_h-RVOB-yEeuxStysDTgLiw")]
    [Description(@"Accepted with change.")]
    AcceptedWithChange,
    
    /// <summary>
    /// Pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_h-RVPR-yEeuxStysDTgLiw")]
    [Description(@"Pending.")]
    Pending,
    
    /// <summary>
    /// Received.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_h-RVPx-yEeuxStysDTgLiw")]
    [Description(@"Received.")]
    Received,
    
    /// <summary>
    /// Rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_h-RVQB-yEeuxStysDTgLiw")]
    [Description(@"Rejected.")]
    Rejected,
    
    /// <summary>
    /// Narrative.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_9DoG8B-0EeuxStysDTgLiw")]
    [Description(@"Narrative.")]
    Narrative,
    
    /// <summary>
    /// Pay creditor by cheque.
    /// Encoded/decoded by serializers as &quot;CHQB&quot;.
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_WWUTMR-1EeuxStysDTgLiw")]
    [Description(@"Pay creditor by cheque.")]
    PayCreditorByCheque,
    
    /// <summary>
    /// Hold cash for creditor.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_jz9loyAZEeuxStysDTgLiw")]
    [Description(@"Hold cash for creditor.")]
    HoldCashForCreditor,
    
    /// <summary>
    /// Phone beneficiary.
    /// Encoded/decoded by serializers as &quot;PHOB&quot;.
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_jz9lpSAZEeuxStysDTgLiw")]
    [Description(@"Phone beneficiary.")]
    PhoneBeneficiary,
    
    /// <summary>
    /// Telecom beneficiary.
    /// Encoded/decoded by serializers as &quot;TELB&quot;.
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_prFKASAZEeuxStysDTgLiw")]
    [Description(@"Telecom beneficiary.")]
    Telecom,
    
    /// <summary>
    /// Specified address.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_ohocwCBoEeugLNJneiyzbA")]
    [Description(@"Specified address.")]
    SpecifiedAddress,
    
    /// <summary>
    /// Any bank.
    /// Encoded/decoded by serializers as &quot;ANYB&quot;.
    /// </summary>
    [EnumMember(Value = "ANYB")]
    [IsoId("_oraD0CBoEeugLNJneiyzbA")]
    [Description(@"Any bank.")]
    AnyBank,
    
    /// <summary>
    /// Confirmation party in trade.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_ow4ZsCBoEeugLNJneiyzbA")]
    [Description(@"Confirmation party in trade.")]
    Confirmation,
    
    /// <summary>
    /// Undertaking issued direct.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_h0ouYyBqEeugLNJneiyzbA")]
    [Description(@"Undertaking issued direct.")]
    UndertakingIssuedDirect,
    
    /// <summary>
    /// Undertaking issued via confirming party.
    /// Encoded/decoded by serializers as &quot;ISCO&quot;.
    /// </summary>
    [EnumMember(Value = "ISCO")]
    [IsoId("_h0ouZCBqEeugLNJneiyzbA")]
    [Description(@"Undertaking issued via confirming party.")]
    UndertakingIssuedViaConfirmingParty,
    
    /// <summary>
    /// Undertaking issued via advising party.
    /// Encoded/decoded by serializers as &quot;ISAD&quot;.
    /// </summary>
    [EnumMember(Value = "ISAD")]
    [IsoId("_h0ouZSBqEeugLNJneiyzbA")]
    [Description(@"Undertaking issued via advising party.")]
    UndertakingViaAdvisingParty,
    
    /// <summary>
    /// AcceptedCreditSettlementCompleted
    /// Encoded/decoded by serializers as &quot;ACCC&quot;.
    /// </summary>
    [EnumMember(Value = "ACCC")]
    [IsoId("_aAh30CE5EeuIZ4Hf6difAw")]
    [Description(@"AcceptedCreditSettlementCompleted")]
    AcceptedCreditSettlementCompleted,
    
    /// <summary>
    /// Request for Cancellation has been forwarded to the payment processing/last payment processing agent.
    /// Encoded/decoded by serializers as &quot;S003&quot;.
    /// </summary>
    [EnumMember(Value = "S003")]
    [IsoId("_TXXz0H-0Ee27G9oJfa4a8Q")]
    [Description(@"Request for Cancellation has been forwarded to the payment processing/last payment processing agent.")]
    RequestForCancellationForwarded,
    
    /// <summary>
    /// Request for Cancellation has been acknowledged as delivered to payment processing/last payment processing agent.
    /// Encoded/decoded by serializers as &quot;S004&quot;.
    /// </summary>
    [EnumMember(Value = "S004")]
    [IsoId("_lDCkUH-0Ee27G9oJfa4a8Q")]
    [Description(@"Request for Cancellation has been acknowledged as delivered to payment processing/last payment processing agent.")]
    RequestForCancellationDeliveryAcknowledgement,

    /// <summary>
    /// Responder is requested to review an earlier response as the requestor objects to it.
    /// Encoded/decoded by serializers as &quot;RQOB&quot;.
    /// </summary>
    [EnumMember(Value = "RQOB")]
    [IsoId("")]
    [Description(@"Responder is requested to review an earlier response as the requestor objects to it.")]
    RequestObjection,

}
