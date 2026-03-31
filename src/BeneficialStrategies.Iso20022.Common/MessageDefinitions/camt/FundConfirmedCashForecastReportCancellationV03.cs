// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.044.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, such as a transfer agent, sends the FundConfirmedCashForecastReportCancellation message to the report user, such as an investment manager or pricing agent, to cancel a previously sent FundConfirmedCashForecastReport message.
/// Usage
/// The FundConfirmedCashForecastReportCancellation message is used to cancel an entire FundConfirmedCashForecastReport message that was previously sent by the report provider. This message must contain reference to the of the message being cancelled.
/// This message may also contain details of the message to be cancelled, but this is not recommended.
/// </summary>
[Description(
    @"Scope|A report provider, such as a transfer agent, sends the FundConfirmedCashForecastReportCancellation message to the report user, such as an investment manager or pricing agent, to cancel a previously sent FundConfirmedCashForecastReport message.|Usage|The FundConfirmedCashForecastReportCancellation message is used to cancel an entire FundConfirmedCashForecastReport message that was previously sent by the report provider. This message must contain reference to the of the message being cancelled.|This message may also contain details of the message to be cancelled, but this is not recommended."
)]
[IsoId("_Q7mCEQasEeSrXeb3pHPmbg")]
[DisplayName("Fund Confirmed Cash Forecast Report Cancellation V")]
public record FundConfirmedCashForecastReportCancellationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.044.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndConfdCshFcstRptCxl";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.044.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_Q7mCEwasEeSrXeb3pHPmbg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Q7mCFQasEeSrXeb3pHPmbg")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Q7mCFwasEeSrXeb3pHPmbg")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_Q7mCGQasEeSrXeb3pHPmbg")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_Q7mCGwasEeSrXeb3pHPmbg")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; }

    /// <summary>
    /// The FundDetailedConfirmedCashForecastReport to be cancelled.
    /// </summary>
    [IsoId("_Q7mCHQasEeSrXeb3pHPmbg")]
    [DisplayName("Cash Forecast Report To Be Cancelled")]
    [IsoXmlTag("CshFcstRptToBeCanc")]
    public FundConfirmedCashForecastReport3? CashForecastReportToBeCancelled { get; init; }
}

// Since FundConfirmedCashForecastReportCancellationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FundConfirmedCashForecastReportCancellationV03.
