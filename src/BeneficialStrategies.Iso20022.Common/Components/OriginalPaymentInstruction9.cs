// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction9"/>
[IsoId("_2sb70SNsEeKdIYatzYH-pQ")]
[DisplayName("Original Payment Instruction")]
public partial record OriginalPaymentInstruction9
{
    /// <inheritdoc cref="IOriginalPaymentInstruction9.OriginalPaymentInformationIdentification"/>
    [IsoId("_23ANJSNsEeKdIYatzYH-pQ")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction9.OriginalNumberOfTransactions"/>
    [IsoId("_23ANKSNsEeKdIYatzYH-pQ")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction9.OriginalControlSum"/>
    [IsoId("_23ANLSNsEeKdIYatzYH-pQ")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction9.PaymentInformationStatus"/>
    [IsoId("_23ANMSNsEeKdIYatzYH-pQ")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public TransactionGroupStatus3Code? PaymentInformationStatus { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction9.StatusReasonInformation"/>
    [IsoId("_23ANOSNsEeKdIYatzYH-pQ")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction9.NumberOfTransactionsPerStatus"/>
    [IsoId("_23ANPSNsEeKdIYatzYH-pQ")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus3> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <inheritdoc cref="IOriginalPaymentInstruction9.TransactionInformationAndStatus"/>
    [IsoId("_23ANQSNsEeKdIYatzYH-pQ")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction49> TransactionInformationAndStatus { get; init; } = [];
}
