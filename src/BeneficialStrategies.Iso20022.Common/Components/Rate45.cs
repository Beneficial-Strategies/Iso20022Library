// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rate45.
/// </summary>
[IsoId("_kv_dP5t3Ee-wQIOX0djF2w")]
[DisplayName("Rate45")]
public record Rate45
{
    /// <summary>
    /// Additional Tax.
    /// </summary>
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat67Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Applicable Rate.
    /// </summary>
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    public IsoPercentage14Rate? ApplicableRate { get; init; }

    /// <summary>
    /// Charges Fees.
    /// </summary>
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat67Choice_? ChargesFees { get; init; }

    /// <summary>
    /// Deemed Rate.
    /// </summary>
    [DisplayName("Deemed Rate")]
    [IsoXmlTag("DmdRate")]
    public ValueList<RateAndAmountFormat68Choice_> DeemedRate { get; init; } = [];

    /// <summary>
    /// Early Solicitation Fee Rate.
    /// </summary>
    [DisplayName("Early Solicitation Fee Rate")]
    [IsoXmlTag("EarlySlctnFeeRate")]
    public SolicitationFeeRateFormat13Choice_? EarlySolicitationFeeRate { get; init; }

    /// <summary>
    /// Equalisation Rate.
    /// </summary>
    [DisplayName("Equalisation Rate")]
    [IsoXmlTag("EqulstnRate")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? EqualisationRate { get; init; }

    /// <summary>
    /// Fiscal Stamp.
    /// </summary>
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    public IsoPercentage14Rate? FiscalStamp { get; init; }

    /// <summary>
    /// Gross Distribution Rate.
    /// </summary>
    [DisplayName("Gross Distribution Rate")]
    [IsoXmlTag("GrssDstrbtnRate")]
    public ValueList<GrossDividendRateFormat40Choice_> GrossDistributionRate { get; init; } = [];

    /// <summary>
    /// Gross Interest Rate Used For Payment.
    /// </summary>
    [DisplayName("Gross Interest Rate Used For Payment")]
    [IsoXmlTag("GrssIntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat19Choice_> GrossInterestRateUsedForPayment { get; init; } =
        [];

    /// <summary>
    /// Net Distribution Rate.
    /// </summary>
    [DisplayName("Net Distribution Rate")]
    [IsoXmlTag("NetDstrbtnRate")]
    public ValueList<NetDividendRateFormat42Choice_> NetDistributionRate { get; init; } = [];

    /// <summary>
    /// Second Level Tax.
    /// </summary>
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat66Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Solicitation Fee Rate.
    /// </summary>
    [DisplayName("Solicitation Fee Rate")]
    [IsoXmlTag("SlctnFeeRate")]
    public SolicitationFeeRateFormat13Choice_? SolicitationFeeRate { get; init; }

    /// <summary>
    /// Tax Credit Rate.
    /// </summary>
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public RateFormat28Choice_? TaxCreditRate { get; init; }

    /// <summary>
    /// Tax On Income.
    /// </summary>
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat67Choice_? TaxOnIncome { get; init; }

    /// <summary>
    /// Tax On Profits.
    /// </summary>
    [DisplayName("Tax On Profits")]
    [IsoXmlTag("TaxOnPrfts")]
    public IsoPercentage14Rate? TaxOnProfits { get; init; }

    /// <summary>
    /// Tax Reclaim Rate.
    /// </summary>
    [DisplayName("Tax Reclaim Rate")]
    [IsoXmlTag("TaxRclmRate")]
    public IsoPercentage14Rate? TaxReclaimRate { get; init; }

    /// <summary>
    /// Third Party Incentive Rate.
    /// </summary>
    [DisplayName("Third Party Incentive Rate")]
    [IsoXmlTag("ThrdPtyIncntivRate")]
    public RateAndAmountFormat67Choice_? ThirdPartyIncentiveRate { get; init; }

    /// <summary>
    /// Withholding Tax Rate.
    /// </summary>
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat66Choice_> WithholdingTaxRate { get; init; } = [];
}
