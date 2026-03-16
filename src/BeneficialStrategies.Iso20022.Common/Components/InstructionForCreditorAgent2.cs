// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information related to the processing of the payment instruction that may need to be acted upon by the creditor&apos;s agent. The instruction may relate to a level of service, or may be an instruction that has to be executed by the creditor&apos;s agent, or may be information required by the creditor&apos;s agent.
/// </summary>
[IsoId("_TOHf1Np-Ed-ak6NoX_4Aeg_1659539851")]
[DisplayName("Instruction For Creditor Agent")]
public record InstructionForCreditorAgent2
{
    /// <summary>
    /// Coded information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor&apos;s agent.
    /// </summary>
    [IsoId("_TOHf1dp-Ed-ak6NoX_4Aeg_1659540378")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public Instruction5Code? Code { get; init; }

    /// <summary>
    /// Further information complementing the coded instruction or instruction to the creditor&apos;s agent that is bilaterally agreed or specific to a user community.
    /// </summary>
    [IsoId("_TOHf1tp-Ed-ak6NoX_4Aeg_1659540421")]
    [DisplayName("Instruction Information")]
    [IsoXmlTag("InstrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionInformation { get; init; }
}
