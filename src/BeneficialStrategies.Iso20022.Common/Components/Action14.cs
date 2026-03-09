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
/// Set of actions to be performed by the POI (Point Of Interaction) system.
/// </summary>
[IsoId("_jdDcsXG4Ee2TbaNWBpRZpQ")]
[DisplayName("Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Action14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Action14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Action14( ActionType13Code reqActionType )
    {
        ActionType = reqActionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of action to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_jjQLUXG4Ee2TbaNWBpRZpQ")]
    [DisplayName("Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnTp")]
    #endif
    [IsoXmlTag("ActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActionType13Code ActionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActionType13Code ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionType13Code ActionType { get; init; } 
    #else
    public ActionType13Code ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Message to be displayed to the cardholder or the cashier.
    /// </summary>
    [IsoId("_jjQLU3G4Ee2TbaNWBpRZpQ")]
    [DisplayName("Message To Present")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgToPres")]
    #endif
    [IsoXmlTag("MsgToPres")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage10? MessageToPresent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage10? MessageToPresent { get; init; } 
    #else
    public ActionMessage10? MessageToPresent { get; set; } 
    #endif
    
    /// <summary>
    /// Access information to reach the target host.
    /// </summary>
    [IsoId("_fNvHIHG5Ee2TbaNWBpRZpQ")]
    [DisplayName("Remote Access")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmotAccs")]
    #endif
    [IsoXmlTag("RmotAccs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetworkParameters7? RemoteAccess { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters7? RemoteAccess { get; init; } 
    #else
    public NetworkParameters7? RemoteAccess { get; set; } 
    #endif
    
    /// <summary>
    /// Definition of retry process if activation of an action fails.
    /// </summary>
    [IsoId("_FdK2oHG6Ee2TbaNWBpRZpQ")]
    [DisplayName("Retry")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rtry")]
    #endif
    [IsoXmlTag("Rtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessRetry3? Retry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessRetry3? Retry { get; init; } 
    #else
    public ProcessRetry3? Retry { get; set; } 
    #endif
    
    /// <summary>
    /// Timing condition for periodic exchanges.
    /// </summary>
    [IsoId("_o_CMoHG6Ee2TbaNWBpRZpQ")]
    [DisplayName("Time Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmCond")]
    #endif
    [IsoXmlTag("TmCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessTiming6? TimeCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessTiming6? TimeCondition { get; init; } 
    #else
    public ProcessTiming6? TimeCondition { get; set; } 
    #endif
    
    
    #nullable disable
    
}
