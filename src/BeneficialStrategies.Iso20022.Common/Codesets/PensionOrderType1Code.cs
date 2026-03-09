// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of order attached to a pension.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bGxkcLTqEeiENt6AoDfPXg")]
[Description(@"Specifies a type of order attached to a pension.")]
[DerivedFrom(typeof(PensionOrderTypeCode))]
public enum PensionOrderType1Code
{
    /// <summary>
    /// Pension policy, plan or scheme has been earmarked (set aside.)
    /// Encoded/decoded by serializers as &quot;EARM&quot;.
    /// </summary>
    [EnumMember(Value = "EARM")]
    [IsoId("_j14EwbT5EeiENt6AoDfPXg")]
    [Description(@"Pension policy, plan or scheme has been earmarked (set aside.)")]
    Earmark = PensionOrderTypeCode.Earmark, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sharing order for the pension policy, plan or scheme has been issued by a court.
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_j7FU4bT5EeiENt6AoDfPXg")]
    [Description(@"Sharing order for the pension policy, plan or scheme has been issued by a court.")]
    Sharing = PensionOrderTypeCode.Sharing, // same ordinal as derivation source for type conversions
    
}
