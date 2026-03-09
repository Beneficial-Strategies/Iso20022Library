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
/// Additional restrictions on the financial instrument, related to the stipulation.
/// </summary>
[IsoId("_5DuEYQgTEe2fOITqoTnSLQ")]
[DisplayName("Financial Instrument Stipulations")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentStipulations4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of stipulation expressing geographical constraints on a fixed income instrument. It is expressed with a state or country abbreviation and a minimum or maximum percentage. Example: CA 0-80 (minimum of 80 percent in Californian assests).
    /// </summary>
    [IsoId("_5XPdVwgTEe2fOITqoTnSLQ")]
    [DisplayName("Geographics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Geogcs")]
    #endif
    [IsoXmlTag("Geogcs")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Geographics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Geographics { get; init; } 
    #else
    public System.String? Geographics { get; set; } 
    #endif
    
    /// <summary>
    /// Range of allowed yield.
    /// </summary>
    [IsoId("_5XPdXwgTEe2fOITqoTnSLQ")]
    [DisplayName("Yield Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="YldRg")]
    #endif
    [IsoXmlTag("YldRg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountOrPercentageRange1? YieldRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrPercentageRange1? YieldRange { get; init; } 
    #else
    public AmountOrPercentageRange1? YieldRange { get; set; } 
    #endif
    
    /// <summary>
    /// Range of assessment of securities credit and investment risk.
    /// </summary>
    [IsoId("_5XPdYQgTEe2fOITqoTnSLQ")]
    [DisplayName("Rating")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ratg")]
    #endif
    [IsoXmlTag("Ratg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rating1? Rating { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rating1? Rating { get; init; } 
    #else
    public Rating1? Rating { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a range of coupon numbers attached to its related financial instrument.
    /// </summary>
    [IsoId("_5XPdYwgTEe2fOITqoTnSLQ")]
    [DisplayName("Coupon Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpnRg")]
    #endif
    [IsoXmlTag("CpnRg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountOrPercentageRange1? CouponRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrPercentageRange1? CouponRange { get; init; } 
    #else
    public AmountOrPercentageRange1? CouponRange { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument repays the principal amount in parts during the life cycle of the security.
    /// </summary>
    [IsoId("_5XPdZQgTEe2fOITqoTnSLQ")]
    [DisplayName("Amortisable Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtsblInd")]
    #endif
    [IsoXmlTag("AmtsblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AmortisableIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AmortisableIndicator { get; init; } 
    #else
    public System.String? AmortisableIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for which money is raised through the issuance of a security.
    /// </summary>
    [IsoId("_5XPdZwgTEe2fOITqoTnSLQ")]
    [DisplayName("Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Purp")]
    #endif
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Purpose { get; init; } 
    #else
    public System.String? Purpose { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the issue is subject to alternative minimum taxation (used for municipal bonds).
    /// </summary>
    [IsoId("_5XPdaQgTEe2fOITqoTnSLQ")]
    [DisplayName("Alternative Minimum Tax Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrntvMinTaxInd")]
    #endif
    [IsoXmlTag("AltrntvMinTaxInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AlternativeMinimumTaxIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlternativeMinimumTaxIndicator { get; init; } 
    #else
    public System.String? AlternativeMinimumTaxIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates an instruction to reinvest dividends in the underlying security (or proceeds at maturity in a similar instrument) if the current rate is &lt;rate&gt; or better.
    /// </summary>
    [IsoId("_5XPdawgTEe2fOITqoTnSLQ")]
    [DisplayName("Auto Reinvestment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AutoRinvstmt")]
    #endif
    [IsoXmlTag("AutoRinvstmt")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? AutoReinvestment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AutoReinvestment { get; init; } 
    #else
    public System.Decimal? AutoReinvestment { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_5XPdbQgTEe2fOITqoTnSLQ")]
    [DisplayName("Transaction Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxConds")]
    #endif
    [IsoXmlTag("TxConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeTransactionCondition2Code? TransactionConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransactionCondition2Code? TransactionConditions { get; init; } 
    #else
    public TradeTransactionCondition2Code? TransactionConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_5XPdbwgTEe2fOITqoTnSLQ")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates an instruction to override an investment&apos;s default start and/or end date with a custom date.
    /// </summary>
    [IsoId("_5XPdcQgTEe2fOITqoTnSLQ")]
    [DisplayName("Custom Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmDt")]
    #endif
    [IsoXmlTag("CstmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod2? CustomDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod2? CustomDate { get; init; } 
    #else
    public DateTimePeriod2? CustomDate { get; set; } 
    #endif
    
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_5XPdcwgTEe2fOITqoTnSLQ")]
    [DisplayName("Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hrcut")]
    #endif
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Haircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Haircut { get; init; } 
    #else
    public System.Decimal? Haircut { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the lender is assured partial or full payment by a third party if the borrower defaults.
    /// </summary>
    [IsoId("_5XPddQgTEe2fOITqoTnSLQ")]
    [DisplayName("Insured Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrdInd")]
    #endif
    [IsoXmlTag("InsrdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? InsuredIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InsuredIndicator { get; init; } 
    #else
    public System.String? InsuredIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates an instruction or attribute giving the number of days to be included in the look-back period for the investment. E.g. some options allow exercise based on the underlying asset&apos;s optimal value over the look-back period.
    /// </summary>
    [IsoId("_5XPddwgTEe2fOITqoTnSLQ")]
    [DisplayName("Look Back")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LookBck")]
    #endif
    [IsoXmlTag("LookBck")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? LookBack { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? LookBack { get; init; } 
    #else
    public System.UInt64? LookBack { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the maturity date.
    /// </summary>
    [IsoId("_5XPdfwgTEe2fOITqoTnSLQ")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYearMonth? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? MaturityDate { get; init; } 
    #else
    public System.UInt16? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the issue date.
    /// </summary>
    [IsoId("_5XPdgQgTEe2fOITqoTnSLQ")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYearMonth? IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? IssueDate { get; init; } 
    #else
    public System.UInt16? IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the issuer.
    /// </summary>
    [IsoId("_5XPdgwgTEe2fOITqoTnSLQ")]
    [DisplayName("Issuer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrId")]
    #endif
    [IsoXmlTag("IssrId")]
    [IsoSimpleType(IsoSimpleType.BICNonFIDec2014Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBICNonFIDec2014Identifier? IssuerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuerIdentification { get; init; } 
    #else
    public System.String? IssuerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the issue size range.
    /// </summary>
    [IsoId("_5XPdhQgTEe2fOITqoTnSLQ")]
    [DisplayName("Issue Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseSz")]
    #endif
    [IsoXmlTag("IsseSz")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? IssueSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? IssueSize { get; init; } 
    #else
    public System.UInt64? IssueSize { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the minimum denomination of a security.
    /// </summary>
    [IsoId("_5XPdhwgTEe2fOITqoTnSLQ")]
    [DisplayName("Minimum Denomination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinDnmtn")]
    #endif
    [IsoXmlTag("MinDnmtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumDenomination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumDenomination { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumDenomination { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of time the collateral can be substitute.
    /// </summary>
    [IsoId("_5XPdiQgTEe2fOITqoTnSLQ")]
    [DisplayName("Maximum Substitution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxSbstitn")]
    #endif
    [IsoXmlTag("MaxSbstitn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumSubstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumSubstitution { get; init; } 
    #else
    public System.UInt64? MaximumSubstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the minimum tradable increments of a security.
    /// </summary>
    [IsoId("_5XPdiwgTEe2fOITqoTnSLQ")]
    [DisplayName("Minimum Increment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinIncrmt")]
    #endif
    [IsoXmlTag("MinIncrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumIncrement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumIncrement { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumIncrement { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the periodic or regular cycle of interest payments.
    /// </summary>
    [IsoId("_5XPdjQgTEe2fOITqoTnSLQ")]
    [DisplayName("Payment Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtFrqcy")]
    #endif
    [IsoXmlTag("PmtFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency1Code? PaymentFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency1Code? PaymentFrequency { get; init; } 
    #else
    public Frequency1Code? PaymentFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the minimum tradable quantity of a security.
    /// </summary>
    [IsoId("_5XPdjwgTEe2fOITqoTnSLQ")]
    [DisplayName("Minimum Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinQty")]
    #endif
    [IsoXmlTag("MinQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? MinimumQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? MinimumQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? MinimumQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a search criterion used when looking to buy a bond, particularly an MBS, issued in a particular year.
    /// </summary>
    [IsoId("_5XPdkQgTEe2fOITqoTnSLQ")]
    [DisplayName("Production")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pdctn")]
    #endif
    [IsoXmlTag("Pdctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Production { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Production { get; init; } 
    #else
    public System.String? Production { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies if the securities is restricted or not (as per Rule 144).
    /// </summary>
    [IsoId("_5XPdkwgTEe2fOITqoTnSLQ")]
    [DisplayName("Restricted Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstrctdInd")]
    #endif
    [IsoXmlTag("RstrctdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RestrictedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RestrictedIndicator { get; init; } 
    #else
    public System.String? RestrictedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the frequency at which the bond is re-rated and therefore re-priced (bond attribute, particularly of floating rate and index linked instruments).
    /// </summary>
    [IsoId("_5XPdlQgTEe2fOITqoTnSLQ")]
    [DisplayName("Price Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricFrqcy")]
    #endif
    [IsoXmlTag("PricFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency1Code? PriceFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency1Code? PriceFrequency { get; init; } 
    #else
    public Frequency1Code? PriceFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the market sector the security is classified as. E.g. pharmacuticals, automobile, housing, etc.
    /// </summary>
    [IsoId("_5XPdlwgTEe2fOITqoTnSLQ")]
    [DisplayName("Sector")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sctr")]
    #endif
    [IsoXmlTag("Sctr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Sector { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Sector { get; init; } 
    #else
    public System.String? Sector { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the maximum number of times collateral can be substituted.
    /// </summary>
    [IsoId("_5XPdmQgTEe2fOITqoTnSLQ")]
    [DisplayName("Substitution Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbstitnFrqcy")]
    #endif
    [IsoXmlTag("SbstitnFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency1Code? SubstitutionFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency1Code? SubstitutionFrequency { get; init; } 
    #else
    public Frequency1Code? SubstitutionFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Number of remaining times the collateral can be substitute.
    /// </summary>
    [IsoId("_5XPdmwgTEe2fOITqoTnSLQ")]
    [DisplayName("Substitution Left")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbstitnLft")]
    #endif
    [IsoXmlTag("SbstitnLft")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SubstitutionLeft { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SubstitutionLeft { get; init; } 
    #else
    public System.UInt64? SubstitutionLeft { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a search criterion when looking to buy an MBS that either is [yes] or is not [no] an entire pool.
    /// </summary>
    [IsoId("_5XPdnQgTEe2fOITqoTnSLQ")]
    [DisplayName("Whole Pool Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhlPoolInd")]
    #endif
    [IsoXmlTag("WhlPoolInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? WholePoolIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WholePoolIndicator { get; init; } 
    #else
    public System.String? WholePoolIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the Benchmark source price (eg. BB Generic, BB Fairvalue, Brokertec.).
    /// </summary>
    [IsoId("_5XPdnwgTEe2fOITqoTnSLQ")]
    [DisplayName("Price Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricSrc")]
    #endif
    [IsoXmlTag("PricSrc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PriceSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PriceSource { get; init; } 
    #else
    public System.String? PriceSource { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which an interest bearing security becomes due and assets are to be repaid.
    /// </summary>
    [IsoId("_5XPdoQgTEe2fOITqoTnSLQ")]
    [DisplayName("Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XprtnDt")]
    #endif
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ExpirationDate { get; init; } 
    #else
    public System.DateTime? ExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount for which a security can be overalloted (as in greenshoe option).
    /// </summary>
    [IsoId("_5XPdowgTEe2fOITqoTnSLQ")]
    [DisplayName("Over Allotment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OverAlltmtAmt")]
    #endif
    [IsoXmlTag("OverAlltmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? OverAllotmentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? OverAllotmentAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? OverAllotmentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage for which a security can be overalloted (as in greenshoe option).
    /// </summary>
    [IsoId("_5XPdpQgTEe2fOITqoTnSLQ")]
    [DisplayName("Over Allotment Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OverAlltmtRate")]
    #endif
    [IsoXmlTag("OverAlltmtRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? OverAllotmentRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? OverAllotmentRate { get; init; } 
    #else
    public System.Decimal? OverAllotmentRate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a search criterion used when looking to buy a bond within a particular price range.
    /// </summary>
    [IsoId("_5XPdpwgTEe2fOITqoTnSLQ")]
    [DisplayName("Price Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricRg")]
    #endif
    [IsoXmlTag("PricRg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountOrPercentageRange1? PriceRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrPercentageRange1? PriceRange { get; init; } 
    #else
    public AmountOrPercentageRange1? PriceRange { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the issuer has the right to pay the security prior to maturity. Also called RetractableIndicator.
    /// </summary>
    [IsoId("_5XPdqQgTEe2fOITqoTnSLQ")]
    [DisplayName("Callable Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CllblInd")]
    #endif
    [IsoXmlTag("CllblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CallableIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CallableIndicator { get; init; } 
    #else
    public System.String? CallableIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interest bearing security is convertible into another type of security.
    /// </summary>
    [IsoId("_5XPdqwgTEe2fOITqoTnSLQ")]
    [DisplayName("Convertible Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvtblInd")]
    #endif
    [IsoXmlTag("ConvtblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ConvertibleIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConvertibleIndicator { get; init; } 
    #else
    public System.String? ConvertibleIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the holder has the right to ask for redemption of the security prior to final maturity. Also called RedeemableIndicator.
    /// </summary>
    [IsoId("_5XPdrQgTEe2fOITqoTnSLQ")]
    [DisplayName("Putable Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PutblInd")]
    #endif
    [IsoXmlTag("PutblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PutableIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PutableIndicator { get; init; } 
    #else
    public System.String? PutableIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether an interest bearing instrument is deposited in a fund that will be used to pay debt service on refunded securities.
    /// </summary>
    [IsoId("_5XPdrwgTEe2fOITqoTnSLQ")]
    [DisplayName("Pre Funded Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreFnddInd")]
    #endif
    [IsoXmlTag("PreFnddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PreFundedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreFundedIndicator { get; init; } 
    #else
    public System.String? PreFundedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether an interest bearing instrument is being escrowed or collateralized either by direct obligations guaranteed by the US government, or by other types of securities. The maturity schedules of the securities in the escrow fund are determined in such a way to pay the maturity value, coupon, and premium payments (if any) of the refunded bonds.
    /// </summary>
    [IsoId("_5XPdsQgTEe2fOITqoTnSLQ")]
    [DisplayName("Escrowed Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EscrwdInd")]
    #endif
    [IsoXmlTag("EscrwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? EscrowedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EscrowedIndicator { get; init; } 
    #else
    public System.String? EscrowedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the security has no maturity date.
    /// </summary>
    [IsoId("_5XPdswgTEe2fOITqoTnSLQ")]
    [DisplayName("Perpetual Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PerptlInd")]
    #endif
    [IsoXmlTag("PerptlInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PerpetualIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PerpetualIndicator { get; init; } 
    #else
    public System.String? PerpetualIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
