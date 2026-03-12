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


namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// This record is an implementation of the cain.018.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The VerificationInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). It conveys information to a receiver requiring verification or authentication. |
/// |
/// Examples of usages are: authentication of certificates, assurance levels of tokens, certificate management, address verification, account verification and cheque verification. It is also used to inform the receiver of a verification that has been completed on its behalf.
/// </summary>
[Description(@"The VerificationInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). It conveys information to a receiver requiring verification or authentication. ||||Examples of usages are: authentication of certificates, assurance levels of tokens, certificate management, address verification, account verification and cheque verification. It is also used to inform the receiver of a verification that has been completed on its behalf.")]
[IsoId("_acX4lVf3EeedJb6VxsnkPg")]
[DisplayName("Verification Initiation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VerificationInitiationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.018.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "VrfctnInitn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.018.001.01";
    
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
    /// Constructs a VerificationInitiationV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VerificationInitiationV01( Header39 reqHeader,VerificationInitiation1 reqBody )
    {
        Header = reqHeader;
        Body = reqBody;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_acX4mFf3EeedJb6VxsnkPg")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header39 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header39 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header39 Header { get; init; } 
    #else
    public Header39 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the verification initiation.
    /// </summary>
    [IsoId("_acX4l1f3EeedJb6VxsnkPg")]
    [DisplayName("Body")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Body")]
    #endif
    [IsoXmlTag("Body")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required VerificationInitiation1 Body { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required VerificationInitiation1 Body { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VerificationInitiation1 Body { get; init; } 
    #else
    public VerificationInitiation1 Body { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_acX4mVf3EeedJb6VxsnkPg")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType20? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType20? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType20? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since VerificationInitiationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to VerificationInitiationV01.

