// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Rate133.
/// </summary>
[IsoId("_l6T8kZt3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action Rate133")]
public record CorporateActionRate133
{
    /// <summary>
    /// Additional Tax.
    /// </summary>
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat69Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Gross Distribution Rate.
    /// </summary>
    [DisplayName("Gross Distribution Rate")]
    [IsoXmlTag("GrssDstrbtnRate")]
    public ValueList<GrossDividendRateFormat41Choice_> GrossDistributionRate { get; init; } = [];

    /// <summary>
    /// Gross Interest Rate Used For Payment.
    /// </summary>
    [DisplayName("Gross Interest Rate Used For Payment")]
    [IsoXmlTag("GrssIntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat18Choice_> GrossInterestRateUsedForPayment { get; init; } =
        [];

    /// <summary>
    /// Maximum Allowed Oversubscription Rate.
    /// </summary>
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    public RateFormat24Choice_? MaximumAllowedOversubscriptionRate { get; init; }

    /// <summary>
    /// Net Distribution Rate.
    /// </summary>
    [DisplayName("Net Distribution Rate")]
    [IsoXmlTag("NetDstrbtnRate")]
    public ValueList<NetDividendRateFormat43Choice_> NetDistributionRate { get; init; } = [];

    /// <summary>
    /// Proration Rate.
    /// </summary>
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    public RateFormat24Choice_? ProrationRate { get; init; }

    /// <summary>
    /// Second Level Tax.
    /// </summary>
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat70Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Taxable Income Per Dividend Share.
    /// </summary>
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public ValueList<RateTypeAndAmountAndStatus33> TaxableIncomePerDividendShare { get; init; } =
        [];

    /// <summary>
    /// Tax On Income.
    /// </summary>
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat69Choice_? TaxOnIncome { get; init; }

    /// <summary>
    /// Withholding Tax Rate.
    /// </summary>
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat70Choice_> WithholdingTaxRate { get; init; } = [];
}
