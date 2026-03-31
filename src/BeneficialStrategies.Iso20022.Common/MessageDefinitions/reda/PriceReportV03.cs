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
/// This record is an implementation of the reda.001.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, eg, a transfer agent, fund accountant or market data provider, sends the PriceReport message to the report recipient, eg, a fund management company, transfer agent, market data provider, regulator or other interested party to provide the net asset value and price information for financial instruments on specific trade dates and, optionally, to quote price variation information.
/// Usage
/// The PriceReport message is used to:
/// - report prices for one or several different financial instruments for one or several different trade dates,
/// - report statistical information about the valuation of a financial instrument,
/// - inform another party that the quotation of a financial instrument is suspended,
/// - report prices that are used for purposes other than the execution of investment funds orders.
/// </summary>
[Description(
    @"Scope|A report provider, eg, a transfer agent, fund accountant or market data provider, sends the PriceReport message to the report recipient, eg, a fund management company, transfer agent, market data provider, regulator or other interested party to provide the net asset value and price information for financial instruments on specific trade dates and, optionally, to quote price variation information.|Usage|The PriceReport message is used to:|- report prices for one or several different financial instruments for one or several different trade dates,|- report statistical information about the valuation of a financial instrument,|- inform another party that the quotation of a financial instrument is suspended,|- report prices that are used for purposes other than the execution of investment funds orders."
)]
[IsoId("_ZtdTrNEvEd-BzquC8wXy7w_1235947940")]
[DisplayName("Price Report V")]
public record PriceReportV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.001.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PricRptV03";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.001.001.03";

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
    [IsoId("_ZtdTrdEvEd-BzquC8wXy7w_-55887132")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_ZtdTrtEvEd-BzquC8wXy7w_1451126940")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_ZtdTr9EvEd-BzquC8wXy7w_1460364565")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_ZtnEoNEvEd-BzquC8wXy7w_1463134202")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_ZtnEodEvEd-BzquC8wXy7w_-1390634790")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; }

    /// <summary>
    /// Information related to the price valuation of a financial instrument.
    /// </summary>
    [IsoId("_ZtnEotEvEd-BzquC8wXy7w_-1559220548")]
    [DisplayName("Price Valuation Details")]
    [IsoXmlTag("PricValtnDtls")]
    public required PriceValuation3 PriceValuationDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ZtnEo9EvEd-BzquC8wXy7w_-1773147282")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since PriceReportV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PriceReportV03.
