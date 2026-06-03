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
[IsoId("d9c6cb01-840a-4161-96b1-6f7322af96ad")]
[DisplayName("Original Payment Instruction55")]
public record OriginalPaymentInstruction55
{
    /// <summary>
    /// Unique identification, as assigned by the assigner, to unambiguously identify the cancellation request.
    /// </summary>
    [IsoId("6fc2583e-9c46-4660-be2c-3374d7ac37b4")]
    [DisplayName("Payment Cancellation Identification")]
    [IsoXmlTag("PmtCxlId")]
    public IsoMax35Text? PaymentCancellationIdentification { get; init; }

    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("f20ee615-2022-46bd-b825-cefa88ef453a")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case6? Case { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the original payment information block, as assigned by the original sending party.
    /// </summary>
    [IsoId("def11ba6-a8b0-4a5c-92ec-ddedd2a8b60a")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("0eebb75d-357d-4c6a-a3d6-b5db4b6c6869")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation33? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the cancellation payment information group.
    /// </summary>
    [IsoId("162fbd13-a6a5-4ab8-8c23-03a8020ef96a")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the cancellation payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("d0bebb35-69c9-4345-86e9-d4c44001462b")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Indicates whether or not the cancellation applies to a whole group of transactions or to individual transactions within the original group.
    /// </summary>
    [IsoId("505648ea-8ebb-42fd-9c59-d95c50bccde5")]
    [DisplayName("Payment Information Cancellation")]
    [IsoXmlTag("PmtInfCxl")]
    public IsoGroupCancellationIndicator? PaymentInformationCancellation { get; init; }

    /// <summary>
    /// Detailed information on the cancellation reason.
    /// </summary>
    [IsoId("56668590-a6a9-43a5-826a-bb0b90bdac20")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public ValueList<PaymentCancellationReason6> CancellationReasonInformation { get; init; } = [];

    /// <summary>
    /// Information concerning the original transactions, to which the cancellation request message refers.
    /// </summary>
    [IsoId("b7d5b20d-300c-4359-b062-4e429f659c43")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public ValueList<PaymentTransaction176> TransactionInformation { get; init; } = [];
}
