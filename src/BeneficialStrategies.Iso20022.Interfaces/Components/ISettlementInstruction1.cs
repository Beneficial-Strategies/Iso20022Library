// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the settlement of the instruction.
/// </summary>
[IsoId("_thgFkFkyEeGeoaLUQk__nA_-1005103671")]
public interface ISettlementInstruction1 : IIsoComponent
{
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_thgFkVkyEeGeoaLUQk__nA_-2116015090")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    SettlementMethod1Code SettlementMethod { get; }

    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_thp2kFkyEeGeoaLUQk__nA_692955488")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    ICashAccount24? SettlementAccount { get; }

    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_thp2kVkyEeGeoaLUQk__nA_-1457591385")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    IClearingSystemIdentification3Choice? ClearingSystem { get; }

    /// <summary>
    /// Agent through which the instructing agent will reimburse the instructed agent.||Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_thp2klkyEeGeoaLUQk__nA_-696826232")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructingReimbursementAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the instructing reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_thp2k1kyEeGeoaLUQk__nA_-1883116034")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    ICashAccount24? InstructingReimbursementAgentAccount { get; }

    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.|Usage: If InstructedReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.|Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_thp2lFkyEeGeoaLUQk__nA_1577085429")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructedReimbursementAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the instructed reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_thzAgFkyEeGeoaLUQk__nA_-1303645245")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    ICashAccount24? InstructedReimbursementAgentAccount { get; }

    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.|Usage: If ThirdReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.
    /// </summary>
    [IsoId("_thzAgVkyEeGeoaLUQk__nA_-1341631288")]
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    IBranchAndFinancialInstitutionIdentification5? ThirdReimbursementAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the third reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_thzAglkyEeGeoaLUQk__nA_-2096381162")]
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    ICashAccount24? ThirdReimbursementAgentAccount { get; }
}
