// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference26"/>
[IsoId("_uzCKOZRvEeazAtAtDSg0Nw")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference26
{
    /// <inheritdoc cref="IOriginalTransactionReference26.Amount"/>
    [IsoId("_u-MRQ5RvEeazAtAtDSg0Nw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference26.RequestedExecutionDate"/>
    [IsoId("_u-MRRZRvEeazAtAtDSg0Nw")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTimeChoice_? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference26.PaymentTypeInformation"/>
    [IsoId("_u-MRR5RvEeazAtAtDSg0Nw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference26.PaymentMethod"/>
    [IsoId("_u-MRSZRvEeazAtAtDSg0Nw")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference26.RemittanceInformation"/>
    [IsoId("_u-MRS5RvEeazAtAtDSg0Nw")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation11? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference26.UltimateDebtor"/>
    [IsoId("_u-MRTZRvEeazAtAtDSg0Nw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference26.Debtor"/>
    [IsoId("_u-MRT5RvEeazAtAtDSg0Nw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification43? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference26.DebtorAccount"/>
    [IsoId("_u-MRUZRvEeazAtAtDSg0Nw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference26.DebtorAgent"/>
    [IsoId("_u-MRU5RvEeazAtAtDSg0Nw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference26.CreditorAgent"/>
    [IsoId("_u-MRVZRvEeazAtAtDSg0Nw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference26.Creditor"/>
    [IsoId("_u-MRV5RvEeazAtAtDSg0Nw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference26.CreditorAccount"/>
    [IsoId("_u-MRWZRvEeazAtAtDSg0Nw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference26.UltimateCreditor"/>
    [IsoId("_u-MRW5RvEeazAtAtDSg0Nw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }
}
