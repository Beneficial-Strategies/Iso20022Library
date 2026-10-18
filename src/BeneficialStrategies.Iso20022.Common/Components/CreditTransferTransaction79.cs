// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction79"/>
[IsoId("_Hvt08XePEfCdoODv2ypKfw")]
[DisplayName("Credit Transfer Transaction79")]
public partial record CreditTransferTransaction79
{
    /// <inheritdoc cref="ICreditTransferTransaction79.PaymentIdentification"/>
    [IsoId("_H4HjHXePEfCdoODv2ypKfw")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification13 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.PaymentTypeInformation"/>
    [IsoId("_H4HjH3ePEfCdoODv2ypKfw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.InterbankSettlementAmount"/>
    [IsoId("_H4HjIXePEfCdoODv2ypKfw")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.InterbankSettlementDate"/>
    [IsoId("_H4HjI3ePEfCdoODv2ypKfw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.SettlementPriority"/>
    [IsoId("_H4HjJXePEfCdoODv2ypKfw")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.SettlementTimeIndication"/>
    [IsoId("_H4HjJ3ePEfCdoODv2ypKfw")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.SettlementTimeRequest"/>
    [IsoId("_H4HjKXePEfCdoODv2ypKfw")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.ExpiryDateTime"/>
    [IsoId("_H4HjK3ePEfCdoODv2ypKfw")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public IsoISODateTime? ExpiryDateTime { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.PaymentSignature"/>
    [IsoId("_H4HjLXePEfCdoODv2ypKfw")]
    [DisplayName("Payment Signature")]
    [IsoXmlTag("PmtSgntr")]
    public CryptographicKey1Choice_? PaymentSignature { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.PreviousInstructingAgent1"/>
    [IsoId("_H4HjL3ePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent1")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.PreviousInstructingAgent1Account"/>
    [IsoId("_H4HjMXePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount40? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.PreviousInstructingAgent2"/>
    [IsoId("_H4HjM3ePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent2")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.PreviousInstructingAgent2Account"/>
    [IsoId("_H4HjNXePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount40? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.PreviousInstructingAgent3"/>
    [IsoId("_H4HjN3ePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent3")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.PreviousInstructingAgent3Account"/>
    [IsoId("_H4HjOXePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount40? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.InstructingAgent"/>
    [IsoId("_H4HjO3ePEfCdoODv2ypKfw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.InstructedAgent"/>
    [IsoId("_H4HjPXePEfCdoODv2ypKfw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.IntermediaryAgent1"/>
    [IsoId("_H4HjP3ePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.IntermediaryAgent1Account"/>
    [IsoId("_H4HjQXePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.IntermediaryAgent2"/>
    [IsoId("_H4HjQ3ePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.IntermediaryAgent2Account"/>
    [IsoId("_H4HjRXePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.IntermediaryAgent3"/>
    [IsoId("_H4HjR3ePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.IntermediaryAgent3Account"/>
    [IsoId("_H4HjSXePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.UltimateDebtor"/>
    [IsoId("_H4HjS3ePEfCdoODv2ypKfw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification8? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.Debtor"/>
    [IsoId("_H4HjTXePEfCdoODv2ypKfw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification8 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.DebtorAccount"/>
    [IsoId("_H4HjT3ePEfCdoODv2ypKfw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.DebtorAgent"/>
    [IsoId("_H4HjUXePEfCdoODv2ypKfw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.DebtorAgentAccount"/>
    [IsoId("_H4HjU3ePEfCdoODv2ypKfw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.CreditorAgent"/>
    [IsoId("_H4HjVXePEfCdoODv2ypKfw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.CreditorAgentAccount"/>
    [IsoId("_H4HjV3ePEfCdoODv2ypKfw")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.Creditor"/>
    [IsoId("_H4HjWXePEfCdoODv2ypKfw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification8 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.CreditorAccount"/>
    [IsoId("_H4HjW3ePEfCdoODv2ypKfw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.UltimateCreditor"/>
    [IsoId("_H4HjXXePEfCdoODv2ypKfw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification8? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.InstructionForCreditorAgent"/>
    [IsoId("_H4HjX3ePEfCdoODv2ypKfw")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction79.InstructionForNextAgent"/>
    [IsoId("_H4HjYXePEfCdoODv2ypKfw")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction79.Purpose"/>
    [IsoId("_H4HjY3ePEfCdoODv2ypKfw")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.RegulatoryReporting"/>
    [IsoId("_SMXaAXePEfCdoODv2ypKfw")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public ValueList<RegulatoryReporting10> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction79.RemittanceInformation"/>
    [IsoId("_H4HjZXePEfCdoODv2ypKfw")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.UnderlyingAllocation"/>
    [IsoId("_H4HjZ3ePEfCdoODv2ypKfw")]
    [DisplayName("Underlying Allocation")]
    [IsoXmlTag("UndrlygAllcn")]
    public ValueList<TransactionAllocation2> UnderlyingAllocation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction79.UnderlyingCustomerCreditTransfer"/>
    [IsoId("_H4HjaXePEfCdoODv2ypKfw")]
    [DisplayName("Underlying Customer Credit Transfer")]
    [IsoXmlTag("UndrlygCstmrCdtTrf")]
    public CreditTransferTransaction72? UnderlyingCustomerCreditTransfer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.UnderlyingFinancialInstitutionCreditTransfer"/>
    [IsoId("_H4Hja3ePEfCdoODv2ypKfw")]
    [DisplayName("Underlying Financial Institution Credit Transfer")]
    [IsoXmlTag("UndrlygFICdtTrf")]
    public CreditTransferTransaction80? UnderlyingFinancialInstitutionCreditTransfer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction79.SupplementaryData"/>
    [IsoId("_H4HjbXePEfCdoODv2ypKfw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
