// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Payment Instruction51.
/// </summary>
[IsoId("_-JN3QTEsEe6GxLzpkVnWYg")]
[DisplayName("Original Payment Instruction51")]
public record OriginalPaymentInstruction51
{
    /// <summary>
    /// Number Of Transactions Per Status.
    /// </summary>
    [DisplayName("Number Of Transactions Per Status")]
    [IsoXmlTag("NbOfTxsPerSts")]
    public ValueList<NumberOfTransactionsPerStatus5> NumberOfTransactionsPerStatus { get; init; } =
        [];

    /// <summary>
    /// Original Control Sum.
    /// </summary>
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <summary>
    /// Original Number Of Transactions.
    /// </summary>
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <summary>
    /// Original Payment Information Identification.
    /// </summary>
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Payment Information Status.
    /// </summary>
    [DisplayName("Payment Information Status")]
    [IsoXmlTag("PmtInfSts")]
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; init; }

    /// <summary>
    /// Status Reason Information.
    /// </summary>
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation14> StatusReasonInformation { get; init; } = [];

    /// <summary>
    /// Transaction Information And Status.
    /// </summary>
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction160> TransactionInformationAndStatus { get; init; } = [];
}
