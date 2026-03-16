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
[IsoId("_StL9Adp-Ed-ak6NoX_4Aeg_-886888907")]
[DisplayName("Single Transport")]
public record SingleTransport3
{
    /// <summary>
    /// Information related to the transportation of goods by air.
    /// </summary>
    [IsoId("_StL9Atp-Ed-ak6NoX_4Aeg_-886888751")]
    [DisplayName("Transport By Air")]
    [IsoXmlTag("TrnsprtByAir")]
    public TransportByAir2? TransportByAir { get; init; }

    /// <summary>
    /// Information related for the transportation of goods by sea.
    /// </summary>
    [IsoId("_StL9A9p-Ed-ak6NoX_4Aeg_-886888829")]
    [DisplayName("Transport By Sea")]
    [IsoXmlTag("TrnsprtBySea")]
    public TransportBySea4? TransportBySea { get; init; }

    /// <summary>
    /// Information related to the transportation of goods by road.
    /// </summary>
    [IsoId("_StL9BNp-Ed-ak6NoX_4Aeg_-886888870")]
    [DisplayName("Transport By Road")]
    [IsoXmlTag("TrnsprtByRoad")]
    public TransportByRoad2? TransportByRoad { get; init; }

    /// <summary>
    /// Information related to the transportation of goods by rail.
    /// </summary>
    [IsoId("_StL9Bdp-Ed-ak6NoX_4Aeg_-886888794")]
    [DisplayName("Transport By Rail")]
    [IsoXmlTag("TrnsprtByRail")]
    public TransportByRail2? TransportByRail { get; init; }
}
