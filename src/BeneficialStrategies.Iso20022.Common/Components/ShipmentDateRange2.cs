// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a shipment schedule, that is the quantity that must be shipped no sooner than the earliest shipment date and no later than the latest shipment date.
/// </summary>
[IsoId("_Sp5_hdp-Ed-ak6NoX_4Aeg_-1202382033")]
[DisplayName("Shipment Date Range")]
public partial record ShipmentDateRange2
{
    #nullable enable
    
    /// <summary>
    /// Sub quantity that must be shipped no sooner than the earliest shipment date and no later than the latest shipment date.
    /// </summary>
    [IsoId("_Sp5_htp-Ed-ak6NoX_4Aeg_-1202382015")]
    [DisplayName("Sub Quantity Value")]
    [IsoXmlTag("SubQtyVal")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber SubQuantityValue { get; init; } 
    
    /// <summary>
    /// Earliest date whereby the goods must be shipped.
    /// </summary>
    [IsoId("_Sp5_h9p-Ed-ak6NoX_4Aeg_-876378095")]
    [DisplayName("Earliest Shipment Date")]
    [IsoXmlTag("EarlstShipmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EarliestShipmentDate { get; init; } 
    
    /// <summary>
    /// Latest date whereby the goods must be shipped.
    /// </summary>
    [IsoId("_SqDwgNp-Ed-ak6NoX_4Aeg_-1202381938")]
    [DisplayName("Latest Shipment Date")]
    [IsoXmlTag("LatstShipmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LatestShipmentDate { get; init; } 
    
    
    #nullable disable
    
}
