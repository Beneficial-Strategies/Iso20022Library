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
[IsoId("_sk0TJc3wEee5nJBZsW8MFQ")]
[DisplayName("Corporate Action Amounts")]
public record CorporateActionAmounts45
{
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_sk0TKc3wEee5nJBZsW8MFQ")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstngAmt")]
    public required RestrictedFINActiveCurrencyAndAmount PostingAmount { get; init; }

    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_sk0TMc3wEee5nJBZsW8MFQ")]
    [DisplayName("Gross Cash Amount")]
    [IsoXmlTag("GrssCshAmt")]
    public RestrictedFINActiveCurrencyAndAmount? GrossCashAmount { get; init; }

    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_sk0TOc3wEee5nJBZsW8MFQ")]
    [DisplayName("Net Cash Amount")]
    [IsoXmlTag("NetCshAmt")]
    public RestrictedFINActiveCurrencyAndAmount? NetCashAmount { get; init; }

    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fees.
    /// </summary>
    [IsoId("_sk0TQc3wEee5nJBZsW8MFQ")]
    [DisplayName("Solicitation Fees")]
    [IsoXmlTag("SlctnFees")]
    public RestrictedFINActiveCurrencyAndAmount? SolicitationFees { get; init; }

    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_sk0TSc3wEee5nJBZsW8MFQ")]
    [DisplayName("Cash In Lieu Of Share")]
    [IsoXmlTag("CshInLieuOfShr")]
    public RestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; }

    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [IsoId("_sk0TUc3wEee5nJBZsW8MFQ")]
    [DisplayName("Capital Gain")]
    [IsoXmlTag("CptlGn")]
    public RestrictedFINActiveCurrencyAndAmount? CapitalGain { get; init; }

    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    [IsoId("_sk0TWc3wEee5nJBZsW8MFQ")]
    [DisplayName("Interest Amount")]
    [IsoXmlTag("IntrstAmt")]
    public RestrictedFINActiveCurrencyAndAmount? InterestAmount { get; init; }

    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    [IsoId("_sk0TYc3wEee5nJBZsW8MFQ")]
    [DisplayName("Market Claim Amount")]
    [IsoXmlTag("MktClmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? MarketClaimAmount { get; init; }

    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    [IsoId("_sk0Tac3wEee5nJBZsW8MFQ")]
    [DisplayName("Indemnity Amount")]
    [IsoXmlTag("IndmntyAmt")]
    public RestrictedFINActiveCurrencyAndAmount? IndemnityAmount { get; init; }

    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender. Also covers compensation/indemnity of missed dividend concerning early/late settlements if applicable to a market.
    /// </summary>
    [IsoId("_sk0Tcc3wEee5nJBZsW8MFQ")]
    [DisplayName("Manufactured Dividend Payment Amount")]
    [IsoXmlTag("ManfctrdDvddPmtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; }

    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [IsoId("_sk0Tc83wEee5nJBZsW8MFQ")]
    [DisplayName("Reinvestment Amount")]
    [IsoXmlTag("RinvstmtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ReinvestmentAmount { get; init; }

    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [IsoId("_sk0Te83wEee5nJBZsW8MFQ")]
    [DisplayName("Fully Franked Amount")]
    [IsoXmlTag("FullyFrnkdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FullyFrankedAmount { get; init; }

    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    [IsoId("_sk0Tg83wEee5nJBZsW8MFQ")]
    [DisplayName("Unfranked Amount")]
    [IsoXmlTag("UfrnkdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? UnfrankedAmount { get; init; }

    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_sk0Ti83wEee5nJBZsW8MFQ")]
    [DisplayName("Sundry Or Other Amount")]
    [IsoXmlTag("SndryOrOthrAmt")]
    public RestrictedFINActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; }

    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_sk0Tk83wEee5nJBZsW8MFQ")]
    [DisplayName("Tax Free Amount")]
    [IsoXmlTag("TaxFreeAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxFreeAmount { get; init; }

    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_sk0Tm83wEee5nJBZsW8MFQ")]
    [DisplayName("Tax Deferred Amount")]
    [IsoXmlTag("TaxDfrrdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxDeferredAmount { get; init; }

    /// <summary>
    /// Tax on value added.
    /// </summary>
    [IsoId("_sk0To83wEee5nJBZsW8MFQ")]
    [DisplayName("Value Added Tax Amount")]
    [IsoXmlTag("ValAddedTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; }

    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_sk0Tq83wEee5nJBZsW8MFQ")]
    [DisplayName("Stamp Duty Amount")]
    [IsoXmlTag("StmpDtyAmt")]
    public RestrictedFINActiveCurrencyAndAmount? StampDutyAmount { get; init; }

    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_sk0Ts83wEee5nJBZsW8MFQ")]
    [DisplayName("Tax Reclaim Amount")]
    [IsoXmlTag("TaxRclmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxReclaimAmount { get; init; }

    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    [IsoId("_sk0Tu83wEee5nJBZsW8MFQ")]
    [DisplayName("Tax Credit Amount")]
    [IsoXmlTag("TaxCdtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxCreditAmount { get; init; }

    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    [IsoId("_sk0Tw83wEee5nJBZsW8MFQ")]
    [DisplayName("Additional Tax Amount")]
    [IsoXmlTag("AddtlTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; }

    /// <summary>
    /// Amount of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_sk0Ty83wEee5nJBZsW8MFQ")]
    [DisplayName("Withholding Tax Amount")]
    [IsoXmlTag("WhldgTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of money withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_sk0T083wEee5nJBZsW8MFQ")]
    [DisplayName("Second Level Tax Amount")]
    [IsoXmlTag("ScndLvlTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? SecondLevelTaxAmount { get; init; }

    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    [IsoId("_sk0T1c3wEee5nJBZsW8MFQ")]
    [DisplayName("Fiscal Stamp Amount")]
    [IsoXmlTag("FsclStmpAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FiscalStampAmount { get; init; }

    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_sk05Yc3wEee5nJBZsW8MFQ")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    [IsoId("_sk05ac3wEee5nJBZsW8MFQ")]
    [DisplayName("Paying Agent Commission Amount")]
    [IsoXmlTag("PngAgtComssnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; }

    /// <summary>
    /// Local broker&apos;s commission.
    /// </summary>
    [IsoId("_sk05cc3wEee5nJBZsW8MFQ")]
    [DisplayName("Local Broker Commission Amount")]
    [IsoXmlTag("LclBrkrComssnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; }

    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_sk05ec3wEee5nJBZsW8MFQ")]
    [DisplayName("Regulatory Fees Amount")]
    [IsoXmlTag("RgltryFeesAmt")]
    public RestrictedFINActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; }

    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [IsoId("_sk05gc3wEee5nJBZsW8MFQ")]
    [DisplayName("Shipping Fees Amount")]
    [IsoXmlTag("ShppgFeesAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ShippingFeesAmount { get; init; }

    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_sk05ic3wEee5nJBZsW8MFQ")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; init; }

    /// <summary>
    /// Indicates cash retained from previous dividend.
    /// </summary>
    [IsoId("_sk05kc3wEee5nJBZsW8MFQ")]
    [DisplayName("Cash Amount Brought Forward")]
    [IsoXmlTag("CshAmtBrghtFwd")]
    public RestrictedFINActiveCurrencyAndAmount? CashAmountBroughtForward { get; init; }

    /// <summary>
    /// Indicates the balance carried forward to next dividend.
    /// </summary>
    [IsoId("_sk05mc3wEee5nJBZsW8MFQ")]
    [DisplayName("Cash Amount Carried Forward")]
    [IsoXmlTag("CshAmtCrrdFwd")]
    public RestrictedFINActiveCurrencyAndAmount? CashAmountCarriedForward { get; init; }

    /// <summary>
    /// Amount of cash that would have been payable if the dividend had been taken in the form of cash rather than shares.
    /// </summary>
    [IsoId("_sk05oc3wEee5nJBZsW8MFQ")]
    [DisplayName("Notional Dividend Payable Amount")]
    [IsoXmlTag("NtnlDvddPyblAmt")]
    public RestrictedFINActiveCurrencyAndAmount? NotionalDividendPayableAmount { get; init; }

    /// <summary>
    /// Where new securities are issued in lieu of a cash dividend, the notional tax is the tax on the amount of cash that would have been paid.
    /// </summary>
    [IsoId("_sk05qc3wEee5nJBZsW8MFQ")]
    [DisplayName("Notional Tax Amount")]
    [IsoXmlTag("NtnlTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? NotionalTaxAmount { get; init; }

    /// <summary>
    /// Amount of money paid by the tax authorities in addition to the payment of the tax refund itself.
    /// </summary>
    [IsoId("_sk05sc3wEee5nJBZsW8MFQ")]
    [DisplayName("Tax Arrears Amount")]
    [IsoXmlTag("TaxArrearsAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxArrearsAmount { get; init; }

    /// <summary>
    /// Posting/settlement Amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_sk05uc3wEee5nJBZsW8MFQ")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public RestrictedFINActiveCurrencyAndAmount? OriginalAmount { get; init; }

    /// <summary>
    /// Amount of money representing a distribution of a bond&apos;s principal, for example, repayment of outstanding debt.
    /// </summary>
    [IsoId("_sk05wc3wEee5nJBZsW8MFQ")]
    [DisplayName("Principal Or Corpus")]
    [IsoXmlTag("PrncplOrCrps")]
    public RestrictedFINActiveCurrencyAndAmount? PrincipalOrCorpus { get; init; }

    /// <summary>
    /// Amount of money (not interest) in addition to the principal at the redemption of a bond.
    /// </summary>
    [IsoId("_sk05yc3wEee5nJBZsW8MFQ")]
    [DisplayName("Redemption Premium Amount")]
    [IsoXmlTag("RedPrmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? RedemptionPremiumAmount { get; init; }

    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    [IsoId("_sk050c3wEee5nJBZsW8MFQ")]
    [DisplayName("Income Portion")]
    [IsoXmlTag("IncmPrtn")]
    public RestrictedFINActiveCurrencyAndAmount? IncomePortion { get; init; }

    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_sk052c3wEee5nJBZsW8MFQ")]
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public RestrictedFINActiveCurrencyAndAmount? StockExchangeTax { get; init; }

    /// <summary>
    /// Total amount of tax withheld at source in conformance with the EU Savings Directive.
    /// </summary>
    [IsoId("_sk054c3wEee5nJBZsW8MFQ")]
    [DisplayName("EU Tax Retention Amount")]
    [IsoXmlTag("EUTaxRtntnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? EUTaxRetentionAmount { get; init; }

    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_sk056c3wEee5nJBZsW8MFQ")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public RestrictedFINActiveCurrencyAndAmount? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Portion of the fund distribution amount which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_sk058c3wEee5nJBZsW8MFQ")]
    [DisplayName("Equalisation Amount")]
    [IsoXmlTag("EqulstnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? EqualisationAmount { get; init; }

    /// <summary>
    /// FATCA (Foreign Account Tax Compliance Act) related tax amount.
    /// </summary>
    [IsoId("_sk05883wEee5nJBZsW8MFQ")]
    [DisplayName("FATCA Tax Amount")]
    [IsoXmlTag("FATCATaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FATCATaxAmount { get; init; }

    /// <summary>
    /// Amount of tax related income subject to NRA (Non Resident Alien).
    /// </summary>
    [IsoId("_sk059c3wEee5nJBZsW8MFQ")]
    [DisplayName("NRA Tax Amount")]
    [IsoXmlTag("NRATaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? NRATaxAmount { get; init; }

    /// <summary>
    /// Amount of tax related to back up withholding.
    /// </summary>
    [IsoId("_sk05983wEee5nJBZsW8MFQ")]
    [DisplayName("Back Up Withholding Tax Amount")]
    [IsoXmlTag("BckUpWhldgTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? BackUpWithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_sk05-c3wEee5nJBZsW8MFQ")]
    [DisplayName("Tax On Income Amount")]
    [IsoXmlTag("TaxOnIncmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxOnIncomeAmount { get; init; }

    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_sk05-83wEee5nJBZsW8MFQ")]
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public RestrictedFINActiveCurrencyAndAmount? TransactionTax { get; init; }

    /// <summary>
    /// Amount of proceeds which is not actually paid to the security holder but on which withholding tax is applicable.
    /// </summary>
    [IsoId("_sk05_c3wEee5nJBZsW8MFQ")]
    [DisplayName("Deemed Amount")]
    [IsoXmlTag("DmdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? DeemedAmount { get; init; }

    /// <summary>
    /// Amount relating to a conduit foreign income.
    /// </summary>
    [IsoId("_sk05_83wEee5nJBZsW8MFQ")]
    [DisplayName("Conduit Foreign Income Amount")]
    [IsoXmlTag("CndtFrgnIncmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ConduitForeignIncomeAmount { get; init; }
}
