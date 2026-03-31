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
/// This record is an implementation of the caaa.002.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorAuthorisationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to return the result of the validation made by issuer about the payment transaction.
/// </summary>
[Description(
    @"The AcceptorAuthorisationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to return the result of the validation made by issuer about the payment transaction."
)]
[IsoId("_gjkcwTGmEeO118ZQJgaQSQ")]
[DisplayName("Acceptor Authorisation Response V")]
public record AcceptorAuthorisationResponseV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.002.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrAuthstnRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.002.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Authorisation response message management information.
    /// </summary>
    [IsoId("_gjkcwzGmEeO118ZQJgaQSQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header7 Header { get; init; }

    /// <summary>
    /// Information related to the response of the authorisation.
    /// </summary>
    [IsoId("_gjkcxTGmEeO118ZQJgaQSQ")]
    [DisplayName("Authorisation Response")]
    [IsoXmlTag("AuthstnRspn")]
    public required AcceptorAuthorisationResponse3 AuthorisationResponse { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_gjkcxzGmEeO118ZQJgaQSQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType8 SecurityTrailer { get; init; }
}

// Since AcceptorAuthorisationResponseV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorAuthorisationResponseV03.
