// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the rates related to securities movement.
/// </summary>
[IsoId("_ckMwZ5KQEeWHWpTQn1FFVg")]
[DisplayName("Rate Details")]
public record RateDetails24
{
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_ckMwd5KQEeWHWpTQn1FFVg")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat43Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_ckMweZKQEeWHWpTQn1FFVg")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat43Choice_? ChargesFees { get; init; }

    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_ckMwe5KQEeWHWpTQn1FFVg")]
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? FiscalStamp { get; init; }

    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; rate includes tax credit for companies that have made sufficient tax payments during fiscal period.
    /// </summary>
    [IsoId("_ckMwfZKQEeWHWpTQn1FFVg")]
    [DisplayName("Fully Franked Rate")]
    [IsoXmlTag("FullyFrnkdRate")]
    public RateAndAmountFormat43Choice_? FullyFrankedRate { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_ckMwf5KQEeWHWpTQn1FFVg")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public ValueList<GrossDividendRateFormat24Choice_> GrossDividendRate { get; init; } = [];

    /// <summary>
    /// Cash rate made available, as an incentive, in addition to the solicitation fee, in order to encourage early participation in an offer.
    /// </summary>
    [IsoId("_ckMwgZKQEeWHWpTQn1FFVg")]
    [DisplayName("Early Solicitation Fee Rate")]
    [IsoXmlTag("EarlySlctnFeeRate")]
    public SolicitationFeeRateFormat9Choice_? EarlySolicitationFeeRate { get; init; }

    /// <summary>
    /// Cash rate made available in an event in order to encourage participation in the offer. As information, Payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    [IsoId("_ckMwg5KQEeWHWpTQn1FFVg")]
    [DisplayName("Third Party Incentive Rate")]
    [IsoXmlTag("ThrdPtyIncntivRate")]
    public RateAndAmountFormat43Choice_? ThirdPartyIncentiveRate { get; init; }

    /// <summary>
    /// Actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    [IsoId("_ckMwhZKQEeWHWpTQn1FFVg")]
    [DisplayName("Interest Rate Used For Payment")]
    [IsoXmlTag("IntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat9Choice_> InterestRateUsedForPayment { get; init; } =
        [];

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_ckMwh5KQEeWHWpTQn1FFVg")]
    [DisplayName("Net Dividend Rate")]
    [IsoXmlTag("NetDvddRate")]
    public ValueList<NetDividendRateFormat26Choice_> NetDividendRate { get; init; } = [];

    /// <summary>
    /// Rate per share to which a non-resident is entitled.
    /// </summary>
    [IsoId("_ckMwiZKQEeWHWpTQn1FFVg")]
    [DisplayName("Non Resident Rate")]
    [IsoXmlTag("NonResdtRate")]
    public RateAndAmountFormat43Choice_? NonResidentRate { get; init; }

    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_ckMwi5KQEeWHWpTQn1FFVg")]
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ApplicableRate { get; init; }

    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fee.
    /// </summary>
    [IsoId("_ckMwjZKQEeWHWpTQn1FFVg")]
    [DisplayName("Solicitation Fee Rate")]
    [IsoXmlTag("SlctnFeeRate")]
    public SolicitationFeeRateFormat9Choice_? SolicitationFeeRate { get; init; }

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_ckMwj5KQEeWHWpTQn1FFVg")]
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public ValueList<TaxCreditRateFormat9Choice_> TaxCreditRate { get; init; } = [];

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_ckMwkZKQEeWHWpTQn1FFVg")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat45Choice_> WithholdingTaxRate { get; init; } = [];

    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_ckMwk5KQEeWHWpTQn1FFVg")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat45Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    [IsoId("_ckMwlZKQEeWHWpTQn1FFVg")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat43Choice_? TaxOnIncome { get; init; }

    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_ckMwl5KQEeWHWpTQn1FFVg")]
    [DisplayName("Tax On Profits")]
    [IsoXmlTag("TaxOnPrfts")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TaxOnProfits { get; init; }

    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_ckMwmZKQEeWHWpTQn1FFVg")]
    [DisplayName("Tax Reclaim Rate")]
    [IsoXmlTag("TaxRclmRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TaxReclaimRate { get; init; }

    /// <summary>
    /// Portion of the fund distribution which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_ckMwm5KQEeWHWpTQn1FFVg")]
    [DisplayName("Equalisation Rate")]
    [IsoXmlTag("EqulstnRate")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? EqualisationRate { get; init; }
}
