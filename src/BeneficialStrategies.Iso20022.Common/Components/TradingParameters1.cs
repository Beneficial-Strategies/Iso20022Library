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
/// Place at which the security is traded.
/// </summary>
[IsoId("_hZpQ4GliEeGaMcKyqKNRfQ_173827975")]
[DisplayName("Trading Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradingParameters1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Code allocated to places of trade, ie, stock exchanges, regulated markets, for example, Electronic Trading Platforms (ECN), and unregulated markets, for example, Automated Trading Systems (ATS) (MIC - ISO 3166).
    /// </summary>
    [IsoId("_hZpQ4WliEeGaMcKyqKNRfQ_-1248560483")]
    [DisplayName("Market Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktId")]
    #endif
    [IsoXmlTag("MktId")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMICIdentifier? MarketIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MarketIdentification { get; init; } 
    #else
    public System.String? MarketIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of securities that can be purchased without incurring a larger fee. For example, if the round lot size is 100 and the trade is for 125 shares, then 100 will be processed without a fee and the remaining 25 will incur a service fee for being an odd lot size.
    /// </summary>
    [IsoId("_hZpQ4mliEeGaMcKyqKNRfQ_-469479883")]
    [DisplayName("Round Lot")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndLot")]
    #endif
    [IsoXmlTag("RndLot")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? RoundLot { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? RoundLot { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? RoundLot { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum number of securities that can be traded.
    /// </summary>
    [IsoId("_hZpQ42liEeGaMcKyqKNRfQ_1421655386")]
    [DisplayName("Trade Lot Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradLotSz")]
    #endif
    [IsoXmlTag("TradLotSz")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? TradeLotSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? TradeLotSize { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? TradeLotSize { get; set; } 
    #endif
    
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_hZpQ5GliEeGaMcKyqKNRfQ_-1252085745")]
    [DisplayName("Secondary Place Of Listing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryPlcOfListg")]
    #endif
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
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinTraddNmnlQty")]
    #endif
    [IsoXmlTag("MinTraddNmnlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmountChoice_? MinimumTradedNominalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmountChoice_? MinimumTradedNominalQuantity { get; init; } 
    #else
    public UnitOrFaceAmountChoice_? MinimumTradedNominalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of securities that can be traded.
    /// </summary>
    [IsoId("_hZpQ5mliEeGaMcKyqKNRfQ_-1334344726")]
    [DisplayName("Maximum Traded Nominal Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxTraddNmnlQty")]
    #endif
    [IsoXmlTag("MaxTraddNmnlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmountChoice_? MaximumTradedNominalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmountChoice_? MaximumTradedNominalQuantity { get; init; } 
    #else
    public UnitOrFaceAmountChoice_? MaximumTradedNominalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the minimum or smallest movement (up or down) in the price allowed for the security.
    /// </summary>
    [IsoId("_hZpQ52liEeGaMcKyqKNRfQ_1514891153")]
    [DisplayName("Minimum Trading Pricing Increment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinTradgPricgIncrmt")]
    #endif
    [IsoXmlTag("MinTradgPricgIncrmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MinimumTradingPricingIncrement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MinimumTradingPricingIncrement { get; init; } 
    #else
    public System.UInt64? MinimumTradingPricingIncrement { get; set; } 
    #endif
    
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    [IsoId("_hZpQ6GliEeGaMcKyqKNRfQ_-1797723936")]
    [DisplayName("Primary Place Of Listing Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryPlcOfListgId")]
    #endif
    [IsoXmlTag("PmryPlcOfListgId")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMICIdentifier? PrimaryPlaceOfListingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PrimaryPlaceOfListingIdentification { get; init; } 
    #else
    public System.String? PrimaryPlaceOfListingIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
