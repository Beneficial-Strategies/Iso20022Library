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

namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.002.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// SCOPE
/// A report provider, for example, a transfer agent, fund accountant or market data provider, sends the PriceReportCancellation message to the report recipient, for example, a fund management company, transfer agent, market data provider, regulator or any other interested party to cancel previously sent prices.|
/// USAGE
/// The PriceReportCancellation message is used to either: |- cancel an entire PriceReport that was previously sent (by quoting the business reference of the original price report in the PriceReportIdentification element), or,|- cancel one or more individual prices from a previously sent price report (by using the PriceDetailsToBeCancelled sequence).|Technically, it is possible to cancel all the prices individually by using the PriceDetailsToBeCancelled sequence, but this is not recommended.|The cancellation should not contain the cancellation of prices for more than one NAV date.
///
///
/// </summary>
[Description(
    @"SCOPE|A report provider, for example, a transfer agent, fund accountant or market data provider, sends the PriceReportCancellation message to the report recipient, for example, a fund management company, transfer agent, market data provider, regulator or any other interested party to cancel previously sent prices.||USAGE|The PriceReportCancellation message is used to either: |- cancel an entire PriceReport that was previously sent (by quoting the business reference of the original price report in the PriceReportIdentification element), or,|- cancel one or more individual prices from a previously sent price report (by using the PriceDetailsToBeCancelled sequence).|Technically, it is possible to cancel all the prices individually by using the PriceDetailsToBeCancelled sequence, but this is not recommended.|The cancellation should not contain the cancellation of prices for more than one NAV date. ||"
)]
[IsoId("_M87dQRj3EeKxeog5DTmtgg")]
[DisplayName("Price Report Cancellation V")]
public record PriceReportCancellationV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.002.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PricRptCxl";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_M87dQxj3EeKxeog5DTmtgg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_M87dRxj3EeKxeog5DTmtgg")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_M87dSxj3EeKxeog5DTmtgg")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_M87dTxj3EeKxeog5DTmtgg")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the price report, as assigned by the reporting party.
    /// </summary>
    [IsoId("_NPnKdRmAEeKxsrht2duUcg")]
    [DisplayName("Price Report Identification")]
    [IsoXmlTag("PricRptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PriceReportIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the cancellation of the previous price report, as assigned by the reporting party.
    /// </summary>
    [IsoId("_epzJZRmAEeKxsrht2duUcg")]
    [DisplayName("Cancellation Identification")]
    [IsoXmlTag("CxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CancellationIdentification { get; init; }

    /// <summary>
    /// Reason for the cancellation.
    /// </summary>
    [IsoId("_06rKcBmAEeKxsrht2duUcg")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? CancellationReason { get; init; }

    /// <summary>
    /// Date or date and time the price will be corrected.
    /// </summary>
    [IsoId("_RTTz8BmBEeKxsrht2duUcg")]
    [DisplayName("Expected Price Correction Date")]
    [IsoXmlTag("XpctdPricCrrctnDt")]
    public DateAndDateTime1Choice_? ExpectedPriceCorrectionDate { get; init; }

    /// <summary>
    /// Indicates whether or not all the prices of the referenced price report are cancelled.
    /// </summary>
    [IsoId("_Cj3HgBmCEeKxsrht2duUcg")]
    [DisplayName("Complete Price Cancellation")]
    [IsoXmlTag("CmpltPricCxl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CompletePriceCancellation { get; init; }

    /// <summary>
    /// Details of prices to be cancelled.
    /// </summary>
    [IsoId("_M87dUxj3EeKxeog5DTmtgg")]
    [DisplayName("Cancelled Price Valuation Details")]
    [IsoXmlTag("CancPricValtnDtls")]
    public PriceReport3? CancelledPriceValuationDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2sI2JRmCEeKxsrht2duUcg")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since PriceReportCancellationV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PriceReportCancellationV04.
