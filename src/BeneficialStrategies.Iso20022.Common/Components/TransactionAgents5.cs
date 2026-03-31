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
[IsoId("_G-oHcW4-EeiU9cctagi5ow")]
[DisplayName("Transaction Agents")]
public record TransactionAgents5
{
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_HH3jA24-EeiU9cctagi5ow")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_HH3jBW4-EeiU9cctagi5ow")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_HH3jB24-EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_HH3jCW4-EeiU9cctagi5ow")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_HH3jC24-EeiU9cctagi5ow")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_HH3jDW4-EeiU9cctagi5ow")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_HH3jD24-EeiU9cctagi5ow")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Party that receives securities from the delivering agent at the place of settlement, such as central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    [IsoId("_HH3jEW4-EeiU9cctagi5ow")]
    [DisplayName("Receiving Agent")]
    [IsoXmlTag("RcvgAgt")]
    public BranchAndFinancialInstitutionIdentification6? ReceivingAgent { get; init; }

    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, such as a central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    [IsoId("_HH3jE24-EeiU9cctagi5ow")]
    [DisplayName("Delivering Agent")]
    [IsoXmlTag("DlvrgAgt")]
    public BranchAndFinancialInstitutionIdentification6? DeliveringAgent { get; init; }

    /// <summary>
    /// Legal entity that has the right to issue securities.
    /// </summary>
    [IsoId("_HH3jFW4-EeiU9cctagi5ow")]
    [DisplayName("Issuing Agent")]
    [IsoXmlTag("IssgAgt")]
    public BranchAndFinancialInstitutionIdentification6? IssuingAgent { get; init; }

    /// <summary>
    /// Place where settlement of the securities takes place.|Usage: This is typed by a financial institution identification as this is the standard way to identify a securities settlement agent/central system.
    /// </summary>
    [IsoId("_HH3jF24-EeiU9cctagi5ow")]
    [DisplayName("Settlement Place")]
    [IsoXmlTag("SttlmPlc")]
    public BranchAndFinancialInstitutionIdentification6? SettlementPlace { get; init; }

    /// <summary>
    /// Proprietary agent related to the underlying transaction.
    /// </summary>
    [IsoId("_HH3jGW4-EeiU9cctagi5ow")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ValueList<ProprietaryAgent4> Proprietary { get; init; } = [];
}
