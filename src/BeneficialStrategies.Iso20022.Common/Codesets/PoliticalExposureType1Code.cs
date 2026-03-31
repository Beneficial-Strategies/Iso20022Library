// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the political exposure type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UW--kBRvEeOKWo1NF21OVw")]
[Description(@"Specifies the political exposure type.")]
[DerivedFrom(typeof(PoliticalExposureTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PoliticalExposureType1Code>))]
#endif
public enum PoliticalExposureType1Code
{
    /// <summary>
    /// No political exposure.
    /// Encoded/decoded by serializers as &quot;NPEX&quot;.
    /// </summary>
    [EnumMember(Value = "NPEX")]
    [IsoId("_Zojl4RRvEeOKWo1NF21OVw")]
    [Description(@"No political exposure.")]
    NoPoliticalExposure = PoliticalExposureTypeCode.NoPoliticalExposure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Political exposure type is foreign.
    /// Encoded/decoded by serializers as &quot;PEXF&quot;.
    /// </summary>
    [EnumMember(Value = "PEXF")]
    [IsoId("_ZyXpMRRvEeOKWo1NF21OVw")]
    [Description(@"Political exposure type is foreign.")]
    PoliticalExposureForeign = PoliticalExposureTypeCode.PoliticalExposureForeign, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Political exposure type is domestic.
    /// Encoded/decoded by serializers as &quot;PEXD&quot;.
    /// </summary>
    [EnumMember(Value = "PEXD")]
    [IsoId("_Z8CikRRvEeOKWo1NF21OVw")]
    [Description(@"Political exposure type is domestic.")]
    PoliticalExposureDomestic = PoliticalExposureTypeCode.PoliticalExposureDomestic, // same ordinal as derivation source for type conversions
}
