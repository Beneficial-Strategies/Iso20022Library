// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information related to the processing of the charges instruction that may need to be acted upon by the instructed agent. The instruction may relate to an instruction that has to be executed by the instructed agent, or may be information required by the instructed agent.
/// </summary>
[IsoId("_8wlHkbt5Eeq_cfXrH83Rcw")]
[DisplayName("Instruction For Instructed Agent")]
public record InstructionForInstructedAgent1
{
    /// <summary>
    /// Coded information related to the processing of the payment instruction, provided by the initiating party, and intended for the instructed agent.
    /// </summary>
    [IsoId("_8xrTwbt5Eeq_cfXrH83Rcw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public ExternalInstructedAgentInstruction1Code? Code { get; init; }

    /// <summary>
    /// Further information complementing the coded instruction or instruction to the instructed agent that is bilaterally agreed or specific to a user community.
    /// </summary>
    [IsoId("_8xrTw7t5Eeq_cfXrH83Rcw")]
    [DisplayName("Instruction Information")]
    [IsoXmlTag("InstrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionInformation { get; init; }
}
