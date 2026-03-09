// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DTpLsCDmEeahCJeThTBhHA")]
[Description(@"Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.")]
[Derivations(typeof(CollateralDeliveryMethod1Code))]
public enum CollateralDeliveryMethodCode
{
    /// <summary>
    /// Title transfer collateral arrangement.
    /// Encoded/decoded by serializers as &quot;TTCA&quot;.
    /// </summary>
    [EnumMember(Value = "TTCA")]
    [IsoId("_FZW7ACDmEeahCJeThTBhHA")]
    [Description(@"Title transfer collateral arrangement.")]
    TitleTransferCollateralArrangement,
    
    /// <summary>
    /// Securities interest collateral arrangement.
    /// Encoded/decoded by serializers as &quot;SICA&quot;.
    /// </summary>
    [EnumMember(Value = "SICA")]
    [IsoId("_LsvkoCDmEeahCJeThTBhHA")]
    [Description(@"Securities interest collateral arrangement.")]
    SecuritiesInterestCollateralArrangement,
    
    /// <summary>
    /// Securities interest with the right of use.
    /// Encoded/decoded by serializers as &quot;SIUR&quot;.
    /// </summary>
    [EnumMember(Value = "SIUR")]
    [IsoId("_OowCwCDmEeahCJeThTBhHA")]
    [Description(@"Securities interest with the right of use.")]
    SecuritiesInterestWithUseRight,
    
}
