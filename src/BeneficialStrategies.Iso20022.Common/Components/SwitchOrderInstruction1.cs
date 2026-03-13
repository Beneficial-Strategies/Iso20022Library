// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a switch order.
/// </summary>
[IsoId("_Uzce69p-Ed-ak6NoX_4Aeg_-530074752")]
[DisplayName("Switch Order Instruction")]
public partial record SwitchOrderInstruction1
{
    #nullable enable
    
    /// <summary>
    /// Information related to the switch order.
    /// </summary>
    [IsoId("_Uzce7Np-Ed-ak6NoX_4Aeg_1247508566")]
    [DisplayName("Switch Order Details")]
    [IsoXmlTag("SwtchOrdrDtls")]
    public required SwitchOrder2 SwitchOrderDetails { get; init; } 
    
    /// <summary>
    /// Confirmation of the information related to an intermediary.
    /// </summary>
    [IsoId("_UzmP4Np-Ed-ak6NoX_4Aeg_-1252533605")]
    [DisplayName("Intermediary Details")]
    [IsoXmlTag("IntrmyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary4> IntermediaryDetails { get; init; } = [];
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_UzmP4dp-Ed-ak6NoX_4Aeg_1405488591")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_UzmP4tp-Ed-ak6NoX_4Aeg_1159218851")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}
