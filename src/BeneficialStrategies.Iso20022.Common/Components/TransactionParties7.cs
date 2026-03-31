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
[IsoId("_2Wprx3L-EeidQ_AAdEzxQA")]
[DisplayName("Transaction Parties")]
public record TransactionParties7
{
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_2hFZ83L-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party40Choice_? UltimateDebtor { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_2hFZ9XL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required Party40Choice_ Debtor { get; init; }

    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    [IsoId("_2hFZ93L-EeidQ_AAdEzxQA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public Party40Choice_? InitiatingParty { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_2hFZ-XL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_2hFZ-3L-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_2hFZ_XL-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_2hFZ_3L-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_2hFaAXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_2hFaA3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_2hFaBXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_2hFaB3L-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_2hFaCXL-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required Party40Choice_ Creditor { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_2hFaC3L-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party40Choice_? UltimateCreditor { get; init; }
}
