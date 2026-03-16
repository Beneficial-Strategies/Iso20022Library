// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates.
/// </summary>
[IsoId("_Tf_6BNp-Ed-ak6NoX_4Aeg_-532082484")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate2
{
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_Tf_6Bdp-Ed-ak6NoX_4Aeg_826416270")]
    [DisplayName("Withholding Tax")]
    [IsoXmlTag("WhldgTax")]
    public RateFormat1Choice_? WithholdingTax { get; init; }

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_Tf_6Btp-Ed-ak6NoX_4Aeg_826415385")]
    [DisplayName("Withholding Of Foreign Tax")]
    [IsoXmlTag("WhldgOfFrgnTax")]
    public RateAndAmountFormat1Choice_? WithholdingOfForeignTax { get; init; }

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_Tf_6B9p-Ed-ak6NoX_4Aeg_826415755")]
    [DisplayName("Withholding Of Local Tax")]
    [IsoXmlTag("WhldgOfLclTax")]
    public RateAndAmountFormat1Choice_? WithholdingOfLocalTax { get; init; }

    /// <summary>
    /// Local tax (ZAS Anrechnungsbetrag) subject to interest down payment tax (proportion of interest liable for interest down payment tax/interim profit that is not covered by the tax exempt amount).
    /// </summary>
    [IsoId("_Tf_6CNp-Ed-ak6NoX_4Aeg_826415786")]
    [DisplayName("German Local Tax")]
    [IsoXmlTag("GrmnLclTax1")]
    public RateAndAmountFormat1Choice_? GermanLocalTax1 { get; init; }

    /// <summary>
    /// Local tax (ZAS Pflichtige Zinsen) interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).
    /// </summary>
    [IsoId("_TgJrANp-Ed-ak6NoX_4Aeg_826415839")]
    [DisplayName("German Local Tax")]
    [IsoXmlTag("GrmnLclTax2")]
    public RateAndAmountFormat1Choice_? GermanLocalTax2 { get; init; }

    /// <summary>
    /// Local tax (Zinstopf) offset interest per unit against tax exempt amount (variation to offset interest per unit in relation to tax exempt amount).
    /// </summary>
    [IsoId("_TgJrAdp-Ed-ak6NoX_4Aeg_826415900")]
    [DisplayName("German Local Tax")]
    [IsoXmlTag("GrmnLclTax3")]
    public RateAndAmountFormat1Choice_? GermanLocalTax3 { get; init; }

    /// <summary>
    /// Local tax (Ertrag Besitzanteilig) yield liable for interest down payment tax.
    /// </summary>
    [IsoId("_TgJrAtp-Ed-ak6NoX_4Aeg_826415961")]
    [DisplayName("German Local Tax")]
    [IsoXmlTag("GrmnLclTax4")]
    public RateAndAmountFormat1Choice_? GermanLocalTax4 { get; init; }

    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    [IsoId("_TgJrA9p-Ed-ak6NoX_4Aeg_826416332")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateFormat1Choice_? TaxOnIncome { get; init; }

    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_TgJrBNp-Ed-ak6NoX_4Aeg_826416393")]
    [DisplayName("Tax On Profit")]
    [IsoXmlTag("TaxOnPrft")]
    public RateFormat1Choice_? TaxOnProfit { get; init; }

    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_TgJrBdp-Ed-ak6NoX_4Aeg_826416733")]
    [DisplayName("Tax Reclaim")]
    [IsoXmlTag("TaxRclm")]
    public RateFormat1Choice_? TaxReclaim { get; init; }

    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_TgJrBtp-Ed-ak6NoX_4Aeg_826416787")]
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    public RateFormat1Choice_? FiscalStamp { get; init; }

    /// <summary>
    /// Proportionate allocation used for the offer.
    /// </summary>
    [IsoId("_TgJrB9p-Ed-ak6NoX_4Aeg_1075572437")]
    [DisplayName("Proration")]
    [IsoXmlTag("Prratn")]
    public RateFormat1Choice_? Proration { get; init; }

    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, eg, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    [IsoId("_TgJrCNp-Ed-ak6NoX_4Aeg_1603231836")]
    [DisplayName("New To Old")]
    [IsoXmlTag("NewToOd")]
    public RatioFormat2Choice_? NewToOld { get; init; }

    /// <summary>
    /// Quantity of new equities that will be derived by the exercise of a given quantity of intermediate securities.
    /// </summary>
    [IsoId("_TgJrCdp-Ed-ak6NoX_4Aeg_1603231845")]
    [DisplayName("New Securities To Underlying Securities")]
    [IsoXmlTag("NewSctiesToUndrlygScties")]
    public RatioFormat2Choice_? NewSecuritiesToUnderlyingSecurities { get; init; }

    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, eg, 1 for 1: 1 new|equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    [IsoId("_TgS08Np-Ed-ak6NoX_4Aeg_1603231867")]
    [DisplayName("Additional Quantity For Existing Securities")]
    [IsoXmlTag("AddtlQtyForExstgScties")]
    public RatioFormat1Choice_? AdditionalQuantityForExistingSecurities { get; init; }

    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    [IsoId("_TgS08dp-Ed-ak6NoX_4Aeg_1603231897")]
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    public RatioFormat1Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; }

    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_TgS08tp-Ed-ak6NoX_4Aeg_1114601396")]
    [DisplayName("Related Tax")]
    [IsoXmlTag("RltdTax")]
    public RelatedTaxType1? RelatedTax { get; init; }

    /// <summary>
    /// Rate per share to which a non-resident is entitled.
    /// </summary>
    [IsoId("_TgS089p-Ed-ak6NoX_4Aeg_-1218810199")]
    [DisplayName("Non Resident Rate")]
    [IsoXmlTag("NonResdtRate")]
    public RateAndAmountFormat1Choice_? NonResidentRate { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_TgS09Np-Ed-ak6NoX_4Aeg_-1017726643")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public RateAndAmountFormat1Choice_? Charges { get; init; }

    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    [IsoId("_TgS09dp-Ed-ak6NoX_4Aeg_32788550")]
    [DisplayName("Interest For Used Payment")]
    [IsoXmlTag("IntrstForUsdPmt")]
    public RateAndAmountFormat1Choice_? InterestForUsedPayment { get; init; }

    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    [IsoId("_TgS09tp-Ed-ak6NoX_4Aeg_192556704")]
    [DisplayName("Index Factor")]
    [IsoXmlTag("IndxFctr")]
    public RateAndAmountFormat1Choice_? IndexFactor { get; init; }

    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; rate includes tax credit for companies that have made sufficient tax payments during fiscal period.
    /// </summary>
    [IsoId("_TgS099p-Ed-ak6NoX_4Aeg_1674113782")]
    [DisplayName("Fully Franked")]
    [IsoXmlTag("FullyFrnkd")]
    public RateAndAmountFormat1Choice_? FullyFranked { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_TgS0-Np-Ed-ak6NoX_4Aeg_1674114207")]
    [DisplayName("Gross Dividend")]
    [IsoXmlTag("GrssDvdd")]
    public GrossDividendRate1Choice_? GrossDividend { get; init; }

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_TgS0-dp-Ed-ak6NoX_4Aeg_-852869139")]
    [DisplayName("Net Dividend")]
    [IsoXmlTag("NetDvdd")]
    public NetDividendRate1Choice_? NetDividend { get; init; }

    /// <summary>
    /// Dividend is final.
    /// </summary>
    [IsoId("_Tgcl8Np-Ed-ak6NoX_4Aeg_1093913528")]
    [DisplayName("Final Dividend")]
    [IsoXmlTag("FnlDvdd")]
    public AmountAndRateFormat2Choice_? FinalDividend { get; init; }

    /// <summary>
    /// Dividend is provisional.
    /// </summary>
    [IsoId("_Tgcl8dp-Ed-ak6NoX_4Aeg_1507650520")]
    [DisplayName("Provisional Dividend")]
    [IsoXmlTag("PrvsnlDvdd")]
    public AmountAndRateFormat2Choice_? ProvisionalDividend { get; init; }

    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, e.g. consent fees.
    /// </summary>
    [IsoId("_Tgcl8tp-Ed-ak6NoX_4Aeg_2061068045")]
    [DisplayName("Cash Incentive")]
    [IsoXmlTag("CshIncntiv")]
    public RateFormat1Choice_? CashIncentive { get; init; }

    /// <summary>
    /// Cash rate made available in an offer in order to encourage participation in the offer.
    /// </summary>
    [IsoId("_Tgcl89p-Ed-ak6NoX_4Aeg_1708651176")]
    [DisplayName("Solicitation Fee")]
    [IsoXmlTag("SlctnFee")]
    public RateFormat1Choice_? SolicitationFee { get; init; }

    /// <summary>
    /// A maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, eg, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50%.
    /// </summary>
    [IsoId("_Tgcl9Np-Ed-ak6NoX_4Aeg_-1566749496")]
    [DisplayName("Maximum Allowed Oversubscription")]
    [IsoXmlTag("MaxAllwdOvrsbcpt")]
    public RateFormat1Choice_? MaximumAllowedOversubscription { get; init; }

    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_Tgcl9dp-Ed-ak6NoX_4Aeg_826416240")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat1Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_Tgcl9tp-Ed-ak6NoX_4Aeg_970763826")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public ActiveCurrencyAndAmount? OriginalAmount { get; init; }

    /// <summary>
    /// Provides information about a foreign exchange.
    /// </summary>
    [IsoId("_Tgcl99p-Ed-ak6NoX_4Aeg_250066085")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public ForeignExchangeTerms8? ExchangeRate { get; init; }

    /// <summary>
    /// Rate applicable to the event announced, eg, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_Tgcl-Np-Ed-ak6NoX_4Aeg_-745146054")]
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    public RateFormat1Choice_? ApplicableRate { get; init; }
}
