// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IInstructionForNextAgent1"/>
[IsoId("_TOHf0dp-Ed-ak6NoX_4Aeg_1118639475")]
[DisplayName("Instruction For Next Agent")]
public partial record InstructionForNextAgent1
{
    /// <inheritdoc cref="IInstructionForNextAgent1.Code"/>
    [IsoId("_TOHf0tp-Ed-ak6NoX_4Aeg_-1086263072")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public Instruction4Code? Code { get; init; }

    /// <inheritdoc cref="IInstructionForNextAgent1.InstructionInformation"/>
    [IsoId("_TOHf09p-Ed-ak6NoX_4Aeg_-1086262686")]
    [DisplayName("Instruction Information")]
    [IsoXmlTag("InstrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionInformation { get; init; }
}
