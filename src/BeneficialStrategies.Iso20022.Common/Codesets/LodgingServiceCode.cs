// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of lodging service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qaX6IGMrEeexSYCBvAp_qA")]
[Description(@"Type of lodging service.")]
[Derivations(typeof(LodgingService1Code))]
public enum LodgingServiceCode
{
    /// <summary>
    /// Room accommodation
    /// Encoded/decoded by serializers as &quot;ACCO&quot;.
    /// </summary>
    [EnumMember(Value = "ACCO")]
    [IsoId("_yTjc4GMrEeexSYCBvAp_qA")]
    [Description(@"Room accommodation")]
    Accommodation,
    
    /// <summary>
    /// Audio visual lodging service.
    /// Encoded/decoded by serializers as &quot;AUDI&quot;.
    /// </summary>
    [EnumMember(Value = "AUDI")]
    [IsoId("_2n3xwGMrEeexSYCBvAp_qA")]
    [Description(@"Audio visual lodging service.")]
    AudioVisual,
    
    /// <summary>
    /// Banquet lodging service.
    /// Encoded/decoded by serializers as &quot;BANQ&quot;.
    /// </summary>
    [EnumMember(Value = "BANQ")]
    [IsoId("_6H1RgGMrEeexSYCBvAp_qA")]
    [Description(@"Banquet lodging service.")]
    Banquet,
    
    /// <summary>
    /// Breakfast lodging service.
    /// Encoded/decoded by serializers as &quot;BREK&quot;.
    /// </summary>
    [EnumMember(Value = "BREK")]
    [IsoId("_8aB9oGMrEeexSYCBvAp_qA")]
    [Description(@"Breakfast lodging service.")]
    Breakfast,
    
    /// <summary>
    /// Business centre lodging service.
    /// Encoded/decoded by serializers as &quot;BUSS&quot;.
    /// </summary>
    [EnumMember(Value = "BUSS")]
    [IsoId("__YkyYGMrEeexSYCBvAp_qA")]
    [Description(@"Business centre lodging service.")]
    BusinessCentre,
    
    /// <summary>
    /// Concierge lodging service.
    /// Encoded/decoded by serializers as &quot;CONC&quot;.
    /// </summary>
    [EnumMember(Value = "CONC")]
    [IsoId("_C5lbAGMsEeexSYCBvAp_qA")]
    [Description(@"Concierge lodging service.")]
    Concierge,
    
    /// <summary>
    /// Early arrival lodging service.
    /// Encoded/decoded by serializers as &quot;EARA&quot;.
    /// </summary>
    [EnumMember(Value = "EARA")]
    [IsoId("_FeMFwGMsEeexSYCBvAp_qA")]
    [Description(@"Early arrival lodging service.")]
    EarlyArrival,
    
    /// <summary>
    /// Early departure lodging service.
    /// Encoded/decoded by serializers as &quot;EARD&quot;.
    /// </summary>
    [EnumMember(Value = "EARD")]
    [IsoId("_IuYEIGMsEeexSYCBvAp_qA")]
    [Description(@"Early departure lodging service.")]
    EarlyDeparture,
    
    /// <summary>
    /// Entertainment lodging service.
    /// Encoded/decoded by serializers as &quot;ENTR&quot;.
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_N1sjQGMsEeexSYCBvAp_qA")]
    [Description(@"Entertainment lodging service.")]
    Entertainment,
    
    /// <summary>
    /// Folio cash advance lodging service.
    /// Encoded/decoded by serializers as &quot;FCAA&quot;.
    /// </summary>
    [EnumMember(Value = "FCAA")]
    [IsoId("_RVQaYGMsEeexSYCBvAp_qA")]
    [Description(@"Folio cash advance lodging service.")]
    FolioCashAdvance,
    
    /// <summary>
    /// Games lodging service.
    /// Encoded/decoded by serializers as &quot;GAME&quot;.
    /// </summary>
    [EnumMember(Value = "GAME")]
    [IsoId("_YKWC4GMsEeexSYCBvAp_qA")]
    [Description(@"Games lodging service.")]
    Games,
    
    /// <summary>
    /// Garage lodging service.
    /// Encoded/decoded by serializers as &quot;GARA&quot;.
    /// </summary>
    [EnumMember(Value = "GARA")]
    [IsoId("_bK6Q4GMsEeexSYCBvAp_qA")]
    [Description(@"Garage lodging service.")]
    Garage,
    
    /// <summary>
    /// Gift shop lodging service.
    /// Encoded/decoded by serializers as &quot;GIFT&quot;.
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_dphoYGMsEeexSYCBvAp_qA")]
    [Description(@"Gift shop lodging service.")]
    GiftShop,
    
