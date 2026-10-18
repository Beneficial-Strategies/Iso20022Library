// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Payment Instruction50.
/// </summary>
[IsoId("_9sSqsTEsEe6GxLzpkVnWYg")]
public interface IOriginalPaymentInstruction50 : IIsoComponent
{
    /// <summary>
    /// Batch Booking.
    /// </summary>
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    IsoBatchBookingIndicator? BatchBooking { get; }

    /// <summary>
    /// Original Control Sum.
    /// </summary>
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    IsoDecimalNumber? OriginalControlSum { get; }

    /// <summary>
    /// Original Number Of Transactions.
    /// </summary>
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    IsoMax15NumericText? OriginalNumberOfTransactions { get; }

    /// <summary>
    /// Original Payment Information Identification.
    /// </summary>
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    IsoMax35Text OriginalPaymentInformationIdentification { get; }

    /// <summary>
    /// Payment Information Reversal.
    /// </summary>
    [DisplayName("Payment Information Reversal")]
    [IsoXmlTag("PmtInfRvsl")]
    IsoTrueFalseIndicator? PaymentInformationReversal { get; }

    /// <summary>
    /// Reversal Payment Information Identification.
    /// </summary>
    [DisplayName("Reversal Payment Information Identification")]
    [IsoXmlTag("RvslPmtInfId")]
    IsoMax35Text? ReversalPaymentInformationIdentification { get; }

    /// <summary>
    /// Reversal Reason Information.
    /// </summary>
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    IEnumerable<IPaymentReversalReason10> ReversalReasonInformation { get; }

    /// <summary>
    /// Transaction Information.
    /// </summary>
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    IEnumerable<IPaymentTransaction156> TransactionInformation { get; }
}
