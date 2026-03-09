// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a single payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Cj0s5UJIEeinU6Cqu8f2Ow")]
[Description(@"Specifies the status of a single payment transaction.")]
[DerivedFrom(typeof(PaymentStatusCode))]
public enum TransactionIndividualStatus5Code
{
    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_Cj0s50JIEeinU6Cqu8f2Ow")]
    [Description(@"Payment initiation or individual transaction included in the payment initiation has been rejected.")]
    Rejected = PaymentStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.
    /// Encoded/decoded by serializers as &quot;ACSP&quot;.
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_Cj0s5kJIEeinU6Cqu8f2Ow")]
    [Description(@"All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.")]
    AcceptedSettlementInProcess = PaymentStatusCode.AcceptedSettlementInProcess, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement on the creditor&apos;s account has been completed. 
    /// Encoded/decoded by serializers as &quot;ACCC&quot;.
    /// </summary>
    [EnumMember(Value = "ACCC")]
    [IsoId("_rIE6kYXnEeizLI4uNYSjtg")]
    [Description(@"Settlement on the creditor's account has been completed. ")]
    AcceptedCreditSettlementCompleted = PaymentStatusCode.AcceptedCreditSettlementCompleted, // same ordinal as derivation source for type conversions
    
}
