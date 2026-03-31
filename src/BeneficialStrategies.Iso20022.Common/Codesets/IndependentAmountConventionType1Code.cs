// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Determines how the independent amount was applied in the margin calculation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YczLNtp-Ed-ak6NoX_4Aeg_428105906")]
[Description(@"Determines how the independent amount was applied in the margin calculation.")]
[DerivedFrom(typeof(IndependentAmountConventionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<IndependentAmountConventionType1Code>))]
#endif
public enum IndependentAmountConventionType1Code
{
    /// <summary>
    /// Independent amount is an add on to exposure.
    /// Encoded/decoded by serializers as &quot;NBTR&quot;.
    /// </summary>
    [EnumMember(Value = "NBTR")]
    [IsoId("_YczLN9p-Ed-ak6NoX_4Aeg_-1097054396")]
    [Description(@"Independent amount is an add on to exposure.")]
    NettedBeforeThreshold = IndependentAmountConventionTypeCode.NettedBeforeThreshold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Independent amount is an add on to the credit support amount and forms part of the variation margin requirement.
    /// Encoded/decoded by serializers as &quot;NATR&quot;.
    /// </summary>
    [EnumMember(Value = "NATR")]
    [IsoId("_Yc8VINp-Ed-ak6NoX_4Aeg_-642967127")]
    [Description(
        @"Independent amount is an add on to the credit support amount and forms part of the variation margin requirement."
    )]
    NettedAfterThreshold = IndependentAmountConventionTypeCode.NettedAfterThreshold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Independent amount is treated independently of variation margin for segregation purposes.
    /// Encoded/decoded by serializers as &quot;SEGR&quot;.
    /// </summary>
    [EnumMember(Value = "SEGR")]
    [IsoId("_Yc8VIdp-Ed-ak6NoX_4Aeg_226653514")]
    [Description(
        @"Independent amount is treated independently of variation margin for segregation purposes."
    )]
    Segregated = IndependentAmountConventionTypeCode.Segregated, // same ordinal as derivation source for type conversions
}
