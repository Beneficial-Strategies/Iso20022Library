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
/// This record is an implementation of the reda.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The PriceReportCancellation message is sent by a report provider, eg, a fund accountant, transfer agent, market data provider, or any other interested party, to a report user, eg, a fund management company, a transfer agent, market data provider, regulator or any other interested party.
/// The message is used to cancel a previously sent PriceReport message.
/// Usage
/// The PriceReportCancellation message is used to cancel an entire PriceReport message that was previously sent by the report provider. If only a part of the information needs to be cancelled and replaced, the PriceReportCorrection message must be used.
/// This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended.
/// </summary>
[Description(
    @"Scope|The PriceReportCancellation message is sent by a report provider, eg, a fund accountant, transfer agent, market data provider, or any other interested party, to a report user, eg, a fund management company, a transfer agent, market data provider, regulator or any other interested party.|The message is used to cancel a previously sent PriceReport message.|Usage|The PriceReportCancellation message is used to cancel an entire PriceReport message that was previously sent by the report provider. If only a part of the information needs to be cancelled and replaced, the PriceReportCorrection message must be used.|This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended."
)]
[IsoId("_Zski2NEvEd-BzquC8wXy7w_-1589707882")]
[DisplayName("Price Report Cancellation V")]
public record PriceReportCancellationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.002.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "reda.002.001.02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Zski2dEvEd-BzquC8wXy7w_-1891280241")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Zski2tEvEd-BzquC8wXy7w_-1948539540")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public required AdditionalReference3 PreviousReference { get; init; }

    /// <summary>
    /// Common information related to all the price reports to be cancelled.
    /// </summary>
    [IsoId("_Zski29EvEd-BzquC8wXy7w_-1321950502")]
    [DisplayName("Price Report To Be Cancelled")]
    [IsoXmlTag("PricRptToBeCanc")]
    public PriceReport1? PriceReportToBeCancelled { get; init; }
}

// Since PriceReportCancellationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PriceReportCancellationV02.
