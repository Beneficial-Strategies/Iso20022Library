// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between earliest/latest shipment date and a shipment schedule per sub quantity of line item quantity.
    /// </summary>
    [KnownType(typeof(ShipmentSchedule2Choice.ShipmentDateRange))]
    [KnownType(typeof(ShipmentSchedule2Choice.ShipmentSubSchedule))]
    [JsonDerivedType(typeof(ShipmentSchedule2Choice.ShipmentDateRange),nameof(ShipmentSchedule2Choice.ShipmentDateRange))]
    [JsonDerivedType(typeof(ShipmentSchedule2Choice.ShipmentSubSchedule),nameof(ShipmentSchedule2Choice.ShipmentSubSchedule))]
    [IsoId("_z9WAAefHEeKNfc-Rw_dPYg")]
    [DisplayName("Shipment Schedule 2 Choice")]
    public abstract partial record ShipmentSchedule2Choice_
    {
    }
}
