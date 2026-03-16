// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide reference and status information on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("_PnAPNdp-Ed-ak6NoX_4Aeg_1902930206")]
[DisplayName("Original Payment Information")]
public record OriginalPaymentInformation4
{
    /// <summary>
    /// Unique identification, as assigned by the assigner, to unambiguously identify the cancellation request.||Usage: The cancellation request identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    [IsoId("_PnAPNtp-Ed-ak6NoX_4Aeg_1902930208")]
    [DisplayName("Payment Cancellation Identification")]
    [IsoXmlTag("PmtCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentCancellationIdentification { get; init; }

    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_PnAPN9p-Ed-ak6NoX_4Aeg_622398900")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case2? Case { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the original payment information block, as assigned by the original sending party.
    /// </summary>
    [IsoId("_PnAPONp-Ed-ak6NoX_4Aeg_1902930515")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_PnAPOdp-Ed-ak6NoX_4Aeg_1444860875")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the cancellation payment information group.
    /// </summary>
    [IsoId("_PnAPOtp-Ed-ak6NoX_4Aeg_-1211527919")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the cancellation payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_PnAPO9p-Ed-ak6NoX_4Aeg_-1212448074")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Indicates whether or not the cancellation applies to a whole group of transactions or to individual transactions within the original group.
    /// </summary>
    [IsoId("_PnAPPNp-Ed-ak6NoX_4Aeg_-1212448013")]
    [DisplayName("Payment Information Cancellation")]
    [IsoXmlTag("PmtInfCxl")]
    [IsoSimpleType(IsoSimpleType.GroupCancellationIndicator)]
    public IsoGroupCancellationIndicator? PaymentInformationCancellation { get; init; }

    /// <summary>
    /// Detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_PnJZINp-Ed-ak6NoX_4Aeg_1903851095")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public ValueList<CancellationReasonInformation3> CancellationReasonInformation { get; init; } =
        [];

    /// <summary>
    /// Information concerning the original transactions, to which the cancellation request message refers.
    /// </summary>
    [IsoId("_PnJZIdp-Ed-ak6NoX_4Aeg_1444861176")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public ValueList<PaymentTransactionInformation30> TransactionInformation { get; init; } = [];
}
