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
[IsoId("_ckK7iZKQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Amounts")]
public record CorporateActionAmounts39
{
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_ckK7i5KQEeWHWpTQn1FFVg")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstngAmt")]
    public required RestrictedFINActiveCurrencyAndAmount PostingAmount { get; init; }

    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_ckK7k5KQEeWHWpTQn1FFVg")]
    [DisplayName("Gross Cash Amount")]
    [IsoXmlTag("GrssCshAmt")]
    public RestrictedFINActiveCurrencyAndAmount? GrossCashAmount { get; init; }

    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_ckK7m5KQEeWHWpTQn1FFVg")]
    [DisplayName("Net Cash Amount")]
    [IsoXmlTag("NetCshAmt")]
    public RestrictedFINActiveCurrencyAndAmount? NetCashAmount { get; init; }

    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fees.
    /// </summary>
    [IsoId("_ckK7o5KQEeWHWpTQn1FFVg")]
    [DisplayName("Solicitation Fees")]
    [IsoXmlTag("SlctnFees")]
    public RestrictedFINActiveCurrencyAndAmount? SolicitationFees { get; init; }

    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_ckK7q5KQEeWHWpTQn1FFVg")]
    [DisplayName("Cash In Lieu Of Share")]
    [IsoXmlTag("CshInLieuOfShr")]
    public RestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; }

    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [IsoId("_ckK7s5KQEeWHWpTQn1FFVg")]
    [DisplayName("Capital Gain")]
    [IsoXmlTag("CptlGn")]
    public RestrictedFINActiveCurrencyAndAmount? CapitalGain { get; init; }

    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    [IsoId("_ckK7u5KQEeWHWpTQn1FFVg")]
    [DisplayName("Interest Amount")]
    [IsoXmlTag("IntrstAmt")]
    public RestrictedFINActiveCurrencyAndAmount? InterestAmount { get; init; }

    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    [IsoId("_ckK7w5KQEeWHWpTQn1FFVg")]
    [DisplayName("Market Claim Amount")]
    [IsoXmlTag("MktClmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? MarketClaimAmount { get; init; }

    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    [IsoId("_ckK7y5KQEeWHWpTQn1FFVg")]
    [DisplayName("Indemnity Amount")]
    [IsoXmlTag("IndmntyAmt")]
    public RestrictedFINActiveCurrencyAndAmount? IndemnityAmount { get; init; }

    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender. Also covers compensation/indemnity of missed dividend concerning early/late settlements if applicable to a market.
    /// </summary>
    [IsoId("_ckK705KQEeWHWpTQn1FFVg")]
    [DisplayName("Manufactured Dividend Payment Amount")]
    [IsoXmlTag("ManfctrdDvddPmtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; }

    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [IsoId("_ckK71ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Reinvestment Amount")]
    [IsoXmlTag("RinvstmtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ReinvestmentAmount { get; init; }

    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [IsoId("_ckK73ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Fully Franked Amount")]
    [IsoXmlTag("FullyFrnkdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FullyFrankedAmount { get; init; }

    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    [IsoId("_ckK75ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Unfranked Amount")]
    [IsoXmlTag("UfrnkdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? UnfrankedAmount { get; init; }

    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_ckK77ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Sundry Or Other Amount")]
    [IsoXmlTag("SndryOrOthrAmt")]
    public RestrictedFINActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; }

    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_ckK79ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Tax Free Amount")]
    [IsoXmlTag("TaxFreeAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxFreeAmount { get; init; }

    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_ckK7_ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Tax Deferred Amount")]
    [IsoXmlTag("TaxDfrrdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxDeferredAmount { get; init; }

    /// <summary>
    /// Tax on value added.
    /// </summary>
    [IsoId("_ckK8BZKQEeWHWpTQn1FFVg")]
    [DisplayName("Value Added Tax Amount")]
    [IsoXmlTag("ValAddedTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; }

    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_ckK8DZKQEeWHWpTQn1FFVg")]
    [DisplayName("Stamp Duty Amount")]
    [IsoXmlTag("StmpDtyAmt")]
    public RestrictedFINActiveCurrencyAndAmount? StampDutyAmount { get; init; }

    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_ckK8FZKQEeWHWpTQn1FFVg")]
    [DisplayName("Tax Reclaim Amount")]
    [IsoXmlTag("TaxRclmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxReclaimAmount { get; init; }

    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    [IsoId("_ckK8HZKQEeWHWpTQn1FFVg")]
    [DisplayName("Tax Credit Amount")]
    [IsoXmlTag("TaxCdtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxCreditAmount { get; init; }

    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    [IsoId("_ckK8JZKQEeWHWpTQn1FFVg")]
    [DisplayName("Additional Tax Amount")]
    [IsoXmlTag("AddtlTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; }

    /// <summary>
    /// Amount of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_ckK8LZKQEeWHWpTQn1FFVg")]
    [DisplayName("Withholding Tax Amount")]
    [IsoXmlTag("WhldgTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of money withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_ckK8NZKQEeWHWpTQn1FFVg")]
    [DisplayName("Second Level Tax Amount")]
    [IsoXmlTag("ScndLvlTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? SecondLevelTaxAmount { get; init; }

    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    [IsoId("_ckK8N5KQEeWHWpTQn1FFVg")]
    [DisplayName("Fiscal Stamp Amount")]
    [IsoXmlTag("FsclStmpAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FiscalStampAmount { get; init; }

    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_ckK8P5KQEeWHWpTQn1FFVg")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    [IsoId("_ckK8R5KQEeWHWpTQn1FFVg")]
    [DisplayName("Paying Agent Commission Amount")]
    [IsoXmlTag("PngAgtComssnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; }

    /// <summary>
    /// Local broker&apos;s commission.
    /// </summary>
    [IsoId("_ckLiQZKQEeWHWpTQn1FFVg")]
    [DisplayName("Local Broker Commission Amount")]
    [IsoXmlTag("LclBrkrComssnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; }

    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_ckLiSZKQEeWHWpTQn1FFVg")]
    [DisplayName("Regulatory Fees Amount")]
    [IsoXmlTag("RgltryFeesAmt")]
    public RestrictedFINActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; }

    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [IsoId("_ckLiUZKQEeWHWpTQn1FFVg")]
    [DisplayName("Shipping Fees Amount")]
    [IsoXmlTag("ShppgFeesAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ShippingFeesAmount { get; init; }

    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_ckLiWZKQEeWHWpTQn1FFVg")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; init; }

    /// <summary>
    /// Indicates cash retained from previous dividend.
    /// </summary>
    [IsoId("_ckLiYZKQEeWHWpTQn1FFVg")]
    [DisplayName("Cash Amount Brought Forward")]
    [IsoXmlTag("CshAmtBrghtFwd")]
    public RestrictedFINActiveCurrencyAndAmount? CashAmountBroughtForward { get; init; }

    /// <summary>
    /// Indicates the balance carried forward to next dividend.
    /// </summary>
    [IsoId("_ckLiaZKQEeWHWpTQn1FFVg")]
    [DisplayName("Cash Amount Carried Forward")]
    [IsoXmlTag("CshAmtCrrdFwd")]
    public RestrictedFINActiveCurrencyAndAmount? CashAmountCarriedForward { get; init; }

    /// <summary>
    /// Amount of cash that would have been payable if the dividend had been taken in the form of cash rather than shares.
    /// </summary>
    [IsoId("_ckLicZKQEeWHWpTQn1FFVg")]
    [DisplayName("Notional Dividend Payable Amount")]
    [IsoXmlTag("NtnlDvddPyblAmt")]
    public RestrictedFINActiveCurrencyAndAmount? NotionalDividendPayableAmount { get; init; }

    /// <summary>
    /// Where new securities are issued in lieu of a cash dividend, the notional tax is the tax on the amount of cash that would have been paid.
    /// </summary>
    [IsoId("_ckLieZKQEeWHWpTQn1FFVg")]
    [DisplayName("Notional Tax Amount")]
    [IsoXmlTag("NtnlTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? NotionalTaxAmount { get; init; }

    /// <summary>
    /// Amount of money paid by the Tax Authorities in addition to the payment of the tax refund itself.
    /// </summary>
    [IsoId("_ckLigZKQEeWHWpTQn1FFVg")]
    [DisplayName("Tax Arrears Amount")]
    [IsoXmlTag("TaxArrearsAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxArrearsAmount { get; init; }

    /// <summary>
    /// Posting/settlement Amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_ckLiiZKQEeWHWpTQn1FFVg")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public RestrictedFINActiveCurrencyAndAmount? OriginalAmount { get; init; }

    /// <summary>
    /// Amount of money representing a distribution of a bond&apos;s principal, for example, repayment of outstanding debt.
    /// </summary>
    [IsoId("_ckLikZKQEeWHWpTQn1FFVg")]
    [DisplayName("Principal Or Corpus")]
    [IsoXmlTag("PrncplOrCrps")]
    public RestrictedFINActiveCurrencyAndAmount? PrincipalOrCorpus { get; init; }

    /// <summary>
    /// Amount of money (not interest) in addition to the principal at the redemption of a bond.
    /// </summary>
    [IsoId("_ckLimZKQEeWHWpTQn1FFVg")]
    [DisplayName("Redemption Premium Amount")]
    [IsoXmlTag("RedPrmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? RedemptionPremiumAmount { get; init; }

    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    [IsoId("_ckLioZKQEeWHWpTQn1FFVg")]
    [DisplayName("Income Portion")]
    [IsoXmlTag("IncmPrtn")]
    public RestrictedFINActiveCurrencyAndAmount? IncomePortion { get; init; }

    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_ckLiqZKQEeWHWpTQn1FFVg")]
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public RestrictedFINActiveCurrencyAndAmount? StockExchangeTax { get; init; }

    /// <summary>
    /// Total amount of tax withheld at source in conformance with the EU Savings Directive.
    /// </summary>
    [IsoId("_ckLisZKQEeWHWpTQn1FFVg")]
    [DisplayName("EU Tax Retention Amount")]
    [IsoXmlTag("EUTaxRtntnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? EUTaxRetentionAmount { get; init; }

    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_ckLiuZKQEeWHWpTQn1FFVg")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public RestrictedFINActiveCurrencyAndAmount? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Portion of the fund distribution amount which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_ckLiwZKQEeWHWpTQn1FFVg")]
    [DisplayName("Equalisation Amount")]
    [IsoXmlTag("EqulstnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? EqualisationAmount { get; init; }

    /// <summary>
    /// FATCA (Foreign Account Tax Compliance Act) related tax amount.
    /// </summary>
    [IsoId("_ckLiw5KQEeWHWpTQn1FFVg")]
    [DisplayName("FATCA Tax Amount")]
    [IsoXmlTag("FATCATaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FATCATaxAmount { get; init; }

    /// <summary>
    /// Amount of tax related income subject to NRA (Non Resident Alien).
    /// </summary>
    [IsoId("_ckLixZKQEeWHWpTQn1FFVg")]
    [DisplayName("NRA Tax Amount")]
    [IsoXmlTag("NRATaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? NRATaxAmount { get; init; }

    /// <summary>
    /// Amount of tax related to back up withholding.
    /// </summary>
    [IsoId("_ckLix5KQEeWHWpTQn1FFVg")]
    [DisplayName("Back Up Withholding Tax Amount")]
    [IsoXmlTag("BckUpWhldgTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? BackUpWithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_ckLiyZKQEeWHWpTQn1FFVg")]
    [DisplayName("Tax On Income Amount")]
    [IsoXmlTag("TaxOnIncmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxOnIncomeAmount { get; init; }

    /// <summary>
    /// Amount of Transaction tax.
    /// </summary>
    [IsoId("_ckLiy5KQEeWHWpTQn1FFVg")]
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public RestrictedFINActiveCurrencyAndAmount? TransactionTax { get; init; }
}
