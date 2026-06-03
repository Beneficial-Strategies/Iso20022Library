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
[IsoId("_uN7NwakHEfCG_LQaXOxwew")]
[DisplayName("Corporate Action Rate138")]
public record CorporateActionRate138
{
    /// <summary>
    /// Additional tax that is withheld.
    /// </summary>
    [IsoId("_uN7NxakHEfCG_LQaXOxwew")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat57Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_uN7NyakHEfCG_LQaXOxwew")]
    [DisplayName("Gross Distribution Rate")]
    [IsoXmlTag("GrssDstrbtnRate")]
    public ValueList<GrossDividendRateFormat43Choice_> GrossDistributionRate { get; init; } = [];

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_uN7NzakHEfCG_LQaXOxwew")]
    [DisplayName("Net Distribution Rate")]
    [IsoXmlTag("NetDstrbtnRate")]
    public ValueList<NetDividendRateFormat38Choice_> NetDistributionRate { get; init; } = [];

    /// <summary>
    /// Interest rate used for payment of the proceeds of the event that the account owner will receive on the payment date.
    /// </summary>
    [IsoId("_uN7N0akHEfCG_LQaXOxwew")]
    [DisplayName("Gross Interest Rate Used For Payment")]
    [IsoXmlTag("GrssIntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat11Choice_> GrossInterestRateUsedForPayment { get; init; } = [];

    /// <summary>
    /// Maximum percentage of shares available through the over-subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner who has subscribed to the basic subscription of 100 shares receives an over-subscription privilege of 25 extra shares.
    /// </summary>
    [IsoId("_uN7N1akHEfCG_LQaXOxwew")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    public RateFormat24Choice_? MaximumAllowedOversubscriptionRate { get; init; }

    /// <summary>
    /// Rate used to determine the cash consideration split across outturn settlement transactions that are the result of a transformation of the parent transaction.
    /// </summary>
    [IsoId("_uN7N2akHEfCG_LQaXOxwew")]
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    public RateFormat32Choice_? ProrationRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_uN7N3akHEfCG_LQaXOxwew")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat56Choice_> WithholdingTaxRate { get; init; } = [];

    /// <summary>
    /// Rate of the second level tax withheld at source by the tax jurisdiction.
    /// </summary>
    [IsoId("_uN7N4akHEfCG_LQaXOxwew")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat56Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax calculation.
    /// </summary>
    [IsoId("_uN7N5akHEfCG_LQaXOxwew")]
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public ValueList<RateTypeAndAmountAndStatus26> TaxableIncomePerDividendShare { get; init; } = [];

    /// <summary>
    /// Exchange rate declared by the issuer.
    /// </summary>
    [IsoId("_uN7N6akHEfCG_LQaXOxwew")]
    [DisplayName("Issuer Declared Exchange Rate")]
    [IsoXmlTag("IssrDclrdXchgRate")]
    public ForeignExchangeTerms38? IssuerDeclaredExchangeRate { get; init; }

    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_uN7N7akHEfCG_LQaXOxwew")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateAndAmountFormat57Choice_? TaxOnIncome { get; init; }

    /// <summary>
    /// Rate used to calculate the bid price.
    /// </summary>
    [IsoId("_uN7N8akHEfCG_LQaXOxwew")]
    [DisplayName("Bid Interval")]
    [IsoXmlTag("BidIntrvl")]
    public RateAndAmountFormat58Choice_? BidInterval { get; init; }
}
