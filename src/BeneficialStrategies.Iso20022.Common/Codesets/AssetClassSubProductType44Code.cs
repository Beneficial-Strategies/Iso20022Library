// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Urea and Ammonium Nitrate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vdR-sVr3EeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Urea and Ammonium Nitrate.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType44Code
{
    /// <summary>
    /// Commodity of type urea and ammonium nitrite.
    /// Encoded/decoded by serializers as &quot;UAAN&quot;.
    /// </summary>
    [EnumMember(Value = "UAAN")]
    [IsoId("_voxdC1r3EeWN79Bl6BUd3g")]
    [Description(@"Commodity of type urea and ammonium nitrite.")]
    UreaAndAmmoniumNitrite = AssetClassSubProductTypeCode.UreaAndAmmoniumNitrite, // same ordinal as derivation source for type conversions
}
