// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference27"/>
[IsoId("_Z3loUYtvEee-OJ-wXSj3YQ")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference27
{
    /// <inheritdoc cref="IOriginalTransactionReference27.InterbankSettlementAmount"/>
    [IsoId("_Z_LeEYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.Amount"/>
    [IsoId("_Z_LeE4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.InterbankSettlementDate"/>
    [IsoId("_Z_LeFYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.RequestedCollectionDate"/>
    [IsoId("_Z_LeF4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.RequestedExecutionDate"/>
    [IsoId("_Z_LeGYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.CreditorSchemeIdentification"/>
    [IsoId("_Z_LeG4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification125? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.SettlementInformation"/>
    [IsoId("_Z_LeHYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction4? SettlementInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.PaymentTypeInformation"/>
    [IsoId("_Z_LeH4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation25? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.PaymentMethod"/>
    [IsoId("_Z_LeIYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.MandateRelatedInformation"/>
    [IsoId("_Z_LeI4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation12? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.RemittanceInformation"/>
    [IsoId("_Z_LeJYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation15? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.UltimateDebtor"/>
    [IsoId("_Z_LeJ4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party35Choice_? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.Debtor"/>
    [IsoId("_Z_LeKYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party35Choice_? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.DebtorAccount"/>
    [IsoId("_Z_LeK4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.DebtorAgent"/>
    [IsoId("_Z_LeLYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.DebtorAgentAccount"/>
    [IsoId("_Z_LeL4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.CreditorAgent"/>
    [IsoId("_Z_LeMYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.CreditorAgentAccount"/>
    [IsoId("_Z_LeM4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.Creditor"/>
    [IsoId("_Z_LeNYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public Party35Choice_? Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.CreditorAccount"/>
    [IsoId("_Z_LeN4tvEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.UltimateCreditor"/>
    [IsoId("_Z_LeOYtvEee-OJ-wXSj3YQ")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party35Choice_? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference27.Purpose"/>
    [IsoId("_lJI1EotvEee-OJ-wXSj3YQ")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }
}
