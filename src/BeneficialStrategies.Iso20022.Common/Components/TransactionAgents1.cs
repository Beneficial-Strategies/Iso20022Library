// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing information specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_PyefZdp-Ed-ak6NoX_4Aeg_868982411")]
[DisplayName("Transaction Agents")]
public record TransactionAgents1
{
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_PyefZtp-Ed-ak6NoX_4Aeg_1518216745")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_PyefZ9p-Ed-ak6NoX_4Aeg_868982525")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the debtor agent and the intermediary agent 2.
    /// </summary>
    [IsoId("_PyefaNp-Ed-ak6NoX_4Aeg_2013944809")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the intermediary agent 1 and the intermediary agent 3.
    /// </summary>
    [IsoId("_PynpUNp-Ed-ak6NoX_4Aeg_2013944549")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the intermediary agent 2 and the creditor agent.
    /// </summary>
    [IsoId("_PynpUdp-Ed-ak6NoX_4Aeg_2013944869")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Party that receives securities from the delivering agent at the place of settlement, eg, central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    [IsoId("_PynpUtp-Ed-ak6NoX_4Aeg_868982892")]
    [DisplayName("Receiving Agent")]
    [IsoXmlTag("RcvgAgt")]
    public BranchAndFinancialInstitutionIdentification3? ReceivingAgent { get; init; }

    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, eg, central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    [IsoId("_PynpU9p-Ed-ak6NoX_4Aeg_868982928")]
    [DisplayName("Delivering Agent")]
    [IsoXmlTag("DlvrgAgt")]
    public BranchAndFinancialInstitutionIdentification3? DeliveringAgent { get; init; }

    /// <summary>
    /// Legal entity that has the right to issue securities.
    /// </summary>
    [IsoId("_PynpVNp-Ed-ak6NoX_4Aeg_820756342")]
    [DisplayName("Issuing Agent")]
    [IsoXmlTag("IssgAgt")]
    public BranchAndFinancialInstitutionIdentification3? IssuingAgent { get; init; }

    /// <summary>
    /// Place where settlement of the securities takes place.||Note: this is typed by a financial institution identification - as this is the standard way of identifying eg securities settlement agent/central system.
    /// </summary>
    [IsoId("_PynpVdp-Ed-ak6NoX_4Aeg_1126443703")]
    [DisplayName("Settlement Place")]
    [IsoXmlTag("SttlmPlc")]
    public BranchAndFinancialInstitutionIdentification3? SettlementPlace { get; init; }

    /// <summary>
    /// Proprietary agent related to the underlying transaction.
    /// </summary>
    [IsoId("_PynpVtp-Ed-ak6NoX_4Aeg_-1828368630")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryAgent1? Proprietary { get; init; }
}
