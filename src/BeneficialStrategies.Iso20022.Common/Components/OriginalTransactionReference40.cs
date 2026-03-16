// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Transaction Reference40.
/// </summary>
[IsoId("_8rFsfzEsEe6GxLzpkVnWYg")]
[DisplayName("Original Transaction Reference40")]
public record OriginalTransactionReference40
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification272 Creditor { get; init; }

    /// <summary>
    /// Creditor Account.
    /// </summary>
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Creditor Agent.
    /// </summary>
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 CreditorAgent { get; init; }

    /// <summary>
    /// Creditor Agent Account.
    /// </summary>
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Debtor.
    /// </summary>
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification272? Debtor { get; init; }

    /// <summary>
    /// Debtor Account.
    /// </summary>
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <summary>
    /// Debtor Agent.
    /// </summary>
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <summary>
    /// Debtor Agent Account.
    /// </summary>
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Enclosed File.
    /// </summary>
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document15> EnclosedFile { get; init; } = [];

    /// <summary>
    /// Expiry Date.
    /// </summary>
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTime2Choice_? ExpiryDate { get; init; }

    /// <summary>
    /// Mandate Related Information.
    /// </summary>
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <summary>
    /// Payment Condition.
    /// </summary>
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    public PaymentCondition2? PaymentCondition { get; init; }

    /// <summary>
    /// Payment Method.
    /// </summary>
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <summary>
    /// Payment Type Information.
    /// </summary>
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Remittance Information.
    /// </summary>
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation22? RemittanceInformation { get; init; }

    /// <summary>
    /// Requested Execution Date.
    /// </summary>
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Ultimate Creditor.
    /// </summary>
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }

    /// <summary>
    /// Ultimate Debtor.
    /// </summary>
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }
}
