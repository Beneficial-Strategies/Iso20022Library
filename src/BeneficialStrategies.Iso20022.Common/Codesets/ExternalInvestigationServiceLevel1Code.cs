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
[IsoId("_3EMJUFEUEe2YkcF60skG_A")]
[Description(
    @"Specifies the investigation service level, as published in an external investigation service level code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalInvestigationServiceLevelCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationServiceLevel1Code>))]
public enum ExternalInvestigationServiceLevel1Code
{
    /// <summary>
    /// Response expected within one business day.
    /// Encoded/decoded by serializers as &quot;R01D&quot;.
    /// </summary>
    [EnumMember(Value = "R01D")]
    [IsoId("___as99YUEe68t8Cw380-tA")]
    [Description(@"Response expected within one business day.")]
    RespondWithinOneBusinessDay = ExternalInvestigationServiceLevelCode.RespondWithinOneBusinessDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response expected within three business days.
    /// Encoded/decoded by serializers as &quot;R03D&quot;.
    /// </summary>
    [EnumMember(Value = "R03D")]
    [IsoId("___as-dYUEe68t8Cw380-tA")]
    [Description(@"Response expected within three business days.")]
    RespondWithinThreeBusinessDays = ExternalInvestigationServiceLevelCode.RespondWithinThreeBusinessDays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response expected within five business days.
    /// Encoded/decoded by serializers as &quot;R05D&quot;.
    /// </summary>
    [EnumMember(Value = "R05D")]
    [IsoId("___as-9YUEe68t8Cw380-tA")]
    [Description(@"Response expected within five business days.")]
    RespondWithinFiveBusinessDays = ExternalInvestigationServiceLevelCode.RespondWithinFiveBusinessDays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response expected within ten business days.
    /// Encoded/decoded by serializers as &quot;R10D&quot;.
    /// </summary>
    [EnumMember(Value = "R10D")]
    [IsoId("___as_dYUEe68t8Cw380-tA")]
    [Description(@"Response expected within ten business days.")]
    RespondWithinTenBusinessDays = ExternalInvestigationServiceLevelCode.RespondWithinTenBusinessDays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response expected within fifteen business days.
    /// Encoded/decoded by serializers as &quot;R15D&quot;.
    /// </summary>
    [EnumMember(Value = "R15D")]
    [IsoId("___as_9YUEe68t8Cw380-tA")]
    [Description(@"Response expected within fifteen business days.")]
    RespondWithinFifteenBusinessDays = ExternalInvestigationServiceLevelCode.RespondWithinFifteenBusinessDays, // same ordinal as derivation source for type conversions
}
