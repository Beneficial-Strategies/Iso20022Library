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
/// This record is an implementation of the tsrv.015.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ExtendOrPayResponse message is sent by the party that requested issuance of the undertaking (applicant or obligor) to the party that issued the undertaking, in response to the issuer&apos;s request for the applicant&apos;s response to the beneficiary’s request to extend or pay.
/// </summary>
[Description(@"The ExtendOrPayResponse message is sent by the party that requested issuance of the undertaking (applicant or obligor) to the party that issued the undertaking, in response to the issuer's request for the applicant's response to the beneficiary’s request to extend or pay.")]
[IsoId("_9iZZEnltEeG7BsjMvd1mEw_519258789")]
[DisplayName("Extend Or Pay Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExtendOrPayResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.015.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "XtndOrPayRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.015.001.01";
    
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
    /// Constructs a ExtendOrPayResponseV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ExtendOrPayResponseV01( ExtendOrPayQuery2 reqExtendOrPayResponseDetails )
    {
        ExtendOrPayResponseDetails = reqExtendOrPayResponseDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details of the extend or pay response.
    /// </summary>
    [IsoId("_9iZZE3ltEeG7BsjMvd1mEw_-29894697")]
    [DisplayName("Extend Or Pay Response Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndOrPayRspnDtls")]
    #endif
    [IsoXmlTag("XtndOrPayRspnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExtendOrPayQuery2 ExtendOrPayResponseDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExtendOrPayQuery2 ExtendOrPayResponseDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExtendOrPayQuery2 ExtendOrPayResponseDetails { get; init; } 
    #else
    public ExtendOrPayQuery2 ExtendOrPayResponseDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the response.
    /// </summary>
    [IsoId("_9iZZFHltEeG7BsjMvd1mEw_1281187011")]
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


// Since ExtendOrPayResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ExtendOrPayResponseV01.

