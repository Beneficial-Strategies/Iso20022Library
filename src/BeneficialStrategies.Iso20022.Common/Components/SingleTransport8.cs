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
[IsoId("__F4NETckEeSaC-PiOaz_KQ")]
[DisplayName("Single Transport")]
public record SingleTransport8
{
    /// <summary>
    /// Information related to the transportation of goods by air.
    /// </summary>
    [IsoId("__bvvYTckEeSaC-PiOaz_KQ")]
    [DisplayName("Transport By Air")]
    [IsoXmlTag("TrnsprtByAir")]
    public ValueList<TransportByAir4> TransportByAir { get; init; } = [];

    /// <summary>
    /// Information related for the transportation of goods by sea.
    /// </summary>
    [IsoId("__bvvYzckEeSaC-PiOaz_KQ")]
    [DisplayName("Transport By Sea")]
    [IsoXmlTag("TrnsprtBySea")]
    public ValueList<TransportBySea5> TransportBySea { get; init; } = [];

    /// <summary>
    /// Moving of goods or people from one place to another by vehicle.
    /// </summary>
    [IsoId("__bvvZTckEeSaC-PiOaz_KQ")]
    [DisplayName("Transport By Road")]
    [IsoXmlTag("TrnsprtByRoad")]
    public ValueList<TransportByRoad4> TransportByRoad { get; init; } = [];

    /// <summary>
    /// Information related to the transportation of goods by rail.
    /// </summary>
    [IsoId("__bvvZzckEeSaC-PiOaz_KQ")]
    [DisplayName("Transport By Rail")]
    [IsoXmlTag("TrnsprtByRail")]
    public ValueList<TransportByRail4> TransportByRail { get; init; } = [];
}
