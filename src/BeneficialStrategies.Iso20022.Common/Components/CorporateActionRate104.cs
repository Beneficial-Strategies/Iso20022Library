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
[IsoId("_L1hQce29Eeqc-LCjwLsUVg")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate104
{
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_MJc4Ve29Eeqc-LCjwLsUVg")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat37Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_MJc4Xe29Eeqc-LCjwLsUVg")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public ValueList<GrossDividendRateFormat36Choice_> GrossDividendRate { get; init; } = [];

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_MJc4Ze29Eeqc-LCjwLsUVg")]
    [DisplayName("Net Dividend Rate")]
    [IsoXmlTag("NetDvddRate")]
    public ValueList<NetDividendRateFormat38Choice_> NetDividendRate { get; init; } = [];

    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    [IsoId("_MJc4b-29Eeqc-LCjwLsUVg")]
    [DisplayName("Interest Rate Used For Payment")]
    [IsoXmlTag("IntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat8Choice_> InterestRateUsedForPayment { get; init; } =
        [];

    /// <summary>
    /// Maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    [IsoId("_MJc4d-29Eeqc-LCjwLsUVg")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    public RateFormat3Choice_? MaximumAllowedOversubscriptionRate { get; init; }

    /// <summary>
    /// Percentage of securities accepted by the offeror/issuer.
    /// </summary>
    [IsoId("_MJc4f-29Eeqc-LCjwLsUVg")]
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    public RateFormat3Choice_? ProrationRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_MJc4h-29Eeqc-LCjwLsUVg")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat41Choice_> WithholdingTaxRate { get; init; } = [];

    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_MJc4j-29Eeqc-LCjwLsUVg")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat41Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments, for example, in the context of the EU Savings directive.
    /// </summary>
    [IsoId("_MJc4ke29Eeqc-LCjwLsUVg")]
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public ValueList<RateTypeAndAmountAndStatus26> TaxableIncomePerDividendShare { get; init; } =
        [];

    /// <summary>
    /// Exchange rate (provided by the issuer) between the dividend or interest rate in the paid currency and the declared dividend or interest rate.
    /// </summary>
    [IsoId("_MJc4k-29Eeqc-LCjwLsUVg")]
    [DisplayName("Issuer Declared Exchange Rate")]
    [IsoXmlTag("IssrDclrdXchgRate")]
    public ForeignExchangeTerms19? IssuerDeclaredExchangeRate { get; init; }

    /// <summary>
    /// Overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_MJc4le29Eeqc-LCjwLsUVg")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat37Choice_? TaxOnIncome { get; init; }

    /// <summary>
    /// Acceptable price increment used for submitting a bid.
    /// </summary>
    [IsoId("_FPPW1O3LEeqc-LCjwLsUVg")]
    [DisplayName("Bid Interval")]
    [IsoXmlTag("BidIntrvl")]
    public RateAndAmountFormat38Choice_? BidInterval { get; init; }
}
