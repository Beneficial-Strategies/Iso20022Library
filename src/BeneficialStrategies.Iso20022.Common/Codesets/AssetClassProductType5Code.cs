// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Fertilizer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WMBukAnyEeWnS-yHF1QhNQ")]
[Description(@"Commodity derivative base product code list for Fertilizer.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType5Code
{
    /// <summary>
    /// Commodity of type fertilizer.
    /// Encoded/decoded by serializers as &quot;FRTL&quot;.
    /// </summary>
    [EnumMember(Value = "FRTL")]
    [IsoId("_ie4nUQnyEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type fertilizer.")]
    Fertilizer = AssetClassProductTypeCode.Fertilizer, // same ordinal as derivation source for type conversions
}
