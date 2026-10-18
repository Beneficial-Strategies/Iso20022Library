// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction41"/>
[IsoId("_b2IDMdcZEeqRFcf2R4bPBw")]
[DisplayName("Original Payment Instruction")]
public partial record OriginalPaymentInstruction41
{
    /// <inheritdoc cref="IOriginalPaymentInstruction41.ReversalPaymentInformationIdentification"/>
    [IsoId("_b3iYd9cZEeqRFcf2R4bPBw")]
    [DisplayName("Reversal Payment Information Identification")]
    [IsoXmlTag("RvslPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction41.OriginalPaymentInformationIdentification"/>
    [IsoId("_b3iYedcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction41.OriginalNumberOfTransactions"/>
    [IsoId("_b3iYe9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction41.OriginalControlSum"/>
    [IsoId("_b3iYfdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction41.BatchBooking"/>
    [IsoId("_b3iYf9cZEeqRFcf2R4bPBw")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction41.PaymentInformationReversal"/>
    [IsoId("_b3iYgdcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Information Reversal")]
    [IsoXmlTag("PmtInfRvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PaymentInformationReversal { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction41.ReversalReasonInformation"/>
    [IsoId("_b3iYg9cZEeqRFcf2R4bPBw")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<PaymentReversalReason9> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction41.TransactionInformation"/>
    [IsoId("_b3iYhdcZEeqRFcf2R4bPBw")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public ValueList<PaymentTransaction134> TransactionInformation { get; init; } = [];
}
