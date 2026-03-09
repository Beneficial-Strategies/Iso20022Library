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
/// Data captured from on board diagnostic systems
/// </summary>
[IsoId("_9D_nY9kGEeizh_fAW7LywQ")]
[DisplayName("On Board Diagnostics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OnBoardDiagnostics1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Current amount of time the vehicle engine has run idle (under no load) as determined by the vehicle monitoring system. 
    /// Expressed in hours
    /// </summary>
    [IsoId("_u84Q0NkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Idle Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NgnIdleTm")]
    #endif
    [IsoXmlTag("NgnIdleTm")]
    [IsoSimpleType(IsoSimpleType.Max10NumberFraction2)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumberFraction2? EngineIdleTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? EngineIdleTime { get; init; } 
    #else
    public System.UInt64? EngineIdleTime { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of time the vehicle engine has run idle (under no load) since the last reset, as determined by the vehicle monitoring system.
    /// Expressed in hours
    /// </summary>
    [IsoId("_wPuYwNkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Total Idle Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NgnTtlIdleTm")]
    #endif
    [IsoXmlTag("NgnTtlIdleTm")]
    [IsoSimpleType(IsoSimpleType.Max10NumberFraction2)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumberFraction2? EngineTotalIdleTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? EngineTotalIdleTime { get; init; } 
    #else
    public System.UInt64? EngineTotalIdleTime { get; set; } 
    #endif
    
    /// <summary>
    /// Number of hours the engine has been running (including idle time) as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_R21uwNkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Hours")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NgnHrs")]
    #endif
    [IsoXmlTag("NgnHrs")]
    [IsoSimpleType(IsoSimpleType.Max10NumberFraction2)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumberFraction2? EngineHours { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? EngineHours { get; init; } 
    #else
    public System.UInt64? EngineHours { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of time elapsed since the previous reset as determined by the vehicle monitoring system.
    /// Expressed in hours
    /// </summary>
    [IsoId("_qG2WANkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Total Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NgnTtlTm")]
    #endif
    [IsoXmlTag("NgnTtlTm")]
    [IsoSimpleType(IsoSimpleType.Max6NumberFraction2)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax6NumberFraction2? EngineTotalTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? EngineTotalTime { get; init; } 
    #else
    public System.UInt64? EngineTotalTime { get; set; } 
    #endif
    
    /// <summary>
    /// Engine load measured as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_mjVzANkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Load")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NgnLd")]
    #endif
    [IsoXmlTag("NgnLd")]
    [IsoSimpleType(IsoSimpleType.Max12NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax12NumericText? EngineLoad { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EngineLoad { get; init; } 
    #else
    public System.String? EngineLoad { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum revolutions per minute experienced by the crankshaft of the vehicle engine as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_kxxuwNkIEeizh_fAW7LywQ")]
    [DisplayName("Engine RPM")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NgnRPM")]
    #endif
    [IsoXmlTag("NgnRPM")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5NumericText? EngineRPM { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EngineRPM { get; init; } 
    #else
    public System.String? EngineRPM { get; set; } 
    #endif
    
    /// <summary>
    /// Temperature of the engine oil as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_oVyBANkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Oil Temperature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NgnOilTmprtr")]
    #endif
    [IsoXmlTag("NgnOilTmprtr")]
    [IsoSimpleType(IsoSimpleType.Max6NumberFraction2)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax6NumberFraction2? EngineOilTemperature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? EngineOilTemperature { get; init; } 
    #else
    public System.UInt64? EngineOilTemperature { get; set; } 
    #endif
    
    /// <summary>
    /// Pressure of the engine oil as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_x5PUQNkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Oil Pressure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NgnOilPrssr")]
    #endif
    [IsoXmlTag("NgnOilPrssr")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? EngineOilPressure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EngineOilPressure { get; init; } 
    #else
    public System.String? EngineOilPressure { get; set; } 
    #endif
    
    /// <summary>
    /// Time remaining before next oil change expressed as a percentage, as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_z4z_UNkIEeizh_fAW7LywQ")]
    [DisplayName("Engine Oil Life Remaining")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NgnOilLifeRmng")]
    #endif
    [IsoXmlTag("NgnOilLifeRmng")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? EngineOilLifeRemaining { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EngineOilLifeRemaining { get; init; } 
    #else
    public System.String? EngineOilLifeRemaining { get; set; } 
    #endif
    
    /// <summary>
    /// Check engine status as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_h77jANkIEeizh_fAW7LywQ")]
    [DisplayName("Check Engine Warning Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckNgnWrngSts")]
    #endif
    [IsoXmlTag("ChckNgnWrngSts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CheckEngineWarningStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CheckEngineWarningStatus { get; init; } 
    #else
    public System.String? CheckEngineWarningStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Fuel tank start level reading as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_TvYkwNkIEeizh_fAW7LywQ")]
    [DisplayName("Fuel Tank Level Start")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FuelTankLvlStart")]
    #endif
    [IsoXmlTag("FuelTankLvlStart")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? FuelTankLevelStart { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FuelTankLevelStart { get; init; } 
    #else
    public System.String? FuelTankLevelStart { get; set; } 
    #endif
    
    /// <summary>
    /// Current fuel tank gauge level reading as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_Vz3lANkIEeizh_fAW7LywQ")]
    [DisplayName("Fuel Gauge Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FuelGaugeLvl")]
    #endif
    [IsoXmlTag("FuelGaugeLvl")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? FuelGaugeLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FuelGaugeLevel { get; init; } 
    #else
    public System.String? FuelGaugeLevel { get; set; } 
    #endif
    
    /// <summary>
    /// Fuel economy expressed in terms of the amount of fuel consumed per unit of travel as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_jYVPkNkIEeizh_fAW7LywQ")]
    [DisplayName("Fuel Economy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FuelEcnmy")]
    #endif
    [IsoXmlTag("FuelEcnmy")]
    [IsoSimpleType(IsoSimpleType.Max6NumberFraction2)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax6NumberFraction2? FuelEconomy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? FuelEconomy { get; init; } 
    #else
    public System.UInt64? FuelEconomy { get; set; } 
    #endif
    
    /// <summary>
    /// Number of hours the refrigeration unit has been in operation.
    /// </summary>
    [IsoId("_0T3D8f2kEeiS2rs-hXBB5Q")]
    [DisplayName("Refrigeration Hours")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RfrgrtnHrs")]
    #endif
    [IsoXmlTag("RfrgrtnHrs")]
    [IsoSimpleType(IsoSimpleType.Max10NumberFraction2)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumberFraction2? RefrigerationHours { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RefrigerationHours { get; init; } 
    #else
    public System.UInt64? RefrigerationHours { get; set; } 
    #endif
    
    /// <summary>
    /// Temperature of the refrigeration unit/trailer as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_OTQTQNkIEeizh_fAW7LywQ")]
    [DisplayName("Refrigeration Temperature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RfrgrtnTmprtr")]
    #endif
    [IsoXmlTag("RfrgrtnTmprtr")]
    [IsoSimpleType(IsoSimpleType.Max6NumberFraction2)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax6NumberFraction2? RefrigerationTemperature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RefrigerationTemperature { get; init; } 
    #else
    public System.UInt64? RefrigerationTemperature { get; set; } 
    #endif
    
    /// <summary>
    /// Temperature of the coolant as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_Z8DiYNkIEeizh_fAW7LywQ")]
    [DisplayName("Coolant Temperature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CoolntTmprtr")]
    #endif
    [IsoXmlTag("CoolntTmprtr")]
    [IsoSimpleType(IsoSimpleType.Max6NumberFraction2)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax6NumberFraction2? CoolantTemperature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? CoolantTemperature { get; init; } 
    #else
    public System.UInt64? CoolantTemperature { get; set; } 
    #endif
    
    /// <summary>
    /// Voltage of the vehicle battery as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_YdD00NkIEeizh_fAW7LywQ")]
    [DisplayName("Battery Voltage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BttryVltg")]
    #endif
    [IsoXmlTag("BttryVltg")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? BatteryVoltage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BatteryVoltage { get; init; } 
    #else
    public System.String? BatteryVoltage { get; set; } 
    #endif
    
    /// <summary>
    /// Number of occurrences of hard breaking as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_r8khgNkIEeizh_fAW7LywQ")]
    [DisplayName("Hard Braking")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HardBrakg")]
    #endif
    [IsoXmlTag("HardBrakg")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? HardBraking { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HardBraking { get; init; } 
    #else
    public System.String? HardBraking { get; set; } 
    #endif
    
    /// <summary>
    /// Number of occurrences of hard acceleration as determined by the vehicle monitoring system.
    /// </summary>
    [IsoId("_tgqxgNkIEeizh_fAW7LywQ")]
    [DisplayName("Hard Acceleration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HardAcclrtn")]
    #endif
    [IsoXmlTag("HardAcclrtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? HardAcceleration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HardAcceleration { get; init; } 
    #else
    public System.String? HardAcceleration { get; set; } 
    #endif
    
    
    #nullable disable
    
}
