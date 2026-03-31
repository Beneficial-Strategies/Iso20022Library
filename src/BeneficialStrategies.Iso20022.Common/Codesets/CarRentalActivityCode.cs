// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Activity type assigned to a car rental company.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_S_0LwFyqEeeve7Je9cXtkQ")]
[Description(@"Activity type assigned to a car rental company.")]
[Derivations(typeof(CarRentalActivity1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CarRentalActivityCode>))]
#endif
public enum CarRentalActivityCode
{
    /// <summary>
    /// Company specialised in car sharing activities.
    /// Encoded/decoded by serializers as &quot;CARS&quot;.
    /// </summary>
    [EnumMember(Value = "CARS")]
    [IsoId("_cjkZ8FyqEeeve7Je9cXtkQ")]
    [Description(@"Company specialised in car sharing activities.")]
    CarSharing,

    /// <summary>
    /// Global car rental activities.
    /// Encoded/decoded by serializers as &quot;GLBL&quot;.
    /// </summary>
    [EnumMember(Value = "GLBL")]
    [IsoId("_9x18sFyqEeeve7Je9cXtkQ")]
    [Description(@"Global car rental activities.")]
    Global,

    /// <summary>
    /// Individual renting a car.
    /// Encoded/decoded by serializers as &quot;INDV&quot;.
    /// </summary>
    [EnumMember(Value = "INDV")]
    [IsoId("_DkIrcFyrEeeve7Je9cXtkQ")]
    [Description(@"Individual renting a car.")]
    Individual,

    /// <summary>
    /// Peer to peer car rental activities.
    /// Encoded/decoded by serializers as &quot;PETP&quot;.
    /// </summary>
    [EnumMember(Value = "PETP")]
    [IsoId("_JWJGUFyrEeeve7Je9cXtkQ")]
    [Description(@"Peer to peer car rental activities.")]
    PeerToPeer,

    /// <summary>
    /// Other type of car rental activity.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vyq4cFyrEeeve7Je9cXtkQ")]
    [Description(@"Other type of car rental activity.")]
    Other,

    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_wGMFYPSrEeife6veM7daYw")]
    [Description(@"Other National")]
    OtherNational,

    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_zQjIkPSrEeife6veM7daYw")]
    [Description(@"Other Private")]
    OtherPrivate,
}
