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
[IsoId("_hZpQ4GliEeGaMcKyqKNRfQ_173827975")]
[DisplayName("Trading Parameters")]
public partial record TradingParameters1
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to places of trade, ie, stock exchanges, regulated markets, for example, Electronic Trading Platforms (ECN), and unregulated markets, for example, Automated Trading Systems (ATS) (MIC - ISO 3166).
    /// </summary>
    [IsoId("_hZpQ4WliEeGaMcKyqKNRfQ_-1248560483")]
    [DisplayName("Market Identification")]
    [IsoXmlTag("MktId")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? MarketIdentification { get; init; } 
    
    /// <summary>
    /// Minimum quantity of securities that can be purchased without incurring a larger fee. For example, if the round lot size is 100 and the trade is for 125 shares, then 100 will be processed without a fee and the remaining 25 will incur a service fee for being an odd lot size.
    /// </summary>
    [IsoId("_hZpQ4mliEeGaMcKyqKNRfQ_-469479883")]
    [DisplayName("Round Lot")]
    [IsoXmlTag("RndLot")]
    public FinancialInstrumentQuantity1Choice_? RoundLot { get; init; } 
    
    /// <summary>
    /// Minimum number of securities that can be traded.
    /// </summary>
    [IsoId("_hZpQ42liEeGaMcKyqKNRfQ_1421655386")]
    [DisplayName("Trade Lot Size")]
    [IsoXmlTag("TradLotSz")]
    public FinancialInstrumentQuantity1Choice_? TradeLotSize { get; init; } 
    
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_hZpQ5GliEeGaMcKyqKNRfQ_-1252085745")]
    [DisplayName("Secondary Place Of Listing")]
    [IsoXmlTag("ScndryPlcOfListg")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> SecondaryPlaceOfListing { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Minimum number of securities that can be traded.
    /// </summary>
    [IsoId("_hZpQ5WliEeGaMcKyqKNRfQ_246464361")]
    [DisplayName("Minimum Traded Nominal Quantity")]
    [IsoXmlTag("MinTraddNmnlQty")]
    public UnitOrFaceAmountChoice_? MinimumTradedNominalQuantity { get; init; } 
    
    /// <summary>
    /// Maximum number of securities that can be traded.
    /// </summary>
    [IsoId("_hZpQ5mliEeGaMcKyqKNRfQ_-1334344726")]
    [DisplayName("Maximum Traded Nominal Quantity")]
    [IsoXmlTag("MaxTraddNmnlQty")]
    public UnitOrFaceAmountChoice_? MaximumTradedNominalQuantity { get; init; } 
    
    /// <summary>
    /// Indicates the minimum or smallest movement (up or down) in the price allowed for the security.
    /// </summary>
    [IsoId("_hZpQ52liEeGaMcKyqKNRfQ_1514891153")]
    [DisplayName("Minimum Trading Pricing Increment")]
    [IsoXmlTag("MinTradgPricgIncrmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MinimumTradingPricingIncrement { get; init; } 
    
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_hZpQ6GliEeGaMcKyqKNRfQ_-1797723936")]
    [DisplayName("Primary Place Of Listing Identification")]
    [IsoXmlTag("PmryPlcOfListgId")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? PrimaryPlaceOfListingIdentification { get; init; } 
    
    
    #nullable disable
    
}
