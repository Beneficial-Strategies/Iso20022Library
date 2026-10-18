// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the original transaction, to which the status report message refers.
/// </summary>
[IsoId("_yhnwJ8loEem0vqvvoqYsqQ")]
public interface IOriginalPaymentInstruction37 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reversed payment information group.|Usage: The instructing party is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </summary>
    [IsoId("_ysDeWcloEem0vqvvoqYsqQ")]
    [DisplayName("Reversal Payment Information Identification")]
    [IsoXmlTag("RvslPmtInfId")]
    IsoMax35Text? ReversalPaymentInformationIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_ysDeW8loEem0vqvvoqYsqQ")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    IsoMax35Text OriginalPaymentInformationIdentification { get; }

    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_ysDeXcloEem0vqvvoqYsqQ")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    IsoMax15NumericText? OriginalNumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_ysDeX8loEem0vqvvoqYsqQ")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    IsoDecimalNumber? OriginalControlSum { get; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    [IsoId("_ysDeYcloEem0vqvvoqYsqQ")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    IsoBatchBookingIndicator? BatchBooking { get; }

    /// <summary>
    /// Indicates whether or not the reversal applies to the complete original payment information group or to individual transactions within that group.
    /// </summary>
    [IsoId("_ysDeY8loEem0vqvvoqYsqQ")]
    [DisplayName("Payment Information Reversal")]
    [IsoXmlTag("PmtInfRvsl")]
    IsoTrueFalseIndicator? PaymentInformationReversal { get; }

    /// <summary>
    /// Provides detailed information on the reversal reason.
    /// </summary>
    [IsoId("_ysDeZcloEem0vqvvoqYsqQ")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    IEnumerable<IPaymentReversalReason9> ReversalReasonInformation { get; }

    /// <summary>
    /// Provides information on the original transactions to which the reversal message refers.
    /// </summary>
    [IsoId("_ysDeZ8loEem0vqvvoqYsqQ")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    IEnumerable<IPaymentTransaction125> TransactionInformation { get; }
}
