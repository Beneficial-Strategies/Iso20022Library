// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the line item number and the purchase order.
/// </summary>
[IsoId("_RaVOBdp-Ed-ak6NoX_4Aeg_-1742051329")]
[DisplayName("Line Item And PO Identification")]
public partial record LineItemAndPOIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a line item.
    /// </summary>
    [IsoId("_RaVOBtp-Ed-ak6NoX_4Aeg_-1638617880")]
    [DisplayName("Line Item Identification")]
    [IsoXmlTag("LineItmId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    public SimpleValueList<System.String> LineItemIdentification { get; init; } = [];
    // ID for the above is _RaVOBtp-Ed-ak6NoX_4Aeg_-1638617880
    
    /// <summary>
    /// Reference to the purchase order containing the line item.
    /// </summary>
    [IsoId("_RaVOB9p-Ed-ak6NoX_4Aeg_-1399423976")]
    [DisplayName("Purchase Order Reference")]
    [IsoXmlTag("PurchsOrdrRef")]
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    
    
    #nullable disable
    
}
