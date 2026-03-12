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


namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// This record is an implementation of the casp.008.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SaleToPOIAdministrativeResponse message is sent by a POI System to a sale system to provide response to an administrative service.
/// </summary>
[Description(@"The SaleToPOIAdministrativeResponse message is sent by a POI System to a sale system to provide response to an administrative service.")]
[IsoId("_c7ODcU6ZEeyGi9JAv6wq7Q")]
[DisplayName("Sale To POI Administrative Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SaleToPOIAdministrativeResponseV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "casp.008.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIAdmstvRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.008.001.04";
    
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
    /// Constructs a SaleToPOIAdministrativeResponseV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SaleToPOIAdministrativeResponseV04( Header41 reqHeader,AdministrativeResponse5 reqAdministrativeResponse )
    {
        Header = reqHeader;
        AdministrativeResponse = reqAdministrativeResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_c7ODc06ZEeyGi9JAv6wq7Q")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header41 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header41 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header41 Header { get; init; } 
    #else
    public Header41 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the response of an administrative request.
    /// </summary>
    [IsoId("_c7ODdU6ZEeyGi9JAv6wq7Q")]
    [DisplayName("Administrative Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdmstvRspn")]
    #endif
    [IsoXmlTag("AdmstvRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdministrativeResponse5 AdministrativeResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdministrativeResponse5 AdministrativeResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdministrativeResponse5 AdministrativeResponse { get; init; } 
    #else
    public AdministrativeResponse5 AdministrativeResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_c7ODd06ZEeyGi9JAv6wq7Q")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType29? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType29? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType29? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since SaleToPOIAdministrativeResponseV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SaleToPOIAdministrativeResponseV04.

