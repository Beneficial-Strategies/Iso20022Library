// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates related to a corporate action option.
/// </summary>
[IsoId("_HKGJISeMEeOXAt_43VmZGw")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate44
{
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_HhJ-TyeMEeOXAt_43VmZGw")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat14Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_HhJ-VyeMEeOXAt_43VmZGw")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public GrossDividendRateFormat9Choice_? GrossDividendRate { get; init; }

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_HhJ-XyeMEeOXAt_43VmZGw")]
    [DisplayName("Net Dividend Rate")]
    [IsoXmlTag("NetDvddRate")]
    public NetDividendRateFormat11Choice_? NetDividendRate { get; init; }

    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    [IsoId("_HhJ-YSeMEeOXAt_43VmZGw")]
    [DisplayName("Index Factor")]
    [IsoXmlTag("IndxFctr")]
    public RateAndAmountFormat14Choice_? IndexFactor { get; init; }

    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    [IsoId("_HhJ-aSeMEeOXAt_43VmZGw")]
    [DisplayName("Interest Rate Used For Payment")]
    [IsoXmlTag("IntrstRateUsdForPmt")]
    public InterestRateUsedForPaymentFormat5Choice_? InterestRateUsedForPayment { get; init; }

    /// <summary>
    /// Maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    [IsoId("_HhJ-cSeMEeOXAt_43VmZGw")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    public RateFormat3Choice_? MaximumAllowedOversubscriptionRate { get; init; }

    /// <summary>
    /// Proportionate allocation used for the offer.
    /// </summary>
    [IsoId("_HhJ-eSeMEeOXAt_43VmZGw")]
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    public RateFormat3Choice_? ProrationRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_HhJ-gSeMEeOXAt_43VmZGw")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public RateFormat10Choice_? WithholdingTaxRate { get; init; }

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction to which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_HhJ-iSeMEeOXAt_43VmZGw")]
    [DisplayName("Withholding Of Foreign Tax")]
    [IsoXmlTag("WhldgOfFrgnTax")]
    public RateAndAmountFormat20Choice_? WithholdingOfForeignTax { get; init; }

    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_HhJ-iyeMEeOXAt_43VmZGw")]
    [DisplayName("Tax Related Rate")]
    [IsoXmlTag("TaxRltdRate")]
    public RateTypeAndAmountAndStatus6? TaxRelatedRate { get; init; }

    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments, for example, in the context of the EU Savings directive.
    /// </summary>
    [IsoId("_HhJ-kyeMEeOXAt_43VmZGw")]
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public RateTypeAndAmountAndStatus11? TaxableIncomePerDividendShare { get; init; }

    /// <summary>
    /// Exchange rate (provided by the issuer) between the dividend or interest rate in the paid currency and the declared dividend or interest rate.
    /// </summary>
    [IsoId("_HhJ-lSeMEeOXAt_43VmZGw")]
    [DisplayName("Issuer Declared Exchange Rate")]
    [IsoXmlTag("IssrDclrdXchgRate")]
    public ForeignExchangeTerms19? IssuerDeclaredExchangeRate { get; init; }

    /// <summary>
    /// Overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_23ss8SnhEeOFFarFEDwxng")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat14Choice_? TaxOnIncome { get; init; }
}
