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
[IsoId("_XES6ISJBEe2zWP9pqvmqdw")]
[DisplayName("Notional Quantity")]
public record NotionalQuantity9
{
    /// <summary>
    /// Number of units of the financial instrument, that is, the nominal value.
    /// </summary>
    [IsoId("_XFM5ESJBEe2zWP9pqvmqdw")]
    [DisplayName("Total Quantity")]
    [IsoXmlTag("TtlQty")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    public IsoLongFraction19DecimalNumber? TotalQuantity { get; init; }

    /// <summary>
    /// Indicates the unit of measure in which the total notional quantity and notional quantity schedules are expressed.
    /// </summary>
    [IsoId("_XFM5FSJBEe2zWP9pqvmqdw")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; }

    /// <summary>
    /// Indicates the schedule or frequency of the derivative transactions.
    /// </summary>
    [IsoId("_ZJkvICJCEe2zWP9pqvmqdw")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public QuantityOrTerm1Choice_? Details { get; init; }
}
