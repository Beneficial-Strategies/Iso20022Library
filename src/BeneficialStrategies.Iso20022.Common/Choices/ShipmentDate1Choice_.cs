// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between proposed and actual shipment date.
    /// </summary>
    [KnownType(typeof(ShipmentDate1Choice.ProposedShipmentDate))]
    [KnownType(typeof(ShipmentDate1Choice.ActualShipmentDate))]
    [JsonDerivedType(
        typeof(ShipmentDate1Choice.ProposedShipmentDate),
        nameof(ShipmentDate1Choice.ProposedShipmentDate)
    )]
    [JsonDerivedType(
        typeof(ShipmentDate1Choice.ActualShipmentDate),
        nameof(ShipmentDate1Choice.ActualShipmentDate)
    )]
    [IsoId("_qi4msDATEeOKib24wnHaFg")]
    [DisplayName("Shipment Date 1 Choice")]
    public abstract record ShipmentDate1Choice_ { }
}
