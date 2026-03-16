// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the collateral has been posted against the variation margin or the segregated independent amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZXcuNp-Ed-ak6NoX_4Aeg_1268885357")]
[Description(
    @"Indicates whether the collateral has been posted against the variation margin or the segregated independent amount."
)]
[Derivations(typeof(CollateralPurpose1Code))]
public enum CollateralPurposeCode
{
    /// <summary>
    /// Collateral has been posted against the variation margin.
    /// Encoded/decoded by serializers as &quot;VAMA&quot;.
    /// </summary>
    [EnumMember(Value = "VAMA")]
    [IsoId("_YZXcudp-Ed-ak6NoX_4Aeg_-2132642673")]
    [Description(@"Collateral has been posted against the variation margin.")]
    VariationMargin,

    /// <summary>
    /// Collateral has been posted against the segregated independent amount.
    /// Encoded/decoded by serializers as &quot;SINA&quot;.
    /// </summary>
    [EnumMember(Value = "SINA")]
    [IsoId("_YZXcutp-Ed-ak6NoX_4Aeg_846367471")]
    [Description(@"Collateral has been posted against the segregated independent amount.")]
    SegregatedIndependentAmount,
}
