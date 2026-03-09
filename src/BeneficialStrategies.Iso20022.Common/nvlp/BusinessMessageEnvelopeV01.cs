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


namespace BeneficialStrategies.Iso20022.nvlp;

/// <summary>
/// This record is an implementation of the nvlp.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The BusinessMessageEnvelope is a technical message container used to bundle a business application header with a message definition, typically to support processing or transport. It may contain and define additional data elements that apply to the message instance container.
/// </summary>
[Description(@"The BusinessMessageEnvelope is a technical message container used to bundle a business application header with a message definition, typically to support processing or transport. It may contain and define additional data elements that apply to the message instance container.")]
[IsoId("_C7O-UQJ9Ee2MF-ort1OTzA")]
[DisplayName("Business Message Envelope V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BusinessMessageEnvelopeV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "nvlp.001.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BizMsgEnvlp";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:nvlp.001.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "BizMsgEnvlp";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BusinessMessageEnvelopeV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BusinessMessageEnvelopeV01( LaxPayload reqDocument )
    {
        Document = reqDocument;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// ISO 20022 Business Application Header instance.
    /// Rule: The external schema must be an official ISO 20022 Business Application Header.
    /// </summary>
    [IsoId("_vln_FAJ9Ee2o0-v8T2Svrw")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LaxPayload? Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LaxPayload? Header { get; init; } 
    #else
    public LaxPayload? Header { get; set; } 
    #endif
    
    /// <summary>
    /// ISO 20022 Message Definition instance.
    /// Rule: The external schema must be an official ISO 20022 Message Definition.
    /// </summary>
    [IsoId("_vln_FQJ9Ee2o0-v8T2Svrw")]
    [DisplayName("Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Doc")]
    #endif
    [IsoXmlTag("Doc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LaxPayload Document { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LaxPayload Document { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LaxPayload Document { get; init; } 
    #else
    public LaxPayload Document { get; set; } 
    #endif
    
    /// <summary>
    /// Reference related to the delivery of the business message whilst in transit from sending to receiving business application.
    /// </summary>
    [IsoId("_vln_FgJ9Ee2o0-v8T2Svrw")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reference22? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reference22? Reference { get; init; } 
    #else
    public Reference22? Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_vln_FwJ9Ee2o0-v8T2Svrw")]
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


// Since BusinessMessageEnvelopeV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BusinessMessageEnvelopeV01.

