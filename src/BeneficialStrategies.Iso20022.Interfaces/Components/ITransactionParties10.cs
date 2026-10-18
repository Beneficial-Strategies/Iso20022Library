// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the parties specific to the individual transaction.
/// </summary>
[IsoId("_bvqPCdcZEeqRFcf2R4bPBw")]
public interface ITransactionParties10 : IIsoComponent
{
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_bxCu7dcZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IParty40Choice? UltimateDebtor { get; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_bxCu79cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IParty40Choice Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_bxCu8dcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount40? DebtorAccount { get; }

    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    [IsoId("_bxCu89cZEeqRFcf2R4bPBw")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IParty40Choice? InitiatingParty { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_bxCu9dcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification6? DebtorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_bxCu99cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    ICashAccount40? DebtorAgentAccount { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the instructing agent.
    /// Usage: If more than one previous instructing agent is present, then PreviousInstructingAgent1 identifies the agent between the DebtorAgent and the PreviousInstructingAgent2.
    /// </summary>
    [IsoId("_bxCu-dcZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    IBranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_bxCu-9cZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    ICashAccount40? PreviousInstructingAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the instructing agent.
    /// Usage: If more than two previous instructing agent are present, then PreviousInstructingAgent2 identifies the agent between the PreviousInstructingAgent1 and the PreviousInstructingAgent3.
    /// </summary>
    [IsoId("_bxCu_dcZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    IBranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_bxCu_9cZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    ICashAccount40? PreviousInstructingAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the instructing agent.
    /// Usage: If PreviousInstructingAgent3 is present, then PreviousInstructingAgent3 identifies the agent between the PreviousInstructingAgent2 and the InstructingAgent.
    /// </summary>
    [IsoId("_bxCvAdcZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    IBranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_bxCvA9cZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    ICashAccount40? PreviousInstructingAgent3Account { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_bxCvBdcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_bxCvB9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    ICashAccount40? IntermediaryAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_bxCvCdcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_bxCvC9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    ICashAccount40? IntermediaryAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_bxCvDdcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_bxCvD9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    ICashAccount40? IntermediaryAgent3Account { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_bxCvEdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification6? CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_bxCvE9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount40? CreditorAgentAccount { get; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_bxCvFdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IParty40Choice Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_bxCvF9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount40? CreditorAccount { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_bxCvGdcZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IParty40Choice? UltimateCreditor { get; }
}
