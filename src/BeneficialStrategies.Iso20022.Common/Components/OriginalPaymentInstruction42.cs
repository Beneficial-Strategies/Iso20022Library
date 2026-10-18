// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction42"/>
[IsoId("_cdiBcdcZEeqRFcf2R4bPBw")]
[DisplayName("Original Payment Instruction")]
public partial record OriginalPaymentInstruction42
{
    /// <inheritdoc cref="IOriginalPaymentInstruction42.OriginalPaymentInformationIdentification"/>
    [IsoId("_cfrWidcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction42.OriginalNumberOfTransactions"/>
    [IsoId("_cfrWi9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction42.OriginalControlSum"/>
    [IsoId("_cfrWjdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction42.PaymentInformationStatus"/>
    [IsoId("_cfrWj9cZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction42.StatusReasonInformation"/>
    [IsoId("_cfrWkdcZEeqRFcf2R4bPBw")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation12> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction42.NumberOfTransactionsPerStatus"/>
    [IsoId("_cfrWk9cZEeqRFcf2R4bPBw")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <inheritdoc cref="IOriginalPaymentInstruction42.TransactionInformationAndStatus"/>
    [IsoId("_cfrWldcZEeqRFcf2R4bPBw")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction136> TransactionInformationAndStatus { get; init; } = [];
}
