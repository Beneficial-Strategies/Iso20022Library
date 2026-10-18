// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference32"/>
[IsoId("_QPGB68QUEemsic1bQcEtLA")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference32
{
    /// <inheritdoc cref="IOriginalTransactionReference32.InterbankSettlementAmount"/>
    [IsoId("_QaHl8cQUEemsic1bQcEtLA")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.Amount"/>
    [IsoId("_QaHl88QUEemsic1bQcEtLA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.InterbankSettlementDate"/>
    [IsoId("_QaHl9cQUEemsic1bQcEtLA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.RequestedCollectionDate"/>
    [IsoId("_QaHl98QUEemsic1bQcEtLA")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.RequestedExecutionDate"/>
    [IsoId("_QaHl-cQUEemsic1bQcEtLA")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.CreditorSchemeIdentification"/>
    [IsoId("_QaHl-8QUEemsic1bQcEtLA")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.SettlementInformation"/>
    [IsoId("_QaHl_cQUEemsic1bQcEtLA")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction7? SettlementInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.PaymentTypeInformation"/>
    [IsoId("_QaHl_8QUEemsic1bQcEtLA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation27? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.PaymentMethod"/>
    [IsoId("_QaHmAcQUEemsic1bQcEtLA")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.MandateRelatedInformation"/>
    [IsoId("_QaHmA8QUEemsic1bQcEtLA")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedData1Choice_? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.RemittanceInformation"/>
    [IsoId("_QaHmBcQUEemsic1bQcEtLA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.UltimateDebtor"/>
    [IsoId("_QaHmB8QUEemsic1bQcEtLA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party40Choice_? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.Debtor"/>
    [IsoId("_QaHmCcQUEemsic1bQcEtLA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party40Choice_? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.DebtorAccount"/>
    [IsoId("_QaHmC8QUEemsic1bQcEtLA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.DebtorAgent"/>
    [IsoId("_QaHmDcQUEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.DebtorAgentAccount"/>
    [IsoId("_QaHmD8QUEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.CreditorAgent"/>
    [IsoId("_QaHmEcQUEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.CreditorAgentAccount"/>
    [IsoId("_QaHmE8QUEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.Creditor"/>
    [IsoId("_QaHmFcQUEemsic1bQcEtLA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public Party40Choice_? Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.CreditorAccount"/>
    [IsoId("_QaHmF8QUEemsic1bQcEtLA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.UltimateCreditor"/>
    [IsoId("_QaHmGcQUEemsic1bQcEtLA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party40Choice_? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.Purpose"/>
    [IsoId("_QaHmG8QUEemsic1bQcEtLA")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference32.UnderlyingCustomerCreditTransfer"/>
    [IsoId("_UuuEIcQTEemsic1bQcEtLA")]
    [DisplayName("Underlying Customer Credit Transfer")]
    [IsoXmlTag("UndrlygCstmrCdtTrf")]
    public CreditTransferTransaction45? UnderlyingCustomerCreditTransfer { get; init; }
}
