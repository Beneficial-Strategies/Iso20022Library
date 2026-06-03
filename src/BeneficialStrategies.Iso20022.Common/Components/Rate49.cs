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
[IsoId("_vnDPwa3cEfCN-rGCydxGUA")]
[DisplayName("Rate49")]
public record Rate49
{
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_vvEjZ63cEfCN-rGCydxGUA")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat57Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Distribution rate before tax has been deducted.
    /// </summary>
    [IsoId("_vvEjaa3cEfCN-rGCydxGUA")]
    [DisplayName("Gross Distribution Rate")]
    [IsoXmlTag("GrssDstrbtnRate")]
    public ValueList<GrossDividendRateFormat38Choice_> GrossDistributionRate { get; init; } = [];

    /// <summary>
    /// The actual interest rate before tax used for the payment of the interest for the specified interest period.
    /// </summary>
    [IsoId("_vvFKYa3cEfCN-rGCydxGUA")]
    [DisplayName("Gross Interest Rate Used For Payment")]
    [IsoXmlTag("GrssIntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat11Choice_> GrossInterestRateUsedForPayment { get; init; } = [];

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer.
    /// </summary>
    [IsoId("_vvFKY63cEfCN-rGCydxGUA")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat56Choice_> WithholdingTaxRate { get; init; } = [];

    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer's country of tax incorporation.
    /// </summary>
    [IsoId("_vvFKZa3cEfCN-rGCydxGUA")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat56Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_vvFKZ63cEfCN-rGCydxGUA")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat57Choice_? ChargesFees { get; init; }

    /// <summary>
    /// Cash rate made available, as an incentive, in addition to the solicitation fee, in order to encourage early participation in an offer.
    /// </summary>
    [IsoId("_vvFKaa3cEfCN-rGCydxGUA")]
    [DisplayName("Early Solicitation Fee Rate")]
    [IsoXmlTag("EarlySlctnFeeRate")]
    public SolicitationFeeRateFormat11Choice_? EarlySolicitationFeeRate { get; init; }

    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_vvFKa63cEfCN-rGCydxGUA")]
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    public RateFormat24Choice_? FiscalStamp { get; init; }

    /// <summary>
    /// Cash rate made available in an event in order to encourage participation in the offer.
    /// </summary>
    [IsoId("_vvFKba3cEfCN-rGCydxGUA")]
    [DisplayName("Third Party Incentive Rate")]
    [IsoXmlTag("ThrdPtyIncntivRate")]
    public RateFormat26Choice_? ThirdPartyIncentiveRate { get; init; }

    /// <summary>
    /// Distribution rate after tax has been deducted.
    /// </summary>
    [IsoId("_vvFKb63cEfCN-rGCydxGUA")]
    [DisplayName("Net Distribution Rate")]
    [IsoXmlTag("NetDstrbtnRate")]
    public ValueList<NetDividendRateFormat39Choice_> NetDistributionRate { get; init; } = [];

    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_vvFKca3cEfCN-rGCydxGUA")]
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    public RateFormat31Choice_? ApplicableRate { get; init; }

    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event.
    /// </summary>
    [IsoId("_vvFKc63cEfCN-rGCydxGUA")]
    [DisplayName("Solicitation Fee Rate")]
    [IsoXmlTag("SlctnFeeRate")]
    public SolicitationFeeRateFormat11Choice_? SolicitationFeeRate { get; init; }

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_vvFKda3cEfCN-rGCydxGUA")]
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public RateFormat26Choice_? TaxCreditRate { get; init; }

    /// <summary>
    /// Overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_vvFKd63cEfCN-rGCydxGUA")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat57Choice_? TaxOnIncome { get; init; }

    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_vvFKea3cEfCN-rGCydxGUA")]
    [DisplayName("Tax On Profits")]
    [IsoXmlTag("TaxOnPrfts")]
    public RateFormat24Choice_? TaxOnProfits { get; init; }

    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_vvFKe63cEfCN-rGCydxGUA")]
    [DisplayName("Tax Reclaim Rate")]
    [IsoXmlTag("TaxRclmRate")]
    public RateFormat24Choice_? TaxReclaimRate { get; init; }

    /// <summary>
    /// Portion of the fund distribution which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_vvFKfa3cEfCN-rGCydxGUA")]
    [DisplayName("Equalisation Rate")]
    [IsoXmlTag("EqulstnRate")]
    public RateAndAmountFormat42Choice_? EqualisationRate { get; init; }

    /// <summary>
    /// Rate applied for the calculation of deemed proceeds which are not paid to security holders but on which withholding tax is applicable.
    /// </summary>
    [IsoId("_vvFKf63cEfCN-rGCydxGUA")]
    [DisplayName("Deemed Rate")]
    [IsoXmlTag("DmdRate")]
    public ValueList<RateAndAmountFormat61Choice_> DeemedRate { get; init; } = [];

    /// <summary>
    /// Redemption Price expressed as a percentage.
    /// </summary>
    [IsoId("_vvFKga3cEfCN-rGCydxGUA")]
    [DisplayName("Principle Rate")]
    [IsoXmlTag("PrncpleRate")]
    public RateFormat24Choice_? PrincipleRate { get; init; }
}
