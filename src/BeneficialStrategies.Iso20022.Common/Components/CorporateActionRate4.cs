// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates.
/// </summary>
[IsoId("_TXEAddp-Ed-ak6NoX_4Aeg_-525646890")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate4
{
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_TXEAdtp-Ed-ak6NoX_4Aeg_-525646490")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat5Choice_? ChargesFees { get; init; }

    /// <summary>
    /// Dividend is final.
    /// </summary>
    [IsoId("_TXNKYNp-Ed-ak6NoX_4Aeg_-525646459")]
    [DisplayName("Final Dividend Rate")]
    [IsoXmlTag("FnlDvddRate")]
    public ActiveCurrencyAnd13DecimalAmount? FinalDividendRate { get; init; }

    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_TXNKYdp-Ed-ak6NoX_4Aeg_-525646398")]
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? FiscalStamp { get; init; }

    /// <summary>
    /// Rate resulting from a fully franked dividend paid by a company; rate includes tax credit for companies that have made sufficient tax payments during fiscal period.
    /// </summary>
    [IsoId("_TXNKYtp-Ed-ak6NoX_4Aeg_-524726403")]
    [DisplayName("Fully Franked Rate")]
    [IsoXmlTag("FullyFrnkdRate")]
    public RateAndAmountFormat5Choice_? FullyFrankedRate { get; init; }

    /// <summary>
    /// Cash dividend amount per equity before deductions or allowances have been made.
    /// </summary>
    [IsoId("_TXNKY9p-Ed-ak6NoX_4Aeg_-524726373")]
    [DisplayName("Gross Dividend Rate")]
    [IsoXmlTag("GrssDvddRate")]
    public GrossDividendRateFormat2Choice_? GrossDividendRate { get; init; }

    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example, consent fees.
    /// </summary>
    [IsoId("_TXNKZNp-Ed-ak6NoX_4Aeg_-524726342")]
    [DisplayName("Cash Incentive Rate")]
    [IsoXmlTag("CshIncntivRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? CashIncentiveRate { get; init; }

    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    [IsoId("_TXNKZdp-Ed-ak6NoX_4Aeg_-524726341")]
    [DisplayName("Index Factor")]
    [IsoXmlTag("IndxFctr")]
    public RateAndAmountFormat5Choice_? IndexFactor { get; init; }

    /// <summary>
    /// Actual interest rate used for the payment of the interest for the specified interest period.
    /// </summary>
    [IsoId("_TXNKZtp-Ed-ak6NoX_4Aeg_-524726311")]
    [DisplayName("Interest Rate Used For Payment")]
    [IsoXmlTag("IntrstRateUsdForPmt")]
    public InterestRateUsedForPaymentFormat2Choice_? InterestRateUsedForPayment { get; init; }

    /// <summary>
    /// Cash dividend amount per equity after deductions or allowances have been made.
    /// </summary>
    [IsoId("_TXNKZ9p-Ed-ak6NoX_4Aeg_-524726158")]
    [DisplayName("Net Dividend Rate")]
    [IsoXmlTag("NetDvddRate")]
    public NetDividendRateFormat2Choice_? NetDividendRate { get; init; }

    /// <summary>
    /// Rate per share to which a non-resident is entitled.
    /// </summary>
    [IsoId("_TXNKaNp-Ed-ak6NoX_4Aeg_-524726128")]
    [DisplayName("Non Resident Rate")]
    [IsoXmlTag("NonResdtRate")]
    public RateAndAmountFormat5Choice_? NonResidentRate { get; init; }

    /// <summary>
    /// A maximum percentage of shares available through the over subscription privilege, usually a percentage of the basic subscription shares, for example, an account owner subscribing to 100 shares may over subscribe to a maximum of 50 additional shares when the over subscription maximum is 50 percent.
    /// </summary>
    [IsoId("_TXNKadp-Ed-ak6NoX_4Aeg_-524725849")]
    [DisplayName("Maximum Allowed Oversubscription Rate")]
    [IsoXmlTag("MaxAllwdOvrsbcptRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? MaximumAllowedOversubscriptionRate { get; init; }

    /// <summary>
    /// Dividend is provisional.
    /// </summary>
    [IsoId("_TXW7YNp-Ed-ak6NoX_4Aeg_-524725819")]
    [DisplayName("Provisional Dividend Rate")]
    [IsoXmlTag("PrvsnlDvddRate")]
    public ActiveCurrencyAnd13DecimalAmount? ProvisionalDividendRate { get; init; }

    /// <summary>
    /// Proportionate allocation used for the offer.
    /// </summary>
    [IsoId("_TXW7Ydp-Ed-ak6NoX_4Aeg_-524725788")]
    [DisplayName("Proration Rate")]
    [IsoXmlTag("PrratnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ProrationRate { get; init; }

    /// <summary>
    /// Cash rate made available in an offer in order to encourage participation in the offer.
    /// </summary>
    [IsoId("_TXW7Ytp-Ed-ak6NoX_4Aeg_-524725787")]
    [DisplayName("Solicitation Fee Rate")]
    [IsoXmlTag("SlctnFeeRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? SolicitationFeeRate { get; init; }

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_TXW7Y9p-Ed-ak6NoX_4Aeg_361018486")]
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public TaxCreditRateFormat2Choice_? TaxCreditRate { get; init; }

    /// <summary>
    /// Percentage of the gross dividend rate on which tax must be paid.
    /// </summary>
    [IsoId("_TXW7ZNp-Ed-ak6NoX_4Aeg_-524725326")]
    [DisplayName("Tax Related Rate")]
    [IsoXmlTag("TaxRltdRate")]
    public RateTypeAndAmountAndStatus6? TaxRelatedRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_TXW7Zdp-Ed-ak6NoX_4Aeg_-524725757")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? WithholdingTaxRate { get; init; }

    /// <summary>
    /// Taxation applied on an amount clearly identified as an income.
    /// </summary>
    [IsoId("_TXW7Ztp-Ed-ak6NoX_4Aeg_-524725727")]
    [DisplayName("Tax On Income")]
    [IsoXmlTag("TaxOnIncm")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TaxOnIncome { get; init; }

    /// <summary>
    /// Taxation applied on an amount clearly identified as capital profits, capital gains.
    /// </summary>
    [IsoId("_TXW7Z9p-Ed-ak6NoX_4Aeg_-524725448")]
    [DisplayName("Tax On Profits")]
    [IsoXmlTag("TaxOnPrfts")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TaxOnProfits { get; init; }

    /// <summary>
    /// Percentage of cash that was paid in excess of actual tax obligation and was reclaimed.
    /// </summary>
    [IsoId("_TXW7aNp-Ed-ak6NoX_4Aeg_-524725418")]
    [DisplayName("Tax Reclaim Rate")]
    [IsoXmlTag("TaxRclmRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TaxReclaimRate { get; init; }

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_TXW7adp-Ed-ak6NoX_4Aeg_-524725387")]
    [DisplayName("Withholding Of Foreign Tax")]
    [IsoXmlTag("WhldgOfFrgnTax")]
    public RateAndAmountFormat5Choice_? WithholdingOfForeignTax { get; init; }

    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_TXgFUNp-Ed-ak6NoX_4Aeg_-524725356")]
    [DisplayName("Withholding Of Local Tax")]
    [IsoXmlTag("WhldgOfLclTax")]
    public RateAndAmountFormat5Choice_? WithholdingOfLocalTax { get; init; }

    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// </summary>
    [IsoId("_TXgFUdp-Ed-ak6NoX_4Aeg_-525646768")]
    [DisplayName("Additional Tax")]
    [IsoXmlTag("AddtlTax")]
    public RateAndAmountFormat5Choice_? AdditionalTax { get; init; }

    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_TXgFUtp-Ed-ak6NoX_4Aeg_-524725295")]
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ApplicableRate { get; init; }
}
