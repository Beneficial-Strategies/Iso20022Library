// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction39"/>
[IsoId("_X2XekQbPEeqF8ePC1fs2Gg")]
[DisplayName("Original Payment Instruction")]
public partial record OriginalPaymentInstruction39
{
    /// <inheritdoc cref="IOriginalPaymentInstruction39.OriginalPaymentInformationIdentification"/>
    [IsoId("_YCkHiwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction39.OriginalNumberOfTransactions"/>
    [IsoId("_YCkHjQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction39.OriginalControlSum"/>
    [IsoId("_YCkHjwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction39.PaymentInformationStatus"/>
    [IsoId("_YCkHkQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction39.StatusReasonInformation"/>
    [IsoId("_YCkHkwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation12> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction39.NumberOfTransactionsPerStatus"/>
    [IsoId("_YCkHlQbPEeqF8ePC1fs2Gg")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <inheritdoc cref="IOriginalPaymentInstruction39.TransactionInformationAndStatus"/>
    [IsoId("_YCkHlwbPEeqF8ePC1fs2Gg")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction128> TransactionInformationAndStatus { get; init; } = [];
}
