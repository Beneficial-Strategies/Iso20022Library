// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of resolution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZU-JVtp-Ed-ak6NoX_4Aeg_861792439")]
[Description(@"Specifies the type of resolution.")]
[Derivations(typeof(ResolutionType1Code),typeof(ResolutionType2Code))]
public enum ResolutionTypeCode
{
    /// <summary>
    /// Meeting resolution is ordinary and is not subject to any specific voting requirements.
    /// Encoded/decoded by serializers as &quot;ORDI&quot;.
    /// </summary>
    [EnumMember(Value = "ORDI")]
    [IsoId("_ZU-JV9p-Ed-ak6NoX_4Aeg_901505726")]
    [Description(@"Meeting resolution is ordinary and is not subject to any specific voting requirements.")]
    Ordinary,
    
    /// <summary>
    /// Meeting resolution is extraordinary and may be subject to specific voting requirements.
    /// Encoded/decoded by serializers as &quot;EXTR&quot;.
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("_ZU-JWNp-Ed-ak6NoX_4Aeg_929210488")]
    [Description(@"Meeting resolution is extraordinary and may be subject to specific voting requirements.")]
    Extraordinary,
    
    /// <summary>
    /// Resolution that is neither ordinary nor extraordinary (eg. decision on an investment strategy).
    /// Encoded/decoded by serializers as &quot;SPCL&quot;.
    /// </summary>
    [EnumMember(Value = "SPCL")]
    [IsoId("_ZVH6UNp-Ed-ak6NoX_4Aeg_817498982")]
    [Description(@"Resolution that is neither ordinary nor extraordinary (eg. decision on an investment strategy).")]
    Special,
    
}
