// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of resolution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7A9vUFuFEeSmO6RkXg92Lg")]
[Description(@"Specifies the type of resolution.")]
[DerivedFrom(typeof(ResolutionTypeCode))]
public enum ResolutionType2Code
{
    /// <summary>
    /// Meeting resolution is extraordinary and may be subject to specific voting requirements.
    /// Encoded/decoded by serializers as &quot;EXTR&quot;.
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("_-9l88VuFEeSmO6RkXg92Lg")]
    [Description(@"Meeting resolution is extraordinary and may be subject to specific voting requirements.")]
    Extraordinary = ResolutionTypeCode.Extraordinary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Resolution that is neither ordinary nor extraordinary (eg. decision on an investment strategy).
    /// Encoded/decoded by serializers as &quot;SPCL&quot;.
    /// </summary>
    [EnumMember(Value = "SPCL")]
    [IsoId("__EcL0VuFEeSmO6RkXg92Lg")]
    [Description(@"Resolution that is neither ordinary nor extraordinary (eg. decision on an investment strategy).")]
    Special = ResolutionTypeCode.Special, // same ordinal as derivation source for type conversions
    
}
