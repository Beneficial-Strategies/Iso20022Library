// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference37"/>
[IsoId("_chXYr9cZEeqRFcf2R4bPBw")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference37
{
    /// <inheritdoc cref="IOriginalTransactionReference37.Amount"/>
    [IsoId("_cmZCgdcZEeqRFcf2R4bPBw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.RequestedExecutionDate"/>
    [IsoId("_cmZpkdcZEeqRFcf2R4bPBw")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.ExpiryDate"/>
    [IsoId("_cmZpk9cZEeqRFcf2R4bPBw")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTime2Choice_? ExpiryDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.PaymentCondition"/>
    [IsoId("_cmZpldcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    public PaymentCondition1? PaymentCondition { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.PaymentTypeInformation"/>
    [IsoId("_cmZpl9cZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.PaymentMethod"/>
    [IsoId("_cmZpmdcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.MandateRelatedInformation"/>
    [IsoId("_cmZpm9cZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.RemittanceInformation"/>
    [IsoId("_cmZpndcZEeqRFcf2R4bPBw")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation21? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.EnclosedFile"/>
    [IsoId("_cmZpn9cZEeqRFcf2R4bPBw")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document12> EnclosedFile { get; init; } = [];

    /// <inheritdoc cref="IOriginalTransactionReference37.UltimateDebtor"/>
    [IsoId("_cmZpodcZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.Debtor"/>
    [IsoId("_cmZpo9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification135? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.DebtorAccount"/>
    [IsoId("_cmZppdcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.DebtorAgent"/>
    [IsoId("_cmZpp9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.CreditorAgent"/>
    [IsoId("_cmZpqdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.Creditor"/>
    [IsoId("_cmZpq9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.CreditorAccount"/>
    [IsoId("_cmZprdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference37.UltimateCreditor"/>
    [IsoId("_cmZpr9cZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }
}
