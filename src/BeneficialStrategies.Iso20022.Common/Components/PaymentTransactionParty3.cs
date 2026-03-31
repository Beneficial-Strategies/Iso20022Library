// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the party fields used to search for a payment.
/// </summary>
[IsoId("__cH_c249EeiU9cctagi5ow")]
[DisplayName("Payment Transaction Party")]
public record PaymentTransactionParty3
{
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_m9DHGXheEeidzqjNEfehPg")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_m9DHGnheEeidzqjNEfehPg")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_m9DHF3heEeidzqjNEfehPg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party40Choice_? UltimateDebtor { get; init; }

    /// <summary>
    /// Party that owes assets to the creditor, such as a result of receipt of goods or services, gifts, or charity payments. The debtor may also be the debit account owner.
    /// </summary>
    [IsoId("__lXa4W49EeiU9cctagi5ow")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party40Choice_? Debtor { get; init; }

    /// <summary>
    /// Financial institution that receives the payment transaction from the account owner, or other authorised party, and processes the instruction.
    /// </summary>
    [IsoId("__lXa4249EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <summary>
    /// Specifies the agent through which the instructing agent will reimburse the instructed agent.
    /// </summary>
    [IsoId("__lXa5W49EeiU9cctagi5ow")]
    [DisplayName("Instructing Reimbursement Agent")]
    [IsoXmlTag("InstgRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingReimbursementAgent { get; init; }

    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.
    /// </summary>
    [IsoId("__lXa5249EeiU9cctagi5ow")]
    [DisplayName("Instructed Reimbursement Agent")]
    [IsoXmlTag("InstdRmbrsmntAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedReimbursementAgent { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_m9DHG3heEeidzqjNEfehPg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_m9DHHHheEeidzqjNEfehPg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_m9DHHXheEeidzqjNEfehPg")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of an account owner, or other nominated party, and credits the account.
    /// </summary>
    [IsoId("__lXa6249EeiU9cctagi5ow")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    [IsoId("__lXa7W49EeiU9cctagi5ow")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public Party40Choice_? Creditor { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_m9DHGHheEeidzqjNEfehPg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party40Choice_? UltimateCreditor { get; init; }
}
