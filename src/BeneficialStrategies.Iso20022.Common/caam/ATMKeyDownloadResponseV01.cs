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
/// This record is an implementation of the caam.004.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMKeyDownloadResponse message is sent from an acquirer to an ATM in response to an ATMKeyDownloadRequest message, to download of one or several cryptographic keys.
/// </summary>
[Description(@"The ATMKeyDownloadResponse message is sent from an acquirer to an ATM in response to an ATMKeyDownloadRequest message, to download of one or several cryptographic keys.")]
[IsoId("_doLoYItREeST3ocKVc8_qA")]
[DisplayName("ATM Key Download Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMKeyDownloadResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.004.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMKeyDwnldRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.004.001.01";
    
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
    /// Constructs a ATMKeyDownloadResponseV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMKeyDownloadResponseV01( Header20 reqHeader )
    {
        Header = reqHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_k16aYItREeST3ocKVc8_qA")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header20 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header20 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header20 Header { get; init; } 
    #else
    public Header20 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_uXuu4ItREeST3ocKVc8_qA")]
    [DisplayName("Protected ATM Key Download Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdATMKeyDwnldRspn")]
    #endif
    [IsoXmlTag("PrtctdATMKeyDwnldRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedATMKeyDownloadResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedATMKeyDownloadResponse { get; init; } 
    #else
    public ContentInformationType10? ProtectedATMKeyDownloadResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the response of an ATM key download from an ATM manager.
    /// </summary>
    [IsoId("_561lsItREeST3ocKVc8_qA")]
    [DisplayName("ATM Key Download Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMKeyDwnldRspn")]
    #endif
    [IsoXmlTag("ATMKeyDwnldRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMKeyDownloadResponse1? ATMKeyDownloadResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMKeyDownloadResponse1? ATMKeyDownloadResponse { get; init; } 
    #else
    public ATMKeyDownloadResponse1? ATMKeyDownloadResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_-i7yMItREeST3ocKVc8_qA")]
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


// Since ATMKeyDownloadResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMKeyDownloadResponseV01.

