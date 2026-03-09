// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Plastic.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_G2wYQAnzEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Plastic.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType18Code
{
    /// <summary>
    /// Commodity of type plastic.
    /// Encoded/decoded by serializers as &quot;PLST&quot;.
    /// </summary>
    [EnumMember(Value = "PLST")]
    [IsoId("_AZyv0Q2sEeW72qLtWESimw")]
    [Description(@"Commodity of type plastic.")]
    Plastic = AssetClassSubProductTypeCode.Plastic, // same ordinal as derivation source for type conversions
    
}
