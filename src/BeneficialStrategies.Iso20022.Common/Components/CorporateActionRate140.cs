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
[IsoId("_qX2SEakdEfCG_LQaXOxwew")]
[DisplayName("Corporate Action Rate140")]
public record CorporateActionRate140
{
    /// <summary>
    /// Additional tax that is withheld.
    /// </summary>
    [IsoId("_qX2SFakdEfCG_LQaXOxwew")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat57Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_qX2SGakdEfCG_LQaXOxwew")]
    [DisplayName("Gross Distribution Rate")]
    [IsoXmlTag("GrssDstrbtnRate")]
    public ValueList<GrossDividendRateFormat36Choice_> GrossDistributionRate { get; init; } = [];

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_qX2SHakdEfCG_LQaXOxwew")]
    [DisplayName("Net Distribution Rate")]
    [IsoXmlTag("NetDstrbtnRate")]
    public ValueList<NetDividendRateFormat38Choice_> NetDistributionRate { get; init; } = [];

    /// <summary>
    /// Interest rate used for payment of the proceeds of the event that the account owner will receive on the payment date.
    /// </summary>
    [IsoId("_qX2SIakdEfCG_LQaXOxwew")]
    [DisplayName("Gross Interest Rate Used For Payment")]
    [IsoXmlTag("GrssIntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat11Choice_> GrossInterestRateUsedForPayment { get; init; } = [];

    /// <summary>
    /// Maximum percentage of shares available through the over-subscription privilege.
    /// </summary>
    [IsoId("_qX2SJakdEfCG_LQaXOxwew")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    public RateFormat24Choice_? MaximumAllowedOversubscriptionRate { get; init; }

    /// <summary>
    /// Rate used to determine the cash consideration split across outturn settlement transactions.
    /// </summary>
    [IsoId("_qX2SKakdEfCG_LQaXOxwew")]
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    public RateFormat32Choice_? ProrationRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_qX2SLakdEfCG_LQaXOxwew")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat56Choice_> WithholdingTaxRate { get; init; } = [];

    /// <summary>
    /// Rate of the second level tax withheld at source by the tax jurisdiction.
    /// </summary>
    [IsoId("_qX2SMakdEfCG_LQaXOxwew")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat56Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax calculation.
    /// </summary>
    [IsoId("_qX2SNakdEfCG_LQaXOxwew")]
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public ValueList<RateTypeAndAmountAndStatus26> TaxableIncomePerDividendShare { get; init; } = [];

    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_qX2SOakdEfCG_LQaXOxwew")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat57Choice_? TaxOnIncome { get; init; }
}
