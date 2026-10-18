// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction40"/>
[IsoId("_aw0A8dcZEeqRFcf2R4bPBw")]
[DisplayName("Original Payment Instruction")]
public partial record OriginalPaymentInstruction40
{
    /// <inheritdoc cref="IOriginalPaymentInstruction40.OriginalPaymentInformationIdentification"/>
    [IsoId("_ayW5GdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction40.OriginalNumberOfTransactions"/>
    [IsoId("_ayW5G9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction40.OriginalControlSum"/>
    [IsoId("_ayW5HdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction40.PaymentInformationStatus"/>
    [IsoId("_ayW5H9cZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction40.StatusReasonInformation"/>
    [IsoId("_ayXgIdcZEeqRFcf2R4bPBw")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation12> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction40.NumberOfTransactionsPerStatus"/>
    [IsoId("_ayXgI9cZEeqRFcf2R4bPBw")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <inheritdoc cref="IOriginalPaymentInstruction40.TransactionInformationAndStatus"/>
    [IsoId("_ayXgJdcZEeqRFcf2R4bPBw")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction129> TransactionInformationAndStatus { get; init; } = [];
}
