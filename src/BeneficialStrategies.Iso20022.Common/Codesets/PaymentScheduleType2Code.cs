// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a payment schedule type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gbgLkLb0Eeu9Cp6InX88Vw")]
[Description(@"Specifies a payment schedule type.")]
[DerivedFrom(typeof(PaymentScheduleTypeCode))]
public enum PaymentScheduleType2Code
{
    /// <summary>
    /// Payment schedule is defined as per contract.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_k51YEbb0Eeu9Cp6InX88Vw")]
    [Description(@"Payment schedule is defined as per contract.")]
    Contract = PaymentScheduleTypeCode.Contract, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment schedule is estimated.
    /// Encoded/decoded by serializers as &quot;ESTM&quot;.
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_k-B7kbb0Eeu9Cp6InX88Vw")]
    [Description(@"Payment schedule is estimated.")]
    Estimated = PaymentScheduleTypeCode.Estimated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract Payment schedule is both defined as per Contract and estimated.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_pFQPobb0Eeu9Cp6InX88Vw")]
    [Description(@"Contract Payment schedule is both defined as per Contract and estimated.")]
    Both = PaymentScheduleTypeCode.Both, // same ordinal as derivation source for type conversions
    
}
