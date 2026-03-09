// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Grain.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_01VOsGX-EeWIGZvepIG8Mg")]
[Description(@"Further sub product code list for commodity derivative Grain.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType15Code
{
    /// <summary>
    /// Commodity attribute of type milled wheat.
    /// Encoded/decoded by serializers as &quot;MWHT&quot;.
    /// </summary>
    [EnumMember(Value = "MWHT")]
    [IsoId("_2a6FYWX-EeWIGZvepIG8Mg")]
    [Description(@"Commodity attribute of type milled wheat.")]
    MillingWheat = AssetClassDetailedSubProductTypeCode.MillingWheat, // same ordinal as derivation source for type conversions
    
}
