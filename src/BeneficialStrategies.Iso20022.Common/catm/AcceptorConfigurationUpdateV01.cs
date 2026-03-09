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


namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// This record is an implementation of the catm.003.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorConfigurationUpdate message is sent by the master terminal manager or delegated terminal manager to the acceptor system for the update of acquirer parameters, merchant parameters, vendor parameters or cryptographic keys of the acquirer.
/// Usage
/// The AcceptorConfigurationUpdate message may embed the information required by the acceptor system for the configuration of:
/// - the application parameters necessary for software applications processed by the POI system,
/// - the acquirer protocol parameters for the message content and message exchange behaviour of the acquirer protocol supported by the POI system,
/// - the host communication parameters to define the addresses of the connected acquirer hosts, and
/// - the merchant parameters needed for the retailer protocol settings of the POI system.
/// </summary>
[Description(@"Scope|The AcceptorConfigurationUpdate message is sent by the master terminal manager or delegated terminal manager to the acceptor system for the update of acquirer parameters, merchant parameters, vendor parameters or cryptographic keys of the acquirer.|Usage|The AcceptorConfigurationUpdate message may embed the information required by the acceptor system for the configuration of:|- the application parameters necessary for software applications processed by the POI system,|- the acquirer protocol parameters for the message content and message exchange behaviour of the acquirer protocol supported by the POI system,|- the host communication parameters to define the addresses of the connected acquirer hosts, and|- the merchant parameters needed for the retailer protocol settings of the POI system.")]
[IsoId("_AgFfYOQXEeCGktPI9k4Dlw_1733626146")]
[DisplayName("Acceptor Configuration Update V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorConfigurationUpdateV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.003.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCfgtnUpd";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.003.001.01";
    
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
    /// Constructs a AcceptorConfigurationUpdateV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorConfigurationUpdateV01( Header4 reqHeader,AcceptorConfiguration1 reqAcceptorConfiguration,ContentInformationType1 reqSecurityTrailer )
    {
        Header = reqHeader;
        AcceptorConfiguration = reqAcceptorConfiguration;
        SecurityTrailer = reqSecurityTrailer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics related to the transfer of the acceptor parameters.
    /// </summary>
    [IsoId("_AgFfYeQXEeCGktPI9k4Dlw_-1237434314")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header4 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header4 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header4 Header { get; init; } 
    #else
    public Header4 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptor configuration to be downloaded from the terminal management system.
    /// </summary>
    [IsoId("_AgFfYuQXEeCGktPI9k4Dlw_950623241")]
    [DisplayName("Acceptor Configuration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptrCfgtn")]
    #endif
    [IsoXmlTag("AccptrCfgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorConfiguration1 AcceptorConfiguration { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptorConfiguration1 AcceptorConfiguration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorConfiguration1 AcceptorConfiguration { get; init; } 
    #else
    public AcceptorConfiguration1 AcceptorConfiguration { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_AgFfY-QXEeCGktPI9k4Dlw_543485283")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentInformationType1 SecurityTrailer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContentInformationType1 SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType1 SecurityTrailer { get; init; } 
    #else
    public ContentInformationType1 SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AcceptorConfigurationUpdateV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorConfigurationUpdateV01.

