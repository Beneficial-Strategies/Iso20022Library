// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction27"/>
[IsoId("_jV5c4bPfEeeppqgHuc69jg")]
[DisplayName("Original Payment Instruction")]
public partial record OriginalPaymentInstruction27
{
    /// <inheritdoc cref="IOriginalPaymentInstruction27.OriginalPaymentInformationIdentification"/>
    [IsoId("_je-ga7PfEeeppqgHuc69jg")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction27.OriginalNumberOfTransactions"/>
    [IsoId("_je-gbbPfEeeppqgHuc69jg")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction27.OriginalControlSum"/>
    [IsoId("_je-gb7PfEeeppqgHuc69jg")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction27.PaymentInformationStatus"/>
    [IsoId("_je-gcbPfEeeppqgHuc69jg")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction27.StatusReasonInformation"/>
    [IsoId("_je-gc7PfEeeppqgHuc69jg")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation11> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction27.NumberOfTransactionsPerStatus"/>
    [IsoId("_je-gdbPfEeeppqgHuc69jg")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <inheritdoc cref="IOriginalPaymentInstruction27.TransactionInformationAndStatus"/>
    [IsoId("_je-gd7PfEeeppqgHuc69jg")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction92> TransactionInformationAndStatus { get; init; } = [];
}
