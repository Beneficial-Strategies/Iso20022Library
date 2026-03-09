// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Oil.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__dGDEAnyEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Oil.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType8Code
{
    /// <summary>
    /// Commodity of type oil.
    /// Encoded/decoded by serializers as &quot;OILP&quot;.
    /// </summary>
    [EnumMember(Value = "OILP")]
    [IsoId("_913xIQnzEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type oil.")]
    Oil = AssetClassSubProductTypeCode.Oil, // same ordinal as derivation source for type conversions
    
}
