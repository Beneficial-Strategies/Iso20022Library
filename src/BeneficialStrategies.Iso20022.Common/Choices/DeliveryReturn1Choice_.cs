// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the delivery return information.
    /// </summary>
    [KnownType(typeof(DeliveryReturn1Choice.Code))]
    [KnownType(typeof(DeliveryReturn1Choice.Proprietary))]
    [JsonDerivedType(typeof(DeliveryReturn1Choice.Code), nameof(DeliveryReturn1Choice.Code))]
    [JsonDerivedType(
        typeof(DeliveryReturn1Choice.Proprietary),
        nameof(DeliveryReturn1Choice.Proprietary)
    )]
    [IsoId("_QuOV89p-Ed-ak6NoX_4Aeg_1305476197")]
    [DisplayName("Delivery Return 1 Choice")]
    public abstract record DeliveryReturn1Choice_ { }
}
