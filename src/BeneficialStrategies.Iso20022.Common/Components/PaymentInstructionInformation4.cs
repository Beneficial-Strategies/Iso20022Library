// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstructionInformation4"/>
[IsoId("_PkUHqtp-Ed-ak6NoX_4Aeg_1196042811")]
[DisplayName("Payment Instruction Information")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-08-07.")]
public partial record PaymentInstructionInformation4
{
    /// <inheritdoc cref="IPaymentInstructionInformation4.PaymentInformationIdentification"/>
    [IsoId("_PkUHq9p-Ed-ak6NoX_4Aeg_1196043143")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.PaymentMethod"/>
    [IsoId("_Pkd4kNp-Ed-ak6NoX_4Aeg_1196042872")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod2Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.BatchBooking"/>
    [IsoId("_Pkd4kdp-Ed-ak6NoX_4Aeg_235313902")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.NumberOfTransactions"/>
    [IsoId("_Pkd4ktp-Ed-ak6NoX_4Aeg_1038777743")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.ControlSum"/>
    [IsoId("_Pkd4k9p-Ed-ak6NoX_4Aeg_1038777866")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.PaymentTypeInformation"/>
    [IsoId("_Pkd4lNp-Ed-ak6NoX_4Aeg_1196964893")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation20? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.RequestedCollectionDate"/>
    [IsoId("_Pkd4ldp-Ed-ak6NoX_4Aeg_1196042841")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.Creditor"/>
    [IsoId("_Pkd4ltp-Ed-ak6NoX_4Aeg_1196964830")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification32 Creditor { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.CreditorAccount"/>
    [IsoId("_Pkd4l9p-Ed-ak6NoX_4Aeg_1196964369")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount16 CreditorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.CreditorAgent"/>
    [IsoId("_Pkd4mNp-Ed-ak6NoX_4Aeg_1196963544")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification4 CreditorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.CreditorAgentAccount"/>
    [IsoId("_PknpkNp-Ed-ak6NoX_4Aeg_1196963914")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount16? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.UltimateCreditor"/>
    [IsoId("_Pknpkdp-Ed-ak6NoX_4Aeg_1196964431")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification32? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.ChargeBearer"/>
    [IsoId("_Pknpktp-Ed-ak6NoX_4Aeg_1196043204")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.ChargesAccount"/>
    [IsoId("_Pknpk9p-Ed-ak6NoX_4Aeg_1196964277")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount16? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.ChargesAccountAgent"/>
    [IsoId("_PknplNp-Ed-ak6NoX_4Aeg_1196963453")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification4? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.CreditorSchemeIdentification"/>
    [IsoId("_PkwzgNp-Ed-ak6NoX_4Aeg_-1576011981")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification32? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation4.DirectDebitTransactionInformation"/>
    [IsoId("_Pkwzgdp-Ed-ak6NoX_4Aeg_1196963822")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation9> DirectDebitTransactionInformation { get; init; } =
        [];
    // ID for the above is _Pkwzgdp-Ed-ak6NoX_4Aeg_1196963822
}
