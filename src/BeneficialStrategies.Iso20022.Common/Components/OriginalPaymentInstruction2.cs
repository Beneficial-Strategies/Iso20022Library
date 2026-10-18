// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction2"/>
[IsoId("_sixMdFkyEeGeoaLUQk__nA_524273766")]
[DisplayName("Original Payment Instruction")]
public partial record OriginalPaymentInstruction2
{
    /// <inheritdoc cref="IOriginalPaymentInstruction2.ReversalPaymentInformationIdentification"/>
    [IsoId("_si6WYFkyEeGeoaLUQk__nA_350187013")]
    [DisplayName("Reversal Payment Information Identification")]
    [IsoXmlTag("RvslPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction2.OriginalPaymentInformationIdentification"/>
    [IsoId("_si6WYVkyEeGeoaLUQk__nA_1059309020")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction2.OriginalNumberOfTransactions"/>
    [IsoId("_sjEHYFkyEeGeoaLUQk__nA_971687718")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction2.OriginalControlSum"/>
    [IsoId("_sjEHYVkyEeGeoaLUQk__nA_1498683661")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction2.BatchBooking"/>
    [IsoId("_sjEHYlkyEeGeoaLUQk__nA_1138707613")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction2.PaymentInformationReversal"/>
    [IsoId("_sjEHY1kyEeGeoaLUQk__nA_-741598027")]
    [DisplayName("Payment Information Reversal")]
    [IsoXmlTag("PmtInfRvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PaymentInformationReversal { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction2.ReversalReasonInformation"/>
    [IsoId("_sjEHZFkyEeGeoaLUQk__nA_1592794882")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason7> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction2.TransactionInformation"/>
    [IsoId("_sjN4YFkyEeGeoaLUQk__nA_-99385315")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public ValueList<PaymentTransaction35> TransactionInformation { get; init; } = [];
}
