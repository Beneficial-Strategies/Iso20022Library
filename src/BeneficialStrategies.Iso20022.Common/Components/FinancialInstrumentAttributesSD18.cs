// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding security that will be distributed as part of entitlement.
/// </summary>
[IsoId("_sDR-Ab-3Eeeb2ZBoAlSG1Q")]
[DisplayName("Financial Instrument Attributes SD")]
public record FinancialInstrumentAttributesSD18
{
    /// <summary>
    /// Security identification of the security that is being distributed as a result of a corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    [IsoId("_sTNQYb-3Eeeb2ZBoAlSG1Q")]
    [DisplayName("Declared Disbursed Security Identification")]
    [IsoXmlTag("DclrdDsbrsdSctyId")]
    public SecurityIdentification20? DeclaredDisbursedSecurityIdentification { get; init; }

    /// <summary>
    /// Declared disbursed security description.
    /// </summary>
    [IsoId("_sTNQab-3Eeeb2ZBoAlSG1Q")]
    [DisplayName("Declared Disbursed Security Description")]
    [IsoXmlTag("DclrdDsbrsdSctyDesc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? DeclaredDisbursedSecurityDescription { get; init; }
}
