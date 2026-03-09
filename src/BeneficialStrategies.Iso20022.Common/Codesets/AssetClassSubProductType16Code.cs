// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Precious Metal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FvfOMAnzEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Precious Metal.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType16Code
{
    /// <summary>
    /// Commodity of type precious metals.
    /// Encoded/decoded by serializers as &quot;PRME&quot;.
    /// </summary>
    [EnumMember(Value = "PRME")]
    [IsoId("_oLnOsQn0EeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type precious metals.")]
    Precious = AssetClassSubProductTypeCode.Precious, // same ordinal as derivation source for type conversions
    
}
