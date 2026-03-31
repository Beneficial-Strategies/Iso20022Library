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
/// This record is an implementation of the caaa.014.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorDiagnosticResponse message is sent by the acquirer (or its agent) to provide to the acceptor the result of the diagnostic request.
/// </summary>
[Description(
    @"The AcceptorDiagnosticResponse message is sent by the acquirer (or its agent) to provide to the acceptor the result of the diagnostic request."
)]
[IsoId("__eyjYQvgEeK9Xewg3qiFQA")]
[DisplayName("Acceptor Diagnostic Response V")]
public record AcceptorDiagnosticResponseV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.014.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrDgnstcRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.014.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Diagnostic response message management information.
    /// </summary>
    [IsoId("__eyjYwvgEeK9Xewg3qiFQA")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header1 Header { get; init; }

    /// <summary>
    /// Information related to the diagnostic response.
    /// </summary>
    [IsoId("__eyjZwvgEeK9Xewg3qiFQA")]
    [DisplayName("Diagnostic Response")]
    [IsoXmlTag("DgnstcRspn")]
    public required AcceptorDiagnosticResponse2 DiagnosticResponse { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("__eyjawvgEeK9Xewg3qiFQA")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType6 SecurityTrailer { get; init; }
}

// Since AcceptorDiagnosticResponseV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorDiagnosticResponseV02.
