// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITransactionParties8"/>
[IsoId("_yZv3scQVEemsic1bQcEtLA")]
[DisplayName("Transaction Parties")]
public partial record TransactionParties8
{
    /// <inheritdoc cref="ITransactionParties8.UltimateDebtor"/>
    [IsoId("_ylhC08QVEemsic1bQcEtLA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party40Choice_? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ITransactionParties8.Debtor"/>
    [IsoId("_ylhC1cQVEemsic1bQcEtLA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required Party40Choice_ Debtor { get; init; }

    /// <inheritdoc cref="ITransactionParties8.DebtorAccount"/>
    [IsoId("_rczTxsQVEemsic1bQcEtLA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <inheritdoc cref="ITransactionParties8.InitiatingParty"/>
    [IsoId("_ylhC18QVEemsic1bQcEtLA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public Party40Choice_? InitiatingParty { get; init; }

    /// <inheritdoc cref="ITransactionParties8.DebtorAgent"/>
    [IsoId("_ylhC2cQVEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="ITransactionParties8.DebtorAgentAccount"/>
    [IsoId("_rczTx8QVEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ITransactionParties8.PreviousInstructingAgent1"/>
    [IsoId("_ylhC28QVEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ITransactionParties8.PreviousInstructingAgent1Account"/>
    [IsoId("_rczTwMQVEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount38? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ITransactionParties8.PreviousInstructingAgent2"/>
    [IsoId("_ylhC3cQVEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ITransactionParties8.PreviousInstructingAgent2Account"/>
    [IsoId("_rczTwcQVEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount38? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ITransactionParties8.PreviousInstructingAgent3"/>
    [IsoId("_ylhC38QVEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ITransactionParties8.PreviousInstructingAgent3Account"/>
    [IsoId("_rczTwsQVEemsic1bQcEtLA")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount38? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ITransactionParties8.IntermediaryAgent1"/>
    [IsoId("_ylhC4cQVEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ITransactionParties8.IntermediaryAgent1Account"/>
    [IsoId("_rczTw8QVEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount38? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ITransactionParties8.IntermediaryAgent2"/>
    [IsoId("_ylhC48QVEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ITransactionParties8.IntermediaryAgent2Account"/>
    [IsoId("_rczTxMQVEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount38? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ITransactionParties8.IntermediaryAgent3"/>
    [IsoId("_ylhC5cQVEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ITransactionParties8.IntermediaryAgent3Account"/>
    [IsoId("_rczTxcQVEemsic1bQcEtLA")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount38? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ITransactionParties8.CreditorAgent"/>
    [IsoId("_ylhC58QVEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="ITransactionParties8.CreditorAgentAccount"/>
    [IsoId("_rczTyMQVEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ITransactionParties8.Creditor"/>
    [IsoId("_ylhC6cQVEemsic1bQcEtLA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required Party40Choice_ Creditor { get; init; }

    /// <inheritdoc cref="ITransactionParties8.CreditorAccount"/>
    [IsoId("_rczTycQVEemsic1bQcEtLA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="ITransactionParties8.UltimateCreditor"/>
    [IsoId("_ylhC68QVEemsic1bQcEtLA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party40Choice_? UltimateCreditor { get; init; }
}
