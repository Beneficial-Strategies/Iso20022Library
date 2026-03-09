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
/// Contracts which grant to the holder either the privilege to purchase or the privilege to sell the assets specified at a predetermined price or formula at or within a time in the future.
/// </summary>
[IsoId("_PPNyoWp7EemmaZLSPtWX5A")]
[DisplayName("Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Option15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the option contract settles at the open or close of the market.
    /// </summary>
    [IsoId("_PbLyEWp7EemmaZLSPtWX5A")]
    [DisplayName("Option Settlement Style")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnSttlmStyle")]
    #endif
    [IsoXmlTag("OptnSttlmStyle")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettleStyle2Choice_? OptionSettlementStyle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettleStyle2Choice_? OptionSettlementStyle { get; init; } 
    #else
    public SettleStyle2Choice_? OptionSettlementStyle { get; set; } 
    #endif
    
    /// <summary>
    /// Deadline by which a convertible security must be converted according to the terms of the issue.
    /// </summary>
    [IsoId("_PbLyE2p7EemmaZLSPtWX5A")]
    [DisplayName("Conversion Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvsDt")]
    #endif
    [IsoXmlTag("ConvsDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ConversionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ConversionDate { get; init; } 
    #else
    public System.DateTime? ConversionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money for which goods, services or assets are offered, sold, or bought.
    /// </summary>
    [IsoId("_PbLyFWp7EemmaZLSPtWX5A")]
    [DisplayName("Strike Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrkPric")]
    #endif
    [IsoXmlTag("StrkPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price8? StrikePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price8? StrikePrice { get; init; } 
    #else
    public Price8? StrikePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of securities that must be exercised.
    /// </summary>
    [IsoId("_PbMZJWp7EemmaZLSPtWX5A")]
    [DisplayName("Minimum Exercisable Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinExrcblQty")]
    #endif
    [IsoXmlTag("MinExrcblQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which a convertible security may be converted according to the terms of the issue.
    /// </summary>
    [IsoId("_PbMZJ2p7EemmaZLSPtWX5A")]
    [DisplayName("Conversion Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvsPrd")]
    #endif
    [IsoXmlTag("ConvsPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1Choice_? ConversionPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1Choice_? ConversionPeriod { get; init; } 
    #else
    public DateTimePeriod1Choice_? ConversionPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how an option can be exercised (American, European, Bermudan).
    /// </summary>
    [IsoId("_PbMZKWp7EemmaZLSPtWX5A")]
    [DisplayName("Option Style")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnStyle")]
    #endif
    [IsoXmlTag("OptnStyle")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionStyle1Choice_? OptionStyle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionStyle1Choice_? OptionStyle { get; init; } 
    #else
    public OptionStyle1Choice_? OptionStyle { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_PbMZK2p7EemmaZLSPtWX5A")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionType8Choice_? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType8Choice_? OptionType { get; init; } 
    #else
    public OptionType8Choice_? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Used for derivatives. The number of shares/units for the financial instrument involved in the option trade.
    /// </summary>
    [IsoId("_PbMZLWp7EemmaZLSPtWX5A")]
    [DisplayName("Strike Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrkVal")]
    #endif
    [IsoXmlTag("StrkVal")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? StrikeValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? StrikeValue { get; init; } 
    #else
    public System.UInt64? StrikeValue { get; set; } 
    #endif
    
    /// <summary>
    /// Used for derivatives. Multiplier applied to the strike price for the purpose of calculating the settlement value.
    /// </summary>
    [IsoId("_PbMZNWp7EemmaZLSPtWX5A")]
    [DisplayName("Strike Multiplier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrkMltplr")]
    #endif
    [IsoXmlTag("StrkMltplr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? StrikeMultiplier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? StrikeMultiplier { get; init; } 
    #else
    public System.UInt64? StrikeMultiplier { get; set; } 
    #endif
    
    /// <summary>
    /// Method under which assignment was conducted.
    /// </summary>
    [IsoId("_PbMZPWp7EemmaZLSPtWX5A")]
    [DisplayName("Instrument Assignment Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrmAssgnmtMtd")]
    #endif
    [IsoXmlTag("InstrmAssgnmtMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssignmentMethod2Choice_? InstrumentAssignmentMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssignmentMethod2Choice_? InstrumentAssignmentMethod { get; init; } 
    #else
    public AssignmentMethod2Choice_? InstrumentAssignmentMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Number allocated by options exchanges to record that an option has undergone a change in its contract specifications (particularly adjustment of the strike price).
    /// </summary>
    [IsoId("_PbMZRWp7EemmaZLSPtWX5A")]
    [DisplayName("Version Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VrsnNb")]
    #endif
    [IsoXmlTag("VrsnNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? VersionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? VersionNumber { get; init; } 
    #else
    public System.UInt64? VersionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Financial center where option expires.
    /// </summary>
    [IsoId("_PbMZTWp7EemmaZLSPtWX5A")]
    [DisplayName("Expiry Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryLctn")]
    #endif
    [IsoXmlTag("XpryLctn")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4AlphaNumericText? ExpiryLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExpiryLocation { get; init; } 
    #else
    public System.String? ExpiryLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the terms of the security (underlying instruments, expiration date, contract size) are defined according to the exchange specifications or whether they can be user defined.
    /// </summary>
    [IsoId("_PbMZT2p7EemmaZLSPtWX5A")]
    [DisplayName("Standardisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Stdstn")]
    #endif
    [IsoXmlTag("Stdstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Standardisation3Choice_? Standardisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Standardisation3Choice_? Standardisation { get; init; } 
    #else
    public Standardisation3Choice_? Standardisation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the party which is the buyer or the seller.
    /// </summary>
    [IsoId("_PbMZUWp7EemmaZLSPtWX5A")]
    [DisplayName("Trading Party Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgPtyRole")]
    #endif
    [IsoXmlTag("TradgPtyRole")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionParty3Choice_? TradingPartyRole { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionParty3Choice_? TradingPartyRole { get; init; } 
    #else
    public OptionParty3Choice_? TradingPartyRole { get; set; } 
    #endif
    
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a quantity.
    /// </summary>
    [IsoId("_PbMZU2p7EemmaZLSPtWX5A")]
    [DisplayName("Contract Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctSz")]
    #endif
    [IsoXmlTag("CtrctSz")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? ContractSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ContractSize { get; init; } 
    #else
    public System.Decimal? ContractSize { get; set; } 
    #endif
    
    /// <summary>
    /// Provides more information about the underlying instrument.
    /// </summary>
    [IsoId("_PbMZVWp7EemmaZLSPtWX5A")]
    [DisplayName("Additional Underlying Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlUndrlygAttrbts")]
    #endif
    [IsoXmlTag("AddtlUndrlygAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingAttributes4? AdditionalUnderlyingAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingAttributes4? AdditionalUnderlyingAttributes { get; init; } 
    #else
    public UnderlyingAttributes4? AdditionalUnderlyingAttributes { get; set; } 
    #endif
    
    
    #nullable disable
    
}
