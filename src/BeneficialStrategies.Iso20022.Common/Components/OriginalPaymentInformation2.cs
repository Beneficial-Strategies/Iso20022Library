// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInformation2"/>
[IsoId("_PlgaYtp-Ed-ak6NoX_4Aeg_-947875364")]
[DisplayName("Original Payment Information")]
public partial record OriginalPaymentInformation2
{
    /// <inheritdoc cref="IOriginalPaymentInformation2.ReversalPaymentInformationIdentification"/>
    [IsoId("_PlgaY9p-Ed-ak6NoX_4Aeg_-1704069715")]
    [DisplayName("Reversal Payment Information Identification")]
    [IsoXmlTag("RvslPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReversalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInformation2.OriginalPaymentInformationIdentification"/>
    [IsoId("_PlgaZNp-Ed-ak6NoX_4Aeg_-947875354")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInformation2.OriginalNumberOfTransactions"/>
    [IsoId("_PlgaZdp-Ed-ak6NoX_4Aeg_-947875303")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInformation2.OriginalControlSum"/>
    [IsoId("_PlgaZtp-Ed-ak6NoX_4Aeg_-947875273")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInformation2.BatchBooking"/>
    [IsoId("_PlgaZ9p-Ed-ak6NoX_4Aeg_-521419408")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInformation2.PaymentInformationReversal"/>
    [IsoId("_PlgaaNp-Ed-ak6NoX_4Aeg_-947875334")]
    [DisplayName("Payment Information Reversal")]
    [IsoXmlTag("PmtInfRvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PaymentInformationReversal { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInformation2.ReversalReasonInformation"/>
    [IsoId("_Plgaadp-Ed-ak6NoX_4Aeg_327509415")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    public ValueList<ReversalReasonInformation6> ReversalReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInformation2.TransactionInformation"/>
    [IsoId("_Plgaatp-Ed-ak6NoX_4Aeg_67825999")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public ValueList<PaymentTransactionInformation28> TransactionInformation { get; init; } = [];
}
