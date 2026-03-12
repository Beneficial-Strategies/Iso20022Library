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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.102.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CreateStandingOrder message is sent by a member to the transaction administrator.
/// It is used to create a permanent order for the transfer of funds between two accounts belonging to the same member and being held at the transaction administrator.
/// Usage
/// Based on the criteria defined in the CreateStandingOrder message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.
/// </summary>
[Description(@"Scope|The CreateStandingOrder message is sent by a member to the transaction administrator.|It is used to create a permanent order for the transfer of funds between two accounts belonging to the same member and being held at the transaction administrator.|Usage|Based on the criteria defined in the CreateStandingOrder message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.")]
[IsoId("_ThMwvdb6Eeq_l4BJLVUF2Q")]
[DisplayName("Create Standing Order V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreateStandingOrderV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.102.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CretStgOrdr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.102.001.02";
    
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
    /// Constructs a CreateStandingOrderV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreateStandingOrderV02( MessageHeader1 reqMessageHeader,StandingOrderIdentification6 reqStandingOrderIdentification,StandingOrder8 reqValueSet )
    {
        MessageHeader = reqMessageHeader;
        StandingOrderIdentification = reqStandingOrderIdentification;
        ValueSet = reqValueSet;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_ThMww9b6Eeq_l4BJLVUF2Q")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader1 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader1 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader1 MessageHeader { get; init; } 
    #else
    public MessageHeader1 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the standing order.
    /// </summary>
    [IsoId("_ThMwxdb6Eeq_l4BJLVUF2Q")]
    [DisplayName("Standing Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgOrdrId")]
    #endif
    [IsoXmlTag("StgOrdrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StandingOrderIdentification6 StandingOrderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StandingOrderIdentification6 StandingOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingOrderIdentification6 StandingOrderIdentification { get; init; } 
    #else
    public StandingOrderIdentification6 StandingOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of values for the standing order.
    /// </summary>
    [IsoId("_ThMwx9b6Eeq_l4BJLVUF2Q")]
    [DisplayName("Value Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValSet")]
    #endif
    [IsoXmlTag("ValSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StandingOrder8 ValueSet { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StandingOrder8 ValueSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingOrder8 ValueSet { get; init; } 
    #else
    public StandingOrder8 ValueSet { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ThMwydb6Eeq_l4BJLVUF2Q")]
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


// Since CreateStandingOrderV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CreateStandingOrderV02.

