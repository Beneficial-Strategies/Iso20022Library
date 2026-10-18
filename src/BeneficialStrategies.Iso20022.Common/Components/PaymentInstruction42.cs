// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction42"/>
[IsoId("_Uzy54QzGEe2Wmf2RrXviyA")]
[DisplayName("Payment Instruction")]
public partial record PaymentInstruction42
{
    /// <inheritdoc cref="IPaymentInstruction42.PaymentInformationIdentification"/>
    [IsoId("_U88O5QzGEe2Wmf2RrXviyA")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction42.PaymentMethod"/>
    [IsoId("_U88O5wzGEe2Wmf2RrXviyA")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod7Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction42.RequestedAdviceType"/>
    [IsoId("_U88O6QzGEe2Wmf2RrXviyA")]
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    public AdviceType1? RequestedAdviceType { get; init; }

    /// <inheritdoc cref="IPaymentInstruction42.PaymentTypeInformation"/>
    [IsoId("_U88O6wzGEe2Wmf2RrXviyA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction42.RequestedExecutionDate"/>
    [IsoId("_U88O7QzGEe2Wmf2RrXviyA")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction42.ExpiryDate"/>
    [IsoId("_U88O7wzGEe2Wmf2RrXviyA")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTime2Choice_? ExpiryDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction42.PaymentCondition"/>
    [IsoId("_U88O8QzGEe2Wmf2RrXviyA")]
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    public PaymentCondition1? PaymentCondition { get; init; }

    /// <inheritdoc cref="IPaymentInstruction42.Debtor"/>
    [IsoId("_U88O8wzGEe2Wmf2RrXviyA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction42.DebtorAccount"/>
    [IsoId("_U88O9QzGEe2Wmf2RrXviyA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction42.DebtorAgent"/>
    [IsoId("_U88O9wzGEe2Wmf2RrXviyA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction42.DebtorAgentAccount"/>
    [IsoId("_QDdnUAzaEe2Wmf2RrXviyA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction42.UltimateDebtor"/>
    [IsoId("_U88O-QzGEe2Wmf2RrXviyA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction42.ChargeBearer"/>
    [IsoId("_U88O-wzGEe2Wmf2RrXviyA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction42.CreditTransferTransaction"/>
    [IsoId("_U88O_QzGEe2Wmf2RrXviyA")]
    [DisplayName("Credit Transfer Transaction")]
    [IsoXmlTag("CdtTrfTx")]
    public ValueList<CreditTransferTransaction57> CreditTransferTransaction { get; init; } = [];
    // ID for the above is _U88O_QzGEe2Wmf2RrXviyA
}
