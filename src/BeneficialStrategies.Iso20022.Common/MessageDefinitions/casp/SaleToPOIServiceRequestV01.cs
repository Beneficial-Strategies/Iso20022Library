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



namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// This record is an implementation of the casp.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This financial service is a request by the Sale system of a service to execute on POI system.
/// </summary>
[Description(@"This financial service is a request by the Sale system of a service to execute on POI system.")]
[IsoId("_dTGYUYX_EemxIqbaFEE8-w")]
[DisplayName("Sale To POI Service Request V")]
public partial record SaleToPOIServiceRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "casp.001.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOISvcReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.001.001.01";
    
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
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_dTGYU4X_EemxIqbaFEE8-w")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header37 Header { get; init; } 
    
    /// <summary>
    /// Information related to a service request.
    /// </summary>
    [IsoId("_dTGYVYX_EemxIqbaFEE8-w")]
    [DisplayName("Service Request")]
    [IsoXmlTag("SvcReq")]
    public required ServiceRequest2 ServiceRequest { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_dTGYV4X_EemxIqbaFEE8-w")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType18? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since SaleToPOIServiceRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SaleToPOIServiceRequestV01.

