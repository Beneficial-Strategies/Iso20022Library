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
[IsoId("_e4u_MYlvEeavwKddCbm3hg")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate81
{
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_fQsMPYlvEeavwKddCbm3hg")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat37Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_fQsMRYlvEeavwKddCbm3hg")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public ValueList<GrossDividendRateFormat19Choice_> GrossDividendRate { get; init; } = [];

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_fQsMTYlvEeavwKddCbm3hg")]
    [DisplayName("Net Dividend Rate")]
    [IsoXmlTag("NetDvddRate")]
    public ValueList<NetDividendRateFormat21Choice_> NetDividendRate { get; init; } = [];

    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    [IsoId("_fQsMT4lvEeavwKddCbm3hg")]
    [DisplayName("Index Factor")]
    [IsoXmlTag("IndxFctr")]
    public RateAndAmountFormat37Choice_? IndexFactor { get; init; }

    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    [IsoId("_fQsMV4lvEeavwKddCbm3hg")]
    [DisplayName("Interest Rate Used For Payment")]
    [IsoXmlTag("IntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat8Choice_> InterestRateUsedForPayment { get; init; } =
        [];

    /// <summary>
    /// Maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    [IsoId("_fQsMX4lvEeavwKddCbm3hg")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    public RateFormat3Choice_? MaximumAllowedOversubscriptionRate { get; init; }

    /// <summary>
    /// Percentage of securities accepted by the offeror/issuer.
    /// </summary>
    [IsoId("_fQsMZ4lvEeavwKddCbm3hg")]
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    public RateFormat3Choice_? ProrationRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_fQsMb4lvEeavwKddCbm3hg")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat41Choice_> WithholdingTaxRate { get; init; } = [];

    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_fQsMd4lvEeavwKddCbm3hg")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat41Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments, for example, in the context of the EU Savings directive.
    /// </summary>
    [IsoId("_fQsMeYlvEeavwKddCbm3hg")]
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public ValueList<RateTypeAndAmountAndStatus26> TaxableIncomePerDividendShare { get; init; } =
        [];

    /// <summary>
    /// Overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_fQsMe4lvEeavwKddCbm3hg")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat37Choice_? TaxOnIncome { get; init; }
}
