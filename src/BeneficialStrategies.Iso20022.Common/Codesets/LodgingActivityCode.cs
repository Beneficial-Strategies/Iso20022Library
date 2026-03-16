// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of lodging activity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_U7-5MGMbEeexSYCBvAp_qA")]
[Description(@"Type of lodging activity.")]
[Derivations(typeof(LodgingActivity1Code))]
public enum LodgingActivityCode
{
    /// <summary>
    /// Apartment residence.
    /// Encoded/decoded by serializers as &quot;APTM&quot;.
    /// </summary>
    [EnumMember(Value = "APTM")]
    [IsoId("_ZdiY0GMbEeexSYCBvAp_qA")]
    [Description(@"Apartment residence.")]
    Apartment,

    /// <summary>
    /// Bed and breakfast or related lodging.
    /// Encoded/decoded by serializers as &quot;BEBR&quot;.
    /// </summary>
    [EnumMember(Value = "BEBR")]
    [IsoId("_e4lFMGMbEeexSYCBvAp_qA")]
    [Description(@"Bed and breakfast or related lodging.")]
    BedAndBreakfast,

    /// <summary>
    /// Cruise line lodging.
    /// Encoded/decoded by serializers as &quot;CRUI&quot;.
    /// </summary>
    [EnumMember(Value = "CRUI")]
    [IsoId("_ngUXEGMbEeexSYCBvAp_qA")]
    [Description(@"Cruise line lodging.")]
    Cruise,

    /// <summary>
    /// Hotel or related lodging.
    /// Encoded/decoded by serializers as &quot;HOTL&quot;.
    /// </summary>
    [EnumMember(Value = "HOTL")]
    [IsoId("_twxogGMbEeexSYCBvAp_qA")]
    [Description(@"Hotel or related lodging.")]
    Hotel,

    /// <summary>
    /// Motel or related lodging.
    /// Encoded/decoded by serializers as &quot;MOTL&quot;.
    /// </summary>
    [EnumMember(Value = "MOTL")]
    [IsoId("_xJkJQGMbEeexSYCBvAp_qA")]
    [Description(@"Motel or related lodging.")]
    Motel,

    /// <summary>
    /// Hostel or related lodging.
    /// Encoded/decoded by serializers as &quot;HOST&quot;.
    /// </summary>
    [EnumMember(Value = "HOST")]
    [IsoId("_05ILQGMbEeexSYCBvAp_qA")]
    [Description(@"Hostel or related lodging.")]
    Hostel,

    /// <summary>
    /// Cottage and related lodging.
    /// Encoded/decoded by serializers as &quot;COTT&quot;.
    /// </summary>
    [EnumMember(Value = "COTT")]
    [IsoId("_NBeEQGMcEeexSYCBvAp_qA")]
    [Description(@"Cottage and related lodging.")]
    Cottage,

    /// <summary>
    /// Lodge or related lodging.
    /// Encoded/decoded by serializers as &quot;LODG&quot;.
    /// </summary>
    [EnumMember(Value = "LODG")]
    [IsoId("_P_ulIGMcEeexSYCBvAp_qA")]
    [Description(@"Lodge or related lodging.")]
    Lodge,

    /// <summary>
    /// Room and board or related lodging.
    /// Encoded/decoded by serializers as &quot;ROAB&quot;.
    /// </summary>
    [EnumMember(Value = "ROAB")]
    [IsoId("_TzZEAGMcEeexSYCBvAp_qA")]
    [Description(@"Room and board or related lodging.")]
    RoomAndBoard,

    /// <summary>
    /// Tourist shelter and related lodging.
    /// Encoded/decoded by serializers as &quot;TOSH&quot;.
    /// </summary>
    [EnumMember(Value = "TOSH")]
    [IsoId("_bDIBIGMcEeexSYCBvAp_qA")]
    [Description(@"Tourist shelter and related lodging.")]
    TouristShelter,

    /// <summary>
    /// An individual offering lodging facilities.
    /// Encoded/decoded by serializers as &quot;HOME&quot;.
    /// </summary>
    [EnumMember(Value = "HOME")]
    [IsoId("_hN3sIGMcEeexSYCBvAp_qA")]
    [Description(@"An individual offering lodging facilities.")]
    Home,

    /// <summary>
    /// Other type of lodging defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_oDoDAGMcEeexSYCBvAp_qA")]
    [Description(@"Other type of lodging defined at national level.")]
    OtherNational,

    /// <summary>
    /// Other type of lodging defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_vHtJwGMcEeexSYCBvAp_qA")]
    [Description(@"Other type of lodging defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// Resort or related lodging.
    /// Encoded/decoded by serializers as &quot;RESO&quot;.
    /// </summary>
    [EnumMember(Value = "RESO")]
    [IsoId("_1laNAGMcEeexSYCBvAp_qA")]
    [Description(@"Resort or related lodging.")]
    Resort,
}
