// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details for the penalty calculation.
/// </summary>
[IsoId("_eaMcYDkVEem897H7zB2RJg")]
[DisplayName("Penalty Calculation Record1")]
public record PenaltyCalculationRecord1
{
    /// <summary>
    /// Date for which the penalty applies.
    /// </summary>
    [IsoId("_qVHWQDkVEem897H7zB2RJg")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public required IsoISODate Date { get; init; }

    /// <summary>
    /// Information provided for penalties where there is missing reference data on this business day.
    /// </summary>
    [IsoId("_woNsADkVEem897H7zB2RJg")]
    [DisplayName("Missing Reference Data")]
    [IsoXmlTag("MssngRefData")]
    public IsoTrueFalseIndicator? MissingReferenceData { get; init; }

    /// <summary>
    /// Further details on the financial instrument reported.
    /// </summary>
    [IsoId("_GhRqADkWEem897H7zB2RJg")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public required PenaltyFinancialInstrumentIdentification1 FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Discount rate for the currency of the penalty, provided if the Security is subject to penalties.
    /// </summary>
    [IsoId("_BDxtQDkbEem897H7zB2RJg")]
    [DisplayName("Discount Rate")]
    [IsoXmlTag("DscntRate")]
    public PriceRateOrAmount4Choice? DiscountRate { get; init; }

    /// <summary>
    /// Further details on the foreign exchange rate.
    /// </summary>
    [IsoId("_pqW6YWHYEemrM9-N4eJYkA")]
    [DisplayName("Foreign Exchange Data")]
    [IsoXmlTag("FXData")]
    public ValueList<ForeignExchangeRate3> ForeignExchangeData { get; init; } = [];

    /// <summary>
    /// Breakdown into sub-amounts that compose the penalty total amount.
    /// </summary>
    [IsoId("_Jz6GIDkbEem897H7zB2RJg")]
    [DisplayName("Sub Amount Penalty Breakdown")]
    [IsoXmlTag("SubAmtPnltyBrkdwn")]
    public ValueList<PenaltyAmountBreakdown1> SubAmountPenaltyBreakdown { get; init; } = [];
}
