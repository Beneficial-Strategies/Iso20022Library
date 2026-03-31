// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_T0i1S2XlEeap-P22vGV91g")]
[DisplayName("Original Payment Instruction")]
public record OriginalPaymentInstruction21
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reversed payment information group.|Usage: The instructing party is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </summary>
    [IsoId("_T_s8SWXlEeap-P22vGV91g")]
    [DisplayName("Reversal Payment Information Identification")]
    [IsoXmlTag("RvslPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_T_s8S2XlEeap-P22vGV91g")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_T_s8TWXlEeap-P22vGV91g")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_T_s8T2XlEeap-P22vGV91g")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    [IsoId("_T_s8UWXlEeap-P22vGV91g")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <summary>
    /// Indicates whether or not the reversal applies to the complete original payment information group or to individual transactions within that group.
    /// </summary>
    [IsoId("_T_s8U2XlEeap-P22vGV91g")]
    [DisplayName("Payment Information Reversal")]
    [IsoXmlTag("PmtInfRvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PaymentInformationReversal { get; init; }

    /// <summary>
    /// Provides detailed information on the reversal reason.
    /// </summary>
    [IsoId("_T_s8VWXlEeap-P22vGV91g")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason7> ReversalReasonInformation { get; init; } = [];

    /// <summary>
    /// Provides information on the original transactions to which the reversal message refers.
    /// </summary>
    [IsoId("_T_s8V2XlEeap-P22vGV91g")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public ValueList<PaymentTransaction77> TransactionInformation { get; init; } = [];
}
