// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the tax voucher.
/// </summary>
[IsoId("_UB00vtp-Ed-ak6NoX_4Aeg_2027853243")]
[DisplayName("Tax Voucher")]
public partial record TaxVoucher1
{
    #nullable enable
    
    /// <summary>
    /// Distribution rate per share.
    /// </summary>
    [IsoId("_UB-lsNp-Ed-ak6NoX_4Aeg_-2044813732")]
    [DisplayName("Tax Voucher Rate")]
    [IsoXmlTag("TaxVchrRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate TaxVoucherRate { get; init; } 
    
    /// <summary>
    /// Amount of tax that have been previously paid.
    /// </summary>
    [IsoId("_UB-lsdp-Ed-ak6NoX_4Aeg_-877092967")]
    [DisplayName("Tax Credit")]
    [IsoXmlTag("TaxCdt")]
    public required ActiveCurrencyAndAmount TaxCredit { get; init; } 
    
    /// <summary>
    /// Amount of tax that have been previously deducted.
    /// </summary>
    [IsoId("_UB-lstp-Ed-ak6NoX_4Aeg_-1198867220")]
    [DisplayName("Tax Deduction")]
    [IsoXmlTag("TaxDdctn")]
    public required ActiveCurrencyAndAmount TaxDeduction { get; init; } 
    
    /// <summary>
    /// Cash amount before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_UB-ls9p-Ed-ak6NoX_4Aeg_-1668939190")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public required ActiveCurrencyAndAmount GrossAmount { get; init; } 
    
    /// <summary>
    /// Cash amount after any deductions and allowances have been made.
    /// </summary>
    [IsoId("_UB-ltNp-Ed-ak6NoX_4Aeg_-1616299971")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public required ActiveCurrencyAndAmount NetAmount { get; init; } 
    
    /// <summary>
    /// Securities holding on record date.
    /// </summary>
    [IsoId("_UB-ltdp-Ed-ak6NoX_4Aeg_-1541494395")]
    [DisplayName("Record Date Holding")]
    [IsoXmlTag("RcrdDtHldg")]
    public required UnitOrFaceAmount1Choice_ RecordDateHolding { get; init; } 
    
    /// <summary>
    /// Applicable tax rate on the tax credit amount.
    /// </summary>
    [IsoId("_UB-lttp-Ed-ak6NoX_4Aeg_-1126831006")]
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TaxCreditRate { get; init; } 
    
    /// <summary>
    /// Cash amount that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_UB-lt9p-Ed-ak6NoX_4Aeg_-829458124")]
    [DisplayName("Withholding Tax Amount")]
    [IsoXmlTag("WhldgTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    
    /// <summary>
    /// Rate of a cash distribution that wil be withheld by a tax authority.
    /// </summary>
    [IsoId("_UB-luNp-Ed-ak6NoX_4Aeg_-713094105")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? WithholdingTaxRate { get; init; } 
    
    /// <summary>
    /// Cost per share of new shares allotted.
    /// </summary>
    [IsoId("_UB-ludp-Ed-ak6NoX_4Aeg_1421163033")]
    [DisplayName("Scrip Dividend Reinvestment Price Per Share")]
    [IsoXmlTag("ScripDvddRinvstmtPricPerShr")]
    public PriceValue1? ScripDividendReinvestmentPricePerShare { get; init; } 
    
    /// <summary>
    /// Cash amount retained from previous dividend or interest payment.
    /// </summary>
    [IsoId("_UCHvoNp-Ed-ak6NoX_4Aeg_1493196653")]
    [DisplayName("Cash Amount Brought Forward")]
    [IsoXmlTag("CshAmtBrghtFwd")]
    public ActiveCurrencyAndAmount? CashAmountBroughtForward { get; init; } 
    
    /// <summary>
    /// Total cash amount required to purchase shares allotted.
    /// </summary>
    [IsoId("_UCHvodp-Ed-ak6NoX_4Aeg_1566152884")]
    [DisplayName("Alloted Shares Cost")]
    [IsoXmlTag("AlltdShrsCost")]
    public PriceValue1? AllotedSharesCost { get; init; } 
    
    /// <summary>
    /// Cash amount carried forward to next dividend or interest payment.
    /// </summary>
    [IsoId("_UCHvotp-Ed-ak6NoX_4Aeg_872324890")]
    [DisplayName("Cash Amount Carried Forward")]
    [IsoXmlTag("CshAmtCrrdFwd")]
    public ActiveCurrencyAndAmount? CashAmountCarriedForward { get; init; } 
    
    /// <summary>
    /// Where new securities are issued in lieu of a cash dividend, the notional tax is the tax on the amount of cash that would have been paid. For scrips only.
    /// </summary>
    [IsoId("_UCHvo9p-Ed-ak6NoX_4Aeg_959135599")]
    [DisplayName("Notional Tax")]
    [IsoXmlTag("NtnlTax")]
    public ActiveCurrencyAndAmount? NotionalTax { get; init; } 
    
    /// <summary>
    /// Amount of cash that would have been payable if the dividend had been taken in the form of cash rather than shares. For scrip only.
    /// </summary>
    [IsoId("_UCHvpNp-Ed-ak6NoX_4Aeg_1243580576")]
    [DisplayName("Notional Dividend Payable")]
    [IsoXmlTag("NtnlDvddPybl")]
    public ActiveCurrencyAndAmount? NotionalDividendPayable { get; init; } 
    
    /// <summary>
    /// Date on which DRIP purchase completed.
    /// </summary>
    [IsoId("_UCHvpdp-Ed-ak6NoX_4Aeg_1300836961")]
    [DisplayName("Bargain Date")]
    [IsoXmlTag("BrgnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BargainDate { get; init; } 
    
    /// <summary>
    /// Settlement date of the DRIP purchase transaction.
    /// </summary>
    [IsoId("_UCHvptp-Ed-ak6NoX_4Aeg_1320230438")]
    [DisplayName("Bargain Settlement Date")]
    [IsoXmlTag("BrgnSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BargainSettlementDate { get; init; } 
    
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_UCHvp9p-Ed-ak6NoX_4Aeg_1378415220")]
    [DisplayName("Stamp Duty Amount")]
    [IsoXmlTag("StmpDtyAmt")]
    public ActiveCurrencyAndAmount? StampDutyAmount { get; init; } 
    
    /// <summary>
    /// Amount of charges/fees charged to the client.
    /// </summary>
    [IsoId("_UCHvqNp-Ed-ak6NoX_4Aeg_1422744340")]
    [DisplayName("Charge Amount")]
    [IsoXmlTag("ChrgAmt")]
    public ActiveCurrencyAndAmount? ChargeAmount { get; init; } 
    
    /// <summary>
    /// Amount due to the paying agent.
    /// </summary>
    [IsoId("_UCHvqdp-Ed-ak6NoX_4Aeg_1452297040")]
    [DisplayName("Commission Amount")]
    [IsoXmlTag("ComssnAmt")]
    public ActiveCurrencyAndAmount? CommissionAmount { get; init; } 
    
    /// <summary>
    /// Provides information about the foreign exchange transaction.
    /// </summary>
    [IsoId("_UCRgoNp-Ed-ak6NoX_4Aeg_583807128")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms9? ForeignExchangeDetails { get; init; } 
    
    
    #nullable disable
    
}
