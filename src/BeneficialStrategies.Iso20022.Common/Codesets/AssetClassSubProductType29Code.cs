// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Carbon Related.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eEGecVrNEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Carbon Related.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType29Code
{
    /// <summary>
    /// Commodity of type carbon related.
    /// Encoded/decoded by serializers as &quot;CRBR&quot;.
    /// </summary>
    [EnumMember(Value = "CRBR")]
    [IsoId("_ePRMoVrNEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type carbon related.")]
    CarbonRelated = AssetClassSubProductTypeCode.CarbonRelated, // same ordinal as derivation source for type conversions
    
}
