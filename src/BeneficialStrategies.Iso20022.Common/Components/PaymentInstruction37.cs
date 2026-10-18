// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction37"/>
[IsoId("_iRC3UdolEembTrt_WixjyQ")]
[DisplayName("Payment Instruction")]
public partial record PaymentInstruction37
{
    /// <inheritdoc cref="IPaymentInstruction37.PaymentInformationIdentification"/>
    [IsoId("_ijsGkdolEembTrt_WixjyQ")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.PaymentMethod"/>
    [IsoId("_ijsGk9olEembTrt_WixjyQ")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod2Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.RequestedAdviceType"/>
    [IsoId("_s_YpUNolEembTrt_WixjyQ")]
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    public AdviceType1? RequestedAdviceType { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.BatchBooking"/>
    [IsoId("_ijsGldolEembTrt_WixjyQ")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.NumberOfTransactions"/>
    [IsoId("_ijsGl9olEembTrt_WixjyQ")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.ControlSum"/>
    [IsoId("_ijsGmdolEembTrt_WixjyQ")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.PaymentTypeInformation"/>
    [IsoId("_ijsGm9olEembTrt_WixjyQ")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.RequestedCollectionDate"/>
    [IsoId("_ijsGndolEembTrt_WixjyQ")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.Creditor"/>
    [IsoId("_ijuiwdolEembTrt_WixjyQ")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.CreditorAccount"/>
    [IsoId("_ijuiw9olEembTrt_WixjyQ")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount38 CreditorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.CreditorAgent"/>
    [IsoId("_ijuixdolEembTrt_WixjyQ")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.CreditorAgentAccount"/>
    [IsoId("_ijuix9olEembTrt_WixjyQ")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.UltimateCreditor"/>
    [IsoId("_ijuiydolEembTrt_WixjyQ")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.ChargeBearer"/>
    [IsoId("_ijuiy9olEembTrt_WixjyQ")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.ChargesAccount"/>
    [IsoId("_ijuizdolEembTrt_WixjyQ")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount38? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.ChargesAccountAgent"/>
    [IsoId("_ijuiz9olEembTrt_WixjyQ")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.CreditorSchemeIdentification"/>
    [IsoId("_ijui0dolEembTrt_WixjyQ")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction37.DirectDebitTransactionInformation"/>
    [IsoId("_ijui09olEembTrt_WixjyQ")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation23> DirectDebitTransactionInformation { get; init; } =
        [];
    // ID for the above is _ijui09olEembTrt_WixjyQ
}
