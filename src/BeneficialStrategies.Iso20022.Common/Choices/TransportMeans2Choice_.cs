// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Describes the multimodal or the individual transport of goods.
    /// </summary>
    [KnownType(typeof(TransportMeans2Choice.IndividualTransport))]
    [KnownType(typeof(TransportMeans2Choice.MultimodalTransport))]
    [JsonDerivedType(typeof(TransportMeans2Choice.IndividualTransport),nameof(TransportMeans2Choice.IndividualTransport))]
    [JsonDerivedType(typeof(TransportMeans2Choice.MultimodalTransport),nameof(TransportMeans2Choice.MultimodalTransport))]
    [IsoId("_U7oxkdp-Ed-ak6NoX_4Aeg_-761772709")]
    [DisplayName("Transport Means 2 Choice")]
    public abstract partial record TransportMeans2Choice_
    {
    }
}
