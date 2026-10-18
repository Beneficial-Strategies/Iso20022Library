// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference31"/>
[IsoId("_wUETQcloEem0vqvvoqYsqQ")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference31
{
    /// <inheritdoc cref="IOriginalTransactionReference31.InterbankSettlementAmount"/>
    [IsoId("_wgb7UcloEem0vqvvoqYsqQ")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.Amount"/>
    [IsoId("_wgb7U8loEem0vqvvoqYsqQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.InterbankSettlementDate"/>
    [IsoId("_wgb7VcloEem0vqvvoqYsqQ")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.RequestedCollectionDate"/>
    [IsoId("_wgb7V8loEem0vqvvoqYsqQ")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.RequestedExecutionDate"/>
    [IsoId("_wgb7WcloEem0vqvvoqYsqQ")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.CreditorSchemeIdentification"/>
    [IsoId("_wgb7W8loEem0vqvvoqYsqQ")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.SettlementInformation"/>
    [IsoId("_wgb7XcloEem0vqvvoqYsqQ")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction7? SettlementInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.PaymentTypeInformation"/>
    [IsoId("_wgb7X8loEem0vqvvoqYsqQ")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation27? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.PaymentMethod"/>
    [IsoId("_wgb7YcloEem0vqvvoqYsqQ")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.MandateRelatedInformation"/>
    [IsoId("_wgb7Y8loEem0vqvvoqYsqQ")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedData1Choice_? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.RemittanceInformation"/>
    [IsoId("_wgb7ZcloEem0vqvvoqYsqQ")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.UltimateDebtor"/>
    [IsoId("_wgb7Z8loEem0vqvvoqYsqQ")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party40Choice_? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.Debtor"/>
    [IsoId("_wgb7acloEem0vqvvoqYsqQ")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party40Choice_? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.DebtorAccount"/>
    [IsoId("_wgb7a8loEem0vqvvoqYsqQ")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.DebtorAgent"/>
    [IsoId("_wgb7bcloEem0vqvvoqYsqQ")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.DebtorAgentAccount"/>
    [IsoId("_wgb7b8loEem0vqvvoqYsqQ")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.CreditorAgent"/>
    [IsoId("_wgb7ccloEem0vqvvoqYsqQ")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.CreditorAgentAccount"/>
    [IsoId("_wgb7c8loEem0vqvvoqYsqQ")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.Creditor"/>
    [IsoId("_wgb7dcloEem0vqvvoqYsqQ")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public Party40Choice_? Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.CreditorAccount"/>
    [IsoId("_wgb7d8loEem0vqvvoqYsqQ")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.UltimateCreditor"/>
    [IsoId("_wgb7ecloEem0vqvvoqYsqQ")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party40Choice_? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference31.Purpose"/>
    [IsoId("_wgb7e8loEem0vqvvoqYsqQ")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }
}
