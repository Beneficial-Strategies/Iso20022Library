// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransactionInformation12"/>
[IsoId("_P6OGJNp-Ed-ak6NoX_4Aeg_1618159966")]
[DisplayName("Credit Transfer Transaction Information")]
public partial record CreditTransferTransactionInformation12
{
    /// <inheritdoc cref="ICreditTransferTransactionInformation12.UltimateDebtor"/>
    [IsoId("_P6OGJdp-Ed-ak6NoX_4Aeg_1618161498")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification32? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.InitiatingParty"/>
    [IsoId("_P6OGJtp-Ed-ak6NoX_4Aeg_1618161440")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification32? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.Debtor"/>
    [IsoId("_P6OGJ9p-Ed-ak6NoX_4Aeg_1618161529")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification32 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.DebtorAccount"/>
    [IsoId("_P6OGKNp-Ed-ak6NoX_4Aeg_1618161067")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount16? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.DebtorAgent"/>
    [IsoId("_P6OGKdp-Ed-ak6NoX_4Aeg_1618163340")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification4 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.DebtorAgentAccount"/>
    [IsoId("_P6X3INp-Ed-ak6NoX_4Aeg_1618160891")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount16? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.PreviousInstructingAgent"/>
    [IsoId("_P6X3Idp-Ed-ak6NoX_4Aeg_1618162939")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? PreviousInstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.PreviousInstructingAgentAccount"/>
    [IsoId("_P6X3Itp-Ed-ak6NoX_4Aeg_1618161006")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount16? PreviousInstructingAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.IntermediaryAgent1"/>
    [IsoId("_P6X3I9p-Ed-ak6NoX_4Aeg_1618162076")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.IntermediaryAgent1Account"/>
    [IsoId("_P6X3JNp-Ed-ak6NoX_4Aeg_1618161098")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount16? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.IntermediaryAgent2"/>
    [IsoId("_P6X3Jdp-Ed-ak6NoX_4Aeg_1618163062")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.IntermediaryAgent2Account"/>
    [IsoId("_P6X3Jtp-Ed-ak6NoX_4Aeg_1618160975")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount16? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.IntermediaryAgent3"/>
    [IsoId("_P6X3J9p-Ed-ak6NoX_4Aeg_1618163031")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.IntermediaryAgent3Account"/>
    [IsoId("_P6X3KNp-Ed-ak6NoX_4Aeg_1618161159")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount16? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.CreditorAgent"/>
    [IsoId("_P6X3Kdp-Ed-ak6NoX_4Aeg_1618162046")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification4 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.CreditorAgentAccount"/>
    [IsoId("_P6hoINp-Ed-ak6NoX_4Aeg_1618160922")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount16? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.Creditor"/>
    [IsoId("_P6hoIdp-Ed-ak6NoX_4Aeg_1618161869")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification32 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.CreditorAccount"/>
    [IsoId("_P6hoItp-Ed-ak6NoX_4Aeg_1618163393")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount16? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.UltimateCreditor"/>
    [IsoId("_P6hoI9p-Ed-ak6NoX_4Aeg_1618161830")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification32? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.RemittanceInformation"/>
    [IsoId("_P6hoJNp-Ed-ak6NoX_4Aeg_1618162416")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation5? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation12.InstructedAmount"/>
    [IsoId("_P6hoJdp-Ed-ak6NoX_4Aeg_1618160119")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }
}
