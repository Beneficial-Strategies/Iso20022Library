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
[IsoId("_N_PusAU-EeGZxNLgzisRtw")]
[DisplayName("Corporate Action Amounts")]
public record CorporateActionAmounts19
{
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_N_PutgU-EeGZxNLgzisRtw")]
    [DisplayName("Gross Cash Amount")]
    [IsoXmlTag("GrssCshAmt")]
    public RestrictedFINActiveCurrencyAndAmount? GrossCashAmount { get; init; }

    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_N_PuvAU-EeGZxNLgzisRtw")]
    [DisplayName("Net Cash Amount")]
    [IsoXmlTag("NetCshAmt")]
    public RestrictedFINActiveCurrencyAndAmount? NetCashAmount { get; init; }

    /// <summary>
    /// Amount of cash premium made available in order to encourage participation in the offer. Payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    [IsoId("_N_PuwgU-EeGZxNLgzisRtw")]
    [DisplayName("Solicitation Fees")]
    [IsoXmlTag("SlctnFees")]
    public RestrictedFINActiveCurrencyAndAmount? SolicitationFees { get; init; }

    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_N_PuyAU-EeGZxNLgzisRtw")]
    [DisplayName("Cash In Lieu Of Share")]
    [IsoXmlTag("CshInLieuOfShr")]
    public RestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; }

    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [IsoId("_N_PuzgU-EeGZxNLgzisRtw")]
    [DisplayName("Capital Gain")]
    [IsoXmlTag("CptlGn")]
    public RestrictedFINActiveCurrencyAndAmount? CapitalGain { get; init; }

    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    [IsoId("_N_Pu1AU-EeGZxNLgzisRtw")]
    [DisplayName("Interest Amount")]
    [IsoXmlTag("IntrstAmt")]
    public RestrictedFINActiveCurrencyAndAmount? InterestAmount { get; init; }

    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    [IsoId("_N_Pu2gU-EeGZxNLgzisRtw")]
    [DisplayName("Market Claim Amount")]
    [IsoXmlTag("MktClmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? MarketClaimAmount { get; init; }

    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    [IsoId("_N_Pu4AU-EeGZxNLgzisRtw")]
    [DisplayName("Indemnity Amount")]
    [IsoXmlTag("IndmntyAmt")]
    public RestrictedFINActiveCurrencyAndAmount? IndemnityAmount { get; init; }

    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender. Also covers compensation/indemnity of missed dividend concerning early/late settlements if applicable to a market.
    /// </summary>
    [IsoId("_N_Pu5gU-EeGZxNLgzisRtw")]
    [DisplayName("Manufactured Dividend Payment Amount")]
    [IsoXmlTag("ManfctrdDvddPmtAmt")]
    public ActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; }

    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [IsoId("_N_Pu6QU-EeGZxNLgzisRtw")]
    [DisplayName("Reinvestment Amount")]
    [IsoXmlTag("RinvstmtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ReinvestmentAmount { get; init; }

    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [IsoId("_N_Pu7wU-EeGZxNLgzisRtw")]
    [DisplayName("Fully Franked Amount")]
    [IsoXmlTag("FullyFrnkdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FullyFrankedAmount { get; init; }

    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    [IsoId("_N_Pu9QU-EeGZxNLgzisRtw")]
    [DisplayName("Unfranked Amount")]
    [IsoXmlTag("UfrnkdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? UnfrankedAmount { get; init; }

    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_N_Pu-wU-EeGZxNLgzisRtw")]
    [DisplayName("Sundry Or Other Amount")]
    [IsoXmlTag("SndryOrOthrAmt")]
    public RestrictedFINActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; }

    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example, consent fees or solicitation fees.
    /// </summary>
    [IsoId("_N_PvAQU-EeGZxNLgzisRtw")]
    [DisplayName("Cash Incentive")]
    [IsoXmlTag("CshIncntiv")]
    public RestrictedFINActiveCurrencyAndAmount? CashIncentive { get; init; }

    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_N_PvBwU-EeGZxNLgzisRtw")]
    [DisplayName("Tax Free Amount")]
    [IsoXmlTag("TaxFreeAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxFreeAmount { get; init; }

    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_N_PvDQU-EeGZxNLgzisRtw")]
    [DisplayName("Tax Deferred Amount")]
    [IsoXmlTag("TaxDfrrdAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxDeferredAmount { get; init; }

    /// <summary>
    /// Amount of value added tax.
    /// </summary>
    [IsoId("_N_PvEwU-EeGZxNLgzisRtw")]
    [DisplayName("Value Added Tax Amount")]
    [IsoXmlTag("ValAddedTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; }

    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_N_PvGQU-EeGZxNLgzisRtw")]
    [DisplayName("Stamp Duty Amount")]
    [IsoXmlTag("StmpDtyAmt")]
    public RestrictedFINActiveCurrencyAndAmount? StampDutyAmount { get; init; }

    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_N_PvHwU-EeGZxNLgzisRtw")]
    [DisplayName("Tax Reclaim Amount")]
    [IsoXmlTag("TaxRclmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxReclaimAmount { get; init; }

    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    [IsoId("_N_PvJQU-EeGZxNLgzisRtw")]
    [DisplayName("Tax Credit Amount")]
    [IsoXmlTag("TaxCdtAmt")]
    public RestrictedFINActiveCurrencyAndAmount? TaxCreditAmount { get; init; }

    /// <summary>
    /// Amount of money withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_N_PvKwU-EeGZxNLgzisRtw")]
    [DisplayName("Withholding Of Foreign Tax Amount")]
    [IsoXmlTag("WhldgOfFrgnTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? WithholdingOfForeignTaxAmount { get; init; }

    /// <summary>
    /// Amount of money withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_N_PvMQU-EeGZxNLgzisRtw")]
    [DisplayName("Withholding Of Local Tax Amount")]
    [IsoXmlTag("WhldgOfLclTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? WithholdingOfLocalTaxAmount { get; init; }

    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    [IsoId("_N_PvNwU-EeGZxNLgzisRtw")]
    [DisplayName("Additional Tax Amount")]
    [IsoXmlTag("AddtlTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; }

    /// <summary>
    /// Amount of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_N_PvPQU-EeGZxNLgzisRtw")]
    [DisplayName("Withholding Tax Amount")]
    [IsoXmlTag("WhldgTaxAmt")]
    public RestrictedFINActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    [IsoId("_N_PvQwU-EeGZxNLgzisRtw")]
    [DisplayName("Fiscal Stamp Amount")]
    [IsoXmlTag("FsclStmpAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FiscalStampAmount { get; init; }

    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_N_PvSQU-EeGZxNLgzisRtw")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    [IsoId("_N_PvTwU-EeGZxNLgzisRtw")]
    [DisplayName("Paying Agent Commission Amount")]
    [IsoXmlTag("PngAgtComssnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; }

    /// <summary>
    /// Local broker&apos;s commission.
    /// </summary>
    [IsoId("_N_PvVQU-EeGZxNLgzisRtw")]
    [DisplayName("Local Broker Commission Amount")]
    [IsoXmlTag("LclBrkrComssnAmt")]
    public RestrictedFINActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; }

    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, securities and exchange fees.
    /// </summary>
    [IsoId("_N_PvWwU-EeGZxNLgzisRtw")]
    [DisplayName("Regulatory Fees Amount")]
    [IsoXmlTag("RgltryFeesAmt")]
    public RestrictedFINActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; }

    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    [IsoId("_N_PvYQU-EeGZxNLgzisRtw")]
    [DisplayName("Shipping Fees Amount")]
    [IsoXmlTag("ShppgFeesAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ShippingFeesAmount { get; init; }

    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_N_PvZwU-EeGZxNLgzisRtw")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public RestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; init; }

    /// <summary>
    /// Cash amount based on terms of corporate action event and balance of underlying securities, entitled to/from account owner (which may be positive or negative).
    /// </summary>
    [IsoId("_N_PvbQU-EeGZxNLgzisRtw")]
    [DisplayName("Entitled Amount")]
    [IsoXmlTag("EntitldAmt")]
    public RestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; }

    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_N_PvcwU-EeGZxNLgzisRtw")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public RestrictedFINActiveCurrencyAndAmount? OriginalAmount { get; init; }

    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_N_PveQU-EeGZxNLgzisRtw")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public RestrictedFINActiveCurrencyAndAmount? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    [IsoId("_N_PvfwU-EeGZxNLgzisRtw")]
    [DisplayName("Income Portion")]
    [IsoXmlTag("IncmPrtn")]
    public RestrictedFINActiveCurrencyAndAmount? IncomePortion { get; init; }
}
