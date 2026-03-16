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
[IsoId("_rtFckRFIEeKp2ZN13DI_pA")]
[DisplayName("Rate Details")]
public record RateDetails10
{
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_sCsgTRFIEeKp2ZN13DI_pA")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat14Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_sCsgURFIEeKp2ZN13DI_pA")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public ValueList<GrossDividendRateFormat7Choice_> GrossDividendRate { get; init; } = [];

    /// <summary>
    /// The actual interest rate used for the payment of the interest for the specified interest period. |Usage guideline: It is used to provide the applicable rate for the current payment, after all calculations have been performed, that is, application of period and method of interest computation.
    /// </summary>
    [IsoId("_sCsgVRFIEeKp2ZN13DI_pA")]
    [DisplayName("Interest Rate Used For Payment")]
    [IsoXmlTag("IntrstRateUsdForPmt")]
    public ValueList<InterestRateUsedForPaymentFormat5Choice_> InterestRateUsedForPayment { get; init; } =
        [];

    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_sCsgWRFIEeKp2ZN13DI_pA")]
    [DisplayName("Tax Related Rate")]
    [IsoXmlTag("TaxRltdRate")]
    public ValueList<RateTypeAndAmountAndStatus6> TaxRelatedRate { get; init; } = [];

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_sCsgXRFIEeKp2ZN13DI_pA")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public RateFormat6Choice_? WithholdingTaxRate { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_sCsgYRFIEeKp2ZN13DI_pA")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat14Choice_? ChargesFees { get; init; }

    /// <summary>
    /// Cash rate made available, as an incentive, in addition to the solicitation fee, in order to encourage early participation in an offer.
    /// </summary>
    [IsoId("_sCsgZRFIEeKp2ZN13DI_pA")]
    [DisplayName("Early Solicitation Fee Rate")]
    [IsoXmlTag("EarlySlctnFeeRate")]
    public SolicitationFeeRateFormat5Choice_? EarlySolicitationFeeRate { get; init; }

    /// <summary>
    /// Dividend is final.
    /// </summary>
    [IsoId("_sCsgaRFIEeKp2ZN13DI_pA")]
    [DisplayName("Final Dividend Rate")]
    [IsoXmlTag("FnlDvddRate")]
    public RateAndAmountFormat15Choice_? FinalDividendRate { get; init; }

    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_sCsgbRFIEeKp2ZN13DI_pA")]
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    public RateFormat6Choice_? FiscalStamp { get; init; }

    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; rate includes tax credit for companies that have made sufficient tax payments during fiscal period.
    /// </summary>
    [IsoId("_sCsgcRFIEeKp2ZN13DI_pA")]
    [DisplayName("Fully Franked Rate")]
    [IsoXmlTag("FullyFrnkdRate")]
    public RateAndAmountFormat14Choice_? FullyFrankedRate { get; init; }

    /// <summary>
    /// Cash rate made available in an event in order to encourage participation in the offer. As information, payment is made to a third party who has solicited an entity to take part in the offer.
    /// </summary>
    [IsoId("_sCsgdRFIEeKp2ZN13DI_pA")]
    [DisplayName("Third Party Incentive Rate")]
    [IsoXmlTag("ThrdPtyIncntivRate")]
    public RateFormat8Choice_? ThirdPartyIncentiveRate { get; init; }

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_sCsgeRFIEeKp2ZN13DI_pA")]
    [DisplayName("Net Dividend Rate")]
    [IsoXmlTag("NetDvddRate")]
    public ValueList<NetDividendRateFormat9Choice_> NetDividendRate { get; init; } = [];

    /// <summary>
    /// Rate per share to which a non-resident is entitled.
    /// </summary>
    [IsoId("_sCsgfRFIEeKp2ZN13DI_pA")]
    [DisplayName("Non Resident Rate")]
    [IsoXmlTag("NonResdtRate")]
    public RateAndAmountFormat14Choice_? NonResidentRate { get; init; }

    /// <summary>
    /// Dividend is provisional.
    /// </summary>
    [IsoId("_sCsggRFIEeKp2ZN13DI_pA")]
    [DisplayName("Provisional Dividend Rate")]
    [IsoXmlTag("PrvsnlDvddRate")]
    public RateAndAmountFormat15Choice_? ProvisionalDividendRate { get; init; }

    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_sCsghRFIEeKp2ZN13DI_pA")]
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    public RateFormat6Choice_? ApplicableRate { get; init; }

    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example consent fees or solicitation fee.
    /// </summary>
    [IsoId("_sCsgiRFIEeKp2ZN13DI_pA")]
    [DisplayName("Solicitation Fee Rate")]
    [IsoXmlTag("SlctnFeeRate")]
    public SolicitationFeeRateFormat5Choice_? SolicitationFeeRate { get; init; }

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_sCsgjRFIEeKp2ZN13DI_pA")]
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public ValueList<TaxCreditRateFormat5Choice_> TaxCreditRate { get; init; } = [];

    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    [IsoId("_sCsgkRFIEeKp2ZN13DI_pA")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    public RateFormat6Choice_? TaxOnIncome { get; init; }

    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_sCsglRFIEeKp2ZN13DI_pA")]
    [DisplayName("Tax On Profits")]
    [IsoXmlTag("TaxOnPrfts")]
    public RateFormat6Choice_? TaxOnProfits { get; init; }

    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_sCsgmRFIEeKp2ZN13DI_pA")]
    [DisplayName("Tax Reclaim Rate")]
    [IsoXmlTag("TaxRclmRate")]
    public RateFormat6Choice_? TaxReclaimRate { get; init; }

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_sCsgnRFIEeKp2ZN13DI_pA")]
    [DisplayName("Withholding Of Foreign Tax")]
    [IsoXmlTag("WhldgOfFrgnTax")]
    public RateAndAmountFormat14Choice_? WithholdingOfForeignTax { get; init; }

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_sCsgoRFIEeKp2ZN13DI_pA")]
    [DisplayName("Withholding Of Local Tax")]
    [IsoXmlTag("WhldgOfLclTax")]
    public RateAndAmountFormat14Choice_? WithholdingOfLocalTax { get; init; }

    /// <summary>
    /// Portion of the fund distribution which represents the average accrued income included in the purchase price for units bought during the account period.
    /// </summary>
    [IsoId("_pKjY8BFJEeKp2ZN13DI_pA")]
    [DisplayName("Equalisation Rate")]
    [IsoXmlTag("EqulstnRate")]
    public RateAndAmountFormat15Choice_? EqualisationRate { get; init; }
}
