// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction16"/>
[IsoId("_kP0XYTq3EeWZFYSPlduMhw")]
[DisplayName("Original Payment Instruction")]
public partial record OriginalPaymentInstruction16
{
    /// <inheritdoc cref="IOriginalPaymentInstruction16.ReversalPaymentInformationIdentification"/>
    [IsoId("_kXQcCTq3EeWZFYSPlduMhw")]
    [DisplayName("Reversal Payment Information Identification")]
    [IsoXmlTag("RvslPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction16.OriginalPaymentInformationIdentification"/>
    [IsoId("_kXQcCzq3EeWZFYSPlduMhw")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction16.OriginalNumberOfTransactions"/>
    [IsoId("_kXQcDTq3EeWZFYSPlduMhw")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction16.OriginalControlSum"/>
    [IsoId("_kXQcDzq3EeWZFYSPlduMhw")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction16.BatchBooking"/>
    [IsoId("_kXQcETq3EeWZFYSPlduMhw")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction16.PaymentInformationReversal"/>
    [IsoId("_kXQcEzq3EeWZFYSPlduMhw")]
    [DisplayName("Payment Information Reversal")]
    [IsoXmlTag("PmtInfRvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PaymentInformationReversal { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction16.ReversalReasonInformation"/>
    [IsoId("_kXQcFTq3EeWZFYSPlduMhw")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason7> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction16.TransactionInformation"/>
    [IsoId("_kXQcFzq3EeWZFYSPlduMhw")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public ValueList<PaymentTransaction64> TransactionInformation { get; init; } = [];
}
