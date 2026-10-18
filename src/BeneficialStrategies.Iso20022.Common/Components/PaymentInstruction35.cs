// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction35"/>
[IsoId("_QA5kwcQAEemsic1bQcEtLA")]
[DisplayName("Payment Instruction")]
public partial record PaymentInstruction35
{
    /// <inheritdoc cref="IPaymentInstruction35.PaymentInformationIdentification"/>
    [IsoId("_QNOwp8QAEemsic1bQcEtLA")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction35.PaymentMethod"/>
    [IsoId("_QNOwqcQAEemsic1bQcEtLA")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod7Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction35.RequestedAdviceType"/>
    [IsoId("_8_wv4QbLEeqF8ePC1fs2Gg")]
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    public AdviceType1? RequestedAdviceType { get; init; }

    /// <inheritdoc cref="IPaymentInstruction35.PaymentTypeInformation"/>
    [IsoId("_QNOwq8QAEemsic1bQcEtLA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction35.RequestedExecutionDate"/>
    [IsoId("_QNOwrcQAEemsic1bQcEtLA")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public required DateAndDateTime2Choice_ RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction35.ExpiryDate"/>
    [IsoId("_QNOwr8QAEemsic1bQcEtLA")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTime2Choice_? ExpiryDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction35.PaymentCondition"/>
    [IsoId("_QNOwscQAEemsic1bQcEtLA")]
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    public PaymentCondition1? PaymentCondition { get; init; }

    /// <inheritdoc cref="IPaymentInstruction35.Debtor"/>
    [IsoId("_QNOws8QAEemsic1bQcEtLA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction35.DebtorAccount"/>
    [IsoId("_QNOwtcQAEemsic1bQcEtLA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction35.DebtorAgent"/>
    [IsoId("_QNOwt8QAEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction35.UltimateDebtor"/>
    [IsoId("_QNOwucQAEemsic1bQcEtLA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction35.ChargeBearer"/>
    [IsoId("_QNOwu8QAEemsic1bQcEtLA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction35.CreditTransferTransaction"/>
    [IsoId("_QNOwvcQAEemsic1bQcEtLA")]
    [DisplayName("Credit Transfer Transaction")]
    [IsoXmlTag("CdtTrfTx")]
    public ValueList<CreditTransferTransaction42> CreditTransferTransaction { get; init; } = [];
    // ID for the above is _QNOwvcQAEemsic1bQcEtLA
}
