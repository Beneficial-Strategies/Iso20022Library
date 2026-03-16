// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Olive Oil.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_70F8EAnyEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Olive Oil.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType3Code
{
    /// <summary>
    /// Commodity of type olive oil.
    /// Encoded/decoded by serializers as &quot;OOLI&quot;.
    /// </summary>
    [EnumMember(Value = "OOLI")]
    [IsoId("_OOrBAQnzEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type olive oil.")]
    OliveOil = AssetClassSubProductTypeCode.OliveOil, // same ordinal as derivation source for type conversions
}
