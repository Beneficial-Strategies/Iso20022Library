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
[IsoId("_3rpUgfPzEd-ezLm12ErWqA")]
[DisplayName("Corporate Action Amounts")]
public record CorporateActionAmounts11
{
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_3rpUg_PzEd-ezLm12ErWqA")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstngAmt")]
    public required ActiveCurrencyAndAmount PostingAmount { get; init; }

    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_3rpUhfPzEd-ezLm12ErWqA")]
    [DisplayName("Gross Cash Amount")]
    [IsoXmlTag("GrssCshAmt")]
    public ActiveCurrencyAndAmount? GrossCashAmount { get; init; }

    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_3rpUh_PzEd-ezLm12ErWqA")]
    [DisplayName("Net Cash Amount")]
    [IsoXmlTag("NetCshAmt")]
    public ActiveCurrencyAndAmount? NetCashAmount { get; init; }

    /// <summary>
    /// Amount of cash premium made available in order to encourage participation in the offer. Payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    [IsoId("_3rpUifPzEd-ezLm12ErWqA")]
    [DisplayName("Solicitation Fees")]
    [IsoXmlTag("SlctnFees")]
    public ActiveCurrencyAndAmount? SolicitationFees { get; init; }

    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_3rpUi_PzEd-ezLm12ErWqA")]
    [DisplayName("Cash In Lieu Of Share")]
    [IsoXmlTag("CshInLieuOfShr")]
    public ActiveCurrencyAndAmount? CashInLieuOfShare { get; init; }

    /// <summary>
    /// Amount of money distributed as the result of a capital gain.
    /// </summary>
    [IsoId("_3rpUjfPzEd-ezLm12ErWqA")]
    [DisplayName("Capital Gain")]
    [IsoXmlTag("CptlGn")]
    public ActiveCurrencyAndAmount? CapitalGain { get; init; }

    /// <summary>
    /// Amount of money representing a coupon payment.
    /// </summary>
    [IsoId("_3rpUj_PzEd-ezLm12ErWqA")]
    [DisplayName("Interest Amount")]
    [IsoXmlTag("IntrstAmt")]
    public ActiveCurrencyAndAmount? InterestAmount { get; init; }

    /// <summary>
    /// Amount of money resulting from a market claim.
    /// </summary>
    [IsoId("_3rpUkfPzEd-ezLm12ErWqA")]
    [DisplayName("Market Claim Amount")]
    [IsoXmlTag("MktClmAmt")]
    public ActiveCurrencyAndAmount? MarketClaimAmount { get; init; }

    /// <summary>
    /// (Unique to France) Amount due to a buyer of securities dealt prior to ex date which may be subject to different rate of taxation.
    /// </summary>
    [IsoId("_3rpUk_PzEd-ezLm12ErWqA")]
    [DisplayName("Indemnity Amount")]
    [IsoXmlTag("IndmntyAmt")]
    public ActiveCurrencyAndAmount? IndemnityAmount { get; init; }

    /// <summary>
    /// Amount of money that the borrower pays to the lender as a compensation. It does not entitle the lender to reclaim any tax credit and is sometimes treated differently by the local tax authorities of the lender. Also covers compensation/indemnity of missed dividend concerning early/late settlements if applicable to a market.
    /// </summary>
    [IsoId("_3rpUlfPzEd-ezLm12ErWqA")]
    [DisplayName("Manufactured Dividend Payment Amount")]
    [IsoXmlTag("ManfctrdDvddPmtAmt")]
    public ActiveCurrencyAndAmount? ManufacturedDividendPaymentAmount { get; init; }

    /// <summary>
    /// Amount of money reinvested in additional securities.
    /// </summary>
    [IsoId("_3rpUl_PzEd-ezLm12ErWqA")]
    [DisplayName("Reinvestment Amount")]
    [IsoXmlTag("RinvstmtAmt")]
    public ActiveCurrencyAndAmount? ReinvestmentAmount { get; init; }

    /// <summary>
    /// Amount resulting from a fully franked dividend paid by a company; amount includes tax credit for companies that have made sufficient tax payments during the fiscal period.
    /// </summary>
    [IsoId("_3rpUmfPzEd-ezLm12ErWqA")]
    [DisplayName("Fully Franked Amount")]
    [IsoXmlTag("FullyFrnkdAmt")]
    public ActiveCurrencyAndAmount? FullyFrankedAmount { get; init; }

    /// <summary>
    /// Amount resulting from an unfranked dividend paid by a company; the amount does not include tax credit and is subject to withholding tax.
    /// </summary>
    [IsoId("_3rpUm_PzEd-ezLm12ErWqA")]
    [DisplayName("Unfranked Amount")]
    [IsoXmlTag("UfrnkdAmt")]
    public ActiveCurrencyAndAmount? UnfrankedAmount { get; init; }

    /// <summary>
    /// Amount of money related to taxable income that cannot be categorised.
    /// </summary>
    [IsoId("_3rpUnfPzEd-ezLm12ErWqA")]
    [DisplayName("Sundry Or Other Amount")]
    [IsoXmlTag("SndryOrOthrAmt")]
    public ActiveCurrencyAndAmount? SundryOrOtherAmount { get; init; }

    /// <summary>
    /// Cash premium made available if the securities holder consents or participates to an event, for example, consent fees or solicitation fees.
    /// </summary>
    [IsoId("_3rpUn_PzEd-ezLm12ErWqA")]
    [DisplayName("Cash Incentive")]
    [IsoXmlTag("CshIncntiv")]
    public ActiveCurrencyAndAmount? CashIncentive { get; init; }

    /// <summary>
    /// Amount of money that has not been subject to taxation.
    /// </summary>
    [IsoId("_3rpUofPzEd-ezLm12ErWqA")]
    [DisplayName("Tax Free Amount")]
    [IsoXmlTag("TaxFreeAmt")]
    public ActiveCurrencyAndAmount? TaxFreeAmount { get; init; }

    /// <summary>
    /// Amount of income eligible for deferred taxation.
    /// </summary>
    [IsoId("_3rpUo_PzEd-ezLm12ErWqA")]
    [DisplayName("Tax Deferred Amount")]
    [IsoXmlTag("TaxDfrrdAmt")]
    public ActiveCurrencyAndAmount? TaxDeferredAmount { get; init; }

    /// <summary>
    /// Tax on value added.
    /// </summary>
    [IsoId("_3rpUpfPzEd-ezLm12ErWqA")]
    [DisplayName("Value Added Tax Amount")]
    [IsoXmlTag("ValAddedTaxAmt")]
    public ActiveCurrencyAndAmount? ValueAddedTaxAmount { get; init; }

    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    [IsoId("_3rpUp_PzEd-ezLm12ErWqA")]
    [DisplayName("Stamp Duty Amount")]
    [IsoXmlTag("StmpDtyAmt")]
    public ActiveCurrencyAndAmount? StampDutyAmount { get; init; }

    /// <summary>
    /// Amount that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_3rpUqfPzEd-ezLm12ErWqA")]
    [DisplayName("Tax Reclaim Amount")]
    [IsoXmlTag("TaxRclmAmt")]
    public ActiveCurrencyAndAmount? TaxReclaimAmount { get; init; }

    /// <summary>
    /// Amount of taxes that have been previously paid in relation to the taxable event.
    /// </summary>
    [IsoId("_3rpUq_PzEd-ezLm12ErWqA")]
    [DisplayName("Tax Credit Amount")]
    [IsoXmlTag("TaxCdtAmt")]
    public ActiveCurrencyAndAmount? TaxCreditAmount { get; init; }

    /// <summary>
    /// Amount of money withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_3rpUrfPzEd-ezLm12ErWqA")]
    [DisplayName("Withholding Of Foreign Tax Amount")]
    [IsoXmlTag("WhldgOfFrgnTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingOfForeignTaxAmount { get; init; }

    /// <summary>
    /// Amount of money withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_3rpUr_PzEd-ezLm12ErWqA")]
    [DisplayName("Withholding Of Local Tax Amount")]
    [IsoXmlTag("WhldgOfLclTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingOfLocalTaxAmount { get; init; }

    /// <summary>
    /// Amount of additional taxes that cannot be categorised.
    /// </summary>
    [IsoId("_3rpUsfPzEd-ezLm12ErWqA")]
    [DisplayName("Additional Tax Amount")]
    [IsoXmlTag("AddtlTaxAmt")]
    public ActiveCurrencyAndAmount? AdditionalTaxAmount { get; init; }

    /// <summary>
    /// Amount of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_3rpUs_PzEd-ezLm12ErWqA")]
    [DisplayName("Withholding Tax Amount")]
    [IsoXmlTag("WhldgTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; }

    /// <summary>
    /// Amount of fiscal tax to apply.
    /// </summary>
    [IsoId("_3rpUtfPzEd-ezLm12ErWqA")]
    [DisplayName("Fiscal Stamp Amount")]
    [IsoXmlTag("FsclStmpAmt")]
    public ActiveCurrencyAndAmount? FiscalStampAmount { get; init; }

    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    [IsoId("_3rpUt_PzEd-ezLm12ErWqA")]
    [DisplayName("Executing Broker Amount")]
    [IsoXmlTag("ExctgBrkrAmt")]
    public ActiveCurrencyAndAmount? ExecutingBrokerAmount { get; init; }

    /// <summary>
    /// Amount of paying/sub-paying agent commission.
    /// </summary>
    [IsoId("_3rpUufPzEd-ezLm12ErWqA")]
    [DisplayName("Paying Agent Commission Amount")]
    [IsoXmlTag("PngAgtComssnAmt")]
    public ActiveCurrencyAndAmount? PayingAgentCommissionAmount { get; init; }

    /// <summary>
    /// Local broker&apos;s commission.
    /// </summary>
    [IsoId("_3rpUu_PzEd-ezLm12ErWqA")]
    [DisplayName("Local Broker Commission Amount")]
    [IsoXmlTag("LclBrkrComssnAmt")]
    public ActiveCurrencyAndAmount? LocalBrokerCommissionAmount { get; init; }

    /// <summary>
    /// Amount of money paid for delivery by regular post mail.
    /// </summary>
    [IsoId("_3rpUvfPzEd-ezLm12ErWqA")]
    [DisplayName("Postage Fee Amount")]
    [IsoXmlTag("PstgFeeAmt")]
    public ActiveCurrencyAndAmount? PostageFeeAmount { get; init; }

    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    [IsoId("_3rpUv_PzEd-ezLm12ErWqA")]
    [DisplayName("Regulatory Fees Amount")]
    [IsoXmlTag("RgltryFeesAmt")]
    public ActiveCurrencyAndAmount? RegulatoryFeesAmount { get; init; }

    /// <summary>
    /// Amount of money (including insurance) paid for delivery by carrier.
    /// </summary>
    [IsoId("_3rpUwfPzEd-ezLm12ErWqA")]
    [DisplayName("Shipping Fees Amount")]
    [IsoXmlTag("ShppgFeesAmt")]
    public ActiveCurrencyAndAmount? ShippingFeesAmount { get; init; }

    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    [IsoId("_3rpUw_PzEd-ezLm12ErWqA")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public ActiveCurrencyAndAmount? ChargesAmount { get; init; }

    /// <summary>
    /// Indicates cash retained from previous dividend.
    /// </summary>
    [IsoId("_3rpUxfPzEd-ezLm12ErWqA")]
    [DisplayName("Cash Amount Brought Forward")]
    [IsoXmlTag("CshAmtBrghtFwd")]
    public ActiveCurrencyAndAmount? CashAmountBroughtForward { get; init; }

    /// <summary>
    /// Indicates the balance carried forward to next dividend.
    /// </summary>
    [IsoId("_3rpUx_PzEd-ezLm12ErWqA")]
    [DisplayName("Cash Amount Carried Forward")]
    [IsoXmlTag("CshAmtCrrdFwd")]
    public ActiveCurrencyAndAmount? CashAmountCarriedForward { get; init; }

    /// <summary>
    /// Amount of cash that would have been payable if the dividend had been taken in the form of cash rather than shares.
    /// </summary>
    [IsoId("_3rpUyfPzEd-ezLm12ErWqA")]
    [DisplayName("Notional Dividend Payable Amount")]
    [IsoXmlTag("NtnlDvddPyblAmt")]
    public ActiveCurrencyAndAmount? NotionalDividendPayableAmount { get; init; }

    /// <summary>
    /// Where new securities are issued in lieu of a cash dividend, the notional tax is the tax on the amount of cash that would have been paid.
    /// </summary>
    [IsoId("_3rpUy_PzEd-ezLm12ErWqA")]
    [DisplayName("Notional Tax Amount")]
    [IsoXmlTag("NtnlTaxAmt")]
    public ActiveCurrencyAndAmount? NotionalTaxAmount { get; init; }

    /// <summary>
    /// Amount of money paid by the Tax Authorities in addition to the payment of the tax refund itself.
    /// </summary>
    [IsoId("_3rpUzfPzEd-ezLm12ErWqA")]
    [DisplayName("Tax Arrears Amount")]
    [IsoXmlTag("TaxArrearsAmt")]
    public ActiveCurrencyAndAmount? TaxArrearsAmount { get; init; }

    /// <summary>
    /// Posting/settlement Amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_3rpUz_PzEd-ezLm12ErWqA")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public ActiveCurrencyAndAmount? OriginalAmount { get; init; }

    /// <summary>
    /// Amount of money representing a distribution of a bond&apos;s principal, for example, repayment of outstanding debt.
    /// </summary>
    [IsoId("_3rpU0fPzEd-ezLm12ErWqA")]
    [DisplayName("Principal Or Corpus")]
    [IsoXmlTag("PrncplOrCrps")]
    public ActiveCurrencyAndAmount? PrincipalOrCorpus { get; init; }

    /// <summary>
    /// Amount of money (not interest) in addition to the principal at the redemption of a bond.
    /// </summary>
    [IsoId("_3rpU0_PzEd-ezLm12ErWqA")]
    [DisplayName("Redemption Premium Amount")]
    [IsoXmlTag("RedPrmAmt")]
    public ActiveCurrencyAndAmount? RedemptionPremiumAmount { get; init; }

    /// <summary>
    /// Amount relating to the underlying security for which income is distributed.
    /// </summary>
    [IsoId("_3rpU1fPzEd-ezLm12ErWqA")]
    [DisplayName("Income Portion")]
    [IsoXmlTag("IncmPrtn")]
    public ActiveCurrencyAndAmount? IncomePortion { get; init; }

    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    [IsoId("_3rpU1_PzEd-ezLm12ErWqA")]
    [DisplayName("Stock Exchange Tax")]
    [IsoXmlTag("StockXchgTax")]
    public ActiveCurrencyAndAmount? StockExchangeTax { get; init; }

    /// <summary>
    /// Total amount of tax withheld at source in conformance with the EU Savings Directive.
    /// </summary>
    [IsoId("_3rpU2fPzEd-ezLm12ErWqA")]
    [DisplayName("EU Tax Retention Amount")]
    [IsoXmlTag("EUTaxRtntnAmt")]
    public ActiveCurrencyAndAmount? EUTaxRetentionAmount { get; init; }

    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_3rpU2_PzEd-ezLm12ErWqA")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public ActiveCurrencyAndAmount? AccruedInterestAmount { get; init; }
}
