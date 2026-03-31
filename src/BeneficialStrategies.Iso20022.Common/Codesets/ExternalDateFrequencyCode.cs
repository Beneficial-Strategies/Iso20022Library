// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external date frequency code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-M07Am7iEeKo25nLKvGr8w_-1381419165")]
[Description(
    @"Specifies the external date frequency code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalDateFrequency1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalDateFrequencyCode>))]
#endif
public enum ExternalDateFrequencyCode
{
    /// <summary>
    /// Frequency is monthly.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_uO_hQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is monthly.")]
    Monthly,

    /// <summary>
    /// Frequency is quarterly (every three months).
    /// Encoded/decoded by serializers as &quot;QUTR&quot;.
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_uO_hRvRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is quarterly (every three months).")]
    Quarterly,

    /// <summary>
    /// Frequency is semi-annual (every six months).
    /// Encoded/decoded by serializers as &quot;SEMI&quot;.
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_uO_hSfRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is semi-annual (every six months).")]
    SemiAnnual,

    /// <summary>
    /// Frequency is two-monthly (every two months).
    /// Encoded/decoded by serializers as &quot;TOMN&quot;.
    /// </summary>
    [EnumMember(Value = "TOMN")]
    [IsoId("_uO_hTPRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is two-monthly (every two months).")]
    TwoMonthly,

    /// <summary>
    /// Frequency is annual.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_uPIrMPRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is annual.")]
    Annual,
}
