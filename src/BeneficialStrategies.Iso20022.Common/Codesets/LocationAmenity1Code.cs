// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Codes pertaining to the amenities available at the location where the merchant actually performed the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uGACoDEtEemzCpWiCwK4aQ")]
[Description(
    @"Codes pertaining to the amenities available at the location where the merchant actually performed the transaction."
)]
[DerivedFrom(typeof(LocationAmenityCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<LocationAmenity1Code>))]
#endif
public enum LocationAmenity1Code
{
    /// <summary>
    /// Interstate Access and Exit Number information with directions Available
    /// Encoded/decoded by serializers as &quot;AADA&quot;.
    /// </summary>
    [EnumMember(Value = "AADA")]
    [IsoId("_xUQuYTEtEemzCpWiCwK4aQ")]
    [Description(@"Interstate Access and Exit Number information with directions Available")]
    AccessAndDirectionsAvailable = LocationAmenityCode.AccessAndDirectionsAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Alternative fuel locations available
    /// Encoded/decoded by serializers as &quot;AFLA&quot;.
    /// </summary>
    [EnumMember(Value = "AFLA")]
    [IsoId("_xxnYwTEtEemzCpWiCwK4aQ")]
    [Description(@"Alternative fuel locations available")]
    AlternativeFuelLocationsAvailable = LocationAmenityCode.AlternativeFuelLocationsAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Aviation locations available
    /// Encoded/decoded by serializers as &quot;AVLA&quot;.
    /// </summary>
    [EnumMember(Value = "AVLA")]
    [IsoId("_yGdAUTEtEemzCpWiCwK4aQ")]
    [Description(@"Aviation locations available")]
    AviationLocationsAvailable = LocationAmenityCode.AviationLocationsAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Car wash available
    /// Encoded/decoded by serializers as &quot;CRWA&quot;.
    /// </summary>
    [EnumMember(Value = "CRWA")]
    [IsoId("_yc9b0TEtEemzCpWiCwK4aQ")]
    [Description(@"Car wash available")]
    CarWashAvailable = LocationAmenityCode.CarWashAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Convenience Store Available
    /// Encoded/decoded by serializers as &quot;CVSA&quot;.
    /// </summary>
    [EnumMember(Value = "CVSA")]
    [IsoId("_yyuQcTEtEemzCpWiCwK4aQ")]
    [Description(@"Convenience Store Available")]
    ConvenienceStoreAvailable = LocationAmenityCode.ConvenienceStoreAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Diesel Sites Available
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_zIoPATEtEemzCpWiCwK4aQ")]
    [Description(@"Diesel Sites Available")]
    DieselSitesAvailable = LocationAmenityCode.DieselSitesAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// 18-wheeler access availability
    /// Encoded/decoded by serializers as &quot;EWAA&quot;.
    /// </summary>
    [EnumMember(Value = "EWAA")]
    [IsoId("_zgeHQTEtEemzCpWiCwK4aQ")]
    [Description(@"18-wheeler access availability")]
    EighteenWheelAccessAvailable = LocationAmenityCode.EighteenWheelAccessAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Marina locations available
    /// Encoded/decoded by serializers as &quot;MRLA&quot;.
    /// </summary>
    [EnumMember(Value = "MRLA")]
    [IsoId("_zoOVETEtEemzCpWiCwK4aQ")]
    [Description(@"Marina locations available")]
    MarinaLocationsAvailable = LocationAmenityCode.MarinaLocationsAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other amenities defined at the national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_z3uJoTEtEemzCpWiCwK4aQ")]
    [Description(@"Other amenities defined at the national level.")]
    OtherNational = LocationAmenityCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other amenities defined at the private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_z9FKwTEtEemzCpWiCwK4aQ")]
    [Description(@"Other amenities defined at the private level.")]
    OtherPrivate = LocationAmenityCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pay-at-pump available
    /// Encoded/decoded by serializers as &quot;PAPA&quot;.
    /// </summary>
    [EnumMember(Value = "PAPA")]
    [IsoId("_0S_JUTEtEemzCpWiCwK4aQ")]
    [Description(@"Pay-at-pump available")]
    PayAtPumpAvailable = LocationAmenityCode.PayAtPumpAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Truck Stop Hotel Available
    /// Encoded/decoded by serializers as &quot;TSHA&quot;.
    /// </summary>
    [EnumMember(Value = "TSHA")]
    [IsoId("_0qr3oTEtEemzCpWiCwK4aQ")]
    [Description(@"Truck Stop Hotel Available")]
    TruckStopHotelAvailable = LocationAmenityCode.TruckStopHotelAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Truck Stop Restaurant Available
    /// Encoded/decoded by serializers as &quot;TSRA&quot;.
    /// </summary>
    [EnumMember(Value = "TSRA")]
    [IsoId("_1AAAUTEtEemzCpWiCwK4aQ")]
    [Description(@"Truck Stop Restaurant Available")]
    TruckStopRestaurantAvailable = LocationAmenityCode.TruckStopRestaurantAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Truck stop with showers available
    /// Encoded/decoded by serializers as &quot;TSSA&quot;.
    /// </summary>
    [EnumMember(Value = "TSSA")]
    [IsoId("_1GtFQTEtEemzCpWiCwK4aQ")]
    [Description(@"Truck stop with showers available")]
    TruckStopWithShowersAvailable = LocationAmenityCode.TruckStopWithShowersAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// 24 hour availability
    /// Encoded/decoded by serializers as &quot;TFHA&quot;.
    /// </summary>
    [EnumMember(Value = "TFHA")]
    [IsoId("_1arKITEtEemzCpWiCwK4aQ")]
    [Description(@"24 hour availability")]
    TwentyFourHourAvailablity = LocationAmenityCode.TwentyFourHourAvailablity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vehicle scales and weigh services available
    /// Encoded/decoded by serializers as &quot;VSWA&quot;.
    /// </summary>
    [EnumMember(Value = "VSWA")]
    [IsoId("_2OPVETEtEemzCpWiCwK4aQ")]
    [Description(@"Vehicle scales and weigh services available")]
    VehicleScalesWeight = LocationAmenityCode.VehicleScalesWeight, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vehicle parking available
    /// Encoded/decoded by serializers as &quot;VHPA&quot;.
    /// </summary>
    [EnumMember(Value = "VHPA")]
    [IsoId("_2ioQsTEtEemzCpWiCwK4aQ")]
    [Description(@"Vehicle parking available")]
    VehicleParking = LocationAmenityCode.VehicleParking, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vehicle maintenance/repair bays available
    /// Encoded/decoded by serializers as &quot;VMRA&quot;.
    /// </summary>
    [EnumMember(Value = "VMRA")]
    [IsoId("_24GKYTEtEemzCpWiCwK4aQ")]
    [Description(@"Vehicle maintenance/repair bays available")]
    VehicleMaintenanceRepairBaysAvailable =
        LocationAmenityCode.VehicleMaintenanceRepairBaysAvailable, // same ordinal as derivation source for type conversions
}
