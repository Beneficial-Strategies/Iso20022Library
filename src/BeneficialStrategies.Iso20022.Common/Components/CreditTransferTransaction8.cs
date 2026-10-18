// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction8"/>
[IsoId("_d0zygSHNEeKXpaAk3g3urA")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction8
{
    /// <inheritdoc cref="ICreditTransferTransaction8.PaymentIdentification"/>
    [IsoId("_eJEygSHNEeKXpaAk3g3urA")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.PaymentTypeInformation"/>
    [IsoId("_eJEyhSHNEeKXpaAk3g3urA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.InterbankSettlementAmount"/>
    [IsoId("_eJEyjSHNEeKXpaAk3g3urA")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.InterbankSettlementDate"/>
    [IsoId("_eJEykSHNEeKXpaAk3g3urA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.SettlementPriority"/>
    [IsoId("_eJEymSHNEeKXpaAk3g3urA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.SettlementTimeIndication"/>
    [IsoId("_eJEynSHNEeKXpaAk3g3urA")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.SettlementTimeRequest"/>
    [IsoId("_eJEyoSHNEeKXpaAk3g3urA")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.PreviousInstructingAgent"/>
    [IsoId("_eJEypSHNEeKXpaAk3g3urA")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.PreviousInstructingAgentAccount"/>
    [IsoId("_eJEyqSHNEeKXpaAk3g3urA")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount24? PreviousInstructingAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.InstructingAgent"/>
    [IsoId("_eJEyrSHNEeKXpaAk3g3urA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.InstructedAgent"/>
    [IsoId("_eJEytSHNEeKXpaAk3g3urA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.IntermediaryAgent1"/>
    [IsoId("_eJEyvSHNEeKXpaAk3g3urA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.IntermediaryAgent1Account"/>
    [IsoId("_eJEywSHNEeKXpaAk3g3urA")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.IntermediaryAgent2"/>
    [IsoId("_eJEyxSHNEeKXpaAk3g3urA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.IntermediaryAgent2Account"/>
    [IsoId("_eJEyySHNEeKXpaAk3g3urA")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.IntermediaryAgent3"/>
    [IsoId("_eJEyzSHNEeKXpaAk3g3urA")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.IntermediaryAgent3Account"/>
    [IsoId("_eJEy0SHNEeKXpaAk3g3urA")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.UltimateDebtor"/>
    [IsoId("_eJEy1SHNEeKXpaAk3g3urA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification5? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.Debtor"/>
    [IsoId("_eJEy2SHNEeKXpaAk3g3urA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification5 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.DebtorAccount"/>
    [IsoId("_eJEy3SHNEeKXpaAk3g3urA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.DebtorAgent"/>
    [IsoId("_eJEy4SHNEeKXpaAk3g3urA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.DebtorAgentAccount"/>
    [IsoId("_eJEy5SHNEeKXpaAk3g3urA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.CreditorAgent"/>
    [IsoId("_eJEy6SHNEeKXpaAk3g3urA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.CreditorAgentAccount"/>
    [IsoId("_eJEy7SHNEeKXpaAk3g3urA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.Creditor"/>
    [IsoId("_eJEy8SHNEeKXpaAk3g3urA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification5 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.CreditorAccount"/>
    [IsoId("_eJEy9SHNEeKXpaAk3g3urA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.UltimateCreditor"/>
    [IsoId("_eJEy-SHNEeKXpaAk3g3urA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification5? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.InstructionForCreditorAgent"/>
    [IsoId("_eJEy_SHNEeKXpaAk3g3urA")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent2> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction8.InstructionForNextAgent"/>
    [IsoId("_eJEzASHNEeKXpaAk3g3urA")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction8.RemittanceInformation"/>
    [IsoId("_eJEzBSHNEeKXpaAk3g3urA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.UnderlyingCustomerCreditTransfer"/>
    [IsoId("_eJEzCSHNEeKXpaAk3g3urA")]
    [DisplayName("Underlying Customer Credit Transfer")]
    [IsoXmlTag("UndrlygCstmrCdtTrf")]
    public CreditTransferTransaction3? UnderlyingCustomerCreditTransfer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction8.SupplementaryData"/>
    [IsoId("_fON1cyHNEeKXpaAk3g3urA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
