// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the frequency of the trade query execution.
/// </summary>
[IsoId("_et5Wt91dEeqxpKDfBZC1vg")]
[DisplayName("Trade Query Execution Frequency")]
public record TradeQueryExecutionFrequency3
{
    /// <summary>
    /// Specifies the frequency type of the trade query execution.
    /// </summary>
    [IsoId("_evMXN91dEeqxpKDfBZC1vg")]
    [DisplayName("Frequency Type")]
    [IsoXmlTag("FrqcyTp")]
    public required Frequency14Code FrequencyType { get; init; }

    /// <summary>
    /// Specifies the day of the expected delivery of the query response.
    /// </summary>
    [IsoId("_evMXOd1dEeqxpKDfBZC1vg")]
    [DisplayName("Delivery Day")]
    [IsoXmlTag("DlvryDay")]
    public WeekDay3Code? DeliveryDay { get; init; }

    /// <summary>
    /// Day of the month of the monthly query execution.
    /// </summary>
    [IsoId("_evMXO91dEeqxpKDfBZC1vg")]
    [DisplayName("Day Of Month")]
    [IsoXmlTag("DayOfMnth")]
    [IsoSimpleType(IsoSimpleType.DayOfMonthNumber)]
    public IsoDayOfMonthNumber? DayOfMonth { get; init; }
}
