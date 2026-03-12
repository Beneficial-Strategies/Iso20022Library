// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status advising on the processing of the instruction.
/// </summary>
[IsoId("_sSu2t16uEeSyc4g_pm5hbw")]
[DisplayName("Instruction Processing Status")]
public partial record InstructionProcessingStatus3
{
    #nullable enable
    
    /// <summary>
    /// Status on the processing of the instructions.
    /// </summary>
    [IsoId("_svC_QV6uEeSyc4g_pm5hbw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status7Code Status { get; init; } 
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_svC_Q16uEeSyc4g_pm5hbw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
