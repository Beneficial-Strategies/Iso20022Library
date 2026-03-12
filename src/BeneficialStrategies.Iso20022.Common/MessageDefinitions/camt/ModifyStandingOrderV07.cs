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
/// This record is an implementation of the camt.024.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ModifyStandingOrder message is sent by a member to the transaction administrator.
/// It is used to request a change in the features of a permanent order for the transfer of funds between two accounts belonging to the same member and being held at the transaction administrator.
/// Usage
/// There should be one standing order per (direct) member and per business day. The ModifyStandingOrder message must not be used to request a transfer of funds between accounts during the working day. The liquidity transfer messages must be used for this purpose. There is no need to have a standing order to empty the settlement account at the end of the day and transfer the funds to the current account. For liquidity savings purposes, systems will effect the necessary transfers automatically when and where relevant.
/// The ModifyStandingOrder message first identifies the standing order to be modified and then provide the details of the new standing order. The elements that can be modified are:
/// - amount
/// - account to be credited
/// - account to be debited
/// - account owner (for on behalf scenario)
/// - frequency of payment
/// - daytime or overnight processing
/// - dates when the standing order begins and ceases to be effective
/// Based on the criteria received within the ModifyStandingOrder message, the transaction administrator will execute or reject the requested modifications.
/// The transaction administrator may send a Receipt message as a reply to the Modify Standing Order request. To verify the outcome of the request, the member may submit a GetStandingOrder message with the appropriate search criteria.
/// </summary>
[Description(@"Scope|The ModifyStandingOrder message is sent by a member to the transaction administrator.|It is used to request a change in the features of a permanent order for the transfer of funds between two accounts belonging to the same member and being held at the transaction administrator.|Usage|There should be one standing order per (direct) member and per business day. The ModifyStandingOrder message must not be used to request a transfer of funds between accounts during the working day. The liquidity transfer messages must be used for this purpose. There is no need to have a standing order to empty the settlement account at the end of the day and transfer the funds to the current account. For liquidity savings purposes, systems will effect the necessary transfers automatically when and where relevant.|The ModifyStandingOrder message first identifies the standing order to be modified and then provide the details of the new standing order. The elements that can be modified are:|- amount|- account to be credited|- account to be debited|- account owner (for on behalf scenario)|- frequency of payment|- daytime or overnight processing|- dates when the standing order begins and ceases to be effective|Based on the criteria received within the ModifyStandingOrder message, the transaction administrator will execute or reject the requested modifications.|The transaction administrator may send a Receipt message as a reply to the Modify Standing Order request. To verify the outcome of the request, the member may submit a GetStandingOrder message with the appropriate search criteria.")]
[IsoId("_ThUsj9b6Eeq_l4BJLVUF2Q")]
[DisplayName("Modify Standing Order V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ModifyStandingOrderV07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.024.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ModfyStgOrdr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.024.001.07";
    
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
    /// Constructs a ModifyStandingOrderV07 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ModifyStandingOrderV07( MessageHeader1 reqMessageHeader,StandingOrderIdentification6 reqStandingOrderIdentification,StandingOrder8 reqNewStandingOrderValueSet )
    {
        MessageHeader = reqMessageHeader;
        StandingOrderIdentification = reqStandingOrderIdentification;
        NewStandingOrderValueSet = reqNewStandingOrderValueSet;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_ThUsl9b6Eeq_l4BJLVUF2Q")]
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
    [IsoId("_ThUsmdb6Eeq_l4BJLVUF2Q")]
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
    /// New set of values for the standing order.
    /// </summary>
    [IsoId("_ThUsm9b6Eeq_l4BJLVUF2Q")]
    [DisplayName("New Standing Order Value Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewStgOrdrValSet")]
    #endif
    [IsoXmlTag("NewStgOrdrValSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StandingOrder8 NewStandingOrderValueSet { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StandingOrder8 NewStandingOrderValueSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingOrder8 NewStandingOrderValueSet { get; init; } 
    #else
    public StandingOrder8 NewStandingOrderValueSet { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ThUsndb6Eeq_l4BJLVUF2Q")]
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


// Since ModifyStandingOrderV07Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ModifyStandingOrderV07.

