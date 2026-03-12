// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contracts which grant to the holder either the privilege to purchase or the privilege to sell the assets specified at a predetermined price or formula at or within a time in the future.
/// </summary>
[IsoId("_PPNyoWp7EemmaZLSPtWX5A")]
[DisplayName("Option")]
public partial record Option15
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the option contract settles at the open or close of the market.
    /// </summary>
    [IsoId("_PbLyEWp7EemmaZLSPtWX5A")]
    [DisplayName("Option Settlement Style")]
    [IsoXmlTag("OptnSttlmStyle")]
    public SettleStyle2Choice_? OptionSettlementStyle { get; init; } 
    
    /// <summary>
    /// Deadline by which a convertible security must be converted according to the terms of the issue.
    /// </summary>
    [IsoId("_PbLyE2p7EemmaZLSPtWX5A")]
    [DisplayName("Conversion Date")]
    [IsoXmlTag("ConvsDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ConversionDate { get; init; } 
    
    /// <summary>
    /// Amount of money for which goods, services or assets are offered, sold, or bought.
    /// </summary>
    [IsoId("_PbLyFWp7EemmaZLSPtWX5A")]
    [DisplayName("Strike Price")]
    [IsoXmlTag("StrkPric")]
    public Price8? StrikePrice { get; init; } 
    
    /// <summary>
    /// Minimum quantity of securities that must be exercised.
    /// </summary>
    [IsoId("_PbMZJWp7EemmaZLSPtWX5A")]
    [DisplayName("Minimum Exercisable Quantity")]
    [IsoXmlTag("MinExrcblQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; } 
    
    /// <summary>
    /// Period during which a convertible security may be converted according to the terms of the issue.
    /// </summary>
    [IsoId("_PbMZJ2p7EemmaZLSPtWX5A")]
    [DisplayName("Conversion Period")]
    [IsoXmlTag("ConvsPrd")]
    public DateTimePeriod1Choice_? ConversionPeriod { get; init; } 
    
    /// <summary>
    /// Specifies how an option can be exercised (American, European, Bermudan).
    /// </summary>
    [IsoId("_PbMZKWp7EemmaZLSPtWX5A")]
    [DisplayName("Option Style")]
    [IsoXmlTag("OptnStyle")]
    public OptionStyle1Choice_? OptionStyle { get; init; } 
    
    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_PbMZK2p7EemmaZLSPtWX5A")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType8Choice_? OptionType { get; init; } 
    
    /// <summary>
    /// Used for derivatives. The number of shares/units for the financial instrument involved in the option trade.
    /// </summary>
    [IsoId("_PbMZLWp7EemmaZLSPtWX5A")]
    [DisplayName("Strike Value")]
    [IsoXmlTag("StrkVal")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? StrikeValue { get; init; } 
    
    /// <summary>
    /// Used for derivatives. Multiplier applied to the strike price for the purpose of calculating the settlement value.
    /// </summary>
    [IsoId("_PbMZNWp7EemmaZLSPtWX5A")]
    [DisplayName("Strike Multiplier")]
    [IsoXmlTag("StrkMltplr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? StrikeMultiplier { get; init; } 
    
    /// <summary>
    /// Method under which assignment was conducted.
    /// </summary>
    [IsoId("_PbMZPWp7EemmaZLSPtWX5A")]
    [DisplayName("Instrument Assignment Method")]
    [IsoXmlTag("InstrmAssgnmtMtd")]
    public AssignmentMethod2Choice_? InstrumentAssignmentMethod { get; init; } 
    
    /// <summary>
    /// Number allocated by options exchanges to record that an option has undergone a change in its contract specifications (particularly adjustment of the strike price).
    /// </summary>
    [IsoId("_PbMZRWp7EemmaZLSPtWX5A")]
    [DisplayName("Version Number")]
    [IsoXmlTag("VrsnNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? VersionNumber { get; init; } 
    
    /// <summary>
    /// Financial center where option expires.
    /// </summary>
    [IsoId("_PbMZTWp7EemmaZLSPtWX5A")]
    [DisplayName("Expiry Location")]
    [IsoXmlTag("XpryLctn")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4AlphaNumericText? ExpiryLocation { get; init; } 
    
    /// <summary>
    /// Specifies whether the terms of the security (underlying instruments, expiration date, contract size) are defined according to the exchange specifications or whether they can be user defined.
    /// </summary>
    [IsoId("_PbMZT2p7EemmaZLSPtWX5A")]
    [DisplayName("Standardisation")]
    [IsoXmlTag("Stdstn")]
    public Standardisation3Choice_? Standardisation { get; init; } 
    
    /// <summary>
    /// Specifies the party which is the buyer or the seller.
    /// </summary>
    [IsoId("_PbMZUWp7EemmaZLSPtWX5A")]
    [DisplayName("Trading Party Role")]
    [IsoXmlTag("TradgPtyRole")]
    public OptionParty3Choice_? TradingPartyRole { get; init; } 
    
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    [IsoId("_PbMZU2p7EemmaZLSPtWX5A")]
    [DisplayName("Contract Size")]
    [IsoXmlTag("CtrctSz")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ContractSize { get; init; } 
    
    /// <summary>
    /// Provides more information about the underlying instrument.
    /// </summary>
    [IsoId("_PbMZVWp7EemmaZLSPtWX5A")]
    [DisplayName("Additional Underlying Attributes")]
    [IsoXmlTag("AddtlUndrlygAttrbts")]
    public UnderlyingAttributes4? AdditionalUnderlyingAttributes { get; init; } 
    
    
    #nullable disable
    
}
