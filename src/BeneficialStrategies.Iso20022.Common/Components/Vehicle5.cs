// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of a fleet vehicle.
/// </summary>
[IsoId("_EQmW3_iqEeiJaN6-Lf-c_w")]
[DisplayName("Vehicle")]
public partial record Vehicle5
{
    #nullable enable
    
    /// <summary>
    /// Identification number assigned to the vehicle by the fleet operator. This may not be a legal registration.
    /// </summary>
    [IsoId("_EQmW4_iqEeiJaN6-Lf-c_w")]
    [DisplayName("Vehicle Number")]
    [IsoXmlTag("VhclNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? VehicleNumber { get; init; } 
    
    /// <summary>
    /// Number that uniquely identifies the vehicle as assigned by the vehicle manufacturer.
    /// </summary>
    [IsoId("_hiSvQPiqEeiJaN6-Lf-c_w")]
    [DisplayName("Vehicle Identification Number")]
    [IsoXmlTag("VhclIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? VehicleIdentificationNumber { get; init; } 
    
    /// <summary>
    /// Fleet number.
    /// </summary>
    [IsoId("_mFyIkPiqEeiJaN6-Lf-c_w")]
    [DisplayName("Fleet Number")]
    [IsoXmlTag("FleetNb")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    public IsoMax10Text? FleetNumber { get; init; } 
    
    /// <summary>
    /// Sub fleet number.
    /// </summary>
    [IsoId("_qP28UPiqEeiJaN6-Lf-c_w")]
    [DisplayName("Sub Fleet Number")]
    [IsoXmlTag("SubFleetNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SubFleetNumber { get; init; } 
    
    /// <summary>
    /// Identification of the unit number of the vehicle in the fleet.
    /// </summary>
    [IsoId("_EQmW5_iqEeiJaN6-Lf-c_w")]
    [DisplayName("Unit Number")]
    [IsoXmlTag("UnitNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? UnitNumber { get; init; } 
    
    /// <summary>
    /// Identification number assigned to the trailer.
    /// </summary>
    [IsoId("_EQmW4PiqEeiJaN6-Lf-c_w")]
    [DisplayName("Trailer Number")]
    [IsoXmlTag("TrlrNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? TrailerNumber { get; init; } 
    
    /// <summary>
    /// Registration tag of the vehicle.
    /// </summary>
    [IsoId("_EQmW5fiqEeiJaN6-Lf-c_w")]
    [DisplayName("Vehicle Tag")]
    [IsoXmlTag("VhclTag")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? VehicleTag { get; init; } 
    
    /// <summary>
    /// Entry mode of the registration tag.
    /// </summary>
    [IsoId("_EQmW6viqEeiJaN6-Lf-c_w")]
    [DisplayName("Vehicle Tag Entry Mode")]
    [IsoXmlTag("VhclTagNtryMd")]
    public CardDataReading5Code? VehicleTagEntryMode { get; init; } 
    
    /// <summary>
    /// True indicates a replacement vehicle.
    /// </summary>
    [IsoId("_EQmW7fiqEeiJaN6-Lf-c_w")]
    [DisplayName("Replacement Vehicle Indicator")]
    [IsoXmlTag("RplcmntVhclInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReplacementVehicleIndicator { get; init; } 
    
    /// <summary>
    /// Odometer reading value indicating the distance travelled by the vehicle (for example, car, van, pickup truck, semi-truck portion of a tractor trailer unit).
    /// </summary>
    [IsoId("_EQmW5PiqEeiJaN6-Lf-c_w")]
    [DisplayName("Odometer")]
    [IsoXmlTag("Odmtr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Odometer { get; init; } 
    
    /// <summary>
    /// Hubometer reading value indicating the distance travelled by the trailer (for example,  the semi-trailer portion of a tractor trailer unit).
    /// </summary>
    [IsoId("_EQmW7PiqEeiJaN6-Lf-c_w")]
    [DisplayName("Hubometer")]
    [IsoXmlTag("Hbmtr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Hubometer { get; init; } 
    
    /// <summary>
    /// Identification assigned to the vehicle related to maintenance.
    /// </summary>
    [IsoId("_EQmW6_iqEeiJaN6-Lf-c_w")]
    [DisplayName("Maintenance Identification")]
    [IsoXmlTag("MntncId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MaintenanceIdentification { get; init; } 
    
    /// <summary>
    /// Data captured from on board diagnostic systems. 
    /// </summary>
    [IsoId("_EQmW4fiqEeiJaN6-Lf-c_w")]
    [DisplayName("On Board Diagnostics")]
    [IsoXmlTag("OnBrdDgnstcs")]
    public OnBoardDiagnostics1? OnBoardDiagnostics { get; init; } 
    
    /// <summary>
    /// Additional information related to the vehicle.
    /// </summary>
    [IsoId("_EQmW6PiqEeiJaN6-Lf-c_w")]
    [DisplayName("Additional Vehicle Data")]
    [IsoXmlTag("AddtlVhclData")]
    public Vehicle2? AdditionalVehicleData { get; init; } 
    
    
    #nullable disable
    
}
