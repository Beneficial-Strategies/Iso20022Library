// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference46"/>
[IsoId("2c1c1fe9-2ee1-4fde-9241-77fb34759ccb")]
[DisplayName("Original Transaction Reference46")]
public partial record OriginalTransactionReference46
{
    /// <inheritdoc cref="IOriginalTransactionReference46.Amount"/>
    [IsoId("d5b37171-37e6-4bdb-b441-28e29044a902")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.RequestedExecutionDate"/>
    [IsoId("2da36558-72f6-4554-9958-2d612fc373ce")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.ExpiryDate"/>
    [IsoId("01497799-9d9d-44b3-8c74-9c2badb6277c")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTime2Choice_? ExpiryDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.PaymentCondition"/>
    [IsoId("2ed7aa04-b688-4780-ae8a-dfd3d10ed70c")]
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    public PaymentCondition2? PaymentCondition { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.PaymentTypeInformation"/>
    [IsoId("890e7ac4-9a24-4d11-ba8b-e7558a1b3015")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.PaymentMethod"/>
    [IsoId("8e8f48d1-19a6-47a2-bb2a-8e4ec784de22")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.MandateRelatedInformation"/>
    [IsoId("d5f53155-2e24-439b-80c2-0b6c53aaa93e")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.RemittanceInformation"/>
    [IsoId("148feddc-2fdf-4f51-8715-7367b8f586e6")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation26? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.EnclosedFile"/>
    [IsoId("3086d9d7-fe9e-4cb4-a03e-feef3ef793e8")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document15> EnclosedFile { get; init; } = [];

    /// <inheritdoc cref="IOriginalTransactionReference46.UltimateDebtor"/>
    [IsoId("38ce7664-f64e-4401-921e-2550bdc58094")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.Debtor"/>
    [IsoId("8b623067-e89f-441a-9700-b9f56f047395")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification272? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.DebtorAccount"/>
    [IsoId("8fe927fa-f861-4ee5-83c0-809f669fc428")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.DebtorAgent"/>
    [IsoId("2d13cc60-2767-469b-8e2a-2b0d22f05da8")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.DebtorAgentAccount"/>
    [IsoId("478d68e5-ef4b-45bc-b617-ad057d1703c2")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.CreditorAgent"/>
    [IsoId("43cf0591-5557-45c0-9b21-14f17f443886")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.CreditorAgentAccount"/>
    [IsoId("f07baf01-1a47-4a30-b080-d39c0235dfe6")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.Creditor"/>
    [IsoId("d1c1efdc-f6b7-4957-8b65-3b3566bad034")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification272 Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.CreditorAccount"/>
    [IsoId("71ee4fa1-9cdc-4d7b-babd-c03b07216af2")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference46.UltimateCreditor"/>
    [IsoId("af5294d9-b77b-4c2a-9bcb-6ace7339c221")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }
}
