// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of lump sum.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SbbakLKdEeiXL6Ccd-oU8g")]
[Description(@"Specifies a type of lump sum.")]
[Derivations(typeof(LumpSumType1Code))]
public enum LumpSumTypeCode
{
    /// <summary>
    /// Lump sum is a death benefit lump sum.
    /// Encoded/decoded by serializers as &quot;DEAB&quot;.
    /// </summary>
    [EnumMember(Value = "DEAB")]
    [IsoId("_V_DSULKdEeiXL6Ccd-oU8g")]
    [Description(@"Lump sum is a death benefit lump sum.")]
    DeathBenefit,
    
    /// <summary>
    /// Lump sum is a pension commencement lump sum.
    /// Encoded/decoded by serializers as &quot;PCLS&quot;.
    /// </summary>
    [EnumMember(Value = "PCLS")]
    [IsoId("_10zi8LKdEeiXL6Ccd-oU8g")]
    [Description(@"Lump sum is a pension commencement lump sum.")]
    PensionCommencement,
    
    /// <summary>
    /// Lump sum is an uncrystallised fund pension lump sum.
    /// Encoded/decoded by serializers as &quot;UFPL&quot;.
    /// </summary>
    [EnumMember(Value = "UFPL")]
    [IsoId("_E5dN4LKeEeiXL6Ccd-oU8g")]
    [Description(@"Lump sum is an uncrystallised fund pension lump sum.")]
    Uncrystallised,
    
}
