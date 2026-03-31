// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Car rental service in addition to main car rental.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_q1VvAF1xEeeu75xdwwAXQw")]
[Description(@"Car rental service in addition to main car rental.")]
[Derivations(typeof(CarRentalServiceType2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CarRentalServiceTypeCode>))]
#endif
public enum CarRentalServiceTypeCode
{
    /// <summary>
    /// Baby seat.
    /// Encoded/decoded by serializers as &quot;BAST&quot;.
    /// </summary>
    [EnumMember(Value = "BAST")]
    [IsoId("_xFrrsF1xEeeu75xdwwAXQw")]
    [Description(@"Baby seat.")]
    BabySeat,

    /// <summary>
    /// Global Positioning System (GPS)
    /// Encoded/decoded by serializers as &quot;GPSY&quot;.
    /// </summary>
    [EnumMember(Value = "GPSY")]
    [IsoId("_0jzYYF1xEeeu75xdwwAXQw")]
    [Description(@"Global Positioning System (GPS)")]
    GlobalPositioningSystem,

    /// <summary>
    /// Entertainment
    /// Encoded/decoded by serializers as &quot;ENTE&quot;.
    /// </summary>
    [EnumMember(Value = "ENTE")]
    [IsoId("_7O7zoF1xEeeu75xdwwAXQw")]
    [Description(@"Entertainment")]
    Entertainment,

