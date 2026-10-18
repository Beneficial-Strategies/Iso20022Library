// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the settlement of the instruction.
/// </summary>
[IsoId("_wFG0kTEyEe6g-ffJsqGiSA")]
public interface ISettlementInstruction15 : IIsoComponent
{
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    IClearingSystemIdentification3Choice? ClearingSystem { get; }

    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.
    /// Usage: If InstructedReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.
    /// Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructedReimbursementAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the instructed reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    ICashAccount40? InstructedReimbursementAgentAccount { get; }

    /// <summary>
    /// Agent through which the instructing agent will reimburse the instructed agent.
    /// Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructingReimbursementAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the instructing reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    ICashAccount40? InstructingReimbursementAgentAccount { get; }

    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    ICashAccount40? SettlementAccount { get; }

    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    SettlementMethod1Code SettlementMethod { get; }

    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.
    /// Usage: If ThirdReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.
    /// </summary>
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    IBranchAndFinancialInstitutionIdentification8? ThirdReimbursementAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the third reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    ICashAccount40? ThirdReimbursementAgentAccount { get; }
}
