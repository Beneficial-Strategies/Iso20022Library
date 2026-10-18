// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction10"/>
[IsoId("_7FdFQSHREeKGep4bhmamiA")]
[DisplayName("Payment Instruction")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public partial record PaymentInstruction10
{
    /// <inheritdoc cref="IPaymentInstruction10.PaymentInformationIdentification"/>
    [IsoId("_7aKxISHREeKGep4bhmamiA")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.PaymentMethod"/>
    [IsoId("_7aKxJSHREeKGep4bhmamiA")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod2Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.BatchBooking"/>
    [IsoId("_7aKxKSHREeKGep4bhmamiA")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.NumberOfTransactions"/>
    [IsoId("_7aKxLSHREeKGep4bhmamiA")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.ControlSum"/>
    [IsoId("_7aKxMSHREeKGep4bhmamiA")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.PaymentTypeInformation"/>
    [IsoId("_7aKxNSHREeKGep4bhmamiA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation24? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.RequestedCollectionDate"/>
    [IsoId("_7aKxPSHREeKGep4bhmamiA")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.Creditor"/>
    [IsoId("_7aKxQSHREeKGep4bhmamiA")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.CreditorAccount"/>
    [IsoId("_7aKxRSHREeKGep4bhmamiA")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount24 CreditorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.CreditorAgent"/>
    [IsoId("_7aKxSSHREeKGep4bhmamiA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.CreditorAgentAccount"/>
    [IsoId("_7aKxTSHREeKGep4bhmamiA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.UltimateCreditor"/>
    [IsoId("_7aKxUSHREeKGep4bhmamiA")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.ChargeBearer"/>
    [IsoId("_7aKxWSHREeKGep4bhmamiA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.ChargesAccount"/>
    [IsoId("_7aKxYSHREeKGep4bhmamiA")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount24? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.ChargesAccountAgent"/>
    [IsoId("_7aKxZSHREeKGep4bhmamiA")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification5? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.CreditorSchemeIdentification"/>
    [IsoId("_7aKxaSHREeKGep4bhmamiA")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction10.DirectDebitTransactionInformation"/>
    [IsoId("_7aKxcSHREeKGep4bhmamiA")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation13> DirectDebitTransactionInformation { get; init; } =
        [];
    // ID for the above is _7aKxcSHREeKGep4bhmamiA
}
