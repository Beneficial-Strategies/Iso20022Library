// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates a status of a payment transaction as defined for the tracker.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y4-AIPpPEemXaqBx8S4XSg")]
[Description(@"Indicates a status of a payment transaction as defined for the tracker.")]
[DerivedFrom(typeof(TrackerPaymentStatusCode))]
public enum TrackerPaymentStatus1Code
{
    /// <summary>
    /// Settlement on the creditor&apos;s account has been completed. 
    /// Encoded/decoded by serializers as &quot;ACCC&quot;.
    /// </summary>
    [EnumMember(Value = "ACCC")]
    [IsoId("_bARq4fpPEemXaqBx8S4XSg")]
    [Description(@"Settlement on the creditor's account has been completed. ")]
    AcceptedCreditSettlementCompleted = TrackerPaymentStatusCode.AcceptedCreditSettlementCompleted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.
    /// Encoded/decoded by serializers as &quot;ACSP&quot;.
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_bIa6QfpPEemXaqBx8S4XSg")]
    [Description(@"All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.")]
    AcceptedSettlementInProcess = TrackerPaymentStatusCode.AcceptedSettlementInProcess, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_bPzUofpPEemXaqBx8S4XSg")]
    [Description(@"Payment initiation or individual transaction included in the payment initiation has been rejected.")]
    Rejected = TrackerPaymentStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
}
