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
[IsoId("_wKDYgeXsEemEj48jhmlA0Q")]
[DisplayName("Corporate Action Amounts")]
public record CorporateActionAmounts54
{
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_wbBMs-XsEemEj48jhmlA0Q")]
    [DisplayName("Gross Cash Amount")]
    [IsoXmlTag("GrssCshAmt")]
    public ActiveCurrencyAndAmount? GrossCashAmount { get; init; }

    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_wbBMu-XsEemEj48jhmlA0Q")]
    [DisplayName("Net Cash Amount")]
    [IsoXmlTag("NetCshAmt")]
    public ActiveCurrencyAndAmount? NetCashAmount { get; init; }

    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fees.
    /// </summary>
    [IsoId("_wbBMw-XsEemEj48jhmlA0Q")]
    [DisplayName("Solicitation Fees")]
    [IsoXmlTag("SlctnFees")]
    public ActiveCurrencyAndAmount? SolicitationFees { get; init; }

    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_wbBMy-XsEemEj48jhmlA0Q")]
    [DisplayName("Cash In Lieu Of Share")]
    [IsoXmlTag("CshInLieuOfShr")]
    public ActiveCurrencyAndAmount? CashInLieuOfShare { get; init; }

    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [IsoId("_wbBM0-XsEemEj48jhmlA0Q")]
    [DisplayName("Capital Gain")]
    [IsoXmlTag("CptlGn")]
    public ActiveCurrencyAndAmount? CapitalGain { get; init; }

    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    [IsoId("_wbBM2-XsEemEj48jhmlA0Q")]
    [DisplayName("Interest Amount")]
    [IsoXmlTag("IntrstAmt")]
    public ActiveCurrencyAndAmount? InterestAmount { get; init; }

