// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction21"/>
[IsoId("_tAWFe2k2Eeanu6HLe77Rkg")]
[DisplayName("Payment Instruction")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public partial record PaymentInstruction21
{
    /// <inheritdoc cref="IPaymentInstruction21.PaymentInformationIdentification"/>
    [IsoId("_tKKv4Wk2Eeanu6HLe77Rkg")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.PaymentMethod"/>
    [IsoId("_tKKv42k2Eeanu6HLe77Rkg")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod2Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.BatchBooking"/>
    [IsoId("_tKKv5Wk2Eeanu6HLe77Rkg")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.NumberOfTransactions"/>
    [IsoId("_tKKv52k2Eeanu6HLe77Rkg")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.ControlSum"/>
    [IsoId("_tKKv6Wk2Eeanu6HLe77Rkg")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.PaymentTypeInformation"/>
    [IsoId("_tKKv62k2Eeanu6HLe77Rkg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation24? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.RequestedCollectionDate"/>
    [IsoId("_tKKv7Wk2Eeanu6HLe77Rkg")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.Creditor"/>
    [IsoId("_tKKv72k2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.CreditorAccount"/>
    [IsoId("_tKKv8Wk2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount24 CreditorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.CreditorAgent"/>
    [IsoId("_tKKv82k2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.CreditorAgentAccount"/>
    [IsoId("_tKKv9Wk2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.UltimateCreditor"/>
    [IsoId("_tKKv92k2Eeanu6HLe77Rkg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.ChargeBearer"/>
    [IsoId("_tKKv-Wk2Eeanu6HLe77Rkg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.ChargesAccount"/>
    [IsoId("_tKKv-2k2Eeanu6HLe77Rkg")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount24? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.ChargesAccountAgent"/>
    [IsoId("_tKKv_Wk2Eeanu6HLe77Rkg")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification5? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.CreditorSchemeIdentification"/>
    [IsoId("_tKKv_2k2Eeanu6HLe77Rkg")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction21.DirectDebitTransactionInformation"/>
    [IsoId("_tKKwAWk2Eeanu6HLe77Rkg")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation22> DirectDebitTransactionInformation { get; init; } =
        [];
    // ID for the above is _tKKwAWk2Eeanu6HLe77Rkg
}
