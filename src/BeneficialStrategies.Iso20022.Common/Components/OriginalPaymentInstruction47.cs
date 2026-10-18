// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalPaymentInstruction47"/>
[IsoId("_8muJwTEsEe6GxLzpkVnWYg")]
[DisplayName("Original Payment Instruction47")]
public partial record OriginalPaymentInstruction47
{
    /// <inheritdoc cref="IOriginalPaymentInstruction47.NumberOfTransactionsPerStatus"/>
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <inheritdoc cref="IOriginalPaymentInstruction47.OriginalControlSum"/>
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction47.OriginalNumberOfTransactions"/>
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction47.OriginalPaymentInformationIdentification"/>
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction47.PaymentInformationStatus"/>
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; init; }

    /// <inheritdoc cref="IOriginalPaymentInstruction47.StatusReasonInformation"/>
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation14> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IOriginalPaymentInstruction47.TransactionInformationAndStatus"/>
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction150> TransactionInformationAndStatus { get; init; } = [];
}
