// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a group of payment instructions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YrjY6Np-Ed-ak6NoX_4Aeg_-1876118210")]
[Description(@"Specifies the status of a group of payment instructions.")]
[DerivedFrom(typeof(PaymentStatusCode))]
public enum TransactionGroupStatus3Code
{
    /// <summary>
    /// Authentication and syntactical and semantical validation are successful.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_YrjY6dp-Ed-ak6NoX_4Aeg_-1876118208")]
    [Description(@"Authentication and syntactical and semantical validation are successful.")]
    AcceptedTechnicalValidation = PaymentStatusCode.AcceptedTechnicalValidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment initiation has been received by the receiving agent.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_Yrsi0Np-Ed-ak6NoX_4Aeg_-1876118179")]
    [Description(@"Payment initiation has been received by the receiving agent.")]
    Received = PaymentStatusCode.Received, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A number of transactions have been accepted, whereas another number of transactions have not yet achieved &apos;accepted&apos; status.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_Yrsi0dp-Ed-ak6NoX_4Aeg_-1876118178")]
    [Description(@"A number of transactions have been accepted, whereas another number of transactions have not yet achieved 'accepted' status.")]
    PartiallyAccepted = PaymentStatusCode.PartiallyAccepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_Yrsi0tp-Ed-ak6NoX_4Aeg_-1876117931")]
    [Description(@"Payment initiation or individual transaction included in the payment initiation has been rejected.")]
    Rejected = PaymentStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation is pending.  Further checks and status update will be performed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_Yrsi09p-Ed-ak6NoX_4Aeg_-1876117901")]
    [Description(@"Payment initiation or individual transaction included in the payment initiation is pending.  Further checks and status update will be performed.")]
    Pending = PaymentStatusCode.Pending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Preceding check of technical validation was successful. Customer profile check was also successful.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_Yrsi1Np-Ed-ak6NoX_4Aeg_-1876117900")]
    [Description(@"Preceding check of technical validation was successful. Customer profile check was also successful.")]
    AcceptedCustomerProfile = PaymentStatusCode.AcceptedCustomerProfile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.
    /// Encoded/decoded by serializers as &quot;ACSP&quot;.
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_Yrsi1dp-Ed-ak6NoX_4Aeg_-1876117870")]
    [Description(@"All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.")]
    AcceptedSettlementInProcess = PaymentStatusCode.AcceptedSettlementInProcess, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement on the debtor&apos;s account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement
    /// Encoded/decoded by serializers as &quot;ACSC&quot;.
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_Yrsi1tp-Ed-ak6NoX_4Aeg_-1876117869")]
    [Description(@"Settlement on the debtor's account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement")]
    AcceptedSettlementCompleted = PaymentStatusCode.AcceptedSettlementCompleted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is accepted but a change will be made, such as date or remittance not sent.
    /// Encoded/decoded by serializers as &quot;ACWC&quot;.
    /// </summary>
    [EnumMember(Value = "ACWC")]
    [IsoId("_Yrsi19p-Ed-ak6NoX_4Aeg_-1876117785")]
    [Description(@"Instruction is accepted but a change will be made, such as date or remittance not sent.")]
    AcceptedWithChange = PaymentStatusCode.AcceptedWithChange, // same ordinal as derivation source for type conversions
    
}
