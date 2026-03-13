// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a redemption multiple order.
/// </summary>
[IsoId("_U2ucZNp-Ed-ak6NoX_4Aeg_67130856")]
[DisplayName("Redemption Multiple Order Instruction")]
public partial record RedemptionMultipleOrderInstruction1
{
    #nullable enable
    
    /// <summary>
    /// General information related to the order.
    /// </summary>
    [IsoId("_U2ucZdp-Ed-ak6NoX_4Aeg_138242514")]
    [DisplayName("Multiple Order Details")]
    [IsoXmlTag("MltplOrdrDtls")]
    public required RedemptionMultipleOrder2 MultipleOrderDetails { get; init; } 
    
    /// <summary>
    /// Information related to an intermediary.
    /// </summary>
    [IsoId("_U2ucZtp-Ed-ak6NoX_4Aeg_1203328139")]
    [DisplayName("Intermediary Details")]
    [IsoXmlTag("IntrmyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary4> IntermediaryDetails { get; init; } = [];
    
    /// <summary>
    /// Message is a copy.
    /// </summary>
    [IsoId("_U2ucZ9p-Ed-ak6NoX_4Aeg_598156950")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_U2ucaNp-Ed-ak6NoX_4Aeg_645084899")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}
