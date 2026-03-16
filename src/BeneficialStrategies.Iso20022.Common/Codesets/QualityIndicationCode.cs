// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the relative quality of the indication of interest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZXWu8Np-Ed-ak6NoX_4Aeg_336258088")]
[Description(@"Indicates the relative quality of the indication of interest.")]
[Derivations(typeof(QualityIndication1Code))]
public enum QualityIndicationCode
{
    /// <summary>
    /// Low quality.
    /// Encoded/decoded by serializers as &quot;LOWE&quot;.
    /// </summary>
    [EnumMember(Value = "LOWE")]
    [IsoId("_ZXWu8dp-Ed-ak6NoX_4Aeg_336258089")]
    [Description(@"Low quality.")]
    Low,

    /// <summary>
    /// Medium quality.
    /// Encoded/decoded by serializers as &quot;MEDI&quot;.
    /// </summary>
    [EnumMember(Value = "MEDI")]
    [IsoId("_ZXWu8tp-Ed-ak6NoX_4Aeg_336258090")]
    [Description(@"Medium quality.")]
    Medium,

    /// <summary>
    /// High quality.
    /// Encoded/decoded by serializers as &quot;HIGH&quot;.
    /// </summary>
    [EnumMember(Value = "HIGH")]
    [IsoId("_ZXWu89p-Ed-ak6NoX_4Aeg_336258099")]
    [Description(@"High quality.")]
    High,
}
