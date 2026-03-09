// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Container Ship Freight.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zbpqAPwfEeW4Wthd0Ze_kA")]
[Description(@"Defines the sub-product of type Container Ship Freight.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType46Code
{
    /// <summary>
    /// Commodity of type container ships.
    /// Encoded/decoded by serializers as &quot;CSHP&quot;.
    /// </summary>
    [EnumMember(Value = "CSHP")]
    [IsoId("_9F9MIfwfEeW4Wthd0Ze_kA")]
    [Description(@"Commodity of type container ships.")]
    ContainerShip = AssetClassSubProductTypeCode.ContainerShip, // same ordinal as derivation source for type conversions
    
}
