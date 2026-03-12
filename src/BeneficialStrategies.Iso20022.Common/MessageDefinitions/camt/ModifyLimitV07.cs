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
/// This record is an implementation of the camt.011.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|The ModifyLimit message is sent by a member to the transaction administrator.|It is used to request modifications in the details of one particular, several or all limits set by the member and managed by the transaction administrator.|Each ModifyLimit message can alter only one type of limit (current or default).|Usage|At any time during the operating hours of the system, the member can request modifications in the limits it has set. For example, the reason may be to unlock the payments queue regarding a particular member, or following a risk management decision issued after an exceptional event has occurred.|The member will submit a message requesting modifications in one or more of the following criteria: |- type of limit (current/default)|- identification of the system|- identification of the counterparty|- value of the limit(s) (default and/or current limit(s))|- point in time when the limit becomes effective|Based on the criteria received within the ModifyLimit message, the transaction administrator will execute or reject the requested modification. The transaction administrator may send a Receipt message as a reply to the ModifyLimit request. To verify the outcome of the request, the member may submit a GetLimit message with the appropriate search criteria.
/// </summary>
[Description(@"Scope|The ModifyLimit message is sent by a member to the transaction administrator.|It is used to request modifications in the details of one particular, several or all limits set by the member and managed by the transaction administrator.|Each ModifyLimit message can alter only one type of limit (current or default).|Usage|At any time during the operating hours of the system, the member can request modifications in the limits it has set. For example, the reason may be to unlock the payments queue regarding a particular member, or following a risk management decision issued after an exceptional event has occurred.|The member will submit a message requesting modifications in one or more of the following criteria: |- type of limit (current/default)|- identification of the system|- identification of the counterparty|- value of the limit(s) (default and/or current limit(s))|- point in time when the limit becomes effective|Based on the criteria received within the ModifyLimit message, the transaction administrator will execute or reject the requested modification. The transaction administrator may send a Receipt message as a reply to the ModifyLimit request. To verify the outcome of the request, the member may submit a GetLimit message with the appropriate search criteria.")]
[IsoId("_jwlbvxbvEeiyVv5j1vf1VQ")]
[DisplayName("Modify Limit V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ModifyLimitV07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.011.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ModfyLmt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.011.001.07";
    
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
    /// Constructs a ModifyLimitV07 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ModifyLimitV07( MessageHeader1 reqMessageHeader )
    {
        MessageHeader = reqMessageHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbwRbvEeiyVv5j1vf1VQ")]
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
    [IsoId("_jwlbwxbvEeiyVv5j1vf1VQ")]
    [DisplayName("Limit Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtDtls")]
    #endif
    [IsoXmlTag("LmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LimitStructure3? LimitDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LimitStructure3? LimitDetails { get; init; } 
    #else
    public LimitStructure3? LimitDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbxRbvEeiyVv5j1vf1VQ")]
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


// Since ModifyLimitV07Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ModifyLimitV07.

