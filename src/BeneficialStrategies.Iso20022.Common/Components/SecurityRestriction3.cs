// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Restrictions applicable to the security.
/// </summary>
[IsoId("_cIeP8Wf9Eembv_9KtOEw8g")]
[DisplayName("Security Restriction")]
public record SecurityRestriction3
{
    /// <summary>
    /// Period during which the restriction applies.
    /// </summary>
    [IsoId("_cVBeMWf9Eembv_9KtOEw8g")]
    [DisplayName("Effective Period")]
    [IsoXmlTag("FctvPrd")]
    public DateTimePeriod2? EffectivePeriod { get; init; }

    /// <summary>
    /// Type of the restriction, for example, selling restriction, buying restriction, placing restriction.
    /// </summary>
    [IsoId("_cVBeM2f9Eembv_9KtOEw8g")]
    [DisplayName("Restriction Type")]
    [IsoXmlTag("RstrctnTp")]
    public SecurityRestrictionType2Choice_? RestrictionType { get; init; }

    /// <summary>
    /// Specifies the regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_cVBeNWf9Eembv_9KtOEw8g")]
    [DisplayName("Legal Restriction Type")]
    [IsoXmlTag("LglRstrctnTp")]
    public LegalRestrictions5Choice_? LegalRestrictionType { get; init; }

    /// <summary>
    /// Specifies whether the restriction to be applied is relevant for citizen, resident, country.
    /// </summary>
    [IsoId("_cVBeN2f9Eembv_9KtOEw8g")]
    [DisplayName("Investor Restriction Type")]
    [IsoXmlTag("InvstrRstrctnTp")]
    public InvestorRestrictionType3Choice_? InvestorRestrictionType { get; init; }

    /// <summary>
    /// Type of investor that is allowed to hold the security.
    /// </summary>
    [IsoId("_cVBeOWf9Eembv_9KtOEw8g")]
    [DisplayName("Investor Type")]
    [IsoXmlTag("InvstrTp")]
    public InvestorType3Choice_? InvestorType { get; init; }
}
