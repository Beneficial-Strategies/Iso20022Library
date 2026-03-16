// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the reference quantity of the transaction and the schedule applicable to the quantity computation.
/// </summary>
[IsoId("_8P5WAAbHEeqrW7Meu5r3kQ")]
[DisplayName("Notional Quantity")]
public record NotionalQuantity1
{
    /// <summary>
    /// Number of units of the financial instrument, that is, the nominal value.
    /// </summary>
    [IsoId("__zSkQgbHEeqrW7Meu5r3kQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    public required IsoLongFraction19DecimalNumber Quantity { get; init; }

    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions negotiated in non-monetary amounts with a notional quantity varying throughout the life of the transaction.
    /// </summary>
    [IsoId("_ZIXWIQbIEeqrW7Meu5r3kQ")]
    [DisplayName("Schedule")]
    [IsoXmlTag("Schdl")]
    public Schedule2? Schedule { get; init; }

    /// <summary>
    /// Indicates the unit of measure in which the total notional quantity and notional quantity schedules are expressed.
    /// </summary>
    [IsoId("__zSkQwbHEeqrW7Meu5r3kQ")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public required UnitOfMeasure12Code UnitOfMeasure { get; init; }
}
