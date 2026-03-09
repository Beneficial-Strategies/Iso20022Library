// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Metal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XbB4UAnyEeWnS-yHF1QhNQ")]
[Description(@"Commodity derivative base product code list for Metal.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType7Code
{
    /// <summary>
    /// Commodity of type metal.
    /// Encoded/decoded by serializers as &quot;METL&quot;.
    /// </summary>
    [EnumMember(Value = "METL")]
    [IsoId("_n9PtcQnyEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type metal.")]
    Metal = AssetClassProductTypeCode.Metal, // same ordinal as derivation source for type conversions
    
}
