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


namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.055.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The PartyEventAdvice message can be sent by any party to any other party. It is used for business letters containing information for which treatment is not formally defined in order to keep partners informed and to maintain business traces, for example confirmations of information exchanged out-of band such as announcing a postal letter, confirming a telephone call or the exchange of contractual information. It can also be sent to verify the technical interoperability of the communicating IT-systems.
/// The message can reference other message and include data from referenced messages.
/// The message can report several events.
/// The message can carry digital signatures if required by context.
/// </summary>
[Description(@"The PartyEventAdvice message can be sent by any party to any other party. It is used for business letters containing information for which treatment is not formally defined in order to keep partners informed and to maintain business traces, for example confirmations of information exchanged out-of band such as announcing a postal letter, confirming a telephone call or the exchange of contractual information. It can also be sent to verify the technical interoperability of the communicating IT-systems.|The message can reference other message and include data from referenced messages.|The message can report several events.|The message can carry digital signatures if required by context.")]
[IsoId("_OTgzNTEy-AOSNFX-8224507")]
[DisplayName("Party Event Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyEventAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.055.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyEvtAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.055.001.01";
    
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
    /// Constructs a PartyEventAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyEventAdviceV01( BusinessLetter1 reqHeader,EventDescription1 reqEventNotice )
    {
        Header = reqHeader;
        EventNotice = reqEventNotice;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics that unambiguously identify the event, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNTEz-AOSNFX-8224507")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BusinessLetter1 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BusinessLetter1 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessLetter1 Header { get; init; } 
    #else
    public BusinessLetter1 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the event.
    /// </summary>
    [IsoId("_OTgzNTE0-AOSNFX-8224507")]
    [DisplayName("Event Notice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtNtce")]
    #endif
    [IsoXmlTag("EvtNtce")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EventDescription1 EventNotice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EventDescription1 EventNotice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventDescription1 EventNotice { get; init; } 
    #else
    public EventDescription1 EventNotice { get; set; } 
    #endif
    
    /// <summary>
    /// Number of events as control value.
    /// </summary>
    [IsoId("_OTgzNTE1-AOSNFX-8224507")]
    [DisplayName("Event Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtCnt")]
    #endif
    [IsoXmlTag("EvtCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? EventCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EventCount { get; init; } 
    #else
    public System.String? EventCount { get; set; } 
    #endif
    
    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNTE2-AOSNFX-8224507")]
    [DisplayName("Attached Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttchdMsg")]
    #endif
    [IsoXmlTag("AttchdMsg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; } 
    #else
    public EncapsulatedBusinessMessage1? AttachedMessage { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since PartyEventAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PartyEventAdviceV01.

