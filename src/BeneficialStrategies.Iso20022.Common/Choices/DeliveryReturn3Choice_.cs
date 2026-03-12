// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the delivery return information.
    /// </summary>
    [KnownType(typeof(DeliveryReturn3Choice.Code))]
    [KnownType(typeof(DeliveryReturn3Choice.Proprietary))]
    [JsonDerivedType(typeof(DeliveryReturn3Choice.Code),nameof(DeliveryReturn3Choice.Code))]
    [JsonDerivedType(typeof(DeliveryReturn3Choice.Proprietary),nameof(DeliveryReturn3Choice.Proprietary))]
    [IsoId("_LtShkTtEEeWRTLSN0i0tng")]
    [DisplayName("Delivery Return 3 Choice")]
    public abstract partial record DeliveryReturn3Choice_
    {
    }
}
