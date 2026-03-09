// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of reconciliation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_B1inEE-DEeePXdaAO32Uew")]
[Description(@"Type of reconciliation.")]
[DerivedFrom(typeof(CardServiceTypeCode))]
public enum CardServiceType4Code
{
    /// <summary>
    /// Partial reconciliation of the day.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_GQgWgU-DEeePXdaAO32Uew")]
    [Description(@"Partial reconciliation of the day.")]
    CheckPoint = CardServiceTypeCode.CheckPoint, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Final reconciliation.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_HStaYk-DEeePXdaAO32Uew")]
    [Description(@"Final reconciliation.")]
    Final = CardServiceTypeCode.Final, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National defined code.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_H7LIkk-DEeePXdaAO32Uew")]
    [Description(@"National defined code.")]
    OtherNational = CardServiceTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Private defined code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_IH-Ock-DEeePXdaAO32Uew")]
    [Description(@"Private defined code.")]
    OtherPrivate = CardServiceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
}
