// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference33"/>
[IsoId("_YOmYYQbPEeqF8ePC1fs2Gg")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference33
{
    /// <inheritdoc cref="IOriginalTransactionReference33.Amount"/>
    [IsoId("_Ya5H8wbPEeqF8ePC1fs2Gg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.RequestedExecutionDate"/>
    [IsoId("_Ya5H9QbPEeqF8ePC1fs2Gg")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.ExpiryDate"/>
    [IsoId("_Ya5H9wbPEeqF8ePC1fs2Gg")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTime2Choice_? ExpiryDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.PaymentCondition"/>
    [IsoId("_Ya5H-QbPEeqF8ePC1fs2Gg")]
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    public PaymentCondition1? PaymentCondition { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.PaymentTypeInformation"/>
    [IsoId("_Ya5H-wbPEeqF8ePC1fs2Gg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.PaymentMethod"/>
    [IsoId("_Ya5H_QbPEeqF8ePC1fs2Gg")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.MandateRelatedInformation"/>
    [IsoId("_NZmkwQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.RemittanceInformation"/>
    [IsoId("_Ya5H_wbPEeqF8ePC1fs2Gg")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.EnclosedFile"/>
    [IsoId("_Ya5IAQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document12> EnclosedFile { get; init; } = [];

    /// <inheritdoc cref="IOriginalTransactionReference33.UltimateDebtor"/>
    [IsoId("_Ya5IAwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.Debtor"/>
    [IsoId("_Ya5IBQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification135? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.DebtorAccount"/>
    [IsoId("_Ya5IBwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.DebtorAgent"/>
    [IsoId("_Ya5ICQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.CreditorAgent"/>
    [IsoId("_Ya5ICwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.Creditor"/>
    [IsoId("_Ya5IDQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.CreditorAccount"/>
    [IsoId("_Ya5IDwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference33.UltimateCreditor"/>
    [IsoId("_Ya5IEQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }
}
