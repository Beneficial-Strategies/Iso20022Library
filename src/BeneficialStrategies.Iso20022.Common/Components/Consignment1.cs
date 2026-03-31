// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Physical packaging of goods for transport.
/// </summary>
[IsoId("_Tms--9p-Ed-ak6NoX_4Aeg_-1622845025")]
[DisplayName("Consignment")]
public record Consignment1
{
    /// <summary>
    /// Total quantity of packaging units, eg number of boxes, containers, pallets, etc.
    /// </summary>
    [IsoId("_Tms-_Np-Ed-ak6NoX_4Aeg_-1580364507")]
    [DisplayName("Total Quantity")]
    [IsoXmlTag("TtlQty")]
    public Quantity3? TotalQuantity { get; init; }

    /// <summary>
    /// Total volume of goods shipped, eg number of cubic meters.
    /// </summary>
    [IsoId("_Tms-_dp-Ed-ak6NoX_4Aeg_-1580364499")]
    [DisplayName("Total Volume")]
    [IsoXmlTag("TtlVol")]
    public Quantity3? TotalVolume { get; init; }

    /// <summary>
    /// Total weight of goods shipped, eg number of kg, tons.
    /// </summary>
    [IsoId("_Tms-_tp-Ed-ak6NoX_4Aeg_-1580364476")]
    [DisplayName("Total Weight")]
    [IsoXmlTag("TtlWght")]
    public Quantity3? TotalWeight { get; init; }
}
