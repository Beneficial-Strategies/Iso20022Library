// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type as Other.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LNGI4bvjEeiLRYqS-r-R-A")]
[Description(@"Defines the sub-product of type as Other.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType49Code
{
    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_QA-HkbvjEeiLRYqS-r-R-A")]
    [Description(@"Commodity of other type.")]
    Other = AssetClassSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
}
