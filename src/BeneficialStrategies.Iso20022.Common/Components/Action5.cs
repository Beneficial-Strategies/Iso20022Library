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
/// Set of actions to be performed by the card acceptor.
/// </summary>
[IsoId("_6jOVEYqFEeSRT5rEzcAHEw")]
[DisplayName("Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Action5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Action5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Action5( ActionType6Code reqActionType )
    {
        ActionType = reqActionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of action to be performed by the card acceptor.
    /// </summary>
    [IsoId("_6v44EYqFEeSRT5rEzcAHEw")]
    [DisplayName("Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnTp")]
    #endif
    [IsoXmlTag("ActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActionType6Code ActionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActionType6Code ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionType6Code ActionType { get; init; } 
    #else
    public ActionType6Code ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Information to display, print or log.
    /// </summary>
    [IsoId("_6v44E4qFEeSRT5rEzcAHEw")]
    [DisplayName("Message To Present")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgToPres")]
    #endif
    [IsoXmlTag("MsgToPres")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage4? MessageToPresent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage4? MessageToPresent { get; init; } 
    #else
    public ActionMessage4? MessageToPresent { get; set; } 
    #endif
    
    /// <summary>
    /// Message to send before the completion of the transaction.
    /// </summary>
    [IsoId("_0HeSQIqIEeSRT5rEzcAHEw")]
    [DisplayName("Request To Perform")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqToPrfrm")]
    #endif
    [IsoXmlTag("ReqToPrfrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageFunction7Code? RequestToPerform { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageFunction7Code? RequestToPerform { get; init; } 
    #else
    public MessageFunction7Code? RequestToPerform { get; set; } 
    #endif
    
    
    #nullable disable
    
}
