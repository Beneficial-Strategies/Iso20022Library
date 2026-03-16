// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the agents specific to the individual transaction.
/// </summary>
[IsoId("_P57LNtp-Ed-ak6NoX_4Aeg_489795231")]
[DisplayName("Transaction Agents")]
public record TransactionAgents2
{
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_P57LN9p-Ed-ak6NoX_4Aeg_489795786")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? DebtorAgent { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_P57LONp-Ed-ak6NoX_4Aeg_489796187")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_P6E8MNp-Ed-ak6NoX_4Aeg_489796332")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_P6E8Mdp-Ed-ak6NoX_4Aeg_489796301")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_P6E8Mtp-Ed-ak6NoX_4Aeg_489795816")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Party that receives securities from the delivering agent at the place of settlement, such as central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    [IsoId("_P6E8M9p-Ed-ak6NoX_4Aeg_489795694")]
    [DisplayName("Receiving Agent")]
    [IsoXmlTag("RcvgAgt")]
    public BranchAndFinancialInstitutionIdentification4? ReceivingAgent { get; init; }

    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, such as a central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    [IsoId("_P6E8NNp-Ed-ak6NoX_4Aeg_489796125")]
    [DisplayName("Delivering Agent")]
    [IsoXmlTag("DlvrgAgt")]
    public BranchAndFinancialInstitutionIdentification4? DeliveringAgent { get; init; }

    /// <summary>
    /// Legal entity that has the right to issue securities.
    /// </summary>
    [IsoId("_P6E8Ndp-Ed-ak6NoX_4Aeg_489796209")]
    [DisplayName("Issuing Agent")]
    [IsoXmlTag("IssgAgt")]
    public BranchAndFinancialInstitutionIdentification4? IssuingAgent { get; init; }

    /// <summary>
    /// Place where settlement of the securities takes place.|Usage: This is typed by a financial institution identification as this is the standard way to identify a securities settlement agent/central system.
    /// </summary>
    [IsoId("_P6E8Ntp-Ed-ak6NoX_4Aeg_489795385")]
    [DisplayName("Settlement Place")]
    [IsoXmlTag("SttlmPlc")]
    public BranchAndFinancialInstitutionIdentification4? SettlementPlace { get; init; }

    /// <summary>
    /// Proprietary agent related to the underlying transaction.
    /// </summary>
    [IsoId("_P6E8N9p-Ed-ak6NoX_4Aeg_489795323")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryAgent2? Proprietary { get; init; }
}
