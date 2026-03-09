// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the political exposure type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7TMJ8RRuEeOKWo1NF21OVw")]
[Description(@"Specifies the political exposure type.")]
[Derivations(typeof(PoliticalExposureType1Code),typeof(PoliticalExposureType2Code))]
public enum PoliticalExposureTypeCode
{
    /// <summary>
    /// Political exposure type is domestic.
    /// Encoded/decoded by serializers as &quot;PEXD&quot;.
    /// </summary>
    [EnumMember(Value = "PEXD")]
    [IsoId("_CDrmUBRvEeOKWo1NF21OVw")]
    [Description(@"Political exposure type is domestic.")]
    PoliticalExposureDomestic,
    
    /// <summary>
    /// Political exposure type is foreign.
    /// Encoded/decoded by serializers as &quot;PEXF&quot;.
    /// </summary>
    [EnumMember(Value = "PEXF")]
    [IsoId("_CHiyoBRvEeOKWo1NF21OVw")]
    [Description(@"Political exposure type is foreign.")]
    PoliticalExposureForeign,
    
    /// <summary>
    /// No political exposure.
    /// Encoded/decoded by serializers as &quot;NPEX&quot;.
    /// </summary>
    [EnumMember(Value = "NPEX")]
    [IsoId("_CjXL8BRvEeOKWo1NF21OVw")]
    [Description(@"No political exposure.")]
    NoPoliticalExposure,
    
    /// <summary>
    /// Political exposure.
    /// Encoded/decoded by serializers as &quot;YPEX&quot;.
    /// </summary>
    [EnumMember(Value = "YPEX")]
    [IsoId("_9vrX8JUfEemC09f0MxYkRg")]
    [Description(@"Political exposure.")]
    PoliticalExposure,
    
}
