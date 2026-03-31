// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the delivery return information.
    /// </summary>
    [KnownType(typeof(DeliveryReturn4Choice.Code))]
    [KnownType(typeof(DeliveryReturn4Choice.Proprietary))]
    [JsonDerivedType(typeof(DeliveryReturn4Choice.Code), nameof(DeliveryReturn4Choice.Code))]
    [JsonDerivedType(
        typeof(DeliveryReturn4Choice.Proprietary),
        nameof(DeliveryReturn4Choice.Proprietary)
    )]
    [IsoId("_6dqqNZNLEeWGlc8L7oPDIg")]
    [DisplayName("Delivery Return 4 Choice")]
    public abstract record DeliveryReturn4Choice_ { }
}
