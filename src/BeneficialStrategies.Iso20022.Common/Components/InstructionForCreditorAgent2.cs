// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IInstructionForCreditorAgent2"/>
[IsoId("_TOHf1Np-Ed-ak6NoX_4Aeg_1659539851")]
[DisplayName("Instruction For Creditor Agent")]
public partial record InstructionForCreditorAgent2
{
    /// <inheritdoc cref="IInstructionForCreditorAgent2.Code"/>
    [IsoId("_TOHf1dp-Ed-ak6NoX_4Aeg_1659540378")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public Instruction5Code? Code { get; init; }

    /// <inheritdoc cref="IInstructionForCreditorAgent2.InstructionInformation"/>
    [IsoId("_TOHf1tp-Ed-ak6NoX_4Aeg_1659540421")]
    [DisplayName("Instruction Information")]
    [IsoXmlTag("InstrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionInformation { get; init; }
}
