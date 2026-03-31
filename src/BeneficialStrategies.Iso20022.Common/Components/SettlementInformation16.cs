// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the settlement of the instruction.
/// </summary>
[IsoId("_QHfGG9p-Ed-ak6NoX_4Aeg_-1606098687")]
[DisplayName("Settlement Information")]
public record SettlementInformation16
{
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_QHfGHNp-Ed-ak6NoX_4Aeg_646940987")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod1Code SettlementMethod { get; init; }

    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_QHfGHdp-Ed-ak6NoX_4Aeg_-1048548137")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount16? SettlementAccount { get; init; }

    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_QHfGHtp-Ed-ak6NoX_4Aeg_1642921334")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }

    /// <summary>
    /// Agent through which the instructing agent will reimburse the instructed agent.||Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_QHo3ENp-Ed-ak6NoX_4Aeg_1968038841")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingReimbursementAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the instructing reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_QHo3Edp-Ed-ak6NoX_4Aeg_1575763687")]
    [DisplayName("Instructing Reimbursement Agent Account")]
    [IsoXmlTag("InstgRmbrsmntAgtAcct")]
    public CashAccount16? InstructingReimbursementAgentAccount { get; init; }

    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.|Usage: If InstructedReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.|Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [IsoId("_QHo3Etp-Ed-ak6NoX_4Aeg_821013813")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedReimbursementAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the instructed reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_QHo3E9p-Ed-ak6NoX_4Aeg_1275101082")]
    [DisplayName("Instructed Reimbursement Agent Account")]
    [IsoXmlTag("InstdRmbrsmntAgtAcct")]
    public CashAccount16? InstructedReimbursementAgentAccount { get; init; }

    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.|Usage: If ThirdReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.
    /// </summary>
    [IsoId("_QHo3FNp-Ed-ak6NoX_4Aeg_1264002305")]
    [DisplayName("Third Reimbursement Agent")]
    [IsoXmlTag("ThrdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification5? ThirdReimbursementAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the third reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_QHo3Fdp-Ed-ak6NoX_4Aeg_-1603368917")]
    [DisplayName("Third Reimbursement Agent Account")]
    [IsoXmlTag("ThrdRmbrsmntAgtAcct")]
    public CashAccount16? ThirdReimbursementAgentAccount { get; init; }
}
