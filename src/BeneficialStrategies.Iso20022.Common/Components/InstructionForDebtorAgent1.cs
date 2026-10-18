// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IInstructionForDebtorAgent1"/>
[IsoId("_WpOTg8saEemxFbEZK-FMzw")]
[DisplayName("Instruction For Debtor Agent")]
public partial record InstructionForDebtorAgent1
{
    /// <inheritdoc cref="IInstructionForDebtorAgent1.Code"/>
    [IsoId("_WpOThMsaEemxFbEZK-FMzw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public ExternalDebtorAgentInstruction1Code? Code { get; init; }

    /// <inheritdoc cref="IInstructionForDebtorAgent1.InstructionInformation"/>
    [IsoId("_WpOThcsaEemxFbEZK-FMzw")]
    [DisplayName("Instruction Information")]
    [IsoXmlTag("InstrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionInformation { get; init; }
}
