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
/// This record is an implementation of the camt.071.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DeleteStandingOrder message is sent by the system member to delete one or more standing orders within the static data held by the system transaction administrator.
/// </summary>
[Description(@"The DeleteStandingOrder message is sent by the system member to delete one or more standing orders within the static data held by the system transaction administrator.")]
[IsoId("_ThNX09b6Eeq_l4BJLVUF2Q")]
[DisplayName("Delete Standing Order V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeleteStandingOrderV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.071.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DelStgOrdr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.071.001.04";
    
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
    /// Constructs a DeleteStandingOrderV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeleteStandingOrderV04( MessageHeader1 reqMessageHeader,StandingOrderOrAll3Choice_ reqStandingOrderDetails )
    {
        MessageHeader = reqMessageHeader;
        StandingOrderDetails = reqStandingOrderDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_ThNX29b6Eeq_l4BJLVUF2Q")]
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
    /// Identifies one particular limit set by the member and managed by the transaction administrator.
    /// </summary>
    [IsoId("_ThNX3db6Eeq_l4BJLVUF2Q")]
    [DisplayName("Standing Order Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgOrdrDtls")]
    #endif
    [IsoXmlTag("StgOrdrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StandingOrderOrAll3Choice_ StandingOrderDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StandingOrderOrAll3Choice_ StandingOrderDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingOrderOrAll3Choice_ StandingOrderDetails { get; init; } 
    #else
    public StandingOrderOrAll3Choice_ StandingOrderDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ThNX39b6Eeq_l4BJLVUF2Q")]
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


// Since DeleteStandingOrderV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DeleteStandingOrderV04.

