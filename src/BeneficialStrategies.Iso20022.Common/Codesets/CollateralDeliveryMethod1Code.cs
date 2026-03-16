// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kC5QICDmEeahCJeThTBhHA")]
[Description(
    @"Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use."
)]
[DerivedFrom(typeof(CollateralDeliveryMethodCode))]
public enum CollateralDeliveryMethod1Code
{
    /// <summary>
    /// Securities interest collateral arrangement.
    /// Encoded/decoded by serializers as &quot;SICA&quot;.
    /// </summary>
    [EnumMember(Value = "SICA")]
    [IsoId("_lJtHMSDmEeahCJeThTBhHA")]
    [Description(@"Securities interest collateral arrangement.")]
    SecuritiesInterestCollateralArrangement =
        CollateralDeliveryMethodCode.SecuritiesInterestCollateralArrangement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities interest with the right of use.
    /// Encoded/decoded by serializers as &quot;SIUR&quot;.
    /// </summary>
    [EnumMember(Value = "SIUR")]
    [IsoId("_lS7UoSDmEeahCJeThTBhHA")]
    [Description(@"Securities interest with the right of use.")]
    SecuritiesInterestWithUseRight = CollateralDeliveryMethodCode.SecuritiesInterestWithUseRight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Title transfer collateral arrangement.
    /// Encoded/decoded by serializers as &quot;TTCA&quot;.
    /// </summary>
    [EnumMember(Value = "TTCA")]
    [IsoId("_laNoYSDmEeahCJeThTBhHA")]
    [Description(@"Title transfer collateral arrangement.")]
    TitleTransferCollateralArrangement =
        CollateralDeliveryMethodCode.TitleTransferCollateralArrangement, // same ordinal as derivation source for type conversions
}
