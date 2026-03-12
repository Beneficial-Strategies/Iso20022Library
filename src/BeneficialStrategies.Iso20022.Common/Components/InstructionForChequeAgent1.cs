// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information related to the processing of the cheque instruction that may need to be acted upon by the receiving agent.
/// </summary>
[IsoId("_93bgEbtnEeq_cfXrH83Rcw")]
[DisplayName("Instruction For Cheque Agent")]
public partial record InstructionForChequeAgent1
{
    #nullable enable
    
    /// <summary>
    /// Coded information related to the processing of the cheque, intended for the receiving agent.
    /// </summary>
    [IsoId("_94B9AbtnEeq_cfXrH83Rcw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public ExternalChequeAgentInstruction1Code? Code { get; init; } 
    
    /// <summary>
    /// Further information complementing the coded instruction or instruction to the cheque agent that is bilaterally agreed or specific to a user community.
    /// </summary>
    [IsoId("_94B9A7tnEeq_cfXrH83Rcw")]
    [DisplayName("Instruction Information")]
    [IsoXmlTag("InstrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? InstructionInformation { get; init; } 
    
    
    #nullable disable
    
}
