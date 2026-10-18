// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction14"/>
[IsoId("__k-HB1kJEeSeLKjZh_lWZw")]
[DisplayName("Original Payment Instruction")]
public partial record OriginalPaymentInstruction14
{
    /// <inheritdoc cref="IOriginalPaymentInstruction14.OriginalPaymentInformationIdentification"/>
    [IsoId("__-Qwy1kJEeSeLKjZh_lWZw")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction14.OriginalNumberOfTransactions"/>
    [IsoId("__-QwzVkJEeSeLKjZh_lWZw")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction14.OriginalControlSum"/>
    [IsoId("__-Qwz1kJEeSeLKjZh_lWZw")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction14.PaymentInformationStatus"/>
    [IsoId("__-Qw0VkJEeSeLKjZh_lWZw")]
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public TransactionGroupStatus3Code? PaymentInformationStatus { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction14.StatusReasonInformation"/>
    [IsoId("__-Qw01kJEeSeLKjZh_lWZw")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction14.NumberOfTransactionsPerStatus"/>
    [IsoId("__-Qw1VkJEeSeLKjZh_lWZw")]
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus3> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <inheritdoc cref="IOriginalPaymentInstruction14.TransactionInformationAndStatus"/>
    [IsoId("__-Qw11kJEeSeLKjZh_lWZw")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction59> TransactionInformationAndStatus { get; init; } = [];
}
