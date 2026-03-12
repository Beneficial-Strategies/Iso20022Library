// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Room details
/// </summary>
[IsoId("_kVNgxfcTEeiW-auGnDPZIw")]
[DisplayName("Lodging Room")]
public partial record LodgingRoom1
{
    #nullable enable
    
    /// <summary>
    /// Type of room (for example, club/lounge level room). 
    /// </summary>
    [IsoId("_kVNgxvcTEeiW-auGnDPZIw")]
    [DisplayName("Room Type")]
    [IsoXmlTag("RoomTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RoomType { get; init; } 
    
    /// <summary>
    /// Contains the room location information (for example,ocean view, lake view, level, etc.) 
    /// </summary>
    [IsoId("_kVNgx_cTEeiW-auGnDPZIw")]
    [DisplayName("Room Location")]
    [IsoXmlTag("RoomLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RoomLocation { get; init; } 
    
    /// <summary>
    /// Contain the type of bed in room (for example, single, double, king, etc.) 
    /// </summary>
    [IsoId("_kVNgyfcTEeiW-auGnDPZIw")]
    [DisplayName("Bed Type")]
    [IsoXmlTag("BedTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? BedType { get; init; } 
    
    /// <summary>
    /// Contains the number of guests in the room. 
    /// </summary>
    [IsoId("_kVNgyPcTEeiW-auGnDPZIw")]
    [DisplayName("Guests Per Room")]
    [IsoXmlTag("GstsPerRoom")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? GuestsPerRoom { get; init; } 
    
    /// <summary>
    /// Contains the number of adult guests in the room. 
    /// </summary>
    [IsoId("_hpN_IfcUEeiW-auGnDPZIw")]
    [DisplayName("Adults In Room")]
    [IsoXmlTag("AdltsInRoom")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? AdultsInRoom { get; init; } 
    
    /// <summary>
    /// Contains the number of child guests in the room. 
    /// </summary>
    [IsoId("_oUeWMfcUEeiW-auGnDPZIw")]
    [DisplayName("Children In Room")]
    [IsoXmlTag("ChldrnInRoom")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? ChildrenInRoom { get; init; } 
    
    /// <summary>
    /// Daily rate being charged for the room.
    /// </summary>
    [IsoId("_aCzx8PcVEeiW-auGnDPZIw")]
    [DisplayName("Daily Room Rate")]
    [IsoXmlTag("DalyRoomRate")]
    public ImpliedCurrencyAndAmount? DailyRoomRate { get; init; } 
    
    
    #nullable disable
    
}
