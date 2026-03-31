// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Lodging type of activity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AWjbYGMdEeexSYCBvAp_qA")]
[Description(@"Lodging type of activity.")]
[DerivedFrom(typeof(LodgingActivityCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<LodgingActivity1Code>))]
#endif
public enum LodgingActivity1Code
{
    /// <summary>
    /// Apartment residence.
    /// Encoded/decoded by serializers as &quot;APTM&quot;.
    /// </summary>
    [EnumMember(Value = "APTM")]
    [IsoId("_Dl0zwWMdEeexSYCBvAp_qA")]
    [Description(@"Apartment residence.")]
    Apartment = LodgingActivityCode.Apartment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bed and breakfast or related lodging.
    /// Encoded/decoded by serializers as &quot;BEBR&quot;.
    /// </summary>
    [EnumMember(Value = "BEBR")]
    [IsoId("_DvdQ4WMdEeexSYCBvAp_qA")]
    [Description(@"Bed and breakfast or related lodging.")]
    BedAndBreakfast = LodgingActivityCode.BedAndBreakfast, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cottage and related lodging.
    /// Encoded/decoded by serializers as &quot;COTT&quot;.
    /// </summary>
    [EnumMember(Value = "COTT")]
    [IsoId("_D6_ygWMdEeexSYCBvAp_qA")]
    [Description(@"Cottage and related lodging.")]
    Cottage = LodgingActivityCode.Cottage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cruise line lodging.
    /// Encoded/decoded by serializers as &quot;CRUI&quot;.
    /// </summary>
    [EnumMember(Value = "CRUI")]
    [IsoId("_EH_FoWMdEeexSYCBvAp_qA")]
    [Description(@"Cruise line lodging.")]
    Cruise = LodgingActivityCode.Cruise, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An individual offering lodging facilities.
    /// Encoded/decoded by serializers as &quot;HOME&quot;.
    /// </summary>
    [EnumMember(Value = "HOME")]
    [IsoId("_EP_yIWMdEeexSYCBvAp_qA")]
    [Description(@"An individual offering lodging facilities.")]
    Home = LodgingActivityCode.Home, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Hostel or related lodging.
    /// Encoded/decoded by serializers as &quot;HOST&quot;.
    /// </summary>
    [EnumMember(Value = "HOST")]
    [IsoId("_EY9g4WMdEeexSYCBvAp_qA")]
    [Description(@"Hostel or related lodging.")]
    Hostel = LodgingActivityCode.Hostel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Hotel or related lodging.
    /// Encoded/decoded by serializers as &quot;HOTL&quot;.
    /// </summary>
    [EnumMember(Value = "HOTL")]
    [IsoId("_Eh2XIWMdEeexSYCBvAp_qA")]
    [Description(@"Hotel or related lodging.")]
    Hotel = LodgingActivityCode.Hotel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Lodge or related lodging.
    /// Encoded/decoded by serializers as &quot;LODG&quot;.
    /// </summary>
    [EnumMember(Value = "LODG")]
    [IsoId("_EsVv4WMdEeexSYCBvAp_qA")]
    [Description(@"Lodge or related lodging.")]
    Lodge = LodgingActivityCode.Lodge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Motel or related lodging.
    /// Encoded/decoded by serializers as &quot;MOTL&quot;.
    /// </summary>
    [EnumMember(Value = "MOTL")]
    [IsoId("_E3f3AWMdEeexSYCBvAp_qA")]
    [Description(@"Motel or related lodging.")]
    Motel = LodgingActivityCode.Motel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of lodging defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_FAXfIWMdEeexSYCBvAp_qA")]
    [Description(@"Other type of lodging defined at national level.")]
    OtherNational = LodgingActivityCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of lodging defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_FJPHQWMdEeexSYCBvAp_qA")]
    [Description(@"Other type of lodging defined at private level.")]
    OtherPrivate = LodgingActivityCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resort or related lodging.
    /// Encoded/decoded by serializers as &quot;RESO&quot;.
    /// </summary>
    [EnumMember(Value = "RESO")]
    [IsoId("_FSGvYWMdEeexSYCBvAp_qA")]
    [Description(@"Resort or related lodging.")]
    Resort = LodgingActivityCode.Resort, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Room and board or related lodging.
    /// Encoded/decoded by serializers as &quot;ROAB&quot;.
    /// </summary>
    [EnumMember(Value = "ROAB")]
    [IsoId("_FdW9IWMdEeexSYCBvAp_qA")]
    [Description(@"Room and board or related lodging.")]
    RoomAndBoard = LodgingActivityCode.RoomAndBoard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tourist shelter and related lodging.
    /// Encoded/decoded by serializers as &quot;TOSH&quot;.
    /// </summary>
    [EnumMember(Value = "TOSH")]
    [IsoId("_FrkYQWMdEeexSYCBvAp_qA")]
    [Description(@"Tourist shelter and related lodging.")]
    TouristShelter = LodgingActivityCode.TouristShelter, // same ordinal as derivation source for type conversions
}
