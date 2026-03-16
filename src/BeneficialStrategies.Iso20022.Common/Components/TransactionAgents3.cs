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
[IsoId("_tXX5MFkyEeGeoaLUQk__nA_-435108298")]
[DisplayName("Transaction Agents")]
public record TransactionAgents3
{
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_tXX5MVkyEeGeoaLUQk__nA_-200070093")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_tXX5MlkyEeGeoaLUQk__nA_-105958872")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_tXX5M1kyEeGeoaLUQk__nA_1251852084")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_tXhDIFkyEeGeoaLUQk__nA_788772033")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_tXhDIVkyEeGeoaLUQk__nA_1549537186")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Party that receives securities from the delivering agent at the place of settlement, such as central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    [IsoId("_tXhDIlkyEeGeoaLUQk__nA_-638538344")]
    [DisplayName("Receiving Agent")]
    [IsoXmlTag("RcvgAgt")]
    public BranchAndFinancialInstitutionIdentification5? ReceivingAgent { get; init; }

    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, such as a central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    [IsoId("_tXhDI1kyEeGeoaLUQk__nA_-135302165")]
    [DisplayName("Delivering Agent")]
    [IsoXmlTag("DlvrgAgt")]
    public BranchAndFinancialInstitutionIdentification5? DeliveringAgent { get; init; }

    /// <summary>
    /// Legal entity that has the right to issue securities.
    /// </summary>
    [IsoId("_tXq0IFkyEeGeoaLUQk__nA_579614623")]
    [DisplayName("Issuing Agent")]
    [IsoXmlTag("IssgAgt")]
    public BranchAndFinancialInstitutionIdentification5? IssuingAgent { get; init; }

    /// <summary>
    /// Place where settlement of the securities takes place.|Usage: This is typed by a financial institution identification as this is the standard way to identify a securities settlement agent/central system.
    /// </summary>
    [IsoId("_tXq0IVkyEeGeoaLUQk__nA_904732130")]
    [DisplayName("Settlement Place")]
    [IsoXmlTag("SttlmPlc")]
    public BranchAndFinancialInstitutionIdentification5? SettlementPlace { get; init; }

    /// <summary>
    /// Proprietary agent related to the underlying transaction.
    /// </summary>
    [IsoId("_tXq0IlkyEeGeoaLUQk__nA_-1025208769")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryAgent3? Proprietary { get; init; }
}
