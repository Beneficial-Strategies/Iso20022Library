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
[IsoId("_cj85W5KQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate74
{
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_cj85Z5KQEeWHWpTQn1FFVg")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public GrossDividendRateFormat23Choice_? GrossDividendRate { get; init; }

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_cj85b5KQEeWHWpTQn1FFVg")]
    [DisplayName("Net Dividend Rate")]
    [IsoXmlTag("NetDvddRate")]
    public NetDividendRateFormat25Choice_? NetDividendRate { get; init; }

    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    [IsoId("_cj85cZKQEeWHWpTQn1FFVg")]
    [DisplayName("Index Factor")]
    [IsoXmlTag("IndxFctr")]
    public RateAndAmountFormat43Choice_? IndexFactor { get; init; }

    /// <summary>
    /// Actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    [IsoId("_cj85eZKQEeWHWpTQn1FFVg")]
    [DisplayName("Interest Rate Used For Payment")]
    [IsoXmlTag("IntrstRateUsdForPmt")]
    public InterestRateUsedForPaymentFormat9Choice_? InterestRateUsedForPayment { get; init; }

    /// <summary>
    /// A maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    [IsoId("_cj85gZKQEeWHWpTQn1FFVg")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? MaximumAllowedOversubscriptionRate { get; init; }

    /// <summary>
    /// Proportionate allocation used for the offer.
    /// </summary>
    [IsoId("_cj85iZKQEeWHWpTQn1FFVg")]
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ProrationRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_cj85kZKQEeWHWpTQn1FFVg")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public RateAndAmountFormat45Choice_? WithholdingTaxRate { get; init; }

    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_cj85mZKQEeWHWpTQn1FFVg")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public RateAndAmountFormat45Choice_? SecondLevelTax { get; init; }

    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_cj85m5KQEeWHWpTQn1FFVg")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat43Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments, for example, in the context of the EU Savings directive.
    /// </summary>
    [IsoId("_cj85o5KQEeWHWpTQn1FFVg")]
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public RateTypeAndAmountAndStatus33? TaxableIncomePerDividendShare { get; init; }
}
