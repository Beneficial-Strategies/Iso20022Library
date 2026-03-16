// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rate42.
/// </summary>
[IsoId("_3is8wYV4Ee-oeNhl-Tk6YQ")]
[DisplayName("Rate42")]
public record Rate42
{
    /// <summary>
    /// Additional Tax.
    /// </summary>
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat57Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Applicable Rate.
    /// </summary>
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    public RateFormat24Choice_? ApplicableRate { get; init; }

    /// <summary>
    /// Charges Fees.
    /// </summary>
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat57Choice_? ChargesFees { get; init; }

    /// <summary>
    /// Deemed Rate.
    /// </summary>
    [DisplayName("Deemed Rate")]
    [IsoXmlTag("DmdRate")]
    public ValueList<RateAndAmountFormat61Choice_> DeemedRate { get; init; } = [];

    /// <summary>
    /// Early Solicitation Fee Rate.
    /// </summary>
    [DisplayName("Early Solicitation Fee Rate")]
    [IsoXmlTag("EarlySlctnFeeRate")]
    public SolicitationFeeRateFormat11Choice_? EarlySolicitationFeeRate { get; init; }

    /// <summary>
    /// Equalisation Rate.
    /// </summary>
    [DisplayName("Equalisation Rate")]
    [IsoXmlTag("EqulstnRate")]
    public RateAndAmountFormat42Choice_? EqualisationRate { get; init; }

    /// <summary>
    /// Fiscal Stamp.
    /// </summary>
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    public RateFormat24Choice_? FiscalStamp { get; init; }

    /// <summary>
    /// Gross Distribution Rate.
    /// </summary>
    [DisplayName("Gross Distribution Rate")]
    [IsoXmlTag("GrssDstrbtnRate")]
    public ValueList<GrossDividendRateFormat38Choice_> GrossDistributionRate { get; init; } = [];

    /// <summary>
    /// Gross Interest Rate Used For Payment.
    /// </summary>
    [DisplayName("Gross Interest Rate Used For Payment")]
    [IsoXmlTag("GrssIntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat11Choice_> GrossInterestRateUsedForPayment { get; init; } =
        [];

    /// <summary>
    /// Net Distribution Rate.
    /// </summary>
    [DisplayName("Net Distribution Rate")]
    [IsoXmlTag("NetDstrbtnRate")]
    public ValueList<NetDividendRateFormat39Choice_> NetDistributionRate { get; init; } = [];

    /// <summary>
    /// Second Level Tax.
    /// </summary>
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat56Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Solicitation Fee Rate.
    /// </summary>
    [DisplayName("Solicitation Fee Rate")]
    [IsoXmlTag("SlctnFeeRate")]
    public SolicitationFeeRateFormat11Choice_? SolicitationFeeRate { get; init; }

    /// <summary>
    /// Tax Credit Rate.
    /// </summary>
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public RateFormat26Choice_? TaxCreditRate { get; init; }

    /// <summary>
    /// Tax On Income.
    /// </summary>
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat57Choice_? TaxOnIncome { get; init; }

    /// <summary>
    /// Tax On Profits.
    /// </summary>
    [DisplayName("Tax On Profits")]
    [IsoXmlTag("TaxOnPrfts")]
    public RateFormat24Choice_? TaxOnProfits { get; init; }

    /// <summary>
    /// Tax Reclaim Rate.
    /// </summary>
    [DisplayName("Tax Reclaim Rate")]
    [IsoXmlTag("TaxRclmRate")]
    public RateFormat24Choice_? TaxReclaimRate { get; init; }

    /// <summary>
    /// Third Party Incentive Rate.
    /// </summary>
    [DisplayName("Third Party Incentive Rate")]
    [IsoXmlTag("ThrdPtyIncntivRate")]
    public RateFormat26Choice_? ThirdPartyIncentiveRate { get; init; }

    /// <summary>
    /// Withholding Tax Rate.
    /// </summary>
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat56Choice_> WithholdingTaxRate { get; init; } = [];
}
