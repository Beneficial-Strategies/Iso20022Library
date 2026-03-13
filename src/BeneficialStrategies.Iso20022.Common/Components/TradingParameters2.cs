// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Place at which the security is traded.
/// </summary>
[IsoId("_-UQ6IZJMEeuAlLVx8pyt3w")]
[DisplayName("Trading Parameters")]
public partial record TradingParameters2
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to places of trade, ie, stock exchanges, regulated markets, for example, Electronic Trading Platforms (ECN), and unregulated markets, for example, Automated Trading Systems (ATS) (MIC - ISO 3166).
    /// </summary>
    [IsoId("_-WYaAZJMEeuAlLVx8pyt3w")]
    [DisplayName("Market Identification")]
    [IsoXmlTag("MktId")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? MarketIdentification { get; init; } 
    
    /// <summary>
    /// Minimum quantity of securities that can be purchased without incurring a larger fee. For example, if the round lot size is 100 and the trade is for 125 shares, then 100 will be processed without a fee and the remaining 25 will incur a service fee for being an odd lot size.
    /// </summary>
    [IsoId("_-WYaA5JMEeuAlLVx8pyt3w")]
    [DisplayName("Round Lot")]
    [IsoXmlTag("RndLot")]
    public FinancialInstrumentQuantity1Choice_? RoundLot { get; init; } 
    
    /// <summary>
    /// Minimum number of securities that can be traded.
    /// </summary>
    [IsoId("_-WYaBZJMEeuAlLVx8pyt3w")]
    [DisplayName("Trade Lot Size")]
    [IsoXmlTag("TradLotSz")]
    public FinancialInstrumentQuantity1Choice_? TradeLotSize { get; init; } 
    
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_-WYaB5JMEeuAlLVx8pyt3w")]
    [DisplayName("Secondary Place Of Listing")]
    [IsoXmlTag("ScndryPlcOfListg")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> SecondaryPlaceOfListing { get; init; } = [];
    
    /// <summary>
    /// Minimum number of securities that can be traded.
    /// </summary>
    [IsoId("_-WYaCZJMEeuAlLVx8pyt3w")]
    [DisplayName("Minimum Traded Nominal Quantity")]
    [IsoXmlTag("MinTraddNmnlQty")]
    public UnitOrFaceAmount1Choice_? MinimumTradedNominalQuantity { get; init; } 
    
    /// <summary>
    /// Maximum number of securities that can be traded.
    /// </summary>
    [IsoId("_-WYaC5JMEeuAlLVx8pyt3w")]
    [DisplayName("Maximum Traded Nominal Quantity")]
    [IsoXmlTag("MaxTraddNmnlQty")]
    public UnitOrFaceAmount1Choice_? MaximumTradedNominalQuantity { get; init; } 
    
    /// <summary>
    /// Indicates the minimum or smallest movement (up or down) in the price allowed for the security.
    /// </summary>
    [IsoId("_-WYaDZJMEeuAlLVx8pyt3w")]
    [DisplayName("Minimum Trading Pricing Increment")]
    [IsoXmlTag("MinTradgPricgIncrmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MinimumTradingPricingIncrement { get; init; } 
    
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_-WYaFZJMEeuAlLVx8pyt3w")]
    [DisplayName("Primary Place Of Listing Identification")]
    [IsoXmlTag("PmryPlcOfListgId")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? PrimaryPlaceOfListingIdentification { get; init; } 
    
    
    #nullable disable
    
}
