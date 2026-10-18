// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference19"/>
[IsoId("_rm2j8SNrEeKdIYatzYH-pQ")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference19
{
    /// <inheritdoc cref="IOriginalTransactionReference19.Amount"/>
    [IsoId("_ryTmDSNrEeKdIYatzYH-pQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType3Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference19.RequestedExecutionDate"/>
    [IsoId("_ryTmHSNrEeKdIYatzYH-pQ")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference19.PaymentTypeInformation"/>
    [IsoId("_ryTmKSNrEeKdIYatzYH-pQ")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference19.PaymentMethod"/>
    [IsoId("_ryTmMSNrEeKdIYatzYH-pQ")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference19.RemittanceInformation"/>
    [IsoId("_ryTmOSNrEeKdIYatzYH-pQ")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation6? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference19.UltimateDebtor"/>
    [IsoId("_ryTmPSNrEeKdIYatzYH-pQ")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference19.Debtor"/>
    [IsoId("_ryTmQSNrEeKdIYatzYH-pQ")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification43? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference19.DebtorAccount"/>
    [IsoId("_ryTmRSNrEeKdIYatzYH-pQ")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference19.DebtorAgent"/>
    [IsoId("_ryTmSSNrEeKdIYatzYH-pQ")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference19.CreditorAgent"/>
    [IsoId("_ryTmTSNrEeKdIYatzYH-pQ")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference19.Creditor"/>
    [IsoId("_ryTmUSNrEeKdIYatzYH-pQ")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference19.CreditorAccount"/>
    [IsoId("_ryTmVSNrEeKdIYatzYH-pQ")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference19.UltimateCreditor"/>
    [IsoId("_ryTmWSNrEeKdIYatzYH-pQ")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }
}
