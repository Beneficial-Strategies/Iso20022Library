// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the agents specific to the individual transaction.
/// </summary>
[IsoId("_G_S7kYasEeeUws0ZryHQ2w")]
[DisplayName("Transaction Agents")]
public record TransactionAgents4
{
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Zo57AoasEeeUws0ZryHQ2w")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Zo57A4asEeeUws0ZryHQ2w")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_HG4xU4asEeeUws0ZryHQ2w")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_HG4xVYasEeeUws0ZryHQ2w")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_HG4xV4asEeeUws0ZryHQ2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_HG4xWYasEeeUws0ZryHQ2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_HG4xW4asEeeUws0ZryHQ2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Party that receives securities from the delivering agent at the place of settlement, such as central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    [IsoId("_HG4xXYasEeeUws0ZryHQ2w")]
    [DisplayName("Receiving Agent")]
    [IsoXmlTag("RcvgAgt")]
    public BranchAndFinancialInstitutionIdentification5? ReceivingAgent { get; init; }

    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, such as a central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    [IsoId("_HG4xX4asEeeUws0ZryHQ2w")]
    [DisplayName("Delivering Agent")]
    [IsoXmlTag("DlvrgAgt")]
    public BranchAndFinancialInstitutionIdentification5? DeliveringAgent { get; init; }

    /// <summary>
    /// Legal entity that has the right to issue securities.
    /// </summary>
    [IsoId("_HG4xYYasEeeUws0ZryHQ2w")]
    [DisplayName("Issuing Agent")]
    [IsoXmlTag("IssgAgt")]
    public BranchAndFinancialInstitutionIdentification5? IssuingAgent { get; init; }

    /// <summary>
    /// Place where settlement of the securities takes place.|Usage: This is typed by a financial institution identification as this is the standard way to identify a securities settlement agent/central system.
    /// </summary>
    [IsoId("_HG4xY4asEeeUws0ZryHQ2w")]
    [DisplayName("Settlement Place")]
    [IsoXmlTag("SttlmPlc")]
    public BranchAndFinancialInstitutionIdentification5? SettlementPlace { get; init; }

    /// <summary>
    /// Proprietary agent related to the underlying transaction.
    /// </summary>
    [IsoId("_HG4xZYasEeeUws0ZryHQ2w")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryAgent3? Proprietary { get; init; }
}
