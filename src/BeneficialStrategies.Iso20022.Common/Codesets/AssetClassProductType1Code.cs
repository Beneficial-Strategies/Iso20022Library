// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Agricultural.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UJ4QoAnyEeWnS-yHF1QhNQ")]
[Description(@"Commodity derivative base product code list for Agricultural.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType1Code
{
    /// <summary>
    /// Commodity of type agricultural.
    /// Encoded/decoded by serializers as &quot;AGRI&quot;.
    /// </summary>
    [EnumMember(Value = "AGRI")]
    [IsoId("_eBGNYQnyEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type agricultural.")]
    Agricultural = AssetClassProductTypeCode.Agricultural, // same ordinal as derivation source for type conversions
}
