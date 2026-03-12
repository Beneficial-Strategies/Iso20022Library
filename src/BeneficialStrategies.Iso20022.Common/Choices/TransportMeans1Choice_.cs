// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Describes the multimodal or the individual transport of goods.
    /// </summary>
    [KnownType(typeof(TransportMeans1Choice.IndividualTransport))]
    [KnownType(typeof(TransportMeans1Choice.MultimodalTransport))]
    [JsonDerivedType(typeof(TransportMeans1Choice.IndividualTransport),nameof(TransportMeans1Choice.IndividualTransport))]
    [JsonDerivedType(typeof(TransportMeans1Choice.MultimodalTransport),nameof(TransportMeans1Choice.MultimodalTransport))]
    [IsoId("_U7oxlNp-Ed-ak6NoX_4Aeg_1112735251")]
    [DisplayName("Transport Means 1 Choice")]
    public abstract partial record TransportMeans1Choice_
    {
    }
}
