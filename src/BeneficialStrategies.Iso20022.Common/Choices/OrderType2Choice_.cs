// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the order type.
    /// </summary>
    [KnownType(typeof(OrderType2Choice.Type))]
    [KnownType(typeof(OrderType2Choice.Proprietary))]
    [JsonDerivedType(typeof(OrderType2Choice.Type),nameof(OrderType2Choice.Type))]
    [JsonDerivedType(typeof(OrderType2Choice.Proprietary),nameof(OrderType2Choice.Proprietary))]
    [IsoId("_cw18IVxUEeWvPv3PXpS3fw")]
    [DisplayName("Order Type 2 Choice")]
    public abstract partial record OrderType2Choice_
    {
    }
}
