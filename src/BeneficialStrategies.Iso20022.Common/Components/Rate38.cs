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
[IsoId("_bZ_ktwVTEeqjd8n6wD9JVw")]
[DisplayName("Rate")]
public record Rate38
{
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_bZ_kzwVTEeqjd8n6wD9JVw")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat46Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_bZ_k0QVTEeqjd8n6wD9JVw")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public GrossDividendRateFormat42Choice_? GrossDividendRate { get; init; }

    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    [IsoId("_bZ_k0wVTEeqjd8n6wD9JVw")]
    [DisplayName("Interest Rate Used For Payment")]
    [IsoXmlTag("IntrstRateUsdForPmt")]
    public InterestRateUsedForPaymentFormat10Choice_? InterestRateUsedForPayment { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_bZ_k1QVTEeqjd8n6wD9JVw")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public RateAndAmountFormat47Choice_? WithholdingTaxRate { get; init; }

    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_bZ_k1wVTEeqjd8n6wD9JVw")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public RateAndAmountFormat47Choice_? SecondLevelTax { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_bZ_k2QVTEeqjd8n6wD9JVw")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat46Choice_? ChargesFees { get; init; }

    /// <summary>
    /// Cash rate made available, as an incentive, in addition to the solicitation fee, in order to encourage early participation in an offer.
    /// </summary>
    [IsoId("_bZ_k2wVTEeqjd8n6wD9JVw")]
    [DisplayName("Early Solicitation Fee Rate")]
    [IsoXmlTag("EarlySlctnFeeRate")]
    public SolicitationFeeRateFormat10Choice_? EarlySolicitationFeeRate { get; init; }

    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_bZ_k3QVTEeqjd8n6wD9JVw")]
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    public RateFormat3Choice_? FiscalStamp { get; init; }

    /// <summary>
    /// Cash rate made available in an event in order to encourage participation in the offer. As information, payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    [IsoId("_bZ_k3wVTEeqjd8n6wD9JVw")]
    [DisplayName("Third Party Incentive Rate")]
    [IsoXmlTag("ThrdPtyIncntivRate")]
    public RateFormat21Choice_? ThirdPartyIncentiveRate { get; init; }

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_bZ_k4QVTEeqjd8n6wD9JVw")]
    [DisplayName("Net Dividend Rate")]
    [IsoXmlTag("NetDvddRate")]
    public NetDividendRateFormat44Choice_? NetDividendRate { get; init; }

    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_bZ_k4wVTEeqjd8n6wD9JVw")]
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    public RateFormat3Choice_? ApplicableRate { get; init; }

    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fee.
    /// </summary>
    [IsoId("_bZ_k5QVTEeqjd8n6wD9JVw")]
    [DisplayName("Solicitation Fee Rate")]
    [IsoXmlTag("SlctnFeeRate")]
    public SolicitationFeeRateFormat10Choice_? SolicitationFeeRate { get; init; }

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_bZ_k5wVTEeqjd8n6wD9JVw")]
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public RateFormat21Choice_? TaxCreditRate { get; init; }

    /// <summary>
    /// Overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_bZ_k6QVTEeqjd8n6wD9JVw")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat46Choice_? TaxOnIncome { get; init; }

    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_bZ_k6wVTEeqjd8n6wD9JVw")]
    [DisplayName("Tax On Profits")]
    [IsoXmlTag("TaxOnPrfts")]
    public RateFormat3Choice_? TaxOnProfits { get; init; }

    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_bZ_k7QVTEeqjd8n6wD9JVw")]
    [DisplayName("Tax Reclaim Rate")]
    [IsoXmlTag("TaxRclmRate")]
    public RateFormat3Choice_? TaxReclaimRate { get; init; }

    /// <summary>
    /// Portion of the fund distribution which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_bZ_k7wVTEeqjd8n6wD9JVw")]
    [DisplayName("Equalisation Rate")]
    [IsoXmlTag("EqulstnRate")]
    public RateAndAmountFormat48Choice_? EqualisationRate { get; init; }

    /// <summary>
    /// Rate applied for the calculation of deemed proceeds which are not paid to security holders but on which withholding tax is applicable.
    /// </summary>
    [IsoId("_bZ_k8QVTEeqjd8n6wD9JVw")]
    [DisplayName("Deemed Rate")]
    [IsoXmlTag("DmdRate")]
    public RateAndAmountFormat53Choice_? DeemedRate { get; init; }
}
