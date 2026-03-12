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


namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.016.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:
/// The PartyStatusAdvice message is sent by the executing party to the instructing party to provide details about the processing of a request on party reference data (create or update).
/// 
/// Usage:
/// When processing information is negative - a failure occurred in applying the changes the message accordingly also delivers information about the reason why the creation or update could not be processed.
/// When processing is successfully performed, the message includes the related party identification.
/// </summary>
[Description(@"Scope:|The PartyStatusAdvice message is sent by the executing party to the instructing party to provide details about the processing of a request on party reference data (create or update).||Usage:|When processing information is negative - a failure occurred in applying the changes the message accordingly also delivers information about the reason why the creation or update could not be processed.|When processing is successfully performed, the message includes the related party identification.")]
[IsoId("_5jHEEZeSEeen_cyMrluY4w")]
[DisplayName("Party Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.016.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.016.001.01";
    
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
    /// Constructs a PartyStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyStatusAdviceV01( PartyStatus2 reqPartyStatus )
    {
        PartyStatus = reqPartyStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_eEidoVhGEeih3fUfzR38Ig")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageHeader12? MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader12? MessageHeader { get; init; } 
    #else
    public MessageHeader12? MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the party involved in the originating message.
    /// </summary>
    [IsoId("_5jHEG5eSEeen_cyMrluY4w")]
    [DisplayName("Party Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtySts")]
    #endif
    [IsoXmlTag("PtySts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyStatus2 PartyStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyStatus2 PartyStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyStatus2 PartyStatus { get; init; } 
    #else
    public PartyStatus2 PartyStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5jHEHZeSEeen_cyMrluY4w")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since PartyStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PartyStatusAdviceV01.

