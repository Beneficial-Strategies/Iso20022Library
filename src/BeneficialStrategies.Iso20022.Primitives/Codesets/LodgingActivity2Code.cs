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
[IsoId("_MBnfUUh5EfCMZJtj4J7UGQ")]
[Description(@"Lodging type of activity.")]
[DerivedFrom(typeof(LodgingActivityCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<LodgingActivity2Code>))]
public enum LodgingActivity2Code
{
    /// <summary>
    /// Apartment residence.
    /// Encoded/decoded by serializers as &quot;APTM&quot;.
    /// </summary>
    [EnumMember(Value = "APTM")]
    [IsoId("_MEE9cUh5EfCMZJtj4J7UGQ")]
    [Description(@"Apartment residence.")]
    Apartment = LodgingActivityCode.Apartment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bed and breakfast or related lodging.
    /// Encoded/decoded by serializers as &quot;BEBR&quot;.
    /// </summary>
    [EnumMember(Value = "BEBR")]
    [IsoId("_MEE9c0h5EfCMZJtj4J7UGQ")]
    [Description(@"Bed and breakfast or related lodging.")]
    BedAndBreakfast = LodgingActivityCode.BedAndBreakfast, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cottage and related lodging.
    /// Encoded/decoded by serializers as &quot;COTT&quot;.
    /// </summary>
    [EnumMember(Value = "COTT")]
    [IsoId("_MEE9dUh5EfCMZJtj4J7UGQ")]
    [Description(@"Cottage and related lodging.")]
    Cottage = LodgingActivityCode.Cottage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cruise line lodging.
    /// Encoded/decoded by serializers as &quot;CRUI&quot;.
    /// </summary>
    [EnumMember(Value = "CRUI")]
    [IsoId("_MEE9d0h5EfCMZJtj4J7UGQ")]
    [Description(@"Cruise line lodging.")]
    Cruise = LodgingActivityCode.Cruise, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An individual offering lodging facilities.
    /// Encoded/decoded by serializers as &quot;HOME&quot;.
    /// </summary>
    [EnumMember(Value = "HOME")]
    [IsoId("_MEE9eUh5EfCMZJtj4J7UGQ")]
    [Description(@"An individual offering lodging facilities.")]
    Home = LodgingActivityCode.Home, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Hostel or related lodging.
    /// Encoded/decoded by serializers as &quot;HOST&quot;.
    /// </summary>
    [EnumMember(Value = "HOST")]
    [IsoId("_MEE9e0h5EfCMZJtj4J7UGQ")]
    [Description(@"Hostel or related lodging.")]
    Hostel = LodgingActivityCode.Hostel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Hotel or related lodging.
    /// Encoded/decoded by serializers as &quot;HOTL&quot;.
    /// </summary>
    [EnumMember(Value = "HOTL")]
    [IsoId("_MEE9fUh5EfCMZJtj4J7UGQ")]
    [Description(@"Hotel or related lodging.")]
    Hotel = LodgingActivityCode.Hotel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Lodge or related lodging.
    /// Encoded/decoded by serializers as &quot;LODG&quot;.
    /// </summary>
    [EnumMember(Value = "LODG")]
    [IsoId("_MEE9f0h5EfCMZJtj4J7UGQ")]
    [Description(@"Lodge or related lodging.")]
    Lodge = LodgingActivityCode.Lodge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Motel or related lodging.
    /// Encoded/decoded by serializers as &quot;MOTL&quot;.
    /// </summary>
    [EnumMember(Value = "MOTL")]
    [IsoId("_MEE9gUh5EfCMZJtj4J7UGQ")]
    [Description(@"Motel or related lodging.")]
    Motel = LodgingActivityCode.Motel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resort or related lodging.
    /// Encoded/decoded by serializers as &quot;RESO&quot;.
    /// </summary>
    [EnumMember(Value = "RESO")]
    [IsoId("_MEE9h0h5EfCMZJtj4J7UGQ")]
    [Description(@"Resort or related lodging.")]
    Resort = LodgingActivityCode.Resort, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Room and board or related lodging.
    /// Encoded/decoded by serializers as &quot;ROAB&quot;.
    /// </summary>
    [EnumMember(Value = "ROAB")]
    [IsoId("_MEE9iUh5EfCMZJtj4J7UGQ")]
    [Description(@"Room and board or related lodging.")]
    RoomAndBoard = LodgingActivityCode.RoomAndBoard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tourist shelter and related lodging.
    /// Encoded/decoded by serializers as &quot;TOSH&quot;.
    /// </summary>
    [EnumMember(Value = "TOSH")]
    [IsoId("_MEE9i0h5EfCMZJtj4J7UGQ")]
    [Description(@"Tourist shelter and related lodging.")]
    TouristShelter = LodgingActivityCode.TouristShelter, // same ordinal as derivation source for type conversions
}
