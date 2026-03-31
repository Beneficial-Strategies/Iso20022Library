// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Dates determining the entitlement.
/// </summary>
[IsoId("_TmHJHdp-Ed-ak6NoX_4Aeg_742278644")]
[DisplayName("Eligibility Dates")]
public record EligibilityDates1
{
    /// <summary>
    /// Date at which the positions are struck to note which parties will receive the entitlement, e.g. record date, book close date.
    /// </summary>
    [IsoId("_TmHJHtp-Ed-ak6NoX_4Aeg_-1095795436")]
    [DisplayName("Entitlement Fixing Date")]
    [IsoXmlTag("EntitlmntFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EntitlementFixingDate { get; init; }
}
