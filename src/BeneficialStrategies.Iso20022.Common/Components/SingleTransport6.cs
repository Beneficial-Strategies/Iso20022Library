// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies individually each leg of a transport of goods.
/// </summary>
[IsoId("_hmI9AdQwEeK0PPbKncCqzA")]
[DisplayName("Single Transport")]
public record SingleTransport6
{
    /// <summary>
    /// Information related to the transportation of goods by air.
    /// </summary>
    [IsoId("_iBomMdQwEeK0PPbKncCqzA")]
    [DisplayName("Transport By Air")]
    [IsoXmlTag("TrnsprtByAir")]
    public TransportByAir4? TransportByAir { get; init; }

    /// <summary>
    /// Information related for the transportation of goods by sea.
    /// </summary>
    [IsoId("_iBomM9QwEeK0PPbKncCqzA")]
    [DisplayName("Transport By Sea")]
    [IsoXmlTag("TrnsprtBySea")]
    public TransportBySea5? TransportBySea { get; init; }

    /// <summary>
    /// Moving of goods or people from one place to another by vehicle.
    /// </summary>
    [IsoId("_iBomNdQwEeK0PPbKncCqzA")]
    [DisplayName("Transport By Road")]
    [IsoXmlTag("TrnsprtByRoad")]
    public TransportByRoad4? TransportByRoad { get; init; }

    /// <summary>
    /// Information related to the transportation of goods by rail.
    /// </summary>
    [IsoId("_iBomN9QwEeK0PPbKncCqzA")]
    [DisplayName("Transport By Rail")]
    [IsoXmlTag("TrnsprtByRail")]
    public TransportByRail4? TransportByRail { get; init; }
}
