// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investor’s investment requirements.
/// </summary>
[IsoId("_XtujXc0SEeuAE-cYsQdwHQ")]
[DisplayName("Investor Requirements")]
public record InvestorRequirements3
{
    /// <summary>
    /// Specifies whether the product is compatible with a client who is looking for the preservation of capital. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05010.
    /// </summary>
    [IsoId("_YDn60c0SEeuAE-cYsQdwHQ")]
    [DisplayName("Return Profile Preservation")]
    [IsoXmlTag("RtrPrflPrsrvtn")]
    public TargetMarket1Code? ReturnProfilePreservation { get; init; }

    /// <summary>
    /// Specifies whether the product is compatible with a client looking for capitalisation growth. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05020.
    /// </summary>
    [IsoId("_YDn6080SEeuAE-cYsQdwHQ")]
    [DisplayName("Return Profile Growth")]
    [IsoXmlTag("RtrPrflGrwth")]
    public TargetMarket1Code? ReturnProfileGrowth { get; init; }

    /// <summary>
    /// Specifies whether the product is compatible with a client who is looking for income. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05030.
    /// </summary>
    [IsoId("_YDn61c0SEeuAE-cYsQdwHQ")]
    [DisplayName("Return Profile Income")]
    [IsoXmlTag("RtrPrflIncm")]
    public TargetMarket1Code? ReturnProfileIncome { get; init; }

    /// <summary>
    /// Level of compatibility of the investor risk profile with the hedging profile of a structured security product.
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05040.
    /// </summary>
    [IsoId("_YDn6180SEeuAE-cYsQdwHQ")]
    [DisplayName("Return Profile Hedging")]
    [IsoXmlTag("RtrPrflHdgg")]
    public TargetMarket1Code? ReturnProfileHedging { get; init; }

    /// <summary>
    /// Level of compatibility of the investor risk profile with the option or leveraged return profile of a structured security product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05050.
    /// </summary>
    [IsoId("_YDn62c0SEeuAE-cYsQdwHQ")]
    [DisplayName("Option Or Leveraged Return Profile")]
    [IsoXmlTag("OptnOrLvrgdRtrPrfl")]
    public TargetMarket1Code? OptionOrLeveragedReturnProfile { get; init; }

    /// <summary>
    /// Level of compatibility of the investor risk profile with the Return Profile Pension Scheme Germany profile of the product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05070.
    /// </summary>
    [IsoId("_YDn6280SEeuAE-cYsQdwHQ")]
    [DisplayName("Return Profile Pension Scheme Germany")]
    [IsoXmlTag("RtrPrflPnsnSchmeDE")]
    public TargetMarket1Code? ReturnProfilePensionSchemeGermany { get; init; }

    /// <summary>
    /// Minimum recommended holding period (RHP).
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05080.
    /// </summary>
    [IsoId("_YDn63c0SEeuAE-cYsQdwHQ")]
    [DisplayName("Minimum Holding Period")]
    [IsoXmlTag("MinHldgPrd")]
    public TimeHorizon2Choice_? MinimumHoldingPeriod { get; init; }

    /// <summary>
    /// Specifies whether the product is compatible with investors that have Environmental, Social and Governance (ESG) preferences. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05105.
    /// </summary>
    [IsoId("_YDn6380SEeuAE-cYsQdwHQ")]
    [DisplayName("ESG Preferences")]
    [IsoXmlTag("ESGPrefs")]
    public TargetMarket2Code? ESGPreferences { get; init; }

    /// <summary>
    /// Specifies whether the product is compatible with investors that have sustainability preferences. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT V3.1) reference 05105.
    /// </summary>
    [IsoId("_B50VoM0TEeuAE-cYsQdwHQ")]
    [DisplayName("Sustainability Preferences")]
    [IsoXmlTag("SstnbltyPrefs")]
    public SustainabilityPreferences1Code? SustainabilityPreferences { get; init; }

    /// <summary>
    /// Specifies other specific investment needs. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05115.
    /// </summary>
    [IsoId("_YDn64c0SEeuAE-cYsQdwHQ")]
    [DisplayName("Other Specific Investment Need")]
    [IsoXmlTag("OthrSpcfcInvstmtNeed")]
    public InvestmentNeed2Choice_? OtherSpecificInvestmentNeed { get; init; }

    /// <summary>
    /// Other investment need.
    /// </summary>
    [IsoId("_YDn6480SEeuAE-cYsQdwHQ")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public OtherInvestmentNeed1? Other { get; init; }
}
