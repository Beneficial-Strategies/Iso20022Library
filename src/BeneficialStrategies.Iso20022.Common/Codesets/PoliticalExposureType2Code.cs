// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the political exposure type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rj2EMJUgEemC09f0MxYkRg")]
[Description(@"Specifies the political exposure type.")]
[DerivedFrom(typeof(PoliticalExposureTypeCode))]
public enum PoliticalExposureType2Code
{
    /// <summary>
    /// No political exposure.
    /// Encoded/decoded by serializers as &quot;NPEX&quot;.
    /// </summary>
    [EnumMember(Value = "NPEX")]
    [IsoId("_tm6vMZUgEemC09f0MxYkRg")]
    [Description(@"No political exposure.")]
    NoPoliticalExposure = PoliticalExposureTypeCode.NoPoliticalExposure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Political exposure.
    /// Encoded/decoded by serializers as &quot;YPEX&quot;.
    /// </summary>
    [EnumMember(Value = "YPEX")]
    [IsoId("_tuzf4ZUgEemC09f0MxYkRg")]
    [Description(@"Political exposure.")]
    PoliticalExposure = PoliticalExposureTypeCode.PoliticalExposure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Political exposure type is domestic.
    /// Encoded/decoded by serializers as &quot;PEXD&quot;.
    /// </summary>
    [EnumMember(Value = "PEXD")]
    [IsoId("_tzkEEZUgEemC09f0MxYkRg")]
    [Description(@"Political exposure type is domestic.")]
    PoliticalExposureDomestic = PoliticalExposureTypeCode.PoliticalExposureDomestic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Political exposure type is foreign.
    /// Encoded/decoded by serializers as &quot;PEXF&quot;.
    /// </summary>
    [EnumMember(Value = "PEXF")]
    [IsoId("_t5g7EZUgEemC09f0MxYkRg")]
    [Description(@"Political exposure type is foreign.")]
    PoliticalExposureForeign = PoliticalExposureTypeCode.PoliticalExposureForeign, // same ordinal as derivation source for type conversions
}
