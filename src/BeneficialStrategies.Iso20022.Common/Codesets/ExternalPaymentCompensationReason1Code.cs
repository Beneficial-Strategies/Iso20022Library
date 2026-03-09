// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for compensation for the processing of a payment, as published in an external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CHK8YIjYEeeDW7_wB-eK_g")]
[Description(@"Specifies the reason for compensation for the processing of a payment, as published in an external code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalPaymentCompensationReasonCode))]
public enum ExternalPaymentCompensationReason1Code
{
    /// <summary>
    /// Compensation requested for value date correction.
    /// Encoded/decoded by serializers as &quot;VADA&quot;.
    /// </summary>
    [EnumMember(Value = "VADA")]
    [IsoId("_udl99fRYEeuLhpyIdtJzwg")]
    [Description(@"Compensation requested for value date correction.")]
    ValueDateAdjustment = ExternalPaymentCompensationReasonCode.ValueDateAdjustment, // same ordinal as derivation source for type conversions
    
}
