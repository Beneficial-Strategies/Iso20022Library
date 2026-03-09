// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Industrial Product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_W0WS0AnyEeWnS-yHF1QhNQ")]
[Description(@"Commodity derivative base product code list for Industrial Product.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType6Code
{
    /// <summary>
    /// Commodity of type industrial product.
    /// Encoded/decoded by serializers as &quot;INDP&quot;.
    /// </summary>
    [EnumMember(Value = "INDP")]
    [IsoId("_lpqhQQnyEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type industrial product.")]
    IndustrialProduct = AssetClassProductTypeCode.IndustrialProduct, // same ordinal as derivation source for type conversions
    
}
