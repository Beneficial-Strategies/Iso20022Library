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
/// Attributes of a fleet vehicle.
/// </summary>
[IsoId("_EQmW3_iqEeiJaN6-Lf-c_w")]
[DisplayName("Vehicle")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Vehicle5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification number assigned to the vehicle by the fleet operator. This may not be a legal registration.
    /// </summary>
    [IsoId("_EQmW4_iqEeiJaN6-Lf-c_w")]
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
    /// Number that uniquely identifies the vehicle as assigned by the vehicle manufacturer.
    /// </summary>
    [IsoId("_hiSvQPiqEeiJaN6-Lf-c_w")]
    [DisplayName("Vehicle Identification Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VhclIdNb")]
    #endif
    [IsoXmlTag("VhclIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? VehicleIdentificationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VehicleIdentificationNumber { get; init; } 
    #else
    public System.String? VehicleIdentificationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Fleet number.
    /// </summary>
    [IsoId("_mFyIkPiqEeiJaN6-Lf-c_w")]
    [DisplayName("Fleet Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FleetNb")]
    #endif
    [IsoXmlTag("FleetNb")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? FleetNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FleetNumber { get; init; } 
    #else
    public System.String? FleetNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Sub fleet number.
    /// </summary>
    [IsoId("_qP28UPiqEeiJaN6-Lf-c_w")]
    [DisplayName("Sub Fleet Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubFleetNb")]
    #endif
    [IsoXmlTag("SubFleetNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SubFleetNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubFleetNumber { get; init; } 
    #else
    public System.String? SubFleetNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the unit number of the vehicle in the fleet.
    /// </summary>
    [IsoId("_EQmW5_iqEeiJaN6-Lf-c_w")]
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
    /// Identification number assigned to the trailer.
    /// </summary>
    [IsoId("_EQmW4PiqEeiJaN6-Lf-c_w")]
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
    [IsoId("_EQmW5fiqEeiJaN6-Lf-c_w")]
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
    [IsoId("_EQmW6viqEeiJaN6-Lf-c_w")]
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
    /// True indicates a replacement vehicle.
    /// </summary>
    [IsoId("_EQmW7fiqEeiJaN6-Lf-c_w")]
    [DisplayName("Replacement Vehicle Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RplcmntVhclInd")]
    #endif
    [IsoXmlTag("RplcmntVhclInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ReplacementVehicleIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReplacementVehicleIndicator { get; init; } 
    #else
    public System.String? ReplacementVehicleIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Odometer reading value indicating the distance travelled by the vehicle (for example, car, van, pickup truck, semi-truck portion of a tractor trailer unit).
    /// </summary>
    [IsoId("_EQmW5PiqEeiJaN6-Lf-c_w")]
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
    /// Hubometer reading value indicating the distance travelled by the trailer (for example,  the semi-trailer portion of a tractor trailer unit).
    /// </summary>
    [IsoId("_EQmW7PiqEeiJaN6-Lf-c_w")]
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
    /// Identification assigned to the vehicle related to maintenance.
    /// </summary>
    [IsoId("_EQmW6_iqEeiJaN6-Lf-c_w")]
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
    /// Data captured from on board diagnostic systems. 
    /// </summary>
    [IsoId("_EQmW4fiqEeiJaN6-Lf-c_w")]
    [DisplayName("On Board Diagnostics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnBrdDgnstcs")]
    #endif
    [IsoXmlTag("OnBrdDgnstcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OnBoardDiagnostics1? OnBoardDiagnostics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OnBoardDiagnostics1? OnBoardDiagnostics { get; init; } 
    #else
    public OnBoardDiagnostics1? OnBoardDiagnostics { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the vehicle.
    /// </summary>
    [IsoId("_EQmW6PiqEeiJaN6-Lf-c_w")]
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
