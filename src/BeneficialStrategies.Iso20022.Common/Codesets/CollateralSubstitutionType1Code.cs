// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the collateral that is substituted was posted against the variation margin or the independent amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcDkVNp-Ed-ak6NoX_4Aeg_917519215")]
[Description(
    @"Specifies if the collateral that is substituted was posted against the variation margin or the independent amount."
)]
[DerivedFrom(typeof(CollateralSubstitutionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CollateralSubstitutionType1Code>))]
#endif
public enum CollateralSubstitutionType1Code
{
    /// <summary>
    /// Specifies if the collateral that is substituted was posted against the variation margin.
    /// Encoded/decoded by serializers as &quot;AVMG&quot;.
    /// </summary>
    [EnumMember(Value = "AVMG")]
    [IsoId("_YcDkVdp-Ed-ak6NoX_4Aeg_168648303")]
    [Description(
        @"Specifies if the collateral that is substituted was posted against the variation margin."
    )]
    AgainstVariationMargin = CollateralSubstitutionTypeCode.AgainstVariationMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies if the collateral that is substituted was posted against the independent amount.
    /// Encoded/decoded by serializers as &quot;ASIA&quot;.
    /// </summary>
    [EnumMember(Value = "ASIA")]
    [IsoId("_YcDkVtp-Ed-ak6NoX_4Aeg_-914318971")]
    [Description(
        @"Specifies if the collateral that is substituted was posted against the independent amount."
    )]
    AgainstSegregatedIndependentAmount =
        CollateralSubstitutionTypeCode.AgainstSegregatedIndependentAmount, // same ordinal as derivation source for type conversions
}
