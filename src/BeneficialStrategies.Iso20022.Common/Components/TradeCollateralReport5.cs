// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of collateral agreement between counterparties.
/// </summary>
[IsoId("_J0zaIVfVEeqqKf65rDYWYw")]
[DisplayName("Trade Collateral Report")]
public partial record TradeCollateralReport5
{
    #nullable enable
    
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// Usage:
    /// NoCode is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    [IsoId("_C-gBQHixEeqKjIYaFgh_2g")]
    [DisplayName("Portfolio Code")]
    [IsoXmlTag("PrtflCd")]
    public required PortfolioCode1Choice_ PortfolioCode { get; init; } 
    
    /// <summary>
    /// Indicates the type of collateral agreement existing between the counterparties.
    /// </summary>
    [IsoId("_KN858VfVEeqqKf65rDYWYw")]
    [DisplayName("Collateralisation")]
    [IsoXmlTag("Collstn")]
    public CollateralisationType2Code? Collateralisation { get; init; } 
    
    /// <summary>
    /// Specifies the pre-haircut or post-haircut monetary value of the initial margin posted by the reporting counterparty.
    /// Usage:
    /// Where initial margin is posted on a portfolio basis, this field should include the total value of initial margin posted for the portfolio.
    /// If the initial margin posted is denominated in more than one currency, those amounts are converted into a single currency chosen by the reporting counterparty and reported as one total value.|
    /// ||
    /// </summary>
    [IsoId("_KN859VfVEeqqKf65rDYWYw")]
    [DisplayName("Initial Margin Posted")]
    [IsoXmlTag("InitlMrgnPstd")]
    public PrePostHaircut1? InitialMarginPosted { get; init; } 
    
    /// <summary>
    /// Specifies the pre-haircut or post-haircut monetary value of the initial margin collected by the reporting counterparty.
    /// ||Usage: |Where initial margin is collected on a portfolio basis, this field should include the total value of initial margin collected for the portfolio.
    /// If the initial margin collected is denominated in more than one currency, those amounts are converted into a single currency chosen by the reporting counterparty and reported as one total value.
    /// </summary>
    [IsoId("_KN85-VfVEeqqKf65rDYWYw")]
    [DisplayName("Initial Margin Received")]
    [IsoXmlTag("InitlMrgnRcvd")]
    public PrePostHaircut1? InitialMarginReceived { get; init; } 
    
    /// <summary>
    /// Specifies the pre-haircut or post-haircut monetary value of the variation margin posted, including cash settled, by the reporting counterparty. 
    /// Usage: Where variation margin is posted on a portfolio basis, this field should include the overall value of variation margin posted for the portfolio.
    /// If the variation margin posted is denominated in more than one currency, those amounts are converted into a single currency chosen by the reporting counterparty and reported as one total value.
    /// </summary>
    [IsoId("_KN8591fVEeqqKf65rDYWYw")]
    [DisplayName("Variation Margin Posted")]
    [IsoXmlTag("VartnMrgnPstd")]
    public PrePostHaircut1? VariationMarginPosted { get; init; } 
    
    /// <summary>
    /// Specifies the pre-haircut or post-haircut monetary value of the variation margin collected, including cash-settled, by the reporting counterparty.
    /// Usage:
    /// Where variation margin is received on a portfolio basis, this field should include the overall value of variation margin received for the portfolio.
    /// If the variation margin collected is denominated in more than one currency, those amounts are converted into a single currency chosen by the reporting counterparty and reported as one total value.
    /// </summary>
    [IsoId("_KN85-1fVEeqqKf65rDYWYw")]
    [DisplayName("Variation Margin Received")]
    [IsoXmlTag("VartnMrgnRcvd")]
    public PrePostHaircut1? VariationMarginReceived { get; init; } 
    
    /// <summary>
    /// Specifies the monetary value of additional collateral posted by the reporting counterparty in excess of the required collateral.
    /// |
    /// Usage: Where excess collateral is posted on a portfolio basis, this field should include the overall value of excess collateral posted for the portfolio.
    /// </summary>
    [IsoId("_KN85_VfVEeqqKf65rDYWYw")]
    [DisplayName("Excess Collateral Posted")]
    [IsoXmlTag("XcssCollPstd")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? ExcessCollateralPosted { get; init; } 
    
    /// <summary>
    /// Specifies the monetary value of additional collateral received by the reporting counterparty in excess of the required collateral.
    /// Usage: Where excess collateral is received on a portfolio basis, this field should include the overall value of excess collateral collected for the portfolio.
    /// </summary>
    [IsoId("_KN85_1fVEeqqKf65rDYWYw")]
    [DisplayName("Excess Collateral Received")]
    [IsoXmlTag("XcssCollRcvd")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? ExcessCollateralReceived { get; init; } 
    
    /// <summary>
    /// Indicates if a counterparty rating trigger is agreed by the counterparties for the collateral posted by the reporting counterparty.
    /// Usage: If the element is not present, the CounterpartyRatingTrigger is False.
    /// </summary>
    [IsoId("_7wjdEorpEeq91phomTRDDA")]
    [DisplayName("Counterparty Rating Trigger Indicator")]
    [IsoXmlTag("CtrPtyRatgTrggrInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CounterpartyRatingTriggerIndicator { get; init; } 
    
    /// <summary>
    /// Indicates if a counterparty rating trigger includes a threshold that increases collateral requirements when the counterparty falls below the single-A rating or equivalent.
    /// Usage: If the CounterpartyRatingTrigger indicator is false, this element is omitted.
    /// </summary>
    [IsoId("_7wjdE4rpEeq91phomTRDDA")]
    [DisplayName("Counterparty Rating Threshold Indicator")]
    [IsoXmlTag("CtrPtyRatgThrshldInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CounterpartyRatingThresholdIndicator { get; init; } 
    
    
    #nullable disable
    
}
