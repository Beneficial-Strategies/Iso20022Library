// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Plan that allows investors to schedule periodical investments or divestments, according to pre-defined criteria.
/// </summary>
[IsoId("_QMaCWNp-Ed-ak6NoX_4Aeg_-262632071")]
[DisplayName("Investment Plan")]
public record InvestmentPlan4
{
    /// <summary>
    /// Frequency of the investment or divestment.
    /// </summary>
    [IsoId("_QMaCWdp-Ed-ak6NoX_4Aeg_-262631881")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required EventFrequency1Code Frequency { get; init; }

    /// <summary>
    /// Frequency of the investment or divestment.
    /// </summary>
    [IsoId("_QMaCWtp-Ed-ak6NoX_4Aeg_386548944")]
    [DisplayName("Extended Frequency")]
    [IsoXmlTag("XtndedFrqcy")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedFrequency { get; init; }

    /// <summary>
    /// Date the investment plan starts.
    /// </summary>
    [IsoId("_QMaCW9p-Ed-ak6NoX_4Aeg_-262631029")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate StartDate { get; init; }

    /// <summary>
    /// Date the investment plan stops.
    /// </summary>
    [IsoId("_QMjMQNp-Ed-ak6NoX_4Aeg_-262630596")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; }

    /// <summary>
    /// Currency and amount of the periodical payments.
    /// </summary>
    [IsoId("_QMjMQdp-Ed-ak6NoX_4Aeg_-262630536")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether an ordered amount is a gross amount (including all charges, commissions, tax). If it is not a gross amount, the ordered amount is a net amount (amount to be invested or redeemed from the fund to which other elements will be added).
    /// </summary>
    [IsoId("_QMjMQtp-Ed-ak6NoX_4Aeg_-261710504")]
    [DisplayName("Gross Amount Indicator")]
    [IsoXmlTag("GrssAmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? GrossAmountIndicator { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_QMjMQ9p-Ed-ak6NoX_4Aeg_-261710469")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Number of pre-paid instalment periods at the time the investment plan is created.
    /// </summary>
    [IsoId("_QMjMRNp-Ed-ak6NoX_4Aeg_-261710427")]
    [DisplayName("Initial Number Of Instalment")]
    [IsoXmlTag("InitlNbOfInstlmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? InitialNumberOfInstalment { get; init; }

    /// <summary>
    /// Total number of times the amount must be invested at the predefined frequency as of the start date of the investment plan.
    /// </summary>
    [IsoId("_QMjMRdp-Ed-ak6NoX_4Aeg_-261710374")]
    [DisplayName("Total Number Of Instalment")]
    [IsoXmlTag("TtlNbOfInstlmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfInstalment { get; init; }

    /// <summary>
    /// Indicates the rounding direction when an amount is to be spread over several funds.
    /// </summary>
    [IsoId("_QMjMRtp-Ed-ak6NoX_4Aeg_-2101951286")]
    [DisplayName("Rounding Direction")]
    [IsoXmlTag("RndgDrctn")]
    public RoundingDirection1Code? RoundingDirection { get; init; }

    /// <summary>
    /// Security that an investment plan invests in, or from which the investment plan divests.
    /// </summary>
    [IsoId("_QMjMR9p-Ed-ak6NoX_4Aeg_-261709915")]
    [DisplayName("Security Details")]
    [IsoXmlTag("SctyDtls")]
    [MinLength(1)]
    [MaxLength(50)]
    public ValueList<Repartition1> SecurityDetails { get; init; } = [];

    /// <summary>
    /// Cash settlement standing instruction associated to the investment plan.
    /// </summary>
    [IsoId("_QMjMSNp-Ed-ak6NoX_4Aeg_-261709011")]
    [DisplayName("Cash Settlement")]
    [IsoXmlTag("CshSttlm")]
    public InvestmentFundCashSettlementInformation3? CashSettlement { get; init; }
}
