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
[IsoId("_dkMBwfpSEeCLrd06h-p51g")]
[DisplayName("Financial Instrument Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributes34
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentAttributes34 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentAttributes34( SecurityIdentification14 reqFinancialInstrumentIdentification )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_dkMB0_pSEeCLrd06h-p51g")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the referenced financial instrument is listed.
    /// </summary>
    [IsoId("_dkMB3fpSEeCLrd06h-p51g")]
    [DisplayName("Place Of Listing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfListg")]
    #endif
    [IsoXmlTag("PlcOfListg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification3Choice_? PlaceOfListing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification3Choice_? PlaceOfListing { get; init; } 
    #else
    public MarketIdentification3Choice_? PlaceOfListing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the financial instrument.
    /// </summary>
    [IsoId("_dkMB5_pSEeCLrd06h-p51g")]
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
    [IsoId("_dkMB8fpSEeCLrd06h-p51g")]
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
    /// Specifies how an option can be exercised.
    /// </summary>
    [IsoId("_dkMB-_pSEeCLrd06h-p51g")]
    [DisplayName("Option Style")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnStyle")]
    #endif
    [IsoXmlTag("OptnStyle")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionStyle4Choice_? OptionStyle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionStyle4Choice_? OptionStyle { get; init; } 
    #else
    public OptionStyle4Choice_? OptionStyle { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which a financial instrument is currently denominated.
    /// </summary>
    [IsoId("_dkMCBfpSEeCLrd06h-p51g")]
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
    [IsoId("_dkMCD_pSEeCLrd06h-p51g")]
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
    /// Date on which the interest rate or redemption price will be/was calculated according to the terms of the issue.
    /// </summary>
    [IsoId("_dkMCGfpSEeCLrd06h-p51g")]
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
    [IsoId("_dkMCI_pSEeCLrd06h-p51g")]
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
    /// Date at which the security was made available.
    /// </summary>
    [IsoId("_dkMCLfpSEeCLrd06h-p51g")]
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
    [IsoId("_dkMCN_pSEeCLrd06h-p51g")]
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
    [IsoId("_dkMCQfpSEeCLrd06h-p51g")]
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
    [IsoId("_dkMCS_pSEeCLrd06h-p51g")]
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
    [IsoId("_dkMCVfpSEeCLrd06h-p51g")]
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
    [IsoId("_dkMCX_pSEeCLrd06h-p51g")]
    [DisplayName("Previous Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsFctr")]
    #endif
    [IsoXmlTag("PrvsFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat3Choice_? PreviousFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat3Choice_? PreviousFactor { get; init; } 
    #else
    public RateFormat3Choice_? PreviousFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    [IsoId("_dkMCafpSEeCLrd06h-p51g")]
    [DisplayName("Next Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtFctr")]
    #endif
    [IsoXmlTag("NxtFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat3Choice_? NextFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat3Choice_? NextFactor { get; init; } 
    #else
    public RateFormat3Choice_? NextFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Annual rate of a financial instrument.
    /// </summary>
    [IsoId("_dkMCc_pSEeCLrd06h-p51g")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat3Choice_? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat3Choice_? InterestRate { get; init; } 
    #else
    public RateFormat3Choice_? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_dkMCffpSEeCLrd06h-p51g")]
    [DisplayName("Next Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtIntrstRate")]
    #endif
    [IsoXmlTag("NxtIntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat3Choice_? NextInterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat3Choice_? NextInterestRate { get; init; } 
    #else
    public RateFormat3Choice_? NextInterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Also known as Minimum Nominal Value. Minimum nominal quantity of financial instrument that must be purchased/sold.
    /// </summary>
    [IsoId("_dkMCh_pSEeCLrd06h-p51g")]
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
    [IsoId("_dkMClfpSEeCLrd06h-p51g")]
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
    [IsoId("_dkMCo_pSEeCLrd06h-p51g")]
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
    [IsoId("_dkMCsfpSEeCLrd06h-p51g")]
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
    
    /// <summary>
    /// Initial issue/valuation price of a resulting security under a corporate action.
    /// </summary>
    [IsoId("_dkMCv_pSEeCLrd06h-p51g")]
    [DisplayName("Issue Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssePric")]
    #endif
    [IsoXmlTag("IssePric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat19Choice_? IssuePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat19Choice_? IssuePrice { get; init; } 
    #else
    public PriceFormat19Choice_? IssuePrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
