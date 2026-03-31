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
[IsoId("_w94igYl2EeavwKddCbm3hg")]
[DisplayName("Rate Details")]
public record RateDetails26
{
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_xXCCX4l2EeavwKddCbm3hg")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat37Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_xXCCYYl2EeavwKddCbm3hg")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public ValueList<GrossDividendRateFormat20Choice_> GrossDividendRate { get; init; } = [];

    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    [IsoId("_xXCCY4l2EeavwKddCbm3hg")]
    [DisplayName("Interest Rate Used For Payment")]
    [IsoXmlTag("IntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat8Choice_> InterestRateUsedForPayment { get; init; } =
        [];

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_xXCCZYl2EeavwKddCbm3hg")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat41Choice_> WithholdingTaxRate { get; init; } = [];

    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_xXCCZ4l2EeavwKddCbm3hg")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat41Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_xXCCaYl2EeavwKddCbm3hg")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat37Choice_? ChargesFees { get; init; }

    /// <summary>
    /// Cash rate made available, as an incentive, in addition to the solicitation fee, in order to encourage early participation in an offer.
    /// </summary>
    [IsoId("_xXCCa4l2EeavwKddCbm3hg")]
    [DisplayName("Early Solicitation Fee Rate")]
    [IsoXmlTag("EarlySlctnFeeRate")]
    public SolicitationFeeRateFormat7Choice_? EarlySolicitationFeeRate { get; init; }

    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_xXCCbYl2EeavwKddCbm3hg")]
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    public RateFormat3Choice_? FiscalStamp { get; init; }

    /// <summary>
    /// Cash rate made available in an event in order to encourage participation in the offer. As information, payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    [IsoId("_xXCCcYl2EeavwKddCbm3hg")]
    [DisplayName("Third Party Incentive Rate")]
    [IsoXmlTag("ThrdPtyIncntivRate")]
    public RateFormat20Choice_? ThirdPartyIncentiveRate { get; init; }

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_xXCCc4l2EeavwKddCbm3hg")]
    [DisplayName("Net Dividend Rate")]
    [IsoXmlTag("NetDvddRate")]
    public ValueList<NetDividendRateFormat22Choice_> NetDividendRate { get; init; } = [];

    /// <summary>
    /// Rate per share to which a non-resident is entitled.
    /// </summary>
    [IsoId("_xXCCdYl2EeavwKddCbm3hg")]
    [DisplayName("Non Resident Rate")]
    [IsoXmlTag("NonResdtRate")]
    public RateAndAmountFormat37Choice_? NonResidentRate { get; init; }

    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_xXCCd4l2EeavwKddCbm3hg")]
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    public RateFormat3Choice_? ApplicableRate { get; init; }

    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fee.
    /// </summary>
    [IsoId("_xXCCeYl2EeavwKddCbm3hg")]
    [DisplayName("Solicitation Fee Rate")]
    [IsoXmlTag("SlctnFeeRate")]
    public SolicitationFeeRateFormat7Choice_? SolicitationFeeRate { get; init; }

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_xXCCe4l2EeavwKddCbm3hg")]
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public ValueList<TaxCreditRateFormat8Choice_> TaxCreditRate { get; init; } = [];

    /// <summary>
    /// Overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_xXCCfYl2EeavwKddCbm3hg")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat37Choice_? TaxOnIncome { get; init; }

    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_xXCCf4l2EeavwKddCbm3hg")]
    [DisplayName("Tax On Profits")]
    [IsoXmlTag("TaxOnPrfts")]
    public RateFormat3Choice_? TaxOnProfits { get; init; }

    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_xXCCgYl2EeavwKddCbm3hg")]
    [DisplayName("Tax Reclaim Rate")]
    [IsoXmlTag("TaxRclmRate")]
    public RateFormat3Choice_? TaxReclaimRate { get; init; }

    /// <summary>
    /// Portion of the fund distribution which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_xXCCg4l2EeavwKddCbm3hg")]
    [DisplayName("Equalisation Rate")]
    [IsoXmlTag("EqulstnRate")]
    public RateAndAmountFormat42Choice_? EqualisationRate { get; init; }
}