    /// <summary>
    /// Health lodging service.
    /// Encoded/decoded by serializers as &quot;HEAL&quot;.
    /// </summary>
    [EnumMember(Value = "HEAL")]
    [IsoId("_gPXpQGMsEeexSYCBvAp_qA")]
    [Description(@"Health lodging service.")]
    Health,
    
    /// <summary>
    /// Internet lodging service.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_j7No4GMsEeexSYCBvAp_qA")]
    [Description(@"Internet lodging service.")]
    Internet,
    
    /// <summary>
    /// Laundry lodging service.
    /// Encoded/decoded by serializers as &quot;LAUN&quot;.
    /// </summary>
    [EnumMember(Value = "LAUN")]
    [IsoId("_xgPUIGMsEeexSYCBvAp_qA")]
    [Description(@"Laundry lodging service.")]
    Laundry,
    
    /// <summary>
    /// Lounge bar lodging service.
    /// Encoded/decoded by serializers as &quot;LONG&quot;.
    /// </summary>
    [EnumMember(Value = "LONG")]
    [IsoId("_01xFgGMsEeexSYCBvAp_qA")]
    [Description(@"Lounge bar lodging service.")]
    LoungeBar,
    
    /// <summary>
    /// Mini bar lodging service.
    /// Encoded/decoded by serializers as &quot;MINI&quot;.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_4DtBIGMsEeexSYCBvAp_qA")]
    [Description(@"Mini bar lodging service.")]
    MiniBar,
    
    /// <summary>
    /// No show lodging service.
    /// Encoded/decoded by serializers as &quot;NOSH&quot;.
    /// </summary>
    [EnumMember(Value = "NOSH")]
    [IsoId("_7ZdcAGMsEeexSYCBvAp_qA")]
    [Description(@"No show lodging service.")]
    NoShow,
    
    /// <summary>
    /// Parking lodging service.
    /// Encoded/decoded by serializers as &quot;PARK&quot;.
    /// </summary>
    [EnumMember(Value = "PARK")]
    [IsoId("_CdLWYWMtEeexSYCBvAp_qA")]
    [Description(@"Parking lodging service.")]
    Parking,
    
    /// <summary>
    /// Phone lodging service.
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_F0a_AGMtEeexSYCBvAp_qA")]
    [Description(@"Phone lodging service.")]
    Phone,
    
    /// <summary>
    /// Restaurant lodging service.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_J2NZcGMtEeexSYCBvAp_qA")]
    [Description(@"Restaurant lodging service.")]
    Restaurant,
    
    /// <summary>
    /// Room lodging service.
    /// Encoded/decoded by serializers as &quot;ROOM&quot;.
    /// </summary>
    [EnumMember(Value = "ROOM")]
    [IsoId("_ONuzUGMtEeexSYCBvAp_qA")]
    [Description(@"Room lodging service.")]
    Room,
    
    /// <summary>
    /// Spa lodging service.
    /// Encoded/decoded by serializers as &quot;SPAS&quot;.
    /// </summary>
    [EnumMember(Value = "SPAS")]
    [IsoId("_Q9flMGMtEeexSYCBvAp_qA")]
    [Description(@"Spa lodging service.")]
    Spa,
    
    /// <summary>
    /// Third-party lodging service.
    /// Encoded/decoded by serializers as &quot;THRD&quot;.
    /// </summary>
    [EnumMember(Value = "THRD")]
    [IsoId("_UcYt8GMtEeexSYCBvAp_qA")]
    [Description(@"Third-party lodging service.")]
    ThirdParty,
    
    /// <summary>
    /// Transportation lodging service.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_cvcwUGMtEeexSYCBvAp_qA")]
    [Description(@"Transportation lodging service.")]
    Transportation,
    
    /// <summary>
    /// Video on demand lodging service.
    /// Encoded/decoded by serializers as &quot;VODS&quot;.
    /// </summary>
    [EnumMember(Value = "VODS")]
    [IsoId("_jVxkEGMtEeexSYCBvAp_qA")]
    [Description(@"Video on demand lodging service.")]
    VideoOnDemand,
    
    /// <summary>
    /// Other type of service.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_qBsCcWMtEeexSYCBvAp_qA")]
    [Description(@"Other type of service.")]
    Other,
    
    /// <summary>
    /// Room service.
    /// Encoded/decoded by serializers as &quot;RMSE&quot;.
    /// </summary>
    [EnumMember(Value = "RMSE")]
    [IsoId("_BM6QQJdDEeme5LKU36W8xA")]
    [Description(@"Room service.")]
    RoomService,
    
}
