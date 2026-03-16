// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of resolution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZU-JUtp-Ed-ak6NoX_4Aeg_1068245890")]
[Description(@"Specifies the type of resolution.")]
[DerivedFrom(typeof(ResolutionTypeCode))]
public enum ResolutionType1Code
{
    /// <summary>
    /// Meeting resolution is extraordinary and may be subject to specific voting requirements.
    /// Encoded/decoded by serializers as &quot;EXTR&quot;.
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("_ZU-JU9p-Ed-ak6NoX_4Aeg_1357307111")]
    [Description(
        @"Meeting resolution is extraordinary and may be subject to specific voting requirements."
    )]
    Extraordinary = ResolutionTypeCode.Extraordinary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting resolution is ordinary and is not subject to any specific voting requirements.
    /// Encoded/decoded by serializers as &quot;ORDI&quot;.
    /// </summary>
    [EnumMember(Value = "ORDI")]
    [IsoId("_ZU-JVNp-Ed-ak6NoX_4Aeg_1357307136")]
    [Description(
        @"Meeting resolution is ordinary and is not subject to any specific voting requirements."
    )]
    Ordinary = ResolutionTypeCode.Ordinary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resolution that is neither ordinary nor extraordinary (eg. decision on an investment strategy).
    /// Encoded/decoded by serializers as &quot;SPCL&quot;.
    /// </summary>
    [EnumMember(Value = "SPCL")]
    [IsoId("_ZU-JVdp-Ed-ak6NoX_4Aeg_-689950721")]
    [Description(
        @"Resolution that is neither ordinary nor extraordinary (eg. decision on an investment strategy)."
    )]
    Special = ResolutionTypeCode.Special, // same ordinal as derivation source for type conversions
}
