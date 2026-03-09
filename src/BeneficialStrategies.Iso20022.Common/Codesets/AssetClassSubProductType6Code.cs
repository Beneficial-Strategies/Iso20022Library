// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Electricity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-FIKkAnyEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Electricity.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType6Code
{
    /// <summary>
    /// Commodity of type electricity.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_61phYQnzEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type electricity.")]
    Electricity = AssetClassSubProductTypeCode.Electricity, // same ordinal as derivation source for type conversions
    
}
