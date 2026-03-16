// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the relative quality of the indication of interest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZXNlBtp-Ed-ak6NoX_4Aeg_-1532318790")]
[Description(@"Indicates the relative quality of the indication of interest.")]
[DerivedFrom(typeof(QualityIndicationCode))]
public enum QualityIndication1Code
{
    /// <summary>
    /// Low quality.
    /// Encoded/decoded by serializers as &quot;LOWE&quot;.
    /// </summary>
    [EnumMember(Value = "LOWE")]
    [IsoId("_ZXNlB9p-Ed-ak6NoX_4Aeg_-1478752289")]
    [Description(@"Low quality.")]
    Low = QualityIndicationCode.Low, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Medium quality.
    /// Encoded/decoded by serializers as &quot;MEDI&quot;.
    /// </summary>
    [EnumMember(Value = "MEDI")]
    [IsoId("_ZXNlCNp-Ed-ak6NoX_4Aeg_-1478752246")]
    [Description(@"Medium quality.")]
    Medium = QualityIndicationCode.Medium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// High quality.
    /// Encoded/decoded by serializers as &quot;HIGH&quot;.
    /// </summary>
    [EnumMember(Value = "HIGH")]
    [IsoId("_ZXNlCdp-Ed-ak6NoX_4Aeg_-1478752210")]
    [Description(@"High quality.")]
    High = QualityIndicationCode.High, // same ordinal as derivation source for type conversions
}
