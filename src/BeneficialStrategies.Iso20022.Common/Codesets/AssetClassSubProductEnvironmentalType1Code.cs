// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code list for environmental related derivative contracts.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YuxOQM5AEeSc85GUbgBycw")]
[Description(@"Code list for environmental related derivative contracts.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductEnvironmentalType1Code
{
    /// <summary>
    /// Commodity of type emission.
    /// Encoded/decoded by serializers as &quot;EMIS&quot;.
    /// </summary>
    [EnumMember(Value = "EMIS")]
    [IsoId("_mjMYsc5GEeSc85GUbgBycw")]
    [Description(@"Commodity of type emission.")]
    Emission = AssetClassSubProductTypeCode.Emission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity of type weather.
    /// Encoded/decoded by serializers as &quot;WTHR&quot;.
    /// </summary>
    [EnumMember(Value = "WTHR")]
    [IsoId("_mzjv8c5GEeSc85GUbgBycw")]
    [Description(@"Commodity of type weather.")]
    Weather = AssetClassSubProductTypeCode.Weather, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_jVjxIUDbEeWOL-OsSq2h6w")]
    [Description(@"Commodity of other type.")]
    Other = AssetClassSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
}
