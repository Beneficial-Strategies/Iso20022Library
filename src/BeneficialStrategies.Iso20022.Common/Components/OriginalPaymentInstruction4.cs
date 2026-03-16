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
[IsoId("_sjzuQVkyEeGeoaLUQk__nA_2132277443")]
[DisplayName("Original Payment Instruction")]
public record OriginalPaymentInstruction4
{
    /// <summary>
    /// Unique identification, as assigned by the assigner, to unambiguously identify the cancellation request.||Usage: The cancellation request identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    [IsoId("_sjzuQlkyEeGeoaLUQk__nA_1829220928")]
    [DisplayName("Payment Cancellation Identification")]
    [IsoXmlTag("PmtCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentCancellationIdentification { get; init; }

    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_sjzuQ1kyEeGeoaLUQk__nA_298371716")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case3? Case { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the original payment information block, as assigned by the original sending party.
    /// </summary>
    [IsoId("_sj9fQFkyEeGeoaLUQk__nA_-1656866630")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_sj9fQVkyEeGeoaLUQk__nA_-330644851")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the cancellation payment information group.
    /// </summary>
    [IsoId("_sj9fQlkyEeGeoaLUQk__nA_-978839933")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the cancellation payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_skGpMFkyEeGeoaLUQk__nA_1500278318")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Indicates whether or not the cancellation applies to a whole group of transactions or to individual transactions within the original group.
    /// </summary>
    [IsoId("_skGpMVkyEeGeoaLUQk__nA_-380027322")]
    [DisplayName("Payment Information Cancellation")]
    [IsoXmlTag("PmtInfCxl")]
    [IsoSimpleType(IsoSimpleType.GroupCancellationIndicator)]
    public IsoGroupCancellationIndicator? PaymentInformationCancellation { get; init; }

    /// <summary>
    /// Detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_skGpMlkyEeGeoaLUQk__nA_-1123621847")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public ValueList<PaymentCancellationReason2> CancellationReasonInformation { get; init; } = [];

    /// <summary>
    /// Information concerning the original transactions, to which the cancellation request message refers.
    /// </summary>
    [IsoId("_skQaMFkyEeGeoaLUQk__nA_372715529")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public ValueList<PaymentTransaction37> TransactionInformation { get; init; } = [];
}
