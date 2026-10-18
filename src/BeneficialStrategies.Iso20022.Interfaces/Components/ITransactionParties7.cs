// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the parties specific to the individual transaction.
/// </summary>
[IsoId("_2Wprx3L-EeidQ_AAdEzxQA")]
public interface ITransactionParties7 : IIsoComponent
{
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_2hFZ83L-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IParty40Choice? UltimateDebtor { get; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_2hFZ9XL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IParty40Choice Debtor { get; }

    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    [IsoId("_2hFZ93L-EeidQ_AAdEzxQA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IParty40Choice? InitiatingParty { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_2hFZ-XL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification6? DebtorAgent { get; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_2hFZ-3L-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    IBranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_2hFZ_XL-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    IBranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_2hFZ_3L-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    IBranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_2hFaAXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_2hFaA3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_2hFaBXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_2hFaB3L-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification6? CreditorAgent { get; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_2hFaCXL-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IParty40Choice Creditor { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_2hFaC3L-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IParty40Choice? UltimateCreditor { get; }
}
