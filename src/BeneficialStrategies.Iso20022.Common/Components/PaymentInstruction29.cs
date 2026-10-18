// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction29"/>
[IsoId("_KKol4W49EeiU9cctagi5ow")]
[DisplayName("Payment Instruction")]
public partial record PaymentInstruction29
{
    /// <inheritdoc cref="IPaymentInstruction29.PaymentInformationIdentification"/>
    [IsoId("_KVEUUW49EeiU9cctagi5ow")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.PaymentMethod"/>
    [IsoId("_KVEUU249EeiU9cctagi5ow")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod2Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.BatchBooking"/>
    [IsoId("_KVEUVW49EeiU9cctagi5ow")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.NumberOfTransactions"/>
    [IsoId("_KVEUV249EeiU9cctagi5ow")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.ControlSum"/>
    [IsoId("_KVEUWW49EeiU9cctagi5ow")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.PaymentTypeInformation"/>
    [IsoId("_KVEUW249EeiU9cctagi5ow")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.RequestedCollectionDate"/>
    [IsoId("_KVEUXW49EeiU9cctagi5ow")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.Creditor"/>
    [IsoId("_KVEUX249EeiU9cctagi5ow")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.CreditorAccount"/>
    [IsoId("_KVEUYW49EeiU9cctagi5ow")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount38 CreditorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.CreditorAgent"/>
    [IsoId("_KVEUY249EeiU9cctagi5ow")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.CreditorAgentAccount"/>
    [IsoId("_KVEUZW49EeiU9cctagi5ow")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.UltimateCreditor"/>
    [IsoId("_KVEUZ249EeiU9cctagi5ow")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.ChargeBearer"/>
    [IsoId("_KVEUaW49EeiU9cctagi5ow")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.ChargesAccount"/>
    [IsoId("_KVEUa249EeiU9cctagi5ow")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount38? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.ChargesAccountAgent"/>
    [IsoId("_KVEUbW49EeiU9cctagi5ow")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.CreditorSchemeIdentification"/>
    [IsoId("_KVEUb249EeiU9cctagi5ow")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction29.DirectDebitTransactionInformation"/>
    [IsoId("_KVEUcW49EeiU9cctagi5ow")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation23> DirectDebitTransactionInformation { get; init; } =
        [];
    // ID for the above is _KVEUcW49EeiU9cctagi5ow
}
