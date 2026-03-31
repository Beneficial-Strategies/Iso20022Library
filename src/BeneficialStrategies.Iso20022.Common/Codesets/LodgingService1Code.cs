// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of lodging service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uwes0GMtEeexSYCBvAp_qA")]
[Description(@"Type of lodging service.")]
[DerivedFrom(typeof(LodgingServiceCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<LodgingService1Code>))]
#endif
public enum LodgingService1Code
{
    /// <summary>
    /// Room accommodation
    /// Encoded/decoded by serializers as &quot;ACCO&quot;.
    /// </summary>
    [EnumMember(Value = "ACCO")]
    [IsoId("_y7qT0WMtEeexSYCBvAp_qA")]
    [Description(@"Room accommodation")]
    Accommodation = LodgingServiceCode.Accommodation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Audio visual lodging service.
    /// Encoded/decoded by serializers as &quot;AUDI&quot;.
    /// </summary>
    [EnumMember(Value = "AUDI")]
    [IsoId("_zM08UmMtEeexSYCBvAp_qA")]
    [Description(@"Audio visual lodging service.")]
    AudioVisual = LodgingServiceCode.AudioVisual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Banquet lodging service.
    /// Encoded/decoded by serializers as &quot;BANQ&quot;.
    /// </summary>
    [EnumMember(Value = "BANQ")]
    [IsoId("_zbOksmMtEeexSYCBvAp_qA")]
    [Description(@"Banquet lodging service.")]
    Banquet = LodgingServiceCode.Banquet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Breakfast lodging service.
    /// Encoded/decoded by serializers as &quot;BREK&quot;.
    /// </summary>
    [EnumMember(Value = "BREK")]
    [IsoId("_zoAccmMtEeexSYCBvAp_qA")]
    [Description(@"Breakfast lodging service.")]
    Breakfast = LodgingServiceCode.Breakfast, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Business centre lodging service.
    /// Encoded/decoded by serializers as &quot;BUSS&quot;.
    /// </summary>
    [EnumMember(Value = "BUSS")]
    [IsoId("_z1EoEmMtEeexSYCBvAp_qA")]
    [Description(@"Business centre lodging service.")]
    BusinessCentre = LodgingServiceCode.BusinessCentre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Concierge lodging service.
    /// Encoded/decoded by serializers as &quot;CONC&quot;.
    /// </summary>
    [EnumMember(Value = "CONC")]
    [IsoId("_0BX-smMtEeexSYCBvAp_qA")]
    [Description(@"Concierge lodging service.")]
    Concierge = LodgingServiceCode.Concierge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Early arrival lodging service.
    /// Encoded/decoded by serializers as &quot;EARA&quot;.
    /// </summary>
    [EnumMember(Value = "EARA")]
    [IsoId("_0TUqUmMtEeexSYCBvAp_qA")]
    [Description(@"Early arrival lodging service.")]
    EarlyArrival = LodgingServiceCode.EarlyArrival, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Early departure lodging service.
    /// Encoded/decoded by serializers as &quot;EARD&quot;.
    /// </summary>
    [EnumMember(Value = "EARD")]
    [IsoId("_0mfd8mMtEeexSYCBvAp_qA")]
    [Description(@"Early departure lodging service.")]
    EarlyDeparture = LodgingServiceCode.EarlyDeparture, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entertainment lodging service.
    /// Encoded/decoded by serializers as &quot;ENTR&quot;.
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_05LwcmMtEeexSYCBvAp_qA")]
    [Description(@"Entertainment lodging service.")]
    Entertainment = LodgingServiceCode.Entertainment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Folio cash advance lodging service.
    /// Encoded/decoded by serializers as &quot;FCAA&quot;.
    /// </summary>
    [EnumMember(Value = "FCAA")]
    [IsoId("_1IohsmMtEeexSYCBvAp_qA")]
    [Description(@"Folio cash advance lodging service.")]
    FolioCashAdvance = LodgingServiceCode.FolioCashAdvance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Games lodging service.
    /// Encoded/decoded by serializers as &quot;GAME&quot;.
    /// </summary>
    [EnumMember(Value = "GAME")]
    [IsoId("_1Xy_EmMtEeexSYCBvAp_qA")]
    [Description(@"Games lodging service.")]
    Games = LodgingServiceCode.Games, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Garage lodging service.
    /// Encoded/decoded by serializers as &quot;GARA&quot;.
    /// </summary>
    [EnumMember(Value = "GARA")]
    [IsoId("_1nJpsmMtEeexSYCBvAp_qA")]
    [Description(@"Garage lodging service.")]
    Garage = LodgingServiceCode.Garage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gift shop lodging service.
    /// Encoded/decoded by serializers as &quot;GIFT&quot;.
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_1zdAUmMtEeexSYCBvAp_qA")]
    [Description(@"Gift shop lodging service.")]
    GiftShop = LodgingServiceCode.GiftShop, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Health lodging service.
    /// Encoded/decoded by serializers as &quot;HEAL&quot;.
    /// </summary>
    [EnumMember(Value = "HEAL")]
    [IsoId("_1-5bUmMtEeexSYCBvAp_qA")]
    [Description(@"Health lodging service.")]
    Health = LodgingServiceCode.Health, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Internet lodging service.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_2saBkmMtEeexSYCBvAp_qA")]
    [Description(@"Internet lodging service.")]
    Internet = LodgingServiceCode.Internet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Laundry lodging service.
    /// Encoded/decoded by serializers as &quot;LAUN&quot;.
    /// </summary>
    [EnumMember(Value = "LAUN")]
    [IsoId("_25L5UmMtEeexSYCBvAp_qA")]
    [Description(@"Laundry lodging service.")]
    Laundry = LodgingServiceCode.Laundry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Lounge bar lodging service.
    /// Encoded/decoded by serializers as &quot;LONG&quot;.
    /// </summary>
    [EnumMember(Value = "LONG")]
    [IsoId("_3HroUmMtEeexSYCBvAp_qA")]
    [Description(@"Lounge bar lodging service.")]
    LoungeBar = LodgingServiceCode.LoungeBar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mini bar lodging service.
    /// Encoded/decoded by serializers as &quot;MINI&quot;.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_3Vgo8mMtEeexSYCBvAp_qA")]
    [Description(@"Mini bar lodging service.")]
    MiniBar = LodgingServiceCode.MiniBar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No show lodging service.
    /// Encoded/decoded by serializers as &quot;NOSH&quot;.
    /// </summary>
    [EnumMember(Value = "NOSH")]
    [IsoId("_3slsMmMtEeexSYCBvAp_qA")]
    [Description(@"No show lodging service.")]
    NoShow = LodgingServiceCode.NoShow, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of service.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_4AnbcmMtEeexSYCBvAp_qA")]
    [Description(@"Other type of service.")]
    Other = LodgingServiceCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Parking lodging service.
    /// Encoded/decoded by serializers as &quot;PARK&quot;.
    /// </summary>
    [EnumMember(Value = "PARK")]
    [IsoId("_4LxikmMtEeexSYCBvAp_qA")]
    [Description(@"Parking lodging service.")]
    Parking = LodgingServiceCode.Parking, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Phone lodging service.
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_4YYbMmMtEeexSYCBvAp_qA")]
    [Description(@"Phone lodging service.")]
    Phone = LodgingServiceCode.Phone, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Restaurant lodging service.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_4kfkkmMtEeexSYCBvAp_qA")]
    [Description(@"Restaurant lodging service.")]
    Restaurant = LodgingServiceCode.Restaurant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Room service.
    /// Encoded/decoded by serializers as &quot;RMSE&quot;.
    /// </summary>
    [EnumMember(Value = "RMSE")]
    [IsoId("_4pvQ8WMtEeexSYCBvAp_qA")]
    [Description(@"Room service.")]
    RoomService = LodgingServiceCode.RoomService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Spa lodging service.
    /// Encoded/decoded by serializers as &quot;SPAS&quot;.
    /// </summary>
    [EnumMember(Value = "SPAS")]
    [IsoId("_5X_eEmMtEeexSYCBvAp_qA")]
    [Description(@"Spa lodging service.")]
    Spa = LodgingServiceCode.Spa, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Third-party lodging service.
    /// Encoded/decoded by serializers as &quot;THRD&quot;.
    /// </summary>
    [EnumMember(Value = "THRD")]
    [IsoId("_5o95UmMtEeexSYCBvAp_qA")]
    [Description(@"Third-party lodging service.")]
    ThirdParty = LodgingServiceCode.ThirdParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transportation lodging service.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_50UNsmMtEeexSYCBvAp_qA")]
    [Description(@"Transportation lodging service.")]
    Transportation = LodgingServiceCode.Transportation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Video on demand lodging service.
    /// Encoded/decoded by serializers as &quot;VODS&quot;.
    /// </summary>
    [EnumMember(Value = "VODS")]
    [IsoId("_6AzxkmMtEeexSYCBvAp_qA")]
    [Description(@"Video on demand lodging service.")]
    VideoOnDemand = LodgingServiceCode.VideoOnDemand, // same ordinal as derivation source for type conversions
}
