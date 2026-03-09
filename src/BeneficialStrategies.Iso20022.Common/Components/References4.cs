// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements for the identification of the message and related references.
/// </summary>
[IsoId("_Qn9899p-Ed-ak6NoX_4Aeg_-250058534")]
[DisplayName("References")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record References4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a References4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public References4( MessageIdentification1 reqMessageIdentification,MessageIdentification1 reqProcessIdentification )
    {
        MessageIdentification = reqMessageIdentification;
        ProcessIdentification = reqProcessIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies a message by a unique identifier and the date and time when the message was created by the sender.
    /// </summary>
    [IsoId("_Qn98-Np-Ed-ak6NoX_4Aeg_1903788067")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a process by a unique identifier and the date and time when the first message belonging to the process was created by the sender. The process identification remains the same in all messages belonging to the same process, from the initial request message to the final account report closing the process.
    /// </summary>
    [IsoId("_QoHt8Np-Ed-ak6NoX_4Aeg_1445785286")]
    [DisplayName("Process Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcId")]
    #endif
    [IsoXmlTag("PrcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 ProcessIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 ProcessIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 ProcessIdentification { get; init; } 
    #else
    public MessageIdentification1 ProcessIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// File name of a document logically related to the request.
    /// </summary>
    [IsoId("_QoHt8dp-Ed-ak6NoX_4Aeg_-938129435")]
    [DisplayName("Attached Document Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttchdDocNm")]
    #endif
    [IsoXmlTag("AttchdDocNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AttachedDocumentName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AttachedDocumentName { get; init; } 
    #else
    public System.String? AttachedDocumentName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
