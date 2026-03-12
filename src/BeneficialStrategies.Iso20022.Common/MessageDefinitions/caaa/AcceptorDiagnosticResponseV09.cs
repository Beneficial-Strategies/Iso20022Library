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


namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// This record is an implementation of the caaa.014.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorDiagnosticResponse message is sent by the acquirer (or its agent) to provide to the acceptor the result of the diagnostic request.
/// </summary>
[Description(@"The AcceptorDiagnosticResponse message is sent by the acquirer (or its agent) to provide to the acceptor the result of the diagnostic request.")]
[IsoId("_QrJMkU7TEeyGi9JAv6wq7Q")]
[DisplayName("Acceptor Diagnostic Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorDiagnosticResponseV09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.014.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrDgnstcRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.014.001.09";
    
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
    /// Constructs a AcceptorDiagnosticResponseV09 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorDiagnosticResponseV09( Header59 reqHeader,AcceptorDiagnosticResponse8 reqDiagnosticResponse )
    {
        Header = reqHeader;
        DiagnosticResponse = reqDiagnosticResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Diagnostic response message management information.
    /// </summary>
    [IsoId("_QrJMlU7TEeyGi9JAv6wq7Q")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header59 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header59 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header59 Header { get; init; } 
    #else
    public Header59 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the diagnostic response.
    /// </summary>
    [IsoId("_QrJMl07TEeyGi9JAv6wq7Q")]
    [DisplayName("Diagnostic Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgnstcRspn")]
    #endif
    [IsoXmlTag("DgnstcRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorDiagnosticResponse8 DiagnosticResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptorDiagnosticResponse8 DiagnosticResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorDiagnosticResponse8 DiagnosticResponse { get; init; } 
    #else
    public AcceptorDiagnosticResponse8 DiagnosticResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_QrJMmU7TEeyGi9JAv6wq7Q")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType31? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType31? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType31? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AcceptorDiagnosticResponseV09Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorDiagnosticResponseV09.

