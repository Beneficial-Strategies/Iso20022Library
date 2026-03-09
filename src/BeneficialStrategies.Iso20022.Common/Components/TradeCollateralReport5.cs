// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of collateral agreement between counterparties.
/// </summary>
[IsoId("_J0zaIVfVEeqqKf65rDYWYw")]
[DisplayName("Trade Collateral Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeCollateralReport5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeCollateralReport5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeCollateralReport5( PortfolioCode1Choice_ reqPortfolioCode )
    {
        PortfolioCode = reqPortfolioCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// Usage:
    /// NoCode is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    [IsoId("_C-gBQHixEeqKjIYaFgh_2g")]
    [DisplayName("Portfolio Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtflCd")]
    #endif
    [IsoXmlTag("PrtflCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PortfolioCode1Choice_ PortfolioCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PortfolioCode1Choice_ PortfolioCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PortfolioCode1Choice_ PortfolioCode { get; init; } 
    #else
    public PortfolioCode1Choice_ PortfolioCode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of collateral agreement existing between the counterparties.
    /// </summary>
    [IsoId("_KN858VfVEeqqKf65rDYWYw")]
    [DisplayName("Collateralisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Collstn")]
    #endif
    [IsoXmlTag("Collstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralisationType2Code? Collateralisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralisationType2Code? Collateralisation { get; init; } 
    #else
    public CollateralisationType2Code? Collateralisation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the pre-haircut or post-haircut monetary value of the initial margin posted by the reporting counterparty.
    /// Usage:
    /// Where initial margin is posted on a portfolio basis, this field should include the total value of initial margin posted for the portfolio.
    /// If the initial margin posted is denominated in more than one currency, those amounts are converted into a single currency chosen by the reporting counterparty and reported as one total value.|
    /// ||
    /// </summary>
    [IsoId("_KN859VfVEeqqKf65rDYWYw")]
    [DisplayName("Initial Margin Posted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnPstd")]
    #endif
    [IsoXmlTag("InitlMrgnPstd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PrePostHaircut1? InitialMarginPosted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PrePostHaircut1? InitialMarginPosted { get; init; } 
    #else
    public PrePostHaircut1? InitialMarginPosted { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the pre-haircut or post-haircut monetary value of the initial margin collected by the reporting counterparty.
    /// ||Usage: |Where initial margin is collected on a portfolio basis, this field should include the total value of initial margin collected for the portfolio.
    /// If the initial margin collected is denominated in more than one currency, those amounts are converted into a single currency chosen by the reporting counterparty and reported as one total value.
    /// </summary>
    [IsoId("_KN85-VfVEeqqKf65rDYWYw")]
    [DisplayName("Initial Margin Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnRcvd")]
    #endif
    [IsoXmlTag("InitlMrgnRcvd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PrePostHaircut1? InitialMarginReceived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PrePostHaircut1? InitialMarginReceived { get; init; } 
    #else
    public PrePostHaircut1? InitialMarginReceived { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the pre-haircut or post-haircut monetary value of the variation margin posted, including cash settled, by the reporting counterparty. 
    /// Usage: Where variation margin is posted on a portfolio basis, this field should include the overall value of variation margin posted for the portfolio.
    /// If the variation margin posted is denominated in more than one currency, those amounts are converted into a single currency chosen by the reporting counterparty and reported as one total value.
    /// </summary>
    [IsoId("_KN8591fVEeqqKf65rDYWYw")]
    [DisplayName("Variation Margin Posted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnPstd")]
    #endif
    [IsoXmlTag("VartnMrgnPstd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PrePostHaircut1? VariationMarginPosted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PrePostHaircut1? VariationMarginPosted { get; init; } 
    #else
    public PrePostHaircut1? VariationMarginPosted { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the pre-haircut or post-haircut monetary value of the variation margin collected, including cash-settled, by the reporting counterparty.
    /// Usage:
    /// Where variation margin is received on a portfolio basis, this field should include the overall value of variation margin received for the portfolio.
    /// If the variation margin collected is denominated in more than one currency, those amounts are converted into a single currency chosen by the reporting counterparty and reported as one total value.
    /// </summary>
    [IsoId("_KN85-1fVEeqqKf65rDYWYw")]
    [DisplayName("Variation Margin Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnRcvd")]
    #endif
    [IsoXmlTag("VartnMrgnRcvd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PrePostHaircut1? VariationMarginReceived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PrePostHaircut1? VariationMarginReceived { get; init; } 
    #else
    public PrePostHaircut1? VariationMarginReceived { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the monetary value of additional collateral posted by the reporting counterparty in excess of the required collateral.
    /// |
    /// Usage: Where excess collateral is posted on a portfolio basis, this field should include the overall value of excess collateral posted for the portfolio.
    /// </summary>
    [IsoId("_KN85_VfVEeqqKf65rDYWYw")]
    [DisplayName("Excess Collateral Posted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcssCollPstd")]
    #endif
    [IsoXmlTag("XcssCollPstd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? ExcessCollateralPosted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? ExcessCollateralPosted { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? ExcessCollateralPosted { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the monetary value of additional collateral received by the reporting counterparty in excess of the required collateral.
    /// Usage: Where excess collateral is received on a portfolio basis, this field should include the overall value of excess collateral collected for the portfolio.
    /// </summary>
    [IsoId("_KN85_1fVEeqqKf65rDYWYw")]
    [DisplayName("Excess Collateral Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcssCollRcvd")]
    #endif
    [IsoXmlTag("XcssCollRcvd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? ExcessCollateralReceived { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? ExcessCollateralReceived { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? ExcessCollateralReceived { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if a counterparty rating trigger is agreed by the counterparties for the collateral posted by the reporting counterparty.
    /// Usage: If the element is not present, the CounterpartyRatingTrigger is False.
    /// </summary>
    [IsoId("_7wjdEorpEeq91phomTRDDA")]
    [DisplayName("Counterparty Rating Trigger Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyRatgTrggrInd")]
    #endif
    [IsoXmlTag("CtrPtyRatgTrggrInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CounterpartyRatingTriggerIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CounterpartyRatingTriggerIndicator { get; init; } 
    #else
    public System.String? CounterpartyRatingTriggerIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if a counterparty rating trigger includes a threshold that increases collateral requirements when the counterparty falls below the single-A rating or equivalent.
    /// Usage: If the CounterpartyRatingTrigger indicator is false, this element is omitted.
    /// </summary>
    [IsoId("_7wjdE4rpEeq91phomTRDDA")]
    [DisplayName("Counterparty Rating Threshold Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyRatgThrshldInd")]
    #endif
    [IsoXmlTag("CtrPtyRatgThrshldInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CounterpartyRatingThresholdIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CounterpartyRatingThresholdIndicator { get; init; } 
    #else
    public System.String? CounterpartyRatingThresholdIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
