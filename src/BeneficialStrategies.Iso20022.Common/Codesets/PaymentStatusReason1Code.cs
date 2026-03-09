// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the reason for a payment status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EbCioEJHEeinU6Cqu8f2Ow")]
[Description(@"Provides the reason for a payment status.")]
[DerivedFrom(typeof(ExternalPaymentStatusReasonCode))]
public enum PaymentStatusReason1Code
{
    /// <summary>
    /// Credit Transfer has been delivered to creditor agent with transaction’s service obligations maintained.
    /// Encoded/decoded by serializers as &quot;G005&quot;.
    /// </summary>
    [EnumMember(Value = "G005")]
    [IsoId("_JwolkUleEei_aPHvPJUVuw")]
    [Description(@"Credit Transfer has been delivered to creditor agent with transaction’s service obligations maintained.")]
    PaymentDeliveredAndSLAMaintained = ExternalPaymentStatusReasonCode.PaymentDeliveredAndSLAMaintained, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit Transfer has been delivered to creditor agent where the transaction’s service obligations were no longer maintained.
    /// Encoded/decoded by serializers as &quot;G006&quot;.
    /// </summary>
    [EnumMember(Value = "G006")]
    [IsoId("_KAQ9AUleEei_aPHvPJUVuw")]
    [Description(@"Credit Transfer has been delivered to creditor agent where the transaction’s service obligations were no longer maintained.")]
    PaymentDeliveredAndSLANoLongerMaintained = ExternalPaymentStatusReasonCode.PaymentDeliveredAndSLANoLongerMaintained, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Status Originator transferred the Credit Transfer to the next Agent or to a Market Infrastructure where the transaction’s service obligations may no longer be guaranteed.
    /// Encoded/decoded by serializers as &quot;G001&quot;.
    /// </summary>
    [EnumMember(Value = "G001")]
    [IsoId("_32zh4YN0EeiZB_kIT07yOA")]
    [Description(@"The Status Originator transferred the Credit Transfer to the next Agent or to a Market Infrastructure where the transaction’s service obligations may no longer be guaranteed.")]
    PaymentTransferredAndSLANoLongerMaintained = ExternalPaymentStatusReasonCode.PaymentTransferredAndSLANoLongerMaintained, // same ordinal as derivation source for type conversions
    
}
