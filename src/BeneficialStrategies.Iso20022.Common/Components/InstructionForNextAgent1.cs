// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information related to the processing of the payment instruction that may need to be acted upon by an other agent. The instruction may relate to a level of service, or may be an instruction that has to be executed by the creditor&apos;s agent, or may be information required by the other agent.
/// </summary>
[IsoId("_TOHf0dp-Ed-ak6NoX_4Aeg_1118639475")]
[DisplayName("Instruction For Next Agent")]
public record InstructionForNextAgent1
{
    /// <summary>
    /// Coded information related to the processing of the payment instruction, provided by the initiating party, and intended for the next agent in the payment chain.
    /// </summary>
    [IsoId("_TOHf0tp-Ed-ak6NoX_4Aeg_-1086263072")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public Instruction4Code? Code { get; init; }

    /// <summary>
    /// Further information complementing the coded instruction or instruction to the next agent that is bilaterally agreed or specific to a user community.
    /// </summary>
    [IsoId("_TOHf09p-Ed-ak6NoX_4Aeg_-1086262686")]
    [DisplayName("Instruction Information")]
    [IsoXmlTag("InstrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionInformation { get; init; }
}
