// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Car rental service in addition to main car rental.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_npzGUVN8EfC0lMwgjvMClw")]
[Description(@"Car rental service in addition to main car rental.")]
[DerivedFrom(typeof(CarRentalServiceTypeCode))]
public enum CarRentalServiceType3Code
{
    /// <summary>
    /// Rental amount adjustment.
    /// Encoded/decoded by serializers as &quot;ADJM&quot;.
    /// </summary>
    [EnumMember(Value = "ADJM")]
    [IsoId("_nsX5MVN8EfC0lMwgjvMClw")]
    [Description(@"Rental amount adjustment.")]
    Adjustment = CarRentalServiceTypeCode.Adjustment,

    /// <summary>
    /// Authorised amount.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_nsX5M1N8EfC0lMwgjvMClw")]
    [Description(@"Authorised amount.")]
    Authorised = CarRentalServiceTypeCode.Authorised,

    /// <summary>
    /// Baby seat.
    /// Encoded/decoded by serializers as &quot;BAST&quot;.
    /// </summary>
    [EnumMember(Value = "BAST")]
    [IsoId("_nsX5NVN8EfC0lMwgjvMClw")]
    [Description(@"Baby seat.")]
    BabySeat = CarRentalServiceTypeCode.BabySeat,

    /// <summary>
    /// Extra charges due to the need to clean the car.
    /// Encoded/decoded by serializers as &quot;CLEA&quot;.
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_nsX5N1N8EfC0lMwgjvMClw")]
    [Description(@"Extra charges due to the need to clean the car.")]
    Cleaning = CarRentalServiceTypeCode.Cleaning,

    /// <summary>
    /// Charge for delivery of rental vehicle.
    /// Encoded/decoded by serializers as &quot;DLVR&quot;.
    /// </summary>
    [EnumMember(Value = "DLVR")]
    [IsoId("_nsX5O1N8EfC0lMwgjvMClw")]
    [Description(@"Charge for delivery of rental vehicle.")]
    Delivery = CarRentalServiceTypeCode.Delivery,

    /// <summary>
    /// Charge for damages.
    /// Encoded/decoded by serializers as &quot;DMGS&quot;.
    /// </summary>
    [EnumMember(Value = "DMGS")]
    [IsoId("_nsX5OVN8EfC0lMwgjvMClw")]
    [Description(@"Charge for damages.")]
    Damage = CarRentalServiceTypeCode.Damage,

    /// <summary>
    /// Drop off charges.
    /// Encoded/decoded by serializers as &quot;DPOF&quot;.
    /// </summary>
    [EnumMember(Value = "DPOF")]
    [IsoId("_nsX5PVN8EfC0lMwgjvMClw")]
    [Description(@"Drop off charges.")]
    DropOff = CarRentalServiceTypeCode.DropOff,

    /// <summary>
    /// Entertainment.
    /// Encoded/decoded by serializers as &quot;ENTE&quot;.
    /// </summary>
    [EnumMember(Value = "ENTE")]
    [IsoId("_nsX5P1N8EfC0lMwgjvMClw")]
    [Description(@"Entertainment.")]
    Entertainment = CarRentalServiceTypeCode.Entertainment,

    /// <summary>
    /// Charges for additional distance.
    /// Encoded/decoded by serializers as &quot;EXDI&quot;.
    /// </summary>
    [EnumMember(Value = "EXDI")]
    [IsoId("_nsX5RVN8EfC0lMwgjvMClw")]
    [Description(@"Charges for additional distance.")]
    ExtraDistance = CarRentalServiceTypeCode.ExtraDistance,

    /// <summary>
    /// Charges for extra days.
    /// Encoded/decoded by serializers as &quot;EXDY&quot;.
    /// </summary>
    [EnumMember(Value = "EXDY")]
    [IsoId("_nsX5Q1N8EfC0lMwgjvMClw")]
    [Description(@"Charges for extra days.")]
    ExtraDays = CarRentalServiceTypeCode.ExtraDays,

    /// <summary>
    /// Charges for extra hours.
    /// Encoded/decoded by serializers as &quot;EXHR&quot;.
    /// </summary>
    [EnumMember(Value = "EXHR")]
    [IsoId("_nsX5R1N8EfC0lMwgjvMClw")]
    [Description(@"Charges for extra hours.")]
    ExtraHours = CarRentalServiceTypeCode.ExtraHours,

