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
[IsoId("_U4qWFdp-Ed-ak6NoX_4Aeg_-44720744")]
[DisplayName("Unit Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnitPrice6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnitPrice6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnitPrice6( PriceType2 reqType,System.String reqForExecutionIndicator,System.String reqCumDividendIndicator )
    {
        Type = reqType;
        ForExecutionIndicator = reqForExecutionIndicator;
        CumDividendIndicator = reqCumDividendIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_U4qWFtp-Ed-ak6NoX_4Aeg_-44720725")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceType2 Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceType2 Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceType2 Type { get; init; } 
    #else
    public PriceType2 Type { get; set; } 
    #endif
    
    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_U4qWF9p-Ed-ak6NoX_4Aeg_-44720701")]
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
    [IsoId("_U4qWGNp-Ed-ak6NoX_4Aeg_-44720684")]
    [DisplayName("Value In Investment Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValInInvstmtCcy")]
    #endif
    [IsoXmlTag("ValInInvstmtCcy")]
    public ValueList<PriceValue1> ValueInInvestmentCurrency { get; init; } = new ValueList<PriceValue1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _U4qWGNp-Ed-ak6NoX_4Aeg_-44720684
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_U4qWGdp-Ed-ak6NoX_4Aeg_-44720418")]
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
    [IsoId("_U40HENp-Ed-ak6NoX_4Aeg_-44720393")]
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
    [IsoId("_U40HEdp-Ed-ak6NoX_4Aeg_-44720358")]
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
    [IsoId("_U40HEtp-Ed-ak6NoX_4Aeg_-144399643")]
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
    /// Specifies the number of days from trade date that the counterparty on the other side of the trade should &quot;given up&quot; or divulged.
    /// </summary>
    [IsoId("_U40HE9p-Ed-ak6NoX_4Aeg_-168219132")]
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
    [IsoId("_U40HFNp-Ed-ak6NoX_4Aeg_-168218824")]
    [DisplayName("Taxable Income Per Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerShr")]
    #endif
    [IsoXmlTag("TaxblIncmPerShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountPrice1Choice_? TaxableIncomePerShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountPrice1Choice_? TaxableIncomePerShare { get; init; } 
    #else
    public AmountPrice1Choice_? TaxableIncomePerShare { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_U40HFdp-Ed-ak6NoX_4Aeg_-514208777")]
    [DisplayName("Taxable Income Per Share Calculated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerShrClctd")]
    #endif
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxableIncomePerShareCalculated1? TaxableIncomePerShareCalculated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxableIncomePerShareCalculated1? TaxableIncomePerShareCalculated { get; init; } 
    #else
    public TaxableIncomePerShareCalculated1? TaxableIncomePerShareCalculated { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_U40HFtp-Ed-ak6NoX_4Aeg_-44720322")]
    [DisplayName("Charge Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgDtls")]
    #endif
    [IsoXmlTag("ChrgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge9? ChargeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge9? ChargeDetails { get; init; } 
    #else
    public Charge9? ChargeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to taxes that are due.
    /// </summary>
    [IsoId("_U40HF9p-Ed-ak6NoX_4Aeg_-44720297")]
    [DisplayName("Tax Liability Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxLbltyDtls")]
    #endif
    [IsoXmlTag("TaxLbltyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax8? TaxLiabilityDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax8? TaxLiabilityDetails { get; init; } 
    #else
    public Tax8? TaxLiabilityDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to taxes that are paid back.
    /// </summary>
    [IsoId("_U40HGNp-Ed-ak6NoX_4Aeg_-626866032")]
    [DisplayName("Tax Refund Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRfndDtls")]
    #endif
    [IsoXmlTag("TaxRfndDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax8? TaxRefundDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax8? TaxRefundDetails { get; init; } 
    #else
    public Tax8? TaxRefundDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
