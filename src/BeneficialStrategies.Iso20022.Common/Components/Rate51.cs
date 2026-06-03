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
[IsoId("_J2PZIa3gEfCN-rGCydxGUA")]
[DisplayName("Rate51")]
public record Rate51
{
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_J-iZl63gEfCN-rGCydxGUA")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat59Choice? AdditionalTax { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_J-iZma3gEfCN-rGCydxGUA")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat59Choice? ChargesFees { get; init; }

    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_J-iZm63gEfCN-rGCydxGUA")]
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    public IsoPercentage14Rate? FiscalStamp { get; init; }

    /// <summary>
    /// Distribution rate before tax has been deducted.
    /// </summary>
    [IsoId("_J-iZna3gEfCN-rGCydxGUA")]
    [DisplayName("Gross Distribution Rate")]
    [IsoXmlTag("GrssDstrbtnRate")]
    public ValueList<GrossDividendRateFormat37Choice> GrossDistributionRate { get; init; } = [];

    /// <summary>
    /// Cash rate made available, as an incentive, in addition to the solicitation fee, in order to encourage early participation in an offer.
    /// </summary>
    [IsoId("_J-iZn63gEfCN-rGCydxGUA")]
    [DisplayName("Early Solicitation Fee Rate")]
    [IsoXmlTag("EarlySlctnFeeRate")]
    public SolicitationFeeRateFormat12Choice? EarlySolicitationFeeRate { get; init; }

    /// <summary>
    /// Cash rate made available in an event in order to encourage participation in the offer.
    /// </summary>
    [IsoId("_J-iZoa3gEfCN-rGCydxGUA")]
    [DisplayName("Third Party Incentive Rate")]
    [IsoXmlTag("ThrdPtyIncntivRate")]
    public RateAndAmountFormat59Choice? ThirdPartyIncentiveRate { get; init; }

    /// <summary>
    /// Actual interest rate before tax used for the payment of the interest for the specified interest period.
    /// </summary>
    [IsoId("_J-iZo63gEfCN-rGCydxGUA")]
    [DisplayName("Gross Interest Rate Used For Payment")]
    [IsoXmlTag("GrssIntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat12Choice> GrossInterestRateUsedForPayment { get; init; } = [];

    /// <summary>
    /// Distribution rate after tax has been deducted.
    /// </summary>
    [IsoId("_J-iZpa3gEfCN-rGCydxGUA")]
    [DisplayName("Net Distribution Rate")]
    [IsoXmlTag("NetDstrbtnRate")]
    public ValueList<NetDividendRateFormat40Choice> NetDistributionRate { get; init; } = [];

    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_J-iZp63gEfCN-rGCydxGUA")]
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    public RateFormat31Choice? ApplicableRate { get; init; }

    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event.
    /// </summary>
    [IsoId("_J-iZqa3gEfCN-rGCydxGUA")]
    [DisplayName("Solicitation Fee Rate")]
    [IsoXmlTag("SlctnFeeRate")]
    public SolicitationFeeRateFormat12Choice? SolicitationFeeRate { get; init; }

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_J-iZq63gEfCN-rGCydxGUA")]
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public RateFormat27Choice? TaxCreditRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer.
    /// </summary>
    [IsoId("_J-iZra3gEfCN-rGCydxGUA")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat55Choice> WithholdingTaxRate { get; init; } = [];

    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer's country of tax incorporation.
    /// </summary>
    [IsoId("_J-iZr63gEfCN-rGCydxGUA")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat55Choice> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    [IsoId("_J-iZsa3gEfCN-rGCydxGUA")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat59Choice? TaxOnIncome { get; init; }

    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_J-iZs63gEfCN-rGCydxGUA")]
    [DisplayName("Tax On Profits")]
    [IsoXmlTag("TaxOnPrfts")]
    public IsoPercentage14Rate? TaxOnProfits { get; init; }

    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_J-iZta3gEfCN-rGCydxGUA")]
    [DisplayName("Tax Reclaim Rate")]
    [IsoXmlTag("TaxRclmRate")]
    public IsoPercentage14Rate? TaxReclaimRate { get; init; }

    /// <summary>
    /// Portion of the fund distribution which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_J-iZt63gEfCN-rGCydxGUA")]
    [DisplayName("Equalisation Rate")]
    [IsoXmlTag("EqulstnRate")]
    public ActiveCurrencyAnd13DecimalAmount? EqualisationRate { get; init; }

    /// <summary>
    /// Rate applied for the calculation of deemed proceeds which are not paid to security holders but on which withholding tax is applicable.
    /// </summary>
    [IsoId("_J-iZua3gEfCN-rGCydxGUA")]
    [DisplayName("Deemed Rate")]
    [IsoXmlTag("DmdRate")]
    public ValueList<RateAndAmountFormat62Choice> DeemedRate { get; init; } = [];
}
