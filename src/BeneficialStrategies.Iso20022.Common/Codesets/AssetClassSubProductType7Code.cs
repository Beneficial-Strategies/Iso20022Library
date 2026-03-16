// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Natural Gas.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-yNTAAnyEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Natural Gas.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType7Code
{
    /// <summary>
    /// Commodity of type natural gas.
    /// Encoded/decoded by serializers as &quot;NGAS&quot;.
    /// </summary>
    [EnumMember(Value = "NGAS")]
    [IsoId("_8eix0QnzEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type natural gas.")]
    NaturalGas = AssetClassSubProductTypeCode.NaturalGas, // same ordinal as derivation source for type conversions
}
