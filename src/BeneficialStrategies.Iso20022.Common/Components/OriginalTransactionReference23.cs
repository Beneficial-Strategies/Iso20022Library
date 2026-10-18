// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference23"/>
[IsoId("_wohsAYIWEeWs6fzahhkJjg")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference23
{
    /// <inheritdoc cref="IOriginalTransactionReference23.Amount"/>
    [IsoId("_wwLMI4IWEeWs6fzahhkJjg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference23.RequestedExecutionDate"/>
    [IsoId("_wwLMJYIWEeWs6fzahhkJjg")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference23.PaymentTypeInformation"/>
    [IsoId("_wwLMJ4IWEeWs6fzahhkJjg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference23.PaymentMethod"/>
    [IsoId("_wwLMKYIWEeWs6fzahhkJjg")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference23.RemittanceInformation"/>
    [IsoId("_wwLMK4IWEeWs6fzahhkJjg")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation11? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference23.UltimateDebtor"/>
    [IsoId("_wwLMLYIWEeWs6fzahhkJjg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference23.Debtor"/>
    [IsoId("_wwLML4IWEeWs6fzahhkJjg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification43? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference23.DebtorAccount"/>
    [IsoId("_wwLMMYIWEeWs6fzahhkJjg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference23.DebtorAgent"/>
    [IsoId("_wwLMM4IWEeWs6fzahhkJjg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference23.CreditorAgent"/>
    [IsoId("_wwLMNYIWEeWs6fzahhkJjg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference23.Creditor"/>
    [IsoId("_wwLMN4IWEeWs6fzahhkJjg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference23.CreditorAccount"/>
    [IsoId("_wwLMOYIWEeWs6fzahhkJjg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference23.UltimateCreditor"/>
    [IsoId("_wwLMO4IWEeWs6fzahhkJjg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }
}
