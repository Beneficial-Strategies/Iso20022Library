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


namespace BeneficialStrategies.Iso20022.cafr;

/// <summary>
/// This record is an implementation of the cafr.003.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// A FraudDispositionInitiation message is usually sent by an agent to a financial institution acting as an acquirer or as an issuer   to report about the disposition of a confirmed fraudulent transaction.
/// </summary>
[Description(@"A FraudDispositionInitiation message is usually sent by an agent to a financial institution acting as an acquirer or as an issuer   to report about the disposition of a confirmed fraudulent transaction.")]
[IsoId("_2sgG8XdfEeeKH6vrEwvLHA")]
[DisplayName("Fraud Disposition Initiation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FraudDispositionInitiationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cafr.003.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FrdDspstnInitn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cafr.003.001.01";
    
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
    /// Constructs a FraudDispositionInitiationV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FraudDispositionInitiationV01( Header48 reqHeader,FraudDispositionInitiation1 reqBody )
    {
        Header = reqHeader;
        Body = reqBody;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_2sgG83dfEeeKH6vrEwvLHA")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header48 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header48 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header48 Header { get; init; } 
    #else
    public Header48 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the initiation of the fraud disposition.
    /// </summary>
    [IsoId("_2sgG9XdfEeeKH6vrEwvLHA")]
    [DisplayName("Body")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Body")]
    #endif
    [IsoXmlTag("Body")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FraudDispositionInitiation1 Body { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FraudDispositionInitiation1 Body { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FraudDispositionInitiation1 Body { get; init; } 
    #else
    public FraudDispositionInitiation1 Body { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_2sgG93dfEeeKH6vrEwvLHA")]
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


// Since FraudDispositionInitiationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FraudDispositionInitiationV01.

