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


namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// This record is an implementation of the tsrv.010.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingNonExtensionRequest message is sent by the party that requested issuance of the undertaking (applicant or obligor) to the party that issued the undertaking. It is used to request no further automatic extensions to the expiry of the referenced undertaking.
/// </summary>
[Description(@"The UndertakingNonExtensionRequest message is sent by the party that requested issuance of the undertaking (applicant or obligor) to the party that issued the undertaking. It is used to request no further automatic extensions to the expiry of the referenced undertaking.")]
[IsoId("_9gmpVXltEeG7BsjMvd1mEw_634999527")]
[DisplayName("Undertaking Non Extension Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingNonExtensionRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.010.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgNonXtnsnReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.010.001.01";
    
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
    /// Constructs a UndertakingNonExtensionRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingNonExtensionRequestV01( UndertakingNonExtensionRequest1 reqUndertakingNonExtensionRequestDetails )
    {
        UndertakingNonExtensionRequestDetails = reqUndertakingNonExtensionRequestDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details of the non extension request.
    /// </summary>
    [IsoId("_9gmpVnltEeG7BsjMvd1mEw_1337678372")]
    [DisplayName("Undertaking Non Extension Request Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgNonXtnsnReqDtls")]
    #endif
    [IsoXmlTag("UdrtkgNonXtnsnReqDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingNonExtensionRequest1 UndertakingNonExtensionRequestDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingNonExtensionRequest1 UndertakingNonExtensionRequestDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingNonExtensionRequest1 UndertakingNonExtensionRequestDetails { get; init; } 
    #else
    public UndertakingNonExtensionRequest1 UndertakingNonExtensionRequestDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the request.
    /// </summary>
    [IsoId("_9gmpV3ltEeG7BsjMvd1mEw_-238052912")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature2? DigitalSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since UndertakingNonExtensionRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingNonExtensionRequestV01.

