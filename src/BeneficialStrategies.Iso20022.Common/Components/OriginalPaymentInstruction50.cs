// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Payment Instruction50.
/// </summary>
[IsoId("_9sSqsTEsEe6GxLzpkVnWYg")]
[DisplayName("Original Payment Instruction50")]
public record OriginalPaymentInstruction50
{
    /// <summary>
    /// Batch Booking.
    /// </summary>
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <summary>
    /// Original Control Sum.
    /// </summary>
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <summary>
    /// Original Number Of Transactions.
    /// </summary>
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <summary>
    /// Original Payment Information Identification.
    /// </summary>
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Payment Information Reversal.
    /// </summary>
    [DisplayName("Payment Information Reversal")]
    [IsoXmlTag("PmtInfRvsl")]
    public IsoTrueFalseIndicator? PaymentInformationReversal { get; init; }

    /// <summary>
    /// Reversal Payment Information Identification.
    /// </summary>
    [DisplayName("Reversal Payment Information Identification")]
    [IsoXmlTag("RvslPmtInfId")]
    public IsoMax35Text? ReversalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Reversal Reason Information.
    /// </summary>
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason10> ReversalReasonInformation { get; init; } = [];

    /// <summary>
    /// Transaction Information.
    /// </summary>
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public ValueList<PaymentTransaction156> TransactionInformation { get; init; } = [];
}
