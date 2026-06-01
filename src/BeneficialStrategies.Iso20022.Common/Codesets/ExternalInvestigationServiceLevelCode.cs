// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation service level, as published in an external investigation service level code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aWp4EE-6Ee2Vhrd5MAjFrA")]
[Description(
    @"Specifies the investigation service level, as published in an external investigation service level code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalInvestigationServiceLevel1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationServiceLevelCode>))]
public enum ExternalInvestigationServiceLevelCode
{
    /// <summary>
    /// Response expected within one business day.
    /// Encoded/decoded by serializers as &quot;R01D&quot;.
    /// </summary>
    [EnumMember(Value = "R01D")]
    [IsoId("__-02FtYUEe68t8Cw380-tA")]
    [Description(@"Response expected within one business day.")]
    RespondWithinOneBusinessDay,

    /// <summary>
    /// Response expected within three business days.
    /// Encoded/decoded by serializers as &quot;R03D&quot;.
    /// </summary>
    [EnumMember(Value = "R03D")]
    [IsoId("__-02F9YUEe68t8Cw380-tA")]
    [Description(@"Response expected within three business days.")]
    RespondWithinThreeBusinessDays,

    /// <summary>
    /// Response expected within five business days.
    /// Encoded/decoded by serializers as &quot;R05D&quot;.
    /// </summary>
    [EnumMember(Value = "R05D")]
    [IsoId("__-02GNYUEe68t8Cw380-tA")]
    [Description(@"Response expected within five business days.")]
    RespondWithinFiveBusinessDays,

    /// <summary>
    /// Response expected within ten business days.
    /// Encoded/decoded by serializers as &quot;R10D&quot;.
    /// </summary>
    [EnumMember(Value = "R10D")]
    [IsoId("__-02GdYUEe68t8Cw380-tA")]
    [Description(@"Response expected within ten business days.")]
    RespondWithinTenBusinessDays,

    /// <summary>
    /// Response expected within fifteen business days.
    /// Encoded/decoded by serializers as &quot;R15D&quot;.
    /// </summary>
    [EnumMember(Value = "R15D")]
    [IsoId("__-02GtYUEe68t8Cw380-tA")]
    [Description(@"Response expected within fifteen business days.")]
    RespondWithinFifteenBusinessDays,
}
