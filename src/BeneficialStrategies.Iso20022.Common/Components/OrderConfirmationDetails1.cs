// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order confirmation details.
/// </summary>
[IsoId("_RPAu1Np-Ed-ak6NoX_4Aeg_2133695541")]
[DisplayName("Order Confirmation Details")]
public partial record OrderConfirmationDetails1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.
    /// </summary>
    [IsoId("_RPAu1dp-Ed-ak6NoX_4Aeg_-1991936657")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AmendmentIndicator { get; init; } 
    
    /// <summary>
    /// General information related to the execution of investment fund orders.
    /// </summary>
    [IsoId("_RPAu1tp-Ed-ak6NoX_4Aeg_2134621993")]
    [DisplayName("Bulk Execution Details")]
    [IsoXmlTag("BlkExctnDtls")]
    public required RedemptionBulkExecution3 BulkExecutionDetails { get; init; } 
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_RPAu19p-Ed-ak6NoX_4Aeg_2134619167")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary9> RelatedPartyDetails { get; init; } = [];
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RPAu2Np-Ed-ak6NoX_4Aeg_2134620848")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}
