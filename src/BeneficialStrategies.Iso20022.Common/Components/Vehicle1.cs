// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a vehicle used during a transaction.
/// </summary>
[IsoId("_KI-4wJXyEeWMQt4mOczoDw")]
[DisplayName("Vehicle")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Vehicle1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Number assigned to the vehicle for identification.
    /// </summary>
    [IsoId("_YNf8YJXyEeWMQt4mOczoDw")]
    [DisplayName("Vehicle Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VhclNb")]
    #endif
    [IsoXmlTag("VhclNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? VehicleNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VehicleNumber { get; init; } 
    #else
    public System.String? VehicleNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned to the vehicle trailer for identification.
    /// </summary>
    [IsoId("_b6qKoJXyEeWMQt4mOczoDw")]
    [DisplayName("Trailer Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrlrNb")]
    #endif
    [IsoXmlTag("TrlrNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? TrailerNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TrailerNumber { get; init; } 
    #else
    public System.String? TrailerNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Registration tag of the vehicle.
    /// </summary>
    [IsoId("_h6RjsJXyEeWMQt4mOczoDw")]
    [DisplayName("Vehicle Tag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VhclTag")]
    #endif
    [IsoXmlTag("VhclTag")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? VehicleTag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VehicleTag { get; init; } 
    #else
    public System.String? VehicleTag { get; set; } 
    #endif
    
    /// <summary>
    /// Entry mode of the registration tag.
    /// </summary>
    [IsoId("_mp2RMJXyEeWMQt4mOczoDw")]
    [DisplayName("Vehicle Tag Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VhclTagNtryMd")]
    #endif
    [IsoXmlTag("VhclTagNtryMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading5Code? VehicleTagEntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading5Code? VehicleTagEntryMode { get; init; } 
    #else
    public CardDataReading5Code? VehicleTagEntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the vehicle in the fleet.
    /// </summary>
    [IsoId("_pxuoIJXyEeWMQt4mOczoDw")]
    [DisplayName("Unit Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitNb")]
    #endif
    [IsoXmlTag("UnitNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? UnitNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UnitNumber { get; init; } 
    #else
    public System.String? UnitNumber { get; set; } 
    #endif
    
    /// <summary>
    /// True if the car is a replacement car.
    /// </summary>
    [IsoId("_vPMWYJXyEeWMQt4mOczoDw")]
    [DisplayName("Replacement Car")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RplcmntCar")]
    #endif
    [IsoXmlTag("RplcmntCar")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ReplacementCar { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReplacementCar { get; init; } 
    #else
    public System.String? ReplacementCar { get; set; } 
    #endif
    
    /// <summary>
    /// Odometer reading value indicating the distance travelled by the vehicle.
    /// </summary>
    [IsoId("_yYGBAJXyEeWMQt4mOczoDw")]
    [DisplayName("Odometer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Odmtr")]
    #endif
    [IsoXmlTag("Odmtr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? Odometer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Odometer { get; init; } 
    #else
    public System.UInt64? Odometer { get; set; } 
    #endif
    
    /// <summary>
    /// Hubometer reading value indicating the distance travelled by the trailer.
    /// </summary>
    [IsoId("_4WJT0JXyEeWMQt4mOczoDw")]
    [DisplayName("Hubometer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hbmtr")]
    #endif
    [IsoXmlTag("Hbmtr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? Hubometer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Hubometer { get; init; } 
    #else
    public System.UInt64? Hubometer { get; set; } 
    #endif
    
    /// <summary>
    /// Number of hours the trailer has been in operation.
    /// </summary>
    [IsoId("_9SEbQJXyEeWMQt4mOczoDw")]
    [DisplayName("Trailer Hours")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrlrHrs")]
    #endif
    [IsoXmlTag("TrlrHrs")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TrailerHours { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TrailerHours { get; init; } 
    #else
    public System.String? TrailerHours { get; set; } 
    #endif
    
    /// <summary>
    /// Number of hours the refer unit has been in operation.
    /// </summary>
    [IsoId("_DUOyAJXzEeWMQt4mOczoDw")]
    [DisplayName("Refer Hours")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefrHrs")]
    #endif
    [IsoXmlTag("RefrHrs")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReferHours { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReferHours { get; init; } 
    #else
    public System.String? ReferHours { get; set; } 
    #endif
    
    /// <summary>
    /// Identification assigned to the vehicle related to maintenance.
    /// </summary>
    [IsoId("_GenqYJXzEeWMQt4mOczoDw")]
    [DisplayName("Maintenance Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MntncId")]
    #endif
    [IsoXmlTag("MntncId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MaintenanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MaintenanceIdentification { get; init; } 
    #else
    public System.String? MaintenanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Second card presented for the payment transaction.
    /// </summary>
    [IsoId("_sO5mkJbhEeW6aPG6p-lhQQ")]
    [DisplayName("Driver Or Vehicle Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrvrOrVhclCard")]
    #endif
    [IsoXmlTag("DrvrOrVhclCard")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlainCardData17? DriverOrVehicleCard { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlainCardData17? DriverOrVehicleCard { get; init; } 
    #else
    public PlainCardData17? DriverOrVehicleCard { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the vehicle.
    /// </summary>
    [IsoId("_ww05oJbhEeW6aPG6p-lhQQ")]
    [DisplayName("Additional Vehicle Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlVhclData")]
    #endif
    [IsoXmlTag("AddtlVhclData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Vehicle2? AdditionalVehicleData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Vehicle2? AdditionalVehicleData { get; init; } 
    #else
    public Vehicle2? AdditionalVehicleData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
