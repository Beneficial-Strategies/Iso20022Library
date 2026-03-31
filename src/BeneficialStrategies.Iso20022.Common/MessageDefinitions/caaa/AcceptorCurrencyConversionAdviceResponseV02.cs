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
/// This record is an implementation of the caaa.019.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorCurrencyConversionAdviceResponse message is sent by the service provider to acknowledge the acceptor about the notification of the reception of the currency conversion advice.
/// </summary>
[Description(
    @"The AcceptorCurrencyConversionAdviceResponse message is sent by the service provider to acknowledge the acceptor about the notification of the reception of the currency conversion advice."
)]
[IsoId("_7RkBods4Eee9e6xduATmQg")]
[DisplayName("Acceptor Currency Conversion Advice Response V")]
public record AcceptorCurrencyConversionAdviceResponseV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.019.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCcyConvsAdvcRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.019.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Cancellation advice response message management information.
    /// </summary>
    [IsoId("_7RkBpds4Eee9e6xduATmQg")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header36 Header { get; init; }

    /// <summary>
    /// Information related to the currency conversion advice response.
    /// </summary>
    [IsoId("_7RkBp9s4Eee9e6xduATmQg")]
    [DisplayName("Currency Conversion Advice Response")]
    [IsoXmlTag("CcyConvsAdvcRspn")]
    public required AcceptorCancellationAdviceResponse7 CurrencyConversionAdviceResponse { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_7RkBqds4Eee9e6xduATmQg")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType16? SecurityTrailer { get; init; }
}

// Since AcceptorCurrencyConversionAdviceResponseV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCurrencyConversionAdviceResponseV02.
