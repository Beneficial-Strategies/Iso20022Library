// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransactionInformation13"/>
[IsoId("_TNX4-Np-Ed-ak6NoX_4Aeg_-1374970422")]
[DisplayName("Credit Transfer Transaction Information")]
public partial record CreditTransferTransactionInformation13
{
    /// <inheritdoc cref="ICreditTransferTransactionInformation13.PaymentIdentification"/>
    [IsoId("_TNX4-dp-Ed-ak6NoX_4Aeg_-1366659810")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification3 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.PaymentTypeInformation"/>
    [IsoId("_TNX4-tp-Ed-ak6NoX_4Aeg_-1366659687")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation23? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.InterbankSettlementAmount"/>
    [IsoId("_TNX4-9p-Ed-ak6NoX_4Aeg_-1374970173")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.InterbankSettlementDate"/>
    [IsoId("_TNX4_Np-Ed-ak6NoX_4Aeg_-1374970121")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.SettlementPriority"/>
    [IsoId("_TNX4_dp-Ed-ak6NoX_4Aeg_-1149437074")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.SettlementTimeIndication"/>
    [IsoId("_TNX4_tp-Ed-ak6NoX_4Aeg_-1374968679")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.SettlementTimeRequest"/>
    [IsoId("_TNX4_9p-Ed-ak6NoX_4Aeg_-1374969627")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.PreviousInstructingAgent"/>
    [IsoId("_TNhp8Np-Ed-ak6NoX_4Aeg_-1374968217")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? PreviousInstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.PreviousInstructingAgentAccount"/>
    [IsoId("_TNhp8dp-Ed-ak6NoX_4Aeg_-1374969165")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount16? PreviousInstructingAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.InstructingAgent"/>
    [IsoId("_TNhp8tp-Ed-ak6NoX_4Aeg_-1366659925")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.InstructedAgent"/>
    [IsoId("_TNhp89p-Ed-ak6NoX_4Aeg_-1374968557")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.IntermediaryAgent1"/>
    [IsoId("_TNhp9Np-Ed-ak6NoX_4Aeg_-1374970059")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.IntermediaryAgent1Account"/>
    [IsoId("_TNhp9dp-Ed-ak6NoX_4Aeg_-1374969111")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount16? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.IntermediaryAgent2"/>
    [IsoId("_TNhp9tp-Ed-ak6NoX_4Aeg_-1366659748")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.IntermediaryAgent2Account"/>
    [IsoId("_TNhp99p-Ed-ak6NoX_4Aeg_-1374968771")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount16? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.IntermediaryAgent3"/>
    [IsoId("_TNhp-Np-Ed-ak6NoX_4Aeg_-1366659008")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification4? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.IntermediaryAgent3Account"/>
    [IsoId("_TNhp-dp-Ed-ak6NoX_4Aeg_-1374969534")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount16? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.UltimateDebtor"/>
    [IsoId("_TNqz4Np-Ed-ak6NoX_4Aeg_-1366659348")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification4? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.Debtor"/>
    [IsoId("_TNqz4dp-Ed-ak6NoX_4Aeg_-1374969658")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification4 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.DebtorAccount"/>
    [IsoId("_TNqz4tp-Ed-ak6NoX_4Aeg_-1374969474")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount16? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.DebtorAgent"/>
    [IsoId("_TNqz49p-Ed-ak6NoX_4Aeg_-1374968156")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.DebtorAgentAccount"/>
    [IsoId("_TNqz5Np-Ed-ak6NoX_4Aeg_-1374969080")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount16? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.CreditorAgent"/>
    [IsoId("_TNqz5dp-Ed-ak6NoX_4Aeg_-1374968618")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.CreditorAgentAccount"/>
    [IsoId("_TNqz5tp-Ed-ak6NoX_4Aeg_-1374969443")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount16? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.Creditor"/>
    [IsoId("_TNqz59p-Ed-ak6NoX_4Aeg_-1374969719")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification4 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.CreditorAccount"/>
    [IsoId("_TNqz6Np-Ed-ak6NoX_4Aeg_-1374968710")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount16? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.UltimateCreditor"/>
    [IsoId("_TNqz6dp-Ed-ak6NoX_4Aeg_-1366659871")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification4? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.InstructionForCreditorAgent"/>
    [IsoId("_TN0k4Np-Ed-ak6NoX_4Aeg_-1374968125")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent2> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.InstructionForNextAgent"/>
    [IsoId("_TN0k4dp-Ed-ak6NoX_4Aeg_-1374968495")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.RemittanceInformation"/>
    [IsoId("_TN0k4tp-Ed-ak6NoX_4Aeg_-1366659409")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation13.UnderlyingCustomerCreditTransfer"/>
    [IsoId("_TN0k49p-Ed-ak6NoX_4Aeg_-1021261888")]
    [DisplayName("Underlying Customer Credit Transfer")]
    [IsoXmlTag("UndrlygCstmrCdtTrf")]
    public CreditTransferTransactionInformation12? UnderlyingCustomerCreditTransfer { get; init; }
}
