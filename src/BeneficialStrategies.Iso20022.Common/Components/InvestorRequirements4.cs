// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investor Requirements4.
/// </summary>
[IsoId("_rK8SgcQXEe2pvZQ_33Qz1Q")]
[DisplayName("Investor Requirements4")]
public partial record InvestorRequirements4
{
    #nullable enable

    /// <summary>
    /// Minimum Holding Period.
    /// </summary>
    [DisplayName("Minimum Holding Period")]
    [IsoXmlTag("MinHldgPrd")]
    public TimeHorizon2Choice_? MinimumHoldingPeriod { get; init; } 

    /// <summary>
    /// Option Or Leveraged Return Profile.
    /// </summary>
    [DisplayName("Option Or Leveraged Return Profile")]
    [IsoXmlTag("OptnOrLvrgdRtrPrfl")]
    public TargetMarket1Code? OptionOrLeveragedReturnProfile { get; init; } 

    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<OtherInvestmentNeed1> Other { get; init; } = [];

    /// <summary>
    /// Other Specific Investment Need.
    /// </summary>
    [DisplayName("Other Specific Investment Need")]
    [IsoXmlTag("OthrSpcfcInvstmtNeed")]
    public InvestmentNeed2Choice_? OtherSpecificInvestmentNeed { get; init; } 

    /// <summary>
    /// Return Profile Growth.
    /// </summary>
    [DisplayName("Return Profile Growth")]
    [IsoXmlTag("RtrPrflGrwth")]
    public TargetMarket1Code? ReturnProfileGrowth { get; init; } 

    /// <summary>
    /// Return Profile Hedging.
    /// </summary>
    [DisplayName("Return Profile Hedging")]
    [IsoXmlTag("RtrPrflHdgg")]
    public TargetMarket1Code? ReturnProfileHedging { get; init; } 

    /// <summary>
    /// Return Profile Income.
    /// </summary>
    [DisplayName("Return Profile Income")]
    [IsoXmlTag("RtrPrflIncm")]
    public TargetMarket1Code? ReturnProfileIncome { get; init; } 

    /// <summary>
    /// Return Profile Pension Scheme Germany.
    /// </summary>
    [DisplayName("Return Profile Pension Scheme Germany")]
    [IsoXmlTag("RtrPrflPnsnSchmeDE")]
    public TargetMarket1Code? ReturnProfilePensionSchemeGermany { get; init; } 

    /// <summary>
    /// Return Profile Preservation.
    /// </summary>
    [DisplayName("Return Profile Preservation")]
    [IsoXmlTag("RtrPrflPrsrvtn")]
    public TargetMarket1Code? ReturnProfilePreservation { get; init; } 

    /// <summary>
    /// Sustainability Preferences.
    /// </summary>
    [DisplayName("Sustainability Preferences")]
    [IsoXmlTag("SstnbltyPrefs")]
    public SustainabilityPreferences2Code? SustainabilityPreferences { get; init; } 

    
    #nullable disable
    
}
