// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction17"/>
[IsoId("_T4ORoRfLEeSEFrADmEUU2w")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction17
{
    /// <inheritdoc cref="ICreditTransferTransaction17.PaymentIdentification"/>
    [IsoId("_UVyXeRfLEeSEFrADmEUU2w")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.PaymentTypeInformation"/>
    [IsoId("_UVyXexfLEeSEFrADmEUU2w")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.InterbankSettlementAmount"/>
    [IsoId("_UVyXfRfLEeSEFrADmEUU2w")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.InterbankSettlementDate"/>
    [IsoId("_UVyXfxfLEeSEFrADmEUU2w")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.SettlementPriority"/>
    [IsoId("_UVyXgRfLEeSEFrADmEUU2w")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.SettlementTimeIndication"/>
    [IsoId("_UVyXgxfLEeSEFrADmEUU2w")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.SettlementTimeRequest"/>
    [IsoId("_UVyXhRfLEeSEFrADmEUU2w")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.PreviousInstructingAgent"/>
    [IsoId("_UVyXhxfLEeSEFrADmEUU2w")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.PreviousInstructingAgentAccount"/>
    [IsoId("_UVyXiRfLEeSEFrADmEUU2w")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount24? PreviousInstructingAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.InstructingAgent"/>
    [IsoId("_UVyXixfLEeSEFrADmEUU2w")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.InstructedAgent"/>
    [IsoId("_UVyXjRfLEeSEFrADmEUU2w")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.IntermediaryAgent1"/>
    [IsoId("_UVyXjxfLEeSEFrADmEUU2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.IntermediaryAgent1Account"/>
    [IsoId("_UVyXkRfLEeSEFrADmEUU2w")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.IntermediaryAgent2"/>
    [IsoId("_UVyXkxfLEeSEFrADmEUU2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.IntermediaryAgent2Account"/>
    [IsoId("_UVyXlRfLEeSEFrADmEUU2w")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.IntermediaryAgent3"/>
    [IsoId("_UVyXlxfLEeSEFrADmEUU2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.IntermediaryAgent3Account"/>
    [IsoId("_UVyXmRfLEeSEFrADmEUU2w")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.UltimateDebtor"/>
    [IsoId("_UVyXmxfLEeSEFrADmEUU2w")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification5? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.Debtor"/>
    [IsoId("_UVyXnRfLEeSEFrADmEUU2w")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification5 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.DebtorAccount"/>
    [IsoId("_UVyXnxfLEeSEFrADmEUU2w")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.DebtorAgent"/>
    [IsoId("_UVyXoRfLEeSEFrADmEUU2w")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.DebtorAgentAccount"/>
    [IsoId("_UVyXoxfLEeSEFrADmEUU2w")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.CreditorAgent"/>
    [IsoId("_UVyXpRfLEeSEFrADmEUU2w")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.CreditorAgentAccount"/>
    [IsoId("_UVyXpxfLEeSEFrADmEUU2w")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.Creditor"/>
    [IsoId("_UVyXqRfLEeSEFrADmEUU2w")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification5 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.CreditorAccount"/>
    [IsoId("_UVyXqxfLEeSEFrADmEUU2w")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.UltimateCreditor"/>
    [IsoId("_UVyXrRfLEeSEFrADmEUU2w")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification5? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.InstructionForCreditorAgent"/>
    [IsoId("_UVyXrxfLEeSEFrADmEUU2w")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent2> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction17.InstructionForNextAgent"/>
    [IsoId("_UVyXsRfLEeSEFrADmEUU2w")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction17.RemittanceInformation"/>
    [IsoId("_UVyXsxfLEeSEFrADmEUU2w")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.UnderlyingCustomerCreditTransfer"/>
    [IsoId("_UVyXtRfLEeSEFrADmEUU2w")]
    [DisplayName("Underlying Customer Credit Transfer")]
    [IsoXmlTag("UndrlygCstmrCdtTrf")]
    public CreditTransferTransaction18? UnderlyingCustomerCreditTransfer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction17.SupplementaryData"/>
    [IsoId("_UVyXtxfLEeSEFrADmEUU2w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
