// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstruction18"/>
[IsoId("_0feASTq4EeWZFYSPlduMhw")]
[DisplayName("Payment Instruction")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-09-08.")]
public partial record PaymentInstruction18
{
    /// <inheritdoc cref="IPaymentInstruction18.PaymentInformationIdentification"/>
    [IsoId("_0mt30Tq4EeWZFYSPlduMhw")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.PaymentMethod"/>
    [IsoId("_0mt30zq4EeWZFYSPlduMhw")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod2Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.BatchBooking"/>
    [IsoId("_0mt31Tq4EeWZFYSPlduMhw")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.NumberOfTransactions"/>
    [IsoId("_0mt31zq4EeWZFYSPlduMhw")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.ControlSum"/>
    [IsoId("_0mt32Tq4EeWZFYSPlduMhw")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.PaymentTypeInformation"/>
    [IsoId("_0mt32zq4EeWZFYSPlduMhw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation24? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.RequestedCollectionDate"/>
    [IsoId("_0mt33Tq4EeWZFYSPlduMhw")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.Creditor"/>
    [IsoId("_0mt33zq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.CreditorAccount"/>
    [IsoId("_0mt34Tq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount24 CreditorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.CreditorAgent"/>
    [IsoId("_0mt34zq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.CreditorAgentAccount"/>
    [IsoId("_0mt35Tq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.UltimateCreditor"/>
    [IsoId("_0mt35zq4EeWZFYSPlduMhw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.ChargeBearer"/>
    [IsoId("_0mt36Tq4EeWZFYSPlduMhw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.ChargesAccount"/>
    [IsoId("_0mt36zq4EeWZFYSPlduMhw")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount24? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.ChargesAccountAgent"/>
    [IsoId("_0mt37Tq4EeWZFYSPlduMhw")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification5? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.CreditorSchemeIdentification"/>
    [IsoId("_0mt37zq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstruction18.DirectDebitTransactionInformation"/>
    [IsoId("_0mt38Tq4EeWZFYSPlduMhw")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation19> DirectDebitTransactionInformation { get; init; } =
        [];
    // ID for the above is _0mt38Tq4EeWZFYSPlduMhw
}
