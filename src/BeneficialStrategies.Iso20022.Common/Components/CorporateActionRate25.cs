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
[IsoId("_nmltNfmUEeCcAY_zfcalaA")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate25
{
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_nmltS_mUEeCcAY_zfcalaA")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat14Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_nmltVfmUEeCcAY_zfcalaA")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public ValueList<GrossDividendRateFormat5Choice_> GrossDividendRate { get; init; } = [];

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_BOqVdfo4EeCVCIR-Uq3c5A")]
    [DisplayName("Net Dividend Rate")]
    [IsoXmlTag("NetDvddRate")]
    public ValueList<NetDividendRateFormat5Choice_> NetDividendRate { get; init; } = [];

    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    [IsoId("_nmltX_mUEeCcAY_zfcalaA")]
    [DisplayName("Index Factor")]
    [IsoXmlTag("IndxFctr")]
    public RateAndAmountFormat14Choice_? IndexFactor { get; init; }

    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    [IsoId("_nmltafmUEeCcAY_zfcalaA")]
    [DisplayName("Interest Rate Used For Payment")]
    [IsoXmlTag("IntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat5Choice_> InterestRateUsedForPayment { get; init; } =
        [];

    /// <summary>
    /// Maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    [IsoId("_nmltc_mUEeCcAY_zfcalaA")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    public RateFormat6Choice_? MaximumAllowedOversubscriptionRate { get; init; }

    /// <summary>
    /// Proportionate allocation used for the offer.
    /// </summary>
    [IsoId("_nmltffmUEeCcAY_zfcalaA")]
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    public RateFormat6Choice_? ProrationRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_nmlth_mUEeCcAY_zfcalaA")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public RateFormat6Choice_? WithholdingTaxRate { get; init; }

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction to which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_p4oAOfmUEeCcAY_zfcalaA")]
    [DisplayName("Withholding Of Foreign Tax")]
    [IsoXmlTag("WhldgOfFrgnTax")]
    public RateAndAmountFormat14Choice_? WithholdingOfForeignTax { get; init; }

    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_nmltkfmUEeCcAY_zfcalaA")]
    [DisplayName("Tax Related Rate")]
    [IsoXmlTag("TaxRltdRate")]
    public ValueList<RateTypeAndAmountAndStatus6> TaxRelatedRate { get; init; } = [];

    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments within the scope of the EU Savings directive.
    /// </summary>
    [IsoId("_nmltm_mUEeCcAY_zfcalaA")]
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public ValueList<RateTypeAndAmountAndStatus11> TaxableIncomePerDividendShare { get; init; } =
        [];
}
