// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Rate130.
/// </summary>
[IsoId("_kV6wj5t3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action Rate130")]
public record CorporateActionRate130
{
    /// <summary>
    /// Oversubscription Rate.
    /// </summary>
    [DisplayName("Oversubscription Rate")]
    [IsoXmlTag("OvrsbcptRate")]
    public RateAndAmountFormat64Choice_? OversubscriptionRate { get; init; }

    /// <summary>
    /// Proposed Rate.
    /// </summary>
    [DisplayName("Proposed Rate")]
    [IsoXmlTag("PropsdRate")]
    public IsoPercentage14Rate? ProposedRate { get; init; }

    /// <summary>
    /// Requested Second Level Tax Rate.
    /// </summary>
    [DisplayName("Requested Second Level Tax Rate")]
    [IsoXmlTag("ReqdScndLvlTaxRate")]
    public ValueList<RateAndAmountFormat65Choice_> RequestedSecondLevelTaxRate { get; init; } = [];

    /// <summary>
    /// Requested Withholding Tax Rate.
    /// </summary>
    [DisplayName("Requested Withholding Tax Rate")]
    [IsoXmlTag("ReqdWhldgTaxRate")]
    public ValueList<RateAndAmountFormat65Choice_> RequestedWithholdingTaxRate { get; init; } = [];
}
