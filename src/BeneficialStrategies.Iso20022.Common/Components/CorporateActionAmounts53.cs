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
[IsoId("_o-j7O_fUEeiNZp_PtLohLw")]
[DisplayName("Corporate Action Amounts")]
public record CorporateActionAmounts53
{
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_o-j7P_fUEeiNZp_PtLohLw")]
    [DisplayName("Gross Cash Amount")]
    [IsoXmlTag("GrssCshAmt")]
    public RestrictedFINActiveCurrencyAndAmount? GrossCashAmount { get; init; }

    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_o-j7R_fUEeiNZp_PtLohLw")]
    [DisplayName("Net Cash Amount")]
    [IsoXmlTag("NetCshAmt")]
    public RestrictedFINActiveCurrencyAndAmount? NetCashAmount { get; init; }

    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fees.
    /// </summary>
    [IsoId("_o-j7T_fUEeiNZp_PtLohLw")]
    [DisplayName("Solicitation Fees")]
    [IsoXmlTag("SlctnFees")]
    public RestrictedFINActiveCurrencyAndAmount? SolicitationFees { get; init; }

    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_o-j7V_fUEeiNZp_PtLohLw")]
    [DisplayName("Cash In Lieu Of Share")]
    [IsoXmlTag("CshInLieuOfShr")]
    public RestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; }

    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [IsoId("_o-j7X_fUEeiNZp_PtLohLw")]
    [DisplayName("Capital Gain")]
    [IsoXmlTag("CptlGn")]
    public RestrictedFINActiveCurrencyAndAmount? CapitalGain { get; init; }

    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    [IsoId("_o-j7Z_fUEeiNZp_PtLohLw")]
    [DisplayName("Interest Amount")]
    [IsoXmlTag("IntrstAmt")]
    public RestrictedFINActiveCurrencyAndAmount? InterestAmount { get; init; }

    /// <summary>
    /// Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation. Used mainly in France.
    /// </summary>
    [IsoId("_o-j7b_fUEeiNZp_PtLohLw")]
    [DisplayName("Indemnity Amount")]
    [IsoXmlTag("IndmntyAmt")]
    public RestrictedFINActiveCurrencyAndAmount? IndemnityAmount { get; init; }

    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender. Also covers compensation/indemnity of missed dividend concerning early/late settlements if applicable to a market.
    /// </summary>
    [IsoId("_o-j7d_fUEeiNZp_PtLohLw")]
    [DisplayName("Manufactured Dividend Payment Amount")]
    [IsoXmlTag("ManfctrdDvddPmtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; }

    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [IsoId("_o-j7effUEeiNZp_PtLohLw")]
    [DisplayName("Reinvestment Amount")]
    [IsoXmlTag("RinvstmtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ReinvestmentAmount { get; init; }

    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [IsoId("_o-j7gffUEeiNZp_PtLohLw")]
    [DisplayName("Fully Franked Amount")]
    [IsoXmlTag("FullyFrnkdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FullyFrankedAmount { get; init; }

    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    [IsoId("_o-j7iffUEeiNZp_PtLohLw")]
    [DisplayName("Unfranked Amount")]
    [IsoXmlTag("UfrnkdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? UnfrankedAmount { get; init; }

    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_o-j7kffUEeiNZp_PtLohLw")]
    [DisplayName("Sundry Or Other Amount")]
    [IsoXmlTag("SndryOrOthrAmt")]
    public RestrictedFINActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; }

    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_o-j7mffUEeiNZp_PtLohLw")]
    [DisplayName("Tax Free Amount")]
    [IsoXmlTag("TaxFreeAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxFreeAmount { get; init; }

    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_o-j7offUEeiNZp_PtLohLw")]
    [DisplayName("Tax Deferred Amount")]
    [IsoXmlTag("TaxDfrrdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxDeferredAmount { get; init; }

    /// <summary>
    /// Amount of value added tax.
    /// </summary>
    [IsoId("_o-j7qffUEeiNZp_PtLohLw")]
    [DisplayName("Value Added Tax Amount")]
    [IsoXmlTag("ValAddedTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; }

    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_o-j7sffUEeiNZp_PtLohLw")]
    [DisplayName("Stamp Duty Amount")]
    [IsoXmlTag("StmpDtyAmt")]
    public RestrictedFINActiveCurrencyAndAmount? StampDutyAmount { get; init; }

    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_o-j7uffUEeiNZp_PtLohLw")]
    [DisplayName("Tax Reclaim Amount")]
    [IsoXmlTag("TaxRclmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxReclaimAmount { get; init; }

    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    [IsoId("_o-j7wffUEeiNZp_PtLohLw")]
    [DisplayName("Tax Credit Amount")]
    [IsoXmlTag("TaxCdtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxCreditAmount { get; init; }

    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    [IsoId("_o-j7yffUEeiNZp_PtLohLw")]
    [DisplayName("Additional Tax Amount")]
    [IsoXmlTag("AddtlTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; }

    /// <summary>
    /// Amount of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_o-j70ffUEeiNZp_PtLohLw")]
    [DisplayName("Withholding Tax Amount")]
    [IsoXmlTag("WhldgTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of money withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_o-j72ffUEeiNZp_PtLohLw")]
    [DisplayName("Second Level Tax Amount")]
    [IsoXmlTag("ScndLvlTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? SecondLevelTaxAmount { get; init; }

    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    [IsoId("_o-j72_fUEeiNZp_PtLohLw")]
    [DisplayName("Fiscal Stamp Amount")]
    [IsoXmlTag("FsclStmpAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FiscalStampAmount { get; init; }

    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_o-j74_fUEeiNZp_PtLohLw")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    [IsoId("_o-j76_fUEeiNZp_PtLohLw")]
    [DisplayName("Paying Agent Commission Amount")]
    [IsoXmlTag("PngAgtComssnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; }

    /// <summary>
    /// Local broker&apos;s commission.
    /// </summary>
    [IsoId("_o-j78_fUEeiNZp_PtLohLw")]
    [DisplayName("Local Broker Commission Amount")]
    [IsoXmlTag("LclBrkrComssnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; }

    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, securities and exchange fees.
    /// </summary>
    [IsoId("_o-j7-_fUEeiNZp_PtLohLw")]
    [DisplayName("Regulatory Fees Amount")]
    [IsoXmlTag("RgltryFeesAmt")]
    public RestrictedFINActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; }

    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [IsoId("_o-j8A_fUEeiNZp_PtLohLw")]
    [DisplayName("Shipping Fees Amount")]
    [IsoXmlTag("ShppgFeesAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ShippingFeesAmount { get; init; }

    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_o-j8C_fUEeiNZp_PtLohLw")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; init; }

    /// <summary>
    /// Cash amount based on the terms of the corporate action event and balance of underlying securities, entitled to/from account owner (which may be positive or negative).
    /// </summary>
    [IsoId("_o-j8E_fUEeiNZp_PtLohLw")]
    [DisplayName("Entitled Amount")]
    [IsoXmlTag("EntitldAmt")]
    public RestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; }

    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_o-j8G_fUEeiNZp_PtLohLw")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public RestrictedFINActiveCurrencyAndAmount? OriginalAmount { get; init; }

    /// <summary>
    /// Amount of money representing a distribution of a bond&apos;s principal, for example, repayment of outstanding debt.
    /// </summary>
    [IsoId("_o-j8I_fUEeiNZp_PtLohLw")]
    [DisplayName("Principal Or Corpus")]
    [IsoXmlTag("PrncplOrCrps")]
    public RestrictedFINActiveCurrencyAndAmount? PrincipalOrCorpus { get; init; }

    /// <summary>
    /// Amount of money (not interest) in addition to the principal at the redemption of a bond.
    /// </summary>
    [IsoId("_o-j8K_fUEeiNZp_PtLohLw")]
    [DisplayName("Redemption Premium Amount")]
    [IsoXmlTag("RedPrmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? RedemptionPremiumAmount { get; init; }

    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    [IsoId("_o-j8M_fUEeiNZp_PtLohLw")]
    [DisplayName("Income Portion")]
    [IsoXmlTag("IncmPrtn")]
    public RestrictedFINActiveCurrencyAndAmount? IncomePortion { get; init; }

    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_o-j8O_fUEeiNZp_PtLohLw")]
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public RestrictedFINActiveCurrencyAndAmount? StockExchangeTax { get; init; }

    /// <summary>
    /// Total amount of tax withheld at source in conformance with the EU Savings Directive.
    /// </summary>
    [IsoId("_o-j8Q_fUEeiNZp_PtLohLw")]
    [DisplayName("EU Tax Retention Amount")]
    [IsoXmlTag("EUTaxRtntnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? EUTaxRetentionAmount { get; init; }

    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_o-j8S_fUEeiNZp_PtLohLw")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public RestrictedFINActiveCurrencyAndAmount? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Portion of the fund distribution amount which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_o-j8U_fUEeiNZp_PtLohLw")]
    [DisplayName("Equalisation Amount")]
    [IsoXmlTag("EqulstnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? EqualisationAmount { get; init; }

    /// <summary>
    /// FATCA (Foreign Account Tax Compliance Act) related tax amount.
    /// </summary>
    [IsoId("_o-j8VffUEeiNZp_PtLohLw")]
    [DisplayName("FATCA Tax Amount")]
    [IsoXmlTag("FATCATaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FATCATaxAmount { get; init; }

    /// <summary>
    /// Amount of tax related income subject to NRA (Non Resident Alien).
    /// </summary>
    [IsoId("_o-j8V_fUEeiNZp_PtLohLw")]
    [DisplayName("NRA Tax Amount")]
    [IsoXmlTag("NRATaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? NRATaxAmount { get; init; }

    /// <summary>
    /// Amount of tax related to back up withholding.
    /// </summary>
    [IsoId("_o-j8WffUEeiNZp_PtLohLw")]
    [DisplayName("Back Up Withholding Tax Amount")]
    [IsoXmlTag("BckUpWhldgTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? BackUpWithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_o-j8W_fUEeiNZp_PtLohLw")]
    [DisplayName("Tax On Income Amount")]
    [IsoXmlTag("TaxOnIncmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxOnIncomeAmount { get; init; }

    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_o-j8XffUEeiNZp_PtLohLw")]
    [DisplayName("Transaction Tax")]
    [IsoXmlTag("TxTax")]
    public RestrictedFINActiveCurrencyAndAmount? TransactionTax { get; init; }

    /// <summary>
    /// Amount of proceeds which is not actually paid to the security holder but on which withholding tax is applicable.
    /// </summary>
    [IsoId("_o-j8X_fUEeiNZp_PtLohLw")]
    [DisplayName("Deemed Amount")]
    [IsoXmlTag("DmdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? DeemedAmount { get; init; }

    /// <summary>
    /// Amount relating to a conduit foreign income.
    /// </summary>
    [IsoId("_o-j8YffUEeiNZp_PtLohLw")]
    [DisplayName("Conduit Foreign Income Amount")]
    [IsoXmlTag("CndtFrgnIncmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ConduitForeignIncomeAmount { get; init; }

    /// <summary>
    /// Deemed amount resulting from the difference between the rate of dividend proceeds attributed to the security holder for the taxable year and the rate of dividend proceeds previously notified to the security holder in relation to cash distributions for the year.
    /// </summary>
    [IsoId("_o-j8Y_fUEeiNZp_PtLohLw")]
    [DisplayName("Deemed Dividend Amount")]
    [IsoXmlTag("DmdDvddAmt")]
    public RestrictedFINActiveCurrencyAndAmount? DeemedDividendAmount { get; init; }

    /// <summary>
    /// Deemed amount resulting from the difference between the rate of the proceeds components comprising a fund payment attributed to the security holder for the taxable year and the rate of the fund proceeds previously notified to the security holder in relation to cash distributions for the year.
    /// </summary>
    [IsoId("_o-j8ZffUEeiNZp_PtLohLw")]
    [DisplayName("Deemed Fund Amount")]
    [IsoXmlTag("DmdFndAmt")]
    public RestrictedFINActiveCurrencyAndAmount? DeemedFundAmount { get; init; }

    /// <summary>
    /// Deemed amount resulting from the difference between the rate of interest proceeds attributed to the security holder for the taxable year and the rate of interest proceeds previously notified to the security holder in relation to cash distributions for the year.
    /// </summary>
    [IsoId("_o-j8Z_fUEeiNZp_PtLohLw")]
    [DisplayName("Deemed Interest Amount")]
    [IsoXmlTag("DmdIntrstAmt")]
    public RestrictedFINActiveCurrencyAndAmount? DeemedInterestAmount { get; init; }

    /// <summary>
    /// Deemed amount resulting from the difference between the rate of royalty proceeds attributed to the security holder for the taxable year and the rate of royalty proceeds previously notified to the security holder in relation to cash distributions for the year.
    /// </summary>
    [IsoId("_o-j8affUEeiNZp_PtLohLw")]
    [DisplayName("Deemed Royalties Amount")]
    [IsoXmlTag("DmdRyltsAmt")]
    public RestrictedFINActiveCurrencyAndAmount? DeemedRoyaltiesAmount { get; init; }
}
