// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Rate127.
/// </summary>
[IsoId("_3xF-PYV4Ee-oeNhl-Tk6YQ")]
[DisplayName("Corporate Action Rate127")]
public partial record CorporateActionRate127
{
    #nullable enable

    /// <summary>
    /// Oversubscription Rate.
    /// </summary>
    [DisplayName("Oversubscription Rate")]
    [IsoXmlTag("OvrsbcptRate")]
    public RateAndAmountFormat59Choice_? OversubscriptionRate { get; init; } 

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
    public ValueList<RateAndAmountFormat55Choice_> RequestedSecondLevelTaxRate { get; init; } = [];

    /// <summary>
    /// Requested Withholding Tax Rate.
    /// </summary>
    [DisplayName("Requested Withholding Tax Rate")]
    [IsoXmlTag("ReqdWhldgTaxRate")]
    public ValueList<RateAndAmountFormat55Choice_> RequestedWithholdingTaxRate { get; init; } = [];

    
    #nullable disable
    
}
