// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the parties specific to the individual transaction.
/// </summary>
[IsoId("_bvqPCdcZEeqRFcf2R4bPBw")]
[DisplayName("Transaction Parties")]
public record TransactionParties10
{
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_bxCu7dcZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party40Choice_? UltimateDebtor { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_bxCu79cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required Party40Choice_ Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_bxCu8dcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    [IsoId("_bxCu89cZEeqRFcf2R4bPBw")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public Party40Choice_? InitiatingParty { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_bxCu9dcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_bxCu99cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the instructing agent.
    /// Usage: If more than one previous instructing agent is present, then PreviousInstructingAgent1 identifies the agent between the DebtorAgent and the PreviousInstructingAgent2.
    /// </summary>
    [IsoId("_bxCu-dcZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_bxCu-9cZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount40? PreviousInstructingAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the instructing agent.
    /// Usage: If more than two previous instructing agent are present, then PreviousInstructingAgent2 identifies the agent between the PreviousInstructingAgent1 and the PreviousInstructingAgent3.
    /// </summary>
    [IsoId("_bxCu_dcZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_bxCu_9cZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount40? PreviousInstructingAgent2Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the instructing agent.
    /// Usage: If PreviousInstructingAgent3 is present, then PreviousInstructingAgent3 identifies the agent between the PreviousInstructingAgent2 and the InstructingAgent.
    /// </summary>
    [IsoId("_bxCvAdcZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_bxCvA9cZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount40? PreviousInstructingAgent3Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_bxCvBdcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_bxCvB9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_bxCvCdcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_bxCvC9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_bxCvDdcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_bxCvD9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_bxCvEdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_bxCvE9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_bxCvFdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required Party40Choice_ Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_bxCvF9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_bxCvGdcZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party40Choice_? UltimateCreditor { get; init; }
}
