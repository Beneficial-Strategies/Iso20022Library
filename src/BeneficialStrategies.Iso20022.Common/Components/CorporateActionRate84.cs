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
[IsoId("_x5_1QZwsEeazcsnODTksnQ")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate84
{
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_x5_1TZwsEeazcsnODTksnQ")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat46Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_x5_1VZwsEeazcsnODTksnQ")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public ValueList<GrossDividendRateFormat25Choice_> GrossDividendRate { get; init; } = [];

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_x5_1XZwsEeazcsnODTksnQ")]
    [DisplayName("Net Dividend Rate")]
    [IsoXmlTag("NetDvddRate")]
    public ValueList<NetDividendRateFormat27Choice_> NetDividendRate { get; init; } = [];

    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    [IsoId("_x5_1X5wsEeazcsnODTksnQ")]
    [DisplayName("Index Factor")]
    [IsoXmlTag("IndxFctr")]
    public RateAndAmountFormat46Choice_? IndexFactor { get; init; }

    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    [IsoId("_x5_1Z5wsEeazcsnODTksnQ")]
    [DisplayName("Interest Rate Used For Payment")]
    [IsoXmlTag("IntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat10Choice_> InterestRateUsedForPayment { get; init; } =
        [];

    /// <summary>
    /// Maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    [IsoId("_x5_1b5wsEeazcsnODTksnQ")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    public RateFormat3Choice_? MaximumAllowedOversubscriptionRate { get; init; }

    /// <summary>
    /// Percentage of securities accepted by the offeror/issuer.
    /// </summary>
    [IsoId("_x5_1d5wsEeazcsnODTksnQ")]
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    public RateFormat3Choice_? ProrationRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_x5_1f5wsEeazcsnODTksnQ")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat47Choice_> WithholdingTaxRate { get; init; } = [];

    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_x5_1h5wsEeazcsnODTksnQ")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat47Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments, for example, in the context of the EU Savings directive.
    /// </summary>
    [IsoId("_x5_1iZwsEeazcsnODTksnQ")]
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public ValueList<RateTypeAndAmountAndStatus33> TaxableIncomePerDividendShare { get; init; } =
        [];

    /// <summary>
    /// Overall tax withheld at source by fund managers prior to considering the tax obligation of each unit holder.
    /// </summary>
    [IsoId("_x5_1i5wsEeazcsnODTksnQ")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat46Choice_? TaxOnIncome { get; init; }
}
