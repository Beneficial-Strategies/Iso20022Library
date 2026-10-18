// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITransactionParties10"/>
[IsoId("_bvqPCdcZEeqRFcf2R4bPBw")]
[DisplayName("Transaction Parties")]
public partial record TransactionParties10
{
    /// <inheritdoc cref="ITransactionParties10.UltimateDebtor"/>
    [IsoId("_bxCu7dcZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party40Choice_? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ITransactionParties10.Debtor"/>
    [IsoId("_bxCu79cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required Party40Choice_ Debtor { get; init; }

    /// <inheritdoc cref="ITransactionParties10.DebtorAccount"/>
    [IsoId("_bxCu8dcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="ITransactionParties10.InitiatingParty"/>
    [IsoId("_bxCu89cZEeqRFcf2R4bPBw")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public Party40Choice_? InitiatingParty { get; init; }

    /// <inheritdoc cref="ITransactionParties10.DebtorAgent"/>
    [IsoId("_bxCu9dcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="ITransactionParties10.DebtorAgentAccount"/>
    [IsoId("_bxCu99cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ITransactionParties10.PreviousInstructingAgent1"/>
    [IsoId("_bxCu-dcZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ITransactionParties10.PreviousInstructingAgent1Account"/>
    [IsoId("_bxCu-9cZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount40? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ITransactionParties10.PreviousInstructingAgent2"/>
    [IsoId("_bxCu_dcZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ITransactionParties10.PreviousInstructingAgent2Account"/>
    [IsoId("_bxCu_9cZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount40? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ITransactionParties10.PreviousInstructingAgent3"/>
    [IsoId("_bxCvAdcZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ITransactionParties10.PreviousInstructingAgent3Account"/>
    [IsoId("_bxCvA9cZEeqRFcf2R4bPBw")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount40? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ITransactionParties10.IntermediaryAgent1"/>
    [IsoId("_bxCvBdcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ITransactionParties10.IntermediaryAgent1Account"/>
    [IsoId("_bxCvB9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ITransactionParties10.IntermediaryAgent2"/>
    [IsoId("_bxCvCdcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ITransactionParties10.IntermediaryAgent2Account"/>
    [IsoId("_bxCvC9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ITransactionParties10.IntermediaryAgent3"/>
    [IsoId("_bxCvDdcZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ITransactionParties10.IntermediaryAgent3Account"/>
    [IsoId("_bxCvD9cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ITransactionParties10.CreditorAgent"/>
    [IsoId("_bxCvEdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="ITransactionParties10.CreditorAgentAccount"/>
    [IsoId("_bxCvE9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ITransactionParties10.Creditor"/>
    [IsoId("_bxCvFdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required Party40Choice_ Creditor { get; init; }

    /// <inheritdoc cref="ITransactionParties10.CreditorAccount"/>
    [IsoId("_bxCvF9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="ITransactionParties10.UltimateCreditor"/>
    [IsoId("_bxCvGdcZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party40Choice_? UltimateCreditor { get; init; }
}
