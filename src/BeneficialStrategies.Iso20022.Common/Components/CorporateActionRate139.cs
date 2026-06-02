// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the rates and amounts related to a corporate action option.
/// </summary>
[IsoId("_VMlc8akXEfCG_LQaXOxwew")]
[DisplayName("Corporate Action Rate139")]
public record CorporateActionRate139
{
    /// <summary>
    /// Additional tax that is withheld.
    /// </summary>
    [IsoId("_VMlc9akXEfCG_LQaXOxwew")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat57Choice? AdditionalTax { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_VMlc-akXEfCG_LQaXOxwew")]
    [DisplayName("Gross Distribution Rate")]
    [IsoXmlTag("GrssDstrbtnRate")]
    public ValueList<GrossDividendRateFormat36Choice> GrossDistributionRate { get; init; } = [];

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_VMlc_akXEfCG_LQaXOxwew")]
    [DisplayName("Net Distribution Rate")]
    [IsoXmlTag("NetDstrbtnRate")]
    public ValueList<NetDividendRateFormat38Choice> NetDistributionRate { get; init; } = [];

    /// <summary>
    /// Interest rate used for payment of the proceeds of the event that the account owner will receive on the payment date.
    /// </summary>
    [IsoId("_VMldAakXEfCG_LQaXOxwew")]
    [DisplayName("Gross Interest Rate Used For Payment")]
    [IsoXmlTag("GrssIntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat11Choice> GrossInterestRateUsedForPayment { get; init; } = [];

    /// <summary>
    /// Maximum percentage of shares available through the over-subscription privilege, usually a percentage of the basic subscription shares.
    /// </summary>
    [IsoId("_VMldBakXEfCG_LQaXOxwew")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    public RateFormat24Choice? MaximumAllowedOversubscriptionRate { get; init; }

    /// <summary>
    /// Rate used to determine the cash consideration split across outturn settlement transactions.
    /// </summary>
    [IsoId("_VMldCakXEfCG_LQaXOxwew")]
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    public RateFormat32Choice? ProrationRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_VMldDakXEfCG_LQaXOxwew")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat56Choice> WithholdingTaxRate { get; init; } = [];

    /// <summary>
    /// Rate of the second level tax withheld at source by the tax jurisdiction.
    /// </summary>
    [IsoId("_VMldEakXEfCG_LQaXOxwew")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat60Choice> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax calculation.
    /// </summary>
    [IsoId("_VMldFakXEfCG_LQaXOxwew")]
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public ValueList<RateTypeAndAmountAndStatus26> TaxableIncomePerDividendShare { get; init; } = [];

    /// <summary>
    /// Exchange rate declared by the issuer.
    /// </summary>
    [IsoId("_VMldGakXEfCG_LQaXOxwew")]
    [DisplayName("Issuer Declared Exchange Rate")]
    [IsoXmlTag("IssrDclrdXchgRate")]
    public ForeignExchangeTerms38? IssuerDeclaredExchangeRate { get; init; }

    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_VMldHakXEfCG_LQaXOxwew")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat57Choice? TaxOnIncome { get; init; }

    /// <summary>
    /// Rate used to calculate the bid price.
    /// </summary>
    [IsoId("_VMldIakXEfCG_LQaXOxwew")]
    [DisplayName("Bid Interval")]
    [IsoXmlTag("BidIntrvl")]
    public RateAndAmountFormat58Choice? BidInterval { get; init; }
}
