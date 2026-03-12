// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between earliest/latest shipment date and a shipment schedule per sub quantity of line item quantity.
    /// </summary>
    [KnownType(typeof(ShipmentSchedule1Choice.ShipmentDateRange))]
    [KnownType(typeof(ShipmentSchedule1Choice.ShipmentSubSchedule))]
    [JsonDerivedType(typeof(ShipmentSchedule1Choice.ShipmentDateRange),nameof(ShipmentSchedule1Choice.ShipmentDateRange))]
    [JsonDerivedType(typeof(ShipmentSchedule1Choice.ShipmentSubSchedule),nameof(ShipmentSchedule1Choice.ShipmentSubSchedule))]
    [IsoId("_Rb-Mytp-Ed-ak6NoX_4Aeg_-786797544")]
    [DisplayName("Shipment Schedule 1 Choice")]
    public abstract partial record ShipmentSchedule1Choice_
    {
    }
}
