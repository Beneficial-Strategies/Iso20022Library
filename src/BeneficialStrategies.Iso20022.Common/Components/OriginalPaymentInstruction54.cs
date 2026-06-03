// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the reference and status of the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("aeb8d0a2-b685-444d-8a96-7df0af319a94")]
[DisplayName("Original Payment Instruction54")]
public record OriginalPaymentInstruction54
{
    /// <summary>
    /// Unique identification, as assigned by the original assigner, to unambiguously identify the original payment information cancellation request.
    /// </summary>
    [IsoId("fa857e2d-2534-4dd9-aedb-e7b89532d547")]
    [DisplayName("Original Payment Information Cancellation Identification")]
    [IsoXmlTag("OrgnlPmtInfCxlId")]
    public IsoMax35Text? OriginalPaymentInformationCancellationIdentification { get; init; }

    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    [IsoId("23d9d878-d18c-4b52-ac5a-9666175ec106")]
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case6? ResolvedCase { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("811d115c-8d3a-493c-9839-dca205dac843")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("c0d2297e-5469-49fd-9f10-04ef9fce2297")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation33? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("5a4011b4-f0e4-471b-9854-91c2bb68c6db")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("85c2e206-5a00-4ecf-af6d-c6602fdd4152")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <summary>
    /// Specifies the status of a cancellation request, related to a payment information group.
    /// </summary>
    [IsoId("a4db0d80-5c4e-41d4-b29b-eaa8261aab8b")]
    [DisplayName("Payment Information Cancellation Status")]
    [IsoXmlTag("PmtInfCxlSts")]
    public GroupCancellationStatus1Code? PaymentInformationCancellationStatus { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("bcf86d54-9c6f-4d19-937f-e8e2186d0680")]
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public ValueList<CancellationStatusReason5> CancellationStatusReasonInformation { get; init; } = [];

    /// <summary>
    /// Detailed information on the number of transactions for each identical cancellation status.
    /// </summary>
    [IsoId("f73b5403-6214-4452-903e-798a873caa5f")]
    [DisplayName("Number Of Transactions Per Cancellation Status")]
    [IsoXmlTag("NbOfTxsPerCxlSts")]
    public ValueList<NumberOfCancellationsPerStatus1> NumberOfTransactionsPerCancellationStatus { get; init; } = [];

    /// <summary>
    /// Provides information on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("6f3b0b5a-d29b-46b0-aa8c-e92cbfef29ae")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction175> TransactionInformationAndStatus { get; init; } = [];
}
