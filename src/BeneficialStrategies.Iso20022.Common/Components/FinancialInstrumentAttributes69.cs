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
/// Description of the financial instrument.
/// </summary>
[IsoId("_chVDB5KQEeWHWpTQn1FFVg")]
[DisplayName("Financial Instrument Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributes69
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a financial instrument.
    /// </summary>
    [IsoId("_chVDC5KQEeWHWpTQn1FFVg")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification20? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the referenced financial instrument is listed.
    /// </summary>
    [IsoId("_chVDE5KQEeWHWpTQn1FFVg")]
    [DisplayName("Place Of Listing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfListg")]
    #endif
    [IsoXmlTag("PlcOfListg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification4Choice_? PlaceOfListing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification4Choice_? PlaceOfListing { get; init; } 
    #else
    public MarketIdentification4Choice_? PlaceOfListing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the financial instrument.
    /// </summary>
    [IsoId("_chVDG5KQEeWHWpTQn1FFVg")]
    [DisplayName("Day Count Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayCntBsis")]
    #endif
    [IsoXmlTag("DayCntBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethodFormat5Choice_? DayCountBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethodFormat5Choice_? DayCountBasis { get; init; } 
    #else
    public InterestComputationMethodFormat5Choice_? DayCountBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI).
    /// </summary>
    [IsoId("_chVDI5KQEeWHWpTQn1FFVg")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClassificationType33Choice_? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClassificationType33Choice_? ClassificationType { get; init; } 
    #else
    public ClassificationType33Choice_? ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which a financial instrument is currently denominated.
    /// </summary>
    [IsoId("_chVDK5KQEeWHWpTQn1FFVg")]
    [DisplayName("Denomination Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DnmtnCcy")]
    #endif
    [IsoXmlTag("DnmtnCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? DenominationCurrency { get; init; } 
    #else
    public string? DenominationCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    [IsoId("_chVDM5KQEeWHWpTQn1FFVg")]
    [DisplayName("Next Coupon Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtCpnDt")]
    #endif
    [IsoXmlTag("NxtCpnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? NextCouponDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? NextCouponDate { get; init; } 
    #else
    public System.DateOnly? NextCouponDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which an order expires or at which a privilege or offer terminates.
    /// </summary>
    [IsoId("_chVDO5KQEeWHWpTQn1FFVg")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpiryDate { get; init; } 
    #else
    public System.DateOnly? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the interest rate or redemption price will be/was calculated according to the terms of the issue.
    /// </summary>
    [IsoId("_chVDQ5KQEeWHWpTQn1FFVg")]
    [DisplayName("Floating Rate Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRateFxgDt")]
    #endif
    [IsoXmlTag("FltgRateFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FloatingRateFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FloatingRateFixingDate { get; init; } 
    #else
    public System.DateOnly? FloatingRateFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a financial instrument becomes due and assets are to be repaid.
    /// </summary>
    [IsoId("_chVDS5KQEeWHWpTQn1FFVg")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MaturityDate { get; init; } 
    #else
    public System.DateOnly? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the financial instrument is issued.
    /// </summary>
    [IsoId("_chVDU5KQEeWHWpTQn1FFVg")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? IssueDate { get; init; } 
    #else
    public System.DateOnly? IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a financial instrument is called away/redeemed before its scheduled maturity.
    /// </summary>
    [IsoId("_chVDW5KQEeWHWpTQn1FFVg")]
    [DisplayName("Next Callable Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtCllblDt")]
    #endif
    [IsoXmlTag("NxtCllblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? NextCallableDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? NextCallableDate { get; init; } 
    #else
    public System.DateOnly? NextCallableDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a holder of a financial instrument has the right to request redemption of the principal amount prior to its scheduled maturity date.
    /// </summary>
    [IsoId("_chVDY5KQEeWHWpTQn1FFVg")]
    [DisplayName("Putable Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PutblDt")]
    #endif
    [IsoXmlTag("PutblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? PutableDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? PutableDate { get; init; } 
    #else
    public System.DateOnly? PutableDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which an interest bearing financial instrument begins to accrue interest.
    /// </summary>
    [IsoId("_chVDa5KQEeWHWpTQn1FFVg")]
    [DisplayName("Dated Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtdDt")]
    #endif
    [IsoXmlTag("DtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DatedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DatedDate { get; init; } 
    #else
    public System.DateOnly? DatedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Deadline by which a convertible security must be converted, according to the terms of the issue.
    /// </summary>
    [IsoId("_chVDc5KQEeWHWpTQn1FFVg")]
    [DisplayName("Conversion Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvsDt")]
    #endif
    [IsoXmlTag("ConvsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ConversionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ConversionDate { get; init; } 
    #else
    public System.DateOnly? ConversionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    [IsoId("_chVDe5KQEeWHWpTQn1FFVg")]
    [DisplayName("Previous Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsFctr")]
    #endif
    [IsoXmlTag("PrvsFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOne14Rate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOne14Rate? PreviousFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PreviousFactor { get; init; } 
    #else
    public System.Decimal? PreviousFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    [IsoId("_chVDg5KQEeWHWpTQn1FFVg")]
    [DisplayName("Next Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtFctr")]
    #endif
    [IsoXmlTag("NxtFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOne14Rate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOne14Rate? NextFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NextFactor { get; init; } 
    #else
    public System.Decimal? NextFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Annual rate of a financial instrument.
    /// </summary>
    [IsoId("_chVDi5KQEeWHWpTQn1FFVg")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InterestRate { get; init; } 
    #else
    public System.Decimal? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_chVDk5KQEeWHWpTQn1FFVg")]
    [DisplayName("Next Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtIntrstRate")]
    #endif
    [IsoXmlTag("NxtIntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? NextInterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NextInterestRate { get; init; } 
    #else
    public System.Decimal? NextInterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum nominal quantity of financial instrument.
    /// </summary>
    [IsoId("_chVDm5KQEeWHWpTQn1FFVg")]
    [DisplayName("Minimum Nominal Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinNmnlQty")]
    #endif
    [IsoXmlTag("MinNmnlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? MinimumNominalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? MinimumNominalQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? MinimumNominalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a financial instrument quantity.
    /// </summary>
    [IsoId("_chVDo5KQEeWHWpTQn1FFVg")]
    [DisplayName("Contract Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctSz")]
    #endif
    [IsoXmlTag("CtrctSz")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? ContractSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? ContractSize { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? ContractSize { get; set; } 
    #endif
    
    
    #nullable disable
    
}
