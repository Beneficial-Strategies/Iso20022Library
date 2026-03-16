// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the shipment conditions.
    /// </summary>
    [KnownType(typeof(ShipmentCondition1Choice.Code))]
    [KnownType(typeof(ShipmentCondition1Choice.Proprietary))]
    [JsonDerivedType(typeof(ShipmentCondition1Choice.Code), nameof(ShipmentCondition1Choice.Code))]
    [JsonDerivedType(
        typeof(ShipmentCondition1Choice.Proprietary),
        nameof(ShipmentCondition1Choice.Proprietary)
    )]
    [IsoId("_TISQMLGdEeuSTr8k0UEM8A")]
    [DisplayName("Shipment Condition 1 Choice")]
    public abstract record ShipmentCondition1Choice_ { }
}
