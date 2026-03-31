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
[IsoId("_Tb1LtNp-Ed-ak6NoX_4Aeg_-218391948")]
[DisplayName("Corporate Action Amounts")]
public record CorporateActionAmounts4
{
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_Tb1Ltdp-Ed-ak6NoX_4Aeg_-218391917")]
    [DisplayName("Gross Cash Amount")]
    [IsoXmlTag("GrssCshAmt")]
    public ActiveCurrencyAndAmount? GrossCashAmount { get; init; }

    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_Tb1Lttp-Ed-ak6NoX_4Aeg_-218391616")]
    [DisplayName("Net Cash Amount")]
    [IsoXmlTag("NetCshAmt")]
    public ActiveCurrencyAndAmount? NetCashAmount { get; init; }

    /// <summary>
    /// Amount of cash premium made available in order to encourage participation in the offer. Payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    [IsoId("_Tb1Lt9p-Ed-ak6NoX_4Aeg_-218391585")]
    [DisplayName("Solicitation Fees")]
    [IsoXmlTag("SlctnFees")]
    public ActiveCurrencyAndAmount? SolicitationFees { get; init; }

    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_Tb1LuNp-Ed-ak6NoX_4Aeg_-218391524")]
    [DisplayName("Cash In Lieu Of Share")]
    [IsoXmlTag("CshInLieuOfShr")]
    public ActiveCurrencyAndAmount? CashInLieuOfShare { get; init; }

    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [IsoId("_Tb1Ludp-Ed-ak6NoX_4Aeg_-218391463")]
    [DisplayName("Capital Gain")]
    [IsoXmlTag("CptlGn")]
    public ActiveCurrencyAndAmount? CapitalGain { get; init; }

    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    [IsoId("_Tb1Lutp-Ed-ak6NoX_4Aeg_-218391432")]
    [DisplayName("Interest Amount")]
    [IsoXmlTag("IntrstAmt")]
    public ActiveCurrencyAndAmount? InterestAmount { get; init; }

    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    [IsoId("_Tb1Lu9p-Ed-ak6NoX_4Aeg_-218391340")]
    [DisplayName("Indemnity Amount")]
    [IsoXmlTag("IndmntyAmt")]
    public ActiveCurrencyAndAmount? IndemnityAmount { get; init; }

    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender.
    /// </summary>
    [IsoId("_Tb-VoNp-Ed-ak6NoX_4Aeg_-218391093")]
    [DisplayName("Manufactured Dividend Amount")]
    [IsoXmlTag("ManfctrdDvddAmt")]
    public ActiveCurrencyAndAmount? ManufacturedDividendAmount { get; init; }

    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [IsoId("_Tb-Vodp-Ed-ak6NoX_4Aeg_-218391062")]
    [DisplayName("Reinvestment Amount")]
    [IsoXmlTag("RinvstmtAmt")]
    public ActiveCurrencyAndAmount? ReinvestmentAmount { get; init; }

    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [IsoId("_Tb-Votp-Ed-ak6NoX_4Aeg_-218391031")]
    [DisplayName("Fully Franked Amount")]
    [IsoXmlTag("FullyFrnkdAmt")]
    public ActiveCurrencyAndAmount? FullyFrankedAmount { get; init; }

    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    [IsoId("_Tb-Vo9p-Ed-ak6NoX_4Aeg_-218391001")]
    [DisplayName("Unfranked Amount")]
    [IsoXmlTag("UfrnkdAmt")]
    public ActiveCurrencyAndAmount? UnfrankedAmount { get; init; }

    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_Tb-VpNp-Ed-ak6NoX_4Aeg_-218390970")]
    [DisplayName("Sundry Or Other Amount")]
    [IsoXmlTag("SndryOrOthrAmt")]
    public ActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; }

    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example, consent fees or solicitation fees.
    /// </summary>
    [IsoId("_Tb-Vpdp-Ed-ak6NoX_4Aeg_-218390668")]
    [DisplayName("Cash Incentive")]
    [IsoXmlTag("CshIncntiv")]
    public ActiveCurrencyAndAmount? CashIncentive { get; init; }

    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_Tb-Vptp-Ed-ak6NoX_4Aeg_-218390637")]
    [DisplayName("Tax Free Amount")]
    [IsoXmlTag("TaxFreeAmt")]
    public ActiveCurrencyAndAmount? TaxFreeAmount { get; init; }

    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_Tb-Vp9p-Ed-ak6NoX_4Aeg_-218390607")]
    [DisplayName("Tax Deferred Amount")]
    [IsoXmlTag("TaxDfrrdAmt")]
    public ActiveCurrencyAndAmount? TaxDeferredAmount { get; init; }

    /// <summary>
    /// Amount of value added tax.
    /// </summary>
    [IsoId("_Tb-VqNp-Ed-ak6NoX_4Aeg_-218390453")]
    [DisplayName("Value Added Tax Amount")]
    [IsoXmlTag("ValAddedTaxAmt")]
    public ActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; }

    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_Tb-Vqdp-Ed-ak6NoX_4Aeg_-218390392")]
    [DisplayName("Stamp Duty Amount")]
    [IsoXmlTag("StmpDtyAmt")]
    public ActiveCurrencyAndAmount? StampDutyAmount { get; init; }

    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_TcIGoNp-Ed-ak6NoX_4Aeg_-218390391")]
    [DisplayName("Tax Reclaim Amount")]
    [IsoXmlTag("TaxRclmAmt")]
    public ActiveCurrencyAndAmount? TaxReclaimAmount { get; init; }

    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    [IsoId("_TcIGodp-Ed-ak6NoX_4Aeg_-218390114")]
    [DisplayName("Tax Credit Amount")]
    [IsoXmlTag("TaxCdtAmt")]
    public ActiveCurrencyAndAmount? TaxCreditAmount { get; init; }

    /// <summary>
    /// Amount of money withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_TcIGotp-Ed-ak6NoX_4Aeg_-218390083")]
    [DisplayName("Withholding Of Foreign Tax Amount")]
    [IsoXmlTag("WhldgOfFrgnTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingOfForeignTaxAmount { get; init; }

    /// <summary>
    /// Amount of money withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_TcIGo9p-Ed-ak6NoX_4Aeg_-218390053")]
    [DisplayName("Withholding Of Local Tax Amount")]
    [IsoXmlTag("WhldgOfLclTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingOfLocalTaxAmount { get; init; }

    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    [IsoId("_TcIGpNp-Ed-ak6NoX_4Aeg_-218390022")]
    [DisplayName("Additional Tax Amount")]
    [IsoXmlTag("AddtlTaxAmt")]
    public ActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; }

    /// <summary>
    /// Amount of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_TcIGpdp-Ed-ak6NoX_4Aeg_-218389991")]
    [DisplayName("Withholding Tax Amount")]
    [IsoXmlTag("WhldgTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    [IsoId("_TcIGptp-Ed-ak6NoX_4Aeg_-218389713")]
    [DisplayName("Fiscal Stamp Amount")]
    [IsoXmlTag("FsclStmpAmt")]
    public ActiveCurrencyAndAmount? FiscalStampAmount { get; init; }

    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_TcIGp9p-Ed-ak6NoX_4Aeg_-218389682")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public ActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    [IsoId("_TcIGqNp-Ed-ak6NoX_4Aeg_-218389652")]
    [DisplayName("Paying Agent Commission Amount")]
    [IsoXmlTag("PngAgtComssnAmt")]
    public ActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; }

    /// <summary>
    /// Local broker&apos;s commission.
    /// </summary>
    [IsoId("_TcRQkNp-Ed-ak6NoX_4Aeg_-218389590")]
    [DisplayName("Local Broker Commission Amount")]
    [IsoXmlTag("LclBrkrComssnAmt")]
    public ActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; }

    /// <summary>
    /// Amount of money paid for delivery by regular post mail.
    /// </summary>
    [IsoId("_TcRQkdp-Ed-ak6NoX_4Aeg_-218389560")]
    [DisplayName("Postage Fee Amount")]
    [IsoXmlTag("PstgFeeAmt")]
    public ActiveCurrencyAndAmount? PostageFeeAmount { get; init; }

    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, securities and exchange fees.
    /// </summary>
    [IsoId("_TcRQktp-Ed-ak6NoX_4Aeg_-218389529")]
    [DisplayName("Regulatory Fees Amount")]
    [IsoXmlTag("RgltryFeesAmt")]
    public ActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; }

    /// <summary>
    /// Amount of money (including insurance) paid for delivery by carrier.
    /// </summary>
    [IsoId("_TcRQk9p-Ed-ak6NoX_4Aeg_-218389498")]
    [DisplayName("Shipping Fees Amount")]
    [IsoXmlTag("ShppgFeesAmt")]
    public ActiveCurrencyAndAmount? ShippingFeesAmount { get; init; }

    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_TcRQlNp-Ed-ak6NoX_4Aeg_-218389468")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public ActiveCurrencyAndAmount? ChargesAmount { get; init; }

    /// <summary>
    /// Cash amount based on terms of corporate action event and balance of underlying securities, entitled to/from account owner (which may be positive or negative).
    /// </summary>
    [IsoId("_TcRQldp-Ed-ak6NoX_4Aeg_-218389437")]
    [DisplayName("Entitled Amount")]
    [IsoXmlTag("EntitldAmt")]
    public ActiveCurrencyAndAmount? EntitledAmount { get; init; }

    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_TcRQltp-Ed-ak6NoX_4Aeg_-218389415")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public ActiveCurrencyAndAmount? OriginalAmount { get; init; }

    /// <summary>
    /// Amount of money representing a distribution of a bond&apos;s principal, for example, repayment of outstanding debt.
    /// </summary>
    [IsoId("_TcRQl9p-Ed-ak6NoX_4Aeg_1154040506")]
    [DisplayName("Principal Or Corpus")]
    [IsoXmlTag("PrncplOrCrps")]
    public ActiveCurrencyAndAmount? PrincipalOrCorpus { get; init; }

    /// <summary>
    /// Amount of money (not interest) in addition to the principal at the redemption of a bond.
    /// </summary>
    [IsoId("_TcRQmNp-Ed-ak6NoX_4Aeg_1854990999")]
    [DisplayName("Redemption Premium Amount")]
    [IsoXmlTag("RedPrmAmt")]
    public ActiveCurrencyAndAmount? RedemptionPremiumAmount { get; init; }

    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    [IsoId("_TcbBkNp-Ed-ak6NoX_4Aeg_1895626854")]
    [DisplayName("Income Portion")]
    [IsoXmlTag("IncmPrtn")]
    public ActiveCurrencyAndAmount? IncomePortion { get; init; }

    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_TcbBkdp-Ed-ak6NoX_4Aeg_1924256989")]
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public ActiveCurrencyAndAmount? StockExchangeTax { get; init; }

    /// <summary>
    /// Total amount of tax withheld at source in conformance with the EU Savings Directive.
    /// </summary>
    [IsoId("_TcbBktp-Ed-ak6NoX_4Aeg_1951963628")]
    [DisplayName("EU Tax Retention Amount")]
    [IsoXmlTag("EUTaxRtntnAmt")]
    public ActiveCurrencyAndAmount? EUTaxRetentionAmount { get; init; }

    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_TcbBk9p-Ed-ak6NoX_4Aeg_-1734624611")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public ActiveCurrencyAndAmount? AccruedInterestAmount { get; init; }
}
