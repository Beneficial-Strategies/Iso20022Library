// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies amounts in the framework of a corporate action event.
/// </summary>
[IsoId("_99kH4WXlEeWht50_j0HXAQ")]
[DisplayName("Corporate Action Amounts")]
public record CorporateActionAmounts38
{
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_-RzSg2XlEeWht50_j0HXAQ")]
    [DisplayName("Gross Cash Amount")]
    [IsoXmlTag("GrssCshAmt")]
    public ActiveCurrencyAndAmount? GrossCashAmount { get; init; }

    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_-RzSi2XlEeWht50_j0HXAQ")]
    [DisplayName("Net Cash Amount")]
    [IsoXmlTag("NetCshAmt")]
    public ActiveCurrencyAndAmount? NetCashAmount { get; init; }

    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fees.
    /// </summary>
    [IsoId("_-RzSk2XlEeWht50_j0HXAQ")]
    [DisplayName("Solicitation Fees")]
    [IsoXmlTag("SlctnFees")]
    public ActiveCurrencyAndAmount? SolicitationFees { get; init; }

    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_-RzSm2XlEeWht50_j0HXAQ")]
    [DisplayName("Cash In Lieu Of Share")]
    [IsoXmlTag("CshInLieuOfShr")]
    public ActiveCurrencyAndAmount? CashInLieuOfShare { get; init; }

    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [IsoId("_-RzSo2XlEeWht50_j0HXAQ")]
    [DisplayName("Capital Gain")]
    [IsoXmlTag("CptlGn")]
    public ActiveCurrencyAndAmount? CapitalGain { get; init; }

    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    [IsoId("_-RzSq2XlEeWht50_j0HXAQ")]
    [DisplayName("Interest Amount")]
    [IsoXmlTag("IntrstAmt")]
    public ActiveCurrencyAndAmount? InterestAmount { get; init; }

    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    [IsoId("_-RzSs2XlEeWht50_j0HXAQ")]
    [DisplayName("Market Claim Amount")]
    [IsoXmlTag("MktClmAmt")]
    public ActiveCurrencyAndAmount? MarketClaimAmount { get; init; }

    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    [IsoId("_-RzSu2XlEeWht50_j0HXAQ")]
    [DisplayName("Indemnity Amount")]
    [IsoXmlTag("IndmntyAmt")]
    public ActiveCurrencyAndAmount? IndemnityAmount { get; init; }

    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender. Also covers compensation/indemnity of missed dividend concerning early/late settlements if applicable to a market.
    /// </summary>
    [IsoId("_-RzSw2XlEeWht50_j0HXAQ")]
    [DisplayName("Manufactured Dividend Payment Amount")]
    [IsoXmlTag("ManfctrdDvddPmtAmt")]
    public ActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; }

    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [IsoId("_-RzSxWXlEeWht50_j0HXAQ")]
    [DisplayName("Reinvestment Amount")]
    [IsoXmlTag("RinvstmtAmt")]
    public ActiveCurrencyAndAmount? ReinvestmentAmount { get; init; }

    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [IsoId("_-RzSzWXlEeWht50_j0HXAQ")]
    [DisplayName("Fully Franked Amount")]
    [IsoXmlTag("FullyFrnkdAmt")]
    public ActiveCurrencyAndAmount? FullyFrankedAmount { get; init; }

    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    [IsoId("_-RzS1WXlEeWht50_j0HXAQ")]
    [DisplayName("Unfranked Amount")]
    [IsoXmlTag("UfrnkdAmt")]
    public ActiveCurrencyAndAmount? UnfrankedAmount { get; init; }

    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_-RzS3WXlEeWht50_j0HXAQ")]
    [DisplayName("Sundry Or Other Amount")]
    [IsoXmlTag("SndryOrOthrAmt")]
    public ActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; }

    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_-RzS5WXlEeWht50_j0HXAQ")]
    [DisplayName("Tax Free Amount")]
    [IsoXmlTag("TaxFreeAmt")]
    public ActiveCurrencyAndAmount? TaxFreeAmount { get; init; }

    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_-RzS7WXlEeWht50_j0HXAQ")]
    [DisplayName("Tax Deferred Amount")]
    [IsoXmlTag("TaxDfrrdAmt")]
    public ActiveCurrencyAndAmount? TaxDeferredAmount { get; init; }

    /// <summary>
    /// Amount of value added tax.
    /// </summary>
    [IsoId("_-RzS9WXlEeWht50_j0HXAQ")]
    [DisplayName("Value Added Tax Amount")]
    [IsoXmlTag("ValAddedTaxAmt")]
    public ActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; }

    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_-RzS_WXlEeWht50_j0HXAQ")]
    [DisplayName("Stamp Duty Amount")]
    [IsoXmlTag("StmpDtyAmt")]
    public ActiveCurrencyAndAmount? StampDutyAmount { get; init; }

    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_-RzTBWXlEeWht50_j0HXAQ")]
    [DisplayName("Tax Reclaim Amount")]
    [IsoXmlTag("TaxRclmAmt")]
    public ActiveCurrencyAndAmount? TaxReclaimAmount { get; init; }

    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    [IsoId("_-RzTDWXlEeWht50_j0HXAQ")]
    [DisplayName("Tax Credit Amount")]
    [IsoXmlTag("TaxCdtAmt")]
    public ActiveCurrencyAndAmount? TaxCreditAmount { get; init; }

    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    [IsoId("_-RzTJWXlEeWht50_j0HXAQ")]
    [DisplayName("Additional Tax Amount")]
    [IsoXmlTag("AddtlTaxAmt")]
    public ActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; }

    /// <summary>
    /// Amount of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_-RzTLWXlEeWht50_j0HXAQ")]
    [DisplayName("Withholding Tax Amount")]
    [IsoXmlTag("WhldgTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of money withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_NUi48WXmEeWht50_j0HXAQ")]
    [DisplayName("Second Level Tax Amount")]
    [IsoXmlTag("ScndLvlTaxAmt")]
    public ActiveCurrencyAndAmount? SecondLevelTaxAmount { get; init; }

    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    [IsoId("_-RzTNWXlEeWht50_j0HXAQ")]
    [DisplayName("Fiscal Stamp Amount")]
    [IsoXmlTag("FsclStmpAmt")]
    public ActiveCurrencyAndAmount? FiscalStampAmount { get; init; }

    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_-RzTPWXlEeWht50_j0HXAQ")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public ActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    [IsoId("_-RzTRWXlEeWht50_j0HXAQ")]
    [DisplayName("Paying Agent Commission Amount")]
    [IsoXmlTag("PngAgtComssnAmt")]
    public ActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; }

    /// <summary>
    /// Local broker&apos;s commission.
    /// </summary>
    [IsoId("_-RzTTWXlEeWht50_j0HXAQ")]
    [DisplayName("Local Broker Commission Amount")]
    [IsoXmlTag("LclBrkrComssnAmt")]
    public ActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; }

    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, securities and exchange fees.
    /// </summary>
    [IsoId("_-RzTVWXlEeWht50_j0HXAQ")]
    [DisplayName("Regulatory Fees Amount")]
    [IsoXmlTag("RgltryFeesAmt")]
    public ActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; }

    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [IsoId("_-RzTXWXlEeWht50_j0HXAQ")]
    [DisplayName("Shipping Fees Amount")]
    [IsoXmlTag("ShppgFeesAmt")]
    public ActiveCurrencyAndAmount? ShippingFeesAmount { get; init; }

    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_-RzTZWXlEeWht50_j0HXAQ")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public ActiveCurrencyAndAmount? ChargesAmount { get; init; }

    /// <summary>
    /// Cash amount based on terms of corporate action event and balance of underlying securities, entitled to/from account owner (which may be positive or negative).
    /// </summary>
    [IsoId("_-RzTbWXlEeWht50_j0HXAQ")]
    [DisplayName("Entitled Amount")]
    [IsoXmlTag("EntitldAmt")]
    public ActiveCurrencyAndAmount? EntitledAmount { get; init; }

    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_-RzTdWXlEeWht50_j0HXAQ")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public ActiveCurrencyAndAmount? OriginalAmount { get; init; }

    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_-RzTfWXlEeWht50_j0HXAQ")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public ActiveCurrencyAndAmount? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    [IsoId("_-RzThWXlEeWht50_j0HXAQ")]
    [DisplayName("Income Portion")]
    [IsoXmlTag("IncmPrtn")]
    public ActiveCurrencyAndAmount? IncomePortion { get; init; }

    /// <summary>
    /// Portion of the fund distribution amount which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_-RzTjWXlEeWht50_j0HXAQ")]
    [DisplayName("Equalisation Amount")]
    [IsoXmlTag("EqulstnAmt")]
    public ActiveCurrencyAndAmount? EqualisationAmount { get; init; }

    /// <summary>
    /// FATCA (Foreign Account Tax Compliance Act) related tax amount.
    /// </summary>
    [IsoId("_-RzTj2XlEeWht50_j0HXAQ")]
    [DisplayName("FATCA Tax Amount")]
    [IsoXmlTag("FATCATaxAmt")]
    public ActiveCurrencyAndAmount? FATCATaxAmount { get; init; }

    /// <summary>
    /// Amount of tax related income subject to NRA (Non Resident Alien).
    /// </summary>
    [IsoId("_-RzTkWXlEeWht50_j0HXAQ")]
    [DisplayName("NRA Tax Amount")]
    [IsoXmlTag("NRATaxAmt")]
    public ActiveCurrencyAndAmount? NRATaxAmount { get; init; }

    /// <summary>
    /// Amount of tax related to back up withholding.
    /// </summary>
    [IsoId("_-RzTk2XlEeWht50_j0HXAQ")]
    [DisplayName("Back Up Withholding Tax Amount")]
    [IsoXmlTag("BckUpWhldgTaxAmt")]
    public ActiveCurrencyAndAmount? BackUpWithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_-RzTlWXlEeWht50_j0HXAQ")]
    [DisplayName("Tax On Income Amount")]
    [IsoXmlTag("TaxOnIncmAmt")]
    public ActiveCurrencyAndAmount? TaxOnIncomeAmount { get; init; }

    /// <summary>
    /// Amount of Transaction tax.
    /// </summary>
    [IsoId("_-RzTl2XlEeWht50_j0HXAQ")]
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public ActiveCurrencyAndAmount? TransactionTax { get; init; }
}