    /// <summary>
    /// Extra charges.
    /// Encoded/decoded by serializers as &quot;EXTC&quot;.
    /// </summary>
    [EnumMember(Value = "EXTC")]
    [IsoId("_nsX5QVN8EfC0lMwgjvMClw")]
    [Description(@"Extra charges.")]
    ExtraCharges = CarRentalServiceTypeCode.ExtraCharges,

    /// <summary>
    /// Charges for Extra miles or kilometers.
    /// Encoded/decoded by serializers as &quot;EXTR&quot;.
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("_wNbUQVN8EfC0lMwgjvMClw")]
    [Description(@"Charges for Extra miles or kilometers.")]
    ExtraMileage = CarRentalServiceTypeCode.ExtraMileage,

    /// <summary>
    /// Police and related fines or violation fees reinvoiced by vehicle rental company.
    /// Encoded/decoded by serializers as &quot;FINE&quot;.
    /// </summary>
    [EnumMember(Value = "FINE")]
    [IsoId("_nsX5SVN8EfC0lMwgjvMClw")]
    [Description(@"Police and related fines or violation fees reinvoiced by vehicle rental company.")]
    Fines = CarRentalServiceTypeCode.Fines,

    /// <summary>
    /// Fuel.
    /// Encoded/decoded by serializers as &quot;FUEL&quot;.
    /// </summary>
    [EnumMember(Value = "FUEL")]
    [IsoId("_nsX5S1N8EfC0lMwgjvMClw")]
    [Description(@"Fuel.")]
    Fuel = CarRentalServiceTypeCode.Fuel,

    /// <summary>
    /// Garage.
    /// Encoded/decoded by serializers as &quot;GARA&quot;.
    /// </summary>
    [EnumMember(Value = "GARA")]
    [IsoId("_nsX5TVN8EfC0lMwgjvMClw")]
    [Description(@"Garage.")]
    Garage = CarRentalServiceTypeCode.Garage,

    /// <summary>
    /// Global Positioning System (GPS).
    /// Encoded/decoded by serializers as &quot;GPSY&quot;.
    /// </summary>
    [EnumMember(Value = "GPSY")]
    [IsoId("_nsX5T1N8EfC0lMwgjvMClw")]
    [Description(@"Global Positioning System (GPS).")]
    GlobalPositioningSystem = CarRentalServiceTypeCode.GlobalPositioningSystem,

    /// <summary>
    /// Insurance.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_nsX5UVN8EfC0lMwgjvMClw")]
    [Description(@"Insurance.")]
    Insurance = CarRentalServiceTypeCode.Insurance,

    /// <summary>
    /// On-board internet.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_6FhawVN8EfC0lMwgjvMClw")]
    [Description(@"On-board internet.")]
    Internet = CarRentalServiceTypeCode.Internet,

    /// <summary>
    /// Car returned late.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_nsX5U1N8EfC0lMwgjvMClw")]
    [Description(@"Car returned late.")]
    LateReturn = CarRentalServiceTypeCode.LateReturn,

    /// <summary>
    /// Charges for Loss Damage Insurance.
    /// Encoded/decoded by serializers as &quot;LDIN&quot;.
    /// </summary>
    [EnumMember(Value = "LDIN")]
    [IsoId("_nsX5V1N8EfC0lMwgjvMClw")]
    [Description(@"Charges for Loss Damage Insurance.")]
    LossDamageInsurance = CarRentalServiceTypeCode.LossDamageInsurance,

    /// <summary>
    /// Charges for liability insurance.
    /// Encoded/decoded by serializers as &quot;LIIN&quot;.
    /// </summary>
    [EnumMember(Value = "LIIN")]
    [IsoId("_nsX5VVN8EfC0lMwgjvMClw")]
    [Description(@"Charges for liability insurance.")]
    LiabilityInsurance = CarRentalServiceTypeCode.LiabilityInsurance,

    /// <summary>
    /// Miles or kilometers charges.
    /// Encoded/decoded by serializers as &quot;MILE&quot;.
    /// </summary>
    [EnumMember(Value = "MILE")]
    [IsoId("_286EAVN8EfC0lMwgjvMClw")]
    [Description(@"Miles or kilometers charges.")]
    Mileage = CarRentalServiceTypeCode.Mileage,

    /// <summary>
    /// Miscellaneous charges.
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_nsX5WVN8EfC0lMwgjvMClw")]
    [Description(@"Miscellaneous charges.")]
    Miscellaneous = CarRentalServiceTypeCode.Miscellaneous,

    /// <summary>
    /// Charges for navigation system.
    /// Encoded/decoded by serializers as &quot;NAVI&quot;.
    /// </summary>
    [EnumMember(Value = "NAVI")]
    [IsoId("_nsX5W1N8EfC0lMwgjvMClw")]
    [Description(@"Charges for navigation system.")]
    Navigation = CarRentalServiceTypeCode.Navigation,

    /// <summary>
    /// Customer no-show charges.
    /// Encoded/decoded by serializers as &quot;NOSH&quot;.
    /// </summary>
    [EnumMember(Value = "NOSH")]
    [IsoId("_nsX5XVN8EfC0lMwgjvMClw")]
    [Description(@"Customer no-show charges.")]
    NoShow = CarRentalServiceTypeCode.NoShow,

    /// <summary>
    /// Drop-off charges.
    /// Encoded/decoded by serializers as &quot;ONEW&quot;.
    /// </summary>
    [EnumMember(Value = "ONEW")]
    [IsoId("_nsX5X1N8EfC0lMwgjvMClw")]
    [Description(@"Drop-off charges.")]
    OneWay = CarRentalServiceTypeCode.OneWay,

    /// <summary>
    /// Parking charges.
    /// Encoded/decoded by serializers as &quot;PARK&quot;.
    /// </summary>
    [EnumMember(Value = "PARK")]
    [IsoId("_nsX5ZVN8EfC0lMwgjvMClw")]
    [Description(@"Parking charges.")]
    Parking = CarRentalServiceTypeCode.Parking,

    /// <summary>
    /// Personal Effects Insurance.
    /// Encoded/decoded by serializers as &quot;PFIN&quot;.
    /// </summary>
    [EnumMember(Value = "PFIN")]
    [IsoId("_nsX5aVN8EfC0lMwgjvMClw")]
    [Description(@"Personal Effects Insurance.")]
    PersonalEffectsInsurance = CarRentalServiceTypeCode.PersonalEffectsInsurance,

    /// <summary>
    /// On-board telephone service.
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_nsX5a1N8EfC0lMwgjvMClw")]
    [Description(@"On-board telephone service.")]
    Phone = CarRentalServiceTypeCode.Phone,

    /// <summary>
    /// Personal Accident Insurance.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_nsX5Z1N8EfC0lMwgjvMClw")]
    [Description(@"Personal Accident Insurance.")]
    PersonalAccidentInsurance = CarRentalServiceTypeCode.PersonalAccidentInsurance,

    /// <summary>
    /// Charges for regular distance.
    /// Encoded/decoded by serializers as &quot;REGD&quot;.
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_nsX5bVN8EfC0lMwgjvMClw")]
    [Description(@"Charges for regular distance.")]
    RegularDistance = CarRentalServiceTypeCode.RegularDistance,

    /// <summary>
    /// Extra charges due to smoking in the car.
    /// Encoded/decoded by serializers as &quot;SMOK&quot;.
    /// </summary>
    [EnumMember(Value = "SMOK")]
    [IsoId("_nsX5b1N8EfC0lMwgjvMClw")]
    [Description(@"Extra charges due to smoking in the car.")]
    Smoking = CarRentalServiceTypeCode.Smoking,

    /// <summary>
    /// Charges for tolls.
    /// Encoded/decoded by serializers as &quot;TOLL&quot;.
    /// </summary>
    [EnumMember(Value = "TOLL")]
    [IsoId("_nsX5cVN8EfC0lMwgjvMClw")]
    [Description(@"Charges for tolls.")]
    Tolls = CarRentalServiceTypeCode.Tolls,

    /// <summary>
    /// Extra charges due to car towing.
    /// Encoded/decoded by serializers as &quot;TOWI&quot;.
    /// </summary>
    [EnumMember(Value = "TOWI")]
    [IsoId("_nsX5c1N8EfC0lMwgjvMClw")]
    [Description(@"Extra charges due to car towing.")]
    Towing = CarRentalServiceTypeCode.Towing,

    /// <summary>
    /// Extra charges due to transportation by bus, coach, taxi, limousine, taxi, shuttle, etc.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_12SaMVN8EfC0lMwgjvMClw")]
    [Description(@"Extra charges due to transportation by bus, coach, taxi, limousine, taxi, shuttle, etc.")]
    Transportation = CarRentalServiceTypeCode.Transportation,
}
