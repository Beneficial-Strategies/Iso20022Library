// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the details of the price applicable to the derivative transaction.
/// </summary>
[IsoId("_IGnwMTN0Ee2gE4h-lpiUxQ")]
[DisplayName("Price Data")]
public record PriceData2
{
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable: fees, taxes or commissions.
    /// </summary>
    [IsoId("_IICsgTN0Ee2gE4h-lpiUxQ")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public SecuritiesTransactionPrice17Choice_? Price { get; init; }

    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions with prices varying throughout the life of the transaction.
    /// </summary>
    [IsoId("_IICsgzN0Ee2gE4h-lpiUxQ")]
    [DisplayName("Schedule Period")]
    [IsoXmlTag("SchdlPrd")]
    public ValueList<Schedule1> SchedulePeriod { get; init; } = [];

    /// <summary>
    /// Specifies the unit of measure in which the price is expressed.
    /// </summary>
    [IsoId("_IICshTN0Ee2gE4h-lpiUxQ")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; }

    /// <summary>
    /// Number of units of the underlying instrument represented by a single derivative contract.
    /// </summary>
    [IsoId("_IICshzN0Ee2gE4h-lpiUxQ")]
    [DisplayName("Price Multiplier")]
    [IsoXmlTag("PricMltplr")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    public IsoLongFraction19DecimalNumber? PriceMultiplier { get; init; }
}
