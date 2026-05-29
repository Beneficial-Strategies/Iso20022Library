// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of car rental activity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fInI4Uh6EfCMZJtj4J7UGQ")]
[Description(@"Type of car rental activity.")]
[DerivedFrom(typeof(CarRentalActivityCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CarRentalActivity2Code>))]
public enum CarRentalActivity2Code
{
    /// <summary>
    /// Company specialised in car sharing activities.
    /// Encoded/decoded by serializers as &quot;CARS&quot;.
    /// </summary>
    [EnumMember(Value = "CARS")]
    [IsoId("_fK5n4Uh6EfCMZJtj4J7UGQ")]
    [Description(@"Company specialised in car sharing activities.")]
    CarSharing = CarRentalActivityCode.CarSharing,

    /// <summary>
    /// Global car rental activities.
    /// Encoded/decoded by serializers as &quot;GLBL&quot;.
    /// </summary>
    [EnumMember(Value = "GLBL")]
    [IsoId("_fK5n40h6EfCMZJtj4J7UGQ")]
    [Description(@"Global car rental activities.")]
    Global = CarRentalActivityCode.Global,

    /// <summary>
    /// Individual renting a car.
    /// Encoded/decoded by serializers as &quot;INDV&quot;.
    /// </summary>
    [EnumMember(Value = "INDV")]
    [IsoId("_fK5n5Uh6EfCMZJtj4J7UGQ")]
    [Description(@"Individual renting a car.")]
    Individual = CarRentalActivityCode.Individual,

    /// <summary>
    /// Other type of car rental activity.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_fK5n7Uh6EfCMZJtj4J7UGQ")]
    [Description(@"Other type of car rental activity.")]
    Other = CarRentalActivityCode.Other,

    /// <summary>
    /// Peer to peer car rental activities.
    /// Encoded/decoded by serializers as &quot;PETP&quot;.
    /// </summary>
    [EnumMember(Value = "PETP")]
    [IsoId("_fK5n50h6EfCMZJtj4J7UGQ")]
    [Description(@"Peer to peer car rental activities.")]
    PeerToPeer = CarRentalActivityCode.PeerToPeer,
}
