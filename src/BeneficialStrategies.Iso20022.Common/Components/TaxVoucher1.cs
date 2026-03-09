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
/// Provides information about the tax voucher.
/// </summary>
[IsoId("_UB00vtp-Ed-ak6NoX_4Aeg_2027853243")]
[DisplayName("Tax Voucher")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxVoucher1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TaxVoucher1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TaxVoucher1( System.Decimal reqTaxVoucherRate,ActiveCurrencyAndAmount reqTaxCredit,ActiveCurrencyAndAmount reqTaxDeduction,ActiveCurrencyAndAmount reqGrossAmount,ActiveCurrencyAndAmount reqNetAmount,UnitOrFaceAmount1Choice_ reqRecordDateHolding )
    {
        TaxVoucherRate = reqTaxVoucherRate;
        TaxCredit = reqTaxCredit;
        TaxDeduction = reqTaxDeduction;
        GrossAmount = reqGrossAmount;
        NetAmount = reqNetAmount;
        RecordDateHolding = reqRecordDateHolding;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Distribution rate per share.
    /// </summary>
    [IsoId("_UB-lsNp-Ed-ak6NoX_4Aeg_-2044813732")]
    [DisplayName("Tax Voucher Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxVchrRate")]
    #endif
    [IsoXmlTag("TaxVchrRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBaseOneRate TaxVoucherRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal TaxVoucherRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal TaxVoucherRate { get; init; } 
    #else
    public System.Decimal TaxVoucherRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of tax that have been previously paid.
    /// </summary>
    [IsoId("_UB-lsdp-Ed-ak6NoX_4Aeg_-877092967")]
    [DisplayName("Tax Credit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCdt")]
    #endif
    [IsoXmlTag("TaxCdt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TaxCredit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TaxCredit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TaxCredit { get; init; } 
    #else
    public ActiveCurrencyAndAmount TaxCredit { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of tax that have been previously deducted.
    /// </summary>
    [IsoId("_UB-lstp-Ed-ak6NoX_4Aeg_-1198867220")]
    [DisplayName("Tax Deduction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDdctn")]
    #endif
    [IsoXmlTag("TaxDdctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TaxDeduction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TaxDeduction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TaxDeduction { get; init; } 
    #else
    public ActiveCurrencyAndAmount TaxDeduction { get; set; } 
    #endif
    
    /// <summary>
    /// Cash amount before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_UB-ls9p-Ed-ak6NoX_4Aeg_-1668939190")]
    [DisplayName("Gross Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssAmt")]
    #endif
    [IsoXmlTag("GrssAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount GrossAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount GrossAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount GrossAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount GrossAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Cash amount after any deductions and allowances have been made.
    /// </summary>
    [IsoId("_UB-ltNp-Ed-ak6NoX_4Aeg_-1616299971")]
    [DisplayName("Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetAmt")]
    #endif
    [IsoXmlTag("NetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount NetAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount NetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount NetAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount NetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Securities holding on record date.
    /// </summary>
    [IsoId("_UB-ltdp-Ed-ak6NoX_4Aeg_-1541494395")]
    [DisplayName("Record Date Holding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrdDtHldg")]
    #endif
    [IsoXmlTag("RcrdDtHldg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOrFaceAmount1Choice_ RecordDateHolding { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOrFaceAmount1Choice_ RecordDateHolding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_ RecordDateHolding { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_ RecordDateHolding { get; set; } 
    #endif
    
    /// <summary>
    /// Applicable tax rate on the tax credit amount.
    /// </summary>
    [IsoId("_UB-lttp-Ed-ak6NoX_4Aeg_-1126831006")]
    [DisplayName("Tax Credit Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxCdtRate")]
    #endif
    [IsoXmlTag("TaxCdtRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TaxCreditRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxCreditRate { get; init; } 
    #else
    public System.Decimal? TaxCreditRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash amount that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_UB-lt9p-Ed-ak6NoX_4Aeg_-829458124")]
    [DisplayName("Withholding Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTaxAmt")]
    #endif
    [IsoXmlTag("WhldgTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of a cash distribution that wil be withheld by a tax authority.
    /// </summary>
    [IsoId("_UB-luNp-Ed-ak6NoX_4Aeg_-713094105")]
    [DisplayName("Withholding Tax Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTaxRate")]
    #endif
    [IsoXmlTag("WhldgTaxRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? WithholdingTaxRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? WithholdingTaxRate { get; init; } 
    #else
    public System.Decimal? WithholdingTaxRate { get; set; } 
    #endif
    
    /// <summary>
    /// Cost per share of new shares allotted.
    /// </summary>
    [IsoId("_UB-ludp-Ed-ak6NoX_4Aeg_1421163033")]
    [DisplayName("Scrip Dividend Reinvestment Price Per Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScripDvddRinvstmtPricPerShr")]
    #endif
    [IsoXmlTag("ScripDvddRinvstmtPricPerShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue1? ScripDividendReinvestmentPricePerShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue1? ScripDividendReinvestmentPricePerShare { get; init; } 
    #else
    public PriceValue1? ScripDividendReinvestmentPricePerShare { get; set; } 
    #endif
    
    /// <summary>
    /// Cash amount retained from previous dividend or interest payment.
    /// </summary>
    [IsoId("_UCHvoNp-Ed-ak6NoX_4Aeg_1493196653")]
    [DisplayName("Cash Amount Brought Forward")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAmtBrghtFwd")]
    #endif
    [IsoXmlTag("CshAmtBrghtFwd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CashAmountBroughtForward { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CashAmountBroughtForward { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CashAmountBroughtForward { get; set; } 
    #endif
    
    /// <summary>
    /// Total cash amount required to purchase shares allotted.
    /// </summary>
    [IsoId("_UCHvodp-Ed-ak6NoX_4Aeg_1566152884")]
    [DisplayName("Alloted Shares Cost")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AlltdShrsCost")]
    #endif
    [IsoXmlTag("AlltdShrsCost")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceValue1? AllotedSharesCost { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValue1? AllotedSharesCost { get; init; } 
    #else
    public PriceValue1? AllotedSharesCost { get; set; } 
    #endif
    
    /// <summary>
    /// Cash amount carried forward to next dividend or interest payment.
    /// </summary>
    [IsoId("_UCHvotp-Ed-ak6NoX_4Aeg_872324890")]
    [DisplayName("Cash Amount Carried Forward")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAmtCrrdFwd")]
    #endif
    [IsoXmlTag("CshAmtCrrdFwd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CashAmountCarriedForward { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CashAmountCarriedForward { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CashAmountCarriedForward { get; set; } 
    #endif
    
    /// <summary>
    /// Where new securities are issued in lieu of a cash dividend, the notional tax is the tax on the amount of cash that would have been paid. For scrips only.
    /// </summary>
    [IsoId("_UCHvo9p-Ed-ak6NoX_4Aeg_959135599")]
    [DisplayName("Notional Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlTax")]
    #endif
    [IsoXmlTag("NtnlTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? NotionalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? NotionalTax { get; init; } 
    #else
    public ActiveCurrencyAndAmount? NotionalTax { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of cash that would have been payable if the dividend had been taken in the form of cash rather than shares. For scrip only.
    /// </summary>
    [IsoId("_UCHvpNp-Ed-ak6NoX_4Aeg_1243580576")]
    [DisplayName("Notional Dividend Payable")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlDvddPybl")]
    #endif
    [IsoXmlTag("NtnlDvddPybl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? NotionalDividendPayable { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? NotionalDividendPayable { get; init; } 
    #else
    public ActiveCurrencyAndAmount? NotionalDividendPayable { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which DRIP purchase completed.
    /// </summary>
    [IsoId("_UCHvpdp-Ed-ak6NoX_4Aeg_1300836961")]
    [DisplayName("Bargain Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrgnDt")]
    #endif
    [IsoXmlTag("BrgnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? BargainDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? BargainDate { get; init; } 
    #else
    public System.DateOnly? BargainDate { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement date of the DRIP purchase transaction.
    /// </summary>
    [IsoId("_UCHvptp-Ed-ak6NoX_4Aeg_1320230438")]
    [DisplayName("Bargain Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrgnSttlmDt")]
    #endif
    [IsoXmlTag("BrgnSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? BargainSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? BargainSettlementDate { get; init; } 
    #else
    public System.DateOnly? BargainSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_UCHvp9p-Ed-ak6NoX_4Aeg_1378415220")]
    [DisplayName("Stamp Duty Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDtyAmt")]
    #endif
    [IsoXmlTag("StmpDtyAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? StampDutyAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of charges/fees charged to the client.
    /// </summary>
    [IsoId("_UCHvqNp-Ed-ak6NoX_4Aeg_1422744340")]
    [DisplayName("Charge Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgAmt")]
    #endif
    [IsoXmlTag("ChrgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ChargeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ChargeAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ChargeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount due to the paying agent.
    /// </summary>
    [IsoId("_UCHvqdp-Ed-ak6NoX_4Aeg_1452297040")]
    [DisplayName("Commission Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnAmt")]
    #endif
    [IsoXmlTag("ComssnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CommissionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CommissionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CommissionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the foreign exchange transaction.
    /// </summary>
    [IsoId("_UCRgoNp-Ed-ak6NoX_4Aeg_583807128")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms9? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms9? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms9? ForeignExchangeDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
