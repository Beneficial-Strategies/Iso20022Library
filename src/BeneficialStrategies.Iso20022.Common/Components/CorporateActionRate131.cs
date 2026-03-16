// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Rate131.
/// </summary>
[IsoId("_kv5925t3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action Rate131")]
public partial record CorporateActionRate131
{
    #nullable enable

    /// <summary>
    /// Additional Tax.
    /// </summary>
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat67Choice_? AdditionalTax { get; init; } 

    /// <summary>
    /// Gross Distribution Rate.
    /// </summary>
    [DisplayName("Gross Distribution Rate")]
    [IsoXmlTag("GrssDstrbtnRate")]
    public ValueList<GrossDividendRateFormat39Choice_> GrossDistributionRate { get; init; } = [];

    /// <summary>
    /// Gross Interest Rate Used For Payment.
    /// </summary>
    [DisplayName("Gross Interest Rate Used For Payment")]
    [IsoXmlTag("GrssIntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat19Choice_> GrossInterestRateUsedForPayment { get; init; } = [];

    /// <summary>
    /// Maximum Allowed Oversubscription Rate.
    /// </summary>
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    public IsoPercentage14Rate? MaximumAllowedOversubscriptionRate { get; init; } 

    /// <summary>
    /// Net Distribution Rate.
    /// </summary>
    [DisplayName("Net Distribution Rate")]
    [IsoXmlTag("NetDstrbtnRate")]
    public ValueList<NetDividendRateFormat41Choice_> NetDistributionRate { get; init; } = [];

    /// <summary>
    /// Proration Rate.
    /// </summary>
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    public IsoPercentage14Rate? ProrationRate { get; init; } 

    /// <summary>
    /// Second Level Tax.
    /// </summary>
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat66Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Taxable Income Per Dividend Share.
    /// </summary>
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public ValueList<RateTypeAndAmountAndStatus33> TaxableIncomePerDividendShare { get; init; } = [];

    /// <summary>
    /// Withholding Tax Rate.
    /// </summary>
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat66Choice_> WithholdingTaxRate { get; init; } = [];

    
    #nullable disable
    
}
