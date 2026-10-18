// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference38"/>
[IsoId("_VbDkYUCeEe2yK-hZh539nQ")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference38
{
    /// <inheritdoc cref="IOriginalTransactionReference38.Amount"/>
    [IsoId("_VkhpcUCeEe2yK-hZh539nQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.RequestedExecutionDate"/>
    [IsoId("_Vkhpc0CeEe2yK-hZh539nQ")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.ExpiryDate"/>
    [IsoId("_VkhpdUCeEe2yK-hZh539nQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTime2Choice_? ExpiryDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.PaymentCondition"/>
    [IsoId("_Vkhpd0CeEe2yK-hZh539nQ")]
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    public PaymentCondition1? PaymentCondition { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.PaymentTypeInformation"/>
    [IsoId("_VkhpeUCeEe2yK-hZh539nQ")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.PaymentMethod"/>
    [IsoId("_Vkhpe0CeEe2yK-hZh539nQ")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.MandateRelatedInformation"/>
    [IsoId("_VkhpfUCeEe2yK-hZh539nQ")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.RemittanceInformation"/>
    [IsoId("_Vkhpf0CeEe2yK-hZh539nQ")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation21? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.EnclosedFile"/>
    [IsoId("_VkhpgUCeEe2yK-hZh539nQ")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document12> EnclosedFile { get; init; } = [];

    /// <inheritdoc cref="IOriginalTransactionReference38.UltimateDebtor"/>
    [IsoId("_Vkhpg0CeEe2yK-hZh539nQ")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.Debtor"/>
    [IsoId("_VkhphUCeEe2yK-hZh539nQ")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification135? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.DebtorAccount"/>
    [IsoId("_Vkhph0CeEe2yK-hZh539nQ")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.DebtorAgent"/>
    [IsoId("_VkhpiUCeEe2yK-hZh539nQ")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.DebtorAgentAccount"/>
    [IsoId("_Bb_N4UCeEe2yK-hZh539nQ")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.CreditorAgent"/>
    [IsoId("_Vkhpi0CeEe2yK-hZh539nQ")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.CreditorAgentAccount"/>
    [IsoId("_ebqCMUCeEe2yK-hZh539nQ")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.Creditor"/>
    [IsoId("_VkhpjUCeEe2yK-hZh539nQ")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.CreditorAccount"/>
    [IsoId("_Vkhpj0CeEe2yK-hZh539nQ")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference38.UltimateCreditor"/>
    [IsoId("_VkhpkUCeEe2yK-hZh539nQ")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }
}
