// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of the delivery point(s) of market area(s) or the interconnection point of a transportation contract.
    /// </summary>
    [KnownType(typeof(DeliveryInterconnectionPoint1Choice.Code))]
    [KnownType(typeof(DeliveryInterconnectionPoint1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(DeliveryInterconnectionPoint1Choice.Code),
        nameof(DeliveryInterconnectionPoint1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(DeliveryInterconnectionPoint1Choice.Proprietary),
        nameof(DeliveryInterconnectionPoint1Choice.Proprietary)
    )]
    [IsoId("_pRKJ0IOrEeWqmeP8QNJBew")]
    [DisplayName("Delivery Interconnection Point 1 Choice")]
    public abstract record DeliveryInterconnectionPoint1Choice_ { }
}
