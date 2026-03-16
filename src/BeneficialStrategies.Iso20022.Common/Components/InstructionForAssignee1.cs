// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information related to the processing of the investigation that may need to be acted upon by the assignee.
/// </summary>
[IsoId("_cj1mAdA1EeeCAfThR1cp_Q")]
[DisplayName("Instruction For Assignee")]
public record InstructionForAssignee1
{
    /// <summary>
    /// Coded information related to the processing of the investigation instruction, provided by the assigner, and intended for the assignee.
    /// </summary>
    [IsoId("_czjdAdA1EeeCAfThR1cp_Q")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public ExternalAgentInstruction1Code? Code { get; init; }

    /// <summary>
    /// Further information complementing the coded instruction or instruction to the assignee.
    /// </summary>
    [IsoId("_czjdA9A1EeeCAfThR1cp_Q")]
    [DisplayName("Instruction Information")]
    [IsoXmlTag("InstrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionInformation { get; init; }
}
