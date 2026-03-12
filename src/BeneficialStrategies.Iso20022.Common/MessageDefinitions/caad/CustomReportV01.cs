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



namespace BeneficialStrategies.Iso20022.caad;

/// <summary>
/// This record is an implementation of the caad.010.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Custom Report message can be initiated by any party and received by any party (acquirer, agent, issuer or other party) connected to a network.
/// 
/// This message provides the capability to convey customized reports that are defined by bi-lateral agreement.
/// </summary>
[Description(@"The Custom Report message can be initiated by any party and received by any party (acquirer, agent, issuer or other party) connected to a network.||This message provides the capability to convey customized reports that are defined by bi-lateral agreement.")]
[IsoId("_4z6yUMlHEeuJ35KoBRZFOg")]
[DisplayName("Custom Report V")]
public partial record CustomReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caad.010.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CstmRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caad.010.001.01";
    
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
    /// Information related to protocol management.
    /// </summary>
    [IsoId("_gLegIMlLEeuJ35KoBRZFOg")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header65 Header { get; init; } 
    
    /// <summary>
    /// Information related to the customer report.
    /// </summary>
    [IsoId("_rJnosMlLEeuJ35KoBRZFOg")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required CustomReport1 Body { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_t0su4clLEeuJ35KoBRZFOg")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since CustomReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CustomReportV01.

