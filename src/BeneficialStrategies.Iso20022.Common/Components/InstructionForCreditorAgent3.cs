// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IInstructionForCreditorAgent3"/>
[IsoId("_PRQQx8QAEemsic1bQcEtLA")]
[DisplayName("Instruction For Creditor Agent")]
public partial record InstructionForCreditorAgent3
{
    /// <inheritdoc cref="IInstructionForCreditorAgent3.Code"/>
    [IsoId("_PdEe8cQAEemsic1bQcEtLA")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public ExternalCreditorAgentInstruction1Code? Code { get; init; }

    /// <inheritdoc cref="IInstructionForCreditorAgent3.InstructionInformation"/>
    [IsoId("_PdEe88QAEemsic1bQcEtLA")]
    [DisplayName("Instruction Information")]
    [IsoXmlTag("InstrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionInformation { get; init; }
}
