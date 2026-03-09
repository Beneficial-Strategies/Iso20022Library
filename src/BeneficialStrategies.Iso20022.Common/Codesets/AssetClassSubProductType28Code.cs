// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Renewable Energy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sFQMYVrKEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Renewable Energy.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType28Code
{
    /// <summary>
    /// Commodity of type renewable energy.
    /// Encoded/decoded by serializers as &quot;RNNG&quot;.
    /// </summary>
    [EnumMember(Value = "RNNG")]
    [IsoId("_sQ1KRVrKEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type renewable energy.")]
    RenewableEnergy = AssetClassSubProductTypeCode.RenewableEnergy, // same ordinal as derivation source for type conversions
    
}
