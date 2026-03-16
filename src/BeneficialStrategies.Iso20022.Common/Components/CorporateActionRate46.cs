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
[IsoId("_Tq528SePEeOXAt_43VmZGw")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate46
{
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_UDJ-7yePEeOXAt_43VmZGw")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public GrossDividendRateFormat10Choice_? GrossDividendRate { get; init; }

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_UDJ-9yePEeOXAt_43VmZGw")]
    [DisplayName("Net Dividend Rate")]
    [IsoXmlTag("NetDvddRate")]
    public NetDividendRateFormat12Choice_? NetDividendRate { get; init; }

    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    [IsoId("_UDJ--SePEeOXAt_43VmZGw")]
    [DisplayName("Index Factor")]
    [IsoXmlTag("IndxFctr")]
    public RateAndAmountFormat5Choice_? IndexFactor { get; init; }

    /// <summary>
    /// Actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    [IsoId("_UDJ_ASePEeOXAt_43VmZGw")]
    [DisplayName("Interest Rate Used For Payment")]
    [IsoXmlTag("IntrstRateUsdForPmt")]
    public InterestRateUsedForPaymentFormat2Choice_? InterestRateUsedForPayment { get; init; }

    /// <summary>
    /// A maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    [IsoId("_UDJ_CSePEeOXAt_43VmZGw")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? MaximumAllowedOversubscriptionRate { get; init; }

    /// <summary>
    /// Proportionate allocation used for the offer.
    /// </summary>
    [IsoId("_UDJ_ESePEeOXAt_43VmZGw")]
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ProrationRate { get; init; }

    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_UDJ_GSePEeOXAt_43VmZGw")]
    [DisplayName("Tax Related Rate")]
    [IsoXmlTag("TaxRltdRate")]
    public RateTypeAndAmountAndStatus6? TaxRelatedRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_UDJ_ISePEeOXAt_43VmZGw")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public RateFormat11Choice_? WithholdingTaxRate { get; init; }

    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_UDJ_KSePEeOXAt_43VmZGw")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat5Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction to which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_UDJ_MSePEeOXAt_43VmZGw")]
    [DisplayName("Withholding Of Foreign Tax")]
    [IsoXmlTag("WhldgOfFrgnTax")]
    public RateAndAmountFormat21Choice_? WithholdingOfForeignTax { get; init; }

    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments, for example, in the context of the EU Savings directive.
    /// </summary>
    [IsoId("_UDJ_MyePEeOXAt_43VmZGw")]
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public RateTypeAndAmountAndStatus11? TaxableIncomePerDividendShare { get; init; }
}
