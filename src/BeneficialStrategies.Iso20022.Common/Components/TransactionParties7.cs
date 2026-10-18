// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITransactionParties7"/>
[IsoId("_2Wprx3L-EeidQ_AAdEzxQA")]
[DisplayName("Transaction Parties")]
public partial record TransactionParties7
{
    /// <inheritdoc cref="ITransactionParties7.UltimateDebtor"/>
    [IsoId("_2hFZ83L-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party40Choice_? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ITransactionParties7.Debtor"/>
    [IsoId("_2hFZ9XL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required Party40Choice_ Debtor { get; init; }

    /// <inheritdoc cref="ITransactionParties7.InitiatingParty"/>
    [IsoId("_2hFZ93L-EeidQ_AAdEzxQA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public Party40Choice_? InitiatingParty { get; init; }

    /// <inheritdoc cref="ITransactionParties7.DebtorAgent"/>
    [IsoId("_2hFZ-XL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="ITransactionParties7.PreviousInstructingAgent1"/>
    [IsoId("_2hFZ-3L-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ITransactionParties7.PreviousInstructingAgent2"/>
    [IsoId("_2hFZ_XL-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ITransactionParties7.PreviousInstructingAgent3"/>
    [IsoId("_2hFZ_3L-EeidQ_AAdEzxQA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ITransactionParties7.IntermediaryAgent1"/>
    [IsoId("_2hFaAXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ITransactionParties7.IntermediaryAgent2"/>
    [IsoId("_2hFaA3L-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ITransactionParties7.IntermediaryAgent3"/>
    [IsoId("_2hFaBXL-EeidQ_AAdEzxQA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ITransactionParties7.CreditorAgent"/>
    [IsoId("_2hFaB3L-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="ITransactionParties7.Creditor"/>
    [IsoId("_2hFaCXL-EeidQ_AAdEzxQA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required Party40Choice_ Creditor { get; init; }

    /// <inheritdoc cref="ITransactionParties7.UltimateCreditor"/>
    [IsoId("_2hFaC3L-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party40Choice_? UltimateCreditor { get; init; }
}
