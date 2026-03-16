// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Newsprint.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ul4O4VryEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Newsprint.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType36Code
{
    /// <summary>
    /// Commodity of type newsprint.
    /// Encoded/decoded by serializers as &quot;NSPT&quot;.
    /// </summary>
    [EnumMember(Value = "NSPT")]
    [IsoId("_uxcls1ryEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type newsprint.")]
    Newsprint = AssetClassSubProductTypeCode.Newsprint, // same ordinal as derivation source for type conversions
}
