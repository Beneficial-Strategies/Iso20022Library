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
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_QelXdtp-Ed-ak6NoX_4Aeg_116968013")]
[DisplayName("Unit Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnitPrice15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnitPrice15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnitPrice15( TypeOfPrice9Code reqType,System.String reqExtendedType,System.String reqForExecutionIndicator,System.String reqCumDividendIndicator,System.String reqEstimatedPriceIndicator )
    {
        Type = reqType;
        ExtendedType = reqExtendedType;
        ForExecutionIndicator = reqForExecutionIndicator;
        CumDividendIndicator = reqCumDividendIndicator;
        EstimatedPriceIndicator = reqEstimatedPriceIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_QelXd9p-Ed-ak6NoX_4Aeg_116968049")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfPrice9Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfPrice9Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice9Code Type { get; init; } 
    #else
    public TypeOfPrice9Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_QelXeNp-Ed-ak6NoX_4Aeg_-1035184327")]
    [DisplayName("Extended Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedTp")]
    #endif
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedType { get; init; } 
    #else
    public System.String ExtendedType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_QeuhYNp-Ed-ak6NoX_4Aeg_116968125")]
    [DisplayName("Price Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricMtd")]
    #endif
    [IsoXmlTag("PricMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceMethod1Code? PriceMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceMethod1Code? PriceMethod { get; init; } 
    #else
    public PriceMethod1Code? PriceMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_QeuhYdp-Ed-ak6NoX_4Aeg_116968420")]
    [DisplayName("Value In Investment Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValInInvstmtCcy")]
    #endif
    [IsoXmlTag("ValInInvstmtCcy")]
    public ValueList<PriceValue1> ValueInInvestmentCurrency { get; init; } = new ValueList<PriceValue1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _QeuhYdp-Ed-ak6NoX_4Aeg_116968420
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_QeuhYtp-Ed-ak6NoX_4Aeg_116968480")]
    [DisplayName("Value In Alternative Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValInAltrntvCcy")]
    #endif
    [IsoXmlTag("ValInAltrntvCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue1? ValueInAlternativeCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue1? ValueInAlternativeCurrency { get; init; } 
    #else
    public PriceValue1? ValueInAlternativeCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the price information can be used for the execution of a transaction.
    /// </summary>
    [IsoId("_QeuhY9p-Ed-ak6NoX_4Aeg_116968557")]
    [DisplayName("For Execution Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ForExctnInd")]
    #endif
    [IsoXmlTag("ForExctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ForExecutionIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ForExecutionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ForExecutionIndicator { get; init; } 
    #else
    public System.String ForExecutionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    [IsoId("_QeuhZNp-Ed-ak6NoX_4Aeg_116968883")]
    [DisplayName("Cum Dividend Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CumDvddInd")]
    #endif
    [IsoXmlTag("CumDvddInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CumDividendIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CumDividendIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CumDividendIndicator { get; init; } 
    #else
    public System.String CumDividendIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Ratio applied on the non-adjusted price.
    /// </summary>
    [IsoId("_QeuhZdp-Ed-ak6NoX_4Aeg_116968944")]
    [DisplayName("Calculation Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnBsis")]
    #endif
    [IsoXmlTag("ClctnBsis")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? CalculationBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CalculationBasis { get; init; } 
    #else
    public System.Decimal? CalculationBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the price is an estimated price.
    /// </summary>
    [IsoId("_QeuhZtp-Ed-ak6NoX_4Aeg_240626510")]
    [DisplayName("Estimated Price Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdPricInd")]
    #endif
    [IsoXmlTag("EstmtdPricInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator EstimatedPriceIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EstimatedPriceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EstimatedPriceIndicator { get; init; } 
    #else
    public System.String EstimatedPriceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of days from trade date that the counterparty on the other side of the trade should &quot;given up&quot; or divulged.
    /// </summary>
    [IsoId("_QeuhZ9p-Ed-ak6NoX_4Aeg_116969021")]
    [DisplayName("Number Of Days Accrued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDaysAcrd")]
    #endif
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfDaysAccrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfDaysAccrued { get; init; } 
    #else
    public System.UInt64? NumberOfDaysAccrued { get; set; } 
    #endif
    
    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_QeuhaNp-Ed-ak6NoX_4Aeg_116969074")]
    [DisplayName("Taxable Income Per Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerShr")]
    #endif
    [IsoXmlTag("TaxblIncmPerShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_Qeuhadp-Ed-ak6NoX_4Aeg_116969376")]
    [DisplayName("Taxable Income Per Share Calculated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerShrClctd")]
    #endif
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; init; } 
    #else
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_Qe4SYNp-Ed-ak6NoX_4Aeg_911625097")]
    [DisplayName("Extended Taxable Income Per Share Calculated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedTaxblIncmPerShrClctd")]
    #endif
    [IsoXmlTag("XtndedTaxblIncmPerShrClctd")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedTaxableIncomePerShareCalculated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedTaxableIncomePerShareCalculated { get; init; } 
    #else
    public System.String? ExtendedTaxableIncomePerShareCalculated { get; set; } 
    #endif
    
    /// <summary>
    /// Amount included in the dividend that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_Qe4SYdp-Ed-ak6NoX_4Aeg_-450781721")]
    [DisplayName("Taxable Income Per Dividend")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerDvdd")]
    #endif
    [IsoXmlTag("TaxblIncmPerDvdd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? TaxableIncomePerDividend { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? TaxableIncomePerDividend { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? TaxableIncomePerDividend { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_Qe4SYtp-Ed-ak6NoX_4Aeg_-107228916")]
    [DisplayName("EU Dividend Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EUDvddSts")]
    #endif
    [IsoXmlTag("EUDvddSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EUDividendStatus1Code? EUDividendStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EUDividendStatus1Code? EUDividendStatus { get; init; } 
    #else
    public EUDividendStatus1Code? EUDividendStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_Qe4SY9p-Ed-ak6NoX_4Aeg_1319885059")]
    [DisplayName("Extended EU Dividend Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedEUDvddSts")]
    #endif
    [IsoXmlTag("XtndedEUDvddSts")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedEUDividendStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedEUDividendStatus { get; init; } 
    #else
    public System.String? ExtendedEUDividendStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_Qe4SZNp-Ed-ak6NoX_4Aeg_116969935")]
    [DisplayName("Charge Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgDtls")]
    #endif
    [IsoXmlTag("ChrgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge15? ChargeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge15? ChargeDetails { get; init; } 
    #else
    public Charge15? ChargeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to taxes that are due.
    /// </summary>
    [IsoId("_Qe4SZdp-Ed-ak6NoX_4Aeg_1606728234")]
    [DisplayName("Tax Liability Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxLbltyDtls")]
    #endif
    [IsoXmlTag("TaxLbltyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax17? TaxLiabilityDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax17? TaxLiabilityDetails { get; init; } 
    #else
    public Tax17? TaxLiabilityDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to taxes that are paid back.
    /// </summary>
    [IsoId("_Qe4SZtp-Ed-ak6NoX_4Aeg_1615962093")]
    [DisplayName("Tax Refund Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRfndDtls")]
    #endif
    [IsoXmlTag("TaxRfndDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax17? TaxRefundDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax17? TaxRefundDetails { get; init; } 
    #else
    public Tax17? TaxRefundDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
