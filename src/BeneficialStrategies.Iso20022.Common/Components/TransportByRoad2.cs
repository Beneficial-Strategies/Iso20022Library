// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the transportation of goods by road.
/// </summary>
[IsoId("_SuOe2dp-Ed-ak6NoX_4Aeg_-77444670")]
[DisplayName("Transport By Road")]
public record TransportByRoad2
{
    /// <summary>
    /// Identifies the location where the goods are received for transportation.
    /// </summary>
    [IsoId("_SuOe2tp-Ed-ak6NoX_4Aeg_-1400067178")]
    [DisplayName("Place Of Receipt")]
    [IsoXmlTag("PlcOfRct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PlaceOfReceipt { get; init; }

    /// <summary>
    /// Identifies the location of delivery of the goods.
    /// </summary>
    [IsoId("_SuOe29p-Ed-ak6NoX_4Aeg_-1400067238")]
    [DisplayName("Place Of Delivery")]
    [IsoXmlTag("PlcOfDlvry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PlaceOfDelivery { get; init; }

    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_SuOe3Np-Ed-ak6NoX_4Aeg_994762252")]
    [DisplayName("Road Carrier Name")]
    [IsoXmlTag("RoadCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RoadCarrierName { get; init; }
}
