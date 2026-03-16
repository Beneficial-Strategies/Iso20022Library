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
[IsoId("_BNvksDcZEeidBoT_PugKiA")]
[DisplayName("Investor Requirements")]
public record InvestorRequirements1
{
    /// <summary>
    /// Specifies whether the product is compatible with a client who is looking for the preservation of capital. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05010. In EMT v2, this is known as Return Profile Client Looking for Preservation.
    /// </summary>
    [IsoId("_L8owUDcZEeidBoT_PugKiA")]
    [DisplayName("Return Profile Preservation")]
    [IsoXmlTag("RtrPrflPrsrvtn")]
    public TargetMarket1Code? ReturnProfilePreservation { get; init; }

    /// <summary>
    /// Specifies whether the product is compatible with a client looking for capitalisation growth.
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05020. In EMT v2, this is known as Return Profile Client Looking for Capitalized Growth.
    /// </summary>
    [IsoId("_3N8BwDcaEeidBoT_PugKiA")]
    [DisplayName("Return Profile Growth")]
    [IsoXmlTag("RtrPrflGrwth")]
    public TargetMarket1Code? ReturnProfileGrowth { get; init; }

    /// <summary>
    /// Specifies whether the product is compatible with a client who is looking for income. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05030. In EMT v2, this is known as Return Profile Client Looking for Income.
    /// </summary>
    [IsoId("_8iVTkDcaEeidBoT_PugKiA")]
    [DisplayName("Return Profile Income")]
    [IsoXmlTag("RtrPrflIncm")]
    public TargetMarket1Code? ReturnProfileIncome { get; init; }

    /// <summary>
    /// Level of compatibility of the investor risk profile with the hedging profile of a structured security product.
    /// In EMT v2, this element is not supported for funds. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05040. In EMT v2, this element is not supported for funds.
    /// </summary>
    [IsoId("_5m4dEIvzEeicrr-UkGlMQA")]
    [DisplayName("Return Profile Hedging")]
    [IsoXmlTag("RtrPrflHdgg")]
    public TargetMarket1Code? ReturnProfileHedging { get; init; }

    /// <summary>
    /// Level of compatibility of the investor risk profile with the option or leveraged return profile of a structured security product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05050. In EMT v2, this element is not supported for funds.
    /// </summary>
    [IsoId("_MhcpoIv0Eeicrr-UkGlMQA")]
    [DisplayName("Option Or Leveraged Return Profile")]
    [IsoXmlTag("OptnOrLvrgdRtrPrfl")]
    public TargetMarket1Code? OptionOrLeveragedReturnProfile { get; init; }

    /// <summary>
    /// Level of compatibility of the investor risk profile with ‘another return’ profile of the product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05060.
    /// </summary>
    [IsoId("_MpHw8DcbEeidBoT_PugKiA")]
    [DisplayName("Return Profile Other")]
    [IsoXmlTag("RtrPrflOthr")]
    public TargetMarket2Code? ReturnProfileOther { get; init; }

    /// <summary>
    /// Level of compatibility of the investor risk profile with the Return Profile Pension Scheme Germany profile of the product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05070.
    /// </summary>
    [IsoId("_R1DqUDcbEeidBoT_PugKiA")]
    [DisplayName("Return Profile Pension Scheme Germany")]
    [IsoXmlTag("RtrPrflPnsnSchmeDE")]
    public TargetMarket1Code? ReturnProfilePensionSchemeGermany { get; init; }

    /// <summary>
    /// Minimum recommended holding period (RHP).
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05080. In EMT v1, this is known as Time Horizon.
    /// </summary>
    [IsoId("_WYjqsDcbEeidBoT_PugKiA")]
    [DisplayName("Minimum Holding Period")]
    [IsoXmlTag("MinHldgPrd")]
    public TimeHorizon1Choice_? MinimumHoldingPeriod { get; init; }

    /// <summary>
    /// Specifies whether the product may be terminated early. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05100.
    /// </summary>
    [IsoId("_Zm1AAIs6EeiLhuH9WH7MLg")]
    [DisplayName("May Be Terminated Early")]
    [IsoXmlTag("MayBeTermntdEarly")]
    public TargetMarket1Code? MayBeTerminatedEarly { get; init; }

    /// <summary>
    /// Specifies specific indicative investment needs. Should be discussed and agreed between the asset manager and bank. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 05110.
    /// </summary>
    [IsoId("_CQQ00DcdEeidBoT_PugKiA")]
    [DisplayName("Specific Investment Need")]
    [IsoXmlTag("SpcfcInvstmtNeed")]
    public InvestmentNeed1Choice_? SpecificInvestmentNeed { get; init; }

    /// <summary>
    /// Other investment need.
    /// </summary>
    [IsoId("_EcKPMDceEeidBoT_PugKiA")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public OtherInvestmentNeed1? Other { get; init; }
}
