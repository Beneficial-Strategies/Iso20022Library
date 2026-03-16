// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the rates related to securities movement.
/// </summary>
[IsoId("_ORdmwOsgEd-b_I-JAnHTUQ")]
[DisplayName("Rate Details")]
public record RateDetails3
{
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_T1lWoesgEd-b_I-JAnHTUQ")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat14Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_o8yZ4esgEd-b_I-JAnHTUQ")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public GrossDividendRateFormat5Choice_? GrossDividendRate { get; init; }

    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    [IsoId("_rgGEIesgEd-b_I-JAnHTUQ")]
    [DisplayName("Interest Rate Used For Payment")]
    [IsoXmlTag("IntrstRateUsdForPmt")]
    public InterestRateUsedForPaymentFormat5Choice_? InterestRateUsedForPayment { get; init; }

    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_vShz8esgEd-b_I-JAnHTUQ")]
    [DisplayName("Tax Related Rate")]
    [IsoXmlTag("TaxRltdRate")]
    public RateTypeAndAmountAndStatus6? TaxRelatedRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_xsdfwesgEd-b_I-JAnHTUQ")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public RateFormat6Choice_? WithholdingTaxRate { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_B-T2cOtJEd-PFJLHKom6FA")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat14Choice_? ChargesFees { get; init; }

    /// <summary>
    /// Cash rate made available, as an incentive, in addition to the solicitation fee, in order to encourage early participation in an offer.
    /// </summary>
    [IsoId("_LqUowOtJEd-PFJLHKom6FA")]
    [DisplayName("Early Solicitation Fee Rate")]
    [IsoXmlTag("EarlySlctnFeeRate")]
    public SolicitationFeeRateFormat3Choice_? EarlySolicitationFeeRate { get; init; }

    /// <summary>
    /// Dividend is final.
    /// </summary>
    [IsoId("_NcmesOtJEd-PFJLHKom6FA")]
    [DisplayName("Final Dividend Rate")]
    [IsoXmlTag("FnlDvddRate")]
    public RateAndAmountFormat15Choice_? FinalDividendRate { get; init; }

    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_PJO_oOtJEd-PFJLHKom6FA")]
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    public RateFormat6Choice_? FiscalStamp { get; init; }

    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; rate includes tax credit for companies that have made sufficient tax payments during fiscal period.
    /// </summary>
    [IsoId("_RX-vIOtJEd-PFJLHKom6FA")]
    [DisplayName("Fully Franked Rate")]
    [IsoXmlTag("FullyFrnkdRate")]
    public RateAndAmountFormat14Choice_? FullyFrankedRate { get; init; }

    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example, consent fees.
    /// </summary>
    [IsoId("_ThNsgOtJEd-PFJLHKom6FA")]
    [DisplayName("Cash Incentive Rate")]
    [IsoXmlTag("CshIncntivRate")]
    public RateFormat6Choice_? CashIncentiveRate { get; init; }

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_U8QHIOtJEd-PFJLHKom6FA")]
    [DisplayName("Net Dividend Rate")]
    [IsoXmlTag("NetDvddRate")]
    public NetDividendRateFormat5Choice_? NetDividendRate { get; init; }

    /// <summary>
    /// Rate per share to which a non-resident is entitled.
    /// </summary>
    [IsoId("_WKCI4OtJEd-PFJLHKom6FA")]
    [DisplayName("Non Resident Rate")]
    [IsoXmlTag("NonResdtRate")]
    public RateAndAmountFormat14Choice_? NonResidentRate { get; init; }

    /// <summary>
    /// Dividend is provisional.
    /// </summary>
    [IsoId("_YczcwOtJEd-PFJLHKom6FA")]
    [DisplayName("Provisional Dividend Rate")]
    [IsoXmlTag("PrvsnlDvddRate")]
    public RateAndAmountFormat15Choice_? ProvisionalDividendRate { get; init; }

    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_ZvfzsOtJEd-PFJLHKom6FA")]
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    public RateFormat6Choice_? ApplicableRate { get; init; }

    /// <summary>
    /// Cash rate made available in an offer in order to encourage participation in the offer.
    /// </summary>
    [IsoId("_bU0ywOtJEd-PFJLHKom6FA")]
    [DisplayName("Solicitation Fee Rate")]
    [IsoXmlTag("SlctnFeeRate")]
    public SolicitationFeeRateFormat3Choice_? SolicitationFeeRate { get; init; }

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_c076oOtJEd-PFJLHKom6FA")]
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public TaxCreditRateFormat5Choice_? TaxCreditRate { get; init; }

    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    [IsoId("_eOVWgOtJEd-PFJLHKom6FA")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateFormat6Choice_? TaxOnIncome { get; init; }

    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_fKF0IOtJEd-PFJLHKom6FA")]
    [DisplayName("Tax On Profits")]
    [IsoXmlTag("TaxOnPrfts")]
    public RateFormat6Choice_? TaxOnProfits { get; init; }

    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_gNlRcOtJEd-PFJLHKom6FA")]
    [DisplayName("Tax Reclaim Rate")]
    [IsoXmlTag("TaxRclmRate")]
    public RateFormat6Choice_? TaxReclaimRate { get; init; }

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_hNgdYOtJEd-PFJLHKom6FA")]
    [DisplayName("Withholding Of Foreign Tax")]
    [IsoXmlTag("WhldgOfFrgnTax")]
    public RateAndAmountFormat14Choice_? WithholdingOfForeignTax { get; init; }

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_iTPWYOtJEd-PFJLHKom6FA")]
    [DisplayName("Withholding Of Local Tax")]
    [IsoXmlTag("WhldgOfLclTax")]
    public RateAndAmountFormat14Choice_? WithholdingOfLocalTax { get; init; }
}
