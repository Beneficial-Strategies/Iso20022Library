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
[IsoId("_D4vKM-2-Eeqc-LCjwLsUVg")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate107
{
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_EjIxxe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public ValueList<GrossDividendRateFormat35Choice_> GrossDividendRate { get; init; } = [];

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_EjIxze2-Eeqc-LCjwLsUVg")]
    [DisplayName("Net Dividend Rate")]
    [IsoXmlTag("NetDvddRate")]
    public ValueList<NetDividendRateFormat37Choice_> NetDividendRate { get; init; } = [];

    /// <summary>
    /// Actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    [IsoId("_EjIx1-2-Eeqc-LCjwLsUVg")]
    [DisplayName("Interest Rate Used For Payment")]
    [IsoXmlTag("IntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat7Choice_> InterestRateUsedForPayment { get; init; } =
        [];

    /// <summary>
    /// A maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    [IsoId("_EjIx3-2-Eeqc-LCjwLsUVg")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? MaximumAllowedOversubscriptionRate { get; init; }

    /// <summary>
    /// Percentage of securities accepted by the offeror/issuer.
    /// </summary>
    [IsoId("_EjIx5-2-Eeqc-LCjwLsUVg")]
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ProrationRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_EjIx7-2-Eeqc-LCjwLsUVg")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat40Choice_> WithholdingTaxRate { get; init; } = [];

    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_EjIx9-2-Eeqc-LCjwLsUVg")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat40Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_EjIx-e2-Eeqc-LCjwLsUVg")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat39Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments, for example, in the context of the EU Savings directive.
    /// </summary>
    [IsoId("_EjIyAe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public ValueList<RateTypeAndAmountAndStatus26> TaxableIncomePerDividendShare { get; init; } =
        [];
}
