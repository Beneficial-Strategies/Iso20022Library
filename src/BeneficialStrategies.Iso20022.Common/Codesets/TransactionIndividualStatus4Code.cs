// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a single payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PKmAgKEXEeaGKbT2u7DmyA")]
[Description(@"Specifies the status of a single payment transaction.")]
[DerivedFrom(typeof(PaymentStatusCode))]
public enum TransactionIndividualStatus4Code
{
    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_d-6wcaEXEeaGKbT2u7DmyA")]
    [Description(@"Payment initiation or individual transaction included in the payment initiation has been rejected.")]
    Rejected = PaymentStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.
    /// Encoded/decoded by serializers as &quot;ACSP&quot;.
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_vZ7SgaZsEeatnf2letP_og")]
    [Description(@"All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.")]
    AcceptedSettlementInProcess = PaymentStatusCode.AcceptedSettlementInProcess, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement on the debtor&apos;s account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement
    /// Encoded/decoded by serializers as &quot;ACSC&quot;.
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_ufz3wKcpEeaDVIZNl20DWg")]
    [Description(@"Settlement on the debtor's account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement")]
    AcceptedSettlementCompleted = PaymentStatusCode.AcceptedSettlementCompleted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement on the creditor&apos;s account has been completed. 
    /// Encoded/decoded by serializers as &quot;ACCC&quot;.
    /// </summary>
    [EnumMember(Value = "ACCC")]
    [IsoId("_XidJkYErEei51tn2YGQhvg")]
    [Description(@"Settlement on the creditor's account has been completed. ")]
    AcceptedCreditSettlementCompleted = PaymentStatusCode.AcceptedCreditSettlementCompleted, // same ordinal as derivation source for type conversions
    
}
