// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information related to the processing of the payment instruction that may need to be acted upon by the creditor&apos;s agent. The instruction may relate to a level of service, or may be an instruction that has to be executed by the creditor&apos;s agent, or may be information required by the creditor&apos;s agent.
/// </summary>
[IsoId("_TOHf1Np-Ed-ak6NoX_4Aeg_1659539851")]
public interface IInstructionForCreditorAgent2 : IIsoComponent
{
    /// <summary>
    /// Coded information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor&apos;s agent.
    /// </summary>
    [IsoId("_TOHf1dp-Ed-ak6NoX_4Aeg_1659540378")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    Instruction5Code? Code { get; }

    /// <summary>
    /// Further information complementing the coded instruction or instruction to the creditor&apos;s agent that is bilaterally agreed or specific to a user community.
    /// </summary>
    [IsoId("_TOHf1tp-Ed-ak6NoX_4Aeg_1659540421")]
    [DisplayName("Instruction Information")]
    [IsoXmlTag("InstrInf")]
    IsoMax140Text? InstructionInformation { get; }
}
