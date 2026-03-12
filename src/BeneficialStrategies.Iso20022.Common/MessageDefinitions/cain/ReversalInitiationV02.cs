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
/// This record is an implementation of the cain.005.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ReversalInitiation message is sent by an acquirer, an originator or an agent to an issuer to request or advise of the reversal of an authorisation by the issuer. A reversal is a partial or complete nullification of the effects of a previous authorisation, financial presentment or financial accumulation presentment that cannot be processed as instructed (for example, is undeliverable and cancelled or the acquirer timed out waiting for a response).
/// </summary>
[Description(@"The ReversalInitiation message is sent by an acquirer, an originator or an agent to an issuer to request or advise of the reversal of an authorisation by the issuer. A reversal is a partial or complete nullification of the effects of a previous authorisation, financial presentment or financial accumulation presentment that cannot be processed as instructed (for example, is undeliverable and cancelled or the acquirer timed out waiting for a response).")]
[IsoId("_ctEcNVT_EeetiruPyDPo0Q")]
[DisplayName("Reversal Initiation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReversalInitiationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.005.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslInitn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.005.001.02";
    
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
    /// Constructs a ReversalInitiationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReversalInitiationV02( Header42 reqHeader,ReversalInitiation1 reqBody )
    {
        Header = reqHeader;
        Body = reqBody;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_ctEcNlT_EeetiruPyDPo0Q")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header42 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header42 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header42 Header { get; init; } 
    #else
    public Header42 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the reversal of an authorisation or financial transaction.
    /// </summary>
    [IsoId("_ctEcOVT_EeetiruPyDPo0Q")]
    [DisplayName("Body")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Body")]
    #endif
    [IsoXmlTag("Body")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReversalInitiation1 Body { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReversalInitiation1 Body { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalInitiation1 Body { get; init; } 
    #else
    public ReversalInitiation1 Body { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_ctEcN1T_EeetiruPyDPo0Q")]
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


// Since ReversalInitiationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReversalInitiationV02.

