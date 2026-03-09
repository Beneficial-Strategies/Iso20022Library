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
/// Room details
/// </summary>
[IsoId("_kVNgxfcTEeiW-auGnDPZIw")]
[DisplayName("Lodging Room")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LodgingRoom1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of room (for example, club/lounge level room). 
    /// </summary>
    [IsoId("_kVNgxvcTEeiW-auGnDPZIw")]
    [DisplayName("Room Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RoomTp")]
    #endif
    [IsoXmlTag("RoomTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RoomType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RoomType { get; init; } 
    #else
    public System.String? RoomType { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the room location information (for example,ocean view, lake view, level, etc.) 
    /// </summary>
    [IsoId("_kVNgx_cTEeiW-auGnDPZIw")]
    [DisplayName("Room Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RoomLctn")]
    #endif
    [IsoXmlTag("RoomLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RoomLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RoomLocation { get; init; } 
    #else
    public System.String? RoomLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Contain the type of bed in room (for example, single, double, king, etc.) 
    /// </summary>
    [IsoId("_kVNgyfcTEeiW-auGnDPZIw")]
    [DisplayName("Bed Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BedTp")]
    #endif
    [IsoXmlTag("BedTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? BedType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BedType { get; init; } 
    #else
    public System.String? BedType { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the number of guests in the room. 
    /// </summary>
    [IsoId("_kVNgyPcTEeiW-auGnDPZIw")]
    [DisplayName("Guests Per Room")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GstsPerRoom")]
    #endif
    [IsoXmlTag("GstsPerRoom")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? GuestsPerRoom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GuestsPerRoom { get; init; } 
    #else
    public System.String? GuestsPerRoom { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the number of adult guests in the room. 
    /// </summary>
    [IsoId("_hpN_IfcUEeiW-auGnDPZIw")]
    [DisplayName("Adults In Room")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdltsInRoom")]
    #endif
    [IsoXmlTag("AdltsInRoom")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? AdultsInRoom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdultsInRoom { get; init; } 
    #else
    public System.String? AdultsInRoom { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the number of child guests in the room. 
    /// </summary>
    [IsoId("_oUeWMfcUEeiW-auGnDPZIw")]
    [DisplayName("Children In Room")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChldrnInRoom")]
    #endif
    [IsoXmlTag("ChldrnInRoom")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? ChildrenInRoom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ChildrenInRoom { get; init; } 
    #else
    public System.String? ChildrenInRoom { get; set; } 
    #endif
    
    /// <summary>
    /// Daily rate being charged for the room.
    /// </summary>
    [IsoId("_aCzx8PcVEeiW-auGnDPZIw")]
    [DisplayName("Daily Room Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DalyRoomRate")]
    #endif
    [IsoXmlTag("DalyRoomRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? DailyRoomRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? DailyRoomRate { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? DailyRoomRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
