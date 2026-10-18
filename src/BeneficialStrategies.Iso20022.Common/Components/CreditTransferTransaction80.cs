// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction80"/>
[IsoId("_eyUN4XePEfCdoODv2ypKfw")]
[DisplayName("Credit Transfer Transaction80")]
public partial record CreditTransferTransaction80
{
    /// <inheritdoc cref="ICreditTransferTransaction80.PaymentIdentification"/>
    [IsoId("_e61Q0XePEfCdoODv2ypKfw")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification13 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.PaymentTypeInformation"/>
    [IsoId("_e61Q03ePEfCdoODv2ypKfw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.InterbankSettlementAmount"/>
    [IsoId("_e61Q1XePEfCdoODv2ypKfw")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.InterbankSettlementDate"/>
    [IsoId("_e61Q13ePEfCdoODv2ypKfw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.SettlementPriority"/>
    [IsoId("_e61Q2XePEfCdoODv2ypKfw")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.SettlementTimeIndication"/>
    [IsoId("_e61Q23ePEfCdoODv2ypKfw")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.SettlementTimeRequest"/>
    [IsoId("_e61Q3XePEfCdoODv2ypKfw")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.ExpiryDateTime"/>
    [IsoId("_e61Q33ePEfCdoODv2ypKfw")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public IsoISODateTime? ExpiryDateTime { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.PaymentSignature"/>
    [IsoId("_e613wHePEfCdoODv2ypKfw")]
    [DisplayName("Payment Signature")]
    [IsoXmlTag("PmtSgntr")]
    public CryptographicKey1Choice_? PaymentSignature { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.PreviousInstructingAgent1"/>
    [IsoId("_e613wnePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent1")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.PreviousInstructingAgent1Account"/>
    [IsoId("_e613xHePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount40? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.PreviousInstructingAgent2"/>
    [IsoId("_e613xnePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent2")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.PreviousInstructingAgent2Account"/>
    [IsoId("_e613yHePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount40? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.PreviousInstructingAgent3"/>
    [IsoId("_e613ynePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent3")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.PreviousInstructingAgent3Account"/>
    [IsoId("_e613zHePEfCdoODv2ypKfw")]
    [DisplayName("Previous Instructing Agent3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount40? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.InstructingAgent"/>
    [IsoId("_e613znePEfCdoODv2ypKfw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.InstructedAgent"/>
    [IsoId("_e6130HePEfCdoODv2ypKfw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.IntermediaryAgent1"/>
    [IsoId("_e6130nePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.IntermediaryAgent1Account"/>
    [IsoId("_e6131HePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.IntermediaryAgent2"/>
    [IsoId("_e6131nePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.IntermediaryAgent2Account"/>
    [IsoId("_e6132HePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.IntermediaryAgent3"/>
    [IsoId("_e6132nePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.IntermediaryAgent3Account"/>
    [IsoId("_e6133HePEfCdoODv2ypKfw")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.UltimateDebtor"/>
    [IsoId("_e6133nePEfCdoODv2ypKfw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification8? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.Debtor"/>
    [IsoId("_e6134HePEfCdoODv2ypKfw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification8 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.DebtorAccount"/>
    [IsoId("_e6134nePEfCdoODv2ypKfw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.DebtorAgent"/>
    [IsoId("_e6135HePEfCdoODv2ypKfw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.DebtorAgentAccount"/>
    [IsoId("_e6135nePEfCdoODv2ypKfw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.CreditorAgent"/>
    [IsoId("_e6136HePEfCdoODv2ypKfw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.CreditorAgentAccount"/>
    [IsoId("_e6136nePEfCdoODv2ypKfw")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.Creditor"/>
    [IsoId("_e6137HePEfCdoODv2ypKfw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification8 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.CreditorAccount"/>
    [IsoId("_e6137nePEfCdoODv2ypKfw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.UltimateCreditor"/>
    [IsoId("_e6138HePEfCdoODv2ypKfw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification8? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.InstructionForCreditorAgent"/>
    [IsoId("_e6138nePEfCdoODv2ypKfw")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction80.InstructionForNextAgent"/>
    [IsoId("_e6139HePEfCdoODv2ypKfw")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction80.Purpose"/>
    [IsoId("_e6139nePEfCdoODv2ypKfw")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.RegulatoryReporting"/>
    [IsoId("_UcuTEXePEfCdoODv2ypKfw")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public ValueList<RegulatoryReporting10> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction80.RemittanceInformation"/>
    [IsoId("_e613-HePEfCdoODv2ypKfw")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction80.UnderlyingAllocation"/>
    [IsoId("_e613-nePEfCdoODv2ypKfw")]
    [DisplayName("Underlying Allocation")]
    [IsoXmlTag("UndrlygAllcn")]
    public ValueList<TransactionAllocation2> UnderlyingAllocation { get; init; } = [];
}
