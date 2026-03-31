// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an earliest shipment date and a latest shipment date.
/// </summary>
[IsoId("_Sp5_gtp-Ed-ak6NoX_4Aeg_-1649364101")]
[DisplayName("Shipment Date Range")]
public record ShipmentDateRange1
{
    /// <summary>
    /// Earliest date whereby the goods must be shipped.
    /// </summary>
    [IsoId("_Sp5_g9p-Ed-ak6NoX_4Aeg_-1349221863")]
    [DisplayName("Earliest Shipment Date")]
    [IsoXmlTag("EarlstShipmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EarliestShipmentDate { get; init; }

    /// <summary>
    /// Latest date whereby the goods must be shipped.
    /// </summary>
    [IsoId("_Sp5_hNp-Ed-ak6NoX_4Aeg_-1302121318")]
    [DisplayName("Latest Shipment Date")]
    [IsoXmlTag("LatstShipmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LatestShipmentDate { get; init; }
}