    /// <summary>
    /// Charges for Extra miles or kilometers.
    /// Encoded/decoded by serializers as &quot;EXTR&quot;.
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("__TSZ4F1xEeeu75xdwwAXQw")]
    [Description(@"Charges for Extra miles or kilometers.")]
    ExtraMileage,

    /// <summary>
    /// Garage
    /// Encoded/decoded by serializers as &quot;GARA&quot;.
    /// </summary>
    [EnumMember(Value = "GARA")]
    [IsoId("_C70m0F1yEeeu75xdwwAXQw")]
    [Description(@"Garage")]
    Garage,

    /// <summary>
    /// Fuel
    /// Encoded/decoded by serializers as &quot;FUEL&quot;.
    /// </summary>
    [EnumMember(Value = "FUEL")]
    [IsoId("_FoPw0F1yEeeu75xdwwAXQw")]
    [Description(@"Fuel")]
    Fuel,

    /// <summary>
    /// On-board internet.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_JfXMUF1yEeeu75xdwwAXQw")]
    [Description(@"On-board internet.")]
    Internet,

    /// <summary>
    /// Insurance
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_MX-_QF1yEeeu75xdwwAXQw")]
    [Description(@"Insurance")]
    Insurance,

    /// <summary>
    /// Drop-off charges.
    /// Encoded/decoded by serializers as &quot;ONEW&quot;.
    /// </summary>
    [EnumMember(Value = "ONEW")]
    [IsoId("_PuExUF1yEeeu75xdwwAXQw")]
    [Description(@"Drop-off charges.")]
    OneWay,

    /// <summary>
    /// Miles or kilometers charges.
    /// Encoded/decoded by serializers as &quot;MILE&quot;.
    /// </summary>
    [EnumMember(Value = "MILE")]
    [IsoId("_Sves0F1yEeeu75xdwwAXQw")]
    [Description(@"Miles or kilometers charges.")]
    Mileage,

    /// <summary>
    /// Customer no-show charges.
    /// Encoded/decoded by serializers as &quot;NOSH&quot;.
    /// </summary>
    [EnumMember(Value = "NOSH")]
    [IsoId("_ZIA8MF1yEeeu75xdwwAXQw")]
    [Description(@"Customer no-show charges.")]
    NoShow,

    /// <summary>
    /// Parking charges.
    /// Encoded/decoded by serializers as &quot;PARK&quot;.
    /// </summary>
    [EnumMember(Value = "PARK")]
    [IsoId("_d4GnEF1yEeeu75xdwwAXQw")]
    [Description(@"Parking charges.")]
    Parking,

    /// <summary>
    /// On-board telephone service.
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_hvg9gF1yEeeu75xdwwAXQw")]
    [Description(@"On-board telephone service.")]
    Phone,

    /// <summary>
    /// Service provided by a third party and invoiced by car rental company.
    /// Encoded/decoded by serializers as &quot;THPY&quot;.
    /// </summary>
    [EnumMember(Value = "THPY")]
    [IsoId("_l0KesF1yEeeu75xdwwAXQw")]
    [Description(@"Service provided by a third party and invoiced by car rental company.")]
    ThirdParty,

    /// <summary>
    /// Car returned late.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_r3kyoF1yEeeu75xdwwAXQw")]
    [Description(@"Car returned late.")]
    LateReturn,

    /// <summary>
    /// Extra charges due to car towing.
    /// Encoded/decoded by serializers as &quot;TOWI&quot;.
    /// </summary>
    [EnumMember(Value = "TOWI")]
    [IsoId("_3lZEoF1yEeeu75xdwwAXQw")]
    [Description(@"Extra charges due to car towing.")]
    Towing,

    /// <summary>
    /// Extra charges due to transportation by bus, coach, taxi, limousine, taxi, shuttle, etc.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_84HigF1yEeeu75xdwwAXQw")]
    [Description(
        @"Extra charges due to transportation by bus, coach, taxi, limousine, taxi, shuttle, etc."
    )]
    Transportation,

    /// <summary>
    /// Extra charges due to smoking in the car.
    /// Encoded/decoded by serializers as &quot;SMOK&quot;.
    /// </summary>
    [EnumMember(Value = "SMOK")]
    [IsoId("_HCtHMF1zEeeu75xdwwAXQw")]
    [Description(@"Extra charges due to smoking in the car.")]
    Smoking,

    /// <summary>
    /// Police and related fines or violation fees reinvoiced by vehicle rental company.
    /// Encoded/decoded by serializers as &quot;FINE&quot;.
    /// </summary>
    [EnumMember(Value = "FINE")]
    [IsoId("_MU3kYF1zEeeu75xdwwAXQw")]
    [Description(
        @"Police and related fines or violation fees reinvoiced by vehicle rental company."
    )]
    Fines,

    /// <summary>
    /// Extra charges due to the need to clean the car.
    /// Encoded/decoded by serializers as &quot;CLEA&quot;.
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_SubugF1zEeeu75xdwwAXQw")]
    [Description(@"Extra charges due to the need to clean the car.")]
    Cleaning,

    /// <summary>
    /// Other type of additional car rental charges.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_XKcm0F1zEeeu75xdwwAXQw")]
    [Description(@"Other type of additional car rental charges.")]
    Other,

    /// <summary>
    /// Rental amount adjustment
    /// Encoded/decoded by serializers as &quot;ADJM&quot;.
    /// </summary>
    [EnumMember(Value = "ADJM")]
    [IsoId("_226ikPS8Eeife6veM7daYw")]
    [Description(@"Rental amount adjustment")]
    Adjustment,

    /// <summary>
    /// Authorised amount
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_27jK8PS8Eeife6veM7daYw")]
    [Description(@"Authorised amount")]
    Authorised,

    /// <summary>
    /// Charge for damages
    /// Encoded/decoded by serializers as &quot;DMGS&quot;.
    /// </summary>
    [EnumMember(Value = "DMGS")]
    [IsoId("_29tHEPS8Eeife6veM7daYw")]
    [Description(@"Charge for damages")]
    Damage,

    /// <summary>
    /// Charge for delivery of rental vehicle
    /// Encoded/decoded by serializers as &quot;DLVR&quot;.
    /// </summary>
    [EnumMember(Value = "DLVR")]
    [IsoId("_2_ZwMPS8Eeife6veM7daYw")]
    [Description(@"Charge for delivery of rental vehicle")]
    Delivery,

    /// <summary>
    /// Drop off charges
    /// Encoded/decoded by serializers as &quot;DPOF&quot;.
    /// </summary>
    [EnumMember(Value = "DPOF")]
    [IsoId("_3BCu8PS8Eeife6veM7daYw")]
    [Description(@"Drop off charges")]
    DropOff,

    /// <summary>
    /// Extra charges
    /// Encoded/decoded by serializers as &quot;EXTC&quot;.
    /// </summary>
    [EnumMember(Value = "EXTC")]
    [IsoId("_3Cp4gPS8Eeife6veM7daYw")]
    [Description(@"Extra charges")]
    ExtraCharges,

    /// <summary>
    /// Charges for extra days
    /// Encoded/decoded by serializers as &quot;EXDY&quot;.
    /// </summary>
    [EnumMember(Value = "EXDY")]
    [IsoId("_3EY94PS8Eeife6veM7daYw")]
    [Description(@"Charges for extra days")]
    ExtraDays,

    /// <summary>
    /// Charges for additional distance
    /// Encoded/decoded by serializers as &quot;EXDI&quot;.
    /// </summary>
    [EnumMember(Value = "EXDI")]
    [IsoId("_3E7JYPS8Eeife6veM7daYw")]
    [Description(@"Charges for additional distance")]
    ExtraDistance,

    /// <summary>
    /// Charges for extra hours
    /// Encoded/decoded by serializers as &quot;EXHR&quot;.
    /// </summary>
    [EnumMember(Value = "EXHR")]
    [IsoId("_DCcrUPS9Eeife6veM7daYw")]
    [Description(@"Charges for extra hours")]
    ExtraHours,

    /// <summary>
    /// Charges for liability insurance
    /// Encoded/decoded by serializers as &quot;LIIN&quot;.
    /// </summary>
    [EnumMember(Value = "LIIN")]
    [IsoId("_DFZRoPS9Eeife6veM7daYw")]
    [Description(@"Charges for liability insurance")]
    LiabilityInsurance,

    /// <summary>
    /// Charges for Loss Damage Insurance
    /// Encoded/decoded by serializers as &quot;LDIN&quot;.
    /// </summary>
    [EnumMember(Value = "LDIN")]
    [IsoId("_DF95YPS9Eeife6veM7daYw")]
    [Description(@"Charges for Loss Damage Insurance")]
    LossDamageInsurance,

    /// <summary>
    /// Miscellaneous charges
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_DIMG8PS9Eeife6veM7daYw")]
    [Description(@"Miscellaneous charges")]
    Miscellaneous,

    /// <summary>
    /// Charges for navigation system
    /// Encoded/decoded by serializers as &quot;NAVI&quot;.
    /// </summary>
    [EnumMember(Value = "NAVI")]
    [IsoId("_DLD0wPS9Eeife6veM7daYw")]
    [Description(@"Charges for navigation system")]
    Navigation,

    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_R9B0QPS9Eeife6veM7daYw")]
    [Description(@"Other National")]
    OtherNational,

    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_X3kgEPS9Eeife6veM7daYw")]
    [Description(@"Other Private")]
    OtherPrivate,

    /// <summary>
    /// Personal Accident Insurance
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_X6aYsPS9Eeife6veM7daYw")]
    [Description(@"Personal Accident Insurance")]
    PersonalAccidentInsurance,

    /// <summary>
    /// Personal Effects Insurance
    /// Encoded/decoded by serializers as &quot;PFIN&quot;.
    /// </summary>
    [EnumMember(Value = "PFIN")]
    [IsoId("_X7A1oPS9Eeife6veM7daYw")]
    [Description(@"Personal Effects Insurance")]
    PersonalEffectsInsurance,

    /// <summary>
    /// Charges for regular distance
    /// Encoded/decoded by serializers as &quot;REGD&quot;.
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_xqWhoPS9Eeife6veM7daYw")]
    [Description(@"Charges for regular distance")]
    RegularDistance,

    /// <summary>
    /// Charges for tolls
    /// Encoded/decoded by serializers as &quot;TOLL&quot;.
    /// </summary>
    [EnumMember(Value = "TOLL")]
    [IsoId("_BxC4YPS-Eeife6veM7daYw")]
    [Description(@"Charges for tolls")]
    Tolls,
}
