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
[IsoId("_1RIYYjL3EeKU9IrkkToqcw_1649073602")]
[DisplayName("Financial Instrument Attributes SD")]
public record FinancialInstrumentAttributesSD2
{
    /// <summary>
    /// Security identification of the security that is being distributed as a result of a corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    [IsoId("_1RIYYzL3EeKU9IrkkToqcw_805259150")]
    [DisplayName("Declared Disbursed Security Identification")]
    [IsoXmlTag("DclrdDsbrsdSctyId")]
    public SecurityIdentification15? DeclaredDisbursedSecurityIdentification { get; init; }

    /// <summary>
    /// Declared disbursed security description.
    /// </summary>
    [IsoId("_1RIYZDL3EeKU9IrkkToqcw_1268382321")]
    [DisplayName("Declared Disbursed Security Description")]
    [IsoXmlTag("DclrdDsbrsdSctyDesc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? DeclaredDisbursedSecurityDescription { get; init; }
}
