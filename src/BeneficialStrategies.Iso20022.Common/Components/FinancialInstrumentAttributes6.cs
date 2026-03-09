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
[IsoId("_Tyn7Hdp-Ed-ak6NoX_4Aeg_673552870")]
[DisplayName("Financial Instrument Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributes6
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
    [IsoId("_Tyn7Htp-Ed-ak6NoX_4Aeg_673552872")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification11? SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification11? SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification11? SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the referenced financial instrument is listed.
    /// </summary>
    [IsoId("_TyxsENp-Ed-ak6NoX_4Aeg_673552913")]
    [DisplayName("Place Of Listing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfListg")]
    #endif
    [IsoXmlTag("PlcOfListg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification2? PlaceOfListing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification2? PlaceOfListing { get; init; } 
    #else
    public MarketIdentification2? PlaceOfListing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the financial instrument.
    /// </summary>
    [IsoId("_TyxsEdp-Ed-ak6NoX_4Aeg_673552930")]
    [DisplayName("Day Count Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayCntBsis")]
    #endif
    [IsoXmlTag("DayCntBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethodFormat1Choice_? DayCountBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethodFormat1Choice_? DayCountBasis { get; init; } 
    #else
    public InterestComputationMethodFormat1Choice_? DayCountBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI).
    /// </summary>
    [IsoId("_TyxsEtp-Ed-ak6NoX_4Aeg_673552948")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClassificationType2Choice_? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClassificationType2Choice_? ClassificationType { get; init; } 
    #else
    public ClassificationType2Choice_? ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which a financial instrument is currently denominated.
    /// </summary>
    [IsoId("_TyxsE9p-Ed-ak6NoX_4Aeg_673552983")]
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
    [IsoId("_TyxsFNp-Ed-ak6NoX_4Aeg_673553225")]
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
    [IsoId("_TyxsFdp-Ed-ak6NoX_4Aeg_673553242")]
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
    [IsoId("_TyxsFtp-Ed-ak6NoX_4Aeg_673553260")]
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
    [IsoId("_TyxsF9p-Ed-ak6NoX_4Aeg_673553285")]
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
    [IsoId("_Ty62ANp-Ed-ak6NoX_4Aeg_673553302")]
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
    [IsoId("_Ty62Adp-Ed-ak6NoX_4Aeg_673553320")]
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
    [IsoId("_Ty62Atp-Ed-ak6NoX_4Aeg_673553337")]
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
    [IsoId("_Ty62A9p-Ed-ak6NoX_4Aeg_910894710")]
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
    [IsoId("_Ty62BNp-Ed-ak6NoX_4Aeg_910894727")]
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
    [IsoId("_Ty62Bdp-Ed-ak6NoX_4Aeg_-1182634448")]
    [DisplayName("Previous Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsFctr")]
    #endif
    [IsoXmlTag("PrvsFctr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PreviousFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PreviousFactor { get; init; } 
    #else
    public System.Decimal? PreviousFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    [IsoId("_Ty62Btp-Ed-ak6NoX_4Aeg_-1182633921")]
    [DisplayName("Next Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtFctr")]
    #endif
    [IsoXmlTag("NxtFctr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? NextFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NextFactor { get; init; } 
    #else
    public System.Decimal? NextFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Annual rate of a financial instrument.
    /// </summary>
    [IsoId("_Ty62B9p-Ed-ak6NoX_4Aeg_910894762")]
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
    [IsoId("_TzEnANp-Ed-ak6NoX_4Aeg_910894780")]
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
    /// Also known as Minimum Nominal Value. Minimum nominal quantity of financial instrument that must be purchased/sold.
    /// </summary>
    [IsoId("_TzEnAdp-Ed-ak6NoX_4Aeg_910894995")]
    [DisplayName("Minimum Nominal Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinNmnlQty")]
    #endif
    [IsoXmlTag("MinNmnlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_TzEnAtp-Ed-ak6NoX_4Aeg_910895237")]
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
    /// Minimum multiple quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_TzEnA9p-Ed-ak6NoX_4Aeg_910895272")]
    [DisplayName("Minimum Exercisable Multiple Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinExrcblMltplQty")]
    #endif
    [IsoXmlTag("MinExrcblMltplQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a financial instrument quantity.
    /// </summary>
    [IsoId("_TzEnBNp-Ed-ak6NoX_4Aeg_910895289")]
    [DisplayName("Contract Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctSz")]
    #endif
    [IsoXmlTag("CtrctSz")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? ContractSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? ContractSize { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? ContractSize { get; set; } 
    #endif
    
    
    #nullable disable
    
}
