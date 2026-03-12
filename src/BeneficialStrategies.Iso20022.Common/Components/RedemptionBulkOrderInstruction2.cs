// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a redemption bulk order.
/// </summary>
[IsoId("_RO293Np-Ed-ak6NoX_4Aeg_-1015929589")]
[DisplayName("Redemption Bulk Order Instruction")]
public partial record RedemptionBulkOrderInstruction2
{
    #nullable enable
    
    /// <summary>
    /// Common information related to all the orders.
    /// </summary>
    [IsoId("_RO293dp-Ed-ak6NoX_4Aeg_-1015929545")]
    [DisplayName("Bulk Order Details")]
    [IsoXmlTag("BlkOrdrDtls")]
    public required RedemptionBulkOrder3 BulkOrderDetails { get; init; } 
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_RO293tp-Ed-ak6NoX_4Aeg_-1015929503")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary8> RelatedPartyDetails { get; init; } = new ValueList<Intermediary8>(){};
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RPAu0Np-Ed-ak6NoX_4Aeg_-1015929468")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}
