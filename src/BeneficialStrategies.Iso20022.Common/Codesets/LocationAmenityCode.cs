// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Codes pertaining to the amenities available at the location where the merchant actually performed the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_F9w-Hfi8EeiJaN6-Lf-c_w")]
[Description(@"Codes pertaining to the amenities available at the location where the merchant actually performed the transaction.")]
[Derivations(typeof(LocationAmenity1Code))]
public enum LocationAmenityCode
{
    /// <summary>
    /// Truck stop with showers available
    /// Encoded/decoded by serializers as &quot;TSSA&quot;.
    /// </summary>
    [EnumMember(Value = "TSSA")]
    [IsoId("_F9xlIfi8EeiJaN6-Lf-c_w")]
    [Description(@"Truck stop with showers available")]
    TruckStopWithShowersAvailable,
    
    /// <summary>
    /// Truck Stop Hotel Available
    /// Encoded/decoded by serializers as &quot;TSHA&quot;.
    /// </summary>
    [EnumMember(Value = "TSHA")]
    [IsoId("_F9xlJ_i8EeiJaN6-Lf-c_w")]
    [Description(@"Truck Stop Hotel Available")]
    TruckStopHotelAvailable,
    
    /// <summary>
    /// Vehicle parking available
    /// Encoded/decoded by serializers as &quot;VHPA&quot;.
    /// </summary>
    [EnumMember(Value = "VHPA")]
    [IsoId("_F9xlI_i8EeiJaN6-Lf-c_w")]
    [Description(@"Vehicle parking available")]
    VehicleParking,
    
    /// <summary>
    /// Marina locations available
    /// Encoded/decoded by serializers as &quot;MRLA&quot;.
    /// </summary>
    [EnumMember(Value = "MRLA")]
    [IsoId("_F9xlKvi8EeiJaN6-Lf-c_w")]
    [Description(@"Marina locations available")]
    MarinaLocationsAvailable,
    
    /// <summary>
    /// Vehicle maintenance/repair bays available
    /// Encoded/decoded by serializers as &quot;VMRA&quot;.
    /// </summary>
    [EnumMember(Value = "VMRA")]
    [IsoId("_F9xlJvi8EeiJaN6-Lf-c_w")]
    [Description(@"Vehicle maintenance/repair bays available")]
    VehicleMaintenanceRepairBaysAvailable,
    
    /// <summary>
    /// Car wash available
    /// Encoded/decoded by serializers as &quot;CRWA&quot;.
    /// </summary>
    [EnumMember(Value = "CRWA")]
    [IsoId("_F9xlJfi8EeiJaN6-Lf-c_w")]
    [Description(@"Car wash available")]
    CarWashAvailable,
    
    /// <summary>
    /// Aviation locations available
    /// Encoded/decoded by serializers as &quot;AVLA&quot;.
    /// </summary>
    [EnumMember(Value = "AVLA")]
    [IsoId("_F9xlKfi8EeiJaN6-Lf-c_w")]
    [Description(@"Aviation locations available")]
    AviationLocationsAvailable,
    
    /// <summary>
    /// Pay-at-pump available
    /// Encoded/decoded by serializers as &quot;PAPA&quot;.
    /// </summary>
    [EnumMember(Value = "PAPA")]
    [IsoId("_F9xlKPi8EeiJaN6-Lf-c_w")]
    [Description(@"Pay-at-pump available")]
    PayAtPumpAvailable,
    
    /// <summary>
    /// Alternative fuel locations available
    /// Encoded/decoded by serializers as &quot;AFLA&quot;.
    /// </summary>
    [EnumMember(Value = "AFLA")]
    [IsoId("_F9xlIvi8EeiJaN6-Lf-c_w")]
    [Description(@"Alternative fuel locations available")]
    AlternativeFuelLocationsAvailable,
    
    /// <summary>
    /// Vehicle scales and weigh services available
    /// Encoded/decoded by serializers as &quot;VSWA&quot;.
    /// </summary>
    [EnumMember(Value = "VSWA")]
    [IsoId("_F9xlIPi8EeiJaN6-Lf-c_w")]
    [Description(@"Vehicle scales and weigh services available")]
    VehicleScalesWeight,
    
    /// <summary>
    /// Other amenities defined at the national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_F9xlK_i8EeiJaN6-Lf-c_w")]
    [Description(@"Other amenities defined at the national level.")]
    OtherNational,
    
    /// <summary>
    /// Other amenities defined at the private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_F9xlJPi8EeiJaN6-Lf-c_w")]
    [Description(@"Other amenities defined at the private level.")]
    OtherPrivate,
    
    /// <summary>
    /// 24 hour availability
    /// Encoded/decoded by serializers as &quot;TFHA&quot;.
    /// </summary>
    [EnumMember(Value = "TFHA")]
    [IsoId("_ooVfsPi8EeiJaN6-Lf-c_w")]
    [Description(@"24 hour availability")]
    TwentyFourHourAvailablity,
    
    /// <summary>
    /// 18-wheeler access availability
    /// Encoded/decoded by serializers as &quot;EWAA&quot;.
    /// </summary>
    [EnumMember(Value = "EWAA")]
    [IsoId("_or6_MPi8EeiJaN6-Lf-c_w")]
    [Description(@"18-wheeler access availability")]
    EighteenWheelAccessAvailable,
    
    /// <summary>
    /// Diesel Sites Available
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_ovyykPi8EeiJaN6-Lf-c_w")]
    [Description(@"Diesel Sites Available")]
    DieselSitesAvailable,
    
    /// <summary>
    /// Interstate Access and Exit Number information with directions Available
    /// Encoded/decoded by serializers as &quot;AADA&quot;.
    /// </summary>
    [EnumMember(Value = "AADA")]
    [IsoId("_ozhcAPi8EeiJaN6-Lf-c_w")]
    [Description(@"Interstate Access and Exit Number information with directions Available")]
    AccessAndDirectionsAvailable,
    
    /// <summary>
    /// Convenience Store Available
    /// Encoded/decoded by serializers as &quot;CVSA&quot;.
    /// </summary>
    [EnumMember(Value = "CVSA")]
    [IsoId("_o3QFcPi8EeiJaN6-Lf-c_w")]
    [Description(@"Convenience Store Available")]
    ConvenienceStoreAvailable,
    
    /// <summary>
    /// Truck Stop Restaurant Available
    /// Encoded/decoded by serializers as &quot;TSRA&quot;.
    /// </summary>
    [EnumMember(Value = "TSRA")]
    [IsoId("_o7aMsPi8EeiJaN6-Lf-c_w")]
    [Description(@"Truck Stop Restaurant Available")]
    TruckStopRestaurantAvailable,
    
}
