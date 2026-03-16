// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of lump sum.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TQu1cLKeEeiXL6Ccd-oU8g")]
[Description(@"Specifies a type of lump sum.")]
[DerivedFrom(typeof(LumpSumTypeCode))]
public enum LumpSumType1Code
{
    /// <summary>
    /// Lump sum is a death benefit lump sum.
    /// Encoded/decoded by serializers as &quot;DEAB&quot;.
    /// </summary>
    [EnumMember(Value = "DEAB")]
    [IsoId("_ULDvsbKeEeiXL6Ccd-oU8g")]
    [Description(@"Lump sum is a death benefit lump sum.")]
    DeathBenefit = LumpSumTypeCode.DeathBenefit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Lump sum is a pension commencement lump sum.
    /// Encoded/decoded by serializers as &quot;PCLS&quot;.
    /// </summary>
    [EnumMember(Value = "PCLS")]
    [IsoId("_UQQ_0bKeEeiXL6Ccd-oU8g")]
    [Description(@"Lump sum is a pension commencement lump sum.")]
    PensionCommencement = LumpSumTypeCode.PensionCommencement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Lump sum is an uncrystallised fund pension lump sum.
    /// Encoded/decoded by serializers as &quot;UFPL&quot;.
    /// </summary>
    [EnumMember(Value = "UFPL")]
    [IsoId("_UVKt8bKeEeiXL6Ccd-oU8g")]
    [Description(@"Lump sum is an uncrystallised fund pension lump sum.")]
    Uncrystallised = LumpSumTypeCode.Uncrystallised, // same ordinal as derivation source for type conversions
}
