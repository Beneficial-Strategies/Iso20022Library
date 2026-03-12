// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// This record is an implementation of the caaa.013.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorDiagnosticRequest message is sent by the card acceptor to the acquirer to ensure the availability of the acquirer. An agent never forwards the message.
/// Usage
/// The AcceptorDiagnosticRequest message is used to:
/// - test the availability of the acquirer;
/// - validate the security of the exchanges with the acquirer;
/// - validate the version of the configuration parameters.
/// </summary>
[Description(@"Scope|The AcceptorDiagnosticRequest message is sent by the card acceptor to the acquirer to ensure the availability of the acquirer. An agent never forwards the message.|Usage|The AcceptorDiagnosticRequest message is used to:|- test the availability of the acquirer;|- validate the security of the exchanges with the acquirer;|- validate the version of the configuration parameters.")]
[IsoId("_VxGmFaMVEeCJ6YNENx4h-w_-1426270091")]
[DisplayName("Acceptor Diagnostic Request V")]
public partial record AcceptorDiagnosticRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.013.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrDgnstcReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.013.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Diagnostic request message management information.
    /// </summary>
    [IsoId("_VxGmFqMVEeCJ6YNENx4h-w_-1637242699")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header1 Header { get; init; } 
    
    /// <summary>
    /// Information related to the diagnostic request.
    /// </summary>
    [IsoId("_VxGmF6MVEeCJ6YNENx4h-w_992203436")]
    [DisplayName("Diagnostic Request")]
    [IsoXmlTag("DgnstcReq")]
    public required AcceptorDiagnosticRequest1 DiagnosticRequest { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_VxGmGKMVEeCJ6YNENx4h-w_-788841491")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType3 SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since AcceptorDiagnosticRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorDiagnosticRequestV01.

