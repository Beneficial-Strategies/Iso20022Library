// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction50"/>
[IsoId("_9sSqsTEsEe6GxLzpkVnWYg")]
[DisplayName("Original Payment Instruction50")]
public partial record OriginalPaymentInstruction50
{
    /// <inheritdoc cref="IOriginalPaymentInstruction50.BatchBooking"/>
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction50.OriginalControlSum"/>
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction50.OriginalNumberOfTransactions"/>
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction50.OriginalPaymentInformationIdentification"/>
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction50.PaymentInformationReversal"/>
    [DisplayName("Payment Information Reversal")]
    [IsoXmlTag("PmtInfRvsl")]
    public IsoTrueFalseIndicator? PaymentInformationReversal { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction50.ReversalPaymentInformationIdentification"/>
    [DisplayName("Reversal Payment Information Identification")]
    [IsoXmlTag("RvslPmtInfId")]
    public IsoMax35Text? ReversalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction50.ReversalReasonInformation"/>
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason10> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction50.TransactionInformation"/>
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public ValueList<PaymentTransaction156> TransactionInformation { get; init; } = [];
}
