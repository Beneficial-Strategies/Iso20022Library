// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the transportation of goods by rail.
/// </summary>
[IsoId("_SuFU5dp-Ed-ak6NoX_4Aeg_6597074")]
[DisplayName("Transport By Rail")]
public record TransportByRail2
{
    /// <summary>
    /// Identifies the location where the goods are received for transportation.
    /// </summary>
    [IsoId("_SuFU5tp-Ed-ak6NoX_4Aeg_1824086883")]
    [DisplayName("Place Of Receipt")]
    [IsoXmlTag("PlcOfRct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PlaceOfReceipt { get; init; }

    /// <summary>
    /// Identifies the location of delivery of the goods.
    /// </summary>
    [IsoId("_SuFU59p-Ed-ak6NoX_4Aeg_1824086866")]
    [DisplayName("Place Of Delivery")]
    [IsoXmlTag("PlcOfDlvry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PlaceOfDelivery { get; init; }

    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_SuFU6Np-Ed-ak6NoX_4Aeg_1041864158")]
    [DisplayName("Rail Carrier Name")]
    [IsoXmlTag("RailCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RailCarrierName { get; init; }
}
