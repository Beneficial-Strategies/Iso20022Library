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

namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// This record is an implementation of the caaa.016.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorCurrencyConversionRequest message is sent by the card acceptor to the currency conversion service provider to request if the cardholder is able to pay in the currency of its card.
///
/// </summary>
[Description(
    @"The AcceptorCurrencyConversionRequest message is sent by the card acceptor to the currency conversion service provider to request if the cardholder is able to pay in the currency of its card.|"
)]
[IsoId("_WUjDIXMdEe2vXY6MoVq19w")]
[DisplayName("Acceptor Currency Conversion Request V")]
public record AcceptorCurrencyConversionRequestV10 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.016.001.10";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCcyConvsReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.016.001.10";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Currency Conversion request message management information.
    /// </summary>
    [IsoId("_WUjDJXMdEe2vXY6MoVq19w")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header70 Header { get; init; }

    /// <summary>
    /// Information related to the currency conversion request.
    /// </summary>
    [IsoId("_WUjDJ3MdEe2vXY6MoVq19w")]
    [DisplayName("Currency Conversion Request")]
    [IsoXmlTag("CcyConvsReq")]
    public required AcceptorCurrencyConversionRequest10 CurrencyConversionRequest { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_WUjDKXMdEe2vXY6MoVq19w")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType36? SecurityTrailer { get; init; }
}

// Since AcceptorCurrencyConversionRequestV10Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCurrencyConversionRequestV10.
