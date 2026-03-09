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
/// This record is an implementation of the camt.069.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|The GetStandingOrder message is sent by a member to the transaction administrator.|It is used to request information on the details of one or more standing orders, based on specific request criteria, especially to query the amount of the overall liquidity available. It will allow to query both reserved liquidity and liquidity available for normal operations.|Usage|The member can request information based on the following elements: |- individual standing orders (predefined or standing liquidity transfer orders)|- amount|- account to be credited|- account to be debited|- account owner (for on behalf scenario)|- frequency of payment|- daytime or overnight processing|- dates when the standing order begins and ceases to be effective|This message will be answered by a ReturnStandingOrder message.
/// </summary>
[Description(@"Scope|The GetStandingOrder message is sent by a member to the transaction administrator.|It is used to request information on the details of one or more standing orders, based on specific request criteria, especially to query the amount of the overall liquidity available. It will allow to query both reserved liquidity and liquidity available for normal operations.|Usage|The member can request information based on the following elements: |- individual standing orders (predefined or standing liquidity transfer orders)|- amount|- account to be credited|- account to be debited|- account owner (for on behalf scenario)|- frequency of payment|- daytime or overnight processing|- dates when the standing order begins and ceases to be effective|This message will be answered by a ReturnStandingOrder message.")]
[IsoId("_ThPM8db6Eeq_l4BJLVUF2Q")]
[DisplayName("Get Standing Order V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GetStandingOrderV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.069.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetStgOrdr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.069.001.04";
    
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
    /// Constructs a GetStandingOrderV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GetStandingOrderV04( MessageHeader4 reqMessageHeader )
    {
        MessageHeader = reqMessageHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_ThPM99b6Eeq_l4BJLVUF2Q")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader4 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader4 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader4 MessageHeader { get; init; } 
    #else
    public MessageHeader4 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the account query criteria.
    /// </summary>
    [IsoId("_ThPM-db6Eeq_l4BJLVUF2Q")]
    [DisplayName("Standing Order Query Definition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgOrdrQryDef")]
    #endif
    [IsoXmlTag("StgOrdrQryDef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StandingOrderQuery4? StandingOrderQueryDefinition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingOrderQuery4? StandingOrderQueryDefinition { get; init; } 
    #else
    public StandingOrderQuery4? StandingOrderQueryDefinition { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ThPM-9b6Eeq_l4BJLVUF2Q")]
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


// Since GetStandingOrderV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to GetStandingOrderV04.

