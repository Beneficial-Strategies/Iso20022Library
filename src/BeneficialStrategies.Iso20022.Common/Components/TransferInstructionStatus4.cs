// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction status.
/// </summary>
[IsoId("_H_n8ISY_EeW_ZNn8gbfY7Q")]
[DisplayName("Transfer Instruction Status")]
public partial record TransferInstructionStatus4
{
    #nullable enable
    
    /// <summary>
    /// Status code.
    /// </summary>
    [IsoId("_Ibc8gyY_EeW_ZNn8gbfY7Q")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TransferStatus4Code Status { get; init; } 
    
    /// <summary>
    /// Reason for the status.
    /// </summary>
    [IsoId("_Ibc8hSY_EeW_ZNn8gbfY7Q")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Reason { get; init; } 
    
    
    #nullable disable
    
}
