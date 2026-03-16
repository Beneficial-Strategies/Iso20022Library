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
[IsoId("_TeEAUtp-Ed-ak6NoX_4Aeg_1803502106")]
[DisplayName("Corporate Action Amounts")]
public record CorporateActionAmounts1
{
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_TeEAU9p-Ed-ak6NoX_4Aeg_2143357834")]
    [DisplayName("Gross Cash Amount")]
    [IsoXmlTag("GrssCshAmt")]
    public ActiveCurrencyAndAmount? GrossCashAmount { get; init; }

    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, ie, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_TeEAVNp-Ed-ak6NoX_4Aeg_2143357865")]
    [DisplayName("Net Cash Amount")]
    [IsoXmlTag("NetCshAmt")]
    public ActiveCurrencyAndAmount? NetCashAmount { get; init; }

    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    [IsoId("_TeEAVdp-Ed-ak6NoX_4Aeg_2143357888")]
    [DisplayName("Issue Discount Amount")]
    [IsoXmlTag("IsseDscntAmt")]
    public ActiveCurrencyAndAmount? IssueDiscountAmount { get; init; }

    /// <summary>
    /// Amount of cash premium made available in order to encourage participation in the offer. Payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    [IsoId("_TeEAVtp-Ed-ak6NoX_4Aeg_2143358167")]
    [DisplayName("Solicitation Fees")]
    [IsoXmlTag("SlctnFees")]
    public ActiveCurrencyAndAmount? SolicitationFees { get; init; }

    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, eg, equity.
    /// </summary>
    [IsoId("_TeEAV9p-Ed-ak6NoX_4Aeg_2143358228")]
    [DisplayName("Cash In Lieu Of Share")]
    [IsoXmlTag("CshInLieuOfShr")]
    public ActiveCurrencyAndAmount? CashInLieuOfShare { get; init; }

    /// <summary>
    /// Amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_TeEAWNp-Ed-ak6NoX_4Aeg_695553989")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public ActiveCurrencyAndAmount? OriginalAmount { get; init; }

    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [IsoId("_TeNxUNp-Ed-ak6NoX_4Aeg_2143358259")]
    [DisplayName("Capital Gain")]
    [IsoXmlTag("CptlGn")]
    public ActiveCurrencyAndAmount? CapitalGain { get; init; }

    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    [IsoId("_TeNxUdp-Ed-ak6NoX_4Aeg_2143358598")]
    [DisplayName("Interest Amount")]
    [IsoXmlTag("IntrstAmt")]
    public ActiveCurrencyAndAmount? InterestAmount { get; init; }

    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    [IsoId("_TeNxUtp-Ed-ak6NoX_4Aeg_2143358660")]
    [DisplayName("Indemnity Amount")]
    [IsoXmlTag("IndmntyAmt")]
    public ActiveCurrencyAndAmount? IndemnityAmount { get; init; }

    /// <summary>
    /// Amount of money (not interest) in addition to the principal at the redemption of a bond.
    /// </summary>
    [IsoId("_TeNxU9p-Ed-ak6NoX_4Aeg_2143358690")]
    [DisplayName("Redemption Premium Amount")]
    [IsoXmlTag("RedPrmAmt")]
    public ActiveCurrencyAndAmount? RedemptionPremiumAmount { get; init; }

    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender.
    /// </summary>
    [IsoId("_TeNxVNp-Ed-ak6NoX_4Aeg_2143358752")]
    [DisplayName("Manufactured Dividend Amount")]
    [IsoXmlTag("ManfctrdDvddAmt")]
    public ActiveCurrencyAndAmount? ManufacturedDividendAmount { get; init; }