    /// <summary>
    /// Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation. Used mainly in France.
    /// </summary>
    [IsoId("_wbBM4-XsEemEj48jhmlA0Q")]
    [DisplayName("Indemnity Amount")]
    [IsoXmlTag("IndmntyAmt")]
    public ActiveCurrencyAndAmount? IndemnityAmount { get; init; }

    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender. Also covers compensation/indemnity of missed dividend concerning early/late settlements if applicable to a market.
    /// </summary>
    [IsoId("_wbBM6-XsEemEj48jhmlA0Q")]
    [DisplayName("Manufactured Dividend Payment Amount")]
    [IsoXmlTag("ManfctrdDvddPmtAmt")]
    public ActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; }

    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [IsoId("_wbBM7eXsEemEj48jhmlA0Q")]
    [DisplayName("Reinvestment Amount")]
    [IsoXmlTag("RinvstmtAmt")]
    public ActiveCurrencyAndAmount? ReinvestmentAmount { get; init; }

    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [IsoId("_wbBM9eXsEemEj48jhmlA0Q")]
    [DisplayName("Fully Franked Amount")]
    [IsoXmlTag("FullyFrnkdAmt")]
    public ActiveCurrencyAndAmount? FullyFrankedAmount { get; init; }

    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    [IsoId("_wbBM_eXsEemEj48jhmlA0Q")]
    [DisplayName("Unfranked Amount")]
    [IsoXmlTag("UfrnkdAmt")]
    public ActiveCurrencyAndAmount? UnfrankedAmount { get; init; }

    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_wbBNBeXsEemEj48jhmlA0Q")]
    [DisplayName("Sundry Or Other Amount")]
    [IsoXmlTag("SndryOrOthrAmt")]
    public ActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; }

    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_wbBNDeXsEemEj48jhmlA0Q")]
    [DisplayName("Tax Free Amount")]
    [IsoXmlTag("TaxFreeAmt")]
    public ActiveCurrencyAndAmount? TaxFreeAmount { get; init; }

    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_wbBNFeXsEemEj48jhmlA0Q")]
    [DisplayName("Tax Deferred Amount")]
    [IsoXmlTag("TaxDfrrdAmt")]
    public ActiveCurrencyAndAmount? TaxDeferredAmount { get; init; }

    /// <summary>
    /// Amount of value added tax.
    /// </summary>
    [IsoId("_wbBNHeXsEemEj48jhmlA0Q")]
    [DisplayName("Value Added Tax Amount")]
    [IsoXmlTag("ValAddedTaxAmt")]
    public ActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; }

    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_wbBNJeXsEemEj48jhmlA0Q")]
    [DisplayName("Stamp Duty Amount")]
    [IsoXmlTag("StmpDtyAmt")]
    public ActiveCurrencyAndAmount? StampDutyAmount { get; init; }

    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_wbBNLeXsEemEj48jhmlA0Q")]
    [DisplayName("Tax Reclaim Amount")]
    [IsoXmlTag("TaxRclmAmt")]
    public ActiveCurrencyAndAmount? TaxReclaimAmount { get; init; }

    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    [IsoId("_wbBNNeXsEemEj48jhmlA0Q")]
    [DisplayName("Tax Credit Amount")]
    [IsoXmlTag("TaxCdtAmt")]
    public ActiveCurrencyAndAmount? TaxCreditAmount { get; init; }

    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    [IsoId("_wbBNPeXsEemEj48jhmlA0Q")]
    [DisplayName("Additional Tax Amount")]
    [IsoXmlTag("AddtlTaxAmt")]
    public ActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; }

    /// <summary>
    /// Amount of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_wbBNReXsEemEj48jhmlA0Q")]
    [DisplayName("Withholding Tax Amount")]
    [IsoXmlTag("WhldgTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of money withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_wbBNTeXsEemEj48jhmlA0Q")]
    [DisplayName("Second Level Tax Amount")]
    [IsoXmlTag("ScndLvlTaxAmt")]
    public ActiveCurrencyAndAmount? SecondLevelTaxAmount { get; init; }

    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    [IsoId("_wbBNT-XsEemEj48jhmlA0Q")]
    [DisplayName("Fiscal Stamp Amount")]
    [IsoXmlTag("FsclStmpAmt")]
    public ActiveCurrencyAndAmount? FiscalStampAmount { get; init; }

    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_wbBNV-XsEemEj48jhmlA0Q")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public ActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    [IsoId("_wbBNX-XsEemEj48jhmlA0Q")]
    [DisplayName("Paying Agent Commission Amount")]
    [IsoXmlTag("PngAgtComssnAmt")]
    public ActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; }

    /// <summary>
    /// Local broker&apos;s commission.
    /// </summary>
    [IsoId("_wbBNZ-XsEemEj48jhmlA0Q")]
    [DisplayName("Local Broker Commission Amount")]
    [IsoXmlTag("LclBrkrComssnAmt")]
    public ActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; }

    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, securities and exchange fees.
    /// </summary>
    [IsoId("_wbBNb-XsEemEj48jhmlA0Q")]
    [DisplayName("Regulatory Fees Amount")]
    [IsoXmlTag("RgltryFeesAmt")]
    public ActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; }

    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [IsoId("_wbBNd-XsEemEj48jhmlA0Q")]
    [DisplayName("Shipping Fees Amount")]
    [IsoXmlTag("ShppgFeesAmt")]
    public ActiveCurrencyAndAmount? ShippingFeesAmount { get; init; }

    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_wbBNf-XsEemEj48jhmlA0Q")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public ActiveCurrencyAndAmount? ChargesAmount { get; init; }

    /// <summary>
    /// Cash amount based on the terms of the corporate action event and balance of underlying securities, entitled to/from account owner (which may be positive or negative).
    /// </summary>
    [IsoId("_wbBNh-XsEemEj48jhmlA0Q")]
    [DisplayName("Entitled Amount")]
    [IsoXmlTag("EntitldAmt")]
    public ActiveCurrencyAndAmount? EntitledAmount { get; init; }

    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_wbBNj-XsEemEj48jhmlA0Q")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public ActiveCurrencyAndAmount? OriginalAmount { get; init; }

    /// <summary>
    /// Amount of money representing a distribution of a bond&apos;s principal, for example, repayment of outstanding debt.
    /// </summary>
    [IsoId("_wbBNl-XsEemEj48jhmlA0Q")]
    [DisplayName("Principal Or Corpus")]
    [IsoXmlTag("PrncplOrCrps")]
    public ActiveCurrencyAndAmount? PrincipalOrCorpus { get; init; }

    /// <summary>
    /// Amount of money (not interest) in addition to the principal at the redemption of a bond.
    /// </summary>
    [IsoId("_wbBNn-XsEemEj48jhmlA0Q")]
    [DisplayName("Redemption Premium Amount")]
    [IsoXmlTag("RedPrmAmt")]
    public ActiveCurrencyAndAmount? RedemptionPremiumAmount { get; init; }

    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    [IsoId("_wbBNp-XsEemEj48jhmlA0Q")]
    [DisplayName("Income Portion")]
    [IsoXmlTag("IncmPrtn")]
    public ActiveCurrencyAndAmount? IncomePortion { get; init; }

    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_wbBNr-XsEemEj48jhmlA0Q")]
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public ActiveCurrencyAndAmount? StockExchangeTax { get; init; }

    /// <summary>
    /// Total amount of tax withheld at source in conformance with the EU Savings Directive.
    /// </summary>
    [IsoId("_wbBNt-XsEemEj48jhmlA0Q")]
    [DisplayName("EU Tax Retention Amount")]
    [IsoXmlTag("EUTaxRtntnAmt")]
    public ActiveCurrencyAndAmount? EUTaxRetentionAmount { get; init; }

    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_wbBNv-XsEemEj48jhmlA0Q")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public ActiveCurrencyAndAmount? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Portion of the fund distribution amount which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_wbBNx-XsEemEj48jhmlA0Q")]
    [DisplayName("Equalisation Amount")]
    [IsoXmlTag("EqulstnAmt")]
    public ActiveCurrencyAndAmount? EqualisationAmount { get; init; }

    /// <summary>
    /// FATCA (Foreign Account Tax Compliance Act) related tax amount.
    /// </summary>
    [IsoId("_wbBNyeXsEemEj48jhmlA0Q")]
    [DisplayName("FATCA Tax Amount")]
    [IsoXmlTag("FATCATaxAmt")]
    public ActiveCurrencyAndAmount? FATCATaxAmount { get; init; }

    /// <summary>
    /// Amount of tax related income subject to NRA (Non Resident Alien).
    /// </summary>
    [IsoId("_wbBNy-XsEemEj48jhmlA0Q")]
    [DisplayName("NRA Tax Amount")]
    [IsoXmlTag("NRATaxAmt")]
    public ActiveCurrencyAndAmount? NRATaxAmount { get; init; }

    /// <summary>
    /// Amount of tax related to back up withholding.
    /// </summary>
    [IsoId("_wbBNzeXsEemEj48jhmlA0Q")]
    [DisplayName("Back Up Withholding Tax Amount")]
    [IsoXmlTag("BckUpWhldgTaxAmt")]
    public ActiveCurrencyAndAmount? BackUpWithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_wbBNz-XsEemEj48jhmlA0Q")]
    [DisplayName("Tax On Income Amount")]
    [IsoXmlTag("TaxOnIncmAmt")]
    public ActiveCurrencyAndAmount? TaxOnIncomeAmount { get; init; }

    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_wbBN0eXsEemEj48jhmlA0Q")]
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public ActiveCurrencyAndAmount? TransactionTax { get; init; }

    /// <summary>
    /// Amount of proceeds which is not actually paid to the security holder but on which withholding tax is applicable.
    /// </summary>
    [IsoId("_wbBN0-XsEemEj48jhmlA0Q")]
    [DisplayName("Deemed Amount")]
    [IsoXmlTag("DmdAmt")]
    public ActiveCurrencyAndAmount? DeemedAmount { get; init; }

    /// <summary>
    /// Amount relating to a foreign income such as a conduit foreign income.
    /// </summary>
    [IsoId("_wbBN1eXsEemEj48jhmlA0Q")]
    [DisplayName("Foreign Income Amount")]
    [IsoXmlTag("FrgnIncmAmt")]
    public ActiveCurrencyAndAmount? ForeignIncomeAmount { get; init; }

    /// <summary>
    /// Deemed amount resulting from the difference between the rate of dividend proceeds attributed to the security holder for the taxable year and the rate of dividend proceeds previously notified to the security holder in relation to cash distributions for the year.
    /// </summary>
    [IsoId("_wbBN1-XsEemEj48jhmlA0Q")]
    [DisplayName("Deemed Dividend Amount")]
    [IsoXmlTag("DmdDvddAmt")]
    public ActiveCurrencyAndAmount? DeemedDividendAmount { get; init; }

    /// <summary>
    /// Deemed amount resulting from the difference between the rate of the proceeds components comprising a fund payment attributed to the security holder for the taxable year and the rate of the fund proceeds previously notified to the security holder in relation to cash distributions for the year.
    /// </summary>
    [IsoId("_wbBN2eXsEemEj48jhmlA0Q")]
    [DisplayName("Deemed Fund Amount")]
    [IsoXmlTag("DmdFndAmt")]
    public ActiveCurrencyAndAmount? DeemedFundAmount { get; init; }

    /// <summary>
    /// Deemed amount resulting from the difference between the rate of interest proceeds attributed to the security holder for the taxable year and the rate of interest proceeds previously notified to the security holder in relation to cash distributions for the year.
    /// </summary>
    [IsoId("_wbBN2-XsEemEj48jhmlA0Q")]
    [DisplayName("Deemed Interest Amount")]
    [IsoXmlTag("DmdIntrstAmt")]
    public ActiveCurrencyAndAmount? DeemedInterestAmount { get; init; }

    /// <summary>
    /// Deemed amount resulting from the difference between the rate of royalty proceeds attributed to the security holder for the taxable year and the rate of royalty proceeds previously notified to the security holder in relation to cash distributions for the year.
    /// </summary>
    [IsoId("_wbBN3eXsEemEj48jhmlA0Q")]
    [DisplayName("Deemed Royalties Amount")]
    [IsoXmlTag("DmdRyltsAmt")]
    public ActiveCurrencyAndAmount? DeemedRoyaltiesAmount { get; init; }
}
