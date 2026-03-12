// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data captured from on board diagnostic systems
/// </summary>
[IsoId("_9D_nY9kGEeizh_fAW7LywQ")]
[DisplayName("On Board Diagnostics")]
public partial record OnBoardDiagnostics1
{
    #nullable enable
    
    /// <summary>
    /// Current amount of time the vehicle engine has run idle (under no load) as determined by the vehicle monitoring system. 
    /// Expressed in hours
    /// </summary>
    [IsoId("_u84Q0NkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Idle Time")]
    [IsoXmlTag("NgnIdleTm")]
    [IsoSimpleType(IsoSimpleType.Max10NumberFraction2)]
    public IsoMax10NumberFraction2? EngineIdleTime { get; init; } 
    
    /// <summary>
    /// Total amount of time the vehicle engine has run idle (under no load) since the last reset, as determined by the vehicle monitoring system.
    /// Expressed in hours
    /// </summary>
    [IsoId("_wPuYwNkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Total Idle Time")]
    [IsoXmlTag("NgnTtlIdleTm")]
    [IsoSimpleType(IsoSimpleType.Max10NumberFraction2)]
    public IsoMax10NumberFraction2? EngineTotalIdleTime { get; init; } 
    
    /// <summary>
    /// Number of hours the engine has been running (including idle time) as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_R21uwNkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Hours")]
    [IsoXmlTag("NgnHrs")]
    [IsoSimpleType(IsoSimpleType.Max10NumberFraction2)]
    public IsoMax10NumberFraction2? EngineHours { get; init; } 
    
    /// <summary>
    /// Amount of time elapsed since the previous reset as determined by the vehicle monitoring system.
    /// Expressed in hours
    /// </summary>
    [IsoId("_qG2WANkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Total Time")]
    [IsoXmlTag("NgnTtlTm")]
    [IsoSimpleType(IsoSimpleType.Max6NumberFraction2)]
    public IsoMax6NumberFraction2? EngineTotalTime { get; init; } 
    
    /// <summary>
    /// Engine load measured as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_mjVzANkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Load")]
    [IsoXmlTag("NgnLd")]
    [IsoSimpleType(IsoSimpleType.Max12NumericText)]
    public IsoMax12NumericText? EngineLoad { get; init; } 
    
    /// <summary>
    /// Maximum revolutions per minute experienced by the crankshaft of the vehicle engine as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_kxxuwNkIEeizh_fAW7LywQ")]
    [DisplayName("Engine RPM")]
    [IsoXmlTag("NgnRPM")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? EngineRPM { get; init; } 
    
    /// <summary>
    /// Temperature of the engine oil as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_oVyBANkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Oil Temperature")]
    [IsoXmlTag("NgnOilTmprtr")]
    [IsoSimpleType(IsoSimpleType.Max6NumberFraction2)]
    public IsoMax6NumberFraction2? EngineOilTemperature { get; init; } 
    
    /// <summary>
    /// Pressure of the engine oil as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_x5PUQNkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Oil Pressure")]
    [IsoXmlTag("NgnOilPrssr")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? EngineOilPressure { get; init; } 
    
    /// <summary>
    /// Time remaining before next oil change expressed as a percentage, as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_z4z_UNkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Oil Life Remaining")]
    [IsoXmlTag("NgnOilLifeRmng")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? EngineOilLifeRemaining { get; init; } 
    
    /// <summary>
    /// Check engine status as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_h77jANkIEeizh_fAW7LywQ")]
    [DisplayName("Check Engine Warning Status")]
    [IsoXmlTag("ChckNgnWrngSts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CheckEngineWarningStatus { get; init; } 
    
    /// <summary>
    /// Fuel tank start level reading as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_TvYkwNkIEeizh_fAW7LywQ")]
    [DisplayName("Fuel Tank Level Start")]
    [IsoXmlTag("FuelTankLvlStart")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? FuelTankLevelStart { get; init; } 
    
    /// <summary>
    /// Current fuel tank gauge level reading as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_Vz3lANkIEeizh_fAW7LywQ")]
    [DisplayName("Fuel Gauge Level")]
    [IsoXmlTag("FuelGaugeLvl")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? FuelGaugeLevel { get; init; } 
    
    /// <summary>
    /// Fuel economy expressed in terms of the amount of fuel consumed per unit of travel as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_jYVPkNkIEeizh_fAW7LywQ")]
    [DisplayName("Fuel Economy")]
    [IsoXmlTag("FuelEcnmy")]
    [IsoSimpleType(IsoSimpleType.Max6NumberFraction2)]
    public IsoMax6NumberFraction2? FuelEconomy { get; init; } 
    
    /// <summary>
    /// Number of hours the refrigeration unit has been in operation.
    /// </summary>
    [IsoId("_0T3D8f2kEeiS2rs-hXBB5Q")]
    [DisplayName("Refrigeration Hours")]
    [IsoXmlTag("RfrgrtnHrs")]
    [IsoSimpleType(IsoSimpleType.Max10NumberFraction2)]
    public IsoMax10NumberFraction2? RefrigerationHours { get; init; } 
    
    /// <summary>
    /// Temperature of the refrigeration unit/trailer as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_OTQTQNkIEeizh_fAW7LywQ")]
    [DisplayName("Refrigeration Temperature")]
    [IsoXmlTag("RfrgrtnTmprtr")]
    [IsoSimpleType(IsoSimpleType.Max6NumberFraction2)]
    public IsoMax6NumberFraction2? RefrigerationTemperature { get; init; } 
    
    /// <summary>
    /// Temperature of the coolant as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_Z8DiYNkIEeizh_fAW7LywQ")]
    [DisplayName("Coolant Temperature")]
    [IsoXmlTag("CoolntTmprtr")]
    [IsoSimpleType(IsoSimpleType.Max6NumberFraction2)]
    public IsoMax6NumberFraction2? CoolantTemperature { get; init; } 
    
    /// <summary>
    /// Voltage of the vehicle battery as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_YdD00NkIEeizh_fAW7LywQ")]
    [DisplayName("Battery Voltage")]
    [IsoXmlTag("BttryVltg")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? BatteryVoltage { get; init; } 
    
    /// <summary>
    /// Number of occurrences of hard breaking as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_r8khgNkIEeizh_fAW7LywQ")]
    [DisplayName("Hard Braking")]
    [IsoXmlTag("HardBrakg")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? HardBraking { get; init; } 
    
    /// <summary>
    /// Number of occurrences of hard acceleration as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_tgqxgNkIEeizh_fAW7LywQ")]
    [DisplayName("Hard Acceleration")]
    [IsoXmlTag("HardAcclrtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? HardAcceleration { get; init; } 
    
    
    #nullable disable
    
}
