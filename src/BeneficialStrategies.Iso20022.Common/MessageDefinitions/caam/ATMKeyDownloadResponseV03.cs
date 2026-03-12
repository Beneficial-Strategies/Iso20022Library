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



namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// This record is an implementation of the caam.004.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMKeyDownloadResponse message is sent from an acquirer to an ATM in response to an ATMKeyDownloadRequest message, to download of one or several cryptographic keys.
/// </summary>
[Description(@"The ATMKeyDownloadResponse message is sent from an acquirer to an ATM in response to an ATMKeyDownloadRequest message, to download of one or several cryptographic keys.")]
[IsoId("_ya2bYbTzEeeQy4o2AayYHg")]
[DisplayName("ATM Key Download Response V")]
public partial record ATMKeyDownloadResponseV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.004.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMKeyDwnldRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.004.001.03";
    
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
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_ya2bY7TzEeeQy4o2AayYHg")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header31 Header { get; init; } 
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_ya2bZbTzEeeQy4o2AayYHg")]
    [DisplayName("Protected ATM Key Download Response")]
    [IsoXmlTag("PrtctdATMKeyDwnldRspn")]
    public ContentInformationType10? ProtectedATMKeyDownloadResponse { get; init; } 
    
    /// <summary>
    /// Information related to the response of an ATM key download from an ATM manager.
    /// </summary>
    [IsoId("_ya2bZ7TzEeeQy4o2AayYHg")]
    [DisplayName("ATM Key Download Response")]
    [IsoXmlTag("ATMKeyDwnldRspn")]
    public ATMKeyDownloadResponse4? ATMKeyDownloadResponse { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_ya2babTzEeeQy4o2AayYHg")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType13? SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since ATMKeyDownloadResponseV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMKeyDownloadResponseV03.

