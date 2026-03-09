// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Paper.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YDowcAnyEeWnS-yHF1QhNQ")]
[Description(@"Commodity derivative base product code list for Paper.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType8Code
{
    /// <summary>
    /// Commodity of type paper.
    /// Encoded/decoded by serializers as &quot;PAPR&quot;.
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_qdn_gQnyEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type paper.")]
    Paper = AssetClassProductTypeCode.Paper, // same ordinal as derivation source for type conversions
    
}
