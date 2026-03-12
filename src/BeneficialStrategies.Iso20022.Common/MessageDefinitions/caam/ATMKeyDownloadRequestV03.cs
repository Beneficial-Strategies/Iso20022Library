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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// This record is an implementation of the caam.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMKeyDownloadRequest message is sent by an ATM to an ATM manager to initiate the download of one or several cryptographic keys.
/// </summary>
[Description(@"The ATMKeyDownloadRequest message is sent by an ATM to an ATM manager to initiate the download of one or several cryptographic keys.")]
[IsoId("_BsUbUbTpEeeQy4o2AayYHg")]
[DisplayName("ATM Key Download Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMKeyDownloadRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.003.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMKeyDwnldReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.003.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMKeyDownloadRequestV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMKeyDownloadRequestV03( Header31 reqHeader )
    {
        Header = reqHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_BsVCYbTpEeeQy4o2AayYHg")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header31 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header31 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header31 Header { get; init; } 
    #else
    public Header31 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_BsVCY7TpEeeQy4o2AayYHg")]
    [DisplayName("Protected ATM Key Download Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdATMKeyDwnldReq")]
    #endif
    [IsoXmlTag("PrtctdATMKeyDwnldReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedATMKeyDownloadRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedATMKeyDownloadRequest { get; init; } 
    #else
    public ContentInformationType10? ProtectedATMKeyDownloadRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the request of a key download from an ATM.
    /// </summary>
    [IsoId("_BsVCZbTpEeeQy4o2AayYHg")]
    [DisplayName("ATM Key Download Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMKeyDwnldReq")]
    #endif
    [IsoXmlTag("ATMKeyDwnldReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMKeyDownloadRequest4? ATMKeyDownloadRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMKeyDownloadRequest4? ATMKeyDownloadRequest { get; init; } 
    #else
    public ATMKeyDownloadRequest4? ATMKeyDownloadRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_BsVCZ7TpEeeQy4o2AayYHg")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType13? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType13? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType13? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ATMKeyDownloadRequestV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMKeyDownloadRequestV03.

