// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the settlement of the instruction.
/// </summary>
[IsoId("_UG9TYXh1EeidzqjNEfehPg")]
[DisplayName("Settlement Instruction")]
public record SettlementInstruction7
{
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_UU8FAXh1EeidzqjNEfehPg")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod1Code SettlementMethod { get; init; }

    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_UU8FA3h1EeidzqjNEfehPg")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount38? SettlementAccount { get; init; }

    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_UU8FBXh1EeidzqjNEfehPg")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }

    /// <summary>
    /// Agent through which the instructing agent will reimburse the instructed agent.||Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_UU8FB3h1EeidzqjNEfehPg")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingReimbursementAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the instructing reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_UU8FCXh1EeidzqjNEfehPg")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    public CashAccount38? InstructingReimbursementAgentAccount { get; init; }

    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.|Usage: If InstructedReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.|Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_UU8FC3h1EeidzqjNEfehPg")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedReimbursementAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the instructed reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_UU8FDXh1EeidzqjNEfehPg")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    public CashAccount38? InstructedReimbursementAgentAccount { get; init; }

    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.|Usage: If ThirdReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.
    /// </summary>
    [IsoId("_UU8FD3h1EeidzqjNEfehPg")]
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification6? ThirdReimbursementAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the third reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_UU8FEXh1EeidzqjNEfehPg")]
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    public CashAccount38? ThirdReimbursementAgentAccount { get; init; }
}
