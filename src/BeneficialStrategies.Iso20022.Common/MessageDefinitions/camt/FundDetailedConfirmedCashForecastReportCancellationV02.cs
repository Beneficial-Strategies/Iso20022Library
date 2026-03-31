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
/// This record is an implementation of the camt.045.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, such as a transfer agent, sends the FundDetailedConfirmedCashForecastReportCancellation messages to the report user, such as an investment manager, fund accountant or any other interested party, to cancel a previously sent FundDetailedConfirmedCashForecastReport.
/// Usage
/// The FundDetailedConfirmedCashForecastReportCancellation message is used to cancel an entire FundDetailedConfirmedCashForecastReport message that was previously sent. This message must contain the reference of the message to be cancelled.
/// This message may also contain details of the message to be cancelled, but this is not recommended.
/// </summary>
[Description(
    @"Scope|A report provider, such as a transfer agent, sends the FundDetailedConfirmedCashForecastReportCancellation messages to the report user, such as an investment manager, fund accountant or any other interested party, to cancel a previously sent FundDetailedConfirmedCashForecastReport.|Usage|The FundDetailedConfirmedCashForecastReportCancellation message is used to cancel an entire FundDetailedConfirmedCashForecastReport message that was previously sent. This message must contain the reference of the message to be cancelled.|This message may also contain details of the message to be cancelled, but this is not recommended."
)]
[IsoId("_bVylm9E-Ed-BzquC8wXy7w_2091851889")]
[DisplayName("Fund Detailed Confirmed Cash Forecast Report Cancellation V")]
public record FundDetailedConfirmedCashForecastReportCancellationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.045.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndDtldConfdCshFcstRptCxlV02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.045.001.02";

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
    [IsoId("_bVylnNE-Ed-BzquC8wXy7w_822772585")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_bVylndE-Ed-BzquC8wXy7w_2091852045")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_bV8WkNE-Ed-BzquC8wXy7w_2091851967")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_bV8WkdE-Ed-BzquC8wXy7w_2091851925")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_bV8WktE-Ed-BzquC8wXy7w_728842936")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; }

    /// <summary>
    /// The FundDetailedConfirmedCashForecastReport to be cancelled.
    /// </summary>
    [IsoId("_bV8Wk9E-Ed-BzquC8wXy7w_2091852010")]
    [DisplayName("Cash Forecast Report To Be Cancelled")]
    [IsoXmlTag("CshFcstRptToBeCanc")]
    public FundDetailedConfirmedCashForecastReport2? CashForecastReportToBeCancelled { get; init; }
}

// Since FundDetailedConfirmedCashForecastReportCancellationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FundDetailedConfirmedCashForecastReportCancellationV02.
