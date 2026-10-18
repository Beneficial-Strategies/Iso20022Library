// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction31"/>
[IsoId("_AgPKEYtlEee-OJ-wXSj3YQ")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction31
{
    /// <inheritdoc cref="ICreditTransferTransaction31.PaymentIdentification"/>
    [IsoId("_ApArqYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.PaymentTypeInformation"/>
    [IsoId("_ApArq4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.InterbankSettlementAmount"/>
    [IsoId("_ApArrYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.InterbankSettlementDate"/>
    [IsoId("_ApArr4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.SettlementPriority"/>
    [IsoId("_ApArsYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.SettlementTimeIndication"/>
    [IsoId("_ApArs4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.SettlementTimeRequest"/>
    [IsoId("_ApArtYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.PreviousInstructingAgent1"/>
    [IsoId("_9rLohotkEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.PreviousInstructingAgent1Account"/>
    [IsoId("_9rLoh4tkEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount24? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.PreviousInstructingAgent2"/>
    [IsoId("_9rLoiItkEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.PreviousInstructingAgent2Account"/>
    [IsoId("_9rLoiYtkEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount24? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.PreviousInstructingAgent3"/>
    [IsoId("_9rLoiotkEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.PreviousInstructingAgent3Account"/>
    [IsoId("_9rLoi4tkEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount24? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.InstructingAgent"/>
    [IsoId("_ApAru4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.InstructedAgent"/>
    [IsoId("_ApArvYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.IntermediaryAgent1"/>
    [IsoId("_ApArv4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.IntermediaryAgent1Account"/>
    [IsoId("_ApArwYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.IntermediaryAgent2"/>
    [IsoId("_ApArw4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.IntermediaryAgent2Account"/>
    [IsoId("_ApArxYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.IntermediaryAgent3"/>
    [IsoId("_ApArx4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.IntermediaryAgent3Account"/>
    [IsoId("_ApAryYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.UltimateDebtor"/>
    [IsoId("_ApAry4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification5? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.Debtor"/>
    [IsoId("_ApArzYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification5 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.DebtorAccount"/>
    [IsoId("_ApArz4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.DebtorAgent"/>
    [IsoId("_ApAr0YtlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.DebtorAgentAccount"/>
    [IsoId("_ApAr04tlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.CreditorAgent"/>
    [IsoId("_ApAr1YtlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.CreditorAgentAccount"/>
    [IsoId("_ApAr14tlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.Creditor"/>
    [IsoId("_ApAr2YtlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification5 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.CreditorAccount"/>
    [IsoId("_ApAr24tlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.UltimateCreditor"/>
    [IsoId("_ApAr3YtlEee-OJ-wXSj3YQ")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification5? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.InstructionForCreditorAgent"/>
    [IsoId("_ApAr34tlEee-OJ-wXSj3YQ")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent2> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction31.InstructionForNextAgent"/>
    [IsoId("_ApAr4YtlEee-OJ-wXSj3YQ")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction31.RemittanceInformation"/>
    [IsoId("_ApAr44tlEee-OJ-wXSj3YQ")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.UnderlyingCustomerCreditTransfer"/>
    [IsoId("_ApAr5YtlEee-OJ-wXSj3YQ")]
    [DisplayName("Underlying Customer Credit Transfer")]
    [IsoXmlTag("UndrlygCstmrCdtTrf")]
    public CreditTransferTransaction32? UnderlyingCustomerCreditTransfer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction31.SupplementaryData"/>
    [IsoId("_ApAr54tlEee-OJ-wXSj3YQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
