// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IInstructionForCreditorAgent1"/>
[IsoId("_TN9u59p-Ed-ak6NoX_4Aeg_1202086664")]
[DisplayName("Instruction For Creditor Agent")]
public partial record InstructionForCreditorAgent1
{
    /// <inheritdoc cref="IInstructionForCreditorAgent1.Code"/>
    [IsoId("_TN9u6Np-Ed-ak6NoX_4Aeg_2092361005")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public Instruction3Code? Code { get; init; }

    /// <inheritdoc cref="IInstructionForCreditorAgent1.InstructionInformation"/>
    [IsoId("_TOHf0Np-Ed-ak6NoX_4Aeg_2092361313")]
    [DisplayName("Instruction Information")]
    [IsoXmlTag("InstrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionInformation { get; init; }
}
