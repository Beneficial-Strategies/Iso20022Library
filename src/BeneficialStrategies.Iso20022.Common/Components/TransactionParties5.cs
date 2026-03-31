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
[IsoId("_YL0nEYauEeeUws0ZryHQ2w")]
[DisplayName("Transaction Parties")]
public record TransactionParties5
{
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_YT2iAYauEeeUws0ZryHQ2w")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party35Choice_? UltimateDebtor { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_YT2iBYauEeeUws0ZryHQ2w")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required Party35Choice_ Debtor { get; init; }

    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    [IsoId("_YT2iA4auEeeUws0ZryHQ2w")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public Party35Choice_? InitiatingParty { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_YT2iCYauEeeUws0ZryHQ2w")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_YT2h7YauEeeUws0ZryHQ2w")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent1 { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_ZqSwMoauEeeUws0ZryHQ2w")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent2 { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_bEmLAoauEeeUws0ZryHQ2w")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent3 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_YT2h9YauEeeUws0ZryHQ2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_YT2h-YauEeeUws0ZryHQ2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_YT2h_YauEeeUws0ZryHQ2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_YT2iDYauEeeUws0ZryHQ2w")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_YT2iEYauEeeUws0ZryHQ2w")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required Party35Choice_ Creditor { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_YT2iFYauEeeUws0ZryHQ2w")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party35Choice_? UltimateCreditor { get; init; }
}