    /// <summary>
    /// Amount of money representing a distribution of a bond&apos;s principal, eg, repayment of outstanding debt.
    /// </summary>
    [IsoId("_TeNxVdp-Ed-ak6NoX_4Aeg_2143358782")]
    [DisplayName("Principal Or Corpus")]
    [IsoXmlTag("PrncplOrCrps")]
    public ActiveCurrencyAndAmount? PrincipalOrCorpus { get; init; }

    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [IsoId("_TeNxVtp-Ed-ak6NoX_4Aeg_2143358843")]
    [DisplayName("Reinvestment Amount")]
    [IsoXmlTag("RinvstmtAmt")]
    public ActiveCurrencyAndAmount? ReinvestmentAmount { get; init; }

    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    [IsoId("_TeNxV9p-Ed-ak6NoX_4Aeg_2143359122")]
    [DisplayName("Market Claim Amount")]
    [IsoXmlTag("MktClmAmt")]
    public ActiveCurrencyAndAmount? MarketClaimAmount { get; init; }

    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [IsoId("_TeNxWNp-Ed-ak6NoX_4Aeg_2143359152")]
    [DisplayName("Fully Franked Amount")]
    [IsoXmlTag("FullyFrnkdAmt")]
    public ActiveCurrencyAndAmount? FullyFrankedAmount { get; init; }

    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    [IsoId("_TeNxWdp-Ed-ak6NoX_4Aeg_2144279208")]
    [DisplayName("Unfranked Amount")]
    [IsoXmlTag("UfrnkdAmt")]
    public ActiveCurrencyAndAmount? UnfrankedAmount { get; init; }

    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_TeW7QNp-Ed-ak6NoX_4Aeg_2144279269")]
    [DisplayName("Sundry Or Other Amount")]
    [IsoXmlTag("SndryOrOthrAmt")]
    public ActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; }

    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    [IsoId("_TeW7Qdp-Ed-ak6NoX_4Aeg_2144279331")]
    [DisplayName("Special Concession Amount")]
    [IsoXmlTag("SpclCncssnAmt")]
    public ActiveCurrencyAndAmount? SpecialConcessionAmount { get; init; }

    /// <summary>
    /// Cash amount based on terms of corporate action event and balance of underlying securities, entitled to/from account owner (which may be positive or negative).
    /// </summary>
    [IsoId("_TeW7Qtp-Ed-ak6NoX_4Aeg_2144279392")]
    [DisplayName("Entitled Amount")]
    [IsoXmlTag("EntitldAmt")]
    public ActiveCurrencyAndAmount? EntitledAmount { get; init; }

    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, e.g. consent fees.
    /// </summary>
    [IsoId("_TeW7Q9p-Ed-ak6NoX_4Aeg_2144279731")]
    [DisplayName("Cash Incentive")]
    [IsoXmlTag("CshIncntiv")]
    public ActiveCurrencyAndAmount? CashIncentive { get; init; }

    /// <summary>
    /// Additional costs - coming on top of the subscription costs - which the subscriber should pay as per the subscription process. Not to be used for the subscription cost itself.
    /// </summary>
    [IsoId("_TeW7RNp-Ed-ak6NoX_4Aeg_2144279885")]
    [DisplayName("Additional Subscription Cost")]
    [IsoXmlTag("AddtlSbcptCost")]
    public ActiveCurrencyAndAmount? AdditionalSubscriptionCost { get; init; }

    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_TeW7Rdp-Ed-ak6NoX_4Aeg_-1937354060")]
    [DisplayName("Tax Free Amount")]
    [IsoXmlTag("TaxFreeAmt")]
    public ActiveCurrencyAndAmount? TaxFreeAmount { get; init; }

    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_TeW7Rtp-Ed-ak6NoX_4Aeg_-1937353750")]
    [DisplayName("Tax Deferred Amount")]
    [IsoXmlTag("TaxDfrrdAmt")]
    public ActiveCurrencyAndAmount? TaxDeferredAmount { get; init; }

    /// <summary>
    /// Local tax (ZAS Anrechnungsbetrag) subject to interest down payment tax (proportion of interest liable for interest down payment tax/interim profit that is not covered by the tax exempt amount).
    /// </summary>
    [IsoId("_TeW7R9p-Ed-ak6NoX_4Aeg_-1937353659")]
    [DisplayName("German Local Tax 1 Amount")]
    [IsoXmlTag("GrmnLclTax1Amt")]
    public ActiveCurrencyAndAmount? GermanLocalTax1Amount { get; init; }

    /// <summary>
    /// Local tax (ZAS Pflichtige Zinsen) interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).
    /// </summary>
    [IsoId("_TeW7SNp-Ed-ak6NoX_4Aeg_-1937353567")]
    [DisplayName("German Local Tax 2 Amount")]
    [IsoXmlTag("GrmnLclTax2Amt")]
    public ActiveCurrencyAndAmount? GermanLocalTax2Amount { get; init; }

    /// <summary>
    /// Local tax (Zinstopf) offset interest per unit against tax exempt amount (variation to offset interest per unit in relation to tax exempt amount).
    /// </summary>
    [IsoId("_TeW7Sdp-Ed-ak6NoX_4Aeg_-1937353505")]
    [DisplayName("German Local Tax 3 Amount")]
    [IsoXmlTag("GrmnLclTax3Amt")]
    public ActiveCurrencyAndAmount? GermanLocalTax3Amount { get; init; }

    /// <summary>
    /// Local tax (Ertrag Besitzanteilig) yield liable for interest down payment tax.
    /// </summary>
    [IsoId("_TegsQNp-Ed-ak6NoX_4Aeg_-1937353227")]
    [DisplayName("German Local Tax 4 Amount")]
    [IsoXmlTag("GrmnLclTax4Amt")]
    public ActiveCurrencyAndAmount? GermanLocalTax4Amount { get; init; }

    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_TegsQdp-Ed-ak6NoX_4Aeg_-1937353143")]
    [DisplayName("Stock Exchange Tax Amount")]
    [IsoXmlTag("StockXchgTaxAmt")]
    public ActiveCurrencyAndAmount? StockExchangeTaxAmount { get; init; }

    /// <summary>
    /// Tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    [IsoId("_TegsQtp-Ed-ak6NoX_4Aeg_-1937352803")]
    [DisplayName("Transfer Tax Amount")]
    [IsoXmlTag("TrfTaxAmt")]
    public ActiveCurrencyAndAmount? TransferTaxAmount { get; init; }

    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    [IsoId("_TegsQ9p-Ed-ak6NoX_4Aeg_-1937352742")]
    [DisplayName("Transaction Tax Amount")]
    [IsoXmlTag("TxTaxAmt")]
    public ActiveCurrencyAndAmount? TransactionTaxAmount { get; init; }

    /// <summary>
    /// Tax on value added.
    /// </summary>
    [IsoId("_TegsRNp-Ed-ak6NoX_4Aeg_-1937352650")]
    [DisplayName("Value Added Tax Amount")]
    [IsoXmlTag("ValAddedTaxAmt")]
    public ActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; }

    /// <summary>
    /// Total amount of tax withheld at source in conformance with the EU Savings Directive.
    /// </summary>
    [IsoId("_TegsRdp-Ed-ak6NoX_4Aeg_-1937352589")]
    [DisplayName("EU Retention Tax Amount")]
    [IsoXmlTag("EURtntnTaxAmt")]
    public ActiveCurrencyAndAmount? EURetentionTaxAmount { get; init; }

    /// <summary>
    /// Amount of tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    [IsoId("_TegsRtp-Ed-ak6NoX_4Aeg_-1937352280")]
    [DisplayName("Local Tax Amount")]
    [IsoXmlTag("LclTaxAmt")]
    public ActiveCurrencyAndAmount? LocalTaxAmount { get; init; }

    /// <summary>
    /// Payment levy tax.
    /// </summary>
    [IsoId("_TegsR9p-Ed-ak6NoX_4Aeg_-1937352226")]
    [DisplayName("Payment Levy Tax Amount")]
    [IsoXmlTag("PmtLevyTaxAmt")]
    public ActiveCurrencyAndAmount? PaymentLevyTaxAmount { get; init; }

    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    [IsoId("_TegsSNp-Ed-ak6NoX_4Aeg_-1937352134")]
    [DisplayName("Country National Federal Tax Amount")]
    [IsoXmlTag("CtryNtlFdrlTaxAmt")]
    public ActiveCurrencyAndAmount? CountryNationalFederalTaxAmount { get; init; }

    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_TegsSdp-Ed-ak6NoX_4Aeg_-1937351825")]
    [DisplayName("Stamp Duty Amount")]
    [IsoXmlTag("StmpDtyAmt")]
    public ActiveCurrencyAndAmount? StampDutyAmount { get; init; }

    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_Tep2MNp-Ed-ak6NoX_4Aeg_-1937351733")]
    [DisplayName("Tax Reclaim Amount")]
    [IsoXmlTag("TaxRclmAmt")]
    public ActiveCurrencyAndAmount? TaxReclaimAmount { get; init; }

    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    [IsoId("_Tep2Mdp-Ed-ak6NoX_4Aeg_-1937351641")]
    [DisplayName("Tax Credit Amount")]
    [IsoXmlTag("TaxCdtAmt")]
    public ActiveCurrencyAndAmount? TaxCreditAmount { get; init; }

    /// <summary>
    /// Amount of money withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_Tep2Mtp-Ed-ak6NoX_4Aeg_-1937351580")]
    [DisplayName("Withholding Of Foreign Tax Amount")]
    [IsoXmlTag("WhldgOfFrgnTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingOfForeignTaxAmount { get; init; }

    /// <summary>
    /// Amount of money withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_Tep2M9p-Ed-ak6NoX_4Aeg_-1937351271")]
    [DisplayName("Withholding Of Local Tax Amount")]
    [IsoXmlTag("WhldgOfLclTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingOfLocalTaxAmount { get; init; }

    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    [IsoId("_Tep2NNp-Ed-ak6NoX_4Aeg_-1936431208")]
    [DisplayName("Additional Tax Amount")]
    [IsoXmlTag("AddtlTaxAmt")]
    public ActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; }

    /// <summary>
    /// Amount of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_Tep2Ndp-Ed-ak6NoX_4Aeg_-1936431123")]
    [DisplayName("Withholding Tax Amount")]
    [IsoXmlTag("WhldgTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    [IsoId("_Tep2Ntp-Ed-ak6NoX_4Aeg_-1936431031")]
    [DisplayName("Fiscal Stamp Amount")]
    [IsoXmlTag("FsclStmpAmt")]
    public ActiveCurrencyAndAmount? FiscalStampAmount { get; init; }

    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_Tep2N9p-Ed-ak6NoX_4Aeg_-1248405467")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public ActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    [IsoId("_Tep2ONp-Ed-ak6NoX_4Aeg_-1248405158")]
    [DisplayName("Paying Agent Commission Amount")]
    [IsoXmlTag("PngAgtComssnAmt")]
    public ActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; }

    /// <summary>
    /// Local broker&apos;s commission.
    /// </summary>
    [IsoId("_Tep2Odp-Ed-ak6NoX_4Aeg_-1248405066")]
    [DisplayName("Local Broker Commission Amount")]
    [IsoXmlTag("LclBrkrComssnAmt")]
    public ActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; }

    /// <summary>
    /// Amount of money paid for delivery by regular post mail.
    /// </summary>
    [IsoId("_TeznMNp-Ed-ak6NoX_4Aeg_-1248404974")]
    [DisplayName("Postage Fee Amount")]
    [IsoXmlTag("PstgFeeAmt")]
    public ActiveCurrencyAndAmount? PostageFeeAmount { get; init; }

    /// <summary>
    /// Amount of money charged by a regulatory authority, eg, Securities and Exchange fees.
    /// </summary>
    [IsoId("_TeznMdp-Ed-ak6NoX_4Aeg_-1248404604")]
    [DisplayName("Regulatory Fees Amount")]
    [IsoXmlTag("RgltryFeesAmt")]
    public ActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; }

    /// <summary>
    /// Amount of money (including insurance) paid for delivery by carrier.
    /// </summary>
    [IsoId("_TeznMtp-Ed-ak6NoX_4Aeg_-1247484541")]
    [DisplayName("Shipping Fees Amount")]
    [IsoXmlTag("ShppgFeesAmt")]
    public ActiveCurrencyAndAmount? ShippingFeesAmount { get; init; }

    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_TeznM9p-Ed-ak6NoX_4Aeg_-1247484449")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public ActiveCurrencyAndAmount? ChargesAmount { get; init; }
}
