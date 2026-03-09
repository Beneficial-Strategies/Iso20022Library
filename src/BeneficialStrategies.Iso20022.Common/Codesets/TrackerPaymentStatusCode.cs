// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates a status of a payment transaction as defined for the tracker.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GV2qUvpPEemXaqBx8S4XSg")]
[Description(@"Indicates a status of a payment transaction as defined for the tracker.")]
[Derivations(typeof(TrackerPaymentStatus1Code))]
public enum TrackerPaymentStatusCode
{
    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_GV3RUPpPEemXaqBx8S4XSg")]
    [Description(@"Payment initiation or individual transaction included in the payment initiation has been rejected.")]
    Rejected,
    
    /// <summary>
    /// All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.
    /// Encoded/decoded by serializers as &quot;ACSP&quot;.
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_GV3RU_pPEemXaqBx8S4XSg")]
    [Description(@"All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.")]
    AcceptedSettlementInProcess,
    
    /// <summary>
    /// Settlement on the creditor&apos;s account has been completed. 
    /// Encoded/decoded by serializers as &quot;ACCC&quot;.
    /// </summary>
    [EnumMember(Value = "ACCC")]
    [IsoId("_GV2qXPpPEemXaqBx8S4XSg")]
    [Description(@"Settlement on the creditor's account has been completed. ")]
    AcceptedCreditSettlementCompleted,
    
}
