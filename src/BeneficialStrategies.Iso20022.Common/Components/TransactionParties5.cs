// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITransactionParties5"/>
[IsoId("_YL0nEYauEeeUws0ZryHQ2w")]
[DisplayName("Transaction Parties")]
public partial record TransactionParties5
{
    /// <inheritdoc cref="ITransactionParties5.UltimateDebtor"/>
    [IsoId("_YT2iAYauEeeUws0ZryHQ2w")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party35Choice_? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ITransactionParties5.Debtor"/>
    [IsoId("_YT2iBYauEeeUws0ZryHQ2w")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required Party35Choice_ Debtor { get; init; }

    /// <inheritdoc cref="ITransactionParties5.InitiatingParty"/>
    [IsoId("_YT2iA4auEeeUws0ZryHQ2w")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public Party35Choice_? InitiatingParty { get; init; }

    /// <inheritdoc cref="ITransactionParties5.DebtorAgent"/>
    [IsoId("_YT2iCYauEeeUws0ZryHQ2w")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="ITransactionParties5.PreviousInstructingAgent1"/>
    [IsoId("_YT2h7YauEeeUws0ZryHQ2w")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ITransactionParties5.PreviousInstructingAgent2"/>
    [IsoId("_ZqSwMoauEeeUws0ZryHQ2w")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ITransactionParties5.PreviousInstructingAgent3"/>
    [IsoId("_bEmLAoauEeeUws0ZryHQ2w")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ITransactionParties5.IntermediaryAgent1"/>
    [IsoId("_YT2h9YauEeeUws0ZryHQ2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ITransactionParties5.IntermediaryAgent2"/>
    [IsoId("_YT2h-YauEeeUws0ZryHQ2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ITransactionParties5.IntermediaryAgent3"/>
    [IsoId("_YT2h_YauEeeUws0ZryHQ2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ITransactionParties5.CreditorAgent"/>
    [IsoId("_YT2iDYauEeeUws0ZryHQ2w")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="ITransactionParties5.Creditor"/>
    [IsoId("_YT2iEYauEeeUws0ZryHQ2w")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required Party35Choice_ Creditor { get; init; }

    /// <inheritdoc cref="ITransactionParties5.UltimateCreditor"/>
    [IsoId("_YT2iFYauEeeUws0ZryHQ2w")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party35Choice_? UltimateCreditor { get; init; }
}
