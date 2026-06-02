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
[IsoId("_anrvgakeEfCG_LQaXOxwew")]
[DisplayName("Corporate Action Rate141")]
public record CorporateActionRate141
{
    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_anrvhakeEfCG_LQaXOxwew")]
    [DisplayName("Gross Distribution Rate")]
    [IsoXmlTag("GrssDstrbtnRate")]
    public ValueList<GrossDividendRateFormat35Choice> GrossDistributionRate { get; init; } = [];

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_anrviakeEfCG_LQaXOxwew")]
    [DisplayName("Net Distribution Rate")]
    [IsoXmlTag("NetDstrbtnRate")]
    public ValueList<NetDividendRateFormat37Choice> NetDistributionRate { get; init; } = [];

    /// <summary>
    /// Interest rate used for payment of the proceeds of the event that the account owner will receive on the payment date.
    /// </summary>
    [IsoId("_anrvjakeEfCG_LQaXOxwew")]
    [DisplayName("Gross Interest Rate Used For Payment")]
    [IsoXmlTag("GrssIntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat12Choice> GrossInterestRateUsedForPayment { get; init; } = [];

    /// <summary>
    /// Maximum percentage of shares available through the over-subscription privilege.
    /// </summary>
    [IsoId("_anrvkakeEfCG_LQaXOxwew")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    public IsoPercentage14Rate? MaximumAllowedOversubscriptionRate { get; init; }

    /// <summary>
    /// Rate used to determine the cash consideration split across outturn settlement transactions.
    /// </summary>
    [IsoId("_anrvlakeEfCG_LQaXOxwew")]
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    public RateFormat32Choice? ProrationRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_anrvmakeEfCG_LQaXOxwew")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat55Choice> WithholdingTaxRate { get; init; } = [];

    /// <summary>
    /// Rate of the second level tax withheld at source by the tax jurisdiction.
    /// </summary>
    [IsoId("_anrvnakeEfCG_LQaXOxwew")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat55Choice> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Additional tax that is withheld.
    /// </summary>
    [IsoId("_anrvoakeEfCG_LQaXOxwew")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat59Choice? AdditionalTax { get; init; }

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax calculation.
    /// </summary>
    [IsoId("_anrvpakeEfCG_LQaXOxwew")]
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public ValueList<RateTypeAndAmountAndStatus26> TaxableIncomePerDividendShare { get; init; } = [];
}
